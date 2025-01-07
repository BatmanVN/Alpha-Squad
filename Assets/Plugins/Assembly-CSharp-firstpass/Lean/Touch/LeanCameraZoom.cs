using UnityEngine;

namespace Lean.Touch
{
	[ExecuteInEditMode]
	public class LeanCameraZoom : MonoBehaviour
	{
		public Camera Camera;

		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public int RequiredFingerCount;

		public LeanSelectable RequiredSelectable;

		public float WheelSensitivity;

		public float Zoom;

		public bool ZoomClamp;

		public float ZoomMin;

		public float ZoomMax;

		protected virtual void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected void SetZoom(float current)
		{
		}
	}
}
