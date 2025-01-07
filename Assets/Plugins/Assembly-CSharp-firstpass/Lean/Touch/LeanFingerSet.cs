using System;
using UnityEngine;
using UnityEngine.Events;

namespace Lean.Touch
{
	public class LeanFingerSet : MonoBehaviour
	{
		public enum DeltaCoordinatesType
		{
			Screen = 0,
			Scaled = 1
		}

		[Serializable]
		public class LeanFingerEvent : UnityEvent<LeanFinger>
		{
		}

		[Serializable]
		public class Vector2Event : UnityEvent<Vector2>
		{
		}

		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public bool IgnoreIfStatic;

		public LeanSelectable RequiredSelectable;

		public DeltaCoordinatesType DeltaCoordinates;

		public LeanFingerEvent OnSet;

		public Vector2Event OnSetDelta;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void FingerSet(LeanFinger finger)
		{
		}
	}
}
