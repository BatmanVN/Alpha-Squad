using UnityEngine;
using UnityEngine.EventSystems;

public class AdaptiveDragThreshold : MonoBehaviour
{
	private EventSystem LLFPMHERTNF;

	[SerializeField]
	private float dragThresholdPercent;

	[SerializeField]
	private bool useWidthForThreshold;

	[SerializeField]
	private bool runOnAwake;

	private void Awake()
	{
	}

	public void UpdatePixelDrag()
	{
	}
}
