using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShopChestOffers : ShopOffer
{
	[CompilerGenerated]
	private sealed class QIERQETMNJE
	{
		public ShopChestOffers _003C_003E4__this;

		public List<JJHFPNTSRLT.ChestPurchaseData> chests;

		internal bool _003CLoadChests_003Eb__0(JJHFPNTSRLT.ChestPurchaseData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FROJOIHLEFH
	{
		public JJHFPNTSRLT.ChestPurchaseData x;

		internal bool _003CLoadChests_003Eb__1(ShopChestCell y)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RPFNMHJSFFT
	{
		public int i;

		public QIERQETMNJE CS_0024_003C_003E8__locals1;

		internal bool _003CLoadChests_003Eb__2(ChestOpenPopup.ChestQualityObject x)
		{
			return false;
		}
	}

	[SerializeField]
	private List<ChestOpenPopup.ChestQualityObject> prefabsSpecial;

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[SerializeField]
	private ShopChestCell prefabCell;

	[SerializeField]
	private RectTransform lootboxParent;

	private List<ShopChestCell> IIFNPERNKPQ;

	public override bool IsAvailable()
	{
		return false;
	}

	public override void Setup(MenuViewShop QJPITOLEQFL)
	{
	}

	private void ERFGNOLKSNQ()
	{
	}

	private void RSKGGHTQRFH()
	{
	}

	public void OnClickChest(ShopChestCell GGOKJRGSMRT)
	{
	}

	public void Hide()
	{
	}
}
