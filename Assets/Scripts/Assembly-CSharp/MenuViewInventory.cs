using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class MenuViewInventory : MenuView
{
	public enum QMKEIKKQSPS
	{
		BY_RARITY = 0,
		BY_ITEM_LEVEL = 1,
		BY_UPGRADE_LEVEL = 2,
		BY_COMBAT_POWER = 3
	}

	[Serializable]
	public struct Data
	{
		public QMKEIKKQSPS sortType;
	}

	[CompilerGenerated]
	private sealed class MSTOHHKONKM
	{
		public ItemWeapon iw;

		internal bool _003CTryUpdateCellForItemWeapon_003Eb__0(InventoryWeaponCell x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class EOSLNLSEPIG
	{
		public ItemWeapon w;

		internal bool _003CGetCellTransformFor_003Eb__0(EquipmentItemCell cell)
		{
			return false;
		}

		internal bool _003CGetCellTransformFor_003Eb__1(InventoryWeaponCell cell)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class IEHIETJTMNH
	{
		public ItemWeapon iw;

		internal bool _003CGetItemCellByWeapon_003Eb__0(InventoryWeaponCell x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TKFQNRMPLTO
	{
		public ItemGear ig;

		internal bool _003CGetItemCellByGear_003Eb__0(InventoryGearCell x)
		{
			return false;
		}
	}

	[SerializeField]
	private EquipmentItemCell prefabEquipCell;

	[SerializeField]
	private EquipmentGearCell prefabGearCell;

	[SerializeField]
	private FloatingErrorText prefabFloatingErrorText;

	[SerializeField]
	private ScrollRectEx scroll;

	[SerializeField]
	public InventoryDisplay inventoryDisplay;

	[SerializeField]
	private InventoryCompareOverlay compareOverlay;

	[SerializeField]
	private RectTransform equipmentParent;

	[SerializeField]
	private UIPlayerPreview preview;

	[SerializeField]
	public RectTransform inventoryScrollContent;

	[SerializeField]
	public RectTransform inventoryScrollViewport;

	[SerializeField]
	public MenuSelectedItem menuSelectedItem;

	[SerializeField]
	private CanvasGroup inventoryHardCover;

	[SerializeField]
	private Text hardCoverLabel;

	[SerializeField]
	private RectTransform lockLocationEquipMode;

	[SerializeField]
	private Text labelTotalCp;

	[SerializeField]
	public Button scrapButton;

	[SerializeField]
	public Button workshopButton;

	[SerializeField]
	public Button sortButton;

	[SerializeField]
	public Button backpackExpandButton;

	[SerializeField]
	public Button changeAgentButton;

	[SerializeField]
	public Button totalCpButton;

	[SerializeField]
	public GameObject inputBlocker;

	[SerializeField]
	private Button coverEquipButton;

	[SerializeField]
	public CanvasGroup inventoryTabs;

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
	public CanvasGroup loadoutButtonParent;

	[SerializeField]
	private LoadoutButton[] loadoutButtons;

	[SerializeField]
	private GameObject profileLoadoutTooltip;

	private ItemWeapon OILLOSLKRNE;

	private ItemWeapon IEIJGFHSPEJ;

	private bool EPKIRGMKQHL;

	private bool PIENFSHRJOG;

	private bool QNHQLTOHGSR;

	private Vector3 GNNESSHPMEI;

	private ItemWeapon TSKNJQGPEPF;

	private ItemWeapon QLMJEQEORGP;

	private Vector3 HSMQREEJOOO;

	[NonSerialized]
	public bool swappingAllowed;

	private List<EquipmentItemCell> OJPOPKTILFR;

	private List<EquipmentGearCell> OOEMQNMLEKO;

	private bool GLSLEJHLHRR;

	private List<ItemWeapon> HIHPIFLKNQJ;

	private List<ItemGear> EEFRHPNMQNH;

	public Data data;

	private Camera NEJLPMJGEEJ;

	private static string JKPNPHQEOKN;

	protected override void Awake()
	{
	}

	private void KHJMORGGSFL()
	{
	}

	public override void Setup()
	{
	}

	public override void OnRemove()
	{
	}

	public override void OnEntered()
	{
	}

	public override void OnExited()
	{
	}

	private void Update()
	{
	}

	private void IRQGNNJNGEI(int PGLQKFSLQJL)
	{
	}

	private void ENFIFTRQFLF()
	{
	}

	private void ERSLSHGSMQE()
	{
	}

	private void GPNMLOPSGMQ()
	{
	}

	public void SetupLoadout()
	{
	}

	private void LSIOGSSSLET()
	{
	}

	private void NHGHLTKSRMR()
	{
	}

	public void CloseLoadoutTooltip()
	{
	}

	private bool TNJJTKSOQLP()
	{
		return false;
	}

	public bool IsInEquipMode()
	{
		return false;
	}

	public void SetEquipMode(bool THNTOHQGJIL, ItemWeapon MTMOSRGIIFO = null)
	{
	}

	public bool IsInComparisonMode()
	{
		return false;
	}

	public void SetWeaponSwapMode(bool RENIIJLOEOR, EquipmentItemCell IHLJKIQNLFS)
	{
	}

	public void OnSwap(Vector3 SKOJGTGOPIF, Vector3 KSOOFMHENOF, ItemWeapon EESTGTGKLJG, ItemWeapon ITKRTPGMJGE)
	{
	}

	public ItemWeapon GetWeaponTryingToEquip()
	{
		return null;
	}

	public void OnWeaponEquip(ItemWeapon FHQPKFMENGQ)
	{
	}

	public void OnWeaponUnequip(ItemWeapon FHQPKFMENGQ)
	{
	}

	public void OnGearEquip(ItemGear PNLNMHFJMSG)
	{
	}

	public void OnGearUnequip(ItemGear PNLNMHFJMSG)
	{
	}

	public void OnLoadoutClick(int IHKIHHNEMRL)
	{
	}

	public ItemWeapon GetPreviewedWeapon()
	{
		return null;
	}

	public void OnSelectedItemChanged()
	{
	}

	private bool PPLQOFOPISI()
	{
		return false;
	}

	private void GEKTRFITETP()
	{
	}

	private void ERJQOPNSKIQ()
	{
	}

	private void TMJFQOQLMPN()
	{
	}

	public void TryUpdateCellForItemWeapon(ItemWeapon FKKJGTNIISP)
	{
	}

	public void OnInventoryItemClick(InventoryWeaponCell TNRNEMRIFLN, bool TTQIQHFJQMO = true)
	{
	}

	public void OnEquipmentItemClick(EquipmentItemCell TNRNEMRIFLN)
	{
	}

	public void OnInventoryGearItemClick(InventoryGearCell HSKHGIPNHLG)
	{
	}

	public void OnEquipmentGearItemClick(EquipmentGearCell HSKHGIPNHLG)
	{
	}

	public void OpenCompareView(ItemWeapon QTRSFNTGTSR)
	{
	}

	public void CompareWithWeapon(ItemWeapon QTRSFNTGTSR)
	{
	}

	public void CloseCompareView()
	{
	}

	private void QERMROSJILM()
	{
	}

	public void ButtonTest()
	{
	}

	public void OnChangeAgentButton()
	{
	}

	public void OnScrapButton()
	{
	}

	public void OnWorkshopButton()
	{
	}

	public void OnSortButton()
	{
	}

	public void OnCoverEquipButton()
	{
	}

	public void OnInventorySizeButton()
	{
	}

	public void OnScrollUpdated()
	{
	}

	public void OnScrapOverlayClosed()
	{
	}

	public void OnTotalCpButton()
	{
	}

	public Transform GetCellTransformFor(ItemWeapon QTRSFNTGTSR)
	{
		return null;
	}

	public InventoryWeaponCell GetItemCellByIndex(int PNIQKIGEHLF)
	{
		return null;
	}

	public InventoryWeaponCell GetItemCellByWeapon(ItemWeapon FKKJGTNIISP)
	{
		return null;
	}

	public InventoryGearCell GetItemCellByGear(ItemGear NTISFTTTKEK)
	{
		return null;
	}

	public List<EquipmentItemCell> GetEquipmentCells()
	{
		return null;
	}

	public void SpawnFloatingErrorText(string HETQTIKJGNI, Transform EESTGTGKLJG, bool FNEHITKNEGR = true)
	{
	}

	public void AnimateWeapons()
	{
	}

	[CompilerGenerated]
	private void HTEGETNHKJJ(EquipmentItemCell HNLHQPIFJNS)
	{
	}

	[CompilerGenerated]
	private void PSLSHGKPSJJ(EquipmentItemCell HNLHQPIFJNS)
	{
	}
}
