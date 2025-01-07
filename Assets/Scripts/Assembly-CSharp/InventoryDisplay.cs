using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
	public enum IKKLTMKGQHH
	{
		BY_RARITY = 0,
		BY_ITEM_LEVEL = 1,
		BY_UPGRADE_LEVEL = 2,
		BY_COMBAT_POWER = 3
	}

	[CompilerGenerated]
	private sealed class RFRRTNJHGQG
	{
		public ItemWeapon w;

		internal bool _003CGetWeaponCell_003Eb__0(InventoryWeaponCell x)
		{
			return false;
		}
	}

	public const IKKLTMKGQHH SORT_TYPE = IKKLTMKGQHH.BY_RARITY;

	public static readonly Color COLOR_TAB_TEXT_INACTIVE;

	public MenuViewInventory owner;

	[SerializeField]
	private List<InventoryDisplayTab> tabs;

	[Space]
	[SerializeField]
	private Text itemCountLabel;

	[SerializeField]
	private Text labelSortType;

	[SerializeField]
	private RectTransform rectTabWeapons;

	[SerializeField]
	private RectTransform rectTabResources;

	[SerializeField]
	private RectTransform rectTabGear;

	[SerializeField]
	public Button buttonTabWeapons;

	[SerializeField]
	public Button buttonTabResources;

	[SerializeField]
	public Button buttonTabGear;

	[Space]
	[SerializeField]
	private GameObject invSizeBlock;

	[SerializeField]
	private GameObject netWorthBlock;

	[SerializeField]
	private GameObject iconPlus;

	[SerializeField]
	private Image invBg;

	[SerializeField]
	private Sprite invSizeBgReg_Weapons;

	[SerializeField]
	private Sprite invSizeBgReg_Gear;

	[SerializeField]
	private Sprite invSizeBgFull_Weapons;

	[SerializeField]
	private Sprite invSizeBgFull_Gear;

	[NonSerialized]
	public bool openForWeapons;

	public static string KEY;

	public event Action OJSRFHKIFIT
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

	public void Setup()
	{
	}

	public void UpdateAll()
	{
	}

	public InventoryWeaponCell GetWeaponCell(ItemWeapon QTRSFNTGTSR)
	{
		return null;
	}

	private void FPLMQFONEOO()
	{
	}

	public void OpenTab<T>()
	{
	}

	public T GetTab<T>() where T : InventoryDisplayTab
	{
		return null;
	}

	public InventoryDisplayTab GetOpenTab()
	{
		return null;
	}

	private void PMPJKHQSIIS(RectTransform OIGIHGHENJK)
	{
	}

	private void FJFKEEPERQO(RectTransform OIGIHGHENJK)
	{
	}

	public void OnTabClickWeapons()
	{
	}

	public void OnTabClickResources()
	{
	}

	public void OnTabClickGear()
	{
	}

	public RectTransform GetScrollViewport()
	{
		return null;
	}

	public RectTransform GetScrollContent()
	{
		return null;
	}
}
