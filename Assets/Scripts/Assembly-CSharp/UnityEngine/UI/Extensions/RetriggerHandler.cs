using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	public class RetriggerHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Serializable]
		public class UIButtonEvent : UnityEvent<PointerEventData.InputButton>
		{
		}

		private const float SKJLJFMGNPN = 0.05f;

		private const float RGIQFHHKIEG = 0.4f;

		public UnityAction action;

		public UnityAction action2;

		public UnityAction releaseAction;

		private bool RKQQPGLQKFQ;

		private PointerEventData IJJILMTOIPR;

		private float EKFSSTEMLFQ;

		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData QSSIJRMPEQF)
		{
		}

		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData QSSIJRMPEQF)
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}
	}
}
