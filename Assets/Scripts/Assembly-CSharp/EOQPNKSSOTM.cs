using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;

public class EOQPNKSSOTM
{
	public enum REERSSMFEIQ
	{
		INVALID = 0,
		PLAYER = 1,
		CORE = 2,
		BASE = 3,
		LEAGUE = 4,
		CONFIG_CORE = 5,
		CONFIG_BASE = 6,
		CONFIG_LEAGUE = 7,
		DONATION_RESPONSE = 8,
		RANDOM_GROUPS_RESPONSE = 9
	}

	public enum FSHIPRSLHTE
	{
		Coins = 0,
		Chest = 1
	}

	public enum GJMQMORNOSQ
	{
		Cash = 0,
		Gems = 1,
		Inapp = 2
	}

	public enum OMMSKMEQSIT
	{
		Leader = 0,
		Officer = 1,
		Member = 2,
		ExMember = 3
	}

	public enum MPNKIHPGMFI
	{
		Invalid = 0,
		InProgress = 1,
		AllRewardsClaimed = 2,
		ClaimedPreviously = 3,
		ReadyToClaimChest = 4,
		ReadyToClaimCoins = 5
	}

	[Serializable]
	public struct Metadata
	{
		public int level;

		public List<DayContribution> clanActivity;

		public bool hasPassword;

		public int minPlayerLevel;

		public int league;
	}

	[Serializable]
	public struct Description
	{
		public string desc;

		public string msg;

		public Description(string TSRPFHOJKSG)
		{
			desc = null;
			msg = null;
		}
	}

	[Serializable]
	public class JoinDate
	{
		public string user;

		public int ts;
	}

	[Serializable]
	public struct DayContribution
	{
		public int ts;

		public int activity;
	}

	[Serializable]
	public class BaseData
	{
		public List<RoomData> rooms;

		public BuildData buildData;

		public BoostsData boostsData;
	}

	[Serializable]
	public class RoomData
	{
		public int id;

		public int level;
	}

	[Serializable]
	public class BuildData
	{
		public bool roomBuildInProgress;

		public int roomIdInProgress;

		public int roomStartTimestamp;

		public int roomAssistedSeconds;
	}

	[Serializable]
	public class BoostsData
	{
		public List<UIRoomLaboratory.BoostLevel> levels;

		public bool upgradeInProgress;

		public int boostIdInProgress;

		public int startTimestamp;

		public int assistedSeconds;
	}

	[Serializable]
	public class CoreData
	{
		public int exp;

		public int coins;

		public int honor;

		public int cashDonationCount;

		public int gemDonationCount;

		public int weeklyCashDonationCount;

		public int weeklyGemDonationCount;

		public int lastWeekDonationsCount;

		public int inappDonationCount;

		public int donationTier;

		public Contributions contributions;

		public Contributions lifeContributions;

		public int shopSeed;

		public int t;

		public int tw;

		public List<JoinDate> joinDates;

		public int kickedTodayCount;
	}

	[Serializable]
	public class LeagueData
	{
		public List<LeagueInfo> leagues;
	}

	[Serializable]
	public class LeagueInfo
	{
		public int leagueIndex;

		public int bucketIndex;

		public long resetTs;

		public long leagueUniqueIndex;

		public bool rewardsClaimed;

		public bool participated;

		public int contractsCompleted;

		public string[][] firstCompletion;

		public override string ToString()
		{
			return null;
		}

		public string IHKGEGTGRKE(int PQPIEJGPJJO)
		{
			return null;
		}

		public string IHKGEGTGRKE(int PQPIEJGPJJO, int GPFLNRGSTES)
		{
			return null;
		}
	}

	[Serializable]
	public class PlayerData
	{
		[Serializable]
		public class LeaguesData
		{
			[Serializable]
			public class MissionData
			{
				public int localRewardGained;

				public int scoreGained;
			}

			public long uniqueIndex;

			public int currentScore;

			public int tickets;

			public bool missionInProgress;

			public long missionStartTs;

