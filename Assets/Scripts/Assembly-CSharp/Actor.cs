using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using UnityEngine;

[SelectionBase]
public class Actor : MonoBehaviour, TQFOFKOSKRQ
{
	public bool alive;

	public bool targetable;

	public bool absorbingBullets;

	public ObscuredFloat health;

	public ObscuredFloat shield;

	[NonSerialized]
	public ObscuredFloat maxHealth;

	public Modifications mods;

	public ModificationVisual modsVisuals;

	public AttackModule attackModule;

	public MTGKQSJELIM improvements;

	public PPRIQSHELHN trackedValues;

	public Actor attackTarget;

	public Transform targetPoint;

	public GameObject hitbox;

	public SoundEffect sfxBodyHit;

	public SoundEffect sfxHurt;

	public bool killedSfxDip;

	public SoundEffect gotKilled;

	public GameObject bodyHitFX;

	public SoundEffect footstepWalkSfx;

	public SoundEffect footstepRunSfx;

	public Action<float> OnHealthChanged;

	public Action<float, LQJTRNFQISM, Actor> OnClampedDamageTaken;

	public Action OnAttackTargetFound;

	public Action OnAttackTargetLost;

	public List<LIRQHQSHLNI> preHitHandlers;

	[NonSerialized]
	public bool turning;

	[NonSerialized]
	public bool rolling;

	[SerializeField]
	protected GameObject reviveVFX;

	protected Tween NPJKQTJJELF;

	public event Action<LQJTRNFQISM> ISEMRTFHHNS
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

	public event Action<LQJTRNFQISM, Actor> SOPEFMNTTFQ
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

	public event Action HNMTRPRTRTT
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

	public event Action<bool> SJGQMHNGMMM
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

	protected virtual void OnDestroy()
	{
	}

	public virtual void InitImprovements()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public virtual Transform GetBulletSpawnTransform(int NILJPLQLTLQ = 0)
	{
		return null;
	}

	public virtual float GetNormalizedSpeed()
	{
		return 0f;
	}

	public virtual float GetMaxSpeed()
	{
		return 0f;
	}

	public virtual bool IsGrounded()
	{
		return false;
	}

	public virtual Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public virtual Vector3 GetForwardDir()
	{
		return default(Vector3);
	}

	public virtual EFIIOMLOOHE GetTeam()
	{
		return default(EFIIOMLOOHE);
	}

	public virtual float GetLastMoveTime()
	{
		return 0f;
	}

	public bool IsValidTarget()
	{
		return false;
	}

	public virtual void Teleport(Vector3 PIKMETQIMKF, bool KLLPJSRLGEN = false)
	{
	}

	public virtual float CalculateMaxHealth()
	{
		return 0f;
	}

	public float GetHealthPercentage()
	{
		return 0f;
	}

	public bool IsFullHealth()
	{
		return false;
	}

	public bool CanHit(Actor FKQLEGQSLHF)
	{
		return false;
	}

	public virtual bool CanBeInstaKilled()
	{
		return false;
	}

	public bool IsParalyzed()
	{
		return false;
	}

	public virtual bool Hit(LQJTRNFQISM EMERMLLSHSL)
	{
		return false;
	}

	public void Heal(float ISLTSKEPJPI, bool KLSLIOMKIRO = true)
	{
	}

	public void AddShield(float ISLTSKEPJPI)
	{
	}

	public virtual float GetMoveSpeedMultiplier()
	{
		return 0f;
	}

	public virtual void Push(LQJTRNFQISM EMERMLLSHSL)
	{
	}

	private void EIRPJQLMMIT(ref float NSQGRQMGOJS)
	{
	}

	public float GetTotalShield()
	{
		return 0f;
	}

	public virtual float CalculateDamage(ref LQJTRNFQISM EMERMLLSHSL)
	{
		return 0f;
	}

	protected float EPFRQTLJMMT(float PPTMHMLPFKL)
	{
		return 0f;
	}

	public bool IsDebugInvulnerable()
	{
		return false;
	}

	public virtual void LostAllHealth(LQJTRNFQISM EMERMLLSHSL = null)
	{
	}

	protected void SSFOKJLJOHK(bool RRPSNPOTQNT)
	{
	}

	public virtual void Revive()
	{
	}

	private void SIGTOTIHQTK(LQJTRNFQISM EMERMLLSHSL)
	{
	}

	protected virtual void MHFNOHPTKKI(Modifications.ModificationData TSRPFHOJKSG, bool PEJJOSEKFPK)
	{
	}

	protected virtual void RLOEFOLFIGK(Modifications.ModificationData TSRPFHOJKSG)
	{
	}

	protected virtual void SJFIQRIKNFK()
	{
	}

	protected virtual void FPRPJIRFIKK(WeaponInfo QHNGKJKPMOH)
	{
	}

	protected virtual void REHNMIPHJJI()
	{
	}

	[CompilerGenerated]
	private void ORNRIILPIRR()
	{
	}
}
