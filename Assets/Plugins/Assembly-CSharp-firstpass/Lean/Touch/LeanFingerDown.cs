using System;
using UnityEngine;
using UnityEngine.Events;

namespace Lean.Touch
{
	public class LeanFingerDown : MonoBehaviour
	{
		[Serializable]
		public class LeanFingerEvent : UnityEvent<LeanFinger>
		{
		}

		public bool IgnoreStartedOverGui;

		public LeanSelectable RequiredSelectable;

		public LeanFingerEvent OnDown;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void FingerDown(LeanFinger finger)
		{
		}
	}
}
