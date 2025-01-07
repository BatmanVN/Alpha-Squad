using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class UIClanDonatePanel : UIPanel
{
	public static Action OnDonated;

	[SerializeField]
	private SlicedFilledImage progression;

	[SerializeField]
	private Text progressionValuesText;

	[SerializeField]
	private GameObject progressionObj;

	[SerializeField]
	private GameObject timerObj;

	[SerializeField]
	private GameObject chestObj;

	[SerializeField]
	private GameObject coinsObj;

	[SerializeField]
	private GameObject debugObj;

	[SerializeField]
	private GameObject claimStateObj;

	[SerializeField]
	private GameObject claimedStateObj;

	[SerializeField]
	private GameObject doneStateObj;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private GameObject rewardCounter;

	[SerializeField]
	private Text rewardCounterText;

	[SerializeField]
	private UITextTimer resetTimer;

	[SerializeField]
	private GameObject donationEffect;

	[SerializeField]
	private DonationPanelBlock cashDonationBlock;

	[SerializeField]
	private DonationPanelBlock gemDonationBlock;

	[SerializeField]
	private DonationPanelBlock inappDonationBlock;

	[SerializeField]
	private ClanBoothKeeper boothKeeper;

	[SerializeField]
	private Text yourTotal;

	[SerializeField]
	private Text yourWeek;

	[SerializeField]
	private SoundEffect donateSound;

	[SerializeField]
	private Image[] chests;

	private EOQPNKSSOTM.Reward FILOKRMHOJJ;

	private int KTFHHKQSOTN;

	private int JOONNQONGPQ => 0;

	private void NGHFQRREIJN()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void EOJIOOPPMQM()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private int ESQRRPLKQFT()
	{
		return 0;
	}

	public int GetTierWithFreeTicket()
	{
		return 0;
	}

	private int HPIQEITRETO()
	{
		return 0;
	}

	private void JJPNTSINTFS()
	{
	}

	public void OnBack()
	{
	}

	public void ResetObjs()
	{
	}

	private void RIRTENTOTGF()
	{
	}

	public void SetClaim()
	{
	}

	public void SetProgress()
	{
	}

	public void SetClaimed()
	{
	}

	public void SetFinished()
	{
	}

	private bool IITROSSKPHE()
	{
		return false;
	}

	private void SJOIOOLRHPF()
	{
	}

	private void QSNREOIHSFM()
	{
	}

	private void ENLIPTPKHOS(int FOQIJNNSRNI)
	{
	}

	private void GQSPFGPLSOM()
	{
	}

	private void OLLTRKFOKMG()
	{
	}

	private void OJKOMSRTJKN()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnChest()
	{
	}

	public void OnCoin()
	{
	}

	public void OnClaim()
	{
	}

	private void ORMRLEPTNGG()
	{
	}

	private void TIIROFLFHLT()
	{
	}

	private ChestController.ChestData EHKORHTMKPO(int FOQIJNNSRNI)
	{
		return null;
	}

	public override void OnShowFinished()
	{
	}

	public void OnDonateButton(bool TPTKFISFNGT)
	{
	}

	private void RKRNIGJIKTE(bool TPTKFISFNGT, int ISLTSKEPJPI = 1, bool RLPMQOHHTTR = false, bool TJTFEONRIIM = false)
	{
	}

	private Task PIOPIQRPLMM(bool TPTKFISFNGT, int ISLTSKEPJPI, bool RLPMQOHHTTR, bool TJTFEONRIIM)
	{
		return null;
	}

	public void OnDonateInappButton()
	{
	}

	private void HELHOKIILMG(bool SILMTFJJQIJ)
	{
	}

	public Task TryToPurchaseInappTicket(Product QFLHGLLPPNR)
	{
		return null;
	}

	private void FPNKNNRGTFF(int FOQIJNNSRNI)
	{
	}

	private Task<bool> OLRELJLGSKO(Product QFLHGLLPPNR, int FOQIJNNSRNI)
	{
		return null;
	}

	private Task NPMMPQHKFJP(int FOQIJNNSRNI)
	{
		return null;
	}

	public static string GetDonationInappForTier(int FOQIJNNSRNI)
	{
		return null;
	}

	public static int GetDonationInappTierForPurchaseId(string HSLQJLPMLMH)
	{
		return 0;
	}

	private static Task GTSMNSPJKSI()
	{
		return null;
	}

	private void SOJKGGNTJQI()
	{
	}

	private static void PNKJLSJPRTM(int SHGFSNPSSQM, int JIFITFGSIML, DonationPanelBlock QIMGEOQLLHO, EOQPNKSSOTM.DonationConfig SOSLGOOOIPG, int PKJFIIQOTMK = 1)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	public void DebugOnResetDonations()
	{
	}

	public void DebugOnResetWeek()
	{
	}

	public void DebugDonateAllRemaining(bool TPTKFISFNGT)
	{
	}

	public void DebugCrazyDonations(bool TJTFEONRIIM)
	{
	}

	private void FNTJORFTLOL()
	{
	}

	[CompilerGenerated]
	internal static void RJTPSJRMSPM(bool TPTKFISFNGT)
	{
	}
}
