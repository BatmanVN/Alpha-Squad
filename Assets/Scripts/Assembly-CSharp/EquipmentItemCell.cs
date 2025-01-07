using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EquipmentItemCell : LootCell, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	[CompilerGenerated]
	private sealed class GEJLRGNQSST
	{
		public Camera cam;

		public Vector3 mP;

		public EquipmentItemCell swapToWeapon;

		public EquipmentItemCell _003C_003E4__this;

		internal bool _003COnEndDrag_003Eb__0(EquipmentItemCell x)
		{
			return false;
		}

		internal bool _003COnEndDrag_003Eb__2(EquipmentItemCell x)
		{
			return false;
		}
	}

	[NonSerialized]
	public MenuViewInventory owner;

	[SerializeField]
	public UIItemWeapon item;

	[SerializeField]
	private WeaponRarityStars rarityStars;

	[NonSerialized]
	public ItemWeapon data;

	public bool allowSwapping;

	public bool interactable;

	private global::HIJIFHMGTTR<Vector2> QREIELQSGIE;

	private Vector3 INTLMSMQEMG;

	private Camera MEEKTRHQHJG;

	public event Action<EquipmentItemCell> ILMHKPSEPPO
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

	public void Setup(ItemWeapon TSRPFHOJKSG)
	{
	}

	public void SetPreview()
	{
	}

	public void PlayEquipAnimation(Vector3 NHLNKMPPTKR)
	{
	}

	public void PlayBounceAnim(float PRRKGRQILFR = 0f)
	{
	}

	public void ClearOnClickCustom()
	{
	}

	public void OnClick()
	{
	}

	public void SetEquipMode(bool THNTOHQGJIL)
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
	private void HOEGNFQSIMQ()
	{
	}

	[CompilerGenerated]
	private void IPFLIMPFHQF()
	{
	}

	[CompilerGenerated]
	private bool KKNMHHGKHNN(EquipmentItemCell HNLHQPIFJNS)
	{
		return false;
	}
}
