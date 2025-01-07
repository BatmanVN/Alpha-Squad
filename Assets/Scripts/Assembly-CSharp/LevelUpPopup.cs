using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class MJKHRMQTLMO
	{
		public LevelUpPopup popup;

		internal void _003COpenWhenAvailable_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct RSEITFOGKLP
	{
		public TMRSFTIETMS pp;

		public int lvl;
	}

	[SerializeField]
	private Text labelTitle;

	[SerializeField]
	private Text levelLabel;

	[SerializeField]
	private GameObject viewRegular;

	[SerializeField]
	private PlayerPathRewardCell playerPathCellFree;

	[SerializeField]
	private PlayerPathRewardCell playerPathCellPaid;

	[SerializeField]
	private PlayerPathRewardCell playerPathCellPremium;

	[SerializeField]
	private GameObject playerPathBlockFree;

	[SerializeField]
	private GameObject playerPathBlockPaid;

	[SerializeField]
	private GameObject playerPathBlockPremium;

	[SerializeField]
	private GameObject playerPathBlock;

	[SerializeField]
	private GameObject operationRewardBlock;

	[SerializeField]
	private GameObject expeditionRewardBlock;

	[SerializeField]
	private GameObject raidRewardBlock;

	[SerializeField]
	private GameObject shopDailyRewardBlock;

	[SerializeField]
	private GameObject workshopBlock;

	[SerializeField]
	private GameObject skirmishBlock;

	[SerializeField]
	private GameObject riftsBlock;

	[SerializeField]
	private GameObject baseBlock;

	[SerializeField]
	private GameObject weeklyContractsBlock;

	[SerializeField]
	private GameObject clansBlock;

	[SerializeField]
	private GameObject weeklyContractsCoinIncreaseBlock;

	[SerializeField]
	private Text labelWeeklyContractsCoinAmountOld;

	[SerializeField]
	private Text labelWeeklyContractsCoinAmountNew;

	[Space]
	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform buttonParent;

	[SerializeField]
	private Button buttonClose;

	[SerializeField]
	private Button buttonBackground;

	[SerializeField]
	private Button buttonOk;

	[SerializeField]
	private Button buttonGoRaid;

	[SerializeField]
	private Button buttonGoOperations;

	[SerializeField]
	private Button buttonGoExpeditions;

	[SerializeField]
	private Button buttonGoWorkshop;

	[SerializeField]
	private Button buttonGoSkirmish;

	[SerializeField]
	private Button buttonGoRifts;

	[SerializeField]
	private Button buttonGoClans;

	[SerializeField]
	private Button buttonGoBase;

	[SerializeField]
	private Button buttonGoContracts;

	[SerializeField]
	private Button buttonPlayerPath;

	[SerializeField]
	private GameObject fingerPlayerPath;

	[SerializeField]
	private GameObject viewTransition;

	[SerializeField]
	private Text labelTransitionOld;

	[SerializeField]
	private Text labelTransitionNew;

	[SerializeField]
	private GameObject buttonTransitionOk;

	[SerializeField]
	private GameObject spinnerTransitionOk;

	private static bool LLSREIQIHEO;

	private static int RIISGRJTERO;

	private Tween GMGSSTNNRNG;

	private static int GOHJGLKFRMP;

	private int NNIJHPRPMOO;

	private bool RSQHPQRQPFG;

	private static bool NFOKOMLKTEN(int HGMTRFFSLTJ)
	{
		return false;
	}

	public static bool OpenWhenAvailable(int HGMTRFFSLTJ)
	{
		return false;
	}

	public static void SetShowTransition(int OGFKHSKTHHR)
	{
	}

	protected override void MGKPMPHSLFR()
	{
	}

	public override void OnRemove()
	{
	}

	private void FGPNPGKKHOL()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void Setup(int GPRETGRLJII)
	{
	}

	private void IMQKGFNFIQL()
	{
	}

	private void GLTGEIFOTJF()
	{
	}

	private void GTLSFKSSLFE(int NNIJHPRPMOO)
	{
	}

	private void TTMLHFHJSQQ()
	{
	}

	private bool LQHJTLTILOE(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool QNMRJLLGPKR(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool PGITONJILPF(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool HQHOFRQRESI(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool FQTGSGSIQQG(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool FPMTSSHTNHF(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool IFLGEQJTOKQ(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool FNOQQGHPFIF(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool ESFIILLFNRK(int NNIJHPRPMOO)
	{
		return false;
	}

	private bool TILQJJKGGLF(int NNIJHPRPMOO)
	{
		return false;
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnExitButton()
	{
	}

	public void OnGoOperationsButton()
	{
	}

	public void OnGoExpeditionsButton()
	{
	}

	public void OnGoWorkshopButton()
	{
	}

	public void OnGoSkirmishButton()
	{
	}

	public void OnGoRiftsButton()
	{
	}

	public void OnGoClansButton()
	{
	}

	public void OnGoContractsButton()
	{
	}

	public void OnPlayerPathButton()
	{
	}

	public void OnGoRaidButton()
	{
	}

	public void OnButtonTransitionOk()
	{
	}

	public void OnFreePlayerPathCellClick()
	{
	}

	public void OnPaidPlayerPathCellClick()
	{
	}

	public void OnPremiumPlayerPathCellClick()
	{
	}

	[CompilerGenerated]
	private void PHPPHKRLRIK()
	{
	}

	[CompilerGenerated]
	internal static void IEGMSIEPLHP(PlayerPathRewardCell GGOKJRGSMRT, TMRSFTIETMS.EEPIMQTNTOF OSOHKTSGQFR, ref RSEITFOGKLP P_2)
	{
	}
}
