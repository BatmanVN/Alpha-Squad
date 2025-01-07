using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Lean.Touch
{
	public class LeanFingerTrail : MonoBehaviour
	{
		[Serializable]
		public class LeanFingerEvent : UnityEvent<LeanFinger>
		{
		}

		[Serializable]
		public class Link
		{
			public LeanFinger Finger;

			public LineRenderer Line;
		}

		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public LeanSelectable RequiredSelectable;

		public LineRenderer LinePrefab;

		public LeanScreenDepth ScreenDepth;

		public int MaxLines;

		public Camera Camera;

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

		protected virtual void WritePositions(LineRenderer line, LeanFinger finger)
		{
		}

		private void FingerSet(LeanFinger finger)
		{
		}

		private void FingerUp(LeanFinger finger)
		{
		}

		protected virtual void LinkFingerUp(Link link)
		{
		}

		private Link FindLink(LeanFinger finger, bool createIfNull)
		{
			return null;
		}
	}
}
