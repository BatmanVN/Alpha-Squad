using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			Active = 0,
			Kinematic = 1,
			Disabled = 2
		}

		public delegate void UpdateDelegate();

		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		public enum UpdateMode
		{
			Normal = 0,
			AnimatePhysics = 1,
			FixedUpdate = 2
		}

		[Serializable]
		public enum State
		{
			Alive = 0,
			Dead = 1,
			Frozen = 2
		}

		[Serializable]
		public struct StateSettings
		{
			public float killDuration;

			public float deadMuscleWeight;

			public float deadMuscleDamper;

			public float maxFreezeSqrVelocity;

			public bool freezePermanently;

			public bool enableAngularLimitsOnKill;

			public bool enableInternalCollisionsOnKill;

			public static StateSettings Default => default(StateSettings);

			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
				this.killDuration = 0f;
				this.deadMuscleWeight = 0f;
				this.deadMuscleDamper = 0f;
				this.maxFreezeSqrVelocity = 0f;
				this.freezePermanently = false;
				this.enableAngularLimitsOnKill = false;
				this.enableInternalCollisionsOnKill = false;
			}
		}

		public PuppetMasterHumanoidConfig humanoidConfig;

		public Transform targetRoot;

		public State state;

		public StateSettings stateSettings;

		public Mode mode;

		public float blendTime;

		public bool fixTargetTransforms;

		public int solverIterationCount;

		public bool visualizeTargetPose;

		public float mappingWeight;

		public float pinWeight;

		public float muscleWeight;

		public float muscleSpring;

		public float muscleDamper;

		public float pinPow;

		public float pinDistanceFalloff;

		public bool updateJointAnchors;

		public bool supportTranslationAnimation;

		public bool angularLimits;

		public bool internalCollisions;

		public Muscle[] muscles;

		public UpdateDelegate OnPostInitiate;

		public UpdateDelegate OnRead;

		public UpdateDelegate OnWrite;

		public UpdateDelegate OnPostLateUpdate;

		public UpdateDelegate OnFixTransforms;

		public UpdateDelegate OnHierarchyChanged;

		public MuscleDelegate OnMuscleRemoved;

		private Animator _targetAnimator;

		[HideInInspector]
		public List<SolverManager> solvers;

		private bool internalCollisionsEnabled;

		private bool angularLimitsEnabled;

		private bool fixedFrame;

		private int lastSolverIterationCount;

		private bool isLegacy;

		private bool animatorDisabled;

		private bool awakeFailed;

		private bool interpolated;

		private bool freezeFlag;

		private bool hasBeenDisabled;

		private bool hierarchyIsFlat;

		private bool teleport;

		private Vector3 teleportPosition;

		private Quaternion teleportRotation;

		private bool teleportMoveToTarget;

		private bool rebuildFlag;

		private bool onPostRebuildFlag;

		private Muscle[] defaultMuscles;

		private Vector3 rebuildPelvisPos;

		private Quaternion rebuildPelvisRot;

		private Mode activeMode;

		private Mode lastMode;

		private float mappingBlend;

		public UpdateDelegate OnFreeze;

		public UpdateDelegate OnUnfreeze;

		public UpdateDelegate OnDeath;

		public UpdateDelegate OnResurrection;

		private State activeState;

		private State lastState;

		private bool angularLimitsEnabledOnKill;

		private bool internalCollisionsEnabledOnKill;

		private bool animationDisabledbyStates;

		[HideInInspector]
		public bool storeTargetMappedState;

		private Transform[] targetChildren;

		private Vector3[] targetMappedPositions;

		private Quaternion[] targetMappedRotations;

		private Vector3[] targetSampledPositions;

		private Quaternion[] targetSampledRotations;

		private bool targetMappedStateStored;

		private bool targetMappedStateSampled;

		private bool sampleTargetMappedState;

		private bool hasProp;

		public Animator targetAnimator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Animation targetAnimation { get; private set; }

		public BehaviourBase[] behaviours { get; private set; }

		public bool isActive => false;

		public bool initiated { get; private set; }

		public UpdateMode updateMode => default(UpdateMode);

		public bool controlsAnimator => false;

		public bool isBlending => false;

		private bool autoSimulate => false;

		private AnimatorUpdateMode targetUpdateMode => default(AnimatorUpdateMode);

		public bool isSwitchingMode { get; private set; }

		public bool isSwitchingState => false;

		public bool isKilling { get; private set; }

		public bool isAlive => false;

		public bool isFrozen => false;

		private void OpenUserManualSetup()
		{
		}

		private void OpenUserManualComponent()
		{
		}

		private void OpenUserManualPerformance()
		{
		}

		private void OpenScriptReference()
		{
		}

		private void OpenSetupTutorial()
		{
		}

		private void OpenComponentTutorial()
		{
		}

		private void ResetStateSettings()
		{
		}

		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		private void Initiate()
		{
		}

		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		private void OnDestroy()
		{
		}

		private bool IsInterpolated()
		{
			return false;
		}

		private void OnRebuild()
		{
		}

		public void OnPreSimulate(float deltaTime)
		{
		}

		public void OnPostSimulate()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnLateUpdate()
		{
		}

		private void MoveToTarget()
		{
		}

		private void Read()
		{
		}

		private void FixTargetTransforms()
		{
		}

		private void VisualizeTargetPose()
		{
		}

		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		private void SetInternalCollisions(bool collide)
		{
		}

		private void SetAngularLimits(bool limited)
		{
		}

		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, Muscle.Props muscleProps = null, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		public void Rebuild()
		{
		}

		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		public void FlattenHierarchy()
		{
		}

		public void TreeHierarchy()
		{
		}

		public void FixMusclePositions()
		{
		}

		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		private bool HierarchyIsFlat()
		{
			return false;
		}

		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		private void KillJoint(ConfigurableJoint joint)
		{
		}

		public void DisableImmediately()
		{
		}

		protected virtual void SwitchModes()
		{
		}

		private void DisabledToKinematic()
		{
		}

		private IEnumerator DisabledToActive()
		{
			return null;
		}

		private void KinematicToDisabled()
		{
		}

		private IEnumerator KinematicToActive()
		{
			return null;
		}

		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		private void UpdateInternalCollisions()
		{
		}

		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return false;
		}

		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return 0;
		}

		public int GetMuscleIndex(Transform target)
		{
			return 0;
		}

		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return 0;
		}

		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return 0;
		}

		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		private void SetUpMuscles(Transform setUpTo)
		{
		}

		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		private void RemoveUnnecessaryBones()
		{
		}

		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return false;
		}

		public void Kill()
		{
		}

		public void Kill(StateSettings stateSettings)
		{
		}

		public void Freeze()
		{
		}

		public void Freeze(StateSettings stateSettings)
		{
		}

		public void Resurrect()
		{
		}

		protected virtual void SwitchStates()
		{
		}

		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		private void OnFreezeFlag()
		{
		}

		private void DeadToAlive()
		{
		}

		private void SetAnimationEnabled(bool to)
		{
		}

		private void DeadToFrozen()
		{
		}

		private void FrozenToAlive()
		{
		}

		private void FrozenToDead()
		{
		}

		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		private bool CanFreeze()
		{
			return false;
		}

		public void SampleTargetMappedState()
		{
		}

		public void FixTargetToSampledState(float weight)
		{
		}

		public void StoreTargetMappedState()
		{
		}

		private void UpdateHierarchies()
		{
		}

		private bool HasProp()
		{
			return false;
		}

		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		private void AssignParentAndChildIndexes()
		{
		}

		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		private void AssignKinshipDegrees()
		{
		}

		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return 0;
		}

		public bool IsValid(bool log)
		{
			return false;
		}

		private bool CheckMassVariation(float threshold, bool log)
		{
			return false;
		}

		private bool CheckIfInitiated()
		{
			return false;
		}
	}
}
