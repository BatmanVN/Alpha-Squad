using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class IMTOMKMLMSK
{
	[Serializable]
	public class Data
	{
		public QuestList activeQuests;

		public QuestList activeVipQuests;

		public List<ShopItemList> availableOffers;

		public List<string> purchasedOffers;

		public int dailyCompletedQuests;

		public int weeklyProgress;

		public int claimedWeeklyRewards;

		public int day;

		public int week;

		public int shopIndex;

		public int rerollsUsed;

		public bool newShopPage;

		public int maxDailyQuestClaims;

		public int unsubmittedClanMissionContracts;
	}

	[Serializable]
	public struct Config
	{
		public int startTimestamp;

		public int weekInterval;

		public int dayInterval;

		public int shopInterval;

		public int shopMemory;

		public int shopListSize;

		public int dailyQuestCount;

		public int[] weeklyRewardReqs;

		public int[] weeklyRewards;

		public int[] weeklyRewardsIncreases;

		public int weeklyProgressStep;

		public int vipExtraMiddlemanTokens;

		public int vipExtraQuests;

		public int questRerolls;

		public int questRerollPrice;
	}

	[Serializable]
	public struct ShopItem
	{
		public int id;

		public string guid;

		public LootElement loot;

		public WeeklyContractsConfig.ShopOfferConfig TEHFIGMSMKG()
		{
			return default(WeeklyContractsConfig.ShopOfferConfig);
		}

		public int SKJEHKRMQKS()
		{
			return 0;
		}

		public int RPFQNNGLIOS()
		{
			return 0;
		}

		public bool EENFGQRELSP(ShopItem HNTPNTJRJMH)
		{
			return false;
		}
	}

	[Serializable]
	public struct ShopItemList
	{
		public List<ShopItem> offers;

		public bool IQGJEIMRLNQ(ShopItem KQQINSRPRNP)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MNMJOIRQSHF
	{
		public string uuid;

		internal bool _003CNewShop_003Eb__0(string x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QPLGQLMSGEO
	{
		public ShopItem item;

		internal bool _003CGetPurchasesRemainingForItem_003Eb__0(string x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class JQHRPJOQTSG
	{
		public ShopItem i;

		public bool save;

		internal void _003CPurchaseShopItem_003Eb__0(List<JJHFPNTSRLT.WeaponPart> x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class LOOIKJIPJHN
	{
		public string uuid;

		public Func<ShopItem, bool> _003C_003E9__9;

		internal bool _003CGenerateShopOffer_003Eb__8(ShopItemList x)
		{
			return false;
		}

		internal bool _003CGenerateShopOffer_003Eb__9(ShopItem y)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class JINSQELLKRF
	{
		public ShopItemList shopItems;

		internal bool _003CGenerateShopOffer_003Eb__10(WeeklyContractsConfig.ShopOfferConfig x)
		{
			return false;
		}

		internal bool _003CGenerateShopOffer_003Eb__11(WeeklyContractsConfig.ShopOfferConfig x)
		{
			return false;
		}
	}

	public static string JKPNPHQEOKN;

	public static string IGSFNLKOSRP;

	private static Data TSRPFHOJKSG;

	private static Config SOSLGOOOIPG;

	private static bool QOOPLGKOOLG;

	public static Action LFTPJTESNFK;

	public static Action QSOJMRGKRTK;

	public static Action KRTJRLONESP;

	private static void MLNESSGJRME()
	{
	}

	private static void EMSMGMTNTJT()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	private static void PMITOIOJNOT()
	{
	}

	public static WeeklyContractsConfig GTSJQPRSOSS()
	{
		return null;
	}

	public static void IOHSELJRPMK()
	{
	}

	public static void MGRLTPGGSSI()
	{
	}

	public static bool OMIHPLSQQEJ(bool IGJHQLPMTJO = true)
	{
		return false;
	}

	public static bool LHTHKTERJNT()
	{
		return false;
	}

	public static bool QQMELHNFIMQ()
	{
		return false;
	}

	public static bool SQPJTNEPGNJ()
	{
		return false;
	}

	public static void NPTRENTSPNS()
	{
	}

	private static int QPSRHIQIQSL()
	{
		return 0;
	}

	private static int GIETFKJHQTN()
	{
		return 0;
	}

	private static int MMHTIRGNFQG()
	{
		return 0;
	}

	public static int OPKQINNIKOG()
	{
		return 0;
	}

	public static int IQPTQITJQQK()
	{
		return 0;
	}

	public static int TGHNFOJPMTE()
	{
		return 0;
	}

	public static int FGQEOPMENSL()
	{
		return 0;
	}

	public static int JKEHIOTLHMJ()
	{
		return 0;
	}

	public static int ETGGSFRSSQS()
	{
		return 0;
	}

	private static void EPGTRQKRMNJ(int NESGNLQSJHP, bool LIPENRNHTJL = false)
	{
	}

	private static void ROQLOTIFLQJ(int SNHRHKRGNRI, bool LIPENRNHTJL = false)
	{
	}

	private static void KNRHNFHLIOK(int HSEESMLIQST, bool LIPENRNHTJL = false)
	{
	}

	public static int ENTJNOFLJLK()
	{
		return 0;
	}

	public static void FJFMKHITQMS(ShopItem HPJMQLRTORF, bool LIPENRNHTJL = true)
	{
	}

	public static int MHNGFMHPTMR(ShopItem HPJMQLRTORF)
	{
		return 0;
	}

	public static bool PPEJLMLMQTO(ShopItem HPJMQLRTORF)
	{
		return false;
	}

	public static bool OSRQRNJRPIS(ShopItem KQQINSRPRNP, bool LIPENRNHTJL = true)
	{
		return false;
	}

	public static List<ShopItemList> THRSPSOGNOK()
	{
		return null;
	}

	private static ShopItemList LQMQETSIEEM()
	{
		return default(ShopItemList);
	}

	public static void OKKQTSEEMOS()
	{
	}

	public static bool LMJEEESJLHR()
	{
		return false;
	}

	public static int FGSNKOLRLRL()
	{
		return 0;
	}

	public static int FMQTHMKGRIJ()
	{
		return 0;
	}

	public static int HTMGTITOLPN()
	{
		return 0;
	}

	public static bool KQNKTSIRIPR(Quest MROKKGHHGTN)
	{
		return false;
	}

	public static bool GITOTOJFFPS(Quest MROKKGHHGTN, bool LIPENRNHTJL = true)
	{
		return false;
	}

	private static void OTSPSJKGGQL(Quest MROKKGHHGTN, bool LIPENRNHTJL)
	{
	}

	private static bool PHLHSQHSGPF()
	{
		return false;
	}

	public static bool EOIFLFFKRIP()
	{
		return false;
	}

	public static void INJKPGRQSTO(bool LIPENRNHTJL = true)
	{
	}

	public static bool HMGKMFNGNLL()
	{
		return false;
	}

	private static void MSPQHHIFIIR(bool NEFPNQJSHOE = true, bool LIPENRNHTJL = false)
	{
	}

	public static QuestList REROPTLNREP()
	{
		return null;
	}

	public static int NNIFMLQJMNK()
	{
		return 0;
	}

	public static void OOMTTFPFJST()
	{
	}

	private static void KHIIMQQLMHQ(bool LIPENRNHTJL)
	{
	}

	public static int GFNKHKQPSKG()
	{
		return 0;
	}

	public static int MPMGRRJPNGF()
	{
		return 0;
	}

	public static int[] MEOLRTFJGPF()
	{
		return null;
	}

	public static void IOFQGHNPRPF(bool LIPENRNHTJL = false)
	{
	}

	public static int SMSKTNHSLNH()
	{
		return 0;
	}

	public static void KKJQQEKLJRE(bool LIPENRNHTJL = true)
	{
	}

	public static int FSQHJFPMHKP(int PSPJIJNTMOI)
	{
		return 0;
	}

	public static int HEMRMLLTMTF()
	{
		return 0;
	}

	public static IEnumerable<int> REFLHTMTITH(bool ESKTQJKMFGN, int IQLQQNIPTPQ)
	{
		return null;
	}

	public static int HHPPKSOSOJH()
	{
		return 0;
	}

	public static int TMNJTNHMHTO()
	{
		return 0;
	}

	public static int FHRJFNOJJQE()
	{
		return 0;
	}

	public static int KKKGRFQFGFH()
	{
		return 0;
	}

	private static bool FKJGTPPSSTJ()
	{
		return false;
	}

	public static void OLEHRIRJFFL(bool NEFPNQJSHOE, bool LIPENRNHTJL)
	{
	}

	public static QuestList LNIQSOHSHPT()
	{
		return null;
	}

	public static int OHHHNIMFKSS()
	{
		return 0;
	}

	public static int QEIKNGISMOO()
	{
		return 0;
	}

	[CompilerGenerated]
	internal static string HIJNINLELHF()
	{
		return null;
	}

	[CompilerGenerated]
	internal static void KKEMRIKKNMS(WeeklyContractsConfig.ShopOfferConfig OOKOJFQKLJJ, ref ShopItemList IJLFOMGQSNO, ref List<WeeklyContractsConfig.ShopOfferConfig> MRIMMLLKFNR, ref List<WeeklyContractsConfig.ShopOfferConfig> PLESOEIIHKM)
	{
	}

	[CompilerGenerated]
	internal static bool HLGRHKJPGFK(WeeklyContractsConfig.ShopOfferConfig HNLHQPIFJNS, ShopItemList QLKLFRTEOEP)
	{
		return false;
	}

	[CompilerGenerated]
	internal static void RJFKRNKLJLH(ShopItemList KKHHSKFGFSL, ref List<WeeklyContractsConfig.ShopOfferConfig> SILFMMSJLIJ)
	{
	}

	[CompilerGenerated]
	internal static int IIMPJQQOPLN(int PIFNNOOSSOH)
	{
		return 0;
	}

	[CompilerGenerated]
	internal static int TLJIRHJKGTF(int PIFNNOOSSOH)
	{
		return 0;
	}
}
