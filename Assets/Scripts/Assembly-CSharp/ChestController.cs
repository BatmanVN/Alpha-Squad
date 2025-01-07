using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class ChestController : MonoBehaviour
{
	public enum MFRETPOLGOE
	{
		UNSET = 0,
		INVISIBLE_CHEST = 996,
		TUTORIAL_SILVER_CHEST = 997,
		SILVER_GIFT_CHEST = 998,
		TUTORIAL_CHEST = 999,
		SILVER = 1001,
		GREEN = 1002,
		RED = 1003,
		PURPLE = 1004,
		SHOP_AGENTS = 1005,
		SHOP_WEAPONS = 1006,
		SHOP_RESOURCE = 1007,
		SHOP_LEGENDARY = 1008,
		SHOP_WEAPON_SELECT_CHEST = 1009,
		SHOP_LEGENDARY_SELECT_CHEST = 1010,
		SHOP_WEAPON_PARTS = 1011,
		SHOP_WEAPON_SELECT_CHEST_MINOR = 1012,
		SHOP_LEGENDARY_SELECT_CHEST_MINOR = 1013,
		HELL = 1100,
		HELL_BOSS = 1101,
		GIFT_0 = 1200,
		GIFT_1 = 1201,
		GIFT_2 = 1202,
		GIFT_3 = 1203,
		GIFT_4 = 1204,
		PURPLE_LTV_GOD = 1300,
		PASS_0_SMALL = 1500,
		PASS_0_MEDIUM = 1501,
		PASS_0_LARGE = 1502,
		PASS_0_EXTRA_LARGE = 1503,
		PASS_0_LARGE_BOOSTED = 1504,
		PASS_0_EXTRA_LARGE_BOOSTED = 1505,
		EXPEDITION_MEDIUM = 2000,
		EXPEDITION_LARGE = 2001,
		CHEST_5STAR_WEAPON = 3000,
		CHEST_4STAR_WEAPON = 3001,
		RESOURCE_CHEST_RARE = 3002,
		RESOURCE_CHEST_REGULAR = 3003,
		CHEST_5STAR_WEAPON_SELECT = 3004,
		ELITE_WEAPON_CHEST = 3005,
		REGULAR_WEAPON_CHEST = 3006,
		CHEST_5STAR_LEG_WEAPON_SELECT = 3007,
		RESOURCE_CHEST_EPIC = 3008,
		RESOURCE_CHEST_LEGENDARY = 3009,
		JUGGERNAUTS_WEAPON_CHEST = 3010,
		CLAN_CHEST = 4000,
		EVENT_EASTER = 5000,
		CHRISTMAS_COMMON_WEAPON = 5001,
		CHRISTMAS_UNCOMMON_WEAPON = 5002,
		CHRISTMAS_EXCEPTIONAL_WEAPON = 5003,
		CHRISTMAS_RARE_WEAPON = 5004,
		CHRISTMAS_EPIC_WEAPON = 5005,
		CHRISTMAS_LEGENDARY_WEAPON = 5006,
		CHRISTMAS_COMMON_TOOLS = 5007,
		CHRISTMAS_UNCOMMON_TOOLS = 5008,
		CHRISTMAS_EXCEPTIONAL_TOOLS = 5009,
		CHRISTMAS_RARE_TOOLS = 5010,
		CHRISTMAS_EPIC_TOOLS = 5011,
		CHRISTMAS_LEGENDARY_TOOLS = 5012,
		CHRISTMAS_COMMON_AGENTCARDS = 5013,
		CHRISTMAS_UNCOMMON_AGENTCARDS = 5014,
		CHRISTMAS_EXCEPTIONAL_AGENTCARDS = 5015,
		CHRISTMAS_RARE_AGENTCARDS = 5016,
		CHRISTMAS_EPIC_AGENTCARDS = 5017,
		CHRISTMAS_LEGENDARY_AGENTCARDS = 5018,
		CHRISTMAS_COMMON_WEAPONCHIPS = 5019,
		CHRISTMAS_UNCOMMON_WEAPONCHIPS = 5020,
		CHRISTMAS_EXCEPTIONAL_WEAPONCHIPS = 5021,
		CHRISTMAS_RARE_WEAPONCHIPS = 5022,
		CHRISTMAS_EPIC_WEAPONCHIPS = 5023,
		CHRISTMAS_LEGENDARY_WEAPONCHIPS = 5024,
		CHRISTMAS_COMMON_AGENTSHARDS = 5025,
		CHRISTMAS_UNCOMMON_AGENTSHARDS = 5026,
		CHRISTMAS_EXCEPTIONAL_AGENTSHARDS = 5027,
		CHRISTMAS_RARE_AGENTSHARDS = 5028,
		CHRISTMAS_EPIC_AGENTSHARDS = 5029,
		CHRISTMAS_LEGENDARY_AGENTSHARDS = 5030,
		CHRISTMAS_COMMON_GEARBOOSTERS = 5031,
		CHRISTMAS_UNCOMMON_GEARBOOSTERS = 5032,
		CHRISTMAS_EXCEPTIONAL_GEARBOOSTERS = 5033,
		CHRISTMAS_RARE_GEARBOOSTERS = 5034,
		CHRISTMAS_EPIC_GEARBOOSTERS = 5035,
		CHRISTMAS_LEGENDARY_GEARBOOSTERS = 5036,
		CHRISTMAS_COMMON_CASH = 5037,
		CHRISTMAS_UNCOMMON_CASH = 5038,
		CHRISTMAS_EXCEPTIONAL_CASH = 5039,
		CHRISTMAS_RARE_CASH = 5040,
		CHRISTMAS_EPIC_CASH = 5041,
		CHRISTMAS_LEGENDARY_CASH = 5042,
		CHRISTMAS_COMMON_WEAPONPARTS = 5043,
		CHRISTMAS_UNCOMMON_WEAPONPARTS = 5044,
		CHRISTMAS_EXCEPTIONAL_WEAPONPARTS = 5045,
		CHRISTMAS_RARE_WEAPONPARTS = 5046,
		CHRISTMAS_EPIC_WEAPONPARTS = 5047,
		CHRISTMAS_LEGENDARY_WEAPONPARTS = 5048,
		CHRISTMAS_COMMON_PISTOL_SCRAP = 5049,
		CHRISTMAS_UNCOMMON_PISTOL_SCRAP = 5050,
		CHRISTMAS_EXCEPTIONAL_PISTOL_SCRAP = 5051,
		CHRISTMAS_RARE_PISTOL_SCRAP = 5052,
		CHRISTMAS_EPIC_PISTOL_SCRAP = 5053,
		CHRISTMAS_LEGENDARY_PISTOL_SCRAP = 5054,
		CHRISTMAS_COMMON_SMG_SCRAP = 5055,
		CHRISTMAS_UNCOMMON_SMG_SCRAP = 5056,
		CHRISTMAS_EXCEPTIONAL_SMG_SCRAP = 5057,
		CHRISTMAS_RARE_SMG_SCRAP = 5058,
		CHRISTMAS_EPIC_SMG_SCRAP = 5059,
		CHRISTMAS_LEGENDARY_SMG_SCRAP = 5060,
		CHRISTMAS_COMMON_SHOTGUN_SCRAP = 5061,
		CHRISTMAS_UNCOMMON_SHOTGUN_SCRAP = 5062,
		CHRISTMAS_EXCEPTIONAL_SHOTGUN_SCRAP = 5063,
		CHRISTMAS_RARE_SHOTGUN_SCRAP = 5064,
		CHRISTMAS_EPIC_SHOTGUN_SCRAP = 5065,
		CHRISTMAS_LEGENDARY_SHOTGUN_SCRAP = 5066,
		CHRISTMAS_COMMON_AR_SCRAP = 5067,
		CHRISTMAS_UNCOMMON_AR_SCRAP = 5068,
		CHRISTMAS_EXCEPTIONAL_AR_SCRAP = 5069,
		CHRISTMAS_RARE_AR_SCRAP = 5070,
		CHRISTMAS_EPIC_AR_SCRAP = 5071,
		CHRISTMAS_LEGENDARY_AR_SCRAP = 5072,
		CHRISTMAS_COMMON_SNIPER_SCRAP = 5073,
		CHRISTMAS_UNCOMMON_SNIPER_SCRAP = 5074,
		CHRISTMAS_EXCEPTIONAL_SNIPER_SCRAP = 5075,
		CHRISTMAS_RARE_SNIPER_SCRAP = 5076,
		CHRISTMAS_EPIC_SNIPER_SCRAP = 5077,
		CHRISTMAS_LEGENDARY_SNIPER_SCRAP = 5078,
		CHRISTMAS_COMMON_EXPLOSIVE_SCRAP = 5079,
		CHRISTMAS_UNCOMMON_EXPLOSIVE_SCRAP = 5080,
		CHRISTMAS_EXCEPTIONAL_EXPLOSIVE_SCRAP = 5081,
		CHRISTMAS_RARE_EXPLOSIVE_SCRAP = 5082,
		CHRISTMAS_EPIC_EXPLOSIVE_SCRAP = 5083,
		CHRISTMAS_LEGENDARY_EXPLOSIVE_SCRAP = 5084,
		CHRISTMAS_COMMON_MIXED_GEAR = 5085,
		CHRISTMAS_UNCOMMON_MIXED_GEAR = 5086,
		CHRISTMAS_EXCEPTIONAL_MIXED_GEAR = 5087,
		CHRISTMAS_RARE_MIXED_GEAR = 5088,
		CHRISTMAS_EPIC_MIXED_GEAR = 5089,
		CHRISTMAS_LEGENDARY_MIXED_GEAR = 5090
	}

	public enum FINRRRRFKEG
	{
		UNSET = 0,
		REGULAR = 1,
		UNLOCKING = 2,
		UNLOCKED = 3
	}

	public enum JPPJGGSMHMT
	{
		UNSET = 0,
		CHRISTMAS = 1,
		ARCADE_PASS = 2,
		STARTER_EVENT = 3
	}

	[Serializable]
	public class ChestData
	{
		[Serializable]
		public struct AnalyticsContext
		{
			public int quality;

			public int difficultyLevel;

			public string Json => null;
		}

		public int timeStarted;

		public int timeTotal;

		public int timeReceived;

		public MFRETPOLGOE quality;

		public bool seen;

		public int difficultyLevel;

		public LootList predefinedCustomLoot;

		public bool blockOpenMore;

		public int? seed;

		public int selectCount;

		public JPPJGGSMHMT ccd;

		public ChestData(MFRETPOLGOE MROKKGHHGTN)
		{
		}

		public bool OQJIOMMPTOQ()
		{
			return false;
		}

		public System.Random MSLETFMNLSR()
		{
			return null;
		}

		public int IHSILOHEGLK()
		{
			return 0;
		}

		public FINRRRRFKEG MOLLQITEILG()
		{
			return default(FINRRRRFKEG);
		}

		public AnalyticsContext RGKKFRJHEFK()
		{
			return default(AnalyticsContext);
		}

		public static ChestData GGKTKKTGEPS(MFRETPOLGOE ETNRRGQSKEG, int HHFHLJFISQF)
		{
			return null;
		}

		public bool JINOMNFEIJI()
		{
			return false;
		}
	}

	[Serializable]
	public struct Data
	{
		public List<ChestData> ownedChests;

		public int chestsReceived;

		public int discountTimestamp;

		public bool discountAvailable;

		public int lastOpeningChest;

		public int freeBoosts;

		public List<ChestData> chestsToOpen;

		public List<JJHFPNTSRLT.ChestQualityNumber> chestsOpened;
	}

	public struct JEKNPELSMSI
	{
		public int ROKKKEHOMRG;

		public int HTLONRMEITP;

		public MFRETPOLGOE[] TJMOIROFEGO;

		public bool TSIFTFRTFFI;

		public ChestOverride[] GRNOIJKSGNN;

		public ChestBoostableOverride[] MTORTTMPRLP;

		public MFRETPOLGOE[] IQETREHMLNF;
	}

	[Serializable]
	public struct ChestOverride
	{
		public int globalLevelIndex;

		public MFRETPOLGOE chestQuality;

		public bool JGGNKIHGNLT(int RPEIIREQPQE)
		{
			return false;
		}
	}

	[Serializable]
	public struct ChestBoostableOverride
	{
		public MFRETPOLGOE id;

		public bool boostable;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct EQGQGSLFEHQ
	{
		public ChestController cc;
	}

	[CompilerGenerated]
	private sealed class LKGJRLFIMRK
	{
		public MFRETPOLGOE q;

		internal bool _003CRemoveChestsOpenedOfQuality_003Eb__0(JJHFPNTSRLT.ChestQualityNumber x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NMKIKSQQJNI
	{
		public MFRETPOLGOE q;

		internal bool _003CIsChestOfQualityOwned_003Eb__0(ChestData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RTTGPKNGTJM
	{
		public ChestData lastOpeningChest;

		internal int _003CCheckForChestQueue_003Eb__0(ChestData x)
		{
			return 0;
		}
	}

	public JEKNPELSMSI config;

	public Data data;

	private bool NNNPOOGTSLT;

	private bool QGNNPSGNTNI;

	public static string KEY;

	public event Action RRKEQIOHRGO
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OHOPTQIRTSF()
	{
	}

	private void KLJEPKORMLM()
	{
	}

	private void ERFGNOLKSNQ()
	{
	}

	public void SaveData()
	{
	}

	public void ForceEmit()
	{
	}

	public void RemoveChest(ChestData KSIMSNROKFP, bool JOKFTNQMLGT = true)
	{
	}

	public void ReplaceChest(ChestData KQRPMHFKSIR, ChestData SQHRTOGQSSJ, bool PHGIHJHKRQK = true)
	{
	}

	private static void LMPTFSEMMPQ()
	{
	}

	public static void TryOpenChestFromQueue()
	{
	}

	private void INQEFOJRKRM(ChestData IEHEOOQKSKK)
	{
	}

	public int GetChestOpenQueueSize()
	{
		return 0;
	}

	public LootList GetRewardsForChestData(ChestData IEHEOOQKSKK, int SLRHNOHJNPL = 0, bool JOPRNLNFPRL = false, bool QTQIOHLLFGK = true)
	{
		return null;
	}

	public void OnChestOpened(ChestData OTSSKRRHTOO)
	{
	}

	public bool HaveFreeBoost()
	{
		return false;
	}

	public void UseFreeBoost()
	{
	}

	public void OnChestUnlock(ChestData OTSSKRRHTOO)
	{
	}

	public void OnChestUnlocked(ChestData OTSSKRRHTOO)
	{
	}

	public void AddChestOpened(MFRETPOLGOE MROKKGHHGTN)
	{
	}

	public void AddChestToOpenQueue(ChestData IEHEOOQKSKK)
	{
	}

	public ChestData GetLastChestFromQueue()
	{
		return null;
	}

	public int GetChestsOpenedOfQuality(MFRETPOLGOE MROKKGHHGTN)
	{
		return 0;
	}

	public void RemoveChestsOpenedOfQuality(MFRETPOLGOE MROKKGHHGTN)
	{
	}

	public void ResetSelectChestOpened()
	{
	}

	public bool CanGetChest()
	{
		return false;
	}

	public static bool IsGiftChest(MFRETPOLGOE MROKKGHHGTN)
	{
		return false;
	}

	public static bool IsSelectChest(MFRETPOLGOE MROKKGHHGTN, JPPJGGSMHMT KFIKORLTLRJ)
	{
		return false;
	}

	public bool IsQualityAvailableForX2Boost(MFRETPOLGOE JIIMNLQRQHF)
	{
		return false;
	}

	public bool AddChest(MFRETPOLGOE ETNRRGQSKEG, int TOEFOKGRJHL)
	{
		return false;
	}

	public static bool CanChestBeOpenedOffline(MFRETPOLGOE MROKKGHHGTN)
	{
		return false;
	}

	public bool AddLevelCompleteChestCustomPlayType(int TOEFOKGRJHL, bool ELGGEIJOMNK, GameController.KFPHKOMNHSS NSQRHJPNSGL)
	{
		return false;
	}

	private MFRETPOLGOE HERGERPFKTP(int SLMKITQNHFE)
	{
		return default(MFRETPOLGOE);
	}

	public MFRETPOLGOE GetNextChest(GameController.KFPHKOMNHSS NSQRHJPNSGL, bool MIHPJFSREKE, bool ELGGEIJOMNK, int SLMKITQNHFE)
	{
		return default(MFRETPOLGOE);
	}

	public void Test()
	{
	}

	public void StepNextGuaranteedChest()
	{
	}

	public void RemoveAllChests()
	{
	}

	public int GetInstantUnlockPrice(ChestData IEHEOOQKSKK, bool MERGNNNMPPK = true)
	{
		return 0;
	}

	public bool CanUnlockOneChest()
	{
		return false;
	}

	public bool CanOpenOrStartChest()
	{
		return false;
	}

	public int GetTimeForChestQuality(MFRETPOLGOE ETNRRGQSKEG)
	{
		return 0;
	}

	public bool IsChestOfQualityOwned(MFRETPOLGOE MROKKGHHGTN)
	{
		return false;
	}

	public bool IsOpenDiscountAvailable()
	{
		return false;
	}

	public void GetSpecificChest(int NERGMFPHLIM, MFRETPOLGOE ETNRRGQSKEG)
	{
	}

	public static int GetChestAdSkipSeconds()
	{
		return 0;
	}

	public static int GetDiscountAvailableSeconds()
	{
		return 0;
	}

	public bool GetChestBoostableOverride(ChestConfigData KFIKORLTLRJ, bool FRGFJOSRSOF)
	{
		return false;
	}

	private void QIJINEPFQEI(int TFOQROESEKK = 0)
	{
	}

	private void OnApplicationFocus(bool KQOPJTEQMEF)
	{
	}

	private void PMTKQKIJOKK()
	{
	}

	private void GRSHGKMRHFF()
	{
	}

	[CompilerGenerated]
	internal static bool LGOEQNNRLHK(ChestData IEHEOOQKSKK)
	{
		return false;
	}

	[CompilerGenerated]
	internal static bool NPOKSJOHTQP(ChestData IEHEOOQKSKK)
	{
		return false;
	}

	[CompilerGenerated]
	internal static void SEMGRNHHJLH(ChestData IEHEOOQKSKK)
	{
	}

	[CompilerGenerated]
	internal static void EQRMSTQQOPQ(int PSPJIJNTMOI, ref EQGQGSLFEHQ P_1)
	{
	}
}
