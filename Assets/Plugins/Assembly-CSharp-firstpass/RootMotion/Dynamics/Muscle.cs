using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	public class Muscle
	{
		[Serializable]
		public enum Group
		{
			Hips = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Hand = 4,
			Leg = 5,
			Foot = 6,
			Tail = 7,
			Prop = 8
		}

		[Serializable]
		public class Props
		{
			public Group group;

			public float mappingWeight;

			public float pinWeight;

			public float muscleWeight;

			public float muscleDamper;

			public bool mapPosition;

			public Props()
			{
			}

			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			public void Clamp()
			{
			}
		}

		public struct State
		{
			public float mappingWeightMlp;

			public float pinWeightMlp;

			public float muscleWeightMlp;

			public float maxForceMlp;

			public float muscleDamperMlp;

			public float muscleDamperAdd;

			public float immunity;

			public float impulseMlp;

			public Vector3 velocity;

			public Vector3 angularVelocity;

			public static State Default => default(State);

			public void Clamp()
			{
			}
		}

		[HideInInspector]
		public string name;

		public ConfigurableJoint joint;

		public Transform target;

		public Props props;

		public State state;

		[HideInInspector]
		public int[] parentIndexes;

		[HideInInspector]
		public int[] childIndexes;

		[HideInInspector]
		public bool[] childFlags;

		[HideInInspector]
		public int[] kinshipDegrees;

		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[HideInInspector]
		public Vector3 positionOffset;

		[HideInInspector]
		public Vector3 mappedVelocity;

		[HideInInspector]
		public Vector3 mappedAngularVelocity;

		private Transform rebuildParent;

		private Vector3 rebuildPosition;

		private Quaternion rebuildRotation;

		private Vector3 rebuildTargetPosition;

		private Quaternion rebuildTargetRotation;

		private ConfigurableJointMotion rebuildAngularXMotion;

		private ConfigurableJointMotion rebuildAngularYMotion;

		private ConfigurableJointMotion rebuildAngularZMotion;

		private JointDrive slerpDrive;

		private float lastJointDriveRotationWeight;

		private float lastRotationDamper;

		private Vector3 defaultPosition;

		private Vector3 defaultTargetLocalPosition;

		private Vector3 lastMappedPosition;

		private Quaternion defaultLocalRotation;

		private Quaternion localRotationConvert;

		private Quaternion toParentSpace;

		private Quaternion toJointSpaceInverse;

		private Quaternion toJointSpaceDefault;

		private Quaternion targetAnimatedRotation;

		private Quaternion targetAnimatedWorldRotation;

		private Quaternion defaultRotation;

		private Quaternion rotationRelativeToTarget;

		private Quaternion defaultTargetLocalRotation;

		private Quaternion lastMappedRotation;

		private Transform targetParent;

		private Transform connectedBodyTransform;

		private ConfigurableJointMotion angularXMotionDefault;

		private ConfigurableJointMotion angularYMotionDefault;

		private ConfigurableJointMotion angularZMotionDefault;

		private bool directTargetParent;

		private bool initiated;

		private Collider[] _colliders;

		private float lastReadTime;

		private float lastWriteTime;

		private bool[] disabledColliders;

		public Transform transform { get; private set; }

		public Rigidbody rigidbody { get; private set; }

		public Transform connectedBodyTarget { get; private set; }

		public Vector3 targetAnimatedPosition { get; private set; }

		public Collider[] colliders => null;

		public Vector3 targetVelocity { get; private set; }

		public Vector3 targetAngularVelocity { get; private set; }

		public Quaternion targetRotationRelative { get; private set; }

		public Rigidbody rebuildConnectedBody { get; private set; }

		public Transform rebuildTargetParent { get; private set; }

		private Quaternion localRotation => default(Quaternion);

		private Quaternion parentRotation => default(Quaternion);

		private Quaternion targetParentRotation => default(Quaternion);

		private Quaternion targetLocalRotation => default(Quaternion);

		public bool IsValid(bool log)
		{
			return false;
		}

		public void Rebuild()
		{
		}

		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		public void UpdateColliders()
		{
		}

		public void DisableColliders()
		{
		}

		public void EnableColliders()
		{
		}

		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		public void IgnoreAngularLimits(bool ignore)
		{
		}

		public void FixTargetTransforms()
		{
		}

		public void Reset()
		{
		}

		public void MoveToTarget()
		{
		}

		public void Read()
		{
		}

		public void ClearVelocities()
		{
		}

		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged, float deltaTime)
		{
		}

		public void Map(float mappingWeightMaster)
		{
		}

		public void CalculateMappedVelocity()
		{
		}

		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, float deltaTime)
		{
		}

		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}
	}
}
