using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeaponBonusesVisual : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class EHPFFKNLIIK
	{
		public WeaponBonusesVisual _003C_003E4__this;

		public Text activeLabel;

		internal void _003CSetup_003Eb__0(float x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class KKESQOTKOKM
	{
		public ItemWeapon.Bonus bonus;

		public EHPFFKNLIIK CS_0024_003C_003E8__locals1;

		internal bool _003CSetup_003Eb__2(JJHFPNTSRLT.PredefinedWeaponBonus x)
		{
			return false;
		}

		internal bool _003CSetup_003Eb__3(WeaponInfoBonusElement x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class JFMRETJJMMS
	{
		public int clickidx;

		public KKESQOTKOKM CS_0024_003C_003E8__locals2;

		internal void _003CSetup_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class TGLJPNMTOGH
	{
		public ItemWeapon.Bonus bonus;

		internal bool _003CSetupForSneakPeak_003Eb__0(JJHFPNTSRLT.PredefinedWeaponBonus x)
		{
			return false;
		}

		internal bool _003CSetupForSneakPeak_003Eb__1(WeaponInfoBonusElement x)
		{
			return false;
		}
	}

	[SerializeField]
	private GameObject prefabBonusSeparator;

	[SerializeField]
	private GameObject prefabBonusSeparatorSmall;

	[SerializeField]
	private WeaponInfoBonusElement prefabBonus;

	[SerializeField]
	private GameObject viewFewBonuses;

	[SerializeField]
	private GameObject viewManyBonuses;

	[SerializeField]
	private RectTransform bonusesParentFew;

	[SerializeField]
	private RectTransform bonusesParentMany;

	[SerializeField]
	private Text labelAttributePowerMore;

	[SerializeField]
	private Text labelAttributePowerLess;

	private bool KMOPHEKMHOL;

	private float IRMFTPGPRRS;

	private ItemWeapon LENQOPNFMTG;

	public void Setup(ItemWeapon TSRPFHOJKSG, bool KQGHGPEKKTJ = false)
	{
	}

	public void SetupForSneakPeak(ItemWeapon TSRPFHOJKSG, bool KQGHGPEKKTJ = false)
	{
	}

	public void SetupForPurchase()
	{
	}

	public void DisableScroll()
	{
	}

	public void OnBonusElementClick(int PNIQKIGEHLF)
	{
	}
}
