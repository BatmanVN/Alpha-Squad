using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIItemWeapon : MonoBehaviour
{
	[Serializable]
	public struct RaritySprite
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public Sprite sprite;
	}

	[SerializeField]
	private GameObject prefabRankReached;

	[SerializeField]
	private GameObject prefabRankNotReached;

	[Space]
	[SerializeField]
	private RectTransform weaponFitRect;

	[SerializeField]
	private Text combatPowerLabel;

	[SerializeField]
	private Text itemLevelLabel;

	[SerializeField]
	private Text progressLabel;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Shader stencilShader;

	[SerializeField]
	private GameObject maxUpgradeView;

	[SerializeField]
	private GameObject maxUpgradePrefab;

	[SerializeField]
	private Image lockIcon;

	[SerializeField]
	private Image upgradeIcon;

	[SerializeField]
	private RectTransform weaponRankParent;

	[SerializeField]
	private RectTransform empowerIcon;

	[SerializeField]
	private List<RaritySprite> backgroundSprites;

	[SerializeField]
	private Sprite backgroundLegendary;

	[SerializeField]
	private Sprite arrowRegular;

	[SerializeField]
	private Sprite arrowRank;

	[SerializeField]
	private Sprite arrowLimitBreak;

	[SerializeField]
	private Sprite arrowEmpower;

	[SerializeField]
	public bool alwaysShowUpgrade;

	private WeaponData NHQFORNOPMI;

	private ItemWeapon PLTFGIJEPEI;

	private global::HIJIFHMGTTR<float> RJKELKFJJTM;

	public void Setup(ItemWeapon TSRPFHOJKSG)
	{
	}

	private void OHSFNQOKGHQ()
	{
	}

	public Image GetBackground()
	{
		return null;
	}

	public void HideUpgrade()
	{
	}

	[CompilerGenerated]
	private bool SGSQPLQITOK(RaritySprite QHSMPFPKNMM)
	{
		return false;
	}
}
