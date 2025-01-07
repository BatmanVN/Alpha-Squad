using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Grenade : WeaponDamageEntity
{
	public enum GFILEMIJPKF
	{
		None = 0,
		CollisionTimer = 1,
		LaunchTimer = 2,
		TargetReached = 3
	}

	public enum IJJQQEREFEM
	{
		None = 0,
		OnSpawn = 1,
		OnTimerStart = 2
	}

	public enum MJLJRKONHEQ
	{
		None = 0,
		RandomAngularVelocity = 1,
		AlignWithDirection = 2
	}

	public enum QNTIJGKTKPG
	{
		OnSpawn = 0,
		BeforeContact = 1
	}

	[CompilerGenerated]
	private sealed class GRIJHFKRKPH
	{
		public Vector3 collisionPoint;

		public Grenade _003C_003E4__this;

		internal void _003CSetup_003Eb__1()
		{
		}
	}

	private const float LKMRIOJGPHR = 0.04f;

	private const int LIHFEKJRGEN = 4;

	public const float IGNORE_COLLISIONS_TIME = 0.5f;

	public Action<Grenade> OnExplode;

	public GFILEMIJPKF triggerType;

	public float explosionTime;

	public float radius;

	public bool dontDamage;

	public float indicatorScaleTime;

	public float extraGravity;

	public float launchAngleDeg;

	public bool offsetWithSpreadAngle;

	public ITKSRPQLPQN damageType;

	public MJLJRKONHEQ rotationMode;

	public float rotationVelocity;

	[NonSerialized]
	public Rigidbody rb;

	[SerializeField]
	private bool setToKinematicOnCollision;

	[SerializeField]
	public GrenadeVisual assignedVisual;

	[SerializeField]
	protected Transform explosionIndicator;

	[SerializeField]
	private IJJQQEREFEM indicatorType;

	[SerializeField]
	protected RangeIndicator explosionIndicatorRange;

	[SerializeField]
	private GameObject contactPointFX;

	public QNTIJGKTKPG contactPointType;

	public float contactPointDuration;

	[SerializeField]
	private bool directHitTrigger;

	[SerializeField]
	private bool overrideToReachablePosition;

	[SerializeField]
	private SoundEffect grenadeBeepSound;

	private GameObject NTJJQRSTEMM;

	protected Vector3 GLGRLNQLHJL;

	protected float SHOFHLMMTHT;

	protected bool FINJFLQLSSL;

	private float FFPMTINETOM;

	private float RJHNQQPQORE;

	public Quaternion lastRotation;

	protected bool LFOPPIKPRFQ;

	private bool RHHMGRTQPNM;

	[NonSerialized]
	public bool cloned;

	private Vector3 QQENINJSIOO;

	private bool QFNMNRLMLFL;

	private RaycastHit[] HHSNMPPINMQ;

	private float OFKJFSORGOE;

	private int ETOFHTMGKHK;

	private Vector3 IKHGSOJIRSK => default(Vector3);

	public event Action IOSMHQFSKPE
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Collision> PILINPFPHQM
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public new event Action<bool> IQOOQMSMNRM
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected virtual void Awake()
	{
	}

	public override void Setup(Actor TNKMMOJJPPI, WeaponInfo HKMHKJRGFEE, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = 0)
	{
	}

	private bool RGFJNOKEFLS(Vector3 QIOLLKMPNFO, float NEKOTTJKOOF, out Vector3 PQNITOOPPOG)
	{
		PQNITOOPPOG = default(Vector3);
		return false;
	}

	private void QSJQTSQFQKE(IJJQQEREFEM GKFKHFITKTO)
	{
	}

	private void OTPRLRLJIJR(Vector3 FRFPPSKGSHH)
	{
	}

	public void SetCollisionsEnabled(bool QHSMPFPKNMM)
	{
	}

	protected void NSKMGPTOTNM()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public float GetPushPower()
	{
		return 0f;
	}

	public float GetRagdollPushPower()
	{
		return 0f;
	}

	public RangeIndicator GetExplosionRangeIndicator()
	{
		return null;
	}

	public Transform GetExplosionIndicator()
	{
		return null;
	}

	protected virtual void OnEnable()
	{
	}

	protected new virtual void Destroy(bool NRLORILTSJR = false)
	{
	}

	protected virtual void HOKNQHFQSQI()
	{
	}

	private void RROINLQOEML()
	{
	}

	protected virtual void OnCollisionEnter(Collision QFRIINRRGIM)
	{
	}

	protected virtual void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	protected virtual void HOMKJKTHSTL()
	{
	}

	protected void KNMQPGRHFIP()
	{
	}

	protected void MOMQRQJSTIP()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void QITSOLFQGQO()
	{
	}

	private Vector3 PLMGPNJMGJH(out float KLHERHJPFKI)
	{
		KLHERHJPFKI = default(float);
		return default(Vector3);
	}

	private bool HKJNRFIJJPG()
	{
		return false;
	}

	[CompilerGenerated]
	private void GLMQIRFJKMM()
	{
	}

	[CompilerGenerated]
	private void QPOJPEHMSPI()
	{
	}
}
