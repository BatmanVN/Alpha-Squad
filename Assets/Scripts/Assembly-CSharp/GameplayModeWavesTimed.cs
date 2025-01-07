using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GameplayModeWavesTimed : HEPTMPFPKPP
{
	[Serializable]
	public class Config : GameplayModeConfig
	{
		public int[] weights;

		public float timePerWave;

		public float totalTime;

		public int levelsIncreasePerWave;

		public float fastForwardTime;

		public int minWaveForElite;

		public JJHFPNTSRLT.LevelOffset[] scaling_offsets;

		public float levelScalingMultiplier;

		public int levelScalingMultiplierApply;

		public int bossStartWave;

		public int bossSpawnGap;

		public override string ToString()
		{
			return null;
		}
	}

	private const float MIN_SPAWN_RANGE_FROM_PLAYER = 6f;

	private const bool DEBUG = false;

	private const float ENEMY_TIME = 0.2f;

	private const int MAX_ENEMIES_TO_SPAWN_WAVE = 5;

	private Config config;

	private List<EnemySoul> souls;

	private int currentWave;

	private float totalTimer;

	private float timer;

	private bool started;

	private float enemyTimer;

	private int enemiesLoading;

	private List<EnemySpot.SMMGLQPTJET> waveEnemies;

	private bool completed;

	private int elitesSpawned;

	private EnemySpot.SMMGLQPTJET forcedEnemyType;

	private int forcedWeight;

	public event Action OnWaveSurvived
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

	public event Action<int> OnWaveSpawned
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

	public override HEPTMPFPKPP Setup(Stage s)
	{
		return null;
	}

	public HEPTMPFPKPP Setup(Stage s, Config _config)
	{
		return null;
	}

	private static void SetupEnemyOnSpawn(Enemy enemy)
	{
	}

	public override void SetupHeaders(bool bossHeaderAllowed = true)
	{
	}

	public override bool IsFinishAllowed()
	{
		return false;
	}

	public override bool AreObjectivesCompleted()
	{
		return false;
	}

	private int GetWeightForWave(int wave)
	{
		return 0;
	}

	public override bool SpawnInitialEnemies()
	{
		return false;
	}

	public int GetCurrentWave()
	{
		return 0;
	}

	public Config GetConfig()
	{
		return null;
	}

	public int GetTimeLeftToNextWave()
	{
		return 0;
	}

	public bool HasStarted()
	{
		return false;
	}

	public override void Update()
	{
	}

	public bool IsCompleted()
	{
		return false;
	}

	public int GetNumEnemiesOverSpawnLimit()
	{
		return 0;
	}

	public bool AreAllEnemiesDead()
	{
		return false;
	}

	private void SpawnWave()
	{
	}

	private void TrySpawnBoss()
	{
	}

	private (List<EnemySpot.OOSTRKKLKGI>, Dictionary<EnemySpot.OOSTRKKLKGI, List<EnemySpot.SMMGLQPTJET>>, int) GetPossibleEnemies()
	{
		return default((List<EnemySpot.OOSTRKKLKGI>, Dictionary<EnemySpot.OOSTRKKLKGI, List<EnemySpot.SMMGLQPTJET>>, int));
	}

	private void SpawnEnemy()
	{
	}

	private float GetLevelMultiplier()
	{
		return 0f;
	}

	private bool IsEliteAllowed()
	{
		return false;
	}

	private EnemySpot GetRandomSpotNotNearPlayer()
	{
		return null;
	}

	public float GetTotalTimePassed()
	{
		return 0f;
	}

	public void SetForcedEnemyType(EnemySpot.SMMGLQPTJET et, int fw = 1)
	{
	}
}
