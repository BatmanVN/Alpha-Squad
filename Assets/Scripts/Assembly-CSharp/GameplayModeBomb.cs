using System;
using System.Collections.Generic;

public class GameplayModeBomb : HEPTMPFPKPP
{
	[Serializable]
	public class Config : GameplayModeConfig
	{
		public int explosion_time;

		public float segment_defuse_time;

		public int segment_count;

		public int max_bombs;

		public override string ToString()
		{
			return null;
		}
	}

	private Config config;

	private List<Bomb> bombs;

	private float bombTimer;

	private bool started;

	protected bool exploded;

	public override HEPTMPFPKPP Setup(Stage s)
	{
		return null;
	}

	public override void SetupHeaders(bool bossHeaderAllowed = true)
	{
	}

	public HEPTMPFPKPP Setup(Stage s, Config c)
	{
		return null;
	}

	public override bool IsFinishAllowed()
	{
		return false;
	}

	public override bool AreObjectivesCompleted()
	{
		return false;
	}

	public bool AreAllBombsDefused()
	{
		return false;
	}

	private int GetExplosionTime()
	{
		return 0;
	}

	public override void Update()
	{
	}

	public float GetTimeLeft()
	{
		return 0f;
	}

	public float GetTimeProgressLeft()
	{
		return 0f;
	}

	public bool IsAnySegmentDefused()
	{
		return false;
	}

	public bool IsExploded()
	{
		return false;
	}

	private void OnTimeRanOut()
	{
	}

	public int GetNumNotAlertedBombs()
	{
		return 0;
	}

	private void AddRagdollForceFromBomb(Actor actor, Bomb bomb)
	{
	}

	public void SpawnBombs()
	{
	}
}
