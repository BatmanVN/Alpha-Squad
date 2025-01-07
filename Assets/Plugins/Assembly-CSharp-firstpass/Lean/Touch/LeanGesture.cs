using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
	public static class LeanGesture
	{
		public static Vector2 GetScreenCenter()
		{
			return default(Vector2);
		}

		public static Vector2 GetScreenCenter(List<LeanFinger> fingers)
		{
			return default(Vector2);
		}

		public static bool TryGetScreenCenter(List<LeanFinger> fingers, ref Vector2 center)
		{
			return false;
		}

		public static Vector2 GetLastScreenCenter()
		{
			return default(Vector2);
		}

		public static Vector2 GetLastScreenCenter(List<LeanFinger> fingers)
		{
			return default(Vector2);
		}

		public static bool TryGetLastScreenCenter(List<LeanFinger> fingers, ref Vector2 center)
		{
			return false;
		}

		public static Vector2 GetStartScreenCenter()
		{
			return default(Vector2);
		}

		public static Vector2 GetStartScreenCenter(List<LeanFinger> fingers)
		{
			return default(Vector2);
		}

		public static bool TryGetStartScreenCenter(List<LeanFinger> fingers, ref Vector2 center)
		{
			return false;
		}

		public static Vector2 GetScreenDelta()
		{
			return default(Vector2);
		}

		public static Vector2 GetScreenDelta(List<LeanFinger> fingers)
		{
			return default(Vector2);
		}

		public static bool TryGetScreenDelta(List<LeanFinger> fingers, ref Vector2 delta)
		{
			return false;
		}

		public static Vector2 GetScaledDelta()
		{
			return default(Vector2);
		}

		public static Vector2 GetScaledDelta(List<LeanFinger> fingers)
		{
			return default(Vector2);
		}

		public static bool TryGetScaledDelta(List<LeanFinger> fingers, ref Vector2 delta)
		{
			return false;
		}

		public static Vector3 GetWorldDelta(float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public static Vector3 GetWorldDelta(List<LeanFinger> fingers, float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public static bool TryGetWorldDelta(List<LeanFinger> fingers, float distance, ref Vector3 delta, Camera camera = null)
		{
			return false;
		}

		public static float GetScreenDistance()
		{
			return 0f;
		}

		public static float GetScreenDistance(List<LeanFinger> fingers)
		{
			return 0f;
		}

		public static float GetScreenDistance(List<LeanFinger> fingers, Vector2 center)
		{
			return 0f;
		}

		public static bool TryGetScreenDistance(List<LeanFinger> fingers, Vector2 center, ref float distance)
		{
			return false;
		}

		public static float GetScaledDistance()
		{
			return 0f;
		}

		public static float GetScaledDistance(List<LeanFinger> fingers)
		{
			return 0f;
		}

		public static float GetScaledDistance(List<LeanFinger> fingers, Vector2 center)
		{
			return 0f;
		}

		public static bool TryGetScaledDistance(List<LeanFinger> fingers, Vector2 center, ref float distance)
		{
			return false;
		}

		public static float GetLastScreenDistance()
		{
			return 0f;
		}

		public static float GetLastScreenDistance(List<LeanFinger> fingers)
		{
			return 0f;
		}

		public static float GetLastScreenDistance(List<LeanFinger> fingers, Vector2 center)
		{
			return 0f;
		}

		public static bool TryGetLastScreenDistance(List<LeanFinger> fingers, Vector2 center, ref float distance)
		{
			return false;
		}

		public static float GetLastScaledDistance()
		{
			return 0f;
		}

		public static float GetLastScaledDistance(List<LeanFinger> fingers)
		{
			return 0f;
		}

		public static float GetLastScaledDistance(List<LeanFinger> fingers, Vector2 center)
		{
			return 0f;
		}

		public static bool TryGetLastScaledDistance(List<LeanFinger> fingers, Vector2 center, ref float distance)
		{
			return false;
		}

		public static float GetStartScreenDistance()
		{
			return 0f;
		}

		public static float GetStartScreenDistance(List<LeanFinger> fingers)
		{
			return 0f;
		}

		public static float GetStartScreenDistance(List<LeanFinger> fingers, Vector2 center)
		{
			return 0f;
		}

		public static bool TryGetStartScreenDistance(List<LeanFinger> fingers, Vector2 center, ref float distance)
		{
			return false;
		}

		public static float GetStartScaledDistance()
		{
			return 0f;
		}

		public static float GetStartScaledDistance(List<LeanFinger> fingers)
		{
			return 0f;
		}

		public static float GetStartScaledDistance(List<LeanFinger> fingers, Vector2 center)
		{
			return 0f;
		}

		public static bool TryGetStartScaledDistance(List<LeanFinger> fingers, Vector2 center, ref float distance)
		{
			return false;
		}

		public static float GetPinchScale(float wheelSensitivity = 0f)
		{
			return 0f;
		}

		public static float GetPinchScale(List<LeanFinger> fingers, float wheelSensitivity = 0f)
		{
			return 0f;
		}

		public static bool TryGetPinchScale(List<LeanFinger> fingers, Vector2 center, Vector2 lastCenter, ref float scale, float wheelSensitivity = 0f)
		{
			return false;
		}

		public static float GetPinchRatio(float wheelSensitivity = 0f)
		{
			return 0f;
		}

		public static float GetPinchRatio(List<LeanFinger> fingers, float wheelSensitivity = 0f)
		{
			return 0f;
		}

		public static bool TryGetPinchRatio(List<LeanFinger> fingers, Vector2 center, Vector2 lastCenter, ref float ratio, float wheelSensitivity = 0f)
		{
			return false;
		}

		public static float GetTwistDegrees()
		{
			return 0f;
		}

		public static float GetTwistDegrees(List<LeanFinger> fingers)
		{
			return 0f;
		}

		public static float GetTwistDegrees(List<LeanFinger> fingers, Vector2 center, Vector2 lastCenter)
		{
			return 0f;
		}

		public static bool TryGetTwistDegrees(List<LeanFinger> fingers, Vector2 center, Vector2 lastCenter, ref float degrees)
		{
			return false;
		}

		public static float GetTwistRadians()
		{
			return 0f;
		}

		public static float GetTwistRadians(List<LeanFinger> fingers)
		{
			return 0f;
		}

		public static float GetTwistRadians(List<LeanFinger> fingers, Vector2 center, Vector2 lastCenter)
		{
			return 0f;
		}

		public static bool TryGetTwistRadians(List<LeanFinger> fingers, Vector2 center, Vector2 lastCenter, ref float radians)
		{
			return false;
		}
	}
}
