using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkirmishController : MonoBehaviour, EKFFMKLSSNN
{
	[Serializable]
	public struct Config
	{
		public int start_timestamp;

		public int duration;

		public ERTTJTQLQJE[] gameplay_mode_sequence;

		public EnemyCount enemy_count;

		public float enemy_convert_elite_chance;

		public int[] modifier_value_weights;

		public int max_positive_modifiers;

		public int modifier_gem_reroll_price;

		public int modifier_reroll_cap;

		public int[] disable_stage_ids;

		public int max_threat_level;

		public JJHFPNTSRLT.LevelOffset[] level_offsets;

		public bool reroll_modifiers_on_threat_increase;

		public bool refresh_reroll_count_on_threat_increase;

		public int gm_waves_initial_wave_count;

		public float gm_waves_threat_enemy_level_add;

		public int[] gm_waves_initial_spawn_weight;

		public int gm_waves_threat_spawn_weight_add;

		public int gm_bomb_initial_timer;

		public int gm_bomb_initial_stage_count;

		public int gm_bomb_threat_timer_rm;

		public float gm_bomb_initial_segment_defuse_time;

		public int gm_bomb_initial_segment_count;

		public float gm_bomb_threat_enemy_level_add;

		public int gm_classic_initial_stage_count;

		public float gm_classic_threat_enemy_level_add;

		public int show_reroll_button_after_failed;

		public int threat_skip_price;

		public bool auto_complete_quests_allowed;

		public int auto_complete_quest_price;
	}

	[Serializable]
	public class Instance
	{
		public int totalStages;

		public WorldData.JQNPLTQOFMJ worldType;

		public ERTTJTQLQJE gameplayType;

		public List<GameModifierTiered> modifiers;

		public List<int> selectedStages;

		public int seed;
	}

	[Serializable]
	public struct Data
	{
		public int startTimestamp;

		public Instance instance;

		public QuestList activeQuests;

		public List<GameModifierTiered> modifiers;

		public WorldData.JQNPLTQOFMJ worldType;

		public ERTTJTQLQJE gameplayType;

		public int seed;

		public int gameplaySeed;

		public int gamblesClaimed;

		public int runsCompleted;

		public int rerollsLeft;

		public List<int> skipStages;

		public int enemyLevel;

		public int threatLevel;

		public bool threatIncreasedEver;

		public bool skirmishSeen;

		public int subsequentFailsWithSameModifiers;

		public float previousThreatBarAmount;
	}

	[CompilerGenerated]
	private sealed class THRJEIRLEPP
	{
		public SkirmishQuestConfigs.Config quest;

		internal bool _003CGenerateNewQuests_003Eb__0(SkirmishQuestConfigs.Config x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NSIEHLKGIFI
	{
		public List<GameModifierTiered> newModifiers;

		public List<OEJQQGFOSRJ> ignoreModifiers;

		public Predicate<GameModifierConfigs.Config> _003C_003E9__0;

		public Predicate<GameModifierConfigs.Config> _003C_003E9__1;

		internal bool _003CGenerateModifiers_003Eb__0(GameModifierConfigs.Config x)
		{
			return false;
		}

		internal bool _003CGenerateModifiers_003Eb__1(GameModifierConfigs.Config x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class LTFERSJHQOK
	{
		public GameModifierConfigs.Config x;

		internal bool _003CGenerateModifiers_003Eb__3(GameModifierTiered y)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RNTOSHHNKIE
	{
		public GameModifierConfigs.Config x;

		internal bool _003CGenerateModifiers_003Eb__4(OEJQQGFOSRJ y)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RTNPPIFETQJ
	{
		public int weightsAdd;

		public int threat;

		internal int _003CGetGameplayModeWavesConfig_003Eb__0(int x)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class RFPLORELTMT
	{
		public List<int> skip;

		public List<int> stages;

		internal bool _003CGenerateNewStageId_003Eb__0(int x)
		{
			return false;
		}
	}

	private static bool JREGORLKOST;

	private static Config SOSLGOOOIPG;

	private static Data TSRPFHOJKSG;

	private static bool GHFGQKPRRRS;

	private static bool NPLMEEHJKOM;

	public static bool threatIncreased;

	public static List<GameModifierTiered> previousModifiers;

	public static readonly int[] GAMBLES_AT_THREAT;

	public static string KEY;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private static void MLNESSGJRME()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	private static void PMITOIOJNOT()
	{
	}

	public static void Clear()
	{
	}

	private static void PQJTMEFKQQL()
	{
	}

	private static int IOKNFSQPEGO()
	{
		return 0;
	}

	private static void PQTEFJRJNRJ()
	{
	}

	private static void RLFTOLNKIJK()
	{
	}

	private static QuestList IMHHHPIRLES(ERTTJTQLQJE EHPNIQIEGQJ)
	{
		return null;
	}

	private static List<GameModifierTiered> JFKMIISSMIK(System.Random FQNLGPSKNRM, List<OEJQQGFOSRJ> MSTIMLOIRFL = null)
	{
		return null;
	}

	private static LootElement PQIKQOPRLQK(EJPTJGENOIN HSLQJLPMLMH, int FOQIJNNSRNI, List<SkirmishConfigs.QuestReward> HFKLMLNQPKK)
	{
		return default(LootElement);
	}

	public static bool IsAvailable()
	{
		return false;
	}

	public static Data GetData()
	{
		return default(Data);
	}

	public static Config GetConfig()
	{
		return default(Config);
	}

	public static WorldData.JQNPLTQOFMJ GetCurrentWorld()
	{
		return default(WorldData.JQNPLTQOFMJ);
	}

	public static int GetCurrentEnemyLevel()
	{
		return 0;
	}

	private static int JMMSPPQGPQH(int EHMSPNPMKOG)
	{
		return 0;
	}

	public static int GetRewardEnemyLevel()
	{
		return 0;
	}

	public static int GetSecondsRemaining()
	{
		return 0;
	}

	public static bool IsGambleAvailable(int EHMSPNPMKOG)
	{
		return false;
	}

	public static int GetTotalGamblesAvailable()
	{
		return 0;
	}

	private static int PKOMKQSIKPK(int EHMSPNPMKOG)
	{
		return 0;
	}

	public static bool IsGambleClaimed(int EHMSPNPMKOG)
	{
		return false;
	}

	public static bool IsGambleIndexClaimed(int PSPJIJNTMOI)
	{
		return false;
	}

	public static bool IsAllGamblesClaimed()
	{
		return false;
	}

	public static (List<RKTKKOOERQQ.GambleReward>, JJHFPNTSRLT.PQRIQGIOGQT) GetCurrentGambleReward()
	{
		return default((List<RKTKKOOERQQ.GambleReward>, JJHFPNTSRLT.PQRIQGIOGQT));
	}

	public static GambleRewardData.THHKQRSSPFN GetGambleTypeForIndex(int PSPJIJNTMOI)
	{
		return default(GambleRewardData.THHKQRSSPFN);
	}

	public static void SetGambleClaimed()
	{
	}

	public static int GetGambleGemPrice()
	{
		return 0;
	}

	public static bool ShouldEnterSkirmishPopup()
	{
		return false;
	}

	public static void SetOpenRerollPopup()
	{
	}

	public static bool ShouldEnterSkirmishRerollPopup()
	{
		return false;
	}

	public static void ResetOpenRerollPopup()
	{
	}

	public static int GetThreatLevel()
	{
		return 0;
	}

	public static float GetPreviousThreatBarAmount()
	{
		return 0f;
	}

	private static int MERHORFKNIM(int HHFHLJFISQF)
	{
		return 0;
	}

	public static bool IsThreatEverIncreased()
	{
		return false;
	}

	public static bool HasNewSkirmish()
	{
		return false;
	}

	public static void SetSkirmishSeen()
	{
	}

	public static bool CanShowAutoCompleteAllQuestsButton(int EHMSPNPMKOG)
	{
		return false;
	}

	public static bool IsAllQuestsCompleted()
	{
		return false;
	}

	public static GameplayModeWaves.Config GetGameplayModeWavesConfig()
	{
		return null;
	}

	public static GameplayModeBomb.Config GetGameplayModeBombConfig()
	{
		return null;
	}

	public static int GetSubsequentFails()
	{
		return 0;
	}

	public static bool TestQuestsCompleted(bool NFFTKPFIQRJ = true)
	{
		return false;
	}

	public static QuestList GetAllQuests()
	{
		return null;
	}

	public static void SetEnterSkirmishPopup()
	{
	}

	public static void OnEnterSkirmishPopup()
	{
	}

	public static void GenerateInstance()
	{
	}

	public static int GetStageCountForGameplayType(ERTTJTQLQJE EOOEIROQJOE, bool GOJHJKMNFTT = false)
	{
		return 0;
	}

	private void MONJFKLHSNJ()
	{
	}

	private void SMJJMNSFJRE(Enemy PFIHOFSRMEH)
	{
	}

	private static void REIGMGQJROK(Enemy PFIHOFSRMEH)
	{
	}

	public MinibossConfig GetMinibossConfig()
	{
		return null;
	}

	public static void RerollModifiers(bool LIPENRNHTJL = true, bool SGQTGILOORO = true)
	{
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

	public static void SetPreviousThreatBarAmount(float ISLTSKEPJPI)
	{
	}

	public static bool IsStillSameSkirmish()
	{
		return false;
	}

	public static void IncreaseThreat(int IRHKTMTGNIL = 1, bool LIPENRNHTJL = true)
	{
	}

	public static int GetNextGambleLevel()
	{
		return 0;
	}

	public static void IncreaseThreatToNextGamble(bool LIPENRNHTJL = true)
	{
	}

	public static bool IsThreatSkipAvailable()
	{
		return false;
	}

	public int GetNumStages()
	{
		return 0;
	}

	public float GetDensity(int MTFHQPOPFKQ)
	{
		return 0f;
	}

	public EnemyCount GetEnemyCount(int MTFHQPOPFKQ)
	{
		return default(EnemyCount);
	}

	public int GetEnemyLevel(int MTFHQPOPFKQ)
	{
		return 0;
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

	public bool IsEnemyEliteAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return false;
	}

	public float GetEliteChance(int MTFHQPOPFKQ)
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

	public static string GetStaticAnalyticsContext()
	{
		return null;
	}

	public static void ForceNextSkirmish()
	{
	}

	public static void ForceCompleteAllUncompletedQuests()
	{
	}

	[CompilerGenerated]
	internal static bool IFGPEJPRQSM(Quest ERPQFMEFQLM)
	{
		return false;
	}
}