			public List<MissionData> missionsData;

			public int dailyContractsCompleted;

			public int SOEFMLQPMQG(int LIQGLGKPMPE)
			{
				return 0;
			}

			public int HFIQSMQJTEO(int LIQGLGKPMPE)
			{
				return 0;
			}

			public bool SPKNSLKPSHP(int LIQGLGKPMPE, int EERRGHKNKNK)
			{
				return false;
			}

			public bool KFMETEIGPSH(int LIQGLGKPMPE, int EERRGHKNKNK)
			{
				return false;
			}

			public int PKKFOLKJSTK()
			{
				return 0;
			}

			public int HNGNRENMNSF()
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private sealed class GRFEKHOHSRL
		{
			public ClanAchievement achievement;

			internal bool _003CIsAnyAchievementClaimable_003Eb__0(ClanAchievementConfig cfg)
			{
				return false;
			}
		}

		public int coins;

		public int honor;

		public int t;

		public int tw;

		public int dt;

		public int donationTier;

		public int cashDonations;

		public int gemDonations;

		public int inappDonations;

		public int inappTicketsT0;

		public int inappTicketsT1;

		public int inappTicketsT2;

		public bool hasAssistedBuild;

		public bool hasAssistedBoost;

		public bool hasJoinedToday;

		public int totalD;

		public int weekD;

		public int lastWeekD;

		public ClanShopData shopData;

		public ClanLeaves clanLeaves;

		public Rewards rewards;

		public List<ClanAchievement> achievements;

		public List<Ban> bans;

		public List<ChatBan> chatBans;

		public List<InappReceipt> receipts;

		public LeaguesData leaguesData;

		public long lastLeagueRewardIndex;

		public bool NHFMGERILRN()
		{
			return false;
		}

		public Reward GKHFEIPNNGO()
		{
			return null;
		}

		public bool RLKLHFTEGTK()
		{
			return false;
		}

		public bool MFIHSRTNOEQ(GJMQMORNOSQ EOOEIROQJOE)
		{
			return false;
		}

		public bool QIPNOJHMRGH()
		{
			return false;
		}

		public int LINQGHKIPQT()
		{
			return 0;
		}

		public int FKHTILJMLON()
		{
			return 0;
		}

		public int HOERHPELTOL()
		{
			return 0;
		}

		public ChatBan OSIKQTQOGEQ(int OTNEQKMGLNS)
		{
			return null;
		}
	}

	[Serializable]
	public class Rewards
	{
		public DonationRewards donationRewards;
	}

	[Serializable]
	public class Ban
	{
		public int kickedOnTs;

		public string groupId;
	}

	[Serializable]
	public class ChatBan
	{
		public int banUntilTs;

		public int reason;
	}

	[Serializable]
	public class InappReceipt
	{
		public string receipt;

		public string transactionId;

		public int ts;

		public int tier;
	}

	[Serializable]
	public class DonationRewards
	{
		public int donationTier;

		public List<Reward> liveRewards;

		public List<Reward> lastRewards;
	}

	[Serializable]
	public class Reward
	{
		public int tier;

		public FSHIPRSLHTE type;

		public int value;

		public int ts;
	}

	[Serializable]
	public class ClanShopData
	{
		public List<ClanRoomData> shops;
	}

	[Serializable]
	public class ClanLeaves
	{
		public int numTotalClanLeaves;

		public int numDailyClanLeaves;

		public int joinClanRestrictionTs;

		public void RHIERRNKFJF()
		{
		}

		public int QLTOSPIRRIO()
		{
			return 0;
		}

		public ClanLeaves MEGITIITHNT()
		{
			return null;
		}
	}

	[Serializable]
	public class ClanRoomData
	{
		public int id;

		public List<BoughItem> boughtItems;
	}

	[Serializable]
	public class BoughItem
	{
		public int id;

		public int count;
	}

	[Serializable]
	public class PrivateData
	{
		public string password;
	}

	[Serializable]
	public class ClanCoreConfig
	{
		public int emblemCost;

