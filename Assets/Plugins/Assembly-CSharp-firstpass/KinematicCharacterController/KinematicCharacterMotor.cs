using System;
using UnityEngine;

namespace KinematicCharacterController
{
	public class KinematicCharacterMotor : MonoBehaviour
	{
		[ReadOnly]
		public CapsuleCollider Capsule;

		[SerializeField]
		private float CapsuleRadius;

		[SerializeField]
		private float CapsuleHeight;

		[SerializeField]
		private float CapsuleYOffset;

		[SerializeField]
		private PhysicsMaterial CapsulePhysicsMaterial;

		public float GroundDetectionExtraDistance;

		public float MaxStableSlopeAngle;

		public LayerMask StableGroundLayers;

		public bool DiscreteCollisionEvents;

		public StepHandlingMethod StepHandling;

		public float MaxStepHeight;

		public bool AllowSteppingWithoutStableGrounding;

		public float MinRequiredStepDepth;

		public bool LedgeAndDenivelationHandling;

		public float MaxStableDistanceFromLedge;

		public float MaxVelocityForLedgeSnap;

		public float MaxStableDenivelationAngle;

		public bool InteractiveRigidbodyHandling;

		public RigidbodyInteractionType RigidbodyInteractionType;

		public bool PreserveAttachedRigidbodyMomentum;

		public bool HasPlanarConstraint;

		public Vector3 PlanarConstraintAxis;

		[NonSerialized]
		public CharacterGroundingReport GroundingStatus;

		[NonSerialized]
		public CharacterTransientGroundingReport LastGroundingStatus;

		[NonSerialized]
		public LayerMask CollidableLayers;

		private Transform _transform;

		private Vector3 _transientPosition;

		private Vector3 _characterUp;

		private Vector3 _characterForward;

		private Vector3 _characterRight;

		private Vector3 _initialSimulationPosition;

		private Quaternion _initialSimulationRotation;

		private Rigidbody _attachedRigidbody;

		private Vector3 _characterTransformToCapsuleCenter;

		private Vector3 _characterTransformToCapsuleBottom;

		private Vector3 _characterTransformToCapsuleTop;

		private Vector3 _characterTransformToCapsuleBottomHemi;

		private Vector3 _characterTransformToCapsuleTopHemi;

		private Vector3 _attachedRigidbodyVelocity;

		private int _overlapsCount;

		private OverlapResult[] _overlaps;

		[NonSerialized]
		public ICharacterController CharacterController;

		[NonSerialized]
		public bool LastMovementIterationFoundAnyGround;

		[NonSerialized]
		public int IndexInCharacterSystem;

		[NonSerialized]
		public Vector3 InitialTickPosition;

		[NonSerialized]
		public Quaternion InitialTickRotation;

		[NonSerialized]
		public Rigidbody AttachedRigidbodyOverride;

		[NonSerialized]
		public Vector3 BaseVelocity;

		private RaycastHit[] _internalCharacterHits;

		private Collider[] _internalProbedColliders;

		private Rigidbody[] _rigidbodiesPushedThisMove;

		private RigidbodyProjectionHit[] _internalRigidbodyProjectionHits;

		private Rigidbody _lastAttachedRigidbody;

		private bool _solveMovementCollisions;

		private bool _solveGrounding;

		private bool _movePositionDirty;

		private Vector3 _movePositionTarget;

		private bool _moveRotationDirty;

		private Quaternion _moveRotationTarget;

		private bool _lastSolvedOverlapNormalDirty;

		private Vector3 _lastSolvedOverlapNormal;

		private int _rigidbodiesPushedCount;

		private int _rigidbodyProjectionHitCount;

		private bool _isMovingFromAttachedRigidbody;

		private bool _mustUnground;

		private float _mustUngroundTimeCounter;

		private Vector3 _cachedWorldUp;

		private Vector3 _cachedWorldForward;

		private Vector3 _cachedWorldRight;

		private Vector3 _cachedZeroVector;

		private Quaternion _transientRotation;

		public const int MaxHitsBudget = 16;

		public const int MaxCollisionBudget = 16;

		public const int MaxGroundingSweepIterations = 2;

		public const int MaxMovementSweepIterations = 8;

		public const int MaxSteppingSweepIterations = 3;

		public const int MaxRigidbodyOverlapsCount = 16;

