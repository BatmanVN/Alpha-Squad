using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameController : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		public bool inProgress;

		public int lootboxCooldown;

		public int lootboxOrderIndex;

		public LootboxSpot.QHMTEIRRMIM lootboxRandomedType;

		public int lootboxSeed;

		public int adRevivesLeft;

		public int adRevivesLastStamp;

		public int revivesUsed;

		public int extraLivesUsed;

		public KFPHKOMNHSS playType;

		public bool playerWasAlive;

		public float damageTimeLeft;
	}

	public enum KFPHKOMNHSS
	{
		STORY = 0,
		OPERATION = 1,
		RAID = 2,
		EXPEDITION = 3,
		SKIRMISH = 4,
		RIFTS = 5,
		HELL = 6,
		CLAN_MISSION = 7,
		EVENT_HALLOWEEN = 101
	}

	public bool startedPlaying;

	public static Data data;

	public static bool savingDisabled;

	private static bool PSHRIKLLMSE;

	private static int[] PPHJPRJLINK;

	private float EINIISGRTEQ;

	public PIGRSTIEERE stageAffixes;

	public static string DATA_KEY;

	public static bool EPMEHQOSNPJ
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public event Action RPKHQGJIHRM
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

	public event Action SGPIGOFPFRS
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

	public static event Action OFHNMFQMMHF
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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static void SaveData()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static void Clear()
	{
	}

	public static Data GetData()
	{
		return null;
	}

	public static int GetAdRevivesLeft()
	{
		return 0;
	}

	public static int GetReviveAdResetInterval()
	{
		return 0;
	}

	public static void LoadMenuScene()
	{
	}

	public static void HardReset()
	{
	}

	public void RestartLevel()
	{
	}

	public void RestartRun()
	{
	}

	public static void ResetRunData()
	{
	}

	public void AbandonWorld()
	{
	}

	private void Update()
	{
	}

	public static void FastSkipStage()
	{
	}

	public static void QuickCompleteStageWithLoot()
	{
	}

	private void REHNMIPHJJI()
	{
	}

	public static void SetSavingDisabled(bool MPGHMIRKNON)
	{
	}

	public static bool IsStoryBossFight()
	{
		return false;
	}

	public void SaveStageData()
	{
	}

	private void JMSMNLJOFQP()
	{
	}

	private bool KOLGNENEGIG()
	{
		return false;
	}

	public static int GetTotalRevivesForPlayType(KFPHKOMNHSS NSQRHJPNSGL)
	{
		return 0;
	}

	private bool LQJLOFMJSHI()
	{
		return false;
	}

	public void StageFailedFinalize(bool KTFKTTSQQRT, bool NRLORILTSJR = false)
	{
	}

	private bool LJRHEGMLLQN()
	{
		return false;
	}

	public void RevivePlayer(RevivePanel.HEOOOJIKORO QKRRNQFMLKG)
	{
	}

	private void HENELGRIJLH()
	{
	}

	private void ILKGHTKLRJN()
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	private void RKHKJERHFSG()
	{
	}

	public float GetCurrentSecondLifeCooldown()
	{
		return 0f;
	}

	[CompilerGenerated]
	private void HMLTMHOIREM()
	{
	}
}
