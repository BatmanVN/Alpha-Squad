using UnityEngine;
using UnityEngine.UI;

public class MailItem : MonoBehaviour
{
	[SerializeField]
	protected Image icon;

	[SerializeField]
	protected Text titleLabel;

	[SerializeField]
	protected Text messageLabel;

	[SerializeField]
	protected RectTransform messageRect;

	[SerializeField]
	protected RectTransform thisRect;

	[SerializeField]
	protected Text createTimeLabel;

	[SerializeField]
	protected GameObject newBadge;

	[SerializeField]
	protected float heightWithoutMessage;

	[SerializeField]
	protected Sprite[] icons;

	protected KMFIJTNRRFS.Mail RJQOJELGTLH;

	public virtual void Setup(KMFIJTNRRFS.Mail NHGSHOSQRFQ)
	{
	}

	public virtual float GetExtraHeight()
	{
		return 0f;
	}

	protected virtual bool JIQNTFRLELO()
	{
		return false;
	}

	public void UpdateNotificationBubble()
	{
	}

	public long GetCreateTs()
	{
		return 0L;
	}

	protected long MREOKSTEMMM()
	{
		return 0L;
	}

	private void HQLMHIOJMFS()
	{
	}

	private void LHOGRPGFFSJ()
	{
	}

	private string FPPFRQNMONR()
	{
		return null;
	}

	private string PEGLPQOMEII()
	{
		return null;
	}

	protected Sprite EKIHLJFMQNM()
	{
		return null;
	}
}
