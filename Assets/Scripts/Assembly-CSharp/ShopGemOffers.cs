using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ShopGemOffers : ShopOffer
{
	[CompilerGenerated]
	private sealed class GSEOPPHTQSN
	{
		public int v;

		public ShopGemOffers _003C_003E4__this;

		internal void _003CSetup_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class PEMTLNERPON
	{
		public RectTransform from;

		public JJHFPNTSRLT.BasicPurchase p;

		public ShopGemOffers _003C_003E4__this;

		internal void _003COnClickPurchase_003Eb__0(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class PHGPQKOTKKG
	{
		public GameObject block;

		internal void _003CAnimateCellsAfterAutoscroll_003Eb__0()
		{
		}
	}

	private JJHFPNTSRLT.BasicPurchase[] TNEINMPNFTM;

	[SerializeField]
	private GameObject[] blocks;

	[SerializeField]
	private LayoutElement leMe;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image ribbon;

	[SerializeField]
	private Sprite redRibbon;

	[SerializeField]
	private Sprite pinkRibbon;

	[SerializeField]
	private GameObject bonusRibbon;

	[SerializeField]
	private GameObject bonusInfoField;

	[SerializeField]
	private RectTransform titleLabel;

	[SerializeField]
	private Sprite spriteBF_background;

	[SerializeField]
	private Sprite spriteBF_cellBackground;

	[SerializeField]
	private Sprite spriteBF_infoBackground;

	[SerializeField]
	private Color colorBF_priceBg;

	[SerializeField]
	private GameObject blockBF_info;

	[SerializeField]
	private GameObject backgroundBF_extras;

	[SerializeField]
	private GameObject blockBF_timer;

	[SerializeField]
	private Vector2 sizeBF;

	[SerializeField]
	private Sprite spriteREG_background;

	[SerializeField]
	private Sprite spriteREG_cellBackground;

	[SerializeField]
	private Sprite spriteREG_infoBackground;

	[SerializeField]
	private Color colorREG_priceBg;

	[SerializeField]
	private Vector2 sizeReg;

	private bool IGINOTPGTLO;

	public override bool IsAvailable()
	{
		return false;
	}

	public override void Setup(MenuViewShop QJPITOLEQFL)
	{
	}

	public void OnClickPurchase(int KQQINSRPRNP)
	{
	}

	public override void Recheck()
	{
	}

	public override void InitPrice()
	{
	}

	public override void AnimateCells()
	{
	}

	public void AnimateCellsAfterAutoscroll()
	{
	}

	public override LootElement.TOINELPLRQP GetCurrencyType()
	{
		return default(LootElement.TOINELPLRQP);
	}

	public void Hide()
	{
	}

	public void OnBlackFridayTimerUp()
	{
	}
}
