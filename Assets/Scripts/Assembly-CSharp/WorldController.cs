using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class WorldController : MonoBehaviour, EKFFMKLSSNN
{
	[Serializable]
	public class WorldProgress
	{
		public WorldData.JQNPLTQOFMJ type;

		public int guaranteedWeaponsReceived;

		public bool newlyUnlocked;

		public int area;

		public int level;

		public List<int> completedStages;

		public bool completed;

		[Obsolete]
		public List<ChallengeData> challenges;

		public void IPLJPPFFMER()
		{
		}

		public void LQSMOQFLORP()
		{
		}

		public bool OSPLNFSOJQO(int NERGMFPHLIM)
		{
			return false;
		}
	}

	[Serializable]
	[Obsolete]
	public class ChallengeData
	{
		public int id;

		public int maxLevelCompleted;

		public List<int> completedStages;

		public bool completed;

		public WorldData.JQNPLTQOFMJ type;

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class Data
	{
		public WorldData.JQNPLTQOFMJ selectedWorld;

		public List<WorldProgress> progress;

		public List<int> playthroughStages;
	}

	[Serializable]
	public class Config
	{
		public WorldConfig[] worlds;
	}

	[Serializable]
	public class WorldConfig
	{
		[Serializable]
		public class LevelConfig
		{
			public int stageCount;

			public int[] stages;

			public int[] enemyLevel;

			public EnemyCount[] enemyCounts;

			public int[] enemyTypes;

			public int[] cantBeElite;

			public float[] eliteChance;

			public float[] density;

			public int eliteLevelAdd;

			public bool PGGTFMMOPQT()
			{
				return false;
			}
		}

		public WorldData.JQNPLTQOFMJ type;

		public EpisodeController.AreaConfig[] areas;

		public JPHMLSJQLNL[] guaranteedWeapons;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct GMQIOGLHKMJ
	{
		public WorldConfig cfg;
	}

	[CompilerGenerated]
	private sealed class TJNFRPRHNSM
	{
		public WorldData.JQNPLTQOFMJ type;

		internal bool _003CGetWorldConfig_003Eb__0(WorldConfig w)
		{
			return false;
		}
	}

	public const int LEVELS_PER_AREA = 6;

	public static Data data;

	public static Config config;

	public static bool staticInitialized;

	public static int totalLevelCountCache;

	public static string KEY;

	public static bool ENIJHLKFMHM
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void MONJFKLHSNJ()
	{
	}

	private bool NOKHPQNIOIF()
	{
		return false;
	}

	private void FKMKSLEEJRN()
	{
	}

	public void DebugFinishPlaythrough()
	{
	}

	public void DebugMessUpAreaProgress()
	{
	}

	public void DebugMessUpLevelProgress()
	{
	}

	public void DebugCompleteWorld()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static Config GetConfig()
	{
		return null;
	}

	public static Data GetData()
	{
		return null;
	}

	private static void MLNESSGJRME()
	{
	}

	public static void Clear()
	{
	}

	public static void UpdateFor116()
	{
	}

	private static void GESNOGJHPGT()
	{
	}

	private static void OTQPEHOFTON()
	{
	}

	public static void SelectFurthestNotCompletedWorld()
	{
	}

	private static void SHHHTPOEOHS()
	{
	}

	private static void TTPJJIFMKGI()
	{
	}

	public static HashSet<EnemySpot.SMMGLQPTJET> GetAllEnemyTypesFromWorld(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
		return null;
	}

	public static void SaveData()
	{
	}

	public static bool IsWorldCompleted()
	{
		return false;
	}

	public static bool IsBossLevel()
	{
		return false;
	}

	public static int[] GetCurrentLevelStages()
	{
		return null;
	}

	public static WorldConfig GetWorldConfig(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
		return null;
	}

	public static WorldProgress GetWorldProgress(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
		return null;
	}

	public static string GetWorldName(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
		return null;
	}

	public static int GetWorldConfigIndex(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
		return 0;
	}

	public static bool DidReceiveAllGuaranteedDropsFromSelectedWorld()
	{
		return false;
	}

	public static JPHMLSJQLNL GetNextGuaranteedWeaponDropFromSelectedWorld()
	{
		return default(JPHMLSJQLNL);
	}

	public static bool IsWorldCompleted(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
		return false;
	}

	public static bool IsWorldUnlocked(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
		return false;
	}

	public static WorldData.JQNPLTQOFMJ GetNextWorld(WorldData.JQNPLTQOFMJ QHTEKKRGIFS)
	{
		return default(WorldData.JQNPLTQOFMJ);
	}

	public static HashSet<WorldData.JQNPLTQOFMJ> GetCompletedWorlds()
	{
		return null;
	}

	public static bool ExistsNextWorld(WorldData.JQNPLTQOFMJ QHTEKKRGIFS)
	{
		return false;
	}

	public static int GetTotalLevelCount()
	{
		return 0;
	}

	public static bool ShouldUseFixedGlobalLevelCount()
	{
		return false;
	}

	public MinibossConfig GetMinibossConfig()
	{
		return null;
	}

	public static int GetCurrentGlobalLevelIndex()
	{
		return 0;
	}

	public static int GetNumStagesInCurrentLevel()
	{
		return 0;
	}

	public static WorldData.JQNPLTQOFMJ GetSelectedWorldType()
	{
		return default(WorldData.JQNPLTQOFMJ);
	}

	public static WorldData GetSelectedWorldData()
	{
		return null;
	}

	public static WorldProgress GetSelectedWorldProgress()
	{
		return null;
	}

	public static int GetSelectedLevel()
	{
		return 0;
	}

	public static WorldConfig GetSelectedWorldConfig()
	{
		return null;
	}

	public static int GetLevelsInSelectedArea()
	{
		return 0;
	}

	public static EpisodeController.AreaConfig GetSelectedAreaConfig()
	{
		return null;
	}

	public static void AddToCompletedStages(int SINKIFTPIER)
	{
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

	public int GetEnemyLevel(int GQTJNOENHFJ)
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

	public static void GetAreaAndLevelFromOldLevel(int IOQHNLJNMJL, WorldData.JQNPLTQOFMJ THJGPJQJIRI, out int NLTEHQRENGT, out int IQLQQNIPTPQ)
	{
		NLTEHQRENGT = default(int);
		IQLQQNIPTPQ = default(int);
	}

	[Obsolete]
	public static ChallengeData GetChallengeData(WorldData.JQNPLTQOFMJ EOOEIROQJOE, int JJGRPGFRSOK = 0)
	{
		return null;
	}

	[CompilerGenerated]
	internal static int IRPPJOJOTLS(int HJITGJOGJJQ, ref GMQIOGLHKMJ P_1)
	{
		return 0;
	}
}
