using System;
using System.Collections.Generic;
using UnityEngine;

public class ClanMissionsGameMode : MonoBehaviour, EKFFMKLSSNN
{
	[Serializable]
	public class Instance
	{
		public int boss;

		public int floor;

		public int enemyLevel;

		public int timeLimit;

		public int worldVariation;

		public List<int> stages;

		public uint seed;

		public List<GameModifierSpecific> modifiers;

		public MinibossConfig bossConfig;
	}

	public static Instance instance;

	public static float timePassed;

	public static int startGameTs;

	private bool FHTQMGNLSSQ;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void SMJJMNSFJRE(Enemy PFIHOFSRMEH)
	{
	}

	public static float GetTimePassed()
	{
		return 0f;
	}

	public void AddTimePassed(float HNMPLNRTRHH = 60f)
	{
	}

	private static void REIGMGQJROK(Enemy PFIHOFSRMEH)
	{
	}

	public static void LoadInstance(Instance GJFPMSOEQTM)
	{
	}

	public static int GetServerSessionTimeRemaining()
	{
		return 0;
	}

	public static float GetSecondsRemaining()
	{
		return 0f;
	}

	public static string GetStringForTime(float HNMPLNRTRHH)
	{
		return null;
	}

	private void Update()
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

	public static string GetStaticAnalyticsContext()
	{
		return null;
	}
}
