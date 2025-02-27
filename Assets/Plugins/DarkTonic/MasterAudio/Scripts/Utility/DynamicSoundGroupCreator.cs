using System.Collections.Generic;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace DarkTonic.MasterAudio {
    /// <summary>
    /// This class is used to configure and create temporary per-Scene Sound Groups and Buses
    /// </summary>
    [AudioScriptOrder(-35)]
    // ReSharper disable once CheckNamespace
    public class DynamicSoundGroupCreator : MonoBehaviour {
        /*! \cond PRIVATE */
        public const int ExtraHardCodedBusOptions = 1;

        // ReSharper disable InconsistentNaming
        public SystemLanguage previewLanguage = SystemLanguage.English;
        public MasterAudio.DragGroupMode curDragGroupMode = MasterAudio.DragGroupMode.OneGroupPerClip;
        public GameObject groupTemplate;
        public GameObject variationTemplate;
        public bool errorOnDuplicates = false;
        public bool createOnAwake = true;
        public bool soundGroupsAreExpanded = true;
        public bool removeGroupsOnSceneChange = true;
        public CreateItemsWhen reUseMode = CreateItemsWhen.FirstEnableOnly;
        public bool showCustomEvents = true;
        public MasterAudio.AudioLocation bulkVariationMode = MasterAudio.AudioLocation.Clip;
        public List<CustomEvent> customEventsToCreate = new List<CustomEvent>();
		public List<CustomEventCategory> customEventCategories = new List<CustomEventCategory> {
			new CustomEventCategory()
		};
		public string newEventName = "my event";
		public string newCustomEventCategoryName = "New Category";
		public string addToCustomEventCategoryName = "New Category";
		public bool showMusicDucking = true;
        public List<DuckGroupInfo> musicDuckingSounds = new List<DuckGroupInfo>();
        public List<GroupBus> groupBuses = new List<GroupBus>();
        public bool playListExpanded = false;
        public bool playlistEditorExp = true;
        public List<MasterAudio.Playlist> musicPlaylists = new List<MasterAudio.Playlist>();
        public List<GameObject> audioSourceTemplates = new List<GameObject>(10);
        public string audioSourceTemplateName = "Max Distance 500";
        public bool groupByBus = false;

        public bool showRTPC = false;
        public bool showParameterManagement = true;
        public List<RealTimeParameter> realTimeParameters = new List<RealTimeParameter>();
        public bool showParameterCommands = false;
        public bool showParameterCommandGizmo = false;
        public List<ParameterCommand> parameterCommands = new List<ParameterCommand>();
        public ParameterCommandElement parameterCommandToGizmo = null;

        public bool itemsCreatedEventExpanded = false;
        public string itemsCreatedCustomEvent = string.Empty;

        public bool showUnityMixerGroupAssignment = true;
        // ReSharper restore InconsistentNaming

        private bool _hasCreated;
        private readonly List<Transform> _groupsToRemove = new List<Transform>();
        private Transform _trans;
        private int _instanceId = -1;

        public enum CreateItemsWhen {
            FirstEnableOnly,
            EveryEnable
        }
        /*! \endcond */

        private readonly List<DynamicSoundGroup> _groupsToCreate = new List<DynamicSoundGroup>();

        // ReSharper disable once UnusedMember.Local
        private void Awake() {
            _trans = transform;
            _hasCreated = false;
            var aud = GetComponent<AudioSource>();
            if (aud != null) {
                Destroy(aud);
            }
        }

        // ReSharper disable once UnusedMember.Local
        private void OnEnable() {
            CreateItemsIfReady(); // create in Enable event if it's all ready
        }

        // ReSharper disable once UnusedMember.Local
        private void Start() {
            CreateItemsIfReady(); // if it wasn't ready in Enable, create everything in Start
        }

        // ReSharper disable once UnusedMember.Local
        private void OnDisable() {
            if (MasterAudio.AppIsShuttingDown) {
                return;
            }

            // scene changing
            if (!removeGroupsOnSceneChange) {
                // nothing to do.
                return;
            }

            if (MasterAudio.SafeInstance != null) {
                RemoveItems();
            }
        }

        private void OnDrawGizmos() {
            if (MasterAudio.SafeInstance == null || !MasterAudio.Instance.showRangeSoundGizmos || !showParameterCommandGizmo || parameterCommandToGizmo == null) {
                return;
            }

            if (parameterCommandToGizmo.ColliderMaxDistance == 0f) {
                return;
            }

            var gizmoColor = Color.green;
            if (MasterAudio.SafeInstance != null) {
                gizmoColor = MasterAudio.Instance.rangeGizmoColor;
            }

            Gizmos.color = gizmoColor;
            Gizmos.DrawWireSphere(transform.position, parameterCommandToGizmo.ColliderMaxDistance);
        }

        void OnDrawGizmosSelected() {
            if (MasterAudio.SafeInstance == null || !MasterAudio.Instance.showRangeSoundGizmos || !showParameterCommandGizmo || parameterCommandToGizmo == null) {
                return;
            }

            if (parameterCommandToGizmo.ColliderMaxDistance == 0f) {
                return;
            }

            var gizmoColor = Color.green;
            if (MasterAudio.SafeInstance != null) {
                gizmoColor = MasterAudio.Instance.selectedRangeGizmoColor;
            }

            Gizmos.color = gizmoColor;
            Gizmos.DrawWireSphere(transform.position, parameterCommandToGizmo.ColliderMaxDistance);
        }

        private void CreateItemsIfReady() {
            if (MasterAudio.SafeInstance == null) { 
				return;
			}

			if (createOnAwake && MasterAudio.SoundsReady && !_hasCreated) {
                CreateItems();
            }
        }

        /// <summary>
        /// This method will remove the Sound Groups, Variations, buses, ducking triggers and Playlist objects specified in the Dynamic Sound Group Creator's Inspector. It is called automatically if you check the "Auto-remove Items" checkbox, otherwise you will need to call this method manually.
        /// </summary>
        public void RemoveItems() {
            // delete any buses we created too
            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < groupBuses.Count; i++) {
                var aBus = groupBuses[i];

                if (aBus.isExisting) {
                    continue; // don't delete!
                }

                var existingBus = MasterAudio.GrabBusByName(aBus.busName);
                if (existingBus != null && !existingBus.isTemporary)
                {
                    continue; // don't delete, it was an existing bus you used because it already existed and you couldn't create it.
                }

                if (existingBus != null)
                {
                    existingBus.RemoveActorInstanceId(InstanceId);
                    if (existingBus.HasLiveActors)
                    {
                        continue;
                    }
                }

                MasterAudio.DeleteBusByName(aBus.busName);
            }

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < _groupsToRemove.Count; i++) {
                var groupName = _groupsToRemove[i].name;

                var grp = MasterAudio.GrabGroup(groupName, false);
                if (grp == null)
                {
                    continue;
                }

                grp.RemoveActorInstanceId(InstanceId);
                if (grp.HasLiveActors)
                {
                    continue;
                }

                if (!grp.isTemporary) {
                    continue; // do not delete if it existed already
                }

                MasterAudio.RemoveSoundGroupFromDuckList(groupName);
                MasterAudio.DeleteSoundGroup(groupName);
            }
            _groupsToRemove.Clear();


            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < customEventsToCreate.Count; i++) {
                var anEvent = customEventsToCreate[i];

                var matchingEvent = MasterAudio.Instance.customEvents.Find(delegate(CustomEvent cEvent)
                {
                    return cEvent.EventName == anEvent.EventName && cEvent.isTemporary;
                });

                if (matchingEvent == null)
                {
                    continue;
                }

                matchingEvent.RemoveActorInstanceId(InstanceId);

                if (matchingEvent.HasLiveActors)
                {
                    continue;
                }

                MasterAudio.DeleteCustomEvent(anEvent.EventName);
            }

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < customEventCategories.Count; i++) {
				var aCat = customEventCategories[i];

                var matchingCat = MasterAudio.Instance.customEventCategories.Find(delegate(CustomEventCategory category)
                {
                    return category.CatName == aCat.CatName && category.IsTemporary;
                });

                if (matchingCat == null)
                {
                    continue;
                }

                matchingCat.RemoveActorInstanceId(InstanceId);

                if (matchingCat.HasLiveActors)
                {
                    continue;
                }

                MasterAudio.Instance.customEventCategories.Remove(matchingCat);
            }

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < musicPlaylists.Count; i++) {
                var aPlaylist = musicPlaylists[i];

                var playlist = MasterAudio.GrabPlaylist(aPlaylist.playlistName, false);
                if (playlist == null)
                {
                    continue;
                }

                playlist.RemoveActorInstanceId(InstanceId);

                if (playlist.HasLiveActors)
                {
                    continue;
                }

                MasterAudio.DeletePlaylist(aPlaylist.playlistName);
            }

            for (var i = 0; i < parameterCommands.Count; i++) {
                var command = parameterCommands[i];

                var matchingCmd = MasterAudio.Instance.parameterCommands.Find(delegate (ParameterCommand cmd) {
                    return cmd.ParameterName == command.ParameterName && cmd.IsTemporary;
                });

                if (matchingCmd == null) {
                    continue;
                }

                MasterAudio.StopParameterCommandsByCommandName(command.CommandName);
                MasterAudio.Instance.parameterCommands.Remove(matchingCmd);
            }

            for (var i =0; i < realTimeParameters.Count; i++) {
                var aParam = realTimeParameters[i];

                var matchingParam = MasterAudio.Instance.realTimeParameters.Find(delegate (RealTimeParameter parameter) {
                    return parameter.ParameterName == aParam.ParameterName && parameter.IsTemporary;
                });

                if (matchingParam == null) {
                    continue;
                }

                MasterAudio.Instance.realTimeParameters.Remove(matchingParam);
            }

            if (reUseMode == CreateItemsWhen.EveryEnable) {
                _hasCreated = false;
            }

            MasterAudio.SilenceOrUnsilenceGroupsFromSoloChange();
        }

        /// <summary>
        /// This method will create the Sound Groups, Variations, buses, ducking triggers and Playlist objects specified in the Dynamic Sound Group Creator's Inspector. It is called automatically if you check the "Auto-create Items" checkbox, otherwise you will need to call this method manually.
        /// </summary>
        public void CreateItems() {
            if (_hasCreated) {
                Debug.LogWarning("DynamicSoundGroupCreator '" + transform.name +
                                 "' has already created its items. Cannot create again.");
                return;
            }

            var ma = MasterAudio.Instance;
            if (ma == null) {
                return;
            }

            PopulateGroupData();

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < groupBuses.Count; i++) {
                var aBus = groupBuses[i];

                if (aBus.isExisting) {
                    var confirmBus = MasterAudio.GrabBusByName(aBus.busName);
                    if (confirmBus == null) {
                        MasterAudio.LogWarning("Existing bus '" + aBus.busName +
                                               "' was not found, specified in prefab '" + name + "'.");
                    }
                    continue; // already exists.
                }

                var createdBus = MasterAudio.GrabBusByName(aBus.busName);

                if (createdBus == null)
                {
                    if (MasterAudio.CreateBus(aBus.busName, InstanceId, errorOnDuplicates, true))
                    {
                        createdBus = MasterAudio.GrabBusByName(aBus.busName);
                    }
                } else {
                    createdBus.AddActorInstanceId(InstanceId);
                }

                if (createdBus == null) {
                    continue;
                }

                var busVol = PersistentAudioSettings.GetBusVolume(aBus.busName);
                if (!busVol.HasValue) {
                    createdBus.volume = aBus.volume;
                    createdBus.OriginalVolume = createdBus.volume;
                }
                createdBus.voiceLimit = aBus.voiceLimit;
                createdBus.busVoiceLimitExceededMode = aBus.busVoiceLimitExceededMode;
                createdBus.forceTo2D = aBus.forceTo2D;
                createdBus.bypassReverbZones = aBus.bypassReverbZones;
                createdBus.mixerChannel = aBus.mixerChannel;
                createdBus.busColor = aBus.busColor;
                createdBus.isUsingOcclusion = aBus.isUsingOcclusion;
            }

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < _groupsToCreate.Count; i++) {
                var aGroup = _groupsToCreate[i];

                var busName = string.Empty;
                var selectedBusIndex = aGroup.busIndex == -1 ? 0 : aGroup.busIndex;
                if (selectedBusIndex >= HardCodedBusOptions) {
                    var selectedBus = groupBuses[selectedBusIndex - HardCodedBusOptions];
                    busName = selectedBus.busName;
                }
                aGroup.busName = busName;

                Transform groupTrans;
                var existingGroup = MasterAudio.GrabGroup(aGroup.name, false);
                if (existingGroup != null)
                {
                    if (errorOnDuplicates) {
                        Debug.LogError("Sound Group named '" + aGroup.name + "' already exists in MasterAudio game object. Skipping creation,");
                    }

                    existingGroup.AddActorInstanceId(InstanceId);
                    groupTrans = existingGroup.transform;
                } else {
                    groupTrans = MasterAudio.CreateSoundGroup(aGroup, InstanceId, errorOnDuplicates);
                }

                // remove fx components
                // ReSharper disable ForCanBeConvertedToForeach
                for (var v = 0; v < aGroup.groupVariations.Count; v++) {
                    // ReSharper restore ForCanBeConvertedToForeach
                    var aVar = aGroup.groupVariations[v];
                    if (aVar.LowPassFilter != null) {
                        Destroy(aVar.LowPassFilter);
                    }
                    if (aVar.HighPassFilter != null) {
                        Destroy(aVar.HighPassFilter);
                    }
                    if (aVar.DistortionFilter != null) {
                        Destroy(aVar.DistortionFilter);
                    }
                    if (aVar.ChorusFilter != null) {
                        Destroy(aVar.ChorusFilter);
                    }
                    if (aVar.EchoFilter != null) {
                        Destroy(aVar.EchoFilter);
                    }
                    if (aVar.ReverbFilter != null) {
                        Destroy(aVar.ReverbFilter);
                    }
                }

                if (groupTrans == null) {
                    continue;
                }

                _groupsToRemove.Add(groupTrans);
            }

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < musicDuckingSounds.Count; i++) {
                var aDuck = musicDuckingSounds[i];
                if (aDuck.soundType == MasterAudio.NoGroupName) {
                    continue;
                }

                MasterAudio.AddSoundGroupToDuckList(aDuck.soundType, aDuck.riseVolStart, aDuck.duckedVolumeCut, aDuck.unduckTime, aDuck.duckMode, aDuck.enableDistanceDuckRatio, true);
            }

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < customEventCategories.Count; i++) {
				var aCat = customEventCategories[i];
				MasterAudio.CreateCustomEventCategoryIfNotThere(aCat.CatName, InstanceId, errorOnDuplicates, true);
			}

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < customEventsToCreate.Count; i++) {
                var anEvent = customEventsToCreate[i];
				MasterAudio.CreateCustomEvent(anEvent.EventName, anEvent.eventReceiveMode, anEvent.distanceThreshold, anEvent.eventRcvFilterMode, anEvent.filterModeQty, InstanceId, anEvent.categoryName, true, errorOnDuplicates);
            }

            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < musicPlaylists.Count; i++) {
                var aPlaylist = musicPlaylists[i];
				aPlaylist.isTemporary = true;

                var existingPlaylist = MasterAudio.Instance.musicPlaylists.Find(delegate(MasterAudio.Playlist playlist)
                {
                    return playlist.playlistName == aPlaylist.playlistName && aPlaylist.isTemporary;
                });

                if (existingPlaylist != null)
                {
                    existingPlaylist.AddActorInstanceId(InstanceId);
                    continue;
                }

				MasterAudio.CreatePlaylist(aPlaylist, errorOnDuplicates);
                aPlaylist.AddActorInstanceId(InstanceId);
            }

            MasterAudio.SilenceOrUnsilenceGroupsFromSoloChange(); // to make sure non-soloed things get muted

            for (var i = 0; i < realTimeParameters.Count; i++) {
                var aParam = realTimeParameters[i];
                MasterAudio.CreateRealTimeParameter(aParam.ParameterName, 0, aParam.IsExpanded, aParam.MinValue, aParam.MaxValue, true, errorOnDuplicates);
            }

            for (var i = 0; i < parameterCommands.Count; i++) {
                var aCommand = parameterCommands[i];
                var newCmd = MasterAudio.CreateRealTimeParameterCommand(aCommand.CommandName, aCommand.ParameterName, aCommand.IsExpanded, 
                    aCommand.MinDisplayCurveX, aCommand.MaxDisplayCurveX,
                    true, errorOnDuplicates);
                if (newCmd == null) {
                    continue;
                }
                
                for (var e = 0; e < aCommand.Elements.Count; e++) {
                    var anElement = aCommand.Elements[e];
                    MasterAudio.CreateParameterCommandElement(newCmd, anElement.ElementName, anElement.VariationName, anElement.IsExpanded,
                        anElement.ShowAdvanced, anElement.VariationMode, anElement.SoundGroup, anElement.Volume,
                        anElement.OverridePitch, anElement.Pitch, anElement.DelaySound, anElement.FadeInRangeStart,
                        anElement.FadeInRangeEnd, anElement.FadeOutRangeStart, anElement.FadeOutRangeEnd,
                        anElement.SoundSpawnLocationMode, 
                        anElement.ShowCurves,
                        anElement.AffectVolume, anElement.VolumeAnimationCurve,
                        anElement.AffectPitch, anElement.PitchAnimationCurve, anElement.ShowFadeInOutFields,
                        anElement.AffectLowPassFilter, anElement.LowPassAnimationCurve,
                        anElement.AffectHighPassFilter, anElement.HighPassAnimationCurve,
                        anElement.MaxDisplayVolumeCurveY, errorOnDuplicates);
                }
            }

            _hasCreated = true;

            if (itemsCreatedEventExpanded) {
				FireEvents();
            }
        }

		private void FireEvents() {
            MasterAudio.FireCustomEventNextFrame(itemsCreatedCustomEvent, _trans);
		}

        /*! \cond PRIVATE */
        public void PopulateGroupData() {
            if (_trans == null) {
                _trans = transform;
            }
            _groupsToCreate.Clear();

            for (var i = 0; i < _trans.childCount; i++) {
                var aGroup = _trans.GetChild(i).GetComponent<DynamicSoundGroup>();
                if (aGroup == null) {
                    continue;
                }

                aGroup.groupVariations.Clear();

                for (var c = 0; c < aGroup.transform.childCount; c++) {
                    var aVar = aGroup.transform.GetChild(c).GetComponent<DynamicGroupVariation>();
                    if (aVar == null) {
                        continue;
                    }

                    aGroup.groupVariations.Add(aVar);
                }

                _groupsToCreate.Add(aGroup);
            }
        }

        public static int HardCodedBusOptions {
            get { return MasterAudio.HardCodedBusOptions + ExtraHardCodedBusOptions; }
        }
        /*! \endcond */

        /// <summary>
        /// This property can be used to read and write the Dynamic Sound Groups.
        /// </summary>	
        public List<DynamicSoundGroup> GroupsToCreate {
            get { return _groupsToCreate; }
        }

		/*! \cond PRIVATE */
		public int InstanceId {
            get {
                if (_instanceId < 0)
                {
                    _instanceId = GetInstanceID();
                }

                return _instanceId;
            }
        }

        /// <summary>
        /// This is used by the Inspector, do not call.
        /// </summary>
        /// <param name="parameterCommandElement">ParameterCommandElement</param>
        /// <returns>AudioSource</returns>
        public AudioSource GetNamedOrFirstAudioSource(ParameterCommandElement parameterCommandElement) {
            if (string.IsNullOrEmpty(parameterCommandElement.SoundGroup)) {
                parameterCommandElement.ColliderMaxDistance = 0;
                return null;
            }

            var grp = transform.Find(parameterCommandElement.SoundGroup);
            if (grp == null) {
                parameterCommandElement.ColliderMaxDistance = 0;
                return null;
            }

            Transform transVar = null;

            switch (parameterCommandElement.VariationMode) {
                case EventSounds.VariationType.PlayRandom:
                    transVar = grp.GetChild(0);
                    break;
                case EventSounds.VariationType.PlaySpecific:
                    transVar = grp.transform.Find(parameterCommandElement.VariationName);
                    break;
            }

            if (transVar == null) {
                parameterCommandElement.ColliderMaxDistance = 0;
                return null;
            }

            return transVar.GetComponent<AudioSource>();
        }

        /// <summary>
        /// This is used by the Inspector, do not call.
        /// </summary>
        /// <param name="element">ParameterCommandElement</param>
        /// <returns>List<AudioSource></returns>
        public List<AudioSource> GetAllVariationAudioSources(ParameterCommandElement element) {
            if (string.IsNullOrEmpty(element.SoundGroup)) {
                element.ColliderMaxDistance = 0;
                return null;
            }

            var grp = transform.Find(element.SoundGroup);
            if (grp == null) {
                element.ColliderMaxDistance = 0;
                return null;
            }

            var audioSources = new List<AudioSource>(grp.childCount);

            for (var i = 0; i < grp.childCount; i++) {
                var a = grp.GetChild(i).GetComponent<AudioSource>();
                audioSources.Add(a);
            }

            return audioSources;
        }

        public void CalculateRadius(ParameterCommandElement element) {
            var aud = GetNamedOrFirstAudioSource(element);

            if (aud == null) {
                element.ColliderMaxDistance = 0f;
                return;
            }

            element.ColliderMaxDistance = aud.maxDistance;
        }

        public bool ShouldShowUnityAudioMixerGroupAssignments {
            get {
                return showUnityMixerGroupAssignment;
            }
        }
        /*! \endcond */
    }
}