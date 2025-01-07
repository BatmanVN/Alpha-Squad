using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RaidController : MonoBehaviour, EKFFMKLSSNN
{
	public enum FKKMKISLFKI
	{
		Recruit = 0,
		Mercenary = 1,
		Guerilla = 2,
		Commando = 3,
		Veteran = 4,
		Chief = 5,
		Master = 6,
		Grandmaster = 7
	}

	[Serializable]
	public class Config
	{
		[Serializable]
		public struct Difficulty
		{
			public FKKMKISLFKI type;

			public int index;

			public int[] enemyLevel;

			public int MaxLevel => 0;

			public override string ToString()
			{
				return null;
			}

			public int EOIGSKGKRFT()
			{
				return 0;
			}

			public string KKEIQMNNJTJ()
			{
				return null;
			}
		}

		public Difficulty[] difficulties;

		public int[] stages;

		public EnemyCount enemyCount;

		public int[] blockedEnemies;

		public int[] numStages;

		public int priceAutoClear;

		public int priceChestBoost;

		public int priceInstantChest;

		public int freePlayLongInterval;

		public int freePlayShortInterval;

		public int freePlayLimit;

		public int freePlayStartTimestamp;
	}

	[Serializable]
	public class Instance
	{
		public int totalStages;

		public int playedDifficultyIndex;

		public WorldData.JQNPLTQOFMJ worldType;

		public int worldVariation;

		public bool doubleBonuses;

		public bool instantChest;

		public bool bossChanceSuccessful;

		public MinibossConfig minibossConfig;
	}

	[Serializable]
	public class Data
	{
		public int selectedDifficultyIndex;

		public Instance instance;

		public List<int> recentStages;

		public int maxCompletedDifficultyIndex;

		public bool hasPlayerChangedDifficulty;

		public Utils.IntervaledLogic freePlays;
	}

	[CompilerGenerated]
	private sealed class QOLPSIRKFNK
	{
		public int enemyLevel;

		internal bool _003CGenerateMinibossConfigForLevel_003Eb__0(KeyValuePair<EnemySpot.SMMGLQPTJET, int> m)
		{
			return false;
		}
	}

	private const bool TIHGKEIIRSH = false;

	public const int RECENT_STAGES_COUNT = 20;

	public static readonly Dictionary<GTIMJFKHLHH, int> AFFIX_LEVELS;

	public static readonly Dictionary<GTIMJFKHLHH, List<EnemySpot.SMMGLQPTJET>> AFFIX_ONLY_BOSSES;

	public static readonly Dictionary<EnemySpot.SMMGLQPTJET, int> MINIBOSS_LEVELS;

	public static Config config;

	public static Data data;

	public static bool staticInitialized;

	public static int[] minibossStages;

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

	private static void MGELQQLFNNF()
	{
	}

	private static void TTILRPSQQNG()
	{
	}

	public void LevelController_OnLevelCompleted()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	public static void LoadData()
	{
	}

	public static void SaveData()
	{
	}

	public static Utils.IntervaledLogic GetFreePlay()
	{
		return null;
	}

	public static void ResetFreePlay()
	{
	}

	public static int GetSelectedDifficultyIndex()
	{
		return 0;
	}

	public static Config.Difficulty GetSelectedDifficultyConfig()
	{
		return default(Config.Difficulty);
	}

	public static Config.Difficulty GetDifficulty(int PSPJIJNTMOI)
	{
		return default(Config.Difficulty);
	}

	public static Config.Difficulty GetPlayedDifficultyConfig()
	{
		return default(Config.Difficulty);
	}

	public static bool IsDifficultyUnlocked(int PSPJIJNTMOI)
	{
		return false;
	}

	public static void GenerateInstance(bool IJPKRTSJGMF = false, bool KEESKGLOEEM = false)
	{
	}

	public static void GenerateMinibossConfig()
	{
	}

	public static MinibossConfig GenerateMinibossConfigForLevel(int HHFHLJFISQF, uint IFIKFFPOPSP = 0u, int LKGJJIOLQNK = int.MaxValue)
	{
		return null;
	}

	public static void CheckAutoSelectDifficulty()
	{
	}

	public static int GetRecommendedDifficulty()
	{
		return 0;
	}

	public static int GetMaxAvailableDifficulty()
	{
		return 0;
	}

	public static int GetMaxCompletedDifficulty()
	{
		return 0;
	}

	public static bool IsDifficultyTypeUnlocked(FKKMKISLFKI EOOEIROQJOE)
	{
		return false;
	}

	public static string GetDifficultyUnlockRequirementString(FKKMKISLFKI EOOEIROQJOE)
	{
		return null;
	}

	public static List<int> GetAllowedEnemyTypes()
	{
		return null;
	}

	public static void AddToRecentStages(int SINKIFTPIER)
	{
	}

	public static void AutoCompleted()
	{
	}

	public static float GetBonusMultiplierCash(int LFGKQEJHKFO, bool PRKGEIOQFGM = false)
	{
		return 0f;
	}

	public static float GetBonusMultiplierGuns(int LFGKQEJHKFO, bool PRKGEIOQFGM = false)
	{
		return 0f;
	}

	public static float GetCurrentBonusMultiplierCash()
	{
		return 0f;
	}

	public static float GetCurrentBonusMultiplierGuns()
	{
		return 0f;
	}

	public static bool IsBonusLootActive()
	{
		return false;
	}

	public static bool IsInstantChestActive()
	{
		return false;
	}

	public static bool HaveMinibossConfig()
	{
		return false;
	}

	public static DropController.DropsCollection GetAutoClearLootForSelectedDifficulty(bool IJPKRTSJGMF = false, bool KEESKGLOEEM = false)
	{
		return null;
	}

	public static DropController.DropsCollection GetAutoClearLootForDifficulty(Config.Difficulty IPMQOGFTQMG, bool IJPKRTSJGMF = false, bool KEESKGLOEEM = false)
	{
		return null;
	}

	public static List<JJHFPNTSRLT.ChestQualityNumber> GetChestWeights(bool IJPKRTSJGMF = false)
	{
		return null;
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

	public int GetEliteLevelAdd(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public string GetAnalyticsContext()
	{
		return null;
	}
}
