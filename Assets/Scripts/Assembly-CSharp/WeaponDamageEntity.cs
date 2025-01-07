using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class WeaponDamageEntity : DamageEntity
{
	[NonSerialized]
	public Actor owner;

	[NonSerialized]
	public WeaponInfo weapon;

	[NonSerialized]
	public AttackModule attackModule;

	[NonSerialized]
	public int bulletIndex;

	[SerializeField]
	public WeaponDamageEntity afterHit;

	[SerializeField]
	public float afterHitDelay;

	[SerializeField]
	private bool destroyOnOwnerDie;

	public float previousAttackTime;

	protected bool KGTEOOSQHGO;

	protected Tween PFMHQHNMSEH;

	public event Action IQOOQMSMNRM
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

	public virtual void Setup(Actor TNKMMOJJPPI, WeaponInfo GLRSKRPPLFQ, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = 0)
	{
	}

	protected virtual void OnDisable()
	{
	}

	public Actor GetOwner()
	{
		return null;
	}

	public override Ragdoll.FKHQTISHHSK GetRagdollArea()
	{
		return default(Ragdoll.FKHQTISHHSK);
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}

	protected void RKNLKNKEMTO()
	{
	}

	protected virtual void EFPGTGGGNSQ(LQJTRNFQISM EMERMLLSHSL, Actor FQMEIQKQEQJ)
	{
	}

	public virtual void Destroy(bool NRLORILTSJR = false)
	{
	}

	protected void NQFJNITHTMO()
	{
	}

	[CompilerGenerated]
	private void HJHOEIOTLFS()
	{
	}

	[CompilerGenerated]
	private void LNFNETFOSQS()
	{
	}
}
