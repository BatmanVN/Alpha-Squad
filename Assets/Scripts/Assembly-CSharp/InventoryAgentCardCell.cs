using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class InventoryAgentCardCell : LootCell
{
	[HideInInspector]
	public MenuViewInventory owner;

	[SerializeField]
	private RectTransform visual;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Text labelCount;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> tagIcons;

	[HideInInspector]
	public RectTransform scrollContent;

	[HideInInspector]
	public RectTransform scrollViewport;

	private JJHFPNTSRLT.PQRIQGIOGQT KJPKRITQTJQ;

	private RectTransform HLFSRNTTOLO;

	private int KQLRLGQOIIS;

	private Camera NEJLPMJGEEJ;

	public void Setup(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int SGNNHEROROI)
	{
	}

	public void ForceUpdate()
	{
	}

	private Camera RHTRRETOEIS()
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	private bool QSOSIKIIHIE()
	{
		return false;
	}

	public void OnClick()
	{
	}

	public override Image GetBackground()
	{
		return null;
	}

	[CompilerGenerated]
	private bool GTOMPHHMIQG(JJHFPNTSRLT.RaritySprite HNLHQPIFJNS)
	{
		return false;
	}
}
