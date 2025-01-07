using System;
using UnityEngine;
using UnityEngine.Events;

namespace Lean.Touch
{
	public class LeanFingerSwipe : MonoBehaviour
	{
		public enum ClampType
		{
			None = 0,
			Normalize = 1,
			Direction4 = 2,
			ScaledDelta = 3
		}

		[Serializable]
		public class FingerEvent : UnityEvent<LeanFinger>
		{
		}

		[Serializable]
		public class Vector2Event : UnityEvent<Vector2>
		{
		}

		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public LeanSelectable RequiredSelectable;

		public bool CheckAngle;

		public float Angle;

		public float AngleThreshold;

		public ClampType Clamp;

		public float Multiplier;

		public FingerEvent OnSwipe;

		public Vector2Event OnSwipeDelta;

		protected bool CheckSwipe(LeanFinger finger, Vector2 swipeDelta)
		{
			return false;
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void FingerSwipe(LeanFinger finger)
		{
		}
	}
}
