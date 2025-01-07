using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelectedItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PHGSOPILLLE
	{
		public bool enableInventoryButtons;

		internal void _003CLockToLocation_003Eb__0(GameObject ie)
		{
		}
	}

	[SerializeField]
	private UIItemWeapon weaponPreview;

	[SerializeField]
	private InventoryGearCell gearPreview;

	[SerializeField]
	private FloatingErrorText prefabFloatingErrorText;

	[SerializeField]
	private GameObject view;

	[SerializeField]
	private List<GameObject> inventoryElements;

	[SerializeField]
	private List<GameObject> equipmentElements;

	[SerializeField]
	private Image background;

	[SerializeField]
	private WeaponRarityStars rarityStars;

	[SerializeField]
	public Button buttonEquip;

	[SerializeField]
	private Button buttonUnequip;

	[SerializeField]
	private Button buttonUnequipDisabled;

	[SerializeField]
	public Button buttonInfo;

	[SerializeField]
	public Button buttonClose;

	[SerializeField]
	private bool doubleClickEquip;

	[SerializeField]
	private bool doubleClickUnequip;

	[SerializeField]
	private float doubleClickDelay;

	[NonSerialized]
	public bool lockedToInventory;

	[NonSerialized]
	public MenuViewInventory owner;

	private Transform ROQFQIOHNHF;

	private RectTransform EIPEKQFEPNP;

	public ItemWeapon allowSelectOnly;

	public bool allowOpenForEquipment;

	private bool LKJKNRFMJQG;

	private RectTransform FMQLOFMTKOQ;

	private ItemGear ONKSRPKJEPK;

	private ItemWeapon KROTEKTFGLI;

	private bool GFNHFEEMLKP;

	private static bool IRSNESJIKNF;

	private float HITOOJPIPFF;

	private const float GROPFRFHHRN = 335f;

	private const float LJSNQTJJKQJ = 245f;

	public static event Action OKEIKSIIKSP
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

	public static event Action HMOOJSQLMLN
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

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void LockToWeapon(ItemWeapon LENQOPNFMTG, RectTransform RRRRMKKRKHM, bool TLNEKIPINSH)
	{
	}

	public void LockToGear(ItemGear GIMISJFQPLI, RectTransform RRRRMKKRKHM, bool TLNEKIPINSH)
	{
	}

	public void LockToLocation(RectTransform SRQQIQLLITT, bool INLQIIKTIMO = false)
	{
	}

	public void ResetLock()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void MQILRTPEQJE()
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public bool IsOpenInventory()
	{
		return false;
	}

	public bool IsOpenEquipment()
	{
		return false;
	}

	public void OnEquipButton()
	{
	}

	public void OnUnequipButton()
	{
	}

	public void OnInfoButton()
	{
	}

	public void OnCloseButton()
	{
	}

	private void LITJEQQHNFS(Vector2 RMJFLTHQPRN)
	{
	}

	private void HMFOTOPGJPH()
	{
	}

	public void RefreshState()
	{
	}

	public void SetAllowEquipUnequip(bool SLQKEPMEMJF)
	{
	}

	public void SetAllowInfo(bool SLQKEPMEMJF)
	{
	}

	public void SetAllowDoubleClick(bool SLQKEPMEMJF)
	{
	}

	public void SetAllow(bool SLQKEPMEMJF)
	{
	}
}
