using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIRoomShopElement : UIShopElement
{
	[CompilerGenerated]
	private sealed class ORGENEPMNOH
	{
		public UIRoom owner;

		public EOQPNKSSOTM.ShopItem shopItem;

		public UIRoomShopElement _003C_003E4__this;

		internal void _003CSetup_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class PQSPERMPKLI
	{
		public UIRoomShopElement _003C_003E4__this;

		public EOQPNKSSOTM.ShopItem shopItem;

		public Button cooldownButton;

		internal void _003CSetupStates_003Eb__0()
		{
		}

		internal void _003CSetupStates_003Eb__1()
		{
		}
	}

	[SerializeField]
	private GameObject levelBadgeActive;

	[SerializeField]
	private GameObject levelBadgeInactive;

	[SerializeField]
	private Text resourceName;

	[SerializeField]
	private Text resourceAmount;

	[SerializeField]
	private Text requiredLevelLeft;

	[SerializeField]
	private Text requiredLevelRight;

	[SerializeField]
	private Text costTextInactive;

	[Space]
	[SerializeField]
	private GameObject stateCanBuy;

	[Space]
	[SerializeField]
	private GameObject spinnerButton;

	[Space]
	[SerializeField]
	private UIRoomShopItemCell shopItemCell;

	private bool SFQHNLLOGLE;

	public void Setup(EOQPNKSSOTM.ShopItem MSHFNNSJFPT, UIRoom FNJLLHKNGOR, bool GJLHFSLPGEP = false)
	{
	}

	protected new virtual int LNLFMQOKELN(EOQPNKSSOTM.ShopItem MSHFNNSJFPT)
	{
		return 0;
	}

	public override void SetupItemInfo(EOQPNKSSOTM.ShopItem MSHFNNSJFPT)
	{
	}

	protected override void PHTSTJJSLFI(LootIdentifier GTNLNSRKHET, bool PQPGFQQNQKQ)
	{
	}

	protected override void JEOJEEHITRE(EOQPNKSSOTM.ShopItem MSHFNNSJFPT)
	{
	}

	protected override void SSJMPTFGPOP(bool IJHNLHLIFKG, bool TEILKPETLEJ)
	{
	}

	protected override void IORNHPGORPS(bool TEILKPETLEJ)
	{
	}

	protected override void OSREELPOFOG(int OHLSPMTFTIM)
	{
	}
}
