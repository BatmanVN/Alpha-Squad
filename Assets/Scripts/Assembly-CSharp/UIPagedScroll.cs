using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class UIPagedScroll : UIBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	private enum QIMKHHTGRGI
	{
		Vertical = 0,
		Horizontal = 1
	}

	public RectTransform Content;

	public RectTransform ViewPort;

	[SerializeField]
	private float scrollDamping;

	[SerializeField]
	private float snapSpeed;

	[SerializeField]
	private QIMKHHTGRGI direction;

	private float NSOHKHMGTEN;

	private float MPJPMHJERIM;

	private Vector2 HKIGMJOIIEP;

	public int currentPage;

	private float GOTJPHGLRKK;

	private float PTPPHKOQHNH;

	private bool PRLPSHRSGME;

	public UnityEvent OnDragStopped;

	public void AddRequiredElements()
	{
	}

	private void RJEFERSHMOG()
	{
	}

	private void Update()
	{
	}

	public void ScrollToPage(int FIPHTRRRPET, bool KQGHGPEKKTJ = true)
	{
	}

	public void OnBeginDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public float GetPageX(int FIPHTRRRPET)
	{
		return 0f;
	}

	public float GetPageY(int FIPHTRRRPET)
	{
		return 0f;
	}

	public void OnEndDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnDrag(PointerEventData QSSIJRMPEQF)
	{
	}
}
