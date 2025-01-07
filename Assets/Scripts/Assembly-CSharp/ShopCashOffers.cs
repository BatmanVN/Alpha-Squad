using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ShopCashOffers : ShopOffer
{
	[Serializable]
	public struct CashScaling
	{
		public List<LevelAmount> offer0;

		public List<LevelAmount> offer1;

		public List<LevelAmount> offer2;

		public const int OFFER_COUNT = 3;
	}

	[Serializable]
	public struct LevelAmount
	{
		public int lvl;

		public int amount;
	}

	[CompilerGenerated]
	private sealed class ETRIKPJQFEI
	{
		public int v;

		public ShopCashOffers _003C_003E4__this;

		internal void _003CSetup_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class JQNNJOLKOQL
	{
		public ShopCashOffers _003C_003E4__this;

		public int i;

		public JJHFPNTSRLT.GemPurchase p;
	}

	[CompilerGenerated]
	private sealed class KFOGPFIOQNS
	{
		public GameObject block;

		internal void _003CAnimateCellsAfterAutoscroll_003Eb__0()
		{
		}
	}

	private JJHFPNTSRLT.GemPurchase[] TNEINMPNFTM;

	[SerializeField]
	private GameObject[] blocks;

	[SerializeField]
	private GameObject specialOfferBlock;

	[SerializeField]
	private GameObject specialOfferFlavorBlock;

	[SerializeField]
	private UITextTimer specialOfferTimer;

	[SerializeField]
	private Text labelSpecialOfferIncreaseAmount;

	[Space]
	[SerializeField]
	private Text timerLabel;

	[Space]
	[SerializeField]
	private Image background;

	[SerializeField]
	private Image infoBackground;

	[SerializeField]
	private Sprite spriteBF_background;

	[SerializeField]
	private Sprite spriteBF_cellBackground;

	[SerializeField]
	private Sprite spriteBF_infoBackground;

	[SerializeField]
	private Color colorBF_outlineTimer;

	[SerializeField]
	private Color colorBF_priceBg;

	[SerializeField]
	private GameObject blockBF_info;

	[SerializeField]
	private GameObject backgroundBF_extras;

	[SerializeField]
	private Sprite spriteREG_background;

	[SerializeField]
	private Sprite spriteREG_cellBackground;

	[SerializeField]
	private Sprite spriteREG_infoBackground;

	[SerializeField]
	private GameObject blockREG_info;

	[SerializeField]
	private Color colorREG_outlineTimer;

	[SerializeField]
	private Color colorREG_priceBg;

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

	public override void AnimateCells()
	{
	}

	private void SJSHIERQKOT()
	{
	}

	public override LootElement.TOINELPLRQP GetCurrencyType()
	{
		return default(LootElement.TOINELPLRQP);
	}

	public void Hide()
	{
	}

	public void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	public void OnTimerUp()
	{
	}

	[CompilerGenerated]
	internal static void TSLJKQHNJON(GameObject QIMGEOQLLHO, Color POSNHINOJRL)
	{
	}
}
