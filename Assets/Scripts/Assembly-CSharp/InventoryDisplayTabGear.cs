using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplayTabGear : InventoryDisplayTab
{
	[CompilerGenerated]
	private sealed class LPSHPRLHLOS
	{
		public List<ItemGear> allGear;

		public int i;

		public Predicate<InventoryGearCell> _003C_003E9__2;

		internal bool _003CTryUpdate_003Eb__2(InventoryGearCell c)
		{
			return false;
		}
	}

	[SerializeField]
	private InventoryGearCell prefabGearCell;

	private ItemController NJTPNQMTJOR;

	[SerializeField]
	private GridLayoutGroup layout;

	[SerializeField]
	private GameObject emptyBlock;

	[SerializeField]
	private GameObject blockButtons;

	[Space]
	[SerializeField]
	private GameObject buttonBody;

	[SerializeField]
	private GameObject buttonHead;

	[SerializeField]
	private GameObject buttonWrist;

	[SerializeField]
	private GameObject buttonGadget;

	[SerializeField]
	public CanvasGroup parentButtons;

	private float OSIMLQFKIJS;

	private float GLGHPFONIRP;

	private List<InventoryGearCell> PHTKEJTOQRG;

	private KNSKIMFQMTH KNGTIMSFIJT;

	public override void Setup()
	{
	}

	public override void TryUpdate()
	{
	}

	private void QPRREQOQGSM()
	{
	}

	private void HEPNTIGNTFS()
	{
	}

	private bool MTHNKEPKFJI()
	{
		return false;
	}

	public void OnButtonBody()
	{
	}

	public void OnButtonHead()
	{
	}

	public void OnButtonWrist()
	{
	}

	public void OnButtonGadget()
	{
	}

	private void RQKFERMHFFP()
	{
	}

	private void RQPRSSRLJHI()
	{
	}

	public KNSKIMFQMTH GetActiveCategory()
	{
		return default(KNSKIMFQMTH);
	}

	public List<InventoryGearCell> GetCells()
	{
		return null;
	}

	[CompilerGenerated]
	internal static void ELJFLRNJMQN(GameObject GKKFNISSPRI, bool ILSTPSQKNNP)
	{
	}
}
