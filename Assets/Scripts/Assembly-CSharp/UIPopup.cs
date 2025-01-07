using System;

public class UIPopup : UILayer
{
	public Action OnRemovedFromPopupQueue;

	public virtual void OnAddedToPopupQueue()
	{
	}

	public virtual void EnterView()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	public void HideForQueue(bool KQGHGPEKKTJ)
	{
	}

	public bool IsInQueue()
	{
		return false;
	}
}
