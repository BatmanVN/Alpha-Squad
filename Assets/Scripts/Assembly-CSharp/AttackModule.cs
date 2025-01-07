using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using UnityEngine;

public class AttackModule : MonoBehaviour
{
	public enum HFLTRROLNHR
	{
		None = 0,
		Aiming = 1,
		Shooting = 2,
		PreCooldown = 3,
		Cooldown = 4
	}

	public interface MLHRLQNFMJL
	{
		bool CanAim();

		Vector3 CalculateAimPosition();
	}

	[CompilerGenerated]
	private sealed class LGISPKKTGIR
	{
		public AttackModule _003C_003E4__this;

		public bool bonusShot;

		internal void _003CShoot_003Eb__0()
		{
		}
	}

	public const int LAYER_HITBOX_MASK = 2048;

	public WeaponInfo weaponInfo;

	[NonSerialized]
	public Weapon weapon;

	[NonSerialized]
	public Weapon secondWeapon;

	public HFLTRROLNHR state;

	public float aimAhead;

	public List<object> timerPausers;

	public bool freeReload;

	public Action OnAmmoChanged;

	public Action OnReloading;

	public Func<bool> CanShootAfterReload;

	public MLHRLQNFMJL aimPositionProvider;

	private Vector3 INOIKJIQHSQ;

	private float EKFSSTEMLFQ;

	private ObscuredInt HLKNRNHEMHO;

	private Actor FNJLLHKNGOR;

	private Actor ETGMMEJFEOP;

	private float KFROGJSKKSE;

	private int NQJKOPOFHJO;

	public int burstIndex;

	private int NILJPLQLTLQ;

	private List<Tween> TSFQTHLJRJE;

	private Tween KJTTRSPHPLR;

	public WeaponData KROTEKTFGLI
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Actor JJJESSESITM => null;

	public int PNHGQMGKGEQ => 0;

	public event Action KQHIPGQTKPL
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

	public event Action<GameObject> HRPIHINLRFI
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

	public event Action PHGTELONSEN
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

	public event Action IELPSGESLPS
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

	public event Action MKGJSLKROQQ
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

	public event Action<WeaponInfo> MMFEKTHNTTT
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

	public event Action<WeaponInfo> HFOLSSRTGJK
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

	public event Action IGHNORIGORE
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

	public event Action KNKQFSOFNGI
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

	public void Setup(Actor TNKMMOJJPPI)
	{
	}

	public void SetTarget(Actor NIHPIGRSJMO)
	{
	}

	public void TryAttacking(Actor NIHPIGRSJMO)
	{
	}

	public void InitiatePreCooldown()
	{
	}

	public void ResetReloadFinishTime()
	{
	}

	public void Stop()
	{
	}

	public bool IsInAttackRange(Actor NIHPIGRSJMO)
	{
		return false;
	}

	public float GetSqrDistanceToActor(Actor NIHPIGRSJMO)
	{
		return 0f;
	}

	public Vector3 GetAimPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetAimTarget(Actor NIHPIGRSJMO)
	{
		return default(Vector3);
	}

	public void UpdateAim()
	{
	}

	public Vector3 CalculateAimPosition()
	{
		return default(Vector3);
	}

	private float MEEOJHQJIIQ()
	{
		return 0f;
	}

	public void SoftUpdate()
	{
	}

	public bool CanAim()
	{
		return false;
	}

	public bool HasReloaded()
	{
		return false;
	}

	public void ReloadAmmo()
	{
	}

	public void ResetAmmo()
	{
	}

	public void RecheckAmmo()
	{
	}

	public void SetAmmo(int NRPQFLLNPPK)
	{
	}

	public int GetAmmo()
	{
		return 0;
	}

	public float GetAmmoPercent()
	{
		return 0f;
	}

	public bool IsClipFull()
	{
		return false;
	}

	public float GetReloadFinishTime()
	{
		return 0f;
	}

	public void SetReloadFinishTime(float JPKGQSMKSTF)
	{
	}

	public float GetReloadProgress()
	{
		return 0f;
	}

	private bool PHRGLQFHOOM()
	{
		return false;
	}

	private void ISJHFORTKKL(bool HPTHPFISTJR = false)
	{
	}

	private void NIJSHFJGGKI(bool HPTHPFISTJR)
	{
	}

	private void RLHQINFFSHO()
	{
	}

	private void FFGPILPGPON(WeaponData.MeleeHit KFQFFQTKIJT)
	{
	}

	public Transform GetBulletSpawnTransform()
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}

	public void CheckSpawnWeapon(bool QPQHPESTRSR = false)
	{
	}

	public Transform GetWeaponAttachmentTransform()
	{
		return null;
	}

	public Actor GetTargetActor()
	{
		return null;
	}

	public float GetVariedBulletSpeed()
	{
		return 0f;
	}

	public float GetTimer()
	{
		return 0f;
	}

	public float GetCooldownProgress()
	{
		return 0f;
	}

	[CompilerGenerated]
	private void FFRLSLNSSKT()
	{
	}
}
