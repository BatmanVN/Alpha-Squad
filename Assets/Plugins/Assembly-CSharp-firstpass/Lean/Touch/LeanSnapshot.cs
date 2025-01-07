using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
	public class LeanSnapshot
	{
		public float Age;

		public Vector2 ScreenPosition;

		public static List<LeanSnapshot> InactiveSnapshots;

		public Vector3 GetWorldPosition(float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public static LeanSnapshot Pop()
		{
			return null;
		}

		public static bool TryGetScreenPosition(List<LeanSnapshot> snapshots, float targetAge, ref Vector2 screenPosition)
		{
			return false;
		}

		public static bool TryGetSnapshot(List<LeanSnapshot> snapshots, int index, ref float age, ref Vector2 screenPosition)
		{
			return false;
		}

		public static int GetLowerIndex(List<LeanSnapshot> snapshots, float targetAge)
		{
			return 0;
		}
	}
}
