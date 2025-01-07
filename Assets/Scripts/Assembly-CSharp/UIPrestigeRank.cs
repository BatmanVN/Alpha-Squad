using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPrestigeRank : MonoBehaviour
{
	private static readonly int JOGTEKPITLS;

	private static readonly int SKIFTOGMGQN;

	private static readonly int NJPJSHFJENP;

	[SerializeField]
	private UIPrestigeRankReward rewardPrefab;

	[SerializeField]
	private Image rankIcon;

	[SerializeField]
	private Image rankLine;

	[SerializeField]
	private Text rankRequirement;

	[SerializeField]
	private Text rankName;

	[SerializeField]
	private GameObject rankRequirementObj;

	[SerializeField]
	private Transform rewardList;

	[SerializeField]
	private GameObject rankGlow;

	[SerializeField]
	private GameObject darkRankIcon;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private GameObject rankAnimatorObj;

	[SerializeField]
	private GameObject fireFliesEffect;

	private List<UIPrestigeRankReward> OPHQESJTOLF;

	private int QRKLQSRSHTJ;

	private PrestigeRank MORQHKNGRHK;

	public void Setup(int PSPJIJNTMOI, int IRGJMLSOQIM, PrestigeRank ORSGPHEJRPG, int HQHRSELQJMR)
	{
	}

	private void QSHPLRIQHMP(bool LKKOESPTGSK)
	{
	}

	public void ActivateNewRank()
	{
	}

	public void SetupIdleActive()
	{
	}

	public void SetupBeforeNew(int IRGJMLSOQIM)
	{
	}

	public void DisplayAsNew(int IRGJMLSOQIM)
	{
	}

	public int GetPrestigeRequirement(int IRGJMLSOQIM)
	{
		return 0;
	}

	public bool IsMilestoneFit(int IRGJMLSOQIM)
	{
		return false;
	}

	public float GetY(int IRGJMLSOQIM, bool HQLLGLEOSEE = false)
	{
		return 0f;
	}

	public int GetMaxMilestones()
	{
		return 0;
	}

	public UIPrestigeRankReward GetRankReward(int PSPJIJNTMOI)
	{
		return null;
	}
}
