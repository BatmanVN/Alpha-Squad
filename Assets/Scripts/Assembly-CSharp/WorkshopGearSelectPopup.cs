using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class WorkshopGearSelectPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class IPQNTJEGNKJ
	{
		public KNSKIMFQMTH cat;

		public WorkshopGearSelectPopup _003C_003E4__this;

		public Action<WorkshopSelectGearCell> _003C_003E9__2;

		internal bool _003CSetup_003Eb__0(GearData x)
		{
			return false;
		}

		internal void _003CSetup_003Eb__2(WorkshopSelectGearCell c)
		{
		}
	}

	[SerializeField]
	private Text labelSubTitle;

	[SerializeField]
	private Text labelCraftPrice;

	[SerializeField]
	private Text labelTitle;

	[SerializeField]
	private GameObject buttonCraft;

	[SerializeField]
	private GameObject buttonCraftDisabled;

	[SerializeField]
	private GameObject blockButtons;

	[SerializeField]
	private GameObject prestigeBadge;

	[SerializeField]
	private Transform popupTransform;

	[SerializeField]
	private WorkshopSelectGearCell cellPrefab;

	[SerializeField]
	private RectTransform cellParent;

	[SerializeField]
	private CanvasGroup backgroundCanvas;

	[SerializeField]
	private ScrollRectEx scrollRect;

	private WorkshopSelectGearCell SRTJHIMORTK;

	private List<WorkshopSelectGearCell> GIMPLLMJOIO;

	private KNSKIMFQMTH EMKNPKTIJPF;

	private int SJNSPJGESHJ;

	private bool IKNGJOTKRMN;

	private bool MESHPSKHJTP;

	private Action<ItemGear> HOQHJSIFSFP;

	public static void Open(KNSKIMFQMTH EMKNPKTIJPF, Action<ItemGear> KGRHPNEMMPG, int GIJGIMNHKOF, bool IKNGJOTKRMN)
	{
	}

	public static void OpenInfo(KNSKIMFQMTH EMKNPKTIJPF)
	{
	}

	public void Setup(KNSKIMFQMTH OJTGHRGORLS)
	{
	}

	private void GTRFKTMGQOI()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	private void JMKTTMEGHQJ(WorkshopSelectGearCell GGOKJRGSMRT)
	{
	}

	public void OnCraftPressed()
	{
	}

	public void OnCloseButton()
	{
	}
}
