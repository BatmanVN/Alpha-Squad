using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class MissionsBlock : MonoBehaviour
{
	public enum INKINFLSSRH
	{
		Maintenance = 0,
		Locked = 1,
		UpdateRequired = 2,
		NoData = 3,
		Playable = 4,
		Finalizing = 5,
		Resting = 6
	}

	private const float RJKQNIMJNFS = -150f;

	public INKINFLSSRH state;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private GameObject availableBlock;

	[SerializeField]
	private UITextTimer stateTimer;

	[SerializeField]
	private Text stateTimerLabel;

	[SerializeField]
	private GameObject playableBlock;

	[SerializeField]
	private GameObject unplayableBlock;

	[SerializeField]
	private GameObject didNotParticipate;

	[SerializeField]
	private GameObject weekIsOver;

	[SerializeField]
	private Image leagueIcon;

	[SerializeField]
	private GameObject newWeek;

	[SerializeField]
	private GameObject timerBlock;

	[SerializeField]
	private GameObject unavailableBlock;

	[SerializeField]
	private GameObject lockedBlock;

	[SerializeField]
	private GameObject maintenanceBlock;

	[SerializeField]
	private GameObject updateRequiredBlock;

	[SerializeField]
	private GameObject noDataBlock;

	[SerializeField]
	private Text lockedLevelRequired;

	[SerializeField]
	private GameObject allBossesUnlocked;

	[SerializeField]
	private GameObject bossProgress;

	[SerializeField]
	private Image bossIcon;

	[SerializeField]
	private Text bossProgressText;

	[SerializeField]
	private SlicedFilledImage bossProgressFill;

	[SerializeField]
	private Sprite bossIconFallback;

	[SerializeField]
	private RectTransform ticketContainer;

	[SerializeField]
	private GameObject ticketsTimerContainer;

	[SerializeField]
	private Text ticketCountLabel;

	[SerializeField]
	private UITextTimer ticketTimer;

	[SerializeField]
	private Text ticketTimerLabel;

	private static bool IKRGTOQLHKG;

	public Task Setup()
	{
		return null;
	}

	public static void Clear()
	{
	}

	public static bool IsStateUnavailable(INKINFLSSRH PTHIFGMSJIP)
	{
		return false;
	}

	public static void SetupTimer(INKINFLSSRH PTHIFGMSJIP, UITextTimer EKFSSTEMLFQ, Text ESRIRITTSIG)
	{
	}

	public static void CheckShouldTryShowRewardPopup()
	{
	}

	public static void CheckShouldTryShowMissionsInfoPopup()
	{
	}

	private static Task SEGRFGJROQG(long RJQKFMGHKKR)
	{
		return null;
	}

	private Task HPNSOLHLMFF()
	{
		return null;
	}

	private void RPGMQOFFQRO()
	{
	}

	public void OnTimerUpdated()
	{
	}

	public void OnLeaderboardsButton()
	{
	}

	public void OnEnterButton()
	{
	}

	public void OnDiscordButton()
	{
	}

	public static void OnUpdateButton()
	{
	}

	public void OnInfoButton()
	{
	}

	public static bool AreMissionsDisabledForCheaters()
	{
		return false;
	}

	public static INKINFLSSRH CalculateState()
	{
		return default(INKINFLSSRH);
	}

	public static bool AreVersionRequirementsMet()
	{
		return false;
	}

	public static bool IsUnlocked()
	{
		return false;
	}

	public void UpdateState()
	{
	}
}
