using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class EpisodeController : MonoBehaviour, EKFFMKLSSNN
{
	[Serializable]
	public class Data
	{
		public int episode;

		public int area;

		public int level;

		public List<int> completedStages;

		public List<int> playthroughStages;
	}

	[Serializable]
	public class Config
	{
		public EpisodeConfig[] episodes;
	}

	[Serializable]
	public class EpisodeConfig
	{
		public AreaConfig[] areas;
	}

	[Serializable]
	public class AreaConfig
	{
		public WorldData.JQNPLTQOFMJ type;

		public int variation;

		public WorldController.WorldConfig.LevelConfig baseConfig;

		public WorldController.WorldConfig.LevelConfig[] levels;

		public MinibossConfig miniboss;

		public List<GameModifierSpecificTiered> modifiers;

		public List<GameModifierSpecificTiered> playerModifiers;

		public bool LEQKHJOJKJQ()
		{
			return false;
		}

		public float[] KMFRLRSLKKQ(int IQLQQNIPTPQ)
		{
			return null;
		}

		public float LMIIOOPTGIL(int IQLQQNIPTPQ, int MTFHQPOPFKQ)
		{
			return 0f;
		}

		public int[] SEOPTFJEFTN(int IQLQQNIPTPQ)
		{
			return null;
		}

		public int[] NIOOPEOMQTM(int IQLQQNIPTPQ)
		{
			return null;
		}

		public bool LSIJFQEKTTL(int IQLQQNIPTPQ)
		{
			return false;
		}

		public bool RFSSOSJQMFJ(int IQLQQNIPTPQ)
		{
			return false;
		}

		public int[] MIFJPFNRIIK(int IQLQQNIPTPQ)
		{
			return null;
		}

		public float[] QHTOKPKJHJL(int IQLQQNIPTPQ)
		{
			return null;
		}

		public float OFOGTSIOGPS(int IQLQQNIPTPQ, int MTFHQPOPFKQ)
		{
			return 0f;
		}

		public int LKQTRGQHTSO(int IQLQQNIPTPQ)
		{
			return 0;
		}

		public EnemyCount[] RHHJSIMSKPS(int IQLQQNIPTPQ)
		{
			return null;
		}

		public EnemyCount SIHFOJOTNIM(int IQLQQNIPTPQ, int MTFHQPOPFKQ)
		{
			return default(EnemyCount);
		}

		public bool LLKKEMEOREI(int IQLQQNIPTPQ)
		{
			return false;
		}

		public int QEGNOPHPQKE(int IQLQQNIPTPQ)
		{
			return 0;
		}

		public int GNLRNOENPIQ(int IQLQQNIPTPQ)
		{
			return 0;
		}

		public int EKJFIQSNFEM(int IQLQQNIPTPQ)
		{
			return 0;
		}

		public int LMJSROSIFEK(int IQLQQNIPTPQ, int MTFHQPOPFKQ)
		{
			return 0;
		}

		public int QFPJFEJNTGS(int IQLQQNIPTPQ)
		{
			return 0;
		}

		public bool PGGTFMMOPQT(int IQLQQNIPTPQ)
		{
			return false;
		}

		public float KRJTEGEMGIR(int IQLQQNIPTPQ, int MTFHQPOPFKQ)
		{
			return 0f;
		}

		public float NQHGNFOTPOE(int IQLQQNIPTPQ, int MTFHQPOPFKQ)
		{
			return 0f;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct NRSPSHSGOGT
	{
		public EpisodeConfig ecfg;
	}

	public const int AREAS_PER_EPISODE = 3;

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

	public static void DebugCompleteWorld()
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

	public static void Init()
	{
	}

	public static void SaveData()
	{
	}

	public static AreaConfig GetAreaConfig()
	{
		return null;
	}

	public static EpisodeConfig GetEpisodeConfig()
	{
		return null;
	}

	public static bool AreAllEpisodesCompleted()
	{
		return false;
	}

	public static bool IsAreaCompleted(int JLRNQPMPGFN, int NLTEHQRENGT)
	{
		return false;
	}

	public static bool IsLevelCompleted(int JLRNQPMPGFN, int NLTEHQRENGT, int IQLQQNIPTPQ)
	{
		return false;
	}

	public static HashSet<WorldData.JQNPLTQOFMJ> GetCompletedWorlds()
	{
		return null;
	}

	public static HashSet<EnemySpot.SMMGLQPTJET> GetAllEnemyTypesFromArea(int JLRNQPMPGFN, int NLTEHQRENGT)
	{
		return null;
	}

	public static void AddToCompletedStages(int SINKIFTPIER)
	{
	}

	public static int GetGlobalLevelIndex()
	{
		return 0;
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

	[CompilerGenerated]
	internal static int QPHFEOQSMQN(int HJITGJOGJJQ, ref NRSPSHSGOGT P_1)
	{
		return 0;
	}
}
