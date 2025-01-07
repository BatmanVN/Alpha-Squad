using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScrapItemCell : MonoBehaviour
{
	[NonSerialized]
	public InventoryScrapPanel owner;

	[NonSerialized]
	public bool isSelected;

	[SerializeField]
	protected CanvasGroup selectedOverlay;

	[SerializeField]
	protected CanvasGroup lockedOverlay;

	[SerializeField]
	protected GameObject lockedIcon;

	[SerializeField]
	protected GameObject[] loadoutLocks;

	protected bool PKGLSMJOJOT;

	protected List<int> SQMJMKQOISI;

	public abstract int GetRarityNumber();

	public abstract bool IsLocked();

	public abstract bool IsItemLocked();

	public abstract bool IsItemEquipped();

	public abstract int GetItemUpgradeLevel();

	public virtual bool IsItemLegendary()
	{
		return false;
	}

	public virtual ItemWeapon GetItemWeapon()
	{
		return null;
	}

	public virtual ItemGear GetItemGear()
	{
		return null;
	}

	public void SetSelected(bool ILSTPSQKNNP, bool HJTSKKHKFNG = true)
	{
	}

	public void PlayAppearAnimation(float PRRKGRQILFR)
	{
	}

	private void KORRHSTLFQG()
	{
	}

	public void OnClick()
	{
	}
}
