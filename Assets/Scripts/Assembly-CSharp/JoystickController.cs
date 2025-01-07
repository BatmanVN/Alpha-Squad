using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler
{
	public bool visible;

	public bool resetOnRelease;

	public bool follow;

	public bool hardFollow;

	public bool forceMax;

	public bool handleUnforceMax;

	public float minInput;

	[SerializeField]
	private Vector2 inputMapRange;

	public RectTransform JoystickBackground;

	public RectTransform JoystickHandle;

	public RectTransform DirectionPointer;

	[SerializeField]
	private RectTransform touchBeginRect;

	[NonSerialized]
	public bool inputStarted;

	private Vector2 PGNJKOGGIRL;

	private Vector2 TKPOJMMOSEP;

	private Vector2 LNSKNHHJLKS;

	private Vector2 IOFNEOIGQOJ;

	public float Size;

	public float Deadzone;

	public float DragRange;

	public float HandleMaxDistance;

	public float hardFollowSpeedFar;

	public float hardFollowSpeedClose;

	private bool OTQMSJRONME;

	protected float KRHGFNFOFQO;

	private PointerEventData RGTPRKKISLE;

	public event Action<Vector2> OLTGGEOLTKS
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action SHHOEMMHOKT
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action QLPSHIJRLMT
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected virtual void Start()
	{
	}

	private void Update()
	{
	}

	public void OnInputHold(Vector2 ERINLTKNSFO)
	{
	}

	public void OnInputReleased()
	{
	}

	private void OnEnable()
	{
	}

	public void OnDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	private void OnApplicationPause(bool ITMQLJPRGOJ)
	{
	}

	public void OnPointerUp(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerDown(PointerEventData QSSIJRMPEQF)
	{
	}

	private void QOQHEEHTSEM()
	{
	}

	private bool QQSESLSLLME(PointerEventData QSSIJRMPEQF)
	{
		return false;
	}

	private bool PSKSSSHPOSN(PointerEventData QSSIJRMPEQF)
	{
		return false;
	}
}
