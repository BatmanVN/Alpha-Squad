using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWeaponCell : LootCell
{
	[HideInInspector]
	public MenuViewInventory owner;

	[SerializeField]
	public UIItemWeapon item;

	[SerializeField]
	private GameObject inventoryNew;

	[SerializeField]
	private WeaponRarityStars rarityStars;

	[NonSerialized]
	public ItemWeapon data;

	[NonSerialized]
	public bool updated;

	[HideInInspector]
	public RectTransform scrollContent;

	[HideInInspector]
	public RectTransform scrollViewport;

	private RectTransform HLFSRNTTOLO;

	private int KQLRLGQOIIS;

	private Camera NEJLPMJGEEJ;

	public bool allowSwapping;

	public void Setup(ItemWeapon TSRPFHOJKSG)
	{
	}

	public void HideNew()
	{
	}

	public void SetNotNew(bool OTKEJPFTSSI = true)
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

	public void UpdateData(ItemWeapon TSRPFHOJKSG)
	{
	}

	public void OnClick()
	{
	}

	public override Image GetBackground()
	{
		return null;
	}
}
