using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class ScrollRectStepped : ScrollRect
{
	[Serializable]
	public class StopEvent : UnityEvent<int>
	{
	}

	[CompilerGenerated]
	private sealed class OHFHMJPSTNH
	{
		public PointerEventData eventData;

		internal void _003COnInitializePotentialDrag_003Eb__0(IInitializePotentialDragHandler parent)
		{
		}
	}

	[CompilerGenerated]
	private sealed class TRHSQLOQKMS
	{
		public PointerEventData eventData;

		internal void _003COnDrag_003Eb__0(IDragHandler parent)
		{
		}
	}

	[CompilerGenerated]
	private sealed class QPFGGJPEESO
	{
		public PointerEventData eventData;

		internal void _003COnBeginDrag_003Eb__0(IBeginDragHandler parent)
		{
		}
	}

	[CompilerGenerated]
	private sealed class GKFKPTQLKGM
	{
		public PointerEventData eventData;

		internal void _003COnEndDrag_003Eb__0(IEndDragHandler parent)
		{
		}
	}

	[CompilerGenerated]
	private sealed class LGEEIOEPIQM
	{
		public PointerEventData eventData;

		internal void _003COnScroll_003Eb__0(IScrollHandler parent)
		{
		}
	}

	public StopEvent onScrollStopped;

	[SerializeField]
	public bool hidePagesNotInView;

	public bool canScrollLeft;

	public bool canScrollRight;

	public bool canScrollUp;

	public bool canScrollDown;

	public bool hardScrollBlocking;

	public bool clampToSinglePageScroll;

	private bool manualScrollEnabled;

	private int startElement;

	private Tween stepTween;

	private float tStartDrag;

	private Vector3 pstart;

	private Vector3 touchStart;

	private bool routeToParent;

	private void FPTGIGKKNMM<T>(Action<T> RIJMSEKSFKN) where T : IEventSystemHandler
	{
	}

	public override void OnInitializePotentialDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public override void OnDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public override void OnBeginDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public override void OnEndDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public override void OnScroll(PointerEventData QSSIJRMPEQF)
	{
	}

	public void AdjustEventData(ref PointerEventData QSSIJRMPEQF, bool FINJTQFFSGE = false)
	{
	}

	private void NRGQHOELPIQ()
	{
	}

	private void HTJQQTKNMHL()
	{
	}

	public Transform GetCurrentPage()
	{
		return null;
	}

	public Transform GetPageTransform(int LHEHNNGEJIH)
	{
		return null;
	}

	private Vector3 FFJHJHHKSGQ(Transform OGFKHSKTHHR)
	{
		return default(Vector3);
	}

	private bool NLLEJPIPSEQ()
	{
		return false;
	}

	public float GetDistanceToCenter(Transform LJIOGPNTJPN)
	{
		return 0f;
	}

	public float GetPageSize()
	{
		return 0f;
	}

	public int GetClosestToCenterElement()
	{
		return 0;
	}

	private void JTGFIFLRPHJ(ref int LSJGNQFTGPS)
	{
	}

	public int GetPageCount()
	{
		return 0;
	}

	public void ScrollToPage(int FIPHTRRRPET, bool KQGHGPEKKTJ = true, bool KHPJTFPPFTE = false, float OGFKHSKTHHR = 0.4f, bool QLSTKESNINR = true)
	{
	}

	public void ForceUpdateLayout()
	{
	}

	public void SetManualScrollEnabled(bool RIQSLLTIFLG)
	{
	}

	private void HJFPLNSREQL()
	{
	}

	private void MISORGPFMLE(int KQSFOENOONK, int TNEEGPGGOIT)
	{
	}

	private void MEJLJHHETHG()
	{
	}
}
