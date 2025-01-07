using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class OperationController : MonoBehaviour, EKFFMKLSSNN
{
	public enum JMSSNJLGTFN
	{
		UNSET = -1,
		EASY = 0,
		MEDIUM = 1,
		HARD = 2,
		EXTREME = 3
	}

	[Serializable]
	public struct Config
	{
		public OperationConfig operation;

		public OperationGenDifficultyConfig[] generation_config;

		public JJHFPNTSRLT.LevelOffset[] generation_scaling_levelOffsets;

		public int spinagain_gem_price;

		public int instant_complete_price;

		public int KSEPMPNPSTT(int NERGMFPHLIM)
		{
			return 0;
		}
	}

	[Serializable]
	public struct OperationConfig
	{
		public int[] easyStages;

		public int[] mediumStages;

		public int[] hardStages;

		public OperationsWorldConfig[] worlds;

		public OperationNameConfig names;

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public struct OperationGenDifficultyConfig
	{
		public JMSSNJLGTFN difficulty;

		public int points;

		public int stagesMin;

		public int stagesMax;

		public JJHFPNTSRLT.MinMaxValueInt lvlOffset;
	}

	[Serializable]
	public struct OperationsWorldConfig
	{
		public WorldData.JQNPLTQOFMJ id;

		public EnemySpot.SMMGLQPTJET[] enemyTypes;

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public struct OperationNameConfig
	{
		public string[] firstName;

		public string[] lastName;
	}

	[Serializable]
	public struct OperationStageConfig
	{
		public int id;

		public EnemySpot.SMMGLQPTJET[] enemyTypesBlackList;

		public float eliteChance;
	}

	[Serializable]
	public struct OperationRewards
	{
		public List<ItemWeapon> weapons;

		public List<JJHFPNTSRLT.AgentIdWithCount> agents;

		public CurrencyData currencies;

		public JJHFPNTSRLT.PQRIQGIOGQT gambleRarity;
	}

	[Serializable]
	public struct OperationGambleRewards
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public CurrencyData currencies;

		public List<ItemWeapon> weapons;
	}

	[Serializable]
	public struct OperationData
	{
		[CompilerGenerated]
		private sealed class HJPNKEKKGNT
		{
			public OperationData self;

			internal int _003CGetRecommendedCP_003Eb__0(EnemySpot.SMMGLQPTJET x)
			{
				return 0;
			}
		}

		public string id;

		public string title;

		public bool completed;

		public int enemyLevel;

		public RKTKKOOERQQ.GambleReward[] allGambleRewards;

		public WorldData.JQNPLTQOFMJ worldType;

		public int worldVariation;

		public int difficulty;

		public int[] stages;

		public uint seed;

		public int EOIGSKGKRFT()
		{
			return 0;
		}

		public JJHFPNTSRLT.PQRIQGIOGQT OSKPRPGGLHM()
		{
			return default(JJHFPNTSRLT.PQRIQGIOGQT);
		}
	}

	[Serializable]
	public class Data
	{
		public OperationData[] activeOperations;

		public int lastResetTimestamp;

		public List<int> previousStages;

		public bool newOperations;

		public int originalLevel;
	}

	[CompilerGenerated]
	private sealed class QRTPQHNSGKG
	{
		public string operationId;

		internal bool _003CSelectOperation_003Eb__0(OperationData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FFESRSOOFPS
	{
		public string id;

		internal bool _003CGetOperationId_003Eb__0(OperationData x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct RMITJJOGMQG
	{
		public OperationNameConfig cfg;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct SRRORJSIFSK
	{
		public List<Tuple<int, int>> availStages;

		public List<Tuple<int, int>> stages;

		public OperationGenDifficultyConfig cfg;

		public int totalPoints;
	}

	[CompilerGenerated]
	private sealed class PLINJIQFPRQ
	{
		public int diff;

		internal bool _003CGenerateStagesForDifficulty_003Eb__10(Tuple<int, int> x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class ONPHTTGEENR
	{
		public int ret;

		internal bool _003CGenerateStagesForDifficulty_003Eb__11(Tuple<int, int> x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct NSRSGIPFHPT
	{
		public OperationData[] newEx;
	}

	[CompilerGenerated]
	private sealed class LONEFQFPPSR
	{
		public int resetEz;

		public int resetMd;

		public int resetHd;

		internal bool _003CResetPlayedStages_003Eb__0(int x)
		{
			return false;
		}
	}

	private static List<string> HFLLIMSLNTF;

	public static Config config;

	public static Data data;

	public static bool staticInitialized;

	private static OperationData MLSMSOOGNLK;

	[SerializeField]
	private GambleConfig gambleConfigInstance;

	private static bool STPPPGOSSHJ;

	public static string KEY;

	public static event Action NMNGGFQJPEL
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

	private static void MLNESSGJRME()
	{
	}

	public static void Clear()
	{
	}

	private static void MONJFKLHSNJ()
	{
	}

	private static void IJTQMKLKEIH()
	{
	}

	public static void OnInstantComplete()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static void CheckGenerateNewOperations()
	{
	}

	public static void SaveData()
	{
	}

	public static bool IsUnlocked()
	{
		return false;
	}

	public static OperationData GetCurrentOperation()
	{
		return default(OperationData);
	}

	public static OperationData[] GetAvailableOperations()
	{
		return null;
	}

	public static bool AnyNotCompletedOperations()
	{
		return false;
	}

	public static List<EnemySpot.SMMGLQPTJET> GetEnemyTypesForWorldType(WorldData.JQNPLTQOFMJ NJSSSTOQQNI)
	{
		return null;
	}

	public static List<EnemySpot.SMMGLQPTJET> GetEnemyTypesForOperations(OperationData HPRNTEJERMS)
	{
		return null;
	}

	public static bool HasNewOperations()
	{
		return false;
	}

	public static int GetSecondsTillNextReset()
	{
		return 0;
	}

	public static int GetSpinAgainGemPrice()
	{
		return 0;
	}

	public static void SelectOperation(string QTSOIOEQLLF)
	{
	}

	private static OperationData SQFMSSNSGJS(string HSLQJLPMLMH)
	{
		return default(OperationData);
	}

	public static void OnOperationRewardsAllClaimed()
	{
	}

	public static void SetNewOperationsSeen()
	{
	}

	private static string TTNEKKNLIEM(JMSSNJLGTFN OPJNKTMSTJR, WorldData.JQNPLTQOFMJ NJSSSTOQQNI)
	{
		return null;
	}

	private static int[] HFOSLIOIJEN(JMSSNJLGTFN OPJNKTMSTJR, bool IEJINQIJOSL = true)
	{
		return null;
	}

	private static OperationData[] GESPETQQTRQ()
	{
		return null;
	}

	private static RKTKKOOERQQ.GambleReward[] TJPLOLRSQQE(JMSSNJLGTFN OPJNKTMSTJR, int HHFHLJFISQF, List<RRMFSKNJIOH> IKQSGLFHNJL)
	{
		return null;
	}

	private static string PFSTETNKKGK(OperationData[] PLJENOHHEIJ)
	{
		return null;
	}

	public static int GetRewardEnemyLevel()
	{
		return 0;
	}

	public static int GetOriginalEnemyLevel()
	{
		return 0;
	}

	private static void HPOLSESMTSR(int GPRRIJQRIQN)
	{
	}

	private static void MHKLMJGIMSG(int JQPPJFSPPQG = 7)
	{
	}

	private static OperationGenDifficultyConfig NRMPEEQMPJS(JMSSNJLGTFN EFMSPPQPHMP)
	{
		return default(OperationGenDifficultyConfig);
	}

	public static void AutoCompleted()
	{
	}

	public void ResetData()
	{
	}

	public void PrintData()
	{
	}

	public void TestStageGen(JMSSNJLGTFN TJOORNQEGLK)
	{
	}

	public static int GetOperationResetInterval()
	{
		return 0;
	}

	public static int GetInstantCompleteTicketPrice()
	{
		return 0;
	}

	public static bool IsOperationDifficultyUnlocked(JMSSNJLGTFN TJOORNQEGLK)
	{
		return false;
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

	public float GetDensity()
	{
		return 0f;
	}

	public int GetEnemyLevel(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public bool IsEnemyEliteAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return false;
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

	public float GetEliteChance(int MTFHQPOPFKQ)
	{
		return 0f;
	}

	public EnemyCount GetEnemyCount(int MTFHQPOPFKQ)
	{
		return default(EnemyCount);
	}

	public float GetDensity(int MTFHQPOPFKQ)
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

	public static void SetReturnToOperationsView()
	{
	}

	public static bool ShouldReturnToOperationsView()
	{
		return false;
	}

	public static void OnEnterOperationsView()
	{
	}

	public static GambleRewardData.THHKQRSSPFN GetGambleTypeForOperationDifficulty(JMSSNJLGTFN JOLFHPIHIEJ)
	{
		return default(GambleRewardData.THHKQRSSPFN);
	}

	[CompilerGenerated]
	internal static string FGFSTRHMHNE(string[] EESTGTGKLJG, ref RMITJJOGMQG P_1)
	{
		return null;
	}

	[CompilerGenerated]
	internal static void JFHSIOLOOJQ(ref SRRORJSIFSK P_0)
	{
	}

	[CompilerGenerated]
	internal static void HIFRFOKMNQP(int TJOORNQEGLK, int[] MHNOIFFONJM, ref SRRORJSIFSK P_2)
	{
	}

	[CompilerGenerated]
	internal static bool SQSFQFORPQF(ref SRRORJSIFSK P_0)
	{
		return false;
	}

	[CompilerGenerated]
	internal static int IGRFHJGNMHM(ref int TJOORNQEGLK, int OGFKHSKTHHR, ref SRRORJSIFSK P_2)
	{
		return 0;
	}

	[CompilerGenerated]
	internal static bool IEJITTTORJJ(string KQORNQFGRMR, ref NSRSGIPFHPT P_1)
	{
		return false;
	}
}
