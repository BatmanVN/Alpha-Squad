using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StageStartLift : StageStart
{
	[CompilerGenerated]
	private sealed class QKGSSKERPHK
	{
		public HEPTMPFPKPP gameplayMode;

		public Action reenableInput;

		public StageStartLift _003C_003E4__this;

		internal void _003CPlayMinibossIntro_003Eb__1()
		{
		}

		internal void _003CPlayMinibossIntro_003Eb__4()
		{
		}

		internal void _003CPlayMinibossIntro_003Eb__6()
		{
		}
	}

	[CompilerGenerated]
	private sealed class IMHQRLFEJER
	{
		public AnimationController animController;

		internal void _003CPlayMinibossIntro_003Eb__5()
		{
		}
	}

	[CompilerGenerated]
	private sealed class GPMREKIFPJI
	{
		public AnimationController playerAnim;

		internal void _003CStartSequenceDone_003Eb__0()
		{
		}
	}

	public Action OnLiftArrived;

	[SerializeField]
	private Transform spawnPoint;

	[SerializeField]
	private GameObject grassView;

	[SerializeField]
	private GameObject liftView;

	[SerializeField]
	protected Animator liftAnimator;

	[SerializeField]
	protected Transform playerLiftLocation;

	[SerializeField]
	private Transform playerMover;

	[SerializeField]
	private Transform playerSpawnStep;

	private const float GIHIMTQGOJS = 1.45f;

	public override void Setup(JQMLNMRIGFN LOGFMFHFPEP, Stage GRPGSQEHKSE, Player SKOJGTGOPIF)
	{
	}

	private void FQGORERKGIO()
	{
	}

	public bool IsLiftActive()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	private void OIHSHQJTOMP()
	{
	}

	public override void BeginSequence()
	{
	}

	public Transform GetSpawnPoint()
	{
		return null;
	}

	private void IGTOPFTFOMP()
	{
	}

	protected virtual void SGMFRNTQOPO()
	{
	}

	public void LiftArrived()
	{
	}

	public void LiftExited()
	{
	}

	private bool KHJEKMGEOSP()
	{
		return false;
	}

	protected virtual void PMFSTOQLINN()
	{
	}

	private void QPIQSNHPGPN(bool SMJFTKGRFLJ)
	{
	}

	public void PlayMinibossIntro()
	{
	}

	protected override void KROLPRIGJJQ()
	{
	}

	[CompilerGenerated]
	private void PFREPLQRQEH()
	{
	}

	[CompilerGenerated]
	private void QFMTGRJGOJT()
	{
	}
}
