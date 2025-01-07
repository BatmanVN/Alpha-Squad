using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPreviewLarge : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MFRSQFTTNFT
	{
		public ItemWeapon data;

		internal bool _003CSetup_003Eb__1(JJHFPNTSRLT.RarityColor x)
		{
			return false;
		}
	}

	[SerializeField]
	private GameObject prefabEmpower;

	[SerializeField]
	private GameObject prefabRankNotReached;

	[SerializeField]
	private GameObject prefabRankReached;

	[SerializeField]
	private RectTransform rankParent;

	[SerializeField]
	private RectTransform empowerParent;

	[SerializeField]
	private RectTransform weaponParent;

	[SerializeField]
	private RectTransform weaponFitRect;

	[SerializeField]
	private Text labelLevelProgress;

	[SerializeField]
	private Image fillLevelProgress;

	[SerializeField]
	private WeaponRarityStars rarityStars;

	[SerializeField]
	private GameObject maxUpgradeAnimation;

	[SerializeField]
	private Image progressFillImage;

	[SerializeField]
	private Sprite fillMax;

	[SerializeField]
	private Sprite fillRegular;

	[SerializeField]
	private Image weaponCategoryIconFill;

	[SerializeField]
	private Image weaponCategoryIcon;

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private Text labelCp;

	[SerializeField]
	private Text labelCategory;

	[SerializeField]
	private UIRotatingElement spinnigWeapon;

	[SerializeField]
	private Animator weaponPreviewAnimator;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image glowImage;

	[SerializeField]
	private GameObject progressBlock;

	[SerializeField]
	private GameObject categoryBlock;

	[SerializeField]
	private List<JJHFPNTSRLT.RarityColor> glowColors;

	[SerializeField]
	public GameObject swapBlock;

	public int rankUpCount;

	public int empowerLevel;

	private ItemWeapon TSRPFHOJKSG;

	private bool TINQMMMKGKI;

	public event Action<GameObject> QOGPQTQRKJG
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

	public event Action<GameObject> EOEOIJNMORL
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

	public void Setup(ItemWeapon TSRPFHOJKSG, bool ROMGOMISSOS = false)
	{
	}

	public void SetupForPurchase()
	{
	}

	private void FHRGJHEGIIK()
	{
	}

	private void EKGQSHSNGFM(bool KQGHGPEKKTJ = true)
	{
	}

	private void QJGFGIRFRTI(bool KQGHGPEKKTJ = true)
	{
	}

	public void UpdateLevel()
	{
	}

	public void UpdateCp(bool TLRKMHLNGTE)
	{
	}

	public void SetIgnoreNextRankUpAnim(bool MJPJLPIKQFE)
	{
	}

	public void SpinWeapon()
	{
	}

	public void PlayUpgradeAnim()
	{
	}

	public void PlayRankUpAnim()
	{
	}
}
