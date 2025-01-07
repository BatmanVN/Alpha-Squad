using UnityEngine;
using UnityEngine.UI;

public class ClanShopCardCellVisual : CardCellVisual
{
	[SerializeField]
	private GameObject randomShards;

	[SerializeField]
	private GameObject randomPart;

	[SerializeField]
	private GameObject randomScrap;

	[SerializeField]
	private GameObject selectionPart;

	[SerializeField]
	private Image weaponSelectionPartBg;

	[SerializeField]
	private Text randomItemCount;

	[SerializeField]
	public Text selectedWeaponPartLabel;

	public void Setup(LootIdentifier KNPQOIKEPKI, bool PQPGFQQNQKQ, bool ENENSKEJPNL = false)
	{
	}

	protected override void ILKNMFOIFFN()
	{
	}

	public GameObject GetRandomItemCountGO()
	{
		return null;
	}
}
