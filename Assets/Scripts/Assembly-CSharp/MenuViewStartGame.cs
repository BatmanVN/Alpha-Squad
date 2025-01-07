using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MenuViewStartGame : MenuView
{
	[Serializable]
	public struct Data
	{
		public bool clearNew;

		public int lastEpisodeNumber;

		public int lastAreaNumber;
	}

	[CompilerGenerated]
	private sealed class IFJKEEEJQHK
	{
		public bool newWorldUnlocked;

		public WorldController.WorldProgress wProgress;

		public bool newEpisodeUnlocked;

		public MenuViewStartGame _003C_003E4__this;

		internal void _003COnEntered_003Eb__1()
		{
		}
	}

	public Text worldTitleText;

	public Image worldIconImage;

	public WorldProgressBar regularMode;

	public MenuViewHell hellView;

	public GameObject playStoryButton;

	public GameObject raidButton;

	public GameObject switchToHellButton;

	public GameObject switchToStoryButton;

	public GameObject worldInfoBlock;

	[SerializeField]
	private ChestPreview prefabChestPreview;

	[SerializeField]
	private ChestRewardCell prefabRewardCell;

	[SerializeField]
	private EpisodeCell prefabEpisodeCell;

	[SerializeField]
	private GameObject particlesHellSwitch;

	[SerializeField]
	private GameObject worldViewStory;

	[SerializeField]
	private GameObject worldViewEpisodes;

	[SerializeField]
	private GameObject viewHell;

	[SerializeField]
	private RectTransform rewardCellParent;

	[SerializeField]
	public Button startButton;

	[SerializeField]
	public RectTransform startBlock;

	[SerializeField]
	public PassButton passButton;

	[SerializeField]
	public MiniOfferLayout miniOffers;

	[SerializeField]
	private GameObject debugLevelSelectButtons;

	[SerializeField]
	private GameObject viewAllContentCompleted;

	[SerializeField]
	private WeeklyContractsButton weeklyContractsButton;

	[SerializeField]
	private GameObject newVersionButton;

	[SerializeField]
	private NotificationBubble mailNotificationBubbleBubble;

	[SerializeField]
	public RectTransform episodeCellParent;

	[SerializeField]
	private Text episodeTitle;

	[SerializeField]
	private RectTransform rectDifficulty;

	[SerializeField]
	private RectTransform rectLevelSelect;

	[SerializeField]
	public RectTransform rectChests;

	[SerializeField]
	private RectTransform rectStartButton;

	[SerializeField]
	private RectTransform rectHuntButton;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private Transform worldPanel;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Material backgroundMatStory;

	[SerializeField]
	private Material backgroundMatHell;

	[SerializeField]
	private Image tiles;

	[SerializeField]
	private Color tilesColorStory;

	[SerializeField]
	private Color tilesColorHell;

	[SerializeField]
	private Image glow;

	[SerializeField]
	private Image glowHell;

	[SerializeField]
	private Color glowColorStory;

	[SerializeField]
	private Color glowColorHell;

	public float animEndScale;

	public float animDuration;

	public Ease animEaseIn;

	public Ease animEaseOut;

	private List<ChestRewardCell> TJRLKJOHIES;

	public Data data;

	private AsyncOperation MKFMNRHRHGF;

	private float LLOFORKPQSK;

	private bool TPRGONLMNTS;

	private bool HMGSEEPHQSO;

	private bool HMSSELKJGET;

	private GameObject PRELGNREHTS;

	private bool PNHPIILELTN;

	private float OQOHQRKPTHO;

	public static string KEY;

	private static string QQNMMNEISIL;

	private static string TLSHQGOKOQL;

	public event Action ONGMGHIJQNI
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

	public void SaveData()
	{
	}

	public override void Setup()
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	protected override void OnDisable()
	{
	}

	private void KNOTGRFNKTG(int FKKLKESIMML)
	{
	}

	private void Update()
	{
	}

	public override void OnEntered()
	{
	}

	public static void TryForceShowPopup()
	{
	}

	public override void OnExited()
	{
	}

	private void KEIOTKPFKHK()
	{
	}

	private void HPKSFLKMOOF()
	{
	}

	public void TryClearNewItems()
	{
	}

	public void OnStartButton()
	{
	}

	public void OnRaidButton()
	{
	}

	public void OnHellButton()
	{
	}

	public void OnSwitchToHellButton()
	{
	}

	public void OnSwitchToStoryButton()
	{
	}

	public void AnimateHellSwitch()
	{
	}

	public void OnMrBitEventButton()
	{
	}

	private bool KKIPSMKQFIG()
	{
		return false;
	}

	public void StartStory()
	{
	}

	public void StartHell()
	{
	}

	private static void EGFOGOLTLSM()
	{
	}

	public void UpdateWorldData()
	{
	}

	public void SetupEpisode()
	{
	}

	public void SetupHell()
	{
	}

	public void SetupChests()
	{
	}

	public void PlayCurrentEpisodeAreaUnlockAnim()
	{
	}

	public ChestRewardCell GetChestByIndex(int PNIQKIGEHLF)
	{
		return null;
	}

	private void OFSMKLRLGNH()
	{
	}

	private void OLGHKOORMLN()
	{
	}

	public void OnButtonWorldLeft()
	{
	}

	public void OnButtonWorldRight()
	{
	}

	public void OnButtonChallengeLeft()
	{
	}

	public void OnButtonChallengeRight()
	{
	}

	public void OnWeeklyContractsButton()
	{
	}

	public void OnSettingsButton()
	{
	}

	public void OnNewsButton()
	{
	}

	public void OnPlayerPathButton()
	{
	}

	public void OnNewVersionButton()
	{
	}

	public void OnChestClicked(ChestRewardCell GGOKJRGSMRT)
	{
	}

	public void OnButtonLevelInfo()
	{
	}

	public void OnBattlePassButton()
	{
	}

	public void OnDiscordButton()
	{
	}

	public void OnWorldChangeHidden()
	{
	}

	public Transform GetWorldIconTransform()
	{
		return null;
	}

	public void SetInputBlockerEnabled(bool QHSMPFPKNMM)
	{
	}

	public Transform GetInputBlocker()
	{
		return null;
	}

	public void RefreshMailNotificationBubble()
	{
	}

	private bool PGNEQNNMQTO()
	{
		return false;
	}

	private void MOHNKHQGKOI()
	{
	}

	private bool TQOMJFTKOTS()
	{
		return false;
	}

	private void JPHHKHHGHIR()
	{
	}

	[CompilerGenerated]
	internal static void EOOEIMSOONS(int LMJNFLONIJI, int QHLEPELLMHQ)
	{
	}

	[CompilerGenerated]
	private void OPILIMEMQJM()
	{
	}

	[CompilerGenerated]
	private void RLLFRENNFJF()
	{
	}
}