		public MiscCfg misc;

		public DonationConfigs donationConfigs;

		public List<ClanAchievementConfig> achievements;

		public int[] lvlXpRequirements;

		public int contributionLiveTime;

		public int[] clanSize;

		public int leaderActivityDeadline;

		public int[] assists;

		public bool debugCallsEnabled;

		public int EMLQFSHHMKF(int MJPKLHHTJTJ)
		{
			return 0;
		}

		public DonationConfig NESPJFFMQOM(GJMQMORNOSQ NETQNSSOTGQ, int FOQIJNNSRNI = 0)
		{
			return null;
		}
	}

	[Serializable]
	public class MiscCfg
	{
		public int autosearchBanDuration;

		public int autosearchBanKickCount;

		public bool maintenance;

		public int resetHour;

		public int banDuration;

		public int dayReset;

		public int weekReset;

		public int freeLeaves;

		public int[] leavePenalties;
	}

	[Serializable]
	public class ClanAchievementConfig
	{
		public int id;

		public int maxLevel;

		public int[] requirements;

		public int[] rewards;
	}

	[Serializable]
	public class ClanAchievement
	{
		public int id;

		public int progress;

		public int level;
	}

	[Serializable]
	public class DonationConfigs
	{
		public float coinsPerProgressRatio;

		public int[] rewards;

		public float[] bonuses;

		public DonationConfig cash;

		public DonationConfig gems;

		public DonationConfig[] inapp;
	}

	[Serializable]
	public class DonationConfig
	{
		public int costAmount;

		public int gainClanCoins;

		public int gainExp;

		public int gainPlayerCoins;

		public int gainPlayerContribution;

		public int increaseTime;

		public int limit;

		public int[] milestones;

		public int limitMultiplier;

		public int OTSSMHKKPHG(int MJPKLHHTJTJ)
		{
			return 0;
		}

		public int NGRPMNMHPQJ(int MJPKLHHTJTJ)
		{
			return 0;
		}

		public float JQJSOJMHOPH(int MJPKLHHTJTJ)
		{
			return 0f;
		}

		public int MQMQIMETSLF(int MJPKLHHTJTJ)
		{
			return 0;
		}
	}

	[Serializable]
	public class Contribution
	{
		public string user;

		public int amount;

		public int ts;

		public int[] counts;
	}

	[Serializable]
	public class Contributions
	{
		public List<Contribution> list;
	}

	[Serializable]
	public class ClanBaseConfig
	{
		public List<RoomConfig> rooms;

		public BuildAssistConfig assist;

		public List<ItemForPurchase> inventory;

		public List<SkinEntry> skins;

		public List<BoostConfig> boostConfigs;

		public int shopActivityReq;

		public bool ENGSQKJGROM(int RKJTFRTJSIR)
		{
			return false;
		}

		public BoostConfig EKGIPMFSKSO(int IQLQQNIPTPQ)
		{
			return null;
		}

		public int SPLOPTPHONN(int TOHTOFEHMHM)
		{
			return 0;
		}
	}

	[Serializable]
	public class ClanLeagueConfig
	{
		public bool maintenance;

		public string minVersion;

		public int minBuild;

		public int maxBucketSize;

		public int numLeagues;

		public float[][] transitionFactors;

		public int[][] honorRewards;

		public float[] honorMaxMultipliers;

		public long[][] honorScore;

		public int[] scoreRewards;

		public int[] gemRewards;

		public int[][] contractRequirements;

		public int[][] revivePrices;

		public int numFloorsPerBoss;

		public long resetInterval;

		public bool promoteWithoutEntry;

		public bool poolsToBucketsSchedulerEnabled;

		public bool bucketsToPoolsSchedulerEnabled;

		public long leaderboardResetUnixOffset;

		public long missionsPlayableUntilOffset;

		public long poolsSchedulerOffset;

		public long rewardsOffset;

		public long finishOffset;

		public int startingTickets;

		public int dailyTickets;

		public int ticketContribution;

