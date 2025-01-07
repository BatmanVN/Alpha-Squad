using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
	public class LeanPath : MonoBehaviour
	{
		public List<Vector3> Points;

		public bool Loop;

		public Space Space;

		public int Smoothing;

		public int PointCount => 0;

		public int GetPointCount(int smoothing = 1)
		{
			return 0;
		}

		public Vector3 GetSmoothedPoint(float index)
		{
			return default(Vector3);
		}

		public Vector3 GetPoint(int index, int smoothing = 1)
		{
			return default(Vector3);
		}

		private Vector3 GetPointRaw(int index, int count)
		{
			return default(Vector3);
		}

		public void SetLine(Vector3 a, Vector3 b)
		{
		}

		public bool TryGetClosest(Vector3 position, ref Vector3 closestPoint, int smoothing = 1)
		{
			return false;
		}

		public bool TryGetClosest(Ray ray, ref Vector3 closestPoint, int smoothing = 1)
		{
			return false;
		}

		private Vector3 GetClosestPoint(Vector3 position, Vector3 origin, Vector3 direction)
		{
			return default(Vector3);
		}

		private Vector3 GetClosestPoint(Ray ray, Vector3 origin, Vector3 direction)
		{
			return default(Vector3);
		}

		private float GetClosestDistance(Ray ray, Vector3 point)
		{
			return 0f;
		}

		private int Mod(int a, int b)
		{
			return 0;
		}

		private float CubicInterpolate(float a, float b, float c, float d, float t)
		{
			return 0f;
		}
	}
}
