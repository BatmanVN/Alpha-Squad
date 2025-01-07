using System;
using UnityEngine;
using UnityEngine.UI;

public class YesNoConfirmPopup : UIPopup
{
	[SerializeField]
	protected CanvasGroup background;

	[SerializeField]
	protected RectTransform popup;

	[SerializeField]
	protected RectTransform[] scaleLaterObjects;

	[SerializeField]
	private Text[] yesLabels;

	[SerializeField]
	private Text[] noLabels;

	public GameObject standartButtons;

	public GameObject swapButtons;

	public RectTransform messageContainer;

	public RectTransform messageRect;

	public Text title;

	public Text message;

	public Action onYes;

	public Action onNo;

	public static void Open(string GTPEOKJIJFE, string ILSPFHSGNIS, Action IEHFNPQRHJJ, Action SFPJTMREPKE = null, bool KSQTFMTLHMN = false, bool PKRMRHJEGQJ = true)
	{
	}

	public static void OpenCustom(string GTPEOKJIJFE, string ILSPFHSGNIS, Action IEHFNPQRHJJ, Action SFPJTMREPKE, bool KSQTFMTLHMN = false, string RJPHSHPRMIQ = null, string LGKQJROGTKH = null, bool PKRMRHJEGQJ = true)
	{
	}

	private void SLMOJQMGGGI(string QLQRPLGPIPK, string GEHQLGOIIQR)
	{
	}

	public virtual void OnYesButton()
	{
	}

	public void OnNoButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}
}
