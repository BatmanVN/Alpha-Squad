using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ShopChestInfoPopup : UIPopup
{
	public enum KMRSITJNLSK
	{
		TOKEN_X1 = 0,
		GEMS_X1 = 1,
		WP_TOKEN_X1 = 2,
		GEMS_X10 = 3,
		TOKEN_X10 = 4
	}

	[CompilerGenerated]
	private sealed class INPGPNGHKGQ
	{
		public ShopWeaponChestData wcd;

		public ShopChestInfoPopup _003C_003E4__this;

		internal void _003COnSkipFeaturedButton_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class LMKTSLKFENN
	{
		public ShopLegendaryChestData wcd;

		public ShopChestInfoPopup _003C_003E4__this;

		internal void _003COnSkipFeaturedButton_003Eb__1()
		{
		}
	}

	[SerializeField]
	private FloatingErrorText prefabFloatingErrorText;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private RectTransform chestIconRect;

	[SerializeField]
	private Image imgChestIcon;

	[SerializeField]
	private Image imgChestIconSmall;

	[SerializeField]
	private Text labelChestTitle;

	[SerializeField]
	private List<JJHFPNTSRLT.QualitySprite> titleBackgrounds;

	[SerializeField]
	private List<JJHFPNTSRLT.QualityColor> qualityColors;

	[SerializeField]
	private Image imgTitleBackground;

	[SerializeField]
	private Image imgChestBeams;

	[SerializeField]
	private Image imgChestGlow;

	[SerializeField]
	private ShopChestInfoPopupBasicBlock blockBasic;

	[SerializeField]
	private ShopChestInfoPopupPossibleLootBlock blockPossibleLoot;

	[SerializeField]
	private ShopChestInfoPopupFeaturedWeaponBlock blockFeaturedWeapon;

	[SerializeField]
	private ShopChestInfoPopupFeaturedResourceBlock blockFeaturedResource;

	[SerializeField]
	private ShopChestInfoPopupBlockFeaturedWeaponParts blockFeaturedWeaponParts;

	[SerializeField]
	private ShopChestInfoPopupBlockPossibleWeaponParts blockPossibleWeaponParts;

	[SerializeField]
	private ShopChestInfoPopupOpenSelectWeaponChestBlock blockSelectWeapon;

	[SerializeField]
	private ShopChestInfoPopupOpenSelectBlock blockSelect;

	[SerializeField]
	private ShopChestInfoPopupButtonsBlock blockButton;

	private ChestController.ChestData LIEEKNMLQJJ;

	private JJHFPNTSRLT.ChestPurchaseData GTLNLRETMIT;

	private bool FHNMFIFIORF;

	public static KMRSITJNLSK lastOpenType;

	private ItemWeapon HQEKLQJIHNG;

	protected override void MGKPMPHSLFR()
	{
	}

	private void HFEPNGRMGIL(int PHRHFKPLRIL)
	{
	}

	public static void Open(JJHFPNTSRLT.ChestPurchaseData MOLEPPSOPLP)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public static void OpenNoPurchase(ChestController.ChestData IEHEOOQKSKK)
	{
	}

	public void Setup(JJHFPNTSRLT.ChestPurchaseData MOLEPPSOPLP)
	{
	}

	private void RHLILLSSOPO()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void OKEFRIIOGNE()
	{
	}

	private void THRNERIPNJR()
	{
	}

	private void LLGTHJRFQTK()
	{
	}

	private void GFIIRSGEJHM()
	{
	}

	private void ILIJEFTSOGK()
	{
	}

	public void OnOpenPaidButton()
	{
	}

	public void OnOpenPaidX10Button()
	{
	}

	public void OnOpenPaidDisabledButton()
	{
	}

	public void OnOpenPaidX10DisabledButton()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnSkipFeaturedButton()
	{
	}

	public void OnOpenSpecialButton()
	{
	}

	public void OnOpenSpecialx10Button()
	{
	}

	public void OnInspectButton()
	{
	}

	public void OnOpenSelectChest()
	{
	}

	public void OnOpenSelectMinor()
	{
	}

	public void OnOpenSelectMajor()
	{
	}

	public void OnExplanationButtonClick()
	{
	}

	public void OnExplanationClose()
	{
	}

	private void FQLJOOMRPRN(string GKKFNISSPRI)
	{
	}

	public void OnTimerEnd()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void JSLMHNEQLGJ()
	{
	}

	public void OnDuplicateLegendaryClick()
	{
	}

	public void OnDuplicateLegendaryCloseClick()
	{
	}

	public void HighlightFeatured(JJHFPNTSRLT.WeaponPartIdentifier TTELHPSKNOL)
	{
	}

	[CompilerGenerated]
	private bool OKRNIKPPSEF(JJHFPNTSRLT.QualitySprite HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private bool ROEHIOKLMMG(JJHFPNTSRLT.QualityColor HNLHQPIFJNS)
	{
		return false;
	}
}
