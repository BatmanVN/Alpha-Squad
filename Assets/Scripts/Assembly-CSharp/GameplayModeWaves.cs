using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GameplayModeWaves : HEPTMPFPKPP
{
	[Serializable]
	public class Config : GameplayModeConfig
	{
		public int[] weights;

		public int waveCount;

		public float timePerWave;

		public override string ToString()
		{
			return null;
		}
	}

	private const float MIN_SPAWN_RANGE_FROM_PLAYER = 6f;

	private const bool DEBUG = false;

	private const float FAST_FORWARD_TIME = 2f;

	private const float ENEMY_TIME = 0.2f;

	private const int MAX_ENEMIES_TO_SPAWN_WAVE = 5;

	private Config config;

	private List<EnemySoul> souls;

	private float timer;

	private int currentWave;

	private bool started;

	private float enemyTimer;

	private int enemiesLoading;

	private List<EnemySpot.SMMGLQPTJET> waveEnemies;

	private bool completed;

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

	public event Action OnWaveSpawned
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

	private void SpawnWave()
	{
	}

	private void SpawnEnemy()
	{
	}

	private EnemySpot GetRandomSpotNotNearPlayer()
	{
		return null;
	}
}
