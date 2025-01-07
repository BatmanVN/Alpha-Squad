using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Lean.Touch
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class LeanSelectable : MonoBehaviour
	{
		[Serializable]
		public class LeanFingerEvent : UnityEvent<LeanFinger>
		{
		}

		public static List<LeanSelectable> Instances;

		public bool HideWithFinger;

		public bool DeselectOnUp;

		[NonSerialized]
		public LeanFinger SelectingFinger;

		public LeanFingerEvent OnSelect;

		public LeanFingerEvent OnSelectSet;

		public LeanFingerEvent OnSelectUp;

		public UnityEvent OnDeselect;

		[SerializeField]
		private bool isSelected;

		public bool IsSelected => false;

		public bool IsSelectedRaw => false;

		public static int IsSelectedCount => 0;

		public static List<LeanFinger> GetFingers(bool ignoreIfStartedOverGui, bool ignoreIfOverGui, int requiredFingerCount = 0, LeanSelectable requiredSelectable = null)
		{
			return null;
		}

		public static List<LeanFinger> GetFingersOrClear(bool ignoreIfStartedOverGui, bool ignoreIfOverGui, int requiredFingerCount = 0, LeanSelectable requiredSelectable = null)
		{
			return null;
		}

		public static void Cull(int maxCount)
		{
		}

		public static LeanSelectable FindSelectable(LeanFinger finger)
		{
			return null;
		}

		public static void ReplaceSelection(LeanFinger finger, List<LeanSelectable> selectables)
		{
		}

		public bool GetIsSelected(bool raw)
		{
			return false;
		}

		public void Select()
		{
		}

		public static void DeselectAll()
		{
		}

		public void Select(LeanFinger finger)
		{
		}

		public void Deselect()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void FingerSet(LeanFinger finger)
		{
		}

		private void FingerUp(LeanFinger finger)
		{
		}
	}
}
