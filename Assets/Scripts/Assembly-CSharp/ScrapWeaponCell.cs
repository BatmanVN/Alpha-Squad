using System;
using UnityEngine;

public class ScrapWeaponCell : ScrapItemCell
{
	[NonSerialized]
	public ItemWeapon data;

	[SerializeField]
	private UIItemWeapon uiItemWeapon;

	[SerializeField]
	private WeaponRarityStars rarityStars;

	public void Setup(ItemWeapon FKKJGTNIISP)
	{
	}

	public override int GetRarityNumber()
	{
		return 0;
	}

	public override bool IsLocked()
	{
		return false;
	}

	public override bool IsItemLocked()
	{
		return false;
	}

	public override bool IsItemEquipped()
	{
		return false;
	}

	public override ItemWeapon GetItemWeapon()
	{
		return null;
	}

	public override bool IsItemLegendary()
	{
		return false;
	}

	public override int GetItemUpgradeLevel()
	{
		return 0;
	}
}
