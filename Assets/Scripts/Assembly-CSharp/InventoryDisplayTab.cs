using UnityEngine;

public class InventoryDisplayTab : MonoBehaviour
{
	public InventoryDisplay owner;

	[SerializeField]
	protected RectTransform elementParent;

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	public virtual void Setup()
	{
	}

	public virtual void TryUpdate()
	{
	}
}
