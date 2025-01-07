using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ExplosiveProjectile : ProjectileLogic
{
	public Action<Vector3> OnExplode;

	public float radius;

	public float acceleration;

	public bool overrideStartingSpeed;

	public float startingSpeed;

	[SerializeField]
	public ExplosiveProjectileVisual assignedVisual;

	protected Actor IFLMTQRKLKK;

	protected bool QFNMNRLMLFL;

	private float FFPMTINETOM;

	public new event Action IQOOQMSMNRM
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

	protected override void Awake()
	{
	}

	public override void Setup(Actor TNKMMOJJPPI, WeaponInfo GLRSKRPPLFQ, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = 0)
	{
	}

	protected virtual void LFEJGLTRLTQ(WeaponInfo GLRSKRPPLFQ)
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

	private new void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	protected override void OnCollisionEnter(Collision QFRIINRRGIM)
	{
	}

	protected override void OnEnable()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	protected virtual void HOMKJKTHSTL()
	{
	}

	protected override void Destroy(bool NRLORILTSJR = false)
	{
	}

	private float ILTPRPHNFOO(float RTGEPIFMSES)
	{
		return 0f;
	}
}
