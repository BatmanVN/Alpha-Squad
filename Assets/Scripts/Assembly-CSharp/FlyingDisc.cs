using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FlyingDisc : DamageEntity
{
	public float speed;

	public float duration;

	public float radius;

	public GameObject visual;

	[SerializeField]
	protected TrailRenderer[] trails;

	[SerializeField]
	protected GameObject hitTargetFX;

	[SerializeField]
	protected SoundEffect hitSfx;

	[SerializeField]
	protected ParticleSystem trailParticles;

	[SerializeField]
	protected List<Actor> hitActors;

	protected Actor FNJLLHKNGOR;

	protected float NSQGRQMGOJS;

	protected float QMOTKOSPIOL;

	protected Vector3 RNFGPMJQIFP;

	protected Vector3 GLGRLNQLHJL;

	protected bool ITNHQOGKKLE;

	private Vector3 PQSIRKQLRTT;

	private Vector3 FHJIIMLHNHG;

	private float KIOKPNPLRKK;

	private float GQOSFGNJQLT;

	private float GGKKJIGEHPO;

	private int IEKPNHIFTGS;

	private bool JNKQPRQFJLI;

	protected Rigidbody ISKPFKOLSRK;

	protected virtual void Awake()
	{
	}

	public virtual void Setup(Actor TNKMMOJJPPI, float QHPEGHJEESR, Vector3 ESKHSLFMOIH)
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

	protected virtual void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	protected void OnTriggerExit(Collider FKQLEGQSLHF)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private Vector2 EPIQFOFNIOP(float OEESQHTSGJL, Vector2 PTQSLGPQSGG)
	{
		return default(Vector2);
	}

	[CompilerGenerated]
	private void LNKOIGIOSJN()
	{
	}

	[CompilerGenerated]
	private void NHIFFRLNIGH()
	{
	}
}