		public int contractContribution;

		public long missionTimeout;

		public ClanMissionConfig.GameplayConfig gameplayConfig;

		public (int, int, int) KNNEFEHPHOM(int PSLQPFEKSHG, int EOOJMQRIRNL)
		{
			return default((int, int, int));
		}

		public string LJFOPGHIREF(LeagueInfo JOMLRMTGQKN)
		{
			return null;
		}

		public bool SQFOSEENJKS(int PSLQPFEKSHG, int EOOJMQRIRNL)
		{
			return false;
		}

		public int FIKOORGKKQM(int PSLQPFEKSHG)
		{
			return 0;
		}

		public float[] NQOPJJNFGNQ(int PSLQPFEKSHG)
		{
			return null;
		}

		public int LFHSOFGPOLT(int EERRGHKNKNK, int PFMLHIPPIIQ)
		{
			return 0;
		}

		public int FSKKOGGIJEF(int PSLQPFEKSHG, int FRHSQTFJEET)
		{
			return 0;
		}

		public List<(int, int)> FISLSHLQSLF(int PSLQPFEKSHG)
		{
			return null;
		}

		public float SPJRFTKQENE(int PSLQPFEKSHG)
		{
			return 0f;
		}

		public int RIOHRGLSGNO(int EERRGHKNKNK)
		{
			return 0;
		}

		public int MOJNSNOTROG(int EERRGHKNKNK, int HGHNNIKROLL = 0)
		{
			return 0;
		}

		public int RQLMLTKLQQK(int EERRGHKNKNK)
		{
			return 0;
		}

		public int OPNTJPJFIMP(int EERRGHKNKNK, int HGHNNIKROLL = 0)
		{
			return 0;
		}

		public int QKJHRERTKEH(int PSLQPFEKSHG, int FRHSQTFJEET)
		{
			return 0;
		}

		private static List<(int, int)> FHRKSTLRNPI(int[] FNOINEOPGKF, int NLMMRENETKM)
		{
			return null;
		}

		public int QITJJLJKENG(int PMNGMSRTHLP)
		{
			return 0;
		}
	}

	[Serializable]
	public class BuildAssistConfig
	{
		public int gainedXp;

		public int gainedContribution;
	}

	[Serializable]
	public class SkinEntry
	{
		public IRHNENTFPPM skin;

		public int cost;
	}

	[Serializable]
	public class BoostConfig
	{
		public int cost;

		public int upgradeTime;

		public int roomLevelRequirement;
	}

	[Serializable]
	public class RoomConfig
	{
		[CompilerGenerated]
		private sealed class TTJQFELTLQI
		{
			public RoomConfig _003C_003E4__this;

			public ClanBaseConfig config;

			public ClanShopItemData clientInventory;

			internal bool _003CItemList_003Eb__0(ShopItem x)
			{
				return false;
			}
		}

		public int id;

		public int[] lvlRequirements;

		public int[] buildTimes;

		public int[] costs;

		public bool autoLevelUp;

		public List<ShopItem> items;

		[NonSerialized]
		private List<ShopItem> filteredItems;

		public List<ShopItem> HEIPKQJRMFP()
		{
			return null;
		}

		private bool JFOTTEFOMTL(int RKJTFRTJSIR, ClanBaseConfig SOSLGOOOIPG, ClanShopItemData ETHMHIQFQQJ)
		{
			return false;
		}
	}

	[Serializable]
	public class ItemForPurchase
	{
		public int type;

		public int max;

		public int cost;

		public int amount;
	}

	[Serializable]
	public class ShopItem
	{
		public int id;

		public int minRoomLevel;

		public int slot;

		[NonSerialized]
		private ItemForPurchase data;

		public ItemForPurchase Data => null;
	}

	[Serializable]
	public struct DonationResponsePayload
	{
		public int xp;

		public int tokens;
	}

	public Metadata JGTOKGTFLOO;

	public CoreData PRSKRIHHILK;

	public BaseData SKEEKPJTTNN;

