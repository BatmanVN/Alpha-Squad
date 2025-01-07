using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ChestInfoPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class OMNLPGQRMSR
	{
		public ChestController.MFRETPOLGOE q;

		internal bool _003CSetupIcon_003Eb__0(JJHFPNTSRLT.QualityColor x)
		{
			return false;
		}

		internal bool _003CSetupIcon_003Eb__1(JJHFPNTSRLT.QualityColor x)
		{
			return false;
		}
	}

	[SerializeField]
	private FloatingErrorText prefabError;

	[Space]
	[SerializeField]
	private ChestInfoPopupBlockBasic blockBasic;

	[SerializeField]
	private ChestInfoPopupBlockBestDrop blockBestDrop;

	[SerializeField]
	private ChestInfoPopupBlockGuaranteed blockGuaranteed;

	[SerializeField]
	private ChestInfoPopupBlockCustomRifts blockCustomRifts;

	[SerializeField]
	private ChestInfoPopupBlockCustomClans blockCustomClans;

	[SerializeField]
	private ChestInfoPopupBlockButtons blockButtons;

	[SerializeField]
	private ChestInfoPopupBlockWeaponsOnly blockWeaponsOnly;

	[SerializeField]
	private ChestInfoPopupBlockRareReward blockRareReward;

	[Space]
	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private Image titleBackground;

	[SerializeField]
	private RectTransform chestIconRect;

	[SerializeField]
	private Image chestIcon;

	[SerializeField]
	private Image chestIconRaised;

	[SerializeField]
	private Image chestIconLarge;

	[SerializeField]
	private Image chestIconElitePass;

	[SerializeField]
	private Image chestBeams;

	[SerializeField]
	private Image chestGlow;

	[SerializeField]
	private GameObject separator;

	[SerializeField]
	private GameObject separatorChanceToGet;

	[SerializeField]
	private Text title;

	[SerializeField]
	private GameObject buttonDelete;

	[SerializeField]
	private GameObject fireFx;

	[SerializeField]
	private GameObject chestBeamsOrange;

	[SerializeField]
	private List<JJHFPNTSRLT.QualityColor> qualityColors;

	[SerializeField]
	private List<JJHFPNTSRLT.QualitySprite> titleBackgrounds;

	[SerializeField]
	private RectTransform layoutLoot;

	private bool SRHKFKFTLRE;

	private int RMOEOIFHNNE;

	private int SHNHTOMQIMT;

	private ChestController.ChestData LIEEKNMLQJJ;

	private ChestConfigData KHJJPFNLORJ;

	public static void Open(ChestController.ChestData OTSSKRRHTOO)
	{
	}

	public static void OpenGameplay(ChestController.ChestData OTSSKRRHTOO, bool FTSJTJLQTQS = false)
	{
	}

	public static void OpenPass(ChestController.ChestData OTSSKRRHTOO, ERLKIIFQKSI MNFRKQLOOLG = ERLKIIFQKSI.FREE)
	{
	}

	public static void OpenCustom(ChestController.ChestData IEHEOOQKSKK)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void OnDestroy()
	{
	}

	private void MLNESSGJRME(ChestController.ChestData OTSSKRRHTOO)
	{
	}

	private void MTPKFLGMOMM(ChestController.ChestData OTSSKRRHTOO, bool FTSJTJLQTQS)
	{
	}

	private void OESHLQRHNFK(ChestController.ChestData OTSSKRRHTOO, ERLKIIFQKSI MNFRKQLOOLG)
	{
	}

	private void FIKRFSFPOGK(ChestController.ChestData OTSSKRRHTOO)
	{
	}

	private void TRLIEKEFLKQ()
	{
	}

	private void LHOGRPGFFSJ(bool RLPQNMNOOIL = true)
	{
	}

	private void QROQLTGLKLK()
	{
	}

	private void PLJMOSIHFPS()
	{
	}

	private void QIRPNTFHILJ()
	{
	}

	private void MHKGMRGGGLI()
	{
	}

	public void OnOpenTimerEnd()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnSkipAdButton()
	{
	}

	public void OnStartOpeningButton()
	{
	}

	public void OnOpenNowButton()
	{
	}

	public void OnOpenNowVipButton()
	{
	}

	public void OnOpenButton()
	{
	}

	public void OnPurchaseButton()
	{
	}

	public void OnElitePassButton()
	{
	}

	public void OnElitePassPlusButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void KTPSOJFQHPT()
	{
	}

	private void LKEESIKQJJI()
	{
	}

	public void OnDeleteButton()
	{
	}

	public Button GetButtonOpenNow()
	{
		return null;
	}

	public Button GetButtonStart()
	{
		return null;
	}

	public ChestController.ChestData GetCurrentData()
	{
		return null;
	}

	[CompilerGenerated]
	private bool QTOOHIEPJMR(JJHFPNTSRLT.QualitySprite HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private bool FTNJOSHLITJ(JJHFPNTSRLT.QualitySprite HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private void JOOPTJPGQJH(bool SILMTFJJQIJ)
	{
	}

	[CompilerGenerated]
	private void RMPGNGQJPET()
	{
	}
}
