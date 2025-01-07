using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class ShopController : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		[SerializeReference]
		public OfferDataLMG lmgOffer;

		[SerializeReference]
		public OfferDataRaidTickets raidTicketOffer;

		[SerializeReference]
		public OfferDataTripleOffer tripleOffer;

		[SerializeReference]
		public OfferBlackFriday blackFriday;

		[SerializeReference]
		public OfferCash offerCash;

		[SerializeReference]
		public ShopWeaponChestData weaponChestData;

		[SerializeReference]
		public ShopResourceChestData resourcesChestData;

		[SerializeReference]
		public ShopWeaponPartChestData weaponPartChestData;

		[SerializeReference]
		public ShopLegendaryChestData legendaryChestData;

		[SerializeReference]
		public OfferWeeklyOffers weeklyOffersData;

		[SerializeReference]
		public OfferAds offerAdsData;

		[SerializeReference]
		public OfferSkins offerSkinsData;

		public int startPack_timeStart;

		public int limitbreakPack_timeStart;

		public int chestPack_timeStart;

		public int agentsshardsPack_timeStart;

		public int toolsPack_timeStart;

		public int materialsMegaBundle_timeStart;

		public int oneTimeOffers_timeStart;

		public ItemWeapon starterPackWeapon;

		public int purchased_resourcePack_tier;

		public int purchased_upgradePack_tier;

		public bool purchased_starterPack;

		public bool purchased_chestPack;

		public bool purchased_limitbreakPack;

		public bool purchased_agentsshardsPack;

		public bool purchased_toolsPack;

		public bool purchased_gemPack;

		public bool purchased_materialsMegaBundle;

		public int limitbreakPack_lastRarity;

		public bool enabled_limitbreakPack;

		public bool enabled_toolsPack;

		public bool enabled_chestPack;

		public bool enabled_agentshardsPack;

		public bool enabled_materialsMegaBundle;

		public bool enabled_weekly_shards;

		public bool seen_starterPack;

		public bool seen_limitbreakPack;

		public bool seen_toolsPack;

		public bool seen_chestPack;

		public bool seen_agentshardsPack;

		public bool seen_materialsMegaBundle;

		public LootList chestPack_rewards_weaponChest;

		public LootList chestPack_rewards_upgradeChest;

		public JJHFPNTSRLT.WeaponPartIdentifier limitbreakPack_selectedWeaponpart;

		public RRMFSKNJIOH agentShardsPack_selectedAgent;

		public LootList toolsPack_rewards_upgradeChest;

		public int reccurts_limitbreakPack;

		public int reccurts_chestPack;

		public int reccurts_toolsPack;

		public int reccurts_agentshardsPack;

		public JJHFPNTSRLT.WeaponPartIdentifier[] limitbreakOffer_WeaponParts;

		public JJHFPNTSRLT.WeaponPartIdentifier[] limitbreakOffer_WeaponParts_Uncommon;

		public List<string> purchasedIds;

		[SerializeReference]
		public WeekendOfferData weekend_offer_data;

		[SerializeReference]
		public GearBoosterPack gear_booster_pack_data;

		public List<int> completedBonusCashPurchases;

		public int lastBonusCashPurchaseResetTimestamp;

		public int blackFridayGemIndex;

		public List<int> blackFridayGemPurchases;

		public bool blackFridayShopEntered;

		public GetResourcePopup.JOQRLMTLFTM getResourcePopupData;
	}

	public struct SJQRHINLPLS
	{
		public bool QJPIGHRSFRN;

		public ShopCashOffers.CashScaling QFHHQLPPQIE;

		public int[] EEEKTMFMRTE;

		public IQHJOMNOSOS[] KFPNRIRRJKT;

		public int TPNPNLESMRR;

		public int FONMEMPKKFS;

		public int PNEQLMNMTJH;

		public int SJPFPTNHFIK;

		public int FGPPMOFRIEF;

		public int LHSFPNFEHQR;

		public int PKPRONFOELP;

		public int MNMRKGFNNRS;

		public int IOFPHEGLGFO;

		public int KROKMQEGKEN;

		public int KPOKISMGQKP;

		public int MNGLNRQQJLH;

		public int JJPIIQIFKSH;

		public int JNGONHGQOTN;

		public int RQETGRNMNFO;

		public int TJSREIOSGLG;

		public int GRREILGHOSE;

		public int KFHIJPINQEF;

		public int SIMTQKRIPKT;

		public int KOEKSJHMTKP;

		public int TPMGFPIMHJS;

		public int MPNTPPFKLLP;

		public int EITNEIJSFIO;

		public int TPTPEFSFKSK;

		public int RSOETEIJTLE;

		public int HNNPNIFIJFM;

		public int LSHFEHSHHGF;

		public int KNENERKNFLJ;

		public int NMHOEMJFIFP;

		public int ISTKHEJSPOH;

		public int TIOESHJFSHK;

		public int SEJJIKFHNTK;

		public int HKNKLJTSGLE;

		public int QIPLHMQKINP;

		public int LQMTISTNIOL;

		public int MSOGLKRHGRN;

		public int KPERKPISNIJ;

		public bool SSFKGOOKEGH;

		public int FOFJJQOMHJQ;

		public int PIJSFRJMQLJ;

		public int OQORITNGJTM;

		public int MKPKGIOHLNR;

		public int PQGFNLGRNKR;

		public int LQJKHPEKLSF;

		public int TPRQROSSORJ;

		public int NGPFIOTLQOG;

		public int HKEGFSMLKSJ;

		public int NONKPITSTOK;

		public int FEPEKGMFLTP;

		public int FEKNQTOHSTQ;

		public int EHJGRJQONMK;

		public JJHFPNTSRLT.ChestPurchaseData[] OHFGMHISMKK;

		public int RINRFSEKELO;

		public int PPRFNMOGJMS;

		public int FMOKQPPSRII;

		public int NPPKLMLOLFS;

		public int TRPQPTILHFT;

		public int MOMRGRKQEFT;

		public int RGIHRGMHOPJ;

		public int PPHITSTGSEI;

		public int INSHKIFHMJP;

		public int FKTSRTPJLPF;

		public int KQEHIHOROTJ;

		public int JRKIRNNPHGI;

		public int RQHLGLIQKGK;

		public int NOSLJKPPINS;

		public int FLITGEHEKKJ;

		public int ITHNNFIPKFM;

		public int SHGTIFJQNSP;

		public WeekendOfferConfig MTHKJNJNKJL;

		public int EJJPHNRGLEG;

		public int PQHHQQIMMFK;

		public int FRIREHNFGGO;

		public int IPHFREORGLI;

		public int IQOMONJMEMJ;

		public int MLTFIITGEHM;

		public int RQPMKGKKHNH;

		public int[] OKISRJLIPTO;

		public float LPHHFRKNETS;

		public float MJOMRIQTOGS;

		public float NSNJSQOLHNP;
	}

	public enum IQHJOMNOSOS
	{
		GEAR_BOOSTER_PACK = 0,
		TOOLS_PACK = 1,
		LMG_PACK = 2,
		RAID_TICKETS = 3,
		RAID_TICKETS_EXPENSIVE = 4,
		BLACK_FRIDAY = 6,
		CASH_OFFER = 7,
		STARTER_PACK = 8,
		CHEST_PACK = 9,
		LIMIT_BREAK_OFFER = 10,
		AGENT_SHARD_PACK = 11,
		MATERIAL_MEGA_BUNDLE = 12,
		TRIPLE_OFFER_CRAFT = 13,
		TRIPLE_OFFER_TOOLS = 14,
		TRIPLE_OFFER_LIMITBREAK = 15,
		WEEKLY_OFFERS = 16,
		ADS_OFFERS = 17,
		SKINS_OFFER = 18
	}

	[CompilerGenerated]
	private sealed class JEFPLFRKNLS
	{
		public JJHFPNTSRLT.PQRIQGIOGQT crarity;

		internal bool _003CGetLimitBreakPackWeaponParts_003Eb__0(JJHFPNTSRLT.WeaponPartIdentifier x)
		{
			return false;
		}

		internal bool _003CGetLimitBreakPackWeaponParts_003Eb__1(JJHFPNTSRLT.WeaponPartIdentifier x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HRMNPLTNMNQ
	{
		public WeaponData.OHHQFFINRQH cat;

		internal bool _003CGetLimitBreakPackWeaponParts_003Eb__5(JJHFPNTSRLT.WeaponPart x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct ENTEPJQNETF
	{
		public List<WeaponData.OHHQFFINRQH> categories;

		public List<JJHFPNTSRLT.WeaponPartIdentifier> pickedIds;
	}

	[CompilerGenerated]
	private sealed class LKOGOELTJNJ
	{
		public WeaponData.OHHQFFINRQH cat;

		public int type;

		public JEFPLFRKNLS CS_0024_003C_003E8__locals1;

		internal bool _003CGetLimitBreakPackWeaponParts_003Eb__7(JJHFPNTSRLT.WeaponPartIdentifier x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KMRTFLROKJG
	{
		public ItemWeapon w;

		internal bool _003CShouldEnableLimitBreakPack_003Eb__2(JJHFPNTSRLT.WeaponPart x)
		{
			return false;
		}

		internal bool _003CShouldEnableLimitBreakPack_003Eb__3(JJHFPNTSRLT.WeaponPart x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TPPHFQEOQIK
	{
		public ChestController.MFRETPOLGOE q;

		internal bool _003CGetPurchaseDataForChestQuality_003Eb__0(JJHFPNTSRLT.ChestPurchaseData x)
		{
			return false;
		}
	}

	private static Data TSRPFHOJKSG;

	private static SJQRHINLPLS SOSLGOOOIPG;

	private static bool JREGORLKOST;

	private static bool TQETTJOEMQF;

	public static string KEY;

	private void Awake()
	{
	}

	public static void Clear()
	{
	}

	private static void MLNESSGJRME()
	{
	}

	public static void ResetData()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static PJRPMRSRNJS.ShopDataPre146 LoadPre146Data()
	{
		return null;
	}

	private static void ERFGNOLKSNQ()
	{
	}

	public static void SaveData()
	{
	}

	public static SJQRHINLPLS GetConfig()
	{
		return default(SJQRHINLPLS);
	}

	public static Data GetData()
	{
		return null;
	}

	public static bool IsShopUnlocked()
	{
		return false;
	}

	public static void CheckForReocurringOffers()
	{
	}

	public static bool IsRemoteOfferOverriding()
	{
		return false;
	}

	public static bool IsOfferAllowed(IQHJOMNOSOS MKMRLLMFORF)
	{
		return false;
	}

	public static bool IsAvailableToolsPack()
	{
		return false;
	}

	public static int GetToolsPackSecondsRemaining()
	{
		return 0;
	}

	public static void PurchaseToolsPack()
	{
	}

	public static bool ShouldEnableToolsPack()
	{
		return false;
	}

	public static bool HaveSeenToolsPack()
	{
		return false;
	}

	public static void SeenToolsPack()
	{
	}

	public static void ToolsPack_SetChestRewards(LootList EKRNPSRGFRM)
	{
	}

	public static LootList ToolsPack_GetChestRewards()
	{
		return null;
	}

	public static void ForceEnableToolsPack()
	{
	}

	public static bool IsAvailableStarterPack()
	{
		return false;
	}

	public static int GetStarterPackSecondsRemaining()
	{
		return 0;
	}

	public static ItemWeapon GetStarterPackWeaponReward()
	{
		return null;
	}

	public static void PurchaseStarterPack()
	{
	}

	public static void SeenStarterPack()
	{
	}

	public static bool HaveSeenStarterPack()
	{
		return false;
	}

	public static void ForceEnableStarterPack()
	{
	}

	public static OfferDataLMG GetLMGOfferData()
	{
		return null;
	}

	public static OfferDataRaidTickets GetRaidTicketsOffer()
	{
		return null;
	}

	public static OfferDataRaidTicketsExpensive GetRaidTicketsOfferExpensive()
	{
		return null;
	}

	public static void ShowRaidTicketOffer(Action OOLSLMJGRRK = null)
	{
	}

	public static bool IsAvailableChestPack()
	{
		return false;
	}

	public static int GetChestPackSecondsRemaining()
	{
		return 0;
	}

	public static void PurchaseChestPack()
	{
	}

	public static bool ShouldEnableChestPack()
	{
		return false;
	}

	public static bool HaveSeenChestPack()
	{
		return false;
	}

	public static void SeenChestPack()
	{
	}

	public static void ForceEnableChestPack()
	{
	}

	public static JJHFPNTSRLT.WeaponPartIdentifier[] GetLimitBreakPackWeaponParts()
	{
		return null;
	}

	public static JJHFPNTSRLT.PQRIQGIOGQT GetLimitBreakPartsRarity()
	{
		return default(JJHFPNTSRLT.PQRIQGIOGQT);
	}

	public static bool IsAvailableLimitBreakPack()
	{
		return false;
	}

	public static int GetLimitBreakPackSecondsRemaining()
	{
		return 0;
	}

	public static void PurchaseLimitBreakPack()
	{
	}

	public static bool HaveSeenLimitBreakPack()
	{
		return false;
	}

	public static void SeenLimitBreakPack()
	{
	}

	public static bool ShouldEnableLimitBreakPack()
	{
		return false;
	}

	public static void LimitbreakPack_SetSelectedWeaponpart(JJHFPNTSRLT.WeaponPartIdentifier TTELHPSKNOL)
	{
	}

	public static JJHFPNTSRLT.WeaponPartIdentifier LimitbreakPack_GetSelectedWeaponPart()
	{
		return default(JJHFPNTSRLT.WeaponPartIdentifier);
	}

	public static void ForceEnableLimitBreakPack()
	{
	}

	public static int GetAgentShardsPackSecondsRemaining()
	{
		return 0;
	}

	public static bool IsAvailableAgentsShardsPack()
	{
		return false;
	}

	public static void PurchaseAgentShardsPack()
	{
	}

	public static void TryEnableAgentShardsPack()
	{
	}

	private static bool OTPMONLQKES()
	{
		return false;
	}

	public static bool HaveSeenAgentShardsPack()
	{
		return false;
	}

	public static void SeenAgentShardsPack()
	{
	}

	public static void AgentShardPack_SetSelectedAgentId(RRMFSKNJIOH TMQJMGQNQQR)
	{
	}

	public static RRMFSKNJIOH AgentShardPack_GetSelectedAgentId()
	{
		return default(RRMFSKNJIOH);
	}

	public static void ForceEnableAgentShardPack()
	{
	}

	public static bool WasBlackFridayShopEntered()
	{
		return false;
	}

	public static void SetBlackFridayShopEntered()
	{
	}

	public static int GetGemPurchaseIndexForProductId(string JSRRSEOKONO)
	{
		return 0;
	}

	public static int[] GetGemPurchases()
	{
		return null;
	}

	public static void SetGemsPurchased(string JSRRSEOKONO)
	{
	}

	public static bool IsGemsPackFirstPurchaseBonusEnabled(string JSRRSEOKONO)
	{
		return false;
	}

	public static bool IsBlackFridayGemOfferAvailable()
	{
		return false;
	}

	public static int GetBlackFridayGemOfferTimeRemaining()
	{
		return 0;
	}

	public static int GetBlackFridayGemPurchaseLimit(int GHHLJIPMSSM)
	{
		return 0;
	}

	public static int GetBlackFridayGemPurchasesRemaining(int GHHLJIPMSSM)
	{
		return 0;
	}

	public static int GetBlackFridayGemMultiplier()
	{
		return 0;
	}

	private static void QSOEHJSOTKE()
	{
	}

	private static bool GLQNHTRJOMP(int GHHLJIPMSSM)
	{
		return false;
	}

	public static int[] GetCashPurchases(bool IQELMNHGOGE = false)
	{
		return null;
	}

	public static bool IsBlackFridayCashOfferAvailable()
	{
		return false;
	}

	public static int GetBlackFridayCashOfferTimeRemaining()
	{
		return 0;
	}

	public static int GetBonusCashOfferTimeRemaining()
	{
		return 0;
	}

	private static float RFELSMFGPQF(int PSPJIJNTMOI)
	{
		return 0f;
	}

	public static float GetCashBonusMultiplier()
	{
		return 0f;
	}

	public static bool IsWeeklyCashBonusClaimedForIndex(int PSPJIJNTMOI)
	{
		return false;
	}

	private static void ELETOKOELRT()
	{
	}

	public static void CashPurchaseCompleted(int PSPJIJNTMOI)
	{
	}

	public static void TrySetToAppropriateUpgradePack(int OJPOMTSLGJP)
	{
	}

	public static bool IsAvailableUpgradePack()
	{
		return false;
	}

	public static bool IsAvailableResourcePack()
	{
		return false;
	}

	public static void PurchaseUpgradePack()
	{
	}

	public static void PurchaseResourcePack()
	{
	}

	public static int GetUpgradePackIndex()
	{
		return 0;
	}

	public static int GetResourcePackIndex()
	{
		return 0;
	}

	public static LimitedOfferPopup.REQSHTKPSEP GetLimitedOfferUpgradePackPopupType()
	{
		return default(LimitedOfferPopup.REQSHTKPSEP);
	}

	public static LimitedOfferPopup.REQSHTKPSEP GetLimitedOfferResourcePackPopupType()
	{
		return default(LimitedOfferPopup.REQSHTKPSEP);
	}

	public static OfferWeeklyOffers GetWeeklyOffersData()
	{
		return null;
	}

	public static OfferAds GetOfferAds()
	{
		return null;
	}

	public static ShopWeaponChestData GetWeaponChestData()
	{
		return null;
	}

	public static ShopResourceChestData GetResourceChestData()
	{
		return null;
	}

	public static ShopWeaponPartChestData GetWeaponPartChestData()
	{
		return null;
	}

	public static ShopLegendaryChestData GetLegendaryChestData()
	{
		return null;
	}

	public static JJHFPNTSRLT.ChestPurchaseData GetPurchaseDataForChestQuality(ChestController.MFRETPOLGOE MROKKGHHGTN)
	{
		return default(JJHFPNTSRLT.ChestPurchaseData);
	}

	public static List<JJHFPNTSRLT.ChestPurchaseData> GetPurchaseDataForAllChestsCopy()
	{
		return null;
	}

	public static OfferDataTripleOffer GetTripleOfferData()
	{
		return null;
	}

	public static OfferBlackFriday GetBlackFridayData()
	{
		return null;
	}

	public static OfferCash GetOfferCashData()
	{
		return null;
	}

	public static bool IsAvailableMaterialsMegaBundle()
	{
		return false;
	}

	public static int GetMaterialsMegaPackSecondsRemaining()
	{
		return 0;
	}

	public static void PurchaseMaterialsMegaPack()
	{
	}

	public static bool ShouldEnableMaterialsMegaBundle()
	{
		return false;
	}

	public static bool HaveSeenMaterialsMegaBundle()
	{
		return false;
	}

	public static void SeenMaterialsMegaBundle()
	{
	}

	public static void ForceEnableMaterialsMegaBundle()
	{
	}

	public static WeekendOfferData GetWeekendOfferData()
	{
		return null;
	}

	public static WeekendOfferConfig GetWeekendOfferConfig()
	{
		return null;
	}

	public static OfferSkins GetSkinsOfferData()
	{
		return null;
	}

	public static GearBoosterPack GetGearBoosterPackData()
	{
		return null;
	}

	public static GetResourcePopup.JOQRLMTLFTM GetResourcePopupData()
	{
		return default(GetResourcePopup.JOQRLMTLFTM);
	}

	public static void SetResourcePopupData(GetResourcePopup.JOQRLMTLFTM QPNIRNRNJON, bool LIPENRNHTJL = true)
	{
	}

	private static void JLHSIPNHELJ()
	{
	}

	public static string GetNameForScreen(UnityEngine.Object JJRRSONQJKG)
	{
		return null;
	}

	[CompilerGenerated]
	internal static bool LHGJGSPPKMG(ItemWeapon QTRSFNTGTSR)
	{
		return false;
	}

	[CompilerGenerated]
	internal static void KFSEMOHQOJQ()
	{
	}

	[CompilerGenerated]
	internal static void MRQIEJKJGPN()
	{
	}

	[CompilerGenerated]
	internal static int NHSQMNFEGKF(int OREMGIQJPRP)
	{
		return 0;
	}
}
