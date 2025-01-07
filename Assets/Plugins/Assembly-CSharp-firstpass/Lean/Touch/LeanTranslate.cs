using UnityEngine;

namespace Lean.Touch
{
	public class LeanTranslate : MonoBehaviour
	{
		public bool IgnoreStartedOverGui;

		public bool IgnoreIsOverGui;

		public int RequiredFingerCount;

		public LeanSelectable RequiredSelectable;

		public Camera Camera;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void TranslateUI(Vector2 screenDelta)
		{
		}

		protected virtual void Translate(Vector2 screenDelta)
		{
		}
	}
}
