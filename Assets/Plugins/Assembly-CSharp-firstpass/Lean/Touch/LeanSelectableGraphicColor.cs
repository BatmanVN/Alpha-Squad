using UnityEngine;

namespace Lean.Touch
{
	public class LeanSelectableGraphicColor : LeanSelectableBehaviour
	{
		public bool AutoGetDefaultColor;

		public Color DefaultColor;

		public Color SelectedColor;

		protected virtual void Start()
		{
		}

		protected override void OnSelect(LeanFinger finger)
		{
		}

		protected override void OnDeselect()
		{
		}

		private void ChangeColor(Color color)
		{
		}
	}
}
