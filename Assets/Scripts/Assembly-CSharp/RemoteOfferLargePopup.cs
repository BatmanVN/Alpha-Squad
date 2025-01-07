using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using RemoteOffers;
using UnityEngine;

public class RemoteOfferLargePopup : RemoteOfferPopupBase_ProductLoot
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct IIHLLJKLKKO
	{
		public RectTransform currentRow;

		public RemoteOfferLargePopup _003C_003E4__this;

		public int rowIndex;

		public int cellsPerRow;
	}

	[SerializeField]
	private GameObject prefabLootRow;

	[SerializeField]
	private SmallCellVisual prefabLootCell;

	[Space]
	[SerializeField]
	private RectTransform rowParent;

	public static void Open(RemoteOfferData GLNTLSLQFFS, bool PRLEJONOPLK = true)
	{
	}

	protected override bool MLNESSGJRME(RemoteOfferData GLNTLSLQFFS)
	{
		return false;
	}

	private void JRTJGQNKPOI()
	{
	}

	[CompilerGenerated]
	private RectTransform IGPEFFNGOLE(ref IIHLLJKLKKO P_0)
	{
		return null;
	}
}
