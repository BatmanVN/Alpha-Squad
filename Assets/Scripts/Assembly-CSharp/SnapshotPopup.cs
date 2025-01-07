using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gear;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class SnapshotPopup : UIPopup
{
	[SerializeField]
	private EnhancementCell prefabEnhancementCell;

	[SerializeField]
	private EquipmentGearCell prefabGearCell;

	[SerializeField]
	private Text labelPlayerName;

	[SerializeField]
	private Text labelTotalCp;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private GameObject watchButton;

	[SerializeField]
	private GameObject profileButton;

	[SerializeField]
	private GameObject watchIconActive;

	[SerializeField]
	private GameObject watchIconInactive;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private ScrollRectEx scrollEnhancements;

	[SerializeField]
	private UIPlayerPreview agentPreview;

	[SerializeField]
	private RectTransform equippedHelmetSizeRef;

	[SerializeField]
	private RectTransform equippedBodySizeRef;

	[SerializeField]
	private RectTransform equippedAccessorySizeRef;

	[SerializeField]
	private RectTransform equippedGadgetSizeRef;

	[SerializeField]
	private RectTransform equippedHelmet;

	[SerializeField]
	private RectTransform equippedBody;

	[SerializeField]
	private RectTransform equippedAccessory;

	[SerializeField]
	private RectTransform equippedGadget;

	[SerializeField]
	private EquipmentItemCell[] equipmentItems;

	[SerializeField]
	private RectTransform agentEnhancementParent;

	[SerializeField]
	private RectTransform globalEnhancementParent;

	[SerializeField]
	private GameObject noAgentEnhancements;

	[SerializeField]
	private GameObject noGlobalEnhancements;

	[SerializeField]
	private GameObject noEnhancements;

	[SerializeField]
	private GameObject enhancementsParent;

	private RiftsController.Snapshot FOKHGGPFRPM;

	private string IPEOLHNKPHM;

	protected override void MGKPMPHSLFR()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public static bool CanSnapshotBeOpened(RiftsController.Snapshot EMIMSLLKITL)
	{
		return false;
	}

	public void Setup(RiftsController.Snapshot IHELNOENHQS, string PIQNNSGGHFS, string EFKRFLHRFPJ)
	{
	}

	private void GTFSLTPRHOS()
	{
	}

	private void IGIQTHHJEFE()
	{
	}

	private void OOQOFTGLEJO()
	{
	}

	private void GHQSNNKQPMI(RectTransform JKFPSLRREIJ, List<Enhancement> OMTKLHRLRSJ, Agent IFLMHEQTKLS, bool STQQHLRRISH)
	{
	}

	private void KRKGTHRMTPH(EquipmentGearCell GGOKJRGSMRT)
	{
	}

	private void ISGQNIHTKRP(EquipmentItemCell GGOKJRGSMRT)
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnProfileButton()
	{
	}

	public void OnWatchButton()
	{
	}

	private void GQRNSGMHKIG()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	[CompilerGenerated]
	private void ERSPNRJMKOT()
	{
	}

	[CompilerGenerated]
	internal static bool JIKJNQOTGPI(ItemWeapon.Bonus ELEIPINNGGJ)
	{
		return false;
	}

	[CompilerGenerated]
	internal static bool QQHRJFQIHPT(Bonus ELEIPINNGGJ)
	{
		return false;
	}

	[CompilerGenerated]
	internal static bool NLIJHHQQRLE(Enhancement QHSMPFPKNMM)
	{
		return false;
	}

	[CompilerGenerated]
	internal static bool TKPEHTJSIKE(ItemWeapon FKKJGTNIISP)
	{
		return false;
	}

	[CompilerGenerated]
	internal static bool EOHRNENRJSF(Agent HHRGQEQGGIS)
	{
		return false;
	}

	[CompilerGenerated]
	internal static bool QTSGKFGFTRG(ItemGear NTISFTTTKEK)
	{
		return false;
	}

	[CompilerGenerated]
	internal static bool JEHHKGKTLHS(Enhancement QHSMPFPKNMM)
	{
		return false;
	}
}
