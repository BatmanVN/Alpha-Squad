using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class RiftsPanel : UIPanel
{
	[SerializeField]
	private ScrollRectStepped mainScroll;

	[SerializeField]
	private List<GameObject> tabs;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private RiftsPanelLeague panelLeague;

	[SerializeField]
	private GameObject snapshotSpinner;

	[SerializeField]
	private GameObject leaderboardsMainBlock;

	[SerializeField]
	private GameObject leaderboardsPlacementBlock;

	[SerializeField]
	private UITextTimer leaderboardsPlacementTimer;

	private List<RiftsPanelView> PPJOLELOQOG;

	public static event Action TNQSFMMGRKF
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

	protected override void MGKPMPHSLFR()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnExitButton()
	{
	}

	public void OnAddWatchButton()
	{
	}

	public void OnTabClicked(int OIGIHGHENJK)
	{
	}

	public void StartRift(int EERRGHKNKNK)
	{
	}

	public void TryShowSnapshotForOwnerId(string IPEOLHNKPHM, long PMNGMSRTHLP, string OEHLJHJTMTQ)
	{
	}

	public static Task<bool> StaticTryShowSnapshotForOwnerId(string IPEOLHNKPHM, long PMNGMSRTHLP, string OEHLJHJTMTQ)
	{
		return null;
	}

	public void SetInputBlocked(bool ELEIPINNGGJ)
	{
	}

	public void OnScrollFinished(int FIPHTRRRPET)
	{
	}

	public void OnScrollValueChanged(Vector2 RRPSNPOTQNT)
	{
	}

	private void JITNJSQRJSO(int FIPHTRRRPET)
	{
	}

	public T GetView<T>() where T : RiftsPanelView
	{
		return null;
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnPlacementTimerUp()
	{
	}
}
