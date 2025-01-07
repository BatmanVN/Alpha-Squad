using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RaidStartPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class LPOQORGNPFK
	{
		public int price;

		public RaidStartPopup _003C_003E4__this;

		internal void _003COnStartButton_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class JPMKOTRLLOL
	{
		public ChestController.MFRETPOLGOE testQ;

		internal bool _003CInitChestValues_003Eb__1(JJHFPNTSRLT.ChestQualityNumber x)
		{
			return false;
		}

		internal bool _003CInitChestValues_003Eb__2(JJHFPNTSRLT.ChestQualityNumber x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class OJEMEOTPRMR
	{
		public bool with_animation;

		public float t;

		public RaidStartPopup _003C_003E4__this;

		internal void _003CUpdateFill_003Eb__1(float x)
		{
		}

		internal void _003CUpdateFill_003Eb__2(float x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class NHROEOLQEOT
	{
		public RaidController.Config.Difficulty cfg;

		internal bool _003CUpdateRaidDisplay_003Eb__0(JJHFPNTSRLT.RaidDifficultyColor e)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class POJJRGKINIP
	{
		public RaidStartPopup _003C_003E4__this;

		public Utils.IntervaledLogic vpLogic;

		internal void _003COnFreePlayButton_003Eb__1(bool ok)
		{
		}
	}

	[SerializeField]
	private FloatingErrorText prefabFloatingErrorText;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private Button buttonLeft;

	[SerializeField]
	private Button buttonRight;

	[SerializeField]
	private Text raidTitle;

	[SerializeField]
	private Text raidRecommendedCp;

	[SerializeField]
	private GameObject skull;

	[SerializeField]
	private Image raidBlockBg;

	[SerializeField]
	private List<JJHFPNTSRLT.RaidDifficultyColor> raidDifficultyColors;

	[SerializeField]
	private Button startButton;

	[SerializeField]
	private GameObject noSlotsBlock;

	[SerializeField]
	private SlicedFilledImage cashFillOver;

	[SerializeField]
	private SlicedFilledImage cashFillUnder;

	[SerializeField]
	private SlicedFilledImage weaponFillOver;

	[SerializeField]
	private SlicedFilledImage weaponFillUnder;

	[SerializeField]
	private Text labelGunDropChance;

	[SerializeField]
	private Text labelCashDropChance;

	[SerializeField]
	private CanvasGroup overlayNoCashDrop;

	[SerializeField]
	private SplitBar bar;

	[SerializeField]
	private Text labelChestLevel;

	[SerializeField]
	private Text labelItemLevel;

	[SerializeField]
	private Image backgroundChestLevel;

	[SerializeField]
	private GameObject backgroundRegular;

	[SerializeField]
	private GameObject backgroundBoosted;

	[SerializeField]
	private Color chestLabelBgRegular;

	[SerializeField]
	private Color chestLabelBgBoosted;

	[SerializeField]
	private GameObject glowChestBar;

	[SerializeField]
	private Text[] labelChances;

	[SerializeField]
	private GameObject paidBlockRaid;

	[SerializeField]
	private GameObject freeBlockRaid;

	[SerializeField]
	private Text labelPriceRaid;

	[SerializeField]
	private Toggle toggleBooster;

	[SerializeField]
	private Toggle toggleAuto;

	[SerializeField]
	private Toggle togglInstantChest;

	[SerializeField]
	private GameObject tutorialBubbleAutoComplete;

	[SerializeField]
	private GameObject blockFreePlay;

	[SerializeField]
	private GameObject timerBlockFreePlay;

	[SerializeField]
	private UITextTimer timerFreePlay;

	[SerializeField]
	private Text labelFreePlayDifficultyName;

	[SerializeField]
	private GameObject buttonFreePlayEnabled;

	[SerializeField]
	private GameObject buttonFreePlayEnabledVip;

	[SerializeField]
	private GameObject buttonFreePlayDisabled;

	[SerializeField]
	private GameObject buttonFreePlayDisabledVip;

	[SerializeField]
	private GameObject ribbonVipActive;

	[SerializeField]
	private GameObject ribbonVipInactive;

	[SerializeField]
	private AdFetchSpinner spinnerFreePlay;

	private bool IJPKRTSJGMF;

	private bool SRHFJHNRHPG;

	private bool KEESKGLOEEM;

	private bool LSOFPFNIJNF;

	private bool OPKKMFMQJEI;

	private int QESOPJNKQHH;

	private int GHGHEEKFOLK;

	private int TGTNPTKTHLM;

	private bool QLGTNNFLSFH;

	private float PPQJGHTGOEF;

	private const float JRSPPIRIKIQ = 0.75f;

	protected override void MGKPMPHSLFR()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	public override void OnAddedToPopupQueue()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnInfoButton()
	{
	}

	public void OnStartButton()
	{
	}

	public void OnClickChest(int IIEQQEKOHKF)
	{
	}

	private void JTQMIPSSGFG()
	{
	}

	public void Test(int NJOGQJTFPKQ)
	{
	}

	private void SSENKKGPLEO()
	{
	}

	private void NFQNFPPEGQM(bool KQGHGPEKKTJ = true)
	{
	}

	private void IJPLLFMHSFL()
	{
	}

	public void OnToggleBooster(bool LKKOESPTGSK)
	{
	}

	public void OnToggleAutoClear(bool LKKOESPTGSK)
	{
	}

	public void OnToggleInstantChest(bool LKKOESPTGSK)
	{
	}

	public void OnCloseAutoClearTutorialButton()
	{
	}

	public void OnButtonLeft()
	{
	}

	public void OnButtonRight()
	{
	}

	private void KMQIMTNTOMN(Transform HSSNSPQEIGR, string HETQTIKJGNI, bool FNEHITKNEGR = true)
	{
	}

	private void GRLTOMSIKOL()
	{
	}

	private void RQKFERMHFFP()
	{
	}

	private void KKOKFLPGMIO(bool KQGHGPEKKTJ = true)
	{
	}

	private bool QTTKLIRTKFM()
	{
		return false;
	}

	private int OHGOENIITJT()
	{
		return 0;
	}

	private string EQTOGTQSJMR()
	{
		return null;
	}

	private void SLMITISHHOE(bool KQGHGPEKKTJ = true)
	{
	}

	private void HRPJMIPJQPP()
	{
	}

	public void OnFreePlayButton()
	{
	}

	public void OnVipButton()
	{
	}

	public void OnFreePlayTimerEnded()
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	private bool ETEGJMSNPOE()
	{
		return false;
	}

	private void TEJNOGSNTOQ()
	{
	}

	private void KLJLLJMSFSK()
	{
	}

	private void OnApplicationQuit()
	{
	}

	[CompilerGenerated]
	private void ETTKSRPQJFQ()
	{
	}

	[CompilerGenerated]
	private void RFMOFEIFSFH()
	{
	}

	[CompilerGenerated]
	private void REOTLNETFLR()
	{
	}
}
