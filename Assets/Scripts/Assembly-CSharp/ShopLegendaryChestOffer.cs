using UnityEngine;
using UnityEngine.UI;

public class ShopLegendaryChestOffer : ShopOffer
{
	[SerializeField]
	private Sprite spriteBackgroundFree;

	[SerializeField]
	private Sprite spriteBackgroundRegular;

	[Space]
	[SerializeField]
	private Image background;

	[SerializeField]
	private GameObject bottonRegular;

	[SerializeField]
	private GameObject bottonClaim;

	[SerializeField]
	private GameObject glow;

	[SerializeField]
	private GameObject beams;

	[SerializeField]
	private GameObject claimedBG;

	[SerializeField]
	private GameObject checkmark;

	[SerializeField]
	private Text labelTokenProgress;

	[SerializeField]
	private GameObject firstTryChangeRibbon;

	[SerializeField]
	private SlicedFilledImage fillTokenProgress;

	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private RectTransform weaponParent;

	[SerializeField]
	private RectTransform weaponFitRect;

	[SerializeField]
	private UITextTimer timerWeaponsOffer;

	[SerializeField]
	private Text xChanceLabel;

	public override bool IsAvailable()
	{
		return false;
	}

	public override void Setup(MenuViewShop QJPITOLEQFL)
	{
	}

	public void InitCell()
	{
	}

	private void FHRGJHEGIIK()
	{
	}

	public void OnClick()
	{
	}
}