		public const int MaxDiscreteCollisionIterations = 3;

		public const float CollisionOffset = 0.001f;

		public const float GroundProbeReboundDistance = 0.02f;

		public const float MinimumGroundProbingDistance = 0.005f;

		public const float GroundProbingBackstepDistance = 0.1f;

		public const float SweepProbingBackstepDistance = 0.002f;

		public const float SecondaryProbesVertical = 0.02f;

		public const float SecondaryProbesHorizontal = 0.001f;

		public const float MinVelocityMagnitude = 0.01f;

		public const float SteppingForwardDistance = 0.03f;

		public const float MinDistanceForLedge = 0.05f;

		public const float CorrelationForVerticalObstruction = 0.01f;

		public const float ExtraSteppingForwardDistance = 0.01f;

		public const float ExtraStepHeightPadding = 0.01f;

		public Transform Transform => null;

		public Vector3 TransientPosition => default(Vector3);

		public Vector3 CharacterUp => default(Vector3);

		public Vector3 CharacterForward => default(Vector3);

		public Vector3 CharacterRight => default(Vector3);

		public Vector3 InitialSimulationPosition => default(Vector3);

		public Quaternion InitialSimulationRotation => default(Quaternion);

		public Rigidbody AttachedRigidbody => null;

		public Vector3 CharacterTransformToCapsuleCenter => default(Vector3);

		public Vector3 CharacterTransformToCapsuleBottom => default(Vector3);

		public Vector3 CharacterTransformToCapsuleTop => default(Vector3);

		public Vector3 CharacterTransformToCapsuleBottomHemi => default(Vector3);

		public Vector3 CharacterTransformToCapsuleTopHemi => default(Vector3);

		public Vector3 AttachedRigidbodyVelocity => default(Vector3);

		public int OverlapsCount => 0;

		public OverlapResult[] Overlaps => null;

		public Quaternion TransientRotation
		{
			get
			{
				return default(Quaternion);
			}
			private set
			{
			}
		}

		public Vector3 Velocity => default(Vector3);

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Reset()
		{
		}

		private void OnValidate()
		{
		}

		private void HandleRemoveComponent()
		{
		}

		public void ValidateData()
		{
		}

		public void SetCapsuleCollisionsActivation(bool collisionsActive)
		{
		}

		public void SetMovementCollisionsSolvingActivation(bool movementCollisionsSolvingActive)
		{
		}

		public void SetGroundSolvingActivation(bool stabilitySolvingActive)
		{
		}

		public void SetPosition(Vector3 position, bool bypassInterpolation = true)
		{
		}

		public void SetRotation(Quaternion rotation, bool bypassInterpolation = true)
		{
		}

		public void SetPositionAndRotation(Vector3 position, Quaternion rotation, bool bypassInterpolation = true)
		{
		}

		public void MoveCharacter(Vector3 toPosition)
		{
		}

		public void RotateCharacter(Quaternion toRotation)
		{
		}

		public KinematicCharacterMotorState GetState()
		{
			return default(KinematicCharacterMotorState);
		}

		public void ApplyState(KinematicCharacterMotorState state, bool bypassInterpolation = true)
		{
		}

		public void SetCapsuleDimensions(float radius, float height, float yOffset)
		{
		}

		private void Awake()
		{
		}

		public void UpdatePhase1(float deltaTime)
		{
		}

		public void UpdatePhase2(float deltaTime)
		{
		}

		private bool IsStableOnNormal(Vector3 normal)
		{
			return false;
		}

		private bool IsStableWithSpecialCases(ref HitStabilityReport stabilityReport, Vector3 velocity)
		{
			return false;
		}

		public void ProbeGround(ref Vector3 probingPosition, Quaternion atRotation, float probingDistance, ref CharacterGroundingReport groundingReport)
		{
		}

		public void ForceUnground(float time = 0.1f)
		{
		}

		public bool MustUnground()
		{
			return false;
		}

		public Vector3 GetDirectionTangentToSurface(Vector3 direction, Vector3 surfaceNormal)
		{
			return default(Vector3);
		}

		private bool InternalCharacterMove(ref Vector3 transientVelocity, float deltaTime)
		{
			return false;
		}

		private Vector3 GetObstructionNormal(Vector3 hitNormal, bool stableOnHit)
		{
			return default(Vector3);
		}

