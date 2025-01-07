using System;
using UnityEngine;

namespace Lean.Touch
{
	[Serializable]
	public struct LeanScreenDepth
	{
		public enum ConversionType
		{
			CameraDistance = 0,
			DepthIntercept = 1,
			PhysicsRaycast = 2,
			PlaneIntercept = 3,
			PathClosest = 4
		}

		public ConversionType Conversion;

		public UnityEngine.Object Object;

		public LayerMask Layers;

		public float Distance;

		public Vector3 Convert(Vector2 screenPoint, Camera camera, GameObject gameObject = null)
		{
			return default(Vector3);
		}

		public bool TryConvert(ref Vector3 position, Vector2 screenPoint, Camera camera, GameObject gameObject = null)
		{
			return false;
		}

		public Vector3 ConvertDelta(Vector2 lastScreenPoint, Vector2 screenPoint, Camera camera, GameObject gameObject = null)
		{
			return default(Vector3);
		}
	}
}
