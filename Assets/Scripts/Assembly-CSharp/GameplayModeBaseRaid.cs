using UnityEngine;

public class GameplayModeBaseRaid : HEPTMPFPKPP
{
	private const float BOSS_DISAPPEAR_TIME = 15f;

	private Miniboss miniboss;

	private float bossAppearTimer;

	private bool disappearQueued;

	private GameObject bossSpotAppearFx;

	public override HEPTMPFPKPP Setup(Stage s)
	{
		return null;
	}

	public override void OnStageDestroy()
	{
	}

	private void LevelController_OnStageObjectivesCompleted()
	{
	}

	private void LevelController_OnStageLoadingFinished()
	{
	}

	private void Miniboss_OnBreakpoint(int breakpoint)
	{
	}

	private void DisappearBoss()
	{
	}

	public float GetBossAppearTimer()
	{
		return 0f;
	}

	private void AppearBoss()
	{
	}

	private void EnemyDied(LQJTRNFQISM hit, Enemy enemy)
	{
	}

	public override void Update()
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

	public override bool SpawnInitialEnemies()
	{
		return false;
	}

	public override bool MinibossAutoTargetPlayer()
	{
		return false;
	}
}
