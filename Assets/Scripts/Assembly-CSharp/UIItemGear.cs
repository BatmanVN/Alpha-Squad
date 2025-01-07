using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIItemGear : MonoBehaviour
{
	[SerializeField]
	private Image gearIcon;

	[SerializeField]
	private Text labelCombatPower;

	[SerializeField]
	private Text labelCategory;

	[SerializeField]
	private Image background;

	[SerializeField]
	private GameObject lockIcon;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> backgroundSprites;

	[SerializeField]
	private Text labelUpgradeLevel;

	[SerializeField]
	private GameObject upgradeArrow;

	[SerializeField]
	public bool alwaysShowUpgrade;

	private GearData LTOPEKOFLSQ;

	private ItemGear KHTSOSFNLIR;

	private global::HIJIFHMGTTR<float> RJKELKFJJTM;

	public void Setup(ItemGear TSRPFHOJKSG)
	{
	}

	public Image GetBackground()
	{
		return null;
	}

	public void ForceHideLock()
	{
	}

	public void HideUpgrade()
	{
	}

	public Text GetLabelUpgradeLevel()
	{
		return null;
	}

	[CompilerGenerated]
	private bool IJNGRSPOEJL(JJHFPNTSRLT.RaritySprite HNLHQPIFJNS)
	{
		return false;
	}
}
