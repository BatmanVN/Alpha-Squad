using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LimitedOfferPopup : UIPopup
{
	public enum REQSHTKPSEP
	{
		UNSET = 0,
		RESOURCE_PACK_1 = 1,
		SCRAP_PACK_1 = 2,
		STARTER_PACK = 3,
		CHEST_PACK = 4,
		LIMITBREAK_PACK = 5,
		AGENTS_SHARDS_PACK = 6,
		TOOLS_PACK = 7,
		RESOURCE_PACK_2 = 8,
		RESOURCE_PACK_3 = 9,
		RESOURCE_PACK_4 = 10,
		SCRAP_PACK_2 = 11,
		SCRAP_PACK_3 = 12,
		SCRAP_PACK_4 = 13,
		MATERIALS_MEGA_BUNDLE = 16,
		LMG_PACK = 17,
		RAID_TICKET_PACK = 18,
		TRIPLE_OFFER_PACK = 19,
		RAID_TICKET_PACK_EXPENSIVE = 20,
		CASH_OFFER = 21,
		GEAR_BOOSTERS = 22
	}

	[SerializeField]
	private LimitedOfferPopupResourcePack prefabResourcePack;

	[SerializeField]
	private LimitedOfferPopupUpgradePack prefabUpgradePack;

	[SerializeField]
	private LimitedOfferStarterPack prefabM416Pack;

	[SerializeField]
	private LimitedOfferChestPack prefabChestPack;

	[SerializeField]
	private LimitedOfferLimitBreakParts prefabLimitBreakOffer;

	[SerializeField]
	private LimitedOfferAgentShards prefabAgentShardsOffer;

	[SerializeField]
	private LimitedOfferToolsPack prefabToolsOffer;

	[SerializeField]
	private LimitedOfferPopupMaterialsMegaBundle prefabMaterialsMegaBundleOffer;

	[SerializeField]
	private LimitedOfferLmgPack prefabLmgPack;

	[SerializeField]
	private LimitedOfferRaidTickets prefabRaidTickets;

	[SerializeField]
	private LimitedOfferTriple prefabTripleOffer;

	[SerializeField]
	private LimitedOfferCash prefabCashOffer;

	[SerializeField]
	private LimitedOfferGearBoosters prefabGearBooster;

	[Space]
	[SerializeField]
	private RectTransform popupOwner;

	[SerializeField]
	private CanvasGroup background;

	private LimitedOfferPopupBase HPKPETQKMEH;

	private Action OOLSLMJGRRK;

	private REQSHTKPSEP PGGRGEKJLMF;

	public static void Open(REQSHTKPSEP EOOEIROQJOE, Action OOLSLMJGRRK, bool PKEOOMSRJLG = false, bool PRLEJONOPLK = false)
	{
	}

	public static void OpenForward(REQSHTKPSEP EOOEIROQJOE, Action OOLSLMJGRRK, bool PKEOOMSRJLG = false)
	{
	}

	public void Init(REQSHTKPSEP EOOEIROQJOE, Action OOLSLMJGRRK, bool PKEOOMSRJLG)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnCloseButton()
	{
	}

	[CompilerGenerated]
	private void EFOITHTHRIR()
	{
	}
}