		private void StoreRigidbodyHit(Rigidbody hitRigidbody, Vector3 hitVelocity, Vector3 hitPoint, Vector3 obstructionNormal, HitStabilityReport hitStabilityReport)
		{
		}

		public void SetTransientPosition(Vector3 newPos)
		{
		}

		private void InternalHandleVelocityProjection(bool stableOnHit, Vector3 hitNormal, Vector3 obstructionNormal, Vector3 originalDirection, ref MovementSweepState sweepState, ref Vector3 previousObstructionNormal, ref Vector3 transientVelocity, ref float remainingMovementMagnitude, ref Vector3 remainingMovementDirection)
		{
		}

		public virtual void HandleVelocityProjection(ref Vector3 velocity, Vector3 obstructionNormal, bool stableOnHit)
		{
		}

		public virtual void HandleSimulatedRigidbodyInteraction(ref Vector3 processedVelocity, RigidbodyProjectionHit hit, float deltaTime)
		{
		}

		private void ProcessVelocityForRigidbodyHits(ref Vector3 processedVelocity, float deltaTime)
		{
		}

		private bool CheckIfColliderValidForCollisions(Collider coll)
		{
			return false;
		}

		private bool InternalIsColliderValidForCollisions(Collider coll)
		{
			return false;
		}

		public void EvaluateHitStability(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, Vector3 atCharacterPosition, Quaternion atCharacterRotation, Vector3 withCharacterVelocity, ref HitStabilityReport stabilityReport)
		{
		}

		private void DetectSteps(Vector3 characterPosition, Quaternion characterRotation, Vector3 hitPoint, Vector3 innerHitDirection, ref HitStabilityReport stabilityReport)
		{
		}

		private bool CheckStepValidity(int nbStepHits, Vector3 characterPosition, Quaternion characterRotation, Vector3 innerHitDirection, Vector3 stepCheckStartPos, out Collider hitCollider)
		{
			hitCollider = null;
			return false;
		}

		public Vector3 GetVelocityFromRigidbodyMovement(Rigidbody interactiveRigidbody, Vector3 atPoint, float deltaTime)
		{
			return default(Vector3);
		}

		private Rigidbody GetInteractiveRigidbody(Collider onCollider)
		{
			return null;
		}

		public Vector3 GetVelocityForMovePosition(Vector3 fromPosition, Vector3 toPosition, float deltaTime)
		{
			return default(Vector3);
		}

		public Vector3 GetVelocityFromMovement(Vector3 movement, float deltaTime)
		{
			return default(Vector3);
		}

		private void RestrictVectorToPlane(ref Vector3 vector, Vector3 toPlane)
		{
		}

		public int CharacterCollisionsOverlap(Vector3 position, Quaternion rotation, Collider[] overlappedColliders, float inflate = 0f, bool acceptOnlyStableGroundLayer = false)
		{
			return 0;
		}

		public int CharacterOverlap(Vector3 position, Quaternion rotation, Collider[] overlappedColliders, LayerMask layers, QueryTriggerInteraction triggerInteraction, float inflate = 0f)
		{
			return 0;
		}

		public int CharacterCollisionsSweep(Vector3 position, Quaternion rotation, Vector3 direction, float distance, out RaycastHit closestHit, RaycastHit[] hits, float inflate = 0f, bool acceptOnlyStableGroundLayer = false)
		{
			closestHit = default(RaycastHit);
			return 0;
		}

		public int CharacterSweep(Vector3 position, Quaternion rotation, Vector3 direction, float distance, out RaycastHit closestHit, RaycastHit[] hits, LayerMask layers, QueryTriggerInteraction triggerInteraction, float inflate = 0f)
		{
			closestHit = default(RaycastHit);
			return 0;
		}

		private bool CharacterGroundSweep(Vector3 position, Quaternion rotation, Vector3 direction, float distance, out RaycastHit closestHit)
		{
			closestHit = default(RaycastHit);
			return false;
		}

		public int CharacterCollisionsRaycast(Vector3 position, Vector3 direction, float distance, out RaycastHit closestHit, RaycastHit[] hits, bool acceptOnlyStableGroundLayer = false)
		{
			closestHit = default(RaycastHit);
			return 0;
		}
	}
}
