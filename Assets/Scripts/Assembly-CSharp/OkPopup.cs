using System;
using UnityEngine;
using UnityEngine.UI;

public class OkPopup : UIPopup
{
	[SerializeField]
	protected CanvasGroup background;

	[SerializeField]
	protected RectTransform popup;

	[SerializeField]
	protected RectTransform[] scaleLaterObjects;

	public Text title;

	public Text message;

	public Action onOk;

	public static void Open(string GTPEOKJIJFE, string ILSPFHSGNIS, Action SILMTFJJQIJ = null)
	{
	}

	public void OnOkButton()
	{
	}

	public void OnCloseButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}
}
