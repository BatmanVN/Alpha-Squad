using System.Runtime.CompilerServices;
using KinematicCharacterController;
using UnityEngine;

public class MovementController : MonoBehaviour, ICharacterController
{
	public KinematicCharacterMotor Motor;

	public bool boostActive;

	public float AnimationMoveSpeedConstant;

	public float MaxStableMoveSpeed;

	public float BoostSpeedMultiplier;

	public float StableMovementSharpness;

	public float StableMovementSharpnessMultiplier;

	public float OrientationSharpness;

	public float MaxAirMoveSpeed;

	public float AirAccelerationSpeed;

	public float Drag;

	public bool RotationObstruction;

	public Vector3 Gravity;

	public Vector3 PushForce;

	private Vector3 MKTKMINFGTL;

	private Vector3 FLSQMKNRETR;

	private Transform HQIQOMFSNSO;

	private Vector3 LOMLMHOSOJI;

	private float MRPTJNNSSON;

	public float SITHOOMNNTM => 0f;

	private void Start()
	{
	}

	public Vector3 GetNormalizedInputVector3()
	{
		return default(Vector3);
	}

	public float GetNormalizedSpeedWithBoost()
	{
		return 0f;
	}

	public float GetUnitSpeedWithBoost()
	{
		return 0f;
	}

	public float GetNormalizedSpeed()
	{
		return 0f;
	}

	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public bool IsGrounded()
	{
		return false;
	}

	public void SetControllerEnabled(bool PONLLSSTOOI)
	{
	}

	public void SetBoostActive(bool SMJFTKGRFLJ)
	{
	}

	public void TeleportTo(Vector3 ETRKSFJPFHS)
	{
	}

	public void LockTo(Transform SHNFGIQNNGE, bool ESMSJGJOOJM = false)
	{
	}

	public void Unlock()
	{
	}

	public void SetInput(Vector2 HIKMLGKLQJG)
	{
	}

	public void BeforeCharacterUpdate(float NONJRSKEHTP)
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdateRotation(ref Quaternion NRQLKOQENTJ, float NONJRSKEHTP)
	{
	}

	public void UpdateVelocity(ref Vector3 OKQTFKKKIEG, float NONJRSKEHTP)
	{
	}

	public void AfterCharacterUpdate(float NONJRSKEHTP)
	{
	}

	public bool IsColliderValidForCollisions(Collider MNESGNPMORP)
	{
		return false;
	}

	public void OnGroundHit(Collider QMRQPKMSLPN, Vector3 QSJRQTEFHLK, Vector3 REFQTORIHQP, ref HitStabilityReport JKJSHPIEILS)
	{
	}

	public void OnMovementHit(Collider QMRQPKMSLPN, Vector3 QSJRQTEFHLK, Vector3 REFQTORIHQP, ref HitStabilityReport JKJSHPIEILS)
	{
	}

	public void PostGroundingUpdate(float NONJRSKEHTP)
	{
	}

	public void AddVelocity(Vector3 JEMKOHSPRRN)
	{
	}

	public void ProcessHitStabilityReport(Collider QMRQPKMSLPN, Vector3 QSJRQTEFHLK, Vector3 REFQTORIHQP, Vector3 PMRPQFKNGPL, Quaternion MROQNEERQFO, ref HitStabilityReport JKJSHPIEILS)
	{
	}

	public void OnDiscreteCollisionDetected(Collider QMRQPKMSLPN)
	{
	}

	public void Push(Vector3 RHOIJKGIEEP)
	{
	}

	[CompilerGenerated]
	private void PNETRFKLJIF()
	{
	}

	[CompilerGenerated]
	private void EKFPJHERSEF()
	{
	}
}
