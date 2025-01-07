using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Lean.Touch
{
	public class LeanFingerHeld : MonoBehaviour
	{
		[Serializable]
		public class FingerEvent : UnityEvent<LeanFinger>
		{
		}

		[Serializable]
		public class Link
		{
			public LeanFinger Finger;

			public bool LastSet;

			public Vector2 TotalScaledDelta;
		}

		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public LeanSelectable RequiredSelectable;

		public float MinimumAge;

		public float MaximumMovement;

		public FingerEvent OnHeldDown;

		public FingerEvent OnHeldSet;

		public FingerEvent OnHeldUp;

		private List<Link> links;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnFingerDown(LeanFinger finger)
		{
		}

		private void OnFingerSet(LeanFinger finger)
		{
		}

		private void OnFingerUp(LeanFinger finger)
		{
		}

		private Link FindLink(LeanFinger finger, bool createIfNull)
		{
			return null;
		}
	}
}