	public LeagueData TMTKQLKQNOO;

	public IApiGroup FTHRGHHSOPG;

	public List<IGroupUserListGroupUser> JKGQLSPNIRP;

	public static readonly string TTMRSRPIHRS;

	public static readonly string HTQQTGMKRHR;

	public static readonly string QKLLHOPRFJS;

	public static readonly string QGESOQQJLNI;

	public static readonly string QPTFGRLHQJL;

	public static readonly string JGLRSPIEEIT;

	public static readonly string ITFSRPLHJSL;

	public static readonly string LTTKROPELOJ;

	public static readonly string RMFFGHHGEMJ;

	public static readonly string SHELMFEQKPE;

	public static readonly Dictionary<string, REERSSMFEIQ> EPTFOROKIJN;

	private const int RLKLKIOMGIP = 604800;

	private const int IGQRJGQJQFF = 86400;

	public string ITKHQMKJTQJ => null;

	public Task NGHFQRREIJN(IApiGroup NTIPSJNKNOE)
	{
		return null;
	}

	public void EETLHPRONHH(IApiGroup NTIPSJNKNOE)
	{
	}

	public int OFQPNSKTJJH()
	{
		return 0;
	}

	private int GELENNRQTKG()
	{
		return 0;
	}

	public int NGRPMNMHPQJ()
	{
		return 0;
	}

	public int NQENERRHNSO(string LEMGFIIIJQK)
	{
		return 0;
	}

	public bool PRIQQJFKPFK()
	{
		return false;
	}

	public Task<bool> KNKMOSISHJL()
	{
		return null;
	}

	public int RIFHLHSOFNH()
	{
		return 0;
	}

	public Task<IApiGroupUserList> KFRKNFMFHTF(string GNKIKJOFGRI)
	{
		return null;
	}

	public Task<bool> RMTLSHJIFRO()
	{
		return null;
	}

	public Task<bool> MKNLOOKSTNF()
	{
		return null;
	}

	private void TORHQTMKKTN(IApiStorageObjects MHGSOKIEHQE)
	{
	}

	public Task RKGJHOMFPRM()
	{
		return null;
	}

	public bool QHGJEMGKKLL()
	{
		return false;
	}

	public void QRTHKKQRHRP(string QKQMRGKQOMI, string RRPSNPOTQNT)
	{
	}

	public static void FNQQSKEJGGF(string HETQTIKJGNI)
	{
	}

	public static void FNQQSKEJGGF(object HNTPNTJRJMH)
	{
	}

	public static string GLQHSOSJFQN(OMMSKMEQSIT MJPJLPIKQFE)
	{
		return null;
	}

	public static string GQOTJEEMNIP(ClanServerCalls.SSQEPNESKEM JOQHQTGGOIR)
	{
		return null;
	}

	public static OMMSKMEQSIT FPSIJNRIQPM(int MJPJLPIKQFE)
	{
		return default(OMMSKMEQSIT);
	}

	public static OMMSKMEQSIT FPSIJNRIQPM(IGroupUserListGroupUser EJIRLENHFJM)
	{
		return default(OMMSKMEQSIT);
	}

	public static int LOMJKFGMEKT()
	{
		return 0;
	}

	public static int PMJMIOIRKSL()
	{
		return 0;
	}

	public static int INGQKLPEHRH(int MKLLHHINHJP, int EESTGTGKLJG)
	{
		return 0;
	}

	public bool KRLKOOGJPFO()
	{
		return false;
	}

	private static bool JIPKTSTHSQT(int MKLLHHINHJP, int MQSTJHFMETT)
	{
		return false;
	}

	public int SPTMRKQKNGH()
	{
		return 0;
	}

	public int GOEEJGJFFMK()
	{
		return 0;
	}

	private static int POKHOGLJPOG()
	{
		return 0;
	}

	public static int HEPHSFQIJNL()
	{
		return 0;
	}

	private static int HIPTSRNEGRO(DayOfWeek ESRIIFHJFJF)
	{
		return 0;
	}
}
