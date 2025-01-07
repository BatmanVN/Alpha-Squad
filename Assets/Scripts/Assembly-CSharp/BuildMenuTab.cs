using UnityEngine;

public abstract class BuildMenuTab : MonoBehaviour
{
	public BuildMenuDisplay owner;

	[SerializeField]
	protected RectTransform elementParent;

	[SerializeField]
	protected BuildMenuSubtabs subtabs;

	protected bool QOOPLGKOOLG;

	protected int QMRMSQFTHHS;

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	protected BaseObjectData FGQHLPQPPEI(int HSLQJLPMLMH)
	{
		return null;
	}

	public virtual void Refresh()
	{
	}

	public virtual void RefreshNotification()
	{
	}

	public virtual void ToggleInputBlocker(bool LKKOESPTGSK)
	{
	}

	public void ToggleInteractive(bool LKKOESPTGSK)
	{
	}

	public abstract void Setup();

	public virtual void TryUpdate()
	{
	}

	public virtual BaseItemSave GetOtherItem(BaseItemSave HPJMQLRTORF, bool PITFEETNKEK)
	{
		return null;
	}

	public virtual bool CanSwapItem()
	{
		return false;
	}
}
