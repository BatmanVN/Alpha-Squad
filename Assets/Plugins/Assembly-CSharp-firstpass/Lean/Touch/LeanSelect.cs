using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
	public class LeanSelect : MonoBehaviour
	{
		public enum SelectType
		{
			Raycast3D = 0,
			Overlap2D = 1,
			CanvasUI = 2
		}

		public enum SearchType
		{
			GetComponent = 0,
			GetComponentInParent = 1,
			GetComponentInChildren = 2
		}

		public enum ReselectType
		{
			KeepSelected = 0,
			Deselect = 1,
			DeselectAndSelect = 2,
			SelectAgain = 3
		}

		public static List<LeanSelect> Instances;

		public SelectType SelectUsing;

		public LayerMask LayerMask;

		public Camera Camera;

		public int MaxSelectables;

		public SearchType Search;

		public ReselectType Reselect;

		public bool AutoDeselect;

		public void SelectStartScreenPosition(LeanFinger finger)
		{
		}

		public void SelectScreenPosition(LeanFinger finger)
		{
		}

		public void SelectScreenPosition(LeanFinger finger, Vector2 screenPosition)
		{
		}

		public void Select(LeanFinger finger, Component component)
		{
		}

		public void Select(LeanFinger finger, LeanSelectable selectable)
		{
		}

		public void DeselectAll()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
