using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class Vip : MonoBehaviour
{
	[Serializable]
	public struct VipActivation
	{
		public long startTimestamp;

		public long endTimestamp;

		public PLFIKIOKPGQ type;

		public long JJPJPFQPRHI()
		{
			return 0L;
		}

		public long OMIGPIMMRIT(long LMJNFLONIJI)
		{
			return 0L;
		}

		public bool QSRLKSRLPGE(int LMJNFLONIJI)
		{
			return false;
		}

		public TimeSpan GJQJFRLJPJF()
		{
			return default(TimeSpan);
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class Data
	{
		public int endTimestamp;

		public int lastDailyGrantedTimestamp;

		public RSQHEFIJIQL biggestVipPurchase;

		public int loseClicked;

		public List<int> vipOffersShown;

		public List<VipActivation> vipActivations;

		public int lastOfferShownTimestamp;

		public int lastOfferToShow;

		public QGLOHONRQQN freeVipState;

		public bool vipRecentlyActive;

		public int lastReusableIndex;

		public List<RSQHEFIJIQL> reusablePurchases;

		public int lastSeenReusableIndex;
	}

	public enum RSQHEFIJIQL
	{
		WEEK = 0,
		MONTH = 1,
		YEAR = 2,
		DAY = 3
	}

	public enum PLFIKIOKPGQ
	{
		FULL = 0,
		TRIAL = 1
	}

	public enum QGLOHONRQQN
	{
		UNAVAILABLE = 0,
		CLAIMABLE = 1,
		CLAIMED = 2
	}

	[Serializable]
	public struct VipSkinGrant
	{
		public IRHNENTFPPM id;

		public int days;

		public bool TSPIMMJJQFI()
		{
			return false;
		}
	}

	[Serializable]
	public struct Config
	{
		public int daily_ticket_count;

		public int daily_hammers_count;

		public VipSkinGrant[] vip_skin_grants;

		public int offer_show_interval_seconds;

		public int offer_visible_duration;

		public int reusable_start_timestamp;

		public int reusable_end_timestamp;

		public int reusable_index;

		public RSQHEFIJIQL[] reusable_types;

		public int free_vip_duration;

		public bool free_vip_enabled;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct QSERIFRRLQS
	{
		public bool unlockPopupShown;
	}

	[CompilerGenerated]
	private sealed class FMTLIIRIINM
	{
		public bool countTrial;

		internal bool _003CHasVipBeenPurchased_003Eb__0(VipActivation x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RLKFTKMKKEF
	{
		public bool countTrials;

		public int ts;

		internal long _003CGetTotalVipDurationPassedSeconds_003Eb__0(VipActivation x)
		{
			return 0L;
		}
	}

	[CompilerGenerated]
	private sealed class QOEKFQIOOFK
	{
		public IRHNENTFPPM sid;

		internal bool _003CGetSecondsTillSkinUnlock_003Eb__0(VipSkinGrant x)
		{
			return false;
		}
	}

	private static readonly int[] QTLMGHSQPIF;

	private static readonly string[] SHRLSHLTQJQ;

	private static Config SOSLGOOOIPG;

	private static Data TSRPFHOJKSG;

	private static bool JREGORLKOST;

	public static Action OnVipStatusChangedToActivated;

	public static Action OnAnyVipActivation;

	private static bool MEKTMLEIFEI;

	public static bool claimedDailies;

	private static int SLREJMPQTJJ;

	public static string KEY;

	private static void MLNESSGJRME()
	{
	}

	public static void Clear()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static void SaveData()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	private static void RRFHMGGFGEG()
	{
	}

	private static bool SNTTKOHSIHK()
	{
		return false;
	}

	public static bool IsAvailableReusableVipOfferOfType(RSQHEFIJIQL EOOEIROQJOE)
	{
		return false;
	}

	private static void GROJFJQRTIH()
	{
	}

	public static bool IsReusableDiscountActive()
	{
		return false;
	}

	public static bool IsReusableDiscountSeen()
	{
		return false;
	}

	public static void SetReusableDiscountSeen()
	{
	}

	public static bool IsActive(bool ISROQQFMFOP = true)
	{
		return false;
	}

	public static bool TryGrantDailies()
	{
		return false;
	}

	public static void Activate(int PGHOGNHTOSR, PLFIKIOKPGQ JQFFSEPGFTK = PLFIKIOKPGQ.FULL)
	{
	}

	public static void OnPurchaseProduct(string MQNHOQLRLQO)
	{
	}

	public static void Activate(RSQHEFIJIQL OGFKHSKTHHR, PLFIKIOKPGQ JQFFSEPGFTK = PLFIKIOKPGQ.FULL)
	{
	}

	private static bool PRJPOOMQSOS(RSQHEFIJIQL HHRGQEQGGIS, RSQHEFIJIQL ELEIPINNGGJ)
	{
		return false;
	}

	public static void GiveDailies()
	{
	}

	public static long GetSecondsRemaining()
	{
		return 0L;
	}

	public static Data GetData()
	{
		return null;
	}

	public static Config GetConfig()
	{
		return default(Config);
	}

	private static void SOKFRMGIEIP(bool PLKFPIPJIOS)
	{
	}

	public static void TryGrantVipSkins()
	{
	}

	public static bool HasVipBeenPurchased(bool ISROQQFMFOP = false)
	{
		return false;
	}

	public static RSQHEFIJIQL GetBiggestVipPurchaseType()
	{
		return default(RSQHEFIJIQL);
	}

	private static bool ESRHKKPPJOH()
	{
		return false;
	}

	public static void OnAnyNoThanksClicked(string JHMNFQKJHGF = "")
	{
	}

	public static void TryShowOffers()
	{
	}

	public static int ShouldShowAnyOfOffers(int[] SILFMMSJLIJ)
	{
		return 0;
	}

	public static bool ShouldShowOffer(int OREMGIQJPRP)
	{
		return false;
	}

	public static int GetLastShownSpecialOffer()
	{
		return 0;
	}

	public static int GetOfferVisibleSecondsRemaining()
	{
		return 0;
	}

	public static void SetOfferShown(int OREMGIQJPRP)
	{
	}

	private static void KKEEPMHRSEF(VipActivation OHHKIKQQRGS)
	{
	}

	public static long GetTotalVipDurationPassedSeconds(bool ENLPFKGSTGM = false)
	{
		return 0L;
	}

	public static VipActivation GetCurrentVipActivation()
	{
		return default(VipActivation);
	}

	public static long GetSecondsTillSkinUnlock(IRHNENTFPPM QHTSIIGGMOP)
	{
		return 0L;
	}

	public static void ClearVip()
	{
	}

	public static bool IsFreeVipAvailable()
	{
		return false;
	}

	public static void ClaimFreeVip()
	{
	}

	public static bool ShouldShowFreeVipPopup()
	{
		return false;
	}

	private static bool JMHESMIITIT(string JSRRSEOKONO)
	{
		return false;
	}

	public static int GetFreeVipDuration()
	{
		return 0;
	}

	public static bool IsVipRecentlyEnded()
	{
		return false;
	}

	public static void ResetVipRecentlyEnded()
	{
	}

	public static void OnAnyPurchaseCompleted(bool SILMTFJJQIJ, string JSRRSEOKONO)
	{
	}

	public static bool IsVipPurchase(string MQNHOQLRLQO)
	{
		return false;
	}

	[CompilerGenerated]
	internal static void KFKSIOFQIKH(RSQHEFIJIQL EOOEIROQJOE)
	{
	}

	[CompilerGenerated]
	internal static void TKOTPFFENKH(IRHNENTFPPM NJJHLIGJPFL, ref QSERIFRRLQS P_1)
	{
	}
}
[Serializable]
public class VIP : R
{
	public int days;

	public Vip.PLFIKIOKPGQ type;

	public override void PSNQTGEMHOR(SEGNIQSSRKE SKQJGSLLSLH = null)
	{
	}
}
