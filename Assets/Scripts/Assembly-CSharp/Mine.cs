using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Mine : DamageEntity
{
	public float explosionTime;

	public float radius;

	public float indicatorScaleTime;

	public ITKSRPQLPQN damageType;

	public float pushPower;

	public float ragdollPushPower;

	public float enemyDamageMultiplier;

	[NonSerialized]
	public Rigidbody rb;

	[SerializeField]
	public GameObject visual;

	[SerializeField]
	public ParticleSystem particles;

	[SerializeField]
	public GameObject explosionFx;

	[SerializeField]
	protected Transform explosionIndicator;

	[SerializeField]
	protected RangeIndicator explosionIndicatorRange;

	[SerializeField]
	private GameObject contactPointFX;

	[SerializeField]
	public SoundEffect explosionSfx;

	[SerializeField]
	private SoundEffect grenadeBeepSound;

	protected float SHOFHLMMTHT;

	protected bool FINJFLQLSSL;

	private float RJHNQQPQORE;

	private bool RHHMGRTQPNM;

	private GameObject NTJJQRSTEMM;

	protected bool IQOGGPSHRQL;

	protected Actor FNJLLHKNGOR;

	protected float NSQGRQMGOJS;

	protected Material EGMKGFOERSE;

	public event Action HHRPQKHIFRO
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

	public void Setup(Actor TNKMMOJJPPI)
	{
	}

	public void Arm()
	{
	}

	public bool IsArmed()
	{
		return false;
	}

	private void QSJQTSQFQKE()
	{
	}

	public void StartExplosionTimer()
	{
	}

	private void FixedUpdate()
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

	protected virtual void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	private void OTPRLRLJIJR(Vector3 ERINLTKNSFO)
	{
	}

	protected virtual void HOMKJKTHSTL()
	{
	}

	protected void KNMQPGRHFIP()
	{
	}

	protected static void KRLGTMTOHEQ()
	{
	}

	private void EMHPMOHFEOF()
	{
	}

	protected void MOMQRQJSTIP()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}

	[CompilerGenerated]
	private void OIONPFMSMHP()
	{
	}
}
