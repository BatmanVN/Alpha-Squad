using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class RHPQSFOILTF
{
	[Serializable]
	public struct Data
	{
		public int currency;

		public int index;

		public string gameData;

		public bool purchased;

		public List<int> claimedPaidRewards;

		public List<int> claimedFreeRewards;

		public int owedPlays;

		public int lastGemCapResetTimestamp;

		public int lastRealMoneyCapResetTimestamp;

		public int cappedGemPurchases;

		public int cappedRealMoneyPurchases;

		public bool introduced;
	}

	[Serializable]
	public struct Config
	{
		public int start;

		public int end;

		public CurrencyDropConfig currency_acquire;

		public int playPriceCurrency;

		public int playPriceGems;

		public int playCapGems;

		public int playCapRealMoney;

		public int playCapRestartIntervalGems;

		public int playCapRestartIntervalRealMoney;

		public int smallPremiumBonus;

		public int largePremiumBonus;

		public int base_device_bonus_cash;

		public int base_device_bonus_gems;

		public int base_device_bonus_tickets;

		public int plays_currency;

		public int plays_gems;

		public int plays_realmoney;
	}

	[Serializable]
	public struct WonReward
	{
		public string identifier;

		public int count;
	}

	[CompilerGenerated]
	private sealed class MNNGTROGQKE
	{
		public bool paid;

		public int rewardIndex;

		public Action OnAfterClaim;
	}

	[CompilerGenerated]
	private sealed class GJGSFKSLLKP
	{
		public LootIdentifier rw;

		public MNNGTROGQKE CS_0024_003C_003E8__locals1;
	}

	[CompilerGenerated]
	private sealed class JFSSTFRSQPP
	{
		public Action<string> OnPurchaseCompleted;

		internal void _003CPurchasePremiumSmall_003Eb__0(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class NSKOPRTITQG
	{
		public Action<string> OnPurchaseCompleted;

		internal void _003CPurchasePremiumLarge_003Eb__0(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class MJSJFHGOSQH
	{
		public Action<string> onCompleted;

		internal void _003CPurchasePlayRealMoney_003Eb__0(bool ok)
		{
		}
	}

	private const int SFJJIOLENIK = 3;

	private static bool QOOPLGKOOLG;

	private static Config SOSLGOOOIPG;

	private static Data TSRPFHOJKSG;

	private static LNLJKJLGQIP EHJPSQLTGHF;

	public static string GMHEFELNQQO;

	public static string JKPNPHQEOKN;

	public static string IGSFNLKOSRP;

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

	private static void MLNESSGJRME()
	{
	}

	private static void IHNTSKNKNTM()
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

	public static void NJPJSHFJENP()
	{
	}

	public static void MGRLTPGGSSI()
	{
	}

	public static LNLJKJLGQIP EHSFOGJTQIE()
	{
		return null;
	}

	public static int SQGSGSKLJHE(LootElement.TOINELPLRQP SMOSQLQMMMF)
	{
		return 0;
	}

	public static LootElement MPPHIMHIJQG(LootElement.TOINELPLRQP OGFKHSKTHHR)
	{
		return default(LootElement);
	}

	public static int HGGIRJFMJRL()
	{
		return 0;
	}

	public static int QJOIHOTFREO()
	{
		return 0;
	}

	public static void RLKPHLREJOP(Action<string> HGHQKPNOEKL)
	{
	}

	public static int HQSLGEPKRIN()
	{
		return 0;
	}

	public static void PHPGFGRNHKO()
	{
	}

	public static int ISEPIIHGNHI()
	{
		return 0;
	}

	public static int TQLNFQPRTNI()
	{
		return 0;
	}

	public static int JLRKQGQNLMQ()
	{
		return 0;
	}

	public static EasterEventConfig MSPTIMKJNTP()
	{
		return null;
	}

	public static bool QSRLKSRLPGE()
	{
		return false;
	}

	public static int MHGETGRLMIM()
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

	public static string MNQEJORHKNM(bool FKPPEQLPJHJ)
	{
		return null;
	}

	public static int OEJGHPNRGGH(BaseObjectData.PTGOHOTMOKK EOOEIROQJOE)
	{
		return 0;
	}

	public static void RLGNFOKJJOH()
	{
	}

	public static bool JFKFSTMFEPR()
	{
		return false;
	}

	public static void OJMSIGONKLJ(int ISLTSKEPJPI, bool LIPENRNHTJL = true)
	{
	}

	public static int RRMIHNQRFLS()
	{
		return 0;
	}

	public static bool PRQJOSFNGPQ(int QJQINTKJTJQ, bool KKQQJQLKHMP, Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static bool HFSLIOGHHKF(int QJQINTKJTJQ, Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static bool MTTLNOKEFLF(int QJQINTKJTJQ, OperationController.JMSSNJLGTFN OPJNKTMSTJR, Random FQNLGPSKNRM = null)
	{
		return false;
	}

	public static int IRSTEPQQMLT(int QJQINTKJTJQ, bool KKQQJQLKHMP, Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int KGNJQILTEER(int QJQINTKJTJQ, Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int ITNKFOJGGFR(int QJQINTKJTJQ, OperationController.JMSSNJLGTFN JOLFHPIHIEJ, Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static int MISESQIPLLG(int QJQINTKJTJQ, ChestController.MFRETPOLGOE HTRLEQMGOOO, Random FQNLGPSKNRM)
	{
		return 0;
	}

	public static bool SSLNQNGTGLH()
	{
		return false;
	}

	public static bool QGIHQLPGLII()
	{
		return false;
	}

	public static bool JLLJRKTQNPS()
	{
		return false;
	}

	public static bool EPJRTGQQKEN()
	{
		return false;
	}

	public static bool TIIETONMFRI()
	{
		return false;
	}

	public static int SKJPGMQSNOS()
	{
		return 0;
	}

	public static int RKHESMIGPMO()
	{
		return 0;
	}

	public static int OMNRHJFRMKI()
	{
		return 0;
	}

	public static int SOJILFTILSG()
	{
		return 0;
	}

	public static int QTLPFLOTJHQ()
	{
		return 0;
	}

	public static int THEIISLPJNS()
	{
		return 0;
	}

	private static void TGMGSQGHMKN()
	{
	}

	private static void SEGFMQGRMGS()
	{
	}

	public static bool SOTOOLEIRGQ(int OLIKOEMTQNT, bool FKPPEQLPJHJ)
	{
		return false;
	}

	public static bool MOKTORIIORH(int LSGHOSTOGTM)
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

	public static void OJJEMHRGMOO(int OLIKOEMTQNT, bool FKPPEQLPJHJ, Action PQGQLGOEMSG)
	{
	}

	public static LootElement HMOSKKSHOTR(int OLIKOEMTQNT, bool FKPPEQLPJHJ)
	{
		return default(LootElement);
	}

	private static void JNRHMHNQRKS()
	{
	}

	public static bool FGJLGKMOITK()
	{
		return false;
	}

	public static void NEMOLMGEEPN(Action<string> OSQEKQHHMNH)
	{
	}

	public static void NRENHEKMOGQ(Action<string> OSQEKQHHMNH)
	{
	}

	private static void GLRSEIRRMLI(Action<string> SQEPQEOJHOK)
	{
	}

	public static void LIKQILHEQFN()
	{
	}

	public static void HEKIJETTTOL()
	{
	}

	public static void RLSGRMTHTTI()
	{
	}

	public static int SGTNQHFIEOP()
	{
		return 0;
	}

	public static int NMLNTFINJQF()
	{
		return 0;
	}
}
