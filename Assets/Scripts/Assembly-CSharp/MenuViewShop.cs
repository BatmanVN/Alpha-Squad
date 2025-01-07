using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class MenuViewShop : MenuView
{
	[CompilerGenerated]
	private sealed class JPOHSNOETRS
	{
		public ShopCashOffers co;

		internal void _003CScrollToCash_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class LOGTMTPPKER
	{
		public ShopGemOffers co;

		internal void _003CScrollToGems_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class TRNHKPSKGNS
	{
		public ShopVipOffer co;

		internal void _003CScrollToVip_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class JNNFNQFONFM
	{
		public ShopOffer offer;

		internal bool _003CSetupOffer_003Eb__0(ShopOffer x)
		{
			return false;
		}

		internal bool _003CSetupOffer_003Eb__1(ShopOffer x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HNTQPQTOKEL
	{
		public MenuViewShop _003C_003E4__this;

		public RectTransform rt;

		public Action onEndCallback;

		internal void _003CScrollToRect_003Eb__0()
		{
		}

		internal void _003CScrollToRect_003Eb__1()
		{
		}
	}

	[SerializeField]
	private List<ShopOffer> offerPrefabs;

	[Space]
	[SerializeField]
	private RectTransform offerParent;

	[SerializeField]
	private ScrollRectEx scroll;

	[SerializeField]
	public RectTransform scrollContent;

	[SerializeField]
	public RectTransform scrollViewport;

	public Transform cardFlyLocation;

	private List<ShopOffer> GJIPTKKGEMN;

	public override void Setup()
	{
	}

	public override void OnEntered()
	{
	}

	private void LELQFTSFPPL(bool HMHSTQGOQTP = false)
	{
	}

	private void LMEFPNHNOSH()
	{
	}

	public override void OnExited()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public void ScrollToCash()
	{
	}

	public void ScrollToGems()
	{
	}

	public void ScrollToVip()
	{
	}

	public T GetActiveShopOffer<T>() where T : ShopOffer
	{
		return null;
	}

	private bool HQPSLHTKIJN(ShopOffer FTMHSEPTHPR)
	{
		return false;
	}

	private void PETRNFTJLFM(bool RLFSMNKFIKH = false)
	{
	}

	private void MMLHJPQTJOS()
	{
	}

	private void NTPJRIPEIGF(RectTransform LJIOGPNTJPN, Action NRRHLFONPPM = null)
	{
	}

	private void TEEMEGNKFEQ(int ILEKEJSTPGT)
	{
	}
}
