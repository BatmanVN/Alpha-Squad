using System.Runtime.CompilerServices;
using UnityEngine;

public class BasicProjectile : DamageEntity
{
	public float duration;

	public float speed;

	[SerializeField]
	protected bool applyMods;

	[SerializeField]
	protected WeaponDamagingZone.ModEntry[] customMods;

	[SerializeField]
	protected GameObject visual;

	[SerializeField]
	protected TrailRenderer[] trails;

	[SerializeField]
	protected GameObject hitTargetFX;

	[SerializeField]
	protected GameObject hitEnvironmentFX;

	public SoundEffect hitSfx;

	protected Vector3 GLGRLNQLHJL;

	protected Actor FNJLLHKNGOR;

	protected float NSQGRQMGOJS;

	protected float QMOTKOSPIOL;

	protected Rigidbody ISKPFKOLSRK;

	protected bool LPFGGMGHHTH;

	protected virtual void Awake()
	{
	}

	public virtual void Setup(Actor TNKMMOJJPPI, float QHPEGHJEESR, Vector3 NFFNFMETPLT)
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	protected virtual void MMRTMTRQNTF(bool NRLORILTSJR = false)
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}

	public void SetHitMutable(bool JKRQSLILLQK)
	{
	}

	protected virtual void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	protected virtual void JNMNRRRTFNN(Actor ETGMMEJFEOP)
	{
	}

	protected virtual void OnCollisionEnter(Collision QFRIINRRGIM)
	{
	}

	[CompilerGenerated]
	private void HNSFJMRFJMT()
	{
	}

	[CompilerGenerated]
	private void JQLITMJPLLJ()
	{
	}
}
