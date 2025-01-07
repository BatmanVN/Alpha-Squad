using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class PassPanel : UIPanel
{
	[CompilerGenerated]
	private sealed class OHGFOGOHMLO
	{
		public Transform tr;

		public PassPanel _003C_003E4__this;

		internal void _003CAutoScroll_003Eb__2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class GOOKQJFHRNJ
	{
		public PassPanel _003C_003E4__this;

		public RectTransform rt;

		public Action onEndCallback;

		public float delay;

		public float time;

		internal void _003CScrollToRect_003Eb__0()
		{
		}

		internal void _003CScrollToRect_003Eb__1()
		{
		}
	}

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[SerializeField]
	public GameObject claimFree;

	[SerializeField]
	public GameObject claimPaid;

	[SerializeField]
	public GameObject progressBlock;

	[SerializeField]
	public GameObject completedBlock;

	[SerializeField]
	private GameObject prefabUnlockedAnim;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private HorizontalLayoutGroup listParent;

	[SerializeField]
	private PassRewardList listPaid;

	[SerializeField]
	private PassRewardList listFree;

	[SerializeField]
	private PassRewardList listPremium;

	[SerializeField]
	private float spacingListsTwo;

	[SerializeField]
	private float spacingListsThree;

	[SerializeField]
	private GameObject buyButtonTwo;

	[SerializeField]
	private GameObject buyButtonCompletedTwo;

	[SerializeField]
	private GameObject buyButtonThree;

	[SerializeField]
	private GameObject buyButtonCompletedThree;

	[SerializeField]
	private GameObject buyButtonFinalThree;

	[SerializeField]
	private GameObject premiumButtonThree;

	[SerializeField]
	private GameObject premiumButtonCompletedThree;

	[SerializeField]
	private GameObject premiumButtonFinalThree;

	[SerializeField]
	private CanvasGroup buttonBuyAfterPurchaseDouble;

	[SerializeField]
	private CanvasGroup buttonBuyAfterPurchaseTriple;

	[SerializeField]
	private GameObject titlesDouble;

	[SerializeField]
	private GameObject titlesTriple;

	[SerializeField]
	private PassLevelList listLevels;

	[SerializeField]
	private ScrollRectEx scroll;

	[SerializeField]
	private RectTransform separatorParent;

	[SerializeField]
	private GameObject separatorRegular;

	[SerializeField]
	private GameObject separatorLocked;

	[SerializeField]
	private GameObject separatorOverLock;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private Text labelTitle;

	[SerializeField]
	private Text labelSeason;

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private SlicedFilledImage fillLevel;

	[SerializeField]
	private Text labelFill;

	[SerializeField]
	private UITextTimer timer;

	[SerializeField]
	private Image seasonIcon;

	[SerializeField]
	private Image seasonBackground;

	[SerializeField]
	private Image seasonGlow;

	[SerializeField]
	private Image beams;

	[SerializeField]
	private PassPanelHighlightBlock highlightBlock;

	[SerializeField]
	private CircleClock circleClock;

	[SerializeField]
	private GameObject blockSkipLarge;

	[SerializeField]
	private GameObject blockSkipSmallElite;

	[SerializeField]
	private GameObject blockSkipSmallPremium;

	[SerializeField]
	private Text labelPriceFinalSkipBoth;

	[SerializeField]
	private Text labelPriceFinalSkipElite;

	[SerializeField]
	private Text labelPriceFinalSkipPremium;

	private static bool PSPMGLJTOST;

	private GameObject HPSNIFEMQQQ;

	private bool KPROOENSLNS;

	protected override void MGKPMPHSLFR()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public void SetupAll()
	{
	}

	private void IEGHKEHQKEP()
	{
	}

	private void OJPNJOQMELL()
	{
	}

	private void PLTOJPEQGPI()
	{
	}

	private void ENRFOOQETLS()
	{
	}

	private void KIGFRSJTQQK()
	{
	}

	private void PJOSNHMSNNS()
	{
	}

	public void ScrollToRect(RectTransform LJIOGPNTJPN, Action NRRHLFONPPM = null, float PRRKGRQILFR = 0f, float JPKGQSMKSTF = 0.35f)
	{
	}

	public void PlayUnclaimedLevelAnimationForLevel(int NERGMFPHLIM)
	{
	}

	private void FGJJOLOOQIG()
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	public void OnExitButton()
	{
	}

	public void OnBuyButton()
	{
	}

	public void OnBuyPlusButton()
	{
	}

	public void OnTimerUp()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public FloatingErrorText SpawnFloatingText(string HETQTIKJGNI, Transform HSSNSPQEIGR = null)
	{
		return null;
	}

	public void SpawnClaimParticles(bool FKPPEQLPJHJ, Transform HSSNSPQEIGR)
	{
	}

	public void OnRewardClaimed()
	{
	}

	public void OnPaidClicked(bool KNHHJTGTHJF = true)
	{
	}

	public void OnPremiumClicked(bool KNHHJTGTHJF = true)
	{
	}

	public void OnFinalSkipClicked()
	{
	}

	public void SetPlayFullAnimation()
	{
	}

	public PassRewardList GetRewardList(ERLKIIFQKSI EMKNPKTIJPF)
	{
		return null;
	}

	[CompilerGenerated]
	private void OHHSRLPGQNQ()
	{
	}

	[CompilerGenerated]
	private void JGHRHPQSQNG(float OGFKHSKTHHR, float PRRKGRQILFR)
	{
	}

	[CompilerGenerated]
	private void KQREHEJHOIF()
	{
	}
}
