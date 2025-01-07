using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Pass;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassController : MonoBehaviour
{
	[Serializable]
	public class RewardOverride
	{
		public int index;

		public ERLKIIFQKSI category;

		public PassData.PassReward newReward;
	}

	[Serializable]
	public struct Data
	{
		public int seasonIndex;

		public KKRGOHJEOSR currentActivePassId;

		public ObscuredInt level;

		public ObscuredInt xp;

		public bool newSeason;

		public bool purchased;

		public bool premium;

		public bool skipped;

		public int claimedFinalRewards;

		public List<int> claimedFreeRewards;

		public List<int> claimedPaidRewards;

		public List<int> claimedPremiumRewards;

		public List<RewardOverride> rewardOverrides;

		public SerializableDictionary<GameController.KFPHKOMNHSS, string> limitedClaimedRewards;

		public bool seasonNull;
	}

	[Serializable]
	public struct Config
	{
		public int xp_gain_regular;

		public int xp_gain_regular_boss;

		public int xp_gain_raid;

		public int xp_gain_operations;

		public int xp_gain_expeditions;

		public int[] xp_gain_skirmish;

		public int xp_gain_hell;

		public int pass_time_start;

		public int pass_level_skip_price;

		public int pass_ending_remaining;

		public int bonus_safe_max_claims;

		public int bonus_cash_per_level;

		public int bonus_cash_per_level_purchased;

		public int bonus_cash_per_level_premium;

		public int bonus_safe_refill_price;

		public int premium_level_skip;

		public bool final_skip_enabled;
	}

	private static Data TSRPFHOJKSG;

	private const int HHJELHRTTKP = 50;

	private const int EORHNLJJMQG = 1000;

	private static Config SOSLGOOOIPG;

	private static bool QOOPLGKOOLG;

	private static bool EHRFRMJKQML;

	private static PassData IIOIHSIGKRN;

	public static string KEY;

	public static event Action JMREPIHJGNT
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

	public static event Action EFRKRNGRSSG
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

	public static event Action<int, bool> RSENRNFPEEO
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

	public static void Clear()
	{
	}

	public static void Init()
	{
	}

	public static void TestXpState()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static void SaveData()
	{
	}

	public static void ResetData()
	{
	}

	private static void MNRMNPTLLJG(int IIHISGQETRJ)
	{
	}

	private static void GQPRSEMEJQK()
	{
	}

	public static void OnPassSeen()
	{
	}

	public static bool AnyUnclaimedRewardsForLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static void SetEndNotificationShown()
	{
	}

	public static void DebugSkipSeason()
	{
	}

	private static void NKHSSGGIENJ()
	{
	}

	public static int CalculateTotalExperience()
	{
		return 0;
	}

	public static int GetSeasonIndex()
	{
		return 0;
	}

	private static int NFHSMGLSMQO()
	{
		return 0;
	}

	public static bool IsPassUnlocked()
	{
		return false;
	}

	public static bool IsPassAvailable()
	{
		return false;
	}

	private static bool KTLPLGPELOI(int GRIJOQOJLGJ = -1)
	{
		return false;
	}

	public static bool IsPassCompleted()
	{
		return false;
	}

	public static int GetXpRemainingToMax()
	{
		return 0;
	}

	public static bool IsPassEndingSoon()
	{
		return false;
	}

	private static KKRGOHJEOSR FMGKJSGTGIO()
	{
		return default(KKRGOHJEOSR);
	}

	public static KKRGOHJEOSR GetActivePassId()
	{
		return default(KKRGOHJEOSR);
	}

	public static PassData GetActivePassData()
	{
		return null;
	}

	public static int GetTimeRemaining()
	{
		return 0;
	}

	public static bool IsPassNew()
	{
		return false;
	}

	public static bool AnyUnclaimedRewards()
	{
		return false;
	}

	public static bool IsPremiumPassAvailable()
	{
		return false;
	}

	public static bool IsSeasonEndingPopupSeen()
	{
		return false;
	}

	public static int GetTotalLevelsCount()
	{
		return 0;
	}

	public static void SetPassPurchased()
	{
	}

	public static bool IsPassPurchased()
	{
		return false;
	}

	public static bool IsSkipPurchased()
	{
		return false;
	}

	public static bool CanPurchaseSkip()
	{
		return false;
	}

	public static void SkipLevelPurchased()
	{
	}

	public static void SetPremiumPurchased()
	{
	}

	public static bool IsPremiumPurchased()
	{
		return false;
	}

	public static bool IsOldPassBonusReward()
	{
		return false;
	}

	public static int GetClaimedFinalRewardsCount()
	{
		return 0;
	}

	public static bool IsFinalBonusAvailable()
	{
		return false;
	}

	public static int GetTotalAvailableBonusRewards()
	{
		return 0;
	}

	public static int GetUnclaimedBonusRewardsCounts()
	{
		return 0;
	}

	public static int GetBonusTotalUnclaimedCash()
	{
		return 0;
	}

	public static int ClaimAllAvailableBonusRewards()
	{
		return 0;
	}

	public static bool IsAllBonusRewardsClaimed()
	{
		return false;
	}

	public static int GetTotalBonusReward()
	{
		return 0;
	}

	public static int GetBonusSafeMaxClaims()
	{
		return 0;
	}

	public static int GetSingleBonusReward()
	{
		return 0;
	}

	public static int GetRemainingBonusReward()
	{
		return 0;
	}

	public static bool CanResetSafe()
	{
		return false;
	}

	public static bool ResetSafe()
	{
		return false;
	}

	public static LootElement GetRefillPrice()
	{
		return default(LootElement);
	}

	private static bool NENITELQGSG(ref PassData.PassReward QFJFSEMOOEH)
	{
		return false;
	}

	public static bool IsPaidRewardAvailable(int PSPJIJNTMOI)
	{
		return false;
	}

	public static bool IsFreeRewardAvailable(int PSPJIJNTMOI)
	{
		return false;
	}

	public static bool IsPremiumRewardAvailable(int PSPJIJNTMOI)
	{
		return false;
	}

	public static bool IsRewardOfTypeAvailable(ERLKIIFQKSI KRJHKPTMEPE, int PSPJIJNTMOI)
	{
		return false;
	}

	private static void OIJQGJLSEHP(int PSPJIJNTMOI)
	{
	}

	private static void EFLKOLFPKOF(int PSPJIJNTMOI)
	{
	}

	private static void NFSLSEEGSGE(int PSPJIJNTMOI)
	{
	}

	public static void TryClaimReward(ERLKIIFQKSI KRJHKPTMEPE, int PSPJIJNTMOI)
	{
	}

	public static void GrantRewardToPlayer(PassData.PassReward QFJFSEMOOEH, int PSPJIJNTMOI, Action<List<LootElement>> MHQNMTJRLIO, ERLKIIFQKSI JLNPMQIGRMG)
	{
	}

	public static List<int> GetClaimedFreeRewards()
	{
		return null;
	}

	public static List<int> GetClaimedPaidRewards()
	{
		return null;
	}

	public static List<int> GetClaimedPremiumRewards()
	{
		return null;
	}

	public static bool IsFreeRewardClaimed(int PSPJIJNTMOI)
	{
		return false;
	}

	public static bool IsPaidRewardClaimed(int PSPJIJNTMOI)
	{
		return false;
	}

	public static bool IsPremiumRewardClaimed(int PSPJIJNTMOI)
	{
		return false;
	}

	public static bool IsRewardOfTypeClaimed(ERLKIIFQKSI NNTTFRFJNQF, int PSPJIJNTMOI)
	{
		return false;
	}

	public static PassData GetPassData(KKRGOHJEOSR EHGGOJQIMLQ)
	{
		return null;
	}

	public static int GetXpGainForPlayType(GameController.KFPHKOMNHSS HKFOJSGMRMJ, bool LIQGLGKPMPE = false)
	{
		return 0;
	}

	public static void GainExperience(int PQJFJINPGPL, bool QLEJRIQMQTN = false)
	{
	}

	public static int GetCurrentXP()
	{
		return 0;
	}

	public static int GetCurrentGoalExperience()
	{
		return 0;
	}

	public static int GetGoalExperienceForLevel(int IQLQQNIPTPQ)
	{
		return 0;
	}

	public static int GetLevel()
	{
		return 0;
	}

	public static bool IsMaxLevel()
	{
		return false;
	}

	public static bool IsMaxLevelWithoutBonusClaims()
	{
		return false;
	}

	public static int GetMaxLevel()
	{
		return 0;
	}

	public static int GetMaxLevelWithBonusClaims()
	{
		return 0;
	}

	public static void SkipLevel(bool LIPENRNHTJL = true)
	{
	}

	public static bool BuyLevelSkip(int JLHFQGGJIKJ = 1, bool LIPENRNHTJL = true)
	{
		return false;
	}

	public static bool IsFinalSkipAvailable()
	{
		return false;
	}

	public static int GetLevelSkipPrice()
	{
		return 0;
	}

	public static int GetPremiumLevelSkipCount()
	{
		return 0;
	}

	public static bool IsLimitedRewardClaimedForPlayType(GameController.KFPHKOMNHSS HKFOJSGMRMJ)
	{
		return false;
	}

	private static void PLOKOLSMLPL(GameController.KFPHKOMNHSS HKFOJSGMRMJ)
	{
	}

	private static void MMMPKJOOLPJ(Scene MHNOIFFONJM, LoadSceneMode HTQEHIEEPTN)
	{
	}

	private static void HENELGRIJLH()
	{
	}

	public static void ApplyXpGainOnLevelCompleted(GameController.KFPHKOMNHSS NSQRHJPNSGL)
	{
	}

	[CompilerGenerated]
	internal static JJHFPNTSRLT.PQRIQGIOGQT QRNMMLKPLKK(JJHFPNTSRLT.PQRIQGIOGQT QPNIRNRNJON, JJHFPNTSRLT.PQRIQGIOGQT PRRKFGTQTJK, JJHFPNTSRLT.PQRIQGIOGQT NHJLNIHMJRG)
	{
		return default(JJHFPNTSRLT.PQRIQGIOGQT);
	}
}
