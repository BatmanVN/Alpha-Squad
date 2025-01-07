using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplayTabWeapons : InventoryDisplayTab
{
	[CompilerGenerated]
	private sealed class FLEHIKFLPHH
	{
		public List<ItemWeapon> allItems;

		public int i;

		public Predicate<InventoryWeaponCell> _003C_003E9__2;

		internal bool _003CTryUpdate_003Eb__2(InventoryWeaponCell c)
		{
			return false;
		}
	}

	[SerializeField]
	private InventoryWeaponCell prefabWeaponCell;

	[NonSerialized]
	public List<InventoryWeaponCell> cells;

	private ItemController NJTPNQMTJOR;

	[SerializeField]
	private GridLayoutGroup layout;

	[SerializeField]
	private GameObject emptyBlock;

	private float OSIMLQFKIJS;

	private float GLGHPFONIRP;

	private bool QOOPLGKOOLG;

	public override void Setup()
	{
	}

	public override void Show()
	{
	}

	private void MLNESSGJRME()
	{
	}

	private void OnDestroy()
	{
	}

	public override void TryUpdate()
	{
	}

	private bool MTHNKEPKFJI()
	{
		return false;
	}

	private void QPRREQOQGSM()
	{
	}

	private void HEPNTIGNTFS()
	{
	}

	public List<InventoryWeaponCell> GetCells()
	{
		return null;
	}
}
