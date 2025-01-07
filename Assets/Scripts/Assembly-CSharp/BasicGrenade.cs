using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BasicGrenade : DamageEntity
{
	public enum ERHGOGPNFJL
	{
		None = 0,
		CollisionTimer = 1,
		LaunchTimer = 2,
		TargetReached = 3
	}

	public enum LFIQQKLISIS
	{
		None = 0,
		OnSpawn = 1,
		OnTimerStart = 2
	}

	public enum QMIIGJHOEOP
	{
		None = 0,
		RandomAngularVelocity = 1,
		AlignWithDirection = 2
	}

	public enum NQGTFGPLJPK
	{
		OnSpawn = 0,
		BeforeContact = 1
	}

	[CompilerGenerated]
	private sealed class LFMPJKFGIKO
	{
		public Vector3 collisionPoint;

		public BasicGrenade _003C_003E4__this;

		internal void _003CSetup_003Eb__1()
		{
		}
	}

	private const float LKMRIOJGPHR = 0.04f;

	private const int LIHFEKJRGEN = 4;

	public const float IGNORE_COLLISIONS_TIME = 0.5f;

	public Action OnExplode;

	[SerializeField]
	public DamageEntityWithOwner afterHit;

	[SerializeField]
	public float afterHitDelay;

	[SerializeField]
	public Vector3 afterHitOffset;

	[SerializeField]
	public bool forceGrounded;

	public ERHGOGPNFJL triggerType;

	public float explosionTime;

	public float radius;

	public bool dontDamage;

	public float indicatorScaleTime;

	public float extraGravity;

	public float launchAngleDeg;

	public bool offsetWithSpreadAngle;

	public ITKSRPQLPQN damageType;

	public QMIIGJHOEOP rotationMode;

	public float rotationVelocity;

	[NonSerialized]
	public Rigidbody rb;

	[SerializeField]
	public GameObject visual;

	[SerializeField]
	public TrailRenderer[] trails;

	[SerializeField]
	public ParticleSystem particles;

	[SerializeField]
	public GameObject explosionFx;

	[SerializeField]
	private bool setToKinematicOnCollision;

	[SerializeField]
	protected Transform explosionIndicator;

	[SerializeField]
	protected LFIQQKLISIS indicatorType;

	[SerializeField]
	protected RangeIndicator explosionIndicatorRange;

	[SerializeField]
	private bool cameraShake;

	[SerializeField]
	private GameObject contactPointFX;

	public NQGTFGPLJPK contactPointType;

	public float contactPointDuration;

	[SerializeField]
	private bool directHitTrigger;

	[SerializeField]
	public SoundEffect explosionSfx;

	[SerializeField]
	public SoundEffect grenadeCollisionSound;

	[SerializeField]
	private SoundEffect grenadeBeepSound;

	private GameObject NTJJQRSTEMM;

	protected Vector3 GLGRLNQLHJL;

	protected Vector3 QQENINJSIOO;

	protected float SHOFHLMMTHT;

	protected bool FINJFLQLSSL;

	private float FFPMTINETOM;

	private float RJHNQQPQORE;

	public Quaternion lastRotation;

	protected bool LFOPPIKPRFQ;

	private bool RHHMGRTQPNM;

	protected Actor FNJLLHKNGOR;

	protected float NSQGRQMGOJS;

	private bool QFNMNRLMLFL;

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

	public event Action<bool> IQOOQMSMNRM
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

	public virtual void Setup(Actor TNKMMOJJPPI, float NRNGTJKLSHG, float QHPEGHJEESR, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = 0)
	{
	}

	protected virtual void QSJQTSQFQKE(LFIQQKLISIS GKFKHFITKTO)
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

	protected virtual void OnEnable()
	{
	}

	protected virtual void MMRTMTRQNTF(bool NRLORILTSJR = false)
	{
	}

	protected virtual void HOKNQHFQSQI()
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

	protected static void KRLGTMTOHEQ()
	{
	}

	private void EMHPMOHFEOF()
	{
	}

	protected void KNMQPGRHFIP()
	{
	}

	protected virtual void MOMQRQJSTIP()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}

	private void QITSOLFQGQO()
	{
	}

	protected Vector3 PLMGPNJMGJH(out float KLHERHJPFKI)
	{
		KLHERHJPFKI = default(float);
		return default(Vector3);
	}

	protected void RKNLKNKEMTO()
	{
	}

	private bool HKJNRFIJJPG()
	{
		return false;
	}

	[CompilerGenerated]
	private void NJHHTLRIFLM()
	{
	}

	[CompilerGenerated]
	private void QKINKQSGTLQ()
	{
	}

	[CompilerGenerated]
	private void OOLTGOQREJN()
	{
	}
}
