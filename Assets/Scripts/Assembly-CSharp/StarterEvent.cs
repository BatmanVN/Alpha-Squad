using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class StarterEvent : MonoBehaviour
{
	private enum SPOIRHJQGKG
	{
		Unset = 0,
		Available = 1,
		Killed = 2
	}

	[Serializable]
	private class Data
	{
		public int start;

		public ObscuredInt currency;

		public bool purchased;

		public string gameData;

		public bool introSeen;

		public int lastRemindTimestamp;

		public List<int> claimedFreeMilestoneRewards;

		public List<int> claimedPaidMilestoneRewards;

		public List<int> boostData;

		public int playsGems;

		public int playsRealMoney;

		public int lastPlayGemsResetTimestamp;

		public int lastPlayRealMoneyResetTimestamp;

		public int playsAds;

		public int lastPlayAdsResetTimestamp;

		public int lastPlayAdsTimestamp;

		public bool seasonEnded;

		public SPOIRHJQGKG killed;
	}

	public class LQHQTGGFITT
	{
		public bool LKJKNRFMJQG;

		public int MKLLHHINHJP;

		public int GSJHPTLEOOE;

		public int RRMPRTLSLSR;

		public CurrencyDropConfig RNMHRNSSIIQ;

		public int TJIOKEGLGIG;

		public int MRSJRLFTHIJ;

		public bool KIQQHPJLMPQ;

		public bool HEQEGHPEGIK;

		public bool ESQGPEFHOJP;

		public int POKFNHLOTLN;

		public int PJENKETIGSR;

		public int IHRSOLHGSEP;

		public int FTINPSHFGPG;

		public int TENLSOKLPKF;

		public int FTFIJSMJILN;

		public int TMJOHGKSLST;

		public int PQORTMMEOFK;

		public int KHHNMNTMHOO;

		public int NPHRQELTGKJ;

		public int ILEOHJHJTGH;

		public int KJQNLKEFNGR;

		public int SRPRKQMIHRI;

		public float ELHLTISOLFQ;
	}

	[CompilerGenerated]
	private sealed class FMNQIMPGMNM
	{
		public Action OnPurchaseCompleted;

		internal void _003CPlayGameRealMoney_003Eb__0(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class KQETLOPJSOJ
	{
		public Action OnPlaySuccess;

		internal void _003CPlayGameAd_003Eb__1(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class RFQSQPOQFRO
	{
		public int index;

		public bool paid;

		public Action onAfterClaim;
	}

	[CompilerGenerated]
	private sealed class TGFNKPEIJKK
	{
		public Action<string> onPurchase;

		internal void _003CPurchasePremiumLarge_003Eb__0(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class JNLJTQGMIQT
	{
		public Action<string> onPurchase;

		internal void _003CPurchasePremiumSmall_003Eb__0(bool ok)
		{
		}
	}

	private static bool LSOMHHEFKMG;

	private static Data TSRPFHOJKSG;

	private static LQHQTGGFITT SOSLGOOOIPG;

	private static bool OHQHKQJEILO;

	private static LNLJKJLGQIP EHJPSQLTGHF;

	public static string KEY;

	public static string LOOT_SOURCE_GAME;

	private static string FHOJOFMPTJE;

	private static string IIFPSFLORPP;

	public static string LOOT_SOURCE_PLAY;

	public static event Action TRGFMHSRINM
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

	public static event Action QGERLRREGNG
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

	public static event Action SKGPRFQEORH
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

	public static event Action IPIEMKONKGF
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

	private static void MLNESSGJRME()
	{
	}

	private static void LNJPNMFSIIQ()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void PMITOIOJNOT()
	{
	}

	private static void TIEMEROSGKK()
	{
	}

	public static void Clear()
	{
	}

	public static void Reset()
	{
	}

	private static int JGEIQTPELEG()
	{
		return 0;
	}

	public static bool IsActive()
	{
		return false;
	}

	public static int GetTimeRemaining()
	{
		return 0;
	}

	private static void PKTMERMOHGE()
	{
	}

	public static QLLSTRPMHKK.GHJKTESNSGI GetCurrentTimeType()
	{
		return default(QLLSTRPMHKK.GHJKTESNSGI);
	}

	public static bool IsEndingSoon()
	{
		return false;
	}

	public static int GetTimeRemainingUntilNextTimeType()
	{
		return 0;
	}

	public static int GetCurrency()
	{
		return 0;
	}

	public static void AddCurrency(int ISLTSKEPJPI)
	{
	}

	public static bool ShouldDropCurrency(int QJQINTKJTJQ, bool KKQQJQLKHMP, System.Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static bool ShouldDropCurrencyForMiniboss(int QJQINTKJTJQ, System.Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static bool ShouldDropCurrencyForLootbox(int QJQINTKJTJQ, OperationController.JMSSNJLGTFN OPJNKTMSTJR, System.Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static int GetCurrencyDropAmount(int QJQINTKJTJQ, bool KKQQJQLKHMP, System.Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int GetCurrencyDropAmountMiniBoss(int QJQINTKJTJQ, System.Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int GetDropAmountLootbox(int QJQINTKJTJQ, OperationController.JMSSNJLGTFN JOLFHPIHIEJ, System.Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int GetDropAmountChest(int QJQINTKJTJQ, ChestController.MFRETPOLGOE HTRLEQMGOOO, System.Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static ArcadePassConfig GetConfig()
	{
		return null;
	}

	public static ArcadePassSeasonConfig GetEventConfig()
	{
		return null;
	}

	public static void SetIntroShown()
	{
	}

	public static void SetOutroShown()
	{
	}

	public static void SetRemindShown()
	{
	}

	public static bool ShouldShowIntro()
	{
		return false;
	}

	public static bool ShouldShowReminder()
	{
		return false;
	}

	public static bool ShouldShowOutro()
	{
		return false;
	}

	public static LNLJKJLGQIP GetGame()
	{
		return null;
	}

	public static int GetPlayCountPass()
	{
		return 0;
	}

	public static int GetPlayCountPassLarge()
	{
		return 0;
	}

	public static int GetBoostProgressForIndex(int PSPJIJNTMOI)
	{
		return 0;
	}

	public static bool IsAllGiftboxesMaxed()
	{
		return false;
	}

	public static void PlayGameGems()
	{
	}

	public static int GetPlayCountGems()
	{
		return 0;
	}

	public static int GetPricePlayGems()
	{
		return 0;
	}

	public static bool IsPlayEnabledGems()
	{
		return false;
	}

	public static int GetPlaysRemainingGems()
	{
		return 0;
	}

	public static bool IsPlayAvailableGems()
	{
		return false;
	}

	public static int GetResetTimeRemainingGems()
	{
		return 0;
	}

	public static int GetLimitPlaysGems()
	{
		return 0;
	}

	public static void PlayGameRealMoney(Action OSQEKQHHMNH)
	{
	}

	public static string GetPricePlayRealMoney()
	{
		return null;
	}

	public static bool IsPlayEnabledRealMoney()
	{
		return false;
	}

	public static int GetPlayCountRealMoney()
	{
		return 0;
	}

	public static bool IsPlayAvailableRealMoney()
	{
		return false;
	}

	public static int GetPlaysRemainingRealMoney()
	{
		return 0;
	}

	public static int GetResetTimeRemainingRealMoney()
	{
		return 0;
	}

	public static int GetLimitPlaysRealMoney()
	{
		return 0;
	}

	public static void PlayGameCurrency()
	{
	}

	public static bool IsPlayAvailableCurrency()
	{
		return false;
	}

	public static int GetPlayCountCurrency()
	{
		return 0;
	}

	private static void EHSSEIPLITQ()
	{
	}

	public static int GetPricePlayCurrency()
	{
		return 0;
	}

	public static void PlayGameAd(Action NGQQOHRQMPI)
	{
	}

	public static int GetPlayCountAds()
	{
		return 0;
	}

	public static bool IsPlayEnabledAds()
	{
		return false;
	}

	public static int GetPlaysRemainingAds()
	{
		return 0;
	}

	public static bool IsPlayAvailableAds()
	{
		return false;
	}

	public static int GetResetTimeRemainingAds()
	{
		return 0;
	}

	public static int GetLimitPlaysAds()
	{
		return 0;
	}

	public static string GetMilestoneSource(bool FKPPEQLPJHJ)
	{
		return null;
	}

	public static bool IsMilestoneRewardClaimable(int LSGHOSTOGTM)
	{
		return false;
	}

	public static bool IsMilestoneRewardClaimed(int PSPJIJNTMOI, bool FKPPEQLPJHJ)
	{
		return false;
	}

	private static void NTRJMPIFJTL(int PSPJIJNTMOI, bool FKPPEQLPJHJ)
	{
	}

	public static void ClaimMilestoneReward(int PSPJIJNTMOI, bool FKPPEQLPJHJ, Action JPLQMGKQFNP)
	{
	}

	public static bool AnyUnclaimedMilestoneRewards()
	{
		return false;
	}

	private static bool GELRGILOKPF()
	{
		return false;
	}

	public static void PurchasePremiumLarge(Action<string> ETLGJKKSMOJ)
	{
	}

	public static void PurchasePremiumSmall(Action<string> ETLGJKKSMOJ)
	{
	}

	public static bool IsPurchased()
	{
		return false;
	}

	public static void OnPurchasePlay()
	{
	}

	public static void OnPurchasePass()
	{
	}

	public static void OnPurchasePassLarge()
	{
	}

	private static int KILMLMQFGSE(int MQSTJHFMETT)
	{
		return 0;
	}

	private static int NEPKKSOIMNJ(DateTime KQSFOENOONK, DateTime TNEEGPGGOIT)
	{
		return 0;
	}

	public static Board.TrackEventData GetTrackingData(int FTIJPMPJLGI, List<int> PQTMRSHQORR, List<int> MMSMHOKJNQM, string FLIRPKFSNML = "")
	{
		return null;
	}

	public static bool IsStarterChest(ChestController.MFRETPOLGOE MROKKGHHGTN)
	{
		return false;
	}

	public static ChestConfigData GetChestConfigData(ChestController.MFRETPOLGOE MROKKGHHGTN)
	{
		return null;
	}
}
