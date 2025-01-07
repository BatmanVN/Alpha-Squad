using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class VipPopup : UIPopup
{
	[SerializeField]
	private VipCell prefabVipCell;

	[Space]
	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private Text labelPriceMonthGreen;

	[SerializeField]
	private Text labelPriceMonthOrange;

	[SerializeField]
	private Text labelPriceYear;

	[SerializeField]
	private Text labelPriceWeek;

	[SerializeField]
	private Text labelTickets;

	[SerializeField]
	private Text labelHammers;

	[SerializeField]
	private Text labelWeekDays;

	[SerializeField]
	private Text labelMonthDaysGreen;

	[SerializeField]
	private Text labelMonthDaysOrange;

	[SerializeField]
	private Text labelYearDays;

	[SerializeField]
	private Text labelActiveTrial;

	[SerializeField]
	private GameObject blockTrial;

	[SerializeField]
	private GameObject weekDiscountBlock;

	[SerializeField]
	private GameObject activeBlock;

	[SerializeField]
	private GameObject buttonBlock;

	[SerializeField]
	private UITextTimer activeTimer;

	[SerializeField]
	private UITextTimer activeTimerTrial;

	[SerializeField]
	private GameObject weekPassButton;

	[SerializeField]
	private GameObject monthPassButtonGreen;

	[SerializeField]
	private GameObject monthPassButtonOrange;

	[SerializeField]
	private GameObject yearPassButton;

	[SerializeField]
	private GameObject vipActiveBlock;

	[SerializeField]
	private GameObject vipInactiveBlock;

	[SerializeField]
	private Transform skinRewardParent;

	[SerializeField]
	private GameObject skinProgressBar;

	[SerializeField]
	private Image skinProgressBarFill;

	[SerializeField]
	private Image skinProgressBarFillCollected;

	[SerializeField]
	private Text totalDaysLabel;

	[SerializeField]
	private ScrollRectEx scroll;

	[SerializeField]
	private RectTransform rewardLayoutParent;

	[SerializeField]
	private GameObject backgroundRewardsLarge;

	[SerializeField]
	private GameObject backgroundRewardsSmall;

	[SerializeField]
	private GameObject blockVipEnded;

	[SerializeField]
	private RectTransform backgroundBot;

	[SerializeField]
	private GameObject fadeLarge;

	[SerializeField]
	private GameObject fadeSmall;

	[Space]
	[SerializeField]
	private GameObject vipInactiveCompletely;

	[SerializeField]
	private VipPopupAnimationController animController;

	[SerializeField]
	private ScrollRectStepped infoScroll;

	[SerializeField]
	private RectTransform pagesParent;

	[SerializeField]
	private VipPopupActiveCharacterController vipPopupActiveCharacterController;

	[SerializeField]
	[Space]
	private GameObject weekSpecialDiscountBlock;

	[SerializeField]
	private GameObject monthDiscountBlockGreen;

	[SerializeField]
	private GameObject monthDiscountBlockOrange;

	[SerializeField]
	private GameObject yearDiscountBlock;

	[SerializeField]
	private Text labelPriceWeekOld;

	[SerializeField]
	private Text labelMonthSpecialOldGreen;

	[SerializeField]
	private Text labelMonthSpecialOldOrange;

	[SerializeField]
	private Text labelYearSpecialOld;

	[SerializeField]
	private Text labelWeekDiscount;

	[SerializeField]
	private Text labelYearDiscount;

	[SerializeField]
	private Text labelMonthOrangeDiscount;

	[SerializeField]
	private Text labelMonthGreenDiscount;

	private Tween EPHOSPIPHKH;

	private bool SQTHPKJOTGP;

	private string TLIGKLMGSSN;

	private string NHQIJHMNELM;

	private string NFSIFRFJOJI;

	private string HSGHJNHLOLE;

	private string FOQJLPNHTRS;

	private string LIOMMKFQMRS;

	private static string KGPINPGKPOI;

	public static void Open(bool SQTHPKJOTGP = false)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void NGHFQRREIJN()
	{
	}

	private void KJGNLRHMMNJ()
	{
	}

	private void GKSHQSHHHRO()
	{
	}

	private void PLTOJPEQGPI(bool MJSHMKKISJN)
	{
	}

	public override void OnShowFinished()
	{
	}

	private void LKMETKOLOTO()
	{
	}

	private void JFKQLJMMEJT()
	{
	}

	private void PEPSSSGEKKO()
	{
	}

	private (string, decimal) ITQLRISSKLL(string JSRRSEOKONO)
	{
		return default((string, decimal));
	}

	private void NQQITPEPGHL()
	{
	}

	private void HSGFKJFKNFF()
	{
	}

	private void QONQRGHQPRK()
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	public virtual void OnEnable()
	{
	}

	public virtual void OnDisable()
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnBuyWeek()
	{
	}

	public void OnBuyMonth()
	{
	}

	public void OnBuyYear()
	{
	}

	private void TLPTIKOHLSL()
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	public void OnTimerEnded()
	{
	}

	public void OnPreviewPageChange(int FIPHTRRRPET)
	{
	}

	[CompilerGenerated]
	internal static void RSIRPEEITJI(int TEGLFRQPILF, int GNONLPPKHMN, int NHJLNIHMJRG, int LPEJMHJFKMK, Image KNKGHPLHORM)
	{
	}

	[CompilerGenerated]
	private void QLILRINLERT(bool SILMTFJJQIJ)
	{
	}

	[CompilerGenerated]
	private void JHQHOGPMFPE(bool SILMTFJJQIJ)
	{
	}

	[CompilerGenerated]
	private void FQSOIHEMIEL(bool SILMTFJJQIJ)
	{
	}
}
