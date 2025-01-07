using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		public enum State
		{
			Puppet = 0,
			Unpinned = 1,
			GetUp = 2
		}

		[Serializable]
		public enum NormalMode
		{
			Active = 0,
			Unmapped = 1,
			Kinematic = 2
		}

		[Serializable]
		public class MasterProps
		{
			public NormalMode normalMode;

			public float mappingBlendSpeed;

			public bool activateOnStaticCollisions;

			public float activateOnImpulse;
		}

		[Serializable]
		public struct MuscleProps
		{
			public float unpinParents;

			public float unpinChildren;

			public float unpinGroup;

			public float minMappingWeight;

			public float maxMappingWeight;

			public bool disableColliders;

			public float regainPinSpeed;

			public float collisionResistance;

			public float knockOutDistance;

			public PhysicsMaterial puppetMaterial;

			public PhysicsMaterial unpinnedMaterial;
		}

		[Serializable]
		public struct MusclePropsGroup
		{
			[HideInInspector]
			public string name;

			public Muscle.Group[] groups;

			public MuscleProps props;
		}

		[Serializable]
		public struct CollisionResistanceMultiplier
		{
			public LayerMask layers;

			public float multiplier;

			public float collisionThreshold;
		}

		public new delegate void CollisionDelegate(MuscleCollision m);

		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		public MasterProps masterProps;

		public LayerMask groundLayers;

		public LayerMask collisionLayers;

		public float collisionThreshold;

		public Weight collisionResistance;

		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		public int maxCollisions;

		public float regainPinSpeed;

		public float boostFalloff;

		public MuscleProps defaults;

		public MusclePropsGroup[] groupOverrides;

		public float knockOutDistance;

		public float unpinnedMuscleWeightMlp;

		public float maxRigidbodyVelocity;

		public float pinWeightThreshold;

		public bool unpinnedMuscleKnockout;

		public bool dropProps;

		public bool canGetUp;

		public float getUpDelay;

		public float blendToAnimationTime;

		public float maxGetUpVelocity;

		public float minGetUpDuration;

		public float getUpCollisionResistanceMlp;

		public float getUpRegainPinSpeedMlp;

		public float getUpKnockOutDistanceMlp;

		public Vector3 getUpOffsetProne;

		public Vector3 getUpOffsetSupine;

		public PuppetEvent onGetUpProne;

		public PuppetEvent onGetUpSupine;

		public PuppetEvent onLoseBalance;

		public PuppetEvent onLoseBalanceFromPuppet;

		public PuppetEvent onLoseBalanceFromGetUp;

		public PuppetEvent onRegainBalance;

		public CollisionDelegate OnCollision;

		public CollisionImpulseDelegate OnCollisionImpulse;

		[HideInInspector]
		public bool canMoveTarget;

		private float unpinnedTimer;

		private float getUpTimer;

		private Vector3 hipsForward;

		private Vector3 hipsUp;

		private float getupAnimationBlendWeight;

		private float getupAnimationBlendWeightV;

		private bool getUpTargetFixed;

		private NormalMode lastNormalMode;

		private int collisions;

		private bool eventsEnabled;

		private float lastKnockOutDistance;

		private float knockOutDistanceSqr;

		private bool getupDisabled;

		private bool hasCollidedSinceGetUp;

		private bool hasBoosted;

		private MuscleCollisionBroadcaster broadcaster;

		private Vector3 getUpPosition;

		private bool dropPropFlag;

		public State state { get; private set; }

		private void OpenUserManual()
		{
		}

		private void OpenScriptReference()
		{
		}

		public override void OnReactivate()
		{
		}

		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnActivate()
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		public override void Resurrect()
		{
		}

		protected override void OnDeactivate()
		{
		}

		protected override void OnFixedUpdate()
		{
		}

		protected override void OnLateUpdate()
		{
		}

		private bool SetKinematic()
		{
			return false;
		}

		protected override void OnReadBehaviour()
		{
		}

		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		public override void OnMuscleAdded(Muscle m)
		{
		}

		public override void OnMuscleRemoved(Muscle m)
		{
		}

		protected void MoveTarget(Vector3 position)
		{
		}

		protected void RotateTarget(Quaternion rotation)
		{
		}

		protected override void GroundTarget(LayerMask layers)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public void Boost(float immunity, float impulseMlp)
		{
		}

		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		public void BoostImmunity(float immunity)
		{
		}

		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		public void Unpin()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return 0f;
		}

		private void UnPin(int muscleIndex, float unpin)
		{
		}

		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		private bool Activate(Collision collision, float impulse)
		{
			return false;
		}

		public bool IsProne()
		{
			return false;
		}

		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return 0f;
		}

		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return 0f;
		}

		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return false;
		}

		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		public void SetState(State newState)
		{
		}

		public void SetColliders(bool unpinned)
		{
		}

		private void SetColliders(Muscle m, bool unpinned)
		{
		}
	}
}
