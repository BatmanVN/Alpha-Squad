using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ShopChestInfoPopupFeaturedWeaponBlock : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PERLQLIJKFK
	{
		public ItemWeapon featured;

		internal bool _003CSetupLegendary_003Eb__0(ItemWeapon x)
		{
			return false;
		}

		internal bool _003CSetupLegendary_003Eb__1(JJHFPNTSRLT.RarityColor x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NPRJOETEIPP
	{
		public (JPHMLSJQLNL, JJHFPNTSRLT.PQRIQGIOGQT) featured;

		internal bool _003CSetupWeapon_003Eb__0(JJHFPNTSRLT.RarityColor x)
		{
			return false;
		}
	}

	[SerializeField]
	private LayoutElement layoutElement;

	[SerializeField]
	private List<JJHFPNTSRLT.RarityColor> specialWeaponGlowColors;

	[SerializeField]
	private WeaponRarityStars starsFeaturedWeapon;

	[SerializeField]
	private Image imgFeaturedWeaponGlow;

	[SerializeField]
	private Image imgFeaturedWeaponBackground;

	[SerializeField]
	private RectTransform rectFeaturedWeaponParent;

	[SerializeField]
	private RectTransform rectFeaturedWeaponFit;

	[SerializeField]
	private Text labelFeaturedWeaponTitle;

	[SerializeField]
	private Image imgFeaturedWeaponCategory;

	[SerializeField]
	private GameObject overlayFeaturedWeaponCollected;

	[SerializeField]
	private UIRotatingElement spinningWeapon;

	[SerializeField]
	private GameObject[] weaponSwapParticles;

	[SerializeField]
	private GameObject duplicateLegendaryBlock;

	[SerializeField]
	private GameObject duplicateLegendaryBubble;

	[SerializeField]
	private Button skipButton;

	[SerializeField]
	private GameObject blockSkipButtonFree;

	[SerializeField]
	private GameObject blockSkipButtonPaid;

	[SerializeField]
	private GameObject blockSkipButtonUnavailable;

	[SerializeField]
	private Text labelPriceSkip;

	[SerializeField]
	private Text labelRerollCount;

	[SerializeField]
	private GameObject blockTimerOffer;

	[SerializeField]
	private GameObject blockTimerWeapon;

	[SerializeField]
	private UITextTimer timerOffer;

	[SerializeField]
	private UITextTimer timerWeaponsOffer;

	[SerializeField]
	private Text labelGuaranteeIn;

	[SerializeField]
	private GameObject guaranteedBlock;

	private ChestController.ChestData LIEEKNMLQJJ;

	public void Setup(ChestController.ChestData NKSTGGFNTSP)
	{
	}

	private void GMJPPPSMFPT()
	{
	}

	private void PJKTSJPJHOR()
	{
	}

	private void ITPIQRKOLJH()
	{
	}

	public void Hide()
	{
	}

	public Transform GetSkipButtonTransform()
	{
		return null;
	}

	public void PlayWeaponChangeAnim()
	{
	}

	public void ShowInfoDuplicateLegendary()
	{
	}

	public void HideInfoDuplicateLegendary()
	{
	}
}
