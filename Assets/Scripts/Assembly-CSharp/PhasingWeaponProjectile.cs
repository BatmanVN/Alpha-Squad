using UnityEngine;

public class PhasingWeaponProjectile : WeaponDamageEntity
{
	[SerializeField]
	protected Rigidbody rb;

	[SerializeField]
	protected float damageMultiplerPerHit;

	[SerializeField]
	protected float hitInterval;

	[SerializeField]
	protected SoundEffect damagedSound;

	[SerializeField]
	protected float radius;

	[SerializeField]
	protected float maxTravelDistance;

	[SerializeField]
	protected GameObject hitFx;

	[SerializeField]
	protected float velocityMultiplier;

	[SerializeField]
	protected bool destroySelfOnHit;

	[SerializeField]
	protected bool boomerang;

	[SerializeField]
	protected float boomerangDuration;

	protected float JEMKOHSPRRN;

	protected float NNHLSNSLNSK;

	protected float SFKTTGTOEKH;

	protected Vector3 GLGRLNQLHJL;

	protected float EFTPSEFJFSM;

	private void OnValidate()
	{
	}

	public override void Setup(Actor TNKMMOJJPPI, WeaponInfo GLRSKRPPLFQ, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = 0)
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	protected void IRRPQGMTMQK()
	{
	}

	private void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	private void STNSQIGGHFI(Actor ETGMMEJFEOP)
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}
}
