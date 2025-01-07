using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class UIClanLeaderboardPanel : UIPanel, DynamicVerticalLayout.SNFEJIONTHF
{
	public enum HIRRQPLLTIJ
	{
		ClanPanel = 0,
		MissionsPanel = 1,
		BossPanel = 2
	}

	public enum HNIOJGGSTPP
	{
		ThisWeek = 0,
		LastWeek = 1,
		Leagues = 2
	}

	public enum LMMHEOPHNQO
	{
		Bucket = 0,
		TopPlayers = 1,
		TopClans = 2
	}

	[CompilerGenerated]
	private sealed class TROJLPJESOL
	{
		public List<IApiLeaderboardRecord> records;

		public string[] bucket;

		internal bool _003CSetupBucket_003Eb__0(string e)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class OQPRTJSJLSE
	{
		public string e;

		internal bool _003CSetupBucket_003Eb__2(IApiLeaderboardRecord r)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HOMSHQSQTIJ
	{
		public int i;

		public TROJLPJESOL CS_0024_003C_003E8__locals1;

		internal bool _003CSetupBucket_003Eb__3(IApiLeaderboardRecord r)
		{
			return false;
		}
	}

	private const int FMSIKFIQPFF = 20;

	private const int EKQIKLGQGJO = 100;

	[SerializeField]
	private List<GameObject> tabsSelected;

	[SerializeField]
	private List<GameObject> subTabsSelected;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private ClanLeagueDisplay leagueDisplay;

	[SerializeField]
	private Text leagueExplanationLabel;

	[SerializeField]
	private ClanLeaderboardItem prefab;

	[SerializeField]
	private RectTransform bucketLayout;

	[SerializeField]
	private RectTransform topClansLayout;

	[SerializeField]
	private GameObject clansScroll;

	[SerializeField]
	private GameObject playerScroll;

	[SerializeField]
	private GameObject topClansScroll;

	[SerializeField]
	private DynamicVerticalLayout playerLayout;

	[SerializeField]
	private GameObject leaderboardBlock;

	[SerializeField]
	private GameObject failedToRetrieveLeaderboards;

	[SerializeField]
	private GameObject leaderboardEmpty;

	[SerializeField]
	private GameObject noLeagueInfo;

	[SerializeField]
	private GameObject noLeagueInfoLastWeek;

	[SerializeField]
	private ClanLeaguePlayerElement playerPrefab;

	[SerializeField]
	private Image[] leagueSelectionOutlines;

	[SerializeField]
	private GameObject leagueSelectorHeader;

	[SerializeField]
	private LeaguesBlock leaguesBlock;

	private List<ClanLeaderboardItem> NNIQGGQJIHT;

	private int MSJMHFGILEO;

	private HIRRQPLLTIJ IQLPQLFGEMM;

	private HNIOJGGSTPP NQTPJLQQLRE;

	private LMMHEOPHNQO LMOTKKNQREP;

	private bool HOKEJTMEGRT;

	private int HPJHPJRFMJK;

	private ClanLeaguePlayerElement LJSFGQIOKSG;

	protected override void Awake()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void NMISIGEOGHE()
	{
	}

	public void OnRetryButton()
	{
	}

	public void SetupBasedOnTabs()
	{
	}

	private long TMRFEFPPGTH()
	{
		return 0L;
	}

	public void SetupPlayers()
	{
	}

	private void RTQQIFKMJEJ(QHOERPGGPPJ QEFHSEEFROM)
	{
	}

	private void HHNMQLMLKJK(QHOERPGGPPJ QEFHSEEFROM, int FIPHTRRRPET)
	{
	}

	public void SetupTopClans()
	{
	}

	private void ILKJKFRHSGF(QHOERPGGPPJ QEFHSEEFROM)
	{
	}

	private void FQIFFEKTHGK(QHOERPGGPPJ QEFHSEEFROM)
	{
	}

	private void RJELRRTTSTF(QHOERPGGPPJ QEFHSEEFROM, int FIPHTRRRPET)
	{
	}

	public void OnTabThisWeek()
	{
	}

	public void OnTabLeagues()
	{
	}

	public void OnTabLastWeek()
	{
	}

	public void OnSubTabBucket()
	{
	}

	public void OnSubTabTopPlayers()
	{
	}

	public void OnSubTabTopClans()
	{
	}

	public void SetOpenFromPanel(HIRRQPLLTIJ EESTGTGKLJG)
	{
	}

	private void RPNLKLJJMEK(bool GSJNPHNGPLM)
	{
	}

	private Task HFTLTMORFLI(bool GSJNPHNGPLM)
	{
		return null;
	}

	private void QEQPTPINROE()
	{
	}

	private void JKPEHGIETQS()
	{
	}

	public void SetupLeaguesBlock()
	{
	}

	public void OnItemClicked()
	{
	}

	private void MGRLTPGGSSI()
	{
	}

	public void OnBackButton()
	{
	}

	public void OnGoToClanButton()
	{
	}

	public void ShowSpinner()
	{
	}

	public void HideSpinner()
	{
	}

	private void JITNJSQRJSO()
	{
	}

	private void TIKTTTHKKKR()
	{
	}

	private void NEQFSIKEKNE()
	{
	}

	private QHOERPGGPPJ GILGPJFFKHJ()
	{
		return null;
	}

	public MonoBehaviour GetItemPrefab()
	{
		return null;
	}

	public void SetupItem(MonoBehaviour LMSPIEGSMRF, int TFPLTLFLKPI)
	{
	}

	public void OnPlayerClicked(ClanLeaguePlayerElement HPJMQLRTORF, int PSPJIJNTMOI)
	{
	}

	public void OnLeagueSelectorClicked(int PSPJIJNTMOI)
	{
	}

	private void MPIKKOSPFRF()
	{
	}

	private void RGJTMOMHLJK()
	{
	}
}
