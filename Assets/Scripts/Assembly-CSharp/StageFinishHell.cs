using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class StageFinishHell : StageFinish
{
	[CompilerGenerated]
	private sealed class EMHKHLLLKPT
	{
		public StageFinishHell _003C_003E4__this;

		public Material mat;

		internal void _003COpen_003Eb__0(float f)
		{
		}
	}

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private Transform playerPosition;

	[SerializeField]
	private GameObject openEffect;

	[SerializeField]
	private GameObject closeEffect;

	[SerializeField]
	private RangeIndicator rangeIndicator;

	[SerializeField]
	private Transform entrancePoint;

	public SoundEffect elevatorReady;

	private Sequence ISSLIHISQIT;

	private bool GIGHGFKNSOF;

	public override Vector3 GetEntrancePointOnNavmesh()
	{
		return default(Vector3);
	}

	public override Transform GetPlayerPosition()
	{
		return null;
	}

	public override float GetFinishDelay()
	{
		return 0f;
	}

	public override void Open()
	{
	}

	public override void Close()
	{
	}

	protected override void TFHNMTIKERE()
	{
	}

	public bool IsPlayerInside()
	{
		return false;
	}
}
