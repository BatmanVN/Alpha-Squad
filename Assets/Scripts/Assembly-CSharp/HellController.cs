using System;
using UnityEngine;

public class HellController : MonoBehaviour, EKFFMKLSSNN
{
	[Serializable]
	public class Data
	{
		public int chapter;

		public int area;

		public int level;

		public bool seenModifiers;

		public bool seenIntro;

		public bool seenEnteringHellPopup;

		public bool hellMode;
	}

	[Serializable]
	public class Config
	{
		public EpisodeController.EpisodeConfig[] chapters;
	}

	public const int AREAS_PER_CHAPTER = 4;

	public const int LEVELS_PER_AREA = 4;

	public const float ELITE_ENEMY_HEALTH_MULTIPLIER = 2f;

	public static Data data;

	public static Config config;

	public static bool staticInitialized;

	public static string KEY;

	private void Awake()
	{
	}

	public static void Clear()
	{
	}

	private void MONJFKLHSNJ()
	{
	}

	public static void DebugFinishPlaythrough()
	{
	}

	private void SKMHKLRGMTJ()
	{
	}

	private void EHOFELLPKQS()
	{
	}

	private static void NOKHPQNIOIF()
	{
	}

	public static void IncrementLevel()
	{
	}

	public static void DecrementLevel()
	{
	}

	public static void SetModifiersSeen()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static bool IsHellMode()
	{
		return false;
	}

	public static Config GetConfig()
	{
		return null;
	}

	public static Data GetData()
	{
		return null;
	}

	public static void Init()
	{
	}

	public static void SaveData()
	{
	}

	public static EpisodeController.AreaConfig GetAreaConfig()
	{
		return null;
	}

	public static EpisodeController.EpisodeConfig GetChapterConfig()
	{
		return null;
	}

	public static bool AreAllChaptersCompleted()
	{
		return false;
	}

	public static bool IsAreaCompleted(int NTRKMISJJKJ, int NLTEHQRENGT)
	{
		return false;
	}

	public static bool IsBossLevel()
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

	public float GetDensity(int MTFHQPOPFKQ)
	{
		return 0f;
	}

	public float GetEliteChance(int MTFHQPOPFKQ)
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

	public int GetEliteLevelAdd(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public string GetAnalyticsContext()
	{
		return null;
	}

	public static int GetGlobalLevelIndex()
	{
		return 0;
	}

	public static int GetChapterLevelIndex()
	{
		return 0;
	}

	public static string GetLevelTag()
	{
		return null;
	}

	public static int GetChestLevelIndex(int NTRKMISJJKJ, int NLTEHQRENGT, int IQLQQNIPTPQ)
	{
		return 0;
	}
}
