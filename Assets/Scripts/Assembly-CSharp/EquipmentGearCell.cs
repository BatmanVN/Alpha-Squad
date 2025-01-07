using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EquipmentGearCell : LootCell, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	[NonSerialized]
	public MenuViewInventory owner;

	[SerializeField]
	public UIItemGear item;

	[NonSerialized]
	public ItemGear data;

	private global::HIJIFHMGTTR<Vector2> QREIELQSGIE;

	private Vector3 INTLMSMQEMG;

	private Camera MEEKTRHQHJG;

	private bool QLHRTLIKFGR;

	public event Action<EquipmentGearCell> ILMHKPSEPPO
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

	public void Setup(ItemGear TSRPFHOJKSG)
	{
	}

	public void SetPreview()
	{
	}

	public void PlayEquipAnimation(Vector3 NHLNKMPPTKR)
	{
	}

	public void OnClick()
	{
	}

	public void OnDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnBeginDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnEndDrag(PointerEventData QSSIJRMPEQF)
	{
	}

	private Camera RHTRRETOEIS()
	{
		return null;
	}

	public void HideWeapon()
	{
	}

	public void ShowWeapon()
	{
	}

	public override Image GetBackground()
	{
		return null;
	}

	[CompilerGenerated]
	private void JEPLMLNFGJK()
	{
	}
}
