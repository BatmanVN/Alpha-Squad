using UnityEngine;

namespace Lean.Touch
{
	public class LeanCameraMove : MonoBehaviour
	{
		public Camera Camera;

		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public int RequiredFingerCount;

		public float Sensitivity;

		public LeanScreenDepth ScreenDepth;

		public virtual void SnapToSelection()
		{
		}

		protected virtual void LateUpdate()
		{
		}
	}
}
