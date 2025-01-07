using UnityEngine;

public class Projectile : ProjectileLogic
{
	[SerializeField]
	public GameObject visual;

	[SerializeField]
	private TrailRenderer[] trails;

	[SerializeField]
	private ParticleSystem particles;

	[SerializeField]
	protected GameObject hitEnvironmentFX;

	[SerializeField]
	protected GameObject hitTargetFX;

	[SerializeField]
	protected GameObject bulletHoleFX;

	public SoundEffect richochetSound;

	public override void Setup(Actor TNKMMOJJPPI, WeaponInfo GLRSKRPPLFQ, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = 0)
	{
	}

	protected override void QEJLSEMMQSG(TQFOFKOSKRQ IRPOKKFIOIO)
	{
	}

	protected override void OnCollisionEnter(Collision QFRIINRRGIM)
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void Destroy(bool NRLORILTSJR = false)
	{
	}
}
