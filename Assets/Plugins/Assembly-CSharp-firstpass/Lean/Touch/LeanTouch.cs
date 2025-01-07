using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Lean.Touch
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LeanTouch : MonoBehaviour
	{
		public static List<LeanTouch> Instances;

		public static List<LeanFinger> Fingers;

		public static List<LeanFinger> InactiveFingers;

		public static Action<LeanFinger> OnFingerDown;

		public static Action<LeanFinger> OnFingerSet;

		public static Action<LeanFinger> OnFingerUp;

		public static Action<LeanFinger> OnFingerTap;

		public static Action<LeanFinger> OnFingerSwipe;

		public static Action<List<LeanFinger>> OnGesture;

		public float TapThreshold;

		public const float DefaultTapThreshold = 0.2f;

		public float SwipeThreshold;

		public const float DefaultSwipeThreshold = 100f;

		public int ReferenceDpi;

		public const int DefaultReferenceDpi = 200;

		public LayerMask GuiLayers;

		public bool RecordFingers;

		public float RecordThreshold;

		public float RecordLimit;

		public bool SimulateMultiFingers;

		public KeyCode PinchTwistKey;

		public KeyCode MultiDragKey;

		public Texture2D FingerTexture;

		private static int highestMouseButton;

		private static List<RaycastResult> tempRaycastResults;

		private static List<LeanFinger> filteredFingers;

		private static PointerEventData tempPointerEventData;

		private static EventSystem tempEventSystem;

		public static float CurrentTapThreshold => 0f;

		public static float CurrentSwipeThreshold => 0f;

		public static int CurrentReferenceDpi => 0;

		public static LayerMask CurrentGuiLayers => default(LayerMask);

		public static LeanTouch Instance => null;

		public static float ScalingFactor => 0f;

		public static bool AnyMouseButtonSet => false;

		public static bool GuiInUse => false;

		public static Camera GetCamera(Camera currentCamera, GameObject gameObject = null)
		{
			return null;
		}

		public static float GetDampenFactor(float dampening, float deltaTime)
		{
			return 0f;
		}

		public static bool PointOverGui(Vector2 screenPosition)
		{
			return false;
		}

		public static List<RaycastResult> RaycastGui(Vector2 screenPosition)
		{
			return null;
		}

		public static List<RaycastResult> RaycastGui(Vector2 screenPosition, LayerMask layerMask)
		{
			return null;
		}

		public static List<LeanFinger> GetFingers(bool ignoreIfStartedOverGui, bool ignoreIfOverGui, int requiredFingerCount = 0)
		{
			return null;
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void OnGUI()
		{
		}

		private void BeginFingers()
		{
		}

		private void EndFingers()
		{
		}

		private void PollFingers()
		{
		}

		private void UpdateEvents()
		{
		}

		private void AddFinger(int index, Vector2 screenPosition, float pressure)
		{
		}

		private LeanFinger FindFinger(int index)
		{
			return null;
		}

		private int FindInactiveFingerIndex(int index)
		{
			return 0;
		}
	}
}
