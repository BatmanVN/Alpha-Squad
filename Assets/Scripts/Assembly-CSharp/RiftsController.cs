using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RiftsController : MonoBehaviour, EKFFMKLSSNN
{
	[Serializable]
	public struct Config
	{
		public int start_timestamp;

		public int regular_duration;

		public int cooldown_duration;

		public int finalizing_results_duration;

		public int placement_duration;

		public int level_duration;

		public float level_killscore;

		public int floors_per_bracket;

		public int chest_level;

		public int first_season;
	}

	[Serializable]
	public struct Data
	{
		public Instance instance;

		public int seasonIndex;

		public int floor;

		public int selectedFloor;

		public List<Record> clears;

		public int rank;

		public LeaderboardMeta meta;

		public float percentile;

		public int totalLeaderboardRecords;

		public int highestCompletedFloor;

		public int highestCompletedFloorInTime;

		public int recordFloor;

		public int recordScore;

		public bool rewardsGranted;

		public bool newRiftSeen;

		public int participationIndex;

		public int placementGames;

		public List<string> watchList;

		public bool newRiftBlockSeen;

		public bool newRiftRewardsSeen;

		public bool riftAttempted;
	}

	[Serializable]
	public class Snapshot
	{
		public LoadoutWithDataAndGlobalEnhancements loadout;

		public Record record;

		public int cp;
	}

	[Serializable]
	public struct Record
	{
		private const int SEPARATOR = 1000000;

		public int floor;

		public int milliseconds;

		public long EEIIFPEJGNL()
		{
			return 0L;
		}

		public Record(long PMNGMSRTHLP)
		{
			floor = 0;
			milliseconds = 0;
		}
	}

	[Serializable]
	public struct LeaderboardMeta
	{
		public string name;

		public RRMFSKNJIOH agentId;

		public int agentLevel;

		public int leaderboardRecords;

		public string hash;

		public float PTOTJHJPNJT(int ORSGPHEJRPG, int GRIJOQOJLGJ)
		{
			return 0f;
		}
	}

	[Serializable]
	public class Instance
	{
		public int enemyLevel;

		public float secondsPassed;

		public float killScore;

		public bool minibossKilled;

		public int floor;

		public bool QLIGRLSOKSM()
		{
			return false;
		}

		public bool RFFRRNLTNLH()
		{
			return false;
		}

		public float SNJLGPIRENO()
		{
			return 0f;
		}

		public int JHOMMFPFTLO()
		{
			return 0;
		}
	}

	[Serializable]
	public struct SeasonTime
	{
		public int endTimestamp;

		public int cooldownDuration;

		public int finalizingResultsDuration;

		public int placementDuration;

		public int KEQLKLPESJS()
		{
			return 0;
		}

		public int SSLMFTTGKIM()
		{
			return 0;
		}

		public int IRRJLQQIRKR()
		{
			return 0;
		}
	}

	public enum JHQLJJTRHRG
	{
		None = 0,
		Available = 1,
		Cooldown = 2,
		FinalizingResults = 3
	}

	[CompilerGenerated]
	private sealed class LQNLJJOPIJS
	{
		public int floor;

		internal bool _003CGetClearTimeForFloor_003Eb__0(Record x)
		{
			return false;
		}

		internal bool _003CGetClearTimeForFloor_003Eb__1(Record x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct ONTFFRFNHQT
	{
		public RiftConfig scfg;
	}

	public const int NUM_PLACEMENT_GAMES = 1;

	public const int MAX_WATCH_LIST_SIZE = 50;

	public static readonly SeasonTime[] CUSTOM_SEASON_DURATIONS;

	private static Config SOSLGOOOIPG;

	private static Data TSRPFHOJKSG;

	private static QHOERPGGPPJ SPTHNPJLNQN;

	private static QHOERPGGPPJ PMREKOENJQL;

	private static QHOERPGGPPJ GHTSFNSPHJE;

	private static QHOERPGGPPJ FQLMSNQIQKS;

	private static QHOERPGGPPJ MFKPHKSOKIG;

	private static Dictionary<string, Snapshot> PRFLQMOSSSI;

	private static bool QRPLONEEHQM;

	private static bool OQISMJQFRJR;

	private static bool JREGORLKOST;

	public static string KEY;

	public static string SNAPSHOT_KEY;

	public static string SNAPSHOT_COLLECTION;

	public static string DEEP_LINK_KEY;

	public static event Action OLNKQJMTIFG
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

	public static event Action<int> MENGIJQMJFR
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

	private void REIQINPKSKQ()
	{
	}

	private void JNQJPHQGPGJ()
	{
	}

	private static void MLNESSGJRME()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static void SaveData()
	{
	}

	public static void Clear()
	{
	}

	public static void ResetData()
	{
	}

	public static Data GetData()
	{
		return default(Data);
	}

	public static Config GetConfig()
	{
		return default(Config);
	}

	public static Instance GetInstance()
	{
		return null;
	}

	public static bool IsAvailable()
	{
		return false;
	}

	public static bool IsCooldownAvailable()
	{
		return false;
	}

	public static bool AreRiftsDisabled()
	{
		return false;
	}

	public static bool IsMinVersionMet()
	{
		return false;
	}

	public static bool IsPlayed()
	{
		return false;
	}

	public static bool IsSeen()
	{
		return false;
	}

	public static int GetSeasonTimeRemaining()
	{
		return 0;
	}

	public static int GetTimeRemainingToCooldown()
	{
		return 0;
	}

	private static int GIHMSFTGEJT()
	{
		return 0;
	}

	private static int LPHPFTJHNEG()
	{
		return 0;
	}

	private static int QKLOQSPTKLO()
	{
		return 0;
	}

	public static int GetTimeRemainingToRewards()
	{
		return 0;
	}

	public static int GetTimeRemainingToPlacementFinish()
	{
		return 0;
	}

	public static bool IsInCooldownState()
	{
		return false;
	}

	public static bool IsInFinalizingResultsState()
	{
		return false;
	}

	public static bool IsInPlacementPeriod()
	{
		return false;
	}

	public static bool HasFinishedPlacementGames()
	{
		return false;
	}

	public static bool IsPlacementMode()
	{
		return false;
	}

	public static bool AreRewardsGrantable()
	{
		return false;
	}

	private static int NFHSMGLSMQO()
	{
		return 0;
	}

	public static bool CurrentSeasonHasData()
	{
		return false;
	}

	public static int GetSeasonIndex()
	{
		return 0;
	}

	public static int GetSeasonIndexForDisplay()
	{
		return 0;
	}

	public static string GetSeasonLabel()
	{
		return null;
	}

	public static string GetSeasonLabelForSeason(int FMMGOOREKRL)
	{
		return null;
	}

	public static int ConvertSeasonIndexForDisplay(int PSPJIJNTMOI)
	{
		return 0;
	}

	private static int JRMSJKLKELP(int GRIJOQOJLGJ)
	{
		return 0;
	}

	public static int GetHighestRiftFloor()
	{
		return 0;
	}

	public static int GetEnemyLevelForRiftFloor(int EIPLFTTPEKJ)
	{
		return 0;
	}

	public static int GetCurrentEnemyLevel()
	{
		return 0;
	}

	public static LOEOGTTNOES.HFEOHSLJJFM GetConfigForGameplayMode()
	{
		return null;
	}

	public static RiftConfig.BracketConfig GetCurrentBracketConfig()
	{
		return default(RiftConfig.BracketConfig);
	}

	public static Task<(PLEHFILISJN.NPNPFMQTFNI, int)> GetRatingForPreviousSeason(int GRIJOQOJLGJ)
	{
		return null;
	}

	public static PLEHFILISJN.NPNPFMQTFNI GetRatingFromRank(int ORSGPHEJRPG, int KRRPJENTMIK, int GRIJOQOJLGJ)
	{
		return default(PLEHFILISJN.NPNPFMQTFNI);
	}

	public static Task<PLEHFILISJN.TMINGRFEIKI> GetCurrentLeagueAsync()
	{
		return null;
	}

	public static PLEHFILISJN.QQNJQRQQTGM GetLeagueFromRank(int ORSGPHEJRPG, float KRRPJENTMIK, int GRIJOQOJLGJ, out int MKEEOHFLSEM)
	{
		MKEEOHFLSEM = default(int);
		return default(PLEHFILISJN.QQNJQRQQTGM);
	}

	public static PLEHFILISJN.QQNJQRQQTGM GetLeagueFromRank(int ORSGPHEJRPG, int TLQERTOFQPH, int GRIJOQOJLGJ, out int MKEEOHFLSEM)
	{
		MKEEOHFLSEM = default(int);
		return default(PLEHFILISJN.QQNJQRQQTGM);
	}

	public static bool ShouldEnterRiftsPanel()
	{
		return false;
	}

	public static bool IsFloorUnlocked(int GTKOJISNPOE)
	{
		return false;
	}

	public static bool IsFloorUnlockedForMaxFloor(int GTKOJISNPOE, int MQFMQLKTFNT)
	{
		return false;
	}

	public static bool IsPreviousBracketUnlocked(int ELEIPINNGGJ)
	{
		return false;
	}

	public static bool IsBracketUnlocked(int ELEIPINNGGJ)
	{
		return false;
	}

	public static bool IsBracketUnlockedForMaxFloor(int ELEIPINNGGJ, int MQFMQLKTFNT)
	{
		return false;
	}

	public static int GetCurrentBracket()
	{
		return 0;
	}

	public static Snapshot GetLastSnapshot()
	{
		return null;
	}

	public static RiftConfig GetCurrentRiftConfig()
	{
		return null;
	}

	public static RiftConfig GetNextRiftConfig()
	{
		return null;
	}

	public static RiftConfig GetCurrentOrAnyPreviousRiftConfig()
	{
		return null;
	}

	public static string GetLeaderboardId()
	{
		return null;
	}

	public static Task<Snapshot> TryGetSnapshotForOwner(string IPEOLHNKPHM, long PMNGMSRTHLP)
	{
		return null;
	}

	public static RiftConfig GetRiftConfigForSeasonIndex(int GRIJOQOJLGJ)
	{
		return null;
	}

	public static QHOERPGGPPJ GetLeaderboard()
	{
		return null;
	}

	public static QHOERPGGPPJ GetOwnerLeaderboard()
	{
		return null;
	}

	public static QHOERPGGPPJ GetAroundOwnerLeaderboard()
	{
		return null;
	}

	public static QHOERPGGPPJ GetWatchListLeaderboard()
	{
		return null;
	}

	public static QHOERPGGPPJ GetClanLeaderboard()
	{
		return null;
	}

	public static Task<IApiLeaderboardRecord> GetOwnerLeaderboardEntry()
	{
		return null;
	}

	public static void ClearLeaderboardCaches()
	{
	}

	public static int GetClearTimeForFloor(int EERRGHKNKNK)
	{
		return 0;
	}

	private static MinibossConfig TOHGOGMMGQJ(int EIPLFTTPEKJ)
	{
		return null;
	}

	public static bool IsFloorClearedInTime(int EERRGHKNKNK)
	{
		return false;
	}

	private static bool PSLKKGETFFP(float HNMPLNRTRHH)
	{
		return false;
	}

	public static int GetHighestCompletedFloorInTime()
	{
		return 0;
	}

	public static int GetBracketIndexForFloor(int EERRGHKNKNK)
	{
		return 0;
	}

	public static bool IsNewRiftBlockSeen()
	{
		return false;
	}

	public static void SetNewRiftBlockSeen()
	{
	}

	public static void SetSeen()
	{
	}

	public static void SetEnterRiftsPanel()
	{
	}

	public static void ResetEnterRiftsPanel()
	{
	}

	public static void DebugResetPlacementGames()
	{
	}

	public static void TryGrantRewardsAndEndSeason()
	{
	}

	private static int FPRKOEKFPLM()
	{
		return 0;
	}

	private static int TFGGIEKKPQH()
	{
		return 0;
	}

	public static Task<bool> GrantRewards(int FMMGOOREKRL, bool TFSJGQOSQIK = false)
	{
		return null;
	}

	public static void ClaimRewards(RiftRewardConfig.Reward FILOKRMHOJJ, RiftConfig MQNPSKHREQI)
	{
	}

	private static void QMHNFTLSQSQ(Instance JGOMELIPEPS, bool LIPENRNHTJL = false)
	{
	}

	public static Task<bool> SubmitScoreAndSnapshot()
	{
		return null;
	}

	public static void SelectRiftFloor(int EERRGHKNKNK)
	{
	}

	public static void SelectLatestRiftFloor()
	{
	}

	public static void GenerateInstance()
	{
	}

	public static string GetStringForTime(int EFNLONLIMFJ)
	{
		return null;
	}

	public static float CalculatePercentile(int ORSGPHEJRPG, int SFQFRTFLOEP, int GRIJOQOJLGJ)
	{
		return 0f;
	}

	public static int CalculatePercentileOld(int ORSGPHEJRPG, int SFQFRTFLOEP)
	{
		return 0;
	}

	private static void ORKNIGKMPRP(LevelController.RunData IRETPMEROII, Instance JGOMELIPEPS)
	{
	}

	public static bool IsNewRiftRewardsSeen()
	{
		return false;
	}

	public static void SetNewRiftRewardsSeen()
	{
	}

	public static void SetRiftAttempted()
	{
	}

	public static bool WasRiftAttempted()
	{
		return false;
	}

	private void MONJFKLHSNJ()
	{
	}

	private static void OEMLRRRHMTQ(Scene SLRMLOOSEGG, LoadSceneMode NHOJNMIMTKJ)
	{
	}

	private static void JOQGLQQSLJN(MenuView QLINOLJLIMP)
	{
	}

	private static void MOJIPKPSSNT()
	{
	}

	public MinibossConfig GetMinibossConfig()
	{
		return null;
	}

	public bool ShouldStageHaveMiniboss()
	{
		return false;
	}

	public WorldData.JQNPLTQOFMJ GetWorldType()
	{
		return default(WorldData.JQNPLTQOFMJ);
	}

	public int GetWorldVariation()
	{
		return 0;
	}

	public int GetNumStages()
	{
		return 0;
	}

	public float GetDensity(int MTFHQPOPFKQ)
	{
		return 0f;
	}

	public EnemyCount GetEnemyCount(int MTFHQPOPFKQ)
	{
		return default(EnemyCount);
	}

	public int GetEnemyLevel(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public int GenerateNewStageId(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public uint GetSeed(int MTFHQPOPFKQ)
	{
		return 0u;
	}

	public bool IsEnemyTypeAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return false;
	}

	public bool IsEnemyEliteAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return false;
	}

	public float GetEliteChance(int MTFHQPOPFKQ)
	{
		return 0f;
	}

	public int GetEliteLevelAdd(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public string GetAnalyticsContext()
	{
		return null;
	}

	public static void ClearRiftsFloorInTime(int EERRGHKNKNK = -1, int FGEKRLQNFIK = -1)
	{
	}

	public static void ClearRiftsFloorLate()
	{
	}

	public void ForceClaimReward(PLEHFILISJN.QQNJQRQQTGM PSLQPFEKSHG, int MKEEOHFLSEM)
	{
	}

	public static string GetStaticAnalyticsContext()
	{
		return null;
	}

	public static bool IsInWatchList(string IPEOLHNKPHM)
	{
		return false;
	}

	public static List<string> GetWatchList()
	{
		return null;
	}

	public static bool AddToWatchList(string IPEOLHNKPHM)
	{
		return false;
	}

	public static bool IsWatchListFull()
	{
		return false;
	}

	public static void RemoveFromWatchList(string IPEOLHNKPHM)
	{
	}

	[CompilerGenerated]
	internal static ChestController.ChestData NNSPENHIIEN(ChestController.MFRETPOLGOE MROKKGHHGTN, ref ONTFFRFNHQT P_1)
	{
		return null;
	}
}
