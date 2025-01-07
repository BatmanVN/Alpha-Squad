using System;

public class GameplayModeKillEnemies : HEPTMPFPKPP
{
	[Serializable]
	public class Config : GameplayModeConfig
	{
		public bool spawnEnemiesWithMiniboss;

		public bool minibossAutoTargetPlayer;

		public override string ToString()
		{
			return null;
		}
	}

	private Config config;

	public override HEPTMPFPKPP Setup(Stage s)
	{
		return null;
	}

	public HEPTMPFPKPP Setup(Stage s, Config c)
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

	public override bool SpawnInitialEnemies()
	{
		return false;
	}

	public override bool MinibossAutoTargetPlayer()
	{
		return false;
	}
}
