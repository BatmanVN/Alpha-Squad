using System;
using UnityEngine;
using UnityEngine.UI;

public class ShopChestCell : MonoBehaviour
{
	[SerializeField]
	private Sprite spriteBackgroundFree;

	[SerializeField]
	private Sprite spriteBackgroundRegular;

	[SerializeField]
	private NotificationBubble notificationBubble;

	[Space]
	[SerializeField]
	private Image background;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image glow;

	[SerializeField]
	private Text priceLabel;

	[SerializeField]
	private Text titleLabel;

	[SerializeField]
	private RectTransform parentForPrefabs;

	[SerializeField]
	private GameObject blockPrice;

	[SerializeField]
	private GameObject blockFree;

	[SerializeField]
	private Image blockFreeIcon;

	[SerializeField]
	private Image blockFreeIconBg;

	[SerializeField]
	private Image priceBackground;

	[SerializeField]
	private GameObject blockNew;

	[Space]
	[SerializeField]
	private GameObject blockSpecial;

	[SerializeField]
	private Image blockSpecialBackground;

	[SerializeField]
	private Image blockSpecialIcon;

	[SerializeField]
	private Image blockSpecialIconBg;

	[SerializeField]
	private SlicedFilledImage specialProgress;

	[SerializeField]
	private Text specialLabel;

	[SerializeField]
	private GameObject blikFree;

	[SerializeField]
	private RectTransform collectBubble;

	[SerializeField]
	private FollowTransform collectBubbleParent;

	[SerializeField]
	private RectTransform collectBubbleFollow;

	[Space]
	[SerializeField]
	private Color colorFreePriceBackground;

	[SerializeField]
	private Color colorRegularPriceBackground;

	[SerializeField]
	private Sprite spriteSpecialBlockBackgroundRegular;

	[SerializeField]
	private Sprite spriteSpecialBlockBackgroundFree;

	[SerializeField]
	private Sprite spriteFillRegular;

	[SerializeField]
	private Sprite spriteFillFree;

	[NonSerialized]
	public JJHFPNTSRLT.ChestPurchaseData purchaseData;

	private ChestController.MFRETPOLGOE ETNRRGQSKEG;

	private int SJNSPJGESHJ;

	private ShopChestOffers FNJLLHKNGOR;

	private bool JQTRRMSTFKP;

	public void Setup(ShopChestOffers FNJLLHKNGOR, JJHFPNTSRLT.ChestPurchaseData JRGIIHLSKML)
	{
	}

	public void Resetup()
	{
	}

	private void OnDestroy()
	{
	}

	private void HTQJPJNLPEL()
	{
	}

	public void LoadPrefab(GameObject GRMOIOOPGSL, string GJOJHKNSGQH)
	{
	}

	public void OnClick()
	{
	}

	public ChestController.MFRETPOLGOE GetChestQuality()
	{
		return default(ChestController.MFRETPOLGOE);
	}
}
