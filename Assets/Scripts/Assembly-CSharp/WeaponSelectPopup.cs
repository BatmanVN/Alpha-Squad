using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectPopup : UIPopup
{
	[SerializeField]
	private GameObject prefabWeaponSelectPopupRow;

	[SerializeField]
	private UIItemWeaponMin prefabWeapon;

	[SerializeField]
	private GameObject prefabSelectionOverlay;

	[Space]
	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private Transform parentWeaponSelectRows;

	[SerializeField]
	private Transform parentSelectionOverlay;

	[SerializeField]
	private Text title;

	[SerializeField]
	private Text selectLabel;

	[SerializeField]
	private GameObject buttonDisabled;

	[SerializeField]
	private GameObject buttonEnabled;

	[SerializeField]
	private Text labelButtonDisabled;

	[SerializeField]
	private Text labelButtonEnabled;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private GameObject blockPrice;

	[SerializeField]
	private GameObject blockPriceDisabled;

	[SerializeField]
	private Image iconPrice;

	[SerializeField]
	private Image iconPriceDisabled;

	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private Text labelPriceDisabled;

	private Transform KHSLHOQJKHP;

	private List<GameObject> REHLMMQNHMS;

	private Action<List<ItemWeapon>> JIEMNJMJFRL;

	private List<UIItemWeaponMin> GFQTQNFMQRK;

	private List<ItemWeapon> EEHPKGGSNSL;

	private int MOONNMKOKGH;

	private const int JTQHOOKTKSR = 3;

	public static void Open(List<ItemWeapon> QMNHNIHROFH, Action<List<ItemWeapon>> QHIRSNHFELM, int MOONNMKOKGH = 1, string OLPSGPIMEJE = null, string TFILGIFJKJH = null, bool EJFJKJRKQHP = true, bool KRKRSKOGSRP = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void IGIQTHHJEFE()
	{
	}

	private void RNTPTOSPNQT()
	{
	}

	private void NLHREMRLOKH()
	{
	}

	private Transform LHNGEGQPKLS()
	{
		return null;
	}

	public void SetPrice(int SJNSPJGESHJ, Sprite ITRKNMFTGIG, Vector3 TMSKFKKQNRO)
	{
	}

	public void OnOkClick()
	{
	}

	public void OnCloseButton()
	{
	}

	private void QEQOOLNLGRM(UIItemWeaponMin FKKJGTNIISP)
	{
	}
}
