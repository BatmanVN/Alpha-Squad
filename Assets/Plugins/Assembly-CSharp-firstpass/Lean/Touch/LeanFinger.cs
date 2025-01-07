using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
	public class LeanFinger
	{
		public int Index;

		public float Age;

		public bool Set;

		public bool LastSet;

		public bool Tap;

		public int TapCount;

		public bool Swipe;

		public float LastPressure;

		public float Pressure;

		public Vector2 StartScreenPosition;

		public Vector2 LastScreenPosition;

		public Vector2 ScreenPosition;

		public bool StartedOverGui;

		public List<LeanSnapshot> Snapshots;

		public bool IsActive => false;

		public float SnapshotDuration => 0f;

		public bool IsOverGui => false;

		public bool Down => false;

		public bool Up => false;

		public Vector2 LastSnapshotScreenDelta => default(Vector2);

		public Vector2 LastSnapshotScaledDelta => default(Vector2);

		public Vector2 ScreenDelta => default(Vector2);

		public Vector2 ScaledDelta => default(Vector2);

		public Vector2 SwipeScreenDelta => default(Vector2);

		public Vector2 SwipeScaledDelta => default(Vector2);

		public Ray GetRay(Camera camera = null)
		{
			return default(Ray);
		}

		public Ray GetStartRay(Camera camera = null)
		{
			return default(Ray);
		}

		public Vector2 GetSnapshotScreenDelta(float deltaTime)
		{
			return default(Vector2);
		}

		public Vector2 GetSnapshotScaledDelta(float deltaTime)
		{
			return default(Vector2);
		}

		public Vector2 GetSnapshotScreenPosition(float targetAge)
		{
			return default(Vector2);
		}

		public Vector3 GetSnapshotWorldPosition(float targetAge, float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public float GetRadians(Vector2 referencePoint)
		{
			return 0f;
		}

		public float GetDegrees(Vector2 referencePoint)
		{
			return 0f;
		}

		public float GetLastRadians(Vector2 referencePoint)
		{
			return 0f;
		}

		public float GetLastDegrees(Vector2 referencePoint)
		{
			return 0f;
		}

		public float GetDeltaRadians(Vector2 referencePoint)
		{
			return 0f;
		}

		public float GetDeltaRadians(Vector2 referencePoint, Vector2 lastReferencePoint)
		{
			return 0f;
		}

		public float GetDeltaDegrees(Vector2 referencePoint)
		{
			return 0f;
		}

		public float GetDeltaDegrees(Vector2 referencePoint, Vector2 lastReferencePoint)
		{
			return 0f;
		}

		public float GetScreenDistance(Vector2 point)
		{
			return 0f;
		}

		public float GetScaledDistance(Vector2 point)
		{
			return 0f;
		}

		public float GetLastScreenDistance(Vector2 point)
		{
			return 0f;
		}

		public float GetLastScaledDistance(Vector2 point)
		{
			return 0f;
		}

		public float GetStartScreenDistance(Vector2 point)
		{
			return 0f;
		}

		public float GetStartScaledDistance(Vector2 point)
		{
			return 0f;
		}

		public Vector3 GetStartWorldPosition(float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public Vector3 GetLastWorldPosition(float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public Vector3 GetWorldPosition(float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public Vector3 GetWorldDelta(float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public Vector3 GetWorldDelta(float lastDistance, float distance, Camera camera = null)
		{
			return default(Vector3);
		}

		public void ClearSnapshots(int count = -1)
		{
		}

		public void RecordSnapshot()
		{
		}
	}
}
