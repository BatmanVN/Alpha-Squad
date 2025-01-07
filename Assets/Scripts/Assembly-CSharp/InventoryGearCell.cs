using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGearCell : LootCell
{
	[HideInInspector]
	public MenuViewInventory owner;

	[SerializeField]
	private GameObject prefabSmallGearBonusIcon;

	[Space]
	[SerializeField]
	private RectTransform parentSmallGearBonusIcons;

	[SerializeField]
	public UIItemGear item;

	[SerializeField]
	private GameObject inventoryNew;

	[NonSerialized]
	public ItemGear data;

	[NonSerialized]
	public bool updated;

	[HideInInspector]
	public RectTransform scrollContent;

	[HideInInspector]
	public RectTransform scrollViewport;

	private RectTransform HLFSRNTTOLO;

	private int KQLRLGQOIIS;

	private Camera NEJLPMJGEEJ;

	private bool FEIOGOEEJQF;

	public void Setup(ItemGear TSRPFHOJKSG, bool FEIOGOEEJQF = false)
	{
	}

	public void SetVisibleIfNotEquipped(bool QPNIRNRNJON)
	{
	}

	private void SPMENIIKSIG()
	{
	}

	public void SetNotNew()
	{
	}

	public void HideNew()
	{
	}

	public void HideUpgrade()
	{
	}

	private Camera RHTRRETOEIS()
	{
		return null;
	}

	public void ForceUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private bool QSOSIKIIHIE()
	{
		return false;
	}

	public void DisableUiItemWeapon()
	{
	}

	public void UpdateData(ItemGear TSRPFHOJKSG)
	{
	}

	public void OnClick()
	{
	}

	public override Image GetBackground()
	{
		return null;
	}

	public bool IsEquipped()
	{
		return false;
	}

	public void ForceHideLock()
	{
	}

	public Text GetLabelUpgradeLevel()
	{
		return null;
	}

	public ItemGear GetItemGear()
	{
		return null;
	}
}
