using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class IFNEFRRNEKG
{
	[Serializable]
	public struct Data
	{
		public int currency;

		public List<int> claimedFreeRewards;

		public List<int> claimedPaidRewards;

		public bool premium;

		public bool superPremium;

		public int index;

		public int lastRemindTimestamp;

		public int dailyGemPlays;

		public int lastPlayGemsResetTimestamp;

		public int buyRealMoney;

		public int lastPlayRealMoneyResetTimestamp;

		public int lastPlayAdsResetTimestamp;

		public int lastPlayAdsTimestamp;

		public int dailyAdClaims;

		public bool introduced;

		public string game;

		public int lastDailyGrant;

		public string shop;

		public bool hasEnteredShop;
	}

	[Serializable]
	public struct Config
	{
		public int start;

		public int end;

		public int bonusTokensSmall;

		public int bonusTokensLarge;

		public CurrencyDropConfig currencyAcquire;

		public int remindInterval;

		public int pricePlayCurrency;

		public int pricePlayGems;

		public int playLimitGems;

		public int playResetIntervalGems;

		public bool playEnabledGems;

		public int buyResetIntervalRealMoney;

		public int buyLimitRealMoney;

		public bool buyEnabledRealMoney;

		public int buyCountRealMoney;

		public int baseDeviceBonusGems;

		public int baseDeviceBonusCash;

		public int baseDeviceBonusTickets;

		public bool claimAdsEnabled;

		public int claimAdsLimit;

		public int claimAdsResetInterval;

		public int claimAdsResetInterval_Short;

		public int claimAdsCount;

		public JJHFPNTSRLT.LevelOffset[] level_offsets;

		public JJHFPNTSRLT.LevelOffset[] level_scaling_offsets;

		public float enemy_level_scaling_multiplier;

		public int enemy_level_scaling_multiplier_apply;

		public int tokenRewardRegular;

		public int tokenRewardElite;

		public int tokenRewardGiant;

		public int[][] addedTokensForWaves;

		public int free_daily_currency;

		public int premium_daily_currency;
	}

	public class IOSNTOPNOQF : EKFFMKLSSNN
	{
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

		public int GetEliteLevelAdd(int MTFHQPOPFKQ)
		{
			return 0;
		}

		public string GetAnalyticsContext()
		{
			return null;
		}

		public bool SJGPNEKENNN()
		{
			return false;
		}

		public bool JRPFTGTJSKJ()
		{
			return false;
		}

		public List<GameModifierSpecific> HGGRFQHRNMF()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class EMLPMRGSNGQ
	{
		public int rewardIndex;

		public bool paid;

		public Action onAfterClaim;
	}

	[CompilerGenerated]
	private sealed class RFTRTHNRIFS
	{
		public Action onCompleted;

		internal void _003CBuyTokens_003Eb__0(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class IFGNQTQSSRG
	{
		public Action onCompleted;

		internal void _003CClaimTokensAds_003Eb__1(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class TSGOSGFJRMN
	{
		public TLSEHKTLMFE.Product prod;

		public int index;

		public Action onCompleted;

		public int amount;

		internal void _003CClaimShopProduct_003Eb__2(List<JJHFPNTSRLT.WeaponPart> x)
		{
		}

		internal void _003CClaimShopProduct_003Eb__5(List<ItemWeapon> x)
		{
		}

		internal void _003CClaimShopProduct_003Eb__6(List<ItemGear> x)
		{
		}

		internal void _003CClaimShopProduct_003Eb__1(RRMFSKNJIOH x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class IERSNLKOJTG
	{
		public LootList ll;

		public TSGOSGFJRMN CS_0024_003C_003E8__locals1;

		internal void _003CClaimShopProduct_003Eb__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class NSSTPMKRNLI
	{
		public IRHNENTFPPM sid;

		public IERSNLKOJTG CS_0024_003C_003E8__locals2;

		internal void _003CClaimShopProduct_003Eb__3()
		{
		}
	}

	private const int QORMSETKFNR = 4;

	private static Config SOSLGOOOIPG;

	private static Data TSRPFHOJKSG;

	private static LNLJKJLGQIP EHJPSQLTGHF;

	private static TLSEHKTLMFE TPKNEOQSFNR;

	private static int EILFPFKHFNG;

	public static bool OKFQTOHMFER;

	private static bool QOOPLGKOOLG;

	private static IOSNTOPNOQF KPHHQQPFJQP;

	public static bool QOQRPIPKPLS;

	public static string JKPNPHQEOKN;

	public static string IGSFNLKOSRP;

	public static string FHOJOFMPTJE;

	public static string IIFPSFLORPP;

	public static string QNSLHIMLMGS;

	public static string LMFIIOSJSFM;

	public static event Action NPNTHKGKSFL
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

	public static void MLNESSGJRME()
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

	public static void NJPJSHFJENP(bool OSOGGLRKNQH = false)
	{
	}

	public static void MGRLTPGGSSI()
	{
	}

	private static void LNJPNMFSIIQ()
	{
	}

	private static void TJPEHLHSNFL()
	{
	}

	private static void OINQQTNOKJO()
	{
	}

	public static bool QSRLKSRLPGE()
	{
		return false;
	}

	public static int TTMOGEMKJMF()
	{
		return 0;
	}

	public static int MHGETGRLMIM()
	{
		return 0;
	}

	public static HalloweenEventConfig MSPTIMKJNTP()
	{
		return null;
	}

	public static int QMTSSERTRHP()
	{
		return 0;
	}

	public static bool FRJQFFFRQKR()
	{
		return false;
	}

	public static bool PLNHKOSQTLN()
	{
		return false;
	}

	public static bool GNMJKESMHGR()
	{
		return false;
	}

	public static bool HLPPQNEGFNN()
	{
		return false;
	}

	public static bool JKLPSPMNPRP()
	{
		return false;
	}

	public static int OEJGHPNRGGH(BaseObjectData.PTGOHOTMOKK EOOEIROQJOE)
	{
		return 0;
	}

	public static bool SQRKSJSTJSP()
	{
		return false;
	}

	public static bool ROLFQEFPOHE()
	{
		return false;
	}

	public static void RLGNFOKJJOH()
	{
	}

	public static bool QHQLMOTTFSN(bool PHQLTRPLKOL)
	{
		return false;
	}

	public static bool ILGOGEHEMKL(bool PHQLTRPLKOL)
	{
		return false;
	}

	public static bool QIGNMJEIHHO(bool PHQLTRPLKOL)
	{
		return false;
	}

	public static void GTSNFFPGJNF()
	{
	}

	public static bool SOTOOLEIRGQ(int OLIKOEMTQNT, bool FKPPEQLPJHJ)
	{
		return false;
	}

	public static bool MOKTORIIORH(int KKQIRLHHSGH)
	{
		return false;
	}

	public static bool QGTOGERORIR(int OLIKOEMTQNT, bool FKPPEQLPJHJ)
	{
		return false;
	}

	public static bool JLLKIGSRQFK()
	{
		return false;
	}

	private static void PTPTEFIEJGL(int OLIKOEMTQNT, bool FKPPEQLPJHJ)
	{
	}

	public static void OJJEMHRGMOO(int OLIKOEMTQNT, bool FKPPEQLPJHJ, Action JPLQMGKQFNP)
	{
	}

	public static string QFPHLFOKFMI(bool FKPPEQLPJHJ)
	{
		return null;
	}

	public static Board.TrackEventData PNLOKOOSRLM(bool THMTSOKHSEI, LootElement FILOKRMHOJJ)
	{
		return null;
	}

	public static bool FGJLGKMOITK()
	{
		return false;
	}

	public static bool HRKERQIHFQJ()
	{
		return false;
	}

	public static void SGGEQJHLSOT(bool ORSMKOJSJEQ)
	{
	}

	public static void RJPPRKPKIIJ()
	{
	}

	public static int ETLORHRHSJE(bool ORSMKOJSJEQ)
	{
		return 0;
	}

	public static int KTEIFJJHMRN()
	{
		return 0;
	}

	public static void OJMSIGONKLJ(int ISLTSKEPJPI, bool LIPENRNHTJL = true)
	{
	}

	public static int RRMIHNQRFLS()
	{
		return 0;
	}

	public static int MIFQMHETQIH()
	{
		return 0;
	}

	public static int KQRJKTPTKHP()
	{
		return 0;
	}

	public static bool PRQJOSFNGPQ(int QJQINTKJTJQ, bool KKQQJQLKHMP, System.Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static bool HFSLIOGHHKF(int QJQINTKJTJQ, System.Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static bool MTTLNOKEFLF(int QJQINTKJTJQ, OperationController.JMSSNJLGTFN OPJNKTMSTJR, System.Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static int IRSTEPQQMLT(int QJQINTKJTJQ, bool KKQQJQLKHMP, System.Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int KGNJQILTEER(int QJQINTKJTJQ, System.Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int ITNKFOJGGFR(int QJQINTKJTJQ, OperationController.JMSSNJLGTFN JOLFHPIHIEJ, System.Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int MISESQIPLLG(int QJQINTKJTJQ, ChestController.MFRETPOLGOE HTRLEQMGOOO, System.Random FQNLGPSKNRM)
	{
		return 0;
	}

	private static void ONHEKEJKJII(Scene SLRMLOOSEGG, LoadSceneMode KGSNKQEHSHO)
	{
	}

	public static void GTOIOFQMRTQ()
	{
	}

	public static bool MRSQMKOKKFP()
	{
		return false;
	}

	public static int TFPSNRPMIIN()
	{
		return 0;
	}

	public static bool PMSOIOEIFIQ()
	{
		return false;
	}

	public static int OJLRSMPPISE()
	{
		return 0;
	}

	public static int MQRKMLQLGQQ()
	{
		return 0;
	}

	public static bool OIGLHQJGHOQ()
	{
		return false;
	}

	public static string TSMSJNMEEHH()
	{
		return null;
	}

	public static int RFHTENOLPNM()
	{
		return 0;
	}

	public static bool OHLTGOJORSQ()
	{
		return false;
	}

	public static int IIEGGMEETKS()
	{
		return 0;
	}

	public static int JGKETGSOKTP()
	{
		return 0;
	}

	public static bool QLLIOJSILKS()
	{
		return false;
	}

	public static int RTLPNLHKNET()
	{
		return 0;
	}

	public static void RNHTOIKKEGH(Action SQEPQEOJHOK)
	{
	}

	public static int LELJJOQJNIK()
	{
		return 0;
	}

	public static int HPEFLMGMIHF()
	{
		return 0;
	}

	public static int NEQOLIJNFSR()
	{
		return 0;
	}

	public static bool FOIKOGHHFOF()
	{
		return false;
	}

	public static bool RSNHFMMJLOJ()
	{
		return false;
	}

	public static int KGPESSKNMQH()
	{
		return 0;
	}

	public static void MGFOSIIHJHI(Action SQEPQEOJHOK)
	{
	}

	public static void MKGNMOIHPLE()
	{
	}

	public static void FORGHHHEJNJ()
	{
	}

	public static IOSNTOPNOQF RLNELHEHSRL()
	{
		return null;
	}

	public static HEPTMPFPKPP MHTGOSKJSTO(Stage MTFHQPOPFKQ)
	{
		return null;
	}

	private static void LEJNFOTMRIR(int FPPORRQNRHL)
	{
	}

	public static int KOMOQKQGHEE(EnemySpot.SMMGLQPTJET IFHOJERLHRR)
	{
		return 0;
	}

	public static bool KOQFRSSEJHG()
	{
		return false;
	}

	public static int OGHRNJPNOFF()
	{
		return 0;
	}

	public static void KRHSGRSMQKJ(int ISLTSKEPJPI)
	{
	}

	public static int EKRFHKIRSMG()
	{
		return 0;
	}

	public static TLSEHKTLMFE GFFLOROKILH()
	{
		return null;
	}

	public static void FPGSQMSFRLI(TLSEHKTLMFE.Product PIRRFTRTOFP, int PSPJIJNTMOI, GameObject QJFNNHKGPOR, Action SQEPQEOJHOK)
	{
	}

	private static List<ItemWeapon> FENTLMQIRRS(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return null;
	}

	private static List<ItemGear> ELEREEOITOQ(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return null;
	}

	public static bool POOSMJOFFLF()
	{
		return false;
	}

	public static void QQJLTGEFQFR()
	{
	}

	public static bool MLPJPNNSJLG()
	{
		return false;
	}
}
