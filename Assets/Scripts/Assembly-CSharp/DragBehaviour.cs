using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class DragBehaviour : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IInitializePotentialDragHandler
{
	[CompilerGenerated]
	private sealed class FTTKLPJNQGJ
	{
		public PointerEventData eventData;

		internal void _003COnDrag_003Eb__0(IDragHandler parent)
		{
		}
	}

	[CompilerGenerated]
	private sealed class GMGRFEJEMEK
	{
		public PointerEventData eventData;

		internal void _003COnBeginDrag_003Eb__0(IBeginDragHandler parent)
		{
		}
	}

	[CompilerGenerated]
	private sealed class LHKEFMQTEIM
	{
		public PointerEventData eventData;

		internal void _003COnEndDrag_003Eb__0(IEndDragHandler parent)
		{
		}
	}

	[CompilerGenerated]
	private sealed class PRIRRMJORJI
	{
		public PointerEventData eventData;

		internal void _003COnInitializePotentialDrag_003Eb__0(IInitializePotentialDragHandler parent)
		{
		}
	}

	public UnityEvent DragBegin;

	public UnityEvent DragEnd;

	public UnityEvent<Vector2> Drag;

	public bool horizontal;

	public bool vertical;

	private bool IHLJKIQNLFS;

	private bool OIRJSMQJLQQ;

	private void FPTGIGKKNMM<T>(Action<T> RIJMSEKSFKN) where T : IEventSystemHandler
	{
	}

	public void OnDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnBeginDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnEndDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnInitializePotentialDrag(PointerEventData QSSIJRMPEQF)
	{
	}
}
