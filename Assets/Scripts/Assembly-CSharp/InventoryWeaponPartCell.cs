using UnityEngine;
using UnityEngine.UI;

public class InventoryWeaponPartCell : LootCell
{
	[SerializeField]
	private GameObject item;

	[SerializeField]
	private RectTransform meRect;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Text amountLabel;

	[SerializeField]
	private Text rarityLabel;

	private int KQLRLGQOIIS;

	[HideInInspector]
	public MenuViewInventory owner;

	[HideInInspector]
	public RectTransform scrollContent;

	[HideInInspector]
	public RectTransform scrollViewport;

	private JJHFPNTSRLT.WeaponPart TSRPFHOJKSG;

	private Camera NEJLPMJGEEJ;

	public void Setup(JJHFPNTSRLT.WeaponPart TSRPFHOJKSG, bool OQLMFONKIFE = false)
	{
	}

	private Camera RHTRRETOEIS()
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	private bool QSOSIKIIHIE()
	{
		return false;
	}

	public void OnClick()
	{
	}

	public override Image GetBackground()
	{
		return null;
	}

	public void HideAmount()
	{
	}

	public JJHFPNTSRLT.WeaponPartIdentifier GetWeaponPartIdentifier()
	{
		return default(JJHFPNTSRLT.WeaponPartIdentifier);
	}

	public JJHFPNTSRLT.WeaponPart GetWeaponPart()
	{
		return default(JJHFPNTSRLT.WeaponPart);
	}
}
