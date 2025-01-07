using System;
using UnityEngine;

public class ScrapGearCell : ScrapItemCell
{
	[NonSerialized]
	public ItemGear data;

	[SerializeField]
	private InventoryGearCell uiItemGear;

	public void Setup(ItemGear NTISFTTTKEK)
	{
	}

	public override bool IsLocked()
	{
		return false;
	}

	public override bool IsItemEquipped()
	{
		return false;
	}

	public override int GetRarityNumber()
	{
		return 0;
	}

	public override bool IsItemLocked()
	{
		return false;
	}

	public override ItemGear GetItemGear()
	{
		return null;
	}

	public override int GetItemUpgradeLevel()
	{
		return 0;
	}
}
