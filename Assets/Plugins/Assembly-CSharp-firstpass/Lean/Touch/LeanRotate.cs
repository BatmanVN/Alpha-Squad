using UnityEngine;

namespace Lean.Touch
{
	public class LeanRotate : MonoBehaviour
	{
		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public int RequiredFingerCount;

		public LeanSelectable RequiredSelectable;

		public Camera Camera;

		public bool Relative;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void TranslateUI(float twistDegrees, Vector2 twistScreenCenter)
		{
		}

		protected virtual void Translate(float twistDegrees, Vector2 twistScreenCenter)
		{
		}

		protected virtual void RotateUI(float twistDegrees)
		{
		}

		protected virtual void Rotate(float twistDegrees)
		{
		}
	}
}
