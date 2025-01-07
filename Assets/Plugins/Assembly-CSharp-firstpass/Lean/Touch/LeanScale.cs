using UnityEngine;

namespace Lean.Touch
{
	public class LeanScale : MonoBehaviour
	{
		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public int RequiredFingerCount;

		public LeanSelectable RequiredSelectable;

		public Camera Camera;

		public float WheelSensitivity;

		public bool Relative;

		public bool ScaleClamp;

		public Vector3 ScaleMin;

		public Vector3 ScaleMax;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void TranslateUI(float pinchScale, Vector2 pinchScreenCenter)
		{
		}

		protected virtual void Translate(float pinchScale, Vector2 screenCenter)
		{
		}

		protected virtual void Scale(Vector3 scale)
		{
		}
	}
}
