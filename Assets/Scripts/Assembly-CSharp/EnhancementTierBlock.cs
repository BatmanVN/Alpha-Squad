using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EnhancementTierBlock : MonoBehaviour
{
	[SerializeField]
	private EnhancementCell prefabEnhancementCell;

	[SerializeField]
	private Text labelTier;

	[SerializeField]
	private Image imageRarity;

	[SerializeField]
	private RectTransform enhancementCellParent;

	[Space]
	[SerializeField]
	private GameObject borderLeft;

	[SerializeField]
	private GameObject borderRight;

	[SerializeField]
	private GameObject commingSoon;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[Space]
	[SerializeField]
	private GameObject powerBlock;

	[SerializeField]
	private GameObject powerAvailForUpgrade;

	[SerializeField]
	private GameObject powerRegular;

	[SerializeField]
	private GameObject powerMax;

	[SerializeField]
	private Text labelPower;

	[SerializeField]
	private Color colorPowerMax;

	[SerializeField]
	private Color colorPowerRegular;

	[SerializeField]
	private Color colorPowerUpgrade;

	[NonSerialized]
	public EnhancementList owner;

	private List<EnhancementCell> PHTKEJTOQRG;

	private int SGETIPNGTPQ;

	private Agent IFLMHEQTKLS;

	private bool TEILKPETLEJ;

	public void Setup(EnhancementTier FOQIJNNSRNI, EnhancementSelection PQPGFQQNQKQ, Agent IFLMHEQTKLS, int ITHFMKSKFQP, bool TEILKPETLEJ)
	{
	}

	public void UpdateTier(EnhancementTier FOQIJNNSRNI, EnhancementSelection PQPGFQQNQKQ, Agent IFLMHEQTKLS, int ITHFMKSKFQP, bool TEILKPETLEJ)
	{
	}

	private void TGFONEKIPEQ(EnhancementTier FOQIJNNSRNI, EnhancementSelection PQPGFQQNQKQ, int ITHFMKSKFQP)
	{
	}

	public RRMFSKNJIOH GetAgentId()
	{
		return default(RRMFSKNJIOH);
	}

	public Agent GetAgent()
	{
		return null;
	}

	public void OnSelect(EnhancementCell LHGGIGRRKEQ)
	{
	}

	public void SetCommingSoon(bool JEQNIHFNEKI = true)
	{
	}

	public bool IsUnselectedAndAvailable()
	{
		return false;
	}

	public EnhancementCell GetSelectedCell()
	{
		return null;
	}

	public List<EnhancementCell> GetCells()
	{
		return null;
	}

	public void OnClick()
	{
	}

	[CompilerGenerated]
	private void GTKJINNIEOL()
	{
	}
}
