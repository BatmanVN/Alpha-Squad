using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class DeselectButton : MonoBehaviour, IDeselectHandler, IEventSystemHandler
{
	public UnityEvent OnButtonDeselect;

	public bool disableOnDeselect;

	public void Activate()
	{
	}

	public void OnDeselect(BaseEventData QSSIJRMPEQF)
	{
	}
}
