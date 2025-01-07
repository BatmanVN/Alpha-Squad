using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GearSelectPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class FRJJQPJEHPN
	{
		public CardCellVisual cell;

		public ItemGear ig;

		public GearSelectPopup _003C_003E4__this;

		internal void _003CSetupGear_003Eb__1()
		{
		}

		internal void _003CSetupGear_003Eb__0()
		{
		}
	}

	[SerializeField]
	private GameObject prefabGearSelectPopupRow;

	[SerializeField]
	private GameObject prefabCell;

	[SerializeField]
	private GameObject prefabSelectionOverlay;

	[SerializeField]
	private GameObject inspectButton;

	[Space]
	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private Transform parentGearSelectRows;

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

	private Action<List<ItemGear>> JIEMNJMJFRL;

	private List<CardCellVisual> OONKFMHJMIJ;

	private List<ItemGear> GIMISJFQPLI;

	private int QEQELQFRKHT;

	private const int SPPHQMNGRFO = 3;

	public static void Open(List<ItemGear> FOMLFRITLIM, Action<List<ItemGear>> QHIRSNHFELM, int QEQELQFRKHT = 1, string OLPSGPIMEJE = null, string TFILGIFJKJH = null, bool EJFJKJRKQHP = true, bool KRKRSKOGSRP = true)
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

	private void OOQOFTGLEJO()
	{
	}

	public void SetPrice(int SJNSPJGESHJ, Sprite ITRKNMFTGIG, Vector3 TMSKFKKQNRO)
	{
	}

	private void HLEPHIQSOSO()
	{
	}

	private void NLHREMRLOKH()
	{
	}

	private Transform LHNGEGQPKLS()
	{
		return null;
	}

	public void OnOkClick()
	{
	}

	public void OnCloseButton()
	{
	}

	private void QEQOOLNLGRM(CardCellVisual MJHEJPSSPLF)
	{
	}

	private void TGEMFMKSKPS(ItemGear NTISFTTTKEK)
	{
	}
}
