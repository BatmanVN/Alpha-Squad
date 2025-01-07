using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class StageFinishLift : StageFinish
{
	[CompilerGenerated]
	private sealed class SJJFTENFFTT
	{
		public StageFinishLift _003C_003E4__this;

		public Material mat;

		internal void _003COpen_003Eb__0(float f)
		{
		}
	}

	[CompilerGenerated]
	private sealed class JFEQIFRGJGJ
	{
		public StageFinishLift _003C_003E4__this;

		public float arrowBig;

		public float arrowSmall;

		internal void _003COpenArrowAnimation_003Eb__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class IMLOSFOKQOS
	{
		public float t;

		public JFEQIFRGJGJ CS_0024_003C_003E8__locals1;

		internal void _003COpenArrowAnimation_003Eb__5()
		{
		}

		internal void _003COpenArrowAnimation_003Eb__6()
		{
		}

		internal void _003COpenArrowAnimation_003Eb__7()
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
	private RangeIndicator rangeIndicator;

	[SerializeField]
	private Transform arrow0;

	[SerializeField]
	private Transform arrow1;

	[SerializeField]
	private Transform arrow2;

	[SerializeField]
	private Transform liftEntrancePoint;

	public SoundEffect elevatorReady;

	private Sequence QRJRKHJOQGP;

	private Sequence ISSLIHISQIT;

	public override void Setup(Stage GRPGSQEHKSE)
	{
	}

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

	private void HLNPTOJGROM()
	{
	}

	private void TRRLKEKIHKO()
	{
	}

	protected override void TFHNMTIKERE()
	{
	}
}
