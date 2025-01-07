using System;
using UnityEngine;
using UnityEngine.Events;

namespace Lean.Touch
{
	public class LeanFingerTap : MonoBehaviour
	{
		[Serializable]
		public class LeanFingerEvent : UnityEvent<LeanFinger>
		{
		}

		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public int RequiredTapCount;

		public int RequiredTapInterval;

		public LeanSelectable RequiredSelectable;

		public LeanFingerEvent OnTap;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void FingerTap(LeanFinger finger)
		{
		}
	}
}
