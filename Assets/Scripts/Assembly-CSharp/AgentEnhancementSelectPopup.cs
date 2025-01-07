using System;
using UnityEngine;
using UnityEngine.UI;

public class AgentEnhancementSelectPopup : UIPopup
{
	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private EnhancementInfoBlock prefabEnhancement;

	[SerializeField]
	private GameObject particlesEnhancementSelect;

	[SerializeField]
	private GameObject prefabSeparator;

	[SerializeField]
	private Text labelPopupTitle;

	[SerializeField]
	private RectTransform parentEnhancements;

	[SerializeField]
	private GameObject blockLocked;

	[SerializeField]
	private GameObject blockUpgrade;

	[Space]
	[SerializeField]
	private UICurrencyElement priceIconShards;

	[SerializeField]
	private Text labelPriceShards;

	[SerializeField]
	private Text labelPriceCash;

	[Space]
	[SerializeField]
	private Image fillLevelProgress;

	[SerializeField]
	private Image levelProgress;

	[SerializeField]
	private Text labelLevelProgress;

	[Space]
	[SerializeField]
	private Text labelAgentLvlRequired;

	[SerializeField]
	private GameObject blockUpgradeRequirement;

	[SerializeField]
	private GameObject blockUpgradeButton;

	[SerializeField]
	private GameObject blockUpgradeLvlLocked;

	[SerializeField]
	private GameObject blockMaxLvlReached;

	[Space]
	[SerializeField]
	private Sprite spriteBarMaxLvl;

	[SerializeField]
	private Sprite spriteBarRegular;

	[SerializeField]
	private Transform particleParent;

	private Action TQQLMEHRHGJ;

	private Enhancement OGIRJNESNLO;

	private bool TEILKPETLEJ;

	private Agent IFLMHEQTKLS;

	private int FOQIJNNSRNI;

	private LootElement SFOTOJMGNPJ;

	private LootElement LLSKJHLPENS;

	private EnhancementInfoBlock QPSMMTJSFGQ;

	public static void Open(int FOQIJNNSRNI, Agent IFLMHEQTKLS, Action TQQLMEHRHGJ)
	{
	}

	public static void OpenPreviewSingle(Enhancement JPEEEILROQN, Agent IFLMHEQTKLS, int EESQJISERQF, int NIQHMTPRKPJ, bool KRKRSKOGSRP = false)
	{
	}

	private void NGHFQRREIJN(int JFHKHTINNMG, Agent QPRRRRQOSNR, bool KQGHGPEKKTJ = false, bool LEISGNHIEPT = true)
	{
	}

	private void MFQNQFIRQIJ(Enhancement HSHHNFSEMKS, Agent QPRRRRQOSNR, int EESQJISERQF, int NIQHMTPRKPJ, bool LEISGNHIEPT = true)
	{
	}

	public void OnSelectButton(EnhancementInfoBlock QIMGEOQLLHO)
	{
	}

	public void OnUpgradeButton()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnClickShards()
	{
	}

	public void OnClickCash()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}
}
