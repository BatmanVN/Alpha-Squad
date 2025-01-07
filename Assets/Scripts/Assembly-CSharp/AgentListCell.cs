using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AgentListCell : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class HOTFKGFJLNE
	{
		public JJHFPNTSRLT.PQRIQGIOGQT upgradeRarity;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[NonSerialized]
	public AgentListPage owner;

	[NonSerialized]
	public MenuAgentPanel agentPanel;

	[NonSerialized]
	public Agent agent;

	[SerializeField]
	private Text labelTitle;

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private Text labelCombatPower;

	[SerializeField]
	private Text labelProgress;

	[SerializeField]
	private Text labelUnlockReq;

	[SerializeField]
	private Text labelLocked;

	[SerializeField]
	private Text labelUpgrade;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image tagIcon;

	[SerializeField]
	private GameObject blockUpgradeInProgress;

	[SerializeField]
	private GameObject blockUpgradeAvailable;

	[SerializeField]
	private GameObject blockMaxUpgrade;

	[SerializeField]
	private GameObject lockedBlock;

	[SerializeField]
	private GameObject selectedMark;

	[SerializeField]
	private Image clickedMark;

	[SerializeField]
	private GameObject newBlock;

	[SerializeField]
	private GameObject readyToUnlockBlock;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> backgrounds;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Sprite progressBarFull;

	[SerializeField]
	private Sprite progressBarRegular;

	[SerializeField]
	private List<Image> grayScaledImages;

	private Material HSINNOQHLSF;

	private Material FNOJNMKINMT;

	private AgentData TSRPFHOJKSG;

	private bool TEILKPETLEJ;

	private bool RPPNORNQORR;

	private bool JJJLEJOHIMT;

	private float QIMNSEKQTTJ;

	public void Setup(Agent IFLMHEQTKLS)
	{
	}

	private void FRPOJISFGRG()
	{
	}

	private void NMMSIGHLELT()
	{
	}

	private Material SJKMNMSIPOI(Image TJJTKHEELIO)
	{
		return null;
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void OnClick()
	{
	}

	public void SetClicked(bool JJJLEJOHIMT, bool KQGHGPEKKTJ = true)
	{
	}

	public void UpdateSelected(bool KQGHGPEKKTJ = true)
	{
	}

	[CompilerGenerated]
	private bool QJKKFGNQITJ(EnhancementTier HNLHQPIFJNS)
	{
		return false;
	}
}
