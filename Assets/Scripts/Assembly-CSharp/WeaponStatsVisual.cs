using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeaponStatsVisual : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LKTKOMPIHIG
	{
		public float realDamage;

		public float baseDamage;

		public float usedLastRealDamage;

		public float usedLastBaseDamage;

		public WeaponStatsVisual _003C_003E4__this;

		internal void _003CSetup_003Eb__0(float x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class LQFTFJJRFHE
	{
		public float realDamage;

		public float usedLastRealDamage;

		public WeaponStatsVisual _003C_003E4__this;

		internal void _003CSetup_003Eb__1(float x)
		{
		}
	}

	[SerializeField]
	private Text labelDamage;

	[SerializeField]
	private Text labelDamageIncrease;

	[SerializeField]
	private Text labelRange;

	[SerializeField]
	private Text labelRateOfFire;

	[SerializeField]
	private Text labelAccuracy;

	[SerializeField]
	private Text labelBulletsPerShot;

	[SerializeField]
	private Text labelCritChance;

	[SerializeField]
	private Text labelCritDamage;

	[SerializeField]
	private Text labelAmmo;

	[SerializeField]
	private Text labelCooldown;

	[SerializeField]
	private Text labelExplosionRadius;

	[SerializeField]
	private Text labelExplosionDPS;

	[SerializeField]
	private Text labelAimTime;

	[SerializeField]
	private GameObject statBlockDamage;

	[SerializeField]
	private GameObject statBlockRange;

	[SerializeField]
	private GameObject statBlockRateOfFire;

	[SerializeField]
	private GameObject statBlockBulletsPerShot;

	[SerializeField]
	private GameObject statBlockAccuracy;

	[SerializeField]
	private GameObject statBlockCritChance;

	[SerializeField]
	private GameObject statBlockCritDamage;

	[SerializeField]
	private GameObject statBlockAmmo;

	[SerializeField]
	private GameObject statBlockCooldown;

	[SerializeField]
	private GameObject statBlockExplosionRadius;

	[SerializeField]
	private GameObject statBlockExplosionDps;

	[SerializeField]
	private GameObject statBlockAimTime;

	[SerializeField]
	private GameObject increaseBlock;

	private float ERQQTGNOLTQ;

	private float NFMRSPNNKHG;

	public void Setup(ItemWeapon TSRPFHOJKSG, bool KQGHGPEKKTJ = false)
	{
	}

	public void SetupForPurchase()
	{
	}

	public void SetupForSneakPeak(ItemWeapon TSRPFHOJKSG)
	{
	}
}
