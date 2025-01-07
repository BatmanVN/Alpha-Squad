using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIClanBossPanel : UIPanel
{
	[CompilerGenerated]
	private sealed class FMNFKLHMQEG
	{
		public UIClanBossPanel _003C_003E4__this;

		public int floor;

		internal void _003CStartGame_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct HKOKKNGHKKE
	{
		public int floor;
	}

	public const int TORMENT_FLOOR = 5;

	public const int MAX_FLOOR = 10;

	[SerializeField]
	private ClanMissionBracketItem regularBracket;

	[SerializeField]
	private ClanMissionBracketItem tormentBracket;

	[SerializeField]
	private Text bossNameLabel;

	[SerializeField]
	private Text affixesLabel;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private Transform bossSpot;

	[SerializeField]
	private GameObject bossSpinner;

	[SerializeField]
	private ScrollRectStepped bracketScroll;

	[SerializeField]
	private GameObject getMoreLeagueTicketsButton;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private Image tiles;

	[SerializeField]
	private GameObject bossAnimationSpeedupButton;

	[SerializeField]
	private GameObject agentBonus;

	[SerializeField]
	private GameObject agentBonusBubble;

	[SerializeField]
	private RectTransform agentBonusInfoButton;

	[SerializeField]
	private RectTransform agentBonusInfoList;

	[SerializeField]
	private MissionBoostElement missionBoostPrefab;

	[SerializeField]
	private Transform rings;

	[SerializeField]
	private Transform ringsBg;

	[SerializeField]
	private Transform bossShadow;

	[SerializeField]
	private Image glowBlue;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private RectTransform bottomOverlay;

	[SerializeField]
	private CanvasGroup topCanvasGroup;

	[SerializeField]
	private Image contentImage;

	[SerializeField]
	private Image fade;

	[SerializeField]
	private CanvasGroup levelsScroll;

	[SerializeField]
	private Image cityBG;

	[SerializeField]
	private GameObject purpleBG;

	private int LIQGLGKPMPE;

	private EnemySpot.SMMGLQPTJET TIMTONIQSLH;

	private GameObject IQJGNKOLNMI;

	private bool TFSPTRPKOIF;

	private Tween HREPTOHFHJI;

	private static int EIILTOHRGSI;

	private static int GSSHJMQGPFI;

	private static int RSKRMJIFEPP;

	private static int NLHMSLNGFMS;

	private static bool TNJRJSJRHPP;

	public static void SetupAndShow(int RKGEFIMLOQT)
	{
	}

	public static void OpenAfterMission()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void JTOOTKHFTLJ(int RGGOMTFHREP, int GGGFLPMSITQ, int QMFHMKHRSMO)
	{
	}

	private void JEELRTNPFSK(int STSFGQMGSNP, int EEHLRFERSGN, int FNEGKRPKOEK)
	{
	}

	private void THPMLLRLGHH()
	{
	}

	private static void RGRGGNGNROI()
	{
	}

	public void Setup(int RKGEFIMLOQT)
	{
	}

	public void UpdateBossAnimation()
	{
	}

	public static bool ShouldOpenAfterMission()
	{
		return false;
	}

	public void OnScrolledToPage(int JIEEJMIKPNG)
	{
	}

	private void ETEFROMPHTQ(bool IOIKQPPEHLS, bool JEPRTELNILG)
	{
	}

	private void TQELTEGIRIQ(bool IOIKQPPEHLS)
	{
	}

	private void HGHIOQKNIMP(EnemySpot.SMMGLQPTJET MFILHEENFHI)
	{
	}

	private void GQKGEMRKQTK(GameObject HNTPNTJRJMH)
	{
	}

	public void OnBackButton()
	{
	}

	public void OnLeaderboardsButton()
	{
	}

	public void ShowSpinner()
	{
	}

	public void HideSpinner()
	{
	}

	public void StartGame(int EERRGHKNKNK)
	{
	}

	public Task ConsumeTicketAndStartGame(int EERRGHKNKNK)
	{
		return null;
	}

	private void JRPFLPJLTIL(int EERRGHKNKNK)
	{
	}

	private void LateUpdate()
	{
	}

	private void PPHKRFMKGME()
	{
	}

	public void OnSpeedupBossAnimationButton()
	{
	}

	public void OnAgentBonusInfoButton()
	{
	}

	private bool OMHSRQNPJMT()
	{
		return false;
	}

	public void HideGetMoreButton()
	{
	}

	public static bool IsFloorUnlocked(int RKGEFIMLOQT, int JTRTLOSKQIT)
	{
		return false;
	}

	private static int KLHGEMGPEKG(int RKGEFIMLOQT)
	{
		return 0;
	}

	[CompilerGenerated]
	private void QOTEOPORNGM()
	{
	}

	[CompilerGenerated]
	internal static bool IMPNLISNRPO(ref HKOKKNGHKKE P_0)
	{
		return false;
	}
}
