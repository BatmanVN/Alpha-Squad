using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopViewFinishedCraft : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct GJMJRGISMKP
	{
		public float tmax;

		public float tmin;
	}

	[NonSerialized]
	public WorkshopPanel owner;

	[SerializeField]
	private WorkshopCraftResultCell prefabCell;

	[SerializeField]
	private WorkshopCraftResultReturns returns;

	[SerializeField]
	private GameObject viewRegular;

	[SerializeField]
	private GameObject viewGear;

	[SerializeField]
	private GameObject viewMultiple;

	[SerializeField]
	private LootElementUICell lootCellGear;

	[SerializeField]
	private LootElementUICell lootCellRegular;

	[SerializeField]
	private GearInfoPopupPerksBlock gearPerks;

	[SerializeField]
	private GearInfoPopupStatsBlock gearStats;

	[SerializeField]
	private Text labelGearTitle;

	[SerializeField]
	private RectTransform multipleCellParent;

	[Space]
	[SerializeField]
	public Button gotoGearButton;

	[SerializeField]
	private Button continueButton;

	[SerializeField]
	public Button gotoGearButtonMultiple;

	[SerializeField]
	private Button gotoInventoryButtonMultiple;

	[SerializeField]
	private Button continueButtonMultiple;

	[SerializeField]
	private GridLayoutGroup layoutMultiple;

	[Space]
	[SerializeField]
	private List<GameObject> gearBoostedElementList;

	[SerializeField]
	public GameObject inputBlocker;

	private float TTJTKKHSPPF;

	private List<LootElement> MSLNETQPKSP;

	public event Action SKNPNSLKKOF
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

	public void Open(LootElement INNLJIGRFOG)
	{
	}

	public void OpenMultiple(List<LootElement> GTNLNSRKHET)
	{
	}

	private void TJEINRFQEGR()
	{
	}

	public void Hide()
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public void OnCloseButton()
	{
	}

	public void OnGoToGearButton()
	{
	}

	public void OnGoToResourcesButton()
	{
	}

	public void OnCraftAnimFinished()
	{
	}

	private void QEQOOLNLGRM(WorkshopCraftResultCell GGOKJRGSMRT)
	{
	}

	public float GetOpenDelay()
	{
		return 0f;
	}

	[CompilerGenerated]
	internal static float GKNGNLRTLPI(int PSPJIJNTMOI, ref GJMJRGISMKP P_1)
	{
		return 0f;
	}
}
