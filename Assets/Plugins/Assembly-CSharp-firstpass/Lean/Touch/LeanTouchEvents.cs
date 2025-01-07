using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
	public class LeanTouchEvents : MonoBehaviour
	{
		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void OnFingerDown(LeanFinger finger)
		{
		}

		public void OnFingerSet(LeanFinger finger)
		{
		}

		public void OnFingerUp(LeanFinger finger)
		{
		}

		public void OnFingerTap(LeanFinger finger)
		{
		}

		public void OnFingerSwipe(LeanFinger finger)
		{
		}

		public void OnGesture(List<LeanFinger> fingers)
		{
		}
	}
}
