using System.Runtime.CompilerServices;
using UnityEngine;

public class StageFinishRift : StageFinish
{
	public static readonly int PARAM_OPEN;

	public GameObject effectPrefab;

	public Transform navigatablePoint;

	public Animator animator;

	public Collider trigger;

	public FinishNavigationTrigger navTrigger;

	public bool IsFinishSequenceStarted()
	{
		return false;
	}

	public override Vector3 GetEntrancePointOnNavmesh()
	{
		return default(Vector3);
	}

	public override void Close()
	{
	}

	public override void Open()
	{
	}

	protected override void TFHNMTIKERE()
	{
	}

	public override float GetFinishDelay()
	{
		return 0f;
	}

	[CompilerGenerated]
	private void GMPMIKNJHMQ()
	{
	}
}
