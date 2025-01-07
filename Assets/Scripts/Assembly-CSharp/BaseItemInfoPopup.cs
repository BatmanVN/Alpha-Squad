using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BaseItemInfoPopup : UIPopup
{
	public static Action<int> OnItemPreviewed;

	[NonSerialized]
	public UnityEvent onOk;

	[NonSerialized]
	public UnityEvent onClose;

	[SerializeField]
	private GameObject popup;

	[SerializeField]
	private GameObject generalInfo;

	[SerializeField]
	private BaseObjectPreview preview;

	[SerializeField]
	private Text itemName;

	[SerializeField]
	private Image categoryIcon;

	[SerializeField]
	private Text categoryName;

	[SerializeField]
	private Text collectionName;

	[SerializeField]
	private Text gridSizeText;

	[SerializeField]
	private Text priceAmountText;

	[SerializeField]
	private GameObject buttonStateBuild;

	[SerializeField]
	private GameObject buttonStateStorage;

	[SerializeField]
	private UIPrestigeDisplay prestigeDisplay;

	[SerializeField]
	private GameObject xpDisplay;

	[SerializeField]
	private Text xpDisplayText;

	[SerializeField]
	private GameObject storedIndicator;

	[SerializeField]
	private Text storedAmountText;

	[SerializeField]
	private GameObject interactableIcon;

	[SerializeField]
	private GameObject arrowHolder;

	[SerializeField]
	private GameObject gotItFrom;

	[Space]
	[SerializeField]
	private GameObject trophyInfo;

	[SerializeField]
	private Text seasonText;

	private BaseItemSave HPJMQLRTORF;

	private BaseObjectData TSRPFHOJKSG;

	private bool NPTHJHLFHIG;

	private BuildMenuTab NQTPJLQQLRE;

	public void SetupForItem(BaseItemSave IOGMNEPJEEM, bool NJKGLQPOPSL = false, bool JEPRTELNILG = false, bool LEQIHMHTNIM = true)
	{
	}

	private void THLLRSEFLOG(int HSLQJLPMLMH)
	{
	}

	private void LNNQHHHFTLF(BaseItemSave IOGMNEPJEEM)
	{
	}

	private void EHQEOLJTNPT()
	{
	}

	public void SwitchItem(bool PITFEETNKEK)
	{
	}

	public override void OnShowFinished()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void MGQMOMPMSSL()
	{
	}

	private void HGNQIPKSTKJ()
	{
	}

	public void OnOk()
	{
	}

	public void OnClose()
	{
	}

	public Transform GetBuildButtonTransform()
	{
		return null;
	}
}
