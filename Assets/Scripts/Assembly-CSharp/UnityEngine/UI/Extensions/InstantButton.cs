using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	public class InstantButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[Serializable]
		public class UIButtonEvent : UnityEvent<PointerEventData.InputButton>
		{
		}

		public UIButtonEvent OnButtonPress;

		private Button GKKFNISSPRI;

		private void Awake()
		{
		}

		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData QSSIJRMPEQF)
		{
		}
	}
}
