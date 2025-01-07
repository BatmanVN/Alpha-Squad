using System.Runtime.CompilerServices;

public abstract class HEPTMPFPKPP
{
	[CompilerGenerated]
	private sealed class SQIGOSEKFJO
	{
		public Quest questTimer;

		internal int _003CSetupHeaders_003Eb__3()
		{
			return 0;
		}

		internal bool _003CSetupHeaders_003Eb__4()
		{
			return false;
		}
	}

	protected Stage ORNGIJSFQQQ;

	protected ERTTJTQLQJE EOOEIROQJOE;

	public virtual HEPTMPFPKPP Setup(Stage MHNOIFFONJM)
	{
		return null;
	}

	public virtual void SetupHeaders(bool RGNRHMEQKHF = true)
	{
	}

	public virtual void OnStageDestroy()
	{
	}

	public abstract bool IsFinishAllowed();

	public abstract bool AreObjectivesCompleted();

	public virtual bool SpawnInitialEnemies()
	{
		return false;
	}

	public virtual bool FLSFPJOJPHL()
	{
		return false;
	}

	public virtual bool MinibossAutoTargetPlayer()
	{
		return false;
	}

	public virtual void Update()
	{
	}

	public void TFGGTOKQIGR(bool SMJFTKGRFLJ)
	{
	}
}
