using UnityEngine;

namespace Lean.Touch
{
	public class LeanRotateCustomAxis : MonoBehaviour
	{
		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public int RequiredFingerCount;

		public LeanSelectable RequiredSelectable;

		public Vector3 Axis;

		public Space Space;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}
	}
}
