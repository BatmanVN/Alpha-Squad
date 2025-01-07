using System;
using System.Collections.Generic;
using Pass;
using UnityEngine;

public class PassRewardList : MonoBehaviour
{
	[NonSerialized]
	public PassPanel owner;

	[SerializeField]
	private ERLKIIFQKSI listCategory;

	[Space]
	[SerializeField]
	private PassRewardCellCurrency prefabCurrency;

	[SerializeField]
	private PassRewardCellChest prefabChest;

	[SerializeField]
	private PassRewardCellSelectWeaponPart prefabSelectWeaponParts;

	[SerializeField]
	private PassRewardCellSelectWeaponScrap prefabSelectWeaponScrap;

	[SerializeField]
	private PassRewardCellSelectGearScrap prefabSelectGearScrap;

	[SerializeField]
	private PassRewardCellSelectFragment prefabSelectFragment;

	[SerializeField]
	private PassRewardCellWeapon prefabWeapon;

	[Space]
	[SerializeField]
	private RectTransform scrollContent;

	[SerializeField]
	private RectTransform scrollViewport;

	private List<PassRewardCell> PHTKEJTOQRG;

	public void Setup(List<PassData.PassReward> OPHQESJTOLF)
	{
	}

	private bool IFJSKOIJGJM(List<PassData.PassReward> OPHQESJTOLF)
	{
		return false;
	}

	public PassRewardCell GetFirstUnclaimedCell()
	{
		return null;
	}

	public List<int> GetAllUnclaimedCellIndices()
	{
		return null;
	}

	public List<PassRewardCell> GetCells()
	{
		return null;
	}
}
