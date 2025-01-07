using UnityEngine;

namespace Lean.Touch
{
	public class LeanPlane : MonoBehaviour
	{
		public bool ClampX;

		public float MinX;

		public float MaxX;

		public bool ClampY;

		public float MinY;

		public float MaxY;

		public float SnapX;

		public float SnapY;

		public Vector3 GetClosest(Vector3 position, float offset = 0f)
		{
			return default(Vector3);
		}

		public bool TryRaycast(Ray ray, ref Vector3 hit, float offset = 0f)
		{
			return false;
		}

		public Vector3 GetClosest(Ray ray)
		{
			return default(Vector3);
		}
	}
}
