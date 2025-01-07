using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class Account : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		public ObscuredInt level;

		public ObscuredLong xp;

		public ObscuredInt lastRewardGranted;

		public ObscuredString version;

		public ObscuredInt maxClearedEnemyLevel;

		public ObscuredInt maxNonSkulledClearedEnemyLevel;

		public ObscuredInt joinDiscordPopupShown;

		public ObscuredInt joinDiscordClicked;

		public ProfileIcon profileIcon;

		public bool attributeRerollTutorialSeen;

		public bool duplicateLegendaryTutorialSeen;

		public List<JJHFPNTSRLT.RecipeIdInteger> dynamicCraftTutorialSeen;

		public bool raidAutoCompleteTutorialSeen;

		public bool weeklyContractsTutorialSeen;

		public bool workshopTutorialFuseReturnSeen;

		public bool workshopTutorialTransformReturnSeen;

		public bool tutorialGearBonusLockingSeen;

		public bool firstLoginRewardClaimed;

		public List<MNJMPEKHPTO> firstStackingSeenReroll;

		public List<MNJMPEKHPTO> firstStackingSeenTransform;

		public List<MNJMPEKHPTO> firstStackingSeenTransformBonusList;

		public List<MNJMPEKHPTO> firstStackingSeenBonusList;

		public List<ProfileIcon.LOQMGTKOSMM> unlockedIcons;

		public List<ProfileIcon.PNQEKROLFPK> unlockedFrames;

		public SerializableDictionary<GameController.KFPHKOMNHSS, string> limitedXpGrants;
	}

	[Serializable]
	public class Stats
	{
		[Serializable]
		public class EnemyKill
		{
			public EnemySpot.SMMGLQPTJET type;

			public int amount;
		}

		[Serializable]
		public class GameplayType
		{
			public GameController.KFPHKOMNHSS playType;

			public int maxClearedEnemyLevel;

			public int maxNonSkulledClearedEnemyLevel;
		}

		[CompilerGenerated]
		private sealed class QEMITKRFMEP
		{
			public GameController.KFPHKOMNHSS _playType;

			internal bool _003CGetGameplayType_003Eb__0(GameplayType p)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class EQRNQSIGQQQ
		{
			public int minSeen;

			internal bool _003CGetHighestRarityWeaponSeen_003Eb__0(JJHFPNTSRLT.RarityNumber x)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class SKTSPHTNKEQ
		{
			public JJHFPNTSRLT.PQRIQGIOGQT r;

			internal bool _003CGetWeaponsOfRaritySeenCount_003Eb__0(JJHFPNTSRLT.RarityNumber x)
			{
				return false;
			}
		}

		public List<EnemyKill> enemyKills;

		public List<GameplayType> playType;

		public List<JJHFPNTSRLT.RarityNumber> weaponsSeenOfRarity;

		public int raidsEntered;

		public int globalLevelCompleted;

		public void SMGSELMRORF(int HHFHLJFISQF, GameController.KFPHKOMNHSS TGMPGTEGKIL)
		{
		}

		public void KNFEKTMGETS(int HHFHLJFISQF, GameController.KFPHKOMNHSS TGMPGTEGKIL)
		{
		}

		public void TGESKQJOOJS()
		{
		}

		public GameplayType PKENRPQRSTF(GameController.KFPHKOMNHSS TGMPGTEGKIL)
		{
			return null;
		}

		public void STTHSGLOGEG(EnemySpot.SMMGLQPTJET EOOEIROQJOE, int ISLTSKEPJPI = 1)
		{
		}

		public bool HTSQMKROLJP(ItemWeapon QTRSFNTGTSR)
		{
			return false;
		}

		public JJHFPNTSRLT.PQRIQGIOGQT MMMKJHFNQEK(int QGHONJPKMPE = 1)
		{
			return default(JJHFPNTSRLT.PQRIQGIOGQT);
		}

		public int TEQNTJQSQGL(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
		{
			return 0;
		}

		public void JPGIHPGOMGS(int TGJNSKTGPRE)
		{
		}
	}

	[Serializable]
	public struct SpecOpDifficultyXpMultiplier
	{
		public OperationController.JMSSNJLGTFN difficulty;

		public float multiplier;
	}

	[Serializable]
	public struct Config
	{
		public long[] xp_requirements;

		public int[] xp_predefined_gains;

		public int xp_reward_per_level;

		public List<SpecOpDifficultyXpMultiplier> xp_specop_multipliers;

		public float expedition_xp_multiplier;

		public float skirmish_xp_multiplier;

		public float boss_xp_multiplier;

		public int unlock_lvl_shop_dailies;

		public int unlock_lvl_shop_legendary_chest;

		public int unlock_lvl_operations;

		public int unlock_lvl_operations_hard;

		public int unlock_lvl_operations_extreme;

		public int unlock_lvl_base;

		public int unlock_lvl_global_tab;

		public int starting_gems;

		public int unlocklvl_loadout_2;

		public int unlocklvl_loadout_3;

		public int unlocklvl_loadout_4;

		public int unlock_lvl_expeditions;

		public int unlock_lvl_raids;

		public int unlock_lvl_rifts;

		public int unlock_lvl_workshop;

		public int unlock_lvl_skirmish;

		public int unlock_lvl_shards_offer;

		public int unlock_lvl_weeklycontracts;

		public int unlock_lvl_clans;

		public int raid_unlock_ticket_reward;

		public int workshop_unlock_fragment_reward;

		public float story_multiplier;

		public float hell_multiplier;

		public bool grant_xp_rewards_lower_hunt;

		public int first_login_reward_gems;
	}

	[CompilerGenerated]
	private sealed class FLGMFPFEJJJ
	{
		public int difficulty;

		internal bool _003CGetXpForLevel_003Eb__0(SpecOpDifficultyXpMultiplier x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HTQGSQLOQNI
	{
		public PJLTIFIPFSM recipe;

		internal bool _003CIsMultiCraftTutorialSeen_003Eb__0(JJHFPNTSRLT.RecipeIdInteger x)
		{
			return false;
		}
	}

	private static Data TSRPFHOJKSG;

	private static Config SOSLGOOOIPG;

	private static Stats IEMHEIGSFNH;

	private static bool QOOPLGKOOLG;

	private static bool LOKJOFSSELO;

	private static bool FGIPONSQIMT;

	private static EOFFPGJPEOM IMHJOLFSNME;

	public static TMRSFTIETMS playerPath;

	public static string KEY;

	public static string STATS_KEY;

	public static event Action PHJMNNTKETL
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

	public static int GetMaxClearedEnemyLevel()
	{
		return 0;
	}

	public static int GetMaxClearedEnemyLevel(GameController.KFPHKOMNHSS NSQRHJPNSGL)
	{
		return 0;
	}

	public static int GetMaxClearedNonSkulledEnemyLevel(GameController.KFPHKOMNHSS NSQRHJPNSGL)
	{
		return 0;
	}

	public static int GetMaxClearedNonSkulledEnemyLevel()
	{
		return 0;
	}

	private void Awake()
	{
	}

	public static EOFFPGJPEOM GetLootImprovements()
	{
		return null;
	}

	private void MEEEMOMNERG()
	{
	}

	private static void ILKGHTKLRJN()
	{
	}

	private static void LKKGMEOIPOQ()
	{
	}

	private void OnDestroy()
	{
	}

	public static void Clear()
	{
	}

	public static bool IsInitialized()
	{
		return false;
	}

	private static void MLNESSGJRME()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void LQLHMTIJIJN()
	{
	}

	public static void SaveData()
	{
	}

	public static void SaveStats()
	{
	}

	public static void GainXP(long PQJFJINPGPL)
	{
	}

	private static void LJGRKSMORGP()
	{
	}

	public static Data GetData()
	{
		return null;
	}

	public static Config GetConfig()
	{
		return default(Config);
	}

	public static Stats GetStats()
	{
		return null;
	}

	public static int GetLevel()
	{
		return 0;
	}

	public static int GetMaxLevel()
	{
		return 0;
	}

	public static long GetCurrentXP()
	{
		return 0L;
	}

	public static long GetGoalXpForLevel(int NERGMFPHLIM)
	{
		return 0L;
	}

	public static long GetCurrentGoalXP()
	{
		return 0L;
	}

	public static bool IsMaxLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static int GetXpForLootLevel(int NERGMFPHLIM)
	{
		return 0;
	}

	public static void GainXpForLevel(int HHFHLJFISQF, GameController.KFPHKOMNHSS NSQRHJPNSGL, int OPJNKTMSTJR, int LLMHHPMHIHS, bool ELGGEIJOMNK)
	{
	}

	public static int GetXpForLevel(int HHFHLJFISQF, GameController.KFPHKOMNHSS NSQRHJPNSGL, int OPJNKTMSTJR, int LLMHHPMHIHS, bool LIQGLGKPMPE)
	{
		return 0;
	}

	public static int GetOperationUnlockLevel()
	{
		return 0;
	}

	public static bool IsTabGlobalUnlocked()
	{
		return false;
	}

	public static void SetJoinDiscordPopupShown(int QPNIRNRNJON)
	{
	}

	public static void SetJoinDiscordPopupClicked()
	{
	}

	public static int CalculateTotalExperience()
	{
		return 0;
	}

	public static bool IsIconUnlocked(ProfileIcon.LOQMGTKOSMM ITRKNMFTGIG)
	{
		return false;
	}

	public static bool IsFrameUnlocked(ProfileIcon.PNQEKROLFPK IOTMPGKLTMT)
	{
		return false;
	}

	public static void UnlockIcon(ProfileIcon.LOQMGTKOSMM ITRKNMFTGIG)
	{
	}

	public static void UnlockFrame(ProfileIcon.PNQEKROLFPK IOTMPGKLTMT)
	{
	}

	public static bool IsOperationsUnlocked()
	{
		return false;
	}

	public static List<OperationController.JMSSNJLGTFN> GetUnlockedOperationDifficulties()
	{
		return null;
	}

	public static List<OperationController.JMSSNJLGTFN> GetUnlockedOperationDifficultiesForLevel(int NERGMFPHLIM)
	{
		return null;
	}

	public static bool IsOperationsUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static int GetOperationDifficultyUnlockLevel(OperationController.JMSSNJLGTFN OPJNKTMSTJR)
	{
		return 0;
	}

	public static bool IsRiftsUnlocked()
	{
		return false;
	}

	public static bool IsRiftsUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static bool IsClansUnlocked()
	{
		return false;
	}

	public static bool IsClansUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static bool IsShopDailiesUnlocked()
	{
		return false;
	}

	public static bool IsShopDailiesUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static bool IsLegendaryChestUnlocked()
	{
		return false;
	}

	public static bool IsRaidsUnlocked()
	{
		return false;
	}

	public static int GetRaidsUnlockLevel()
	{
		return 0;
	}

	public static bool IsRaidsUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static int GetRaidUnlockTicketReward()
	{
		return 0;
	}

	public static bool IsWorkshopUnlocked()
	{
		return false;
	}

	public static bool IsWorkshopUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static int GetWorkshopUnlockLevel()
	{
		return 0;
	}

	private static void IFHKGSQLORG()
	{
	}

	private static void GSQTNHLHTTP()
	{
	}

	private static void MQQQLJQSOJL()
	{
	}

	private static void OQTEKGGMFOQ()
	{
	}

	private static void NJIKIJMMSRE()
	{
	}

	private static void LGIQLROPNPL()
	{
	}

	public static bool IsExpeditionsUnlocked()
	{
		return false;
	}

	public static bool IsExpeditionsUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static bool IsSkirmishUnlocked()
	{
		return false;
	}

	public static bool IsSkirmishUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static bool IsBaseUnlocked()
	{
		return false;
	}

	public static bool IsBaseUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static bool IsWeeklyContractsUnlocked()
	{
		return false;
	}

	public static bool IsWeeklyContractsUnlockedAtLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static bool IsAttributeRerollTutorialSeen()
	{
		return false;
	}

	public static void SetAttributeRerollTutorialSeen()
	{
	}

	public static bool IsDuplicateLegendaryTutorialSeen()
	{
		return false;
	}

	public static void SetDuplicateLegendaryTutorialSeen()
	{
	}

	public static bool IsMultiCraftTutorialSeen(PJLTIFIPFSM LQKPOLSLLJQ)
	{
		return false;
	}

	public static void SetMultiCraftTutorialSeen(PJLTIFIPFSM LQKPOLSLLJQ)
	{
	}

	public static bool IsRaidAutoCompleteTutorialSeen()
	{
		return false;
	}

	public static void SetRaidAutoCompleteTutorialSeen()
	{
	}

	public static bool IsWeeklyContractsTutorialSeen()
	{
		return false;
	}

	public static void SetWeeklyContractsTutorialSeen()
	{
	}

	public static bool IsWorkshopTutorialFuseReturnSeen()
	{
		return false;
	}

	public static void SetWorkshopTutorialFuseReturnSeen()
	{
	}

	public static bool IsWorkshopTutorialTransformReturnSeen()
	{
		return false;
	}

	public static void SetWorkshopTutorialTransformReturnSeen()
	{
	}

	public static bool IsStackingInfoSeenInTransform(MNJMPEKHPTO HSLQJLPMLMH)
	{
		return false;
	}

	public static bool IsStackingInfoSeenInTransformBonusList(MNJMPEKHPTO HSLQJLPMLMH)
	{
		return false;
	}

	public static bool IsStackingInfoSeenInBonusList(MNJMPEKHPTO HSLQJLPMLMH)
	{
		return false;
	}

	public static bool IsStackingInfoSeenInReroll(MNJMPEKHPTO HSLQJLPMLMH)
	{
		return false;
	}

	public static void SetStackingInfoSeenInTransform(MNJMPEKHPTO HSLQJLPMLMH)
	{
	}

	public static void SetStackingInfoSeenInTransformBonusList(MNJMPEKHPTO HSLQJLPMLMH)
	{
	}

	public static void SetStackingInfoSeenInBonusList(MNJMPEKHPTO HSLQJLPMLMH)
	{
	}

	public static void SetStackingInfoSeenInReroll(MNJMPEKHPTO HSLQJLPMLMH)
	{
	}

	private static bool GSHTGQPNJFN(List<MNJMPEKHPTO> GRJRQRKLHIH, MNJMPEKHPTO HSLQJLPMLMH)
	{
		return false;
	}

	private static void TLQNKRGFOFP(ref List<MNJMPEKHPTO> GRJRQRKLHIH, MNJMPEKHPTO HSLQJLPMLMH)
	{
	}

	public static bool IsTutorialGearBonusLockingSeen()
	{
		return false;
	}

	public static void SetTutorialGearBonusLockingSeen()
	{
	}

	public static bool IsLoadoutUnlocked(int LTMHMRFKTML)
	{
		return false;
	}

	public static int GetLoadoutUnlockLevel(int LTMHMRFKTML)
	{
		return 0;
	}

	public static bool IsLimitedXpClaimedForPlayType(GameController.KFPHKOMNHSS HKFOJSGMRMJ)
	{
		return false;
	}

	private static void EQSRQKNJOIO(GameController.KFPHKOMNHSS HKFOJSGMRMJ)
	{
	}

	public static bool ShouldGrantXpAndPassXpForPlayType(GameController.KFPHKOMNHSS HKFOJSGMRMJ, int HHFHLJFISQF)
	{
		return false;
	}

	public static bool IsFirstLoginRewardClaimed()
	{
		return false;
	}

	public static bool IsFirstLoginRewardClaimAvailable()
	{
		return false;
	}

	private static void GKNGPMTRKPM()
	{
	}

	private static void NKSQLTSPNLM()
	{
	}

	public static void TryClaimFirstLoginReward()
	{
	}

	public void PrintXpAtProgress(int NJSSSTOQQNI, int IQLQQNIPTPQ)
	{
	}
}
