using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class BoardToken : MonoBehaviour
{
	[Serializable]
	public class StepAnimation
	{
		public float tokenJumpHeight;

		public AnimationCurve tokenYCurve;

		public AnimationCurve tokenEaseCurve;

		public AnimationCurve tokenScaleXCurve;

		public AnimationCurve tokenScaleYCurve;

		public AnimationCurve tokenScaleZCurve;

		public GameObject particleOnTile;

		public float minusTimeForParticle;

		public float tokenMoveDuration;
	}

	[CompilerGenerated]
	private sealed class IMKNQEGNKIG
	{
		public BoardToken _003C_003E4__this;

		public StepAnimation animator;

		internal void _003CCreateScale_003Eb__0(float f)
		{
		}
	}

	public StepAnimation step;

	public StepAnimation finalStep;

	public Tween CreateMove(Vector3 JSMLIQPPPQS, bool SPELFKQJMIJ)
	{
		return null;
	}

	public Tween CreateJump(bool SPELFKQJMIJ)
	{
		return null;
	}

	public Tween CreateScale(bool SPELFKQJMIJ)
	{
		return null;
	}

	private StepAnimation FJOEREHFNHK(bool SPELFKQJMIJ)
	{
		return null;
	}

	public float TimeForParticle(bool SPELFKQJMIJ)
	{
		return 0f;
	}

	public GameObject GetStepParticle(bool SPELFKQJMIJ)
	{
		return null;
	}
}
