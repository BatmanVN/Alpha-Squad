using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeaponDamagingArc : WeaponDamageEntity
{
	[Serializable]
	public struct ModEntry
	{
		public NNFTTJERLEM mod;

		public float value;

		public float duration;
	}

	[SerializeField]
	public float weaponDamageMultiplier;

	[SerializeField]
	public float damageInterval;

	[SerializeField]
	private ITKSRPQLPQN damageType;

	[SerializeField]
	private ModEntry[] customMods;

	[SerializeField]
	private float arcSize;

	[SerializeField]
	private bool damagePlayer;

	[SerializeField]
	private bool damageEnemy;

	[SerializeField]
	private float range;

	[SerializeField]
	public float stayAliveTime;

	[SerializeField]
	public bool hitOnce;

	[SerializeField]
	public bool raycastHits;

	[SerializeField]
	private bool instantDestroy;

	public bool testDrawGizmos;

	private float NFOMNEMEHNG;

	private float KQKGQFFKQTJ;

	private new bool KGTEOOSQHGO;

	private List<Actor> SHLJNELOFFT;

	private RaycastHit[] LPKQHERRFGG;

	private int JETJONPMJHF;

	private List<Vector3> TOKFHPLHJTP;

	[SerializeField]
	private LightningRenderer[] lightningRenderers;

	private bool PQTLMEOPQTH => false;

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

	public event Action<Actor> LTQQFPMHIJO
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

	private void Awake()
	{
	}

	public override void Setup(Actor TNKMMOJJPPI, WeaponInfo GLRSKRPPLFQ, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = -1)
	{
	}

	public float GetRadius()
	{
		return 0f;
	}

	private void FixedUpdate()
	{
	}

	private void QTLNNKTOIPN()
	{
	}

	private void GHHSHIOKJHK()
	{
	}

	private new void Destroy(bool NRLORILTSJR = false)
	{
	}

	private void SEMHJGEMLKM(Actor ETGMMEJFEOP)
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}

	[CompilerGenerated]
	private void JJGIHJJNLNP()
	{
	}
}
