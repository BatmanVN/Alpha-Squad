/*! \cond PRIVATE */
using System;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace DarkTonic.MasterAudio {
    [Serializable]
    // ReSharper disable once CheckNamespace
    public class ParameterCommandElement {
        public string ElementName = "YourElement";
        public bool IsExpanded = true;
        public bool IsEditing = false;
        public string ProspectiveName;
        public string SoundGroup = MasterAudio.NoGroupName;
        public bool ShowAdvanced = false;
        public EventSounds.VariationType VariationMode;
        public string VariationName = string.Empty;
        public MasterAudio.SoundSpawnLocationMode SoundSpawnLocationMode;
        public float Volume = 1f;
        public bool OverridePitch = false;
        public float Pitch = 1f;
        public float DelaySound = 0f;
        public bool ShowFadeInOutFields = false;
        public float FadeInRangeStart = 0f;
        public float FadeInRangeEnd = 1f;
        public float FadeOutRangeStart = 9f;
        public float FadeOutRangeEnd = 10f;
        public float MaxDisplayVolumeCurveY = 1f;
        public bool ShowCurves = true;
        public bool AffectVolume = true;
        public AnimationCurve VolumeAnimationCurve = new AnimationCurve();
        public bool AffectPitch = false;
        public AnimationCurve PitchAnimationCurve = new AnimationCurve();
        public float ColliderMaxDistance;
        public bool ShowSphereGizmo = false;
        public bool AffectLowPassFilter = false;
        public AnimationCurve LowPassAnimationCurve = new AnimationCurve();
        public bool AffectHighPassFilter = false;
        public AnimationCurve HighPassAnimationCurve = new AnimationCurve();
    }
}
/*! \endcond */