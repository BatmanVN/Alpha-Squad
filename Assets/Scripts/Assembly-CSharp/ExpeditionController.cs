using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Expedition;
using UnityEngine;

public class ExpeditionController : MonoBehaviour, EKFFMKLSSNN
{
	private struct KFPQEKFLJLN
	{
		public int JOHGIPIFPHS;

		public int JQFQGGFGEMO;

		public int KHNKJJIHLOK;

		public JJHFPNTSRLT.LevelOffset[] RQRFSMGSIEM;

		public int TJMMQPJOGRN;

		public int GPIHQGNEENG;

		public int TTTEMHSMJNJ;

		public int GIEHSROKKLK;

		public int QRNQRTKGELQ;

		public int KSEPMPNPSTT(int NERGMFPHLIM)
		{
			return 0;
		}
	}

	[Serializable]
	public class Instance
	{
		public int totalStages;

		public bool wheelShown;

		public List<BoostReference.BoostSlot> boosts;

		public bool boss;

		public MinibossConfig minibossConfig;
	}

	[Serializable]
	public class Data
	{
		public int timestamp;

		public int entryTimestamp;

		public ObscuredInt availableEntries;

		public int currentExpeditionId;

		public int currentLevel;

		public int currentEnemyLevel;

		public int previousEnemyLevel;

		public WorldData.JQNPLTQOFMJ worldType;

		public int worldVariation;

		public List<int> currentStages;

		public Instance instance;

		public List<ExpeditionData.ExpeditionLevelReward> currentRewards;

		public List<ExpeditionData.ExpeditionLevelRewardSaved> overrideRewards;

		public List<JJHFPNTSRLT.WeaponPartIdentifier> recentWeaponParts;

		public int highestCompletedLevel;

		public bool specialRewardsClaimed;

		public List<WorldData.JQNPLTQOFMJ> previousWorlds;

		public List<int> previousRewardsIds;

		public List<int> recentStages;

		public ExpeditionData.ExpeditionLevel activeLevel;

		public bool expeditionSeen;
	}

	[Serializable]
	public struct AnalyticsContext
	{
		public List<BoostReference.BoostSlot> boosts;

		public string Json => null;
	}

	[CompilerGenerated]
	private sealed class PHFTLNTMFSK
	{
		public List<WorldData.JQNPLTQOFMJ> expeditionWorlds;

		internal bool _003CGenerateNewExpedition_003Eb__0(WorldData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class IIESPQTRMEN
	{
		public int k;

		internal bool _003CGenerateNewExpedition_003Eb__3(ExpeditionData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FMSGGTLKGFO
	{
		public int i;

		internal bool _003CGetCurrentExpeditionData_003Eb__0(ExpeditionData.ExpeditionLevelRewardSaved x)
		{
			return false;
		}

		internal bool _003CGetCurrentExpeditionData_003Eb__1(ExpeditionData.ExpeditionLevelRewardSaved x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NHKSQEEOFRH
	{
		public List<JJHFPNTSRLT.WeaponPartIdentifier> allParts;

		public JJHFPNTSRLT.WeaponPartIdentifier ret;

		internal bool _003CGetNonRecentWeaponPart_003Eb__0(JJHFPNTSRLT.WeaponPartIdentifier x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class EOJQNGTNMTL
	{
		public int i;

		public NHKSQEEOFRH CS_0024_003C_003E8__locals1;

		internal bool _003CGetNonRecentWeaponPart_003Eb__1(JJHFPNTSRLT.WeaponPartIdentifier x)
		{
			return false;
		}
	}

	private static KFPQEKFLJLN SOSLGOOOIPG;

	private static Data TSRPFHOJKSG;

	private static ExpeditionData HOESOMHKPLO;

	private static bool JREGORLKOST;

	private static bool FKKSTPLHLJF;

	public static string KEY;

	public static event Action NMNGGFQJPEL
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

	private void OnDestroy()
	{
	}

	private static void MLNESSGJRME()
	{
	}

	public static void Clear()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	private static void MPLFTRNNKMT()
	{
	}

	public static void SaveData()
	{
	}

	public static Data GetData()
	{
		return null;
	}

	public static void SkipTimeToNextExpedition()
	{
	}

	public static void ResetAttempts()
	{
	}

	private static void JKPLSPQQHTE()
	{
	}

	private static void STPMKJJIFMH(int LMJNFLONIJI = -1, bool ITLPIELOJGP = false)
	{
	}

	public static int GetKeycardPriceFull()
	{
		return 0;
	}

	public static int GetKeycardPurchasePriceCurrent()
	{
		return 0;
	}

	public static int GetCurrentEnemyLevel()
	{
		return 0;
	}

	public static int GetPreviousEnemyLevel()
	{
		return 0;
	}

	public static int GetRewardLevel()
	{
		return 0;
	}

	public static bool IsAvailable()
	{
		return false;
	}

	public static List<int> GetCurrentStages()
	{
		return null;
	}

	public static bool IsCompleted()
	{
		return false;
	}

	public static int GetRemainingLevels()
	{
		return 0;
	}

	public static int GetCurrentLevel()
	{
		return 0;
	}

	public static int GetAttemptsLeft()
	{
		return 0;
	}

	public static int GetEventStartTimestamp()
	{
		return 0;
	}

	public static int GetAttemptRefreshStartTimestamp()
	{
		return 0;
	}

	public static int GetEventRefreshInterval()
	{
		return 0;
	}

	public static int GetAttemptRefreshInterval()
	{
		return 0;
	}

	public static int GetMaxAttempts()
	{
		return 0;
	}

	public static WorldData.JQNPLTQOFMJ GetCurrentWorld()
	{
		return default(WorldData.JQNPLTQOFMJ);
	}

	public static ExpeditionData.ExpeditionLevel GetLevelDataForLevel(int NERGMFPHLIM)
	{
		return default(ExpeditionData.ExpeditionLevel);
	}

	public static ExpeditionData.ExpeditionLevel GetCurrentLevelData()
	{
		return default(ExpeditionData.ExpeditionLevel);
	}

	public static ExpeditionData.ExpeditionLevel GetActiveLevelData()
	{
		return default(ExpeditionData.ExpeditionLevel);
	}

	public static ExpeditionData GetCurrentExpeditionData()
	{
		return null;
	}

	public static ExpeditionData.ExpeditionRewardSingle GetTopRewardForCurrentExpedition()
	{
		return default(ExpeditionData.ExpeditionRewardSingle);
	}

	private static System.Random IOTRIIHJJQE()
	{
		return null;
	}

	public static List<RKTKKOOERQQ.GambleReward> GetGambleRewards(int FRFTQJJMGFG = -1)
	{
		return null;
	}

	public static bool HasNewExpedition()
	{
		return false;
	}

	public static int GetAutoCompleteTicketPrice()
	{
		return 0;
	}

	public static bool CanAutoCompleteLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static void LevelStart()
	{
	}

	public static void LevelAutoComplete()
	{
	}

	private static void RQJRTEKQGTQ(bool TSETKTETSGJ = true)
	{
	}

	private static void MJOLNEIMOFI()
	{
	}

	private static List<RKTKKOOERQQ.GambleReward> NHMQKOGQMQK(ExpeditionData.ExpeditionRewardSingle KEHLRNOQSEQ)
	{
		return null;
	}

	public static void GenerateInstance()
	{
	}

	public static uint GetLevelSeed(int GQTJNOENHFJ = 0)
	{
		return 0u;
	}

	public static int GetExpeditionIndex()
	{
		return 0;
	}

	public static bool CanStartLevel()
	{
		return false;
	}

	public static int CalculateAttemptsLeft()
	{
		return 0;
	}

	private static void RPEGLRKFIJQ(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
	}

	private static void MIEHGTLMTOG(int EOOEIROQJOE)
	{
	}

	private void MONJFKLHSNJ()
	{
	}

	public static void AddToRecentStages(int SINKIFTPIER)
	{
	}

	private static void NOKHPQNIOIF()
	{
	}

	private static void LQOPEFGSTFE()
	{
	}

	public static void SetExpeditionSeen()
	{
	}

	public static void AddEntryTicket()
	{
	}

	public static bool ShouldEnterExpeditionPanel()
	{
		return false;
	}

	public static void SetEnterExpeditionPanel()
	{
	}

	public static void OnEnterExpeditionPanel()
	{
	}

	public static void Test_FinishLevel()
	{
	}

	public MinibossConfig GetMinibossConfig()
	{
		return null;
	}

	public bool ShouldStageHaveMiniboss()
	{
		return false;
	}

	public WorldData.JQNPLTQOFMJ GetWorldType()
	{
		return default(WorldData.JQNPLTQOFMJ);
	}

	public int GetWorldVariation()
	{
		return 0;
	}

	public int GetNumStages()
	{
		return 0;
	}

	public float GetDensity()
	{
		return 0f;
	}

	public int GetEnemyLevel(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public bool IsEnemyEliteAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return false;
	}

	public int GenerateNewStageId(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public uint GetSeed(int MTFHQPOPFKQ)
	{
		return 0u;
	}

	public bool IsEnemyTypeAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return false;
	}

	public float GetEliteChance(int MTFHQPOPFKQ)
	{
		return 0f;
	}

	public EnemyCount GetEnemyCount(int MTFHQPOPFKQ)
	{
		return default(EnemyCount);
	}

	public float GetDensity(int MTFHQPOPFKQ)
	{
		return 0f;
	}

	public int GetEliteLevelAdd(int MTFHQPOPFKQ)
	{
		return 0;
	}

	public string GetAnalyticsContext()
	{
		return null;
	}

	private static JJHFPNTSRLT.WeaponPartIdentifier LMRSQKHLMTS(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return default(JJHFPNTSRLT.WeaponPartIdentifier);
	}

	private static bool IIGPFFLEMNN(ExpeditionData.ExpeditionLevel NERGMFPHLIM)
	{
		return false;
	}

	private static bool TGSNIPTOFKQ(ExpeditionData.ExpeditionRewardSingle QFJFSEMOOEH)
	{
		return false;
	}
}
