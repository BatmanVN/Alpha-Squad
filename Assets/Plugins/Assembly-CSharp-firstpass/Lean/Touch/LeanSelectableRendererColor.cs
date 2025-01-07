using System;
using UnityEngine;

namespace Lean.Touch
{
	public class LeanSelectableRendererColor : LeanSelectableBehaviour
	{
		public bool AutoGetDefaultColor;

		public Color DefaultColor;

		public Color SelectedColor;

		public bool CloneMaterials;

		[NonSerialized]
		private Renderer cachedRenderer;

		protected virtual void Awake()
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
