using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MenuAgentPanel : UIPanel
{
	[CompilerGenerated]
	private sealed class TEGONQLEPOT
	{
		public MenuAgentPanel _003C_003E4__this;

		public HOEOSKPERRR.AgentUpgradeRequirement upgradeReq;

		internal void _003CSetupSelectedAgent_003Eb__1(float x)
		{
		}

		internal void _003CSetupSelectedAgent_003Eb__2(float x)
		{
		}

		internal bool _003CSetupSelectedAgent_003Eb__3(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}

		internal bool _003CSetupSelectedAgent_003Eb__4(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KTKQOEGFNJH
	{
		public RRMFSKNJIOH aid;

		internal bool _003COnBuyButton_003Eb__0(Agent a)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FFFFMFHKMFJ
	{
		public AgentListCell cell;

		internal void _003COnAgentCellDoubleClicked_003Eb__0(AgentListPage p)
		{
		}
	}

	[CompilerGenerated]
	private sealed class JHMGMTEEOIT
	{
		public JJHFPNTSRLT.PQRIQGIOGQT toRarity;

		public MenuAgentPanel _003C_003E4__this;

		internal bool _003COnAgentRankUp_003Eb__0(JJHFPNTSRLT.RarityGameObject x)
		{
			return false;
		}

		internal void _003COnAgentRankUp_003Eb__1()
		{
		}
	}

	[SerializeField]
	private AgentListPage prefabPage;

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[Space]
	[SerializeField]
	private AgentPanelUpgradeCover upgradeCover;

	[SerializeField]
	private AgentPanelSkinsCover skinsCover;

	[SerializeField]
	private RectTransform listPageParent;

	[SerializeField]
	public UIPlayerPreview preview;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private Transform previewParent;

	[SerializeField]
	private GameObject selectButton;

	[SerializeField]
	private GameObject upgradeButton;

	[SerializeField]
	private GameObject selectedButton;

	[SerializeField]
	private GameObject buyButton;

	[SerializeField]
	private GameObject getNowButton;

	[SerializeField]
	private GameObject skinsButton;

	[SerializeField]
	public GameObject dataPanel;

	[SerializeField]
	public GameObject agentList;

	[SerializeField]
	private GameObject dataStatsBlock;

	[SerializeField]
	private GameObject dataLockedBlock;

	[SerializeField]
	private Transform particleSpawnLocation;

	[SerializeField]
	private Transform rotateTarget;

	[SerializeField]
	private ScrollRectStepped infoBlockScroll;

	[SerializeField]
	private GameObject infoBlock;

	[SerializeField]
	private GameObject infoUnlockOperations;

	[SerializeField]
	private GameObject infoUnlockShards;

	[SerializeField]
	private Image shardUnlockIcon;

	[SerializeField]
	private Text shardUnlockLabel;

	[SerializeField]
	private GameObject shardUnlockButton;

	[SerializeField]
	private GameObject topBlock;

	[SerializeField]
	private VideoPlayerWrapper videoPlayer;

	[SerializeField]
	private UIScrollPageTracker scrollPages;

	[SerializeField]
	private Text labelHP;

	[SerializeField]
	private Text labelDamage;

	[SerializeField]
	private Text labelCombatPower;

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private Text labelName;

	[SerializeField]
	private Text labelBonus;

	[SerializeField]
	private Text labelBonusLocked;

	[SerializeField]
	private Text labelBuyPriceGems;

	[SerializeField]
	private Text labelLocked;

	[SerializeField]
	private RectTransform blockHealth;

	[SerializeField]
	private RectTransform blockDamage;

	[SerializeField]
	private Image agentAbillityIcon;

	[SerializeField]
	private Image agentAbillityIconLocked;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image levelInfoBackground;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> backgrounds;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> lvlInfoBgs;

	[Space]
	[SerializeField]
	private Sprite imageFillFull;

	[SerializeField]
	private Sprite imageFillRegular;

	[SerializeField]
	private List<JJHFPNTSRLT.RarityGameObject> rankUpEffects;

	[SerializeField]
	private GameObject activateUltimateParticles;

	[SerializeField]
	private GameObject activateEnhancementParticles;

	private readonly List<GameObject> GIGESTTSLQR;

	private int OPJPOERFTJR;

	private float NGGEFNGQESQ;

	private ItemWeapon MMROEOQNRIR;

	private Agent OHNKKIHHEQM;

	private Agent MOFFFPNNHNI;

	private bool IFSRTRFIESK;

	private List<AgentListPage> LOGTNKITFPM;

	protected override void MGKPMPHSLFR()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void IRQGNNJNGEI(int QMHFIQMSKQJ)
	{
	}

	private void HJIJTJTKHKO()
	{
	}

	private void GIEQOSHEOKG()
	{
	}

	private void GQLPRKGKSJI(RRMFSKNJIOH TMQJMGQNQQR, IRHNENTFPPM QHTSIIGGMOP)
	{
	}

	private void LHORLLTSFJN()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void KRLKNOEEEGF()
	{
	}

	private void FEFJNKIRGIS(bool NQMQSLSJFGK = true, bool OIQNLGSSLET = false, bool IQSLSONOLGM = true)
	{
	}

	private void QTRRKKQLSEG(List<Agent> TSRPFHOJKSG)
	{
	}

	private void RTGPOOFEQMH()
	{
	}

	private void RQKFERMHFFP(bool KQGHGPEKKTJ = true)
	{
	}

	private void IEGHKEHQKEP(bool KQGHGPEKKTJ)
	{
	}

	public void OnBuyButton()
	{
	}

	public void OnShardUnlockButton()
	{
	}

	private void EGQLLLIGEMJ(RRMFSKNJIOH TMQJMGQNQQR = RRMFSKNJIOH.UNSET)
	{
	}

	public void OnSkinsButton()
	{
	}

	public void OnExitButton()
	{
	}

	public void OnBackButton()
	{
	}

	public void OnSelectButton()
	{
	}

	public void OnUpgradeButton()
	{
	}

	public void OnVipButton()
	{
	}

	public void OnGetNowButton()
	{
	}

	public void OnAgentCellClicked(AgentListCell GGOKJRGSMRT)
	{
	}

	public void OnAgentCellDoubleClicked(AgentListCell GGOKJRGSMRT)
	{
	}

	public void OnInfoScrollStopped(int LHEHNNGEJIH)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnAgentRankUp(JJHFPNTSRLT.PQRIQGIOGQT JPERFTSMLRH)
	{
	}

	public void PlayUpgradeAnimation()
	{
	}

	public void PlayEnhancementActivateAnimation(bool IJRPOMJKPOF = false)
	{
	}

	public void OnEnhancementsChanged()
	{
	}

	private void MNQRLNNHNQQ()
	{
	}

	private void FNJMFMGEFNL()
	{
	}

	private FloatingErrorText KMQIMTNTOMN(string HETQTIKJGNI, Transform HSSNSPQEIGR = null)
	{
		return null;
	}

	public void OnSkinsCoverClose()
	{
	}

	public void OnUpgradeCoverClose(Agent IFLMHEQTKLS)
	{
	}

	[CompilerGenerated]
	internal static void FKGGNKSEMPH(RectTransform ELEIPINNGGJ, float PRRKGRQILFR, Text ESRIRITTSIG, float KQSFOENOONK, float TNEEGPGGOIT, Action<float> SGKMEFSQLQK)
	{
	}

	[CompilerGenerated]
	private void IOQRRNHLFSP(AgentListPage SKOJGTGOPIF)
	{
	}

	[CompilerGenerated]
	private void ELIMTSIPLHS(AgentListPage SKOJGTGOPIF)
	{
	}

	[CompilerGenerated]
	private void MLIMKNPFMTE(AgentListPage SKOJGTGOPIF)
	{
	}
}
