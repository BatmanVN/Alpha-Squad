using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MenuGearPopup : UIPopup
{
	public enum OPTKLHNEPRP
	{
		REGULAR = 0,
		INFO = 1,
		PREVIEW = 2
	}

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[Space]
	[SerializeField]
	private Text title;

	[SerializeField]
	private GearInfoPopupPreviewBlock previewBlock;

	[SerializeField]
	private GearInfoPopupStatsBlock statsBlock;

	[SerializeField]
	private GearInfoPopupPerksBlock perksBlock;

	[SerializeField]
	private GearInfoPopupButtonsBlock buttonsBlock;

	[SerializeField]
	private GearInfoPopupUpgradeBlock upgradeBlock;

	[SerializeField]
	private GameObject workshopButton;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[Space]
	[SerializeField]
	public Button lockButton;

	[SerializeField]
	private GameObject lockIconActive;

	[SerializeField]
	private GameObject lockIconInactive;

	[SerializeField]
	private GameObject lockParent;

	[SerializeField]
	private Material scrapButtonMaterial;

	private ItemGear HPJMQLRTORF;

	private OPTKLHNEPRP MJPJLPIKQFE;

	private List<ItemGear> LMOEKNFJKPO;

	private int NEQMJEMJFPE;

	private int EESQJISERQF;

	private int MGHREJOIRQK;

	private int PLLITENTTGO;

	private bool RJSMNINHQGP;

	private List<ItemGear> FKNRQPJMSEP;

	protected override void MGKPMPHSLFR()
	{
	}

	private void HFEPNGRMGIL(int FKKLKESIMML)
	{
	}

	public static void Open(ItemGear QPSGKEPIKNP, OPTKLHNEPRP PTHIFGMSJIP = OPTKLHNEPRP.REGULAR, bool PKRMRHJEGQJ = true)
	{
	}

	public static void OpenWithPredefinedSwaps(ItemGear QPSGKEPIKNP, List<ItemGear> QMEMNLIJRFG)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void NGHFQRREIJN(ItemGear GIMISJFQPLI, bool JEPRTELNILG = false)
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnWorkshopButton()
	{
	}

	public void OnSwapLeftButton()
	{
	}

	public void OnSwapRightButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void KEHJKTNEHER()
	{
	}

	private bool RMHIGQQIRMN()
	{
		return false;
	}

	public void OnLockButton()
	{
	}

	public void OnRerollStatsButton()
	{
	}

	public void OnRerollBonusesButton()
	{
	}

	public void OnUpgradeButton()
	{
	}

	public void OnEquipButton()
	{
	}

	public void OnDowngradeButton()
	{
	}

	public void OnMaxOutButton()
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	[CompilerGenerated]
	private void RLQGFRQFFSP()
	{
	}

	[CompilerGenerated]
	private void MJQPQSMNRLI()
	{
	}

	[CompilerGenerated]
	private void NTIMLOKJTSL()
	{
	}
}
