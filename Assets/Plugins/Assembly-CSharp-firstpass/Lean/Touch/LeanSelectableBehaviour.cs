using System;
using UnityEngine;

namespace Lean.Touch
{
	public abstract class LeanSelectableBehaviour : MonoBehaviour
	{
		[NonSerialized]
		private LeanSelectable selectable;

		public LeanSelectable Selectable => null;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnSelect(LeanFinger finger)
		{
		}

		protected virtual void OnSelectUp(LeanFinger finger)
		{
		}

		protected virtual void OnDeselect()
		{
		}

		private void UpdateSelectable()
		{
		}
	}
}
