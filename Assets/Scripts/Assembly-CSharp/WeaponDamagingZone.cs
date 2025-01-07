using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeaponDamagingZone : WeaponDamageEntity
{
	[Serializable]
	public struct ModEntry
	{
		public NNFTTJERLEM mod;

		public float value;

		public float duration;

		public bool customIdentifier;

		public int identifier;

		public void SPOHPGSNSMJ(Actor ETGMMEJFEOP, Actor FNJLLHKNGOR)
		{
		}
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
	private bool damagePlayer;

	[SerializeField]
	private bool damageEnemy;

	[SerializeField]
	protected float radius;

	[SerializeField]
	public float stayAliveTime;

	[SerializeField]
	private bool collisionYDistClip;

	[SerializeField]
	private float collisionMaxYDist;

	[SerializeField]
	private bool hapticOnHit;

	[SerializeField]
	private SoundEffect startSound;

	[SerializeField]
	private SoundEffect endSound;

	[SerializeField]
	private SoundEffect doDamageSound;

	[SerializeField]
	public WeaponDamagingZoneVisual assignedVisual;

	public bool testDrawGizmos;

	private float NFOMNEMEHNG;

	private float EKFSSTEMLFQ;

	private const float LGMGRFGOEIK = 0.1f;

	private float SLTEOOHHMRS;

	private float FFPMTINETOM;

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

	protected virtual void FixedUpdate()
	{
	}

	private bool PQTLMEOPQTH()
	{
		return false;
	}

	private void QTLNNKTOIPN()
	{
	}

	private void SEMHJGEMLKM(Actor ETGMMEJFEOP)
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}
}
