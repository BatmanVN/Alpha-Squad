using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LootReceivedPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class KNJIFHITKJG
	{
		public float max;

		public int size;

		public float[] steps;

		public LootReceivedPopup _003C_003E4__this;

		internal void _003CSetupWithCollectAnimation_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class EJTKEFKIJLN
	{
		public long max;

		internal bool _003CSetupChest_003Eb__2(ChestController.ChestData x)
		{
			return false;
		}
	}

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[Space]
	[SerializeField]
	private AnimatedLabelText huntingAnimLabel;

	[SerializeField]
	private LayoutGameOver layoutCurrencies;

	[SerializeField]
	private LayoutGameOver layoutWeapons;

	[SerializeField]
	private RectTransform header;

	[SerializeField]
	private SlicedFilledImage progressBar;

	[SerializeField]
	private GameObject progressBarParent;

	[SerializeField]
	private Text chestTitle;

	[SerializeField]
	private Text chestLevel;

	[SerializeField]
	private Text chestOpenPrice;

	[SerializeField]
	private Text chestDiscountOpenPrice;

	[SerializeField]
	private Text chestDiscountOpenPriceOriginal;

	[SerializeField]
	private AdFetchSpinner openNowSpinner;

	[SerializeField]
	private GameObject chestBlock;

	[SerializeField]
	private GameObject chestNotReceivedWarn;

	[SerializeField]
	private Image chestIconImage;

	[SerializeField]
	private Material notReceivedMaterial;

	[SerializeField]
	private Button buttonOpenNow;

	[SerializeField]
	private Button buttonOpenNowDiscount;

	[SerializeField]
	private Button buttonOpenNowAd;

	[SerializeField]
	private Button buttonOpenNowVip;

	[SerializeField]
	private Button buttonChestInfo;

	[SerializeField]
	private Button buttonReplace;

	[SerializeField]
	private Button buttonNext;

	[SerializeField]
	private Text labelButtonNext;

	[SerializeField]
	private GameObject buttonBlock;

	[SerializeField]
	private Text labelTitle;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private GameObject blockXp;

	[SerializeField]
	private GameObject blockPassXp;

	[SerializeField]
	private Text labelXp;

	[SerializeField]
	private Text labelPassXp;

	private ChestController.ChestData SMPJFNFKISE;

	private bool SRHNOHTQTPP;

	private bool KEESKGLOEEM;

	private bool ENMGNPPHNRM;

	private static event Action PIPOOQNGMSF
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void MGKPMPHSLFR()
	{
	}

	public static void Open(DropController.DropsCollection JONGJFLGQHH, bool ENMGNPPHNRM = true, string OLPSGPIMEJE = null, Action QIJGQSKQHRG = null)
	{
	}

	public static void OpenWithAnimation(DropController.DropsCollection JONGJFLGQHH, bool ENMGNPPHNRM = true, string OLPSGPIMEJE = null, Action QIJGQSKQHRG = null)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public new void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	private void HJGPLSSNNHO()
	{
	}

	private void PGOEOFKLNPS(string OLPSGPIMEJE)
	{
	}

	private void OHEMLRRMNGR()
	{
	}

	private void PNERFLOJKKE(DropController.DropsCollection JONGJFLGQHH)
	{
	}

	private void Setup(DropController.DropsCollection JONGJFLGQHH)
	{
	}

	private void JPFIEJHGPOI(float PRRKGRQILFR)
	{
	}

	private void MHJFLERLFTL()
	{
	}

	private void PLFKNRKLPOT(float PQHJSKMSNOG = 0f)
	{
	}

	private void QSMRJKFGEQM(float PQHJSKMSNOG = 0f)
	{
	}

	private void QJNTGHHQSQL(float PRRKGRQILFR)
	{
	}

	public void OnOpenNowButton()
	{
	}

	public void OnOpenNowDiscountButton()
	{
	}

	public void OnOpenNowAdButton()
	{
	}

	public void OnOpenNowVipButton()
	{
	}

	public void OnInfoButton()
	{
	}

	public void OnReplaceButton()
	{
	}

	private void KTPSOJFQHPT()
	{
	}

	private void FMHJGQRLFOH()
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

	private void SGIQFQGTQTN(LootElement INNLJIGRFOG, float PRRKGRQILFR = 0f)
	{
	}

	private float JKROTEEQRRP(DropController.DropsCollection JONGJFLGQHH, float PRRKGRQILFR = 0f)
	{
		return 0f;
	}

	[CompilerGenerated]
	private void HELKKQMRHHR()
	{
	}

	[CompilerGenerated]
	private void KPGJKMQSLIH(bool SILMTFJJQIJ)
	{
	}

	[CompilerGenerated]
	private void QNRPNSNEHKH(ChestController.ChestData SOLRLPJRKGG)
	{
	}
}
