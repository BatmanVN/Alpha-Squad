using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HalloweenShopCell : MonoBehaviour
{
	[SerializeField]
	private CardCellVisual cellLoot;

	[SerializeField]
	private CardCellSelectVisual cellSelect;

	[SerializeField]
	private GameObject overlayPurchased;

	[SerializeField]
	private GameObject blockPrice;

	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private GameObject blockCount;

	[SerializeField]
	private Text labelCount;

	private int PSPJIJNTMOI;

	private TLSEHKTLMFE.Product QFLHGLLPPNR;

	public event Action<HalloweenShopCell> RPJQQQQIHJG
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Setup(int QFOPFRIRJGQ, TLSEHKTLMFE.Product HRSTNHMRIEE)
	{
	}

	public void OnClick()
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	public TLSEHKTLMFE.Product GetProduct()
	{
		return null;
	}
}
