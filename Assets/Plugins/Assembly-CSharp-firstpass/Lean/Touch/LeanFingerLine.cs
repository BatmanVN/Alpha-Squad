using System;
using UnityEngine;
using UnityEngine.Events;

namespace Lean.Touch
{
	public class LeanFingerLine : LeanFingerTrail
	{
		[Serializable]
		public class Vector3Vector3Event : UnityEvent<Vector3, Vector3>
		{
		}

		[Serializable]
		public class Vector3Event : UnityEvent<Vector3>
		{
		}

		public float ThicknessScale;

		public float LengthMin;

		public float LengthMax;

		public Transform Target;

		public Vector3Vector3Event OnReleasedFromTo;

		public Vector3Event OnReleasedTo;

		protected override void LinkFingerUp(Link link)
		{
		}

		protected override void WritePositions(LineRenderer line, LeanFinger finger)
		{
		}

		private Vector3 GetStartPoint(LeanFinger finger)
		{
			return default(Vector3);
		}

		private Vector3 GetEndPoint(LeanFinger finger, Vector3 start)
		{
			return default(Vector3);
		}
	}
}
