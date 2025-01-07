using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Gear;
using UnityEngine;

public static class SLERLGELELO
{
	[Serializable]
	public struct GearStatsConfig
	{
		public JJHFPNTSRLT.MinMaxValueInt health;

		public JJHFPNTSRLT.MinMaxValueFloat damage;

		public JJHFPNTSRLT.MinMaxValueFloat resist;
	}

	[Serializable]
	public struct GearBonusLayoutsConfig
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public GearBonusSingleLayoutConfig[] bonus_configs;
	}

	[Serializable]
	public struct GearBonusLayoutsConfigQuality
	{
		public int quality;

		public JJHFPNTSRLT.PQRIQGIOGQT[] layout;
	}

	[Serializable]
	public struct GearBonusSingleLayoutConfig
	{
		public int weight;

		public JJHFPNTSRLT.PQRIQGIOGQT[] layout;
	}

	public enum RTFJMHFIHRS
	{
		HEALTH = 0,
		DAMAGE = 1,
		DAMAGE_RESIST_ALL = 2,
		DAMAGE_RESIST_MELEE = 3,
		DAMAGE_RESIST_RANGED = 4,
		DAMAGE_RESIST_EXPLOSIVE = 6
	}

	[Serializable]
	public struct GearStat
	{
		public RTFJMHFIHRS type;

		public ObscuredFloat roll;

		public float RKQINGQKGLT(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
		{
			return 0f;
		}

		public float SIKOFGJLQTM(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
		{
			return 0f;
		}
	}

	[Serializable]
	public class GearScrap
	{
		public KNSKIMFQMTH category;

		public int amount;
	}

	[CompilerGenerated]
	private sealed class ORHTEJLPMNO
	{
		public float[][] allBrackets;

		public float ret;

		internal void _003CGetDamageBonusForUpgradeLevel_003Eb__0((int, int, int, int) t)
		{
		}
	}

	[CompilerGenerated]
	private sealed class IPHPSEJESFG
	{
		public int[][] allBrackets;

		public int ret;

		internal void _003CGetHealthBonusForUpgradeLevel_003Eb__0((int, int, int, int) t)
		{
		}
	}

	[CompilerGenerated]
	private sealed class RPSILTJKPLK
	{
		public int[][] allBracketsCash;

		public int[][] allBracketsScrap;

		public LootList ll;

		public KNSKIMFQMTH category;

		internal void _003CGetUpgradeTotalForUpgradeLevel_003Eb__0((int, int, int, int) t)
		{
		}
	}

	[CompilerGenerated]
	private sealed class GGMIIIKNQQN
	{
		public int upgradeLevel;

		public int[][] allBracketsCash;

		public int[][] allBracketsScrap;

		public LootList ret;

		public KNSKIMFQMTH gearCategory;

		internal void _003CGetUpgradePriceForUpgradeLevel_003Eb__0((int, int, int, int) t)
		{
		}
	}

	[CompilerGenerated]
	private sealed class HSGFNRHGMNH
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CPickBonusLayoutConfig_003Eb__1(GearBonusLayoutsConfig x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class EMTORFRONNO
	{
		public JJHFPNTSRLT.PQRIQGIOGQT r;

		public int minVal;

		internal bool _003CPickBonusLayoutConfigForQuality_003Eb__0(GearBonusLayoutsConfig x)
		{
			return false;
		}

		internal bool _003CPickBonusLayoutConfigForQuality_003Eb__1(GearBonusSingleLayoutConfig x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FHLEOGOROKO
	{
		public KNSKIMFQMTH cat;

		internal bool _003CGetIconForGearCategory_003Eb__0(JJHFPNTSRLT.GearCategorySprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QINFTTITSIP
	{
		public MNJMPEKHPTO id;

		internal bool _003CGetIconForBonusId_003Eb__0(JJHFPNTSRLT.GearBonusSprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QTRQEMTSMOH
	{
		public JJHFPNTSRLT.PQRIQGIOGQT r;

		public Func<JJHFPNTSRLT.PQRIQGIOGQT, int> _003C_003E9__1;

		internal bool _003CGetMinGearBonusQualityForRarity_003Eb__0(GearBonusLayoutsConfig x)
		{
			return false;
		}

		internal int _003CGetMinGearBonusQualityForRarity_003Eb__1(JJHFPNTSRLT.PQRIQGIOGQT x)
		{
			return 0;
		}
	}

	private const float PFLLRTQJGGL = 3f;

	private const float IMMHLEOMGQE = 2f;

	private const float OQHTMOEKOFO = 2f;

	private static int ILOQQJQQOHT;

	public static float HKSGJHEFLRL(float QPNIRNRNJON)
	{
		return 0f;
	}

	public static float HEJIRMGNEMI(float QPNIRNRNJON)
	{
		return 0f;
	}

	public static int JPITHFRTOFM(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, float JEFLOELTQGJ)
	{
		return 0;
	}

	public static float IFKOSORRLTQ(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, float JEFLOELTQGJ)
	{
		return 0f;
	}

	public static float NPLEGJMOIOE(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, float JEFLOELTQGJ)
	{
		return 0f;
	}

	public static bool RPFQSROPTKN(KNSKIMFQMTH OJTGHRGORLS)
	{
		return false;
	}

	public static bool FTKJHEPHMMQ(KNSKIMFQMTH OJTGHRGORLS)
	{
		return false;
	}

	private static int KFGIMRQISFJ(int OGFKHSKTHHR, int MHENQNFOQNO, int KTSLQMKNHKF)
	{
		return 0;
	}

	private static float KFGIMRQISFJ(int OGFKHSKTHHR, float MHENQNFOQNO, float KTSLQMKNHKF)
	{
		return 0f;
	}

	private static void HIGMPIELPFN(int EESQJISERQF, Action<(int, int, int, int)> FQNIPIPFEIK)
	{
	}

	public static float GQJJOTELINP(KNSKIMFQMTH EMKNPKTIJPF, int EESQJISERQF)
	{
		return 0f;
	}

	public static int FFKLLHJLFRI(KNSKIMFQMTH EMKNPKTIJPF, int EESQJISERQF)
	{
		return 0;
	}

	public static LootList TGHSMOPPLJF(int EESQJISERQF, KNSKIMFQMTH EMKNPKTIJPF)
	{
		return null;
	}

	public static LootList FKJQMOFHSNJ(int NFTNLENGFPQ, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, bool MTNHLRLHIHQ = true)
	{
		return null;
	}

	public static LootList NRMIHJIMQRT(int EESQJISERQF, KNSKIMFQMTH QQKJLIFKMHM)
	{
		return null;
	}

	public static bool NFNLEMNJNOI(int EESQJISERQF, KNSKIMFQMTH QQKJLIFKMHM)
	{
		return false;
	}

	public static void HIQGHRJRRNG(ItemGear EETSQSGPOES, ItemGear HHIHIMFSJMF, bool RREKSGOHHJT = false, bool EPEOKSGENTK = false)
	{
	}

	public static int MOTHFTNFLET(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return 0;
	}

	public static JJHFPNTSRLT.NKSMTQENIRK EGJMPFOGFLO(KNSKIMFQMTH EMKNPKTIJPF)
	{
		return default(JJHFPNTSRLT.NKSMTQENIRK);
	}

	public static JJHFPNTSRLT.NKSMTQENIRK PJQMRTGFGGN(RTFJMHFIHRS LOGFMFHFPEP)
	{
		return default(JJHFPNTSRLT.NKSMTQENIRK);
	}

	public static GearBonusSingleLayoutConfig EGPTOTFRNNP(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, GearBonusLayoutsConfig[] SOSLGOOOIPG, System.Random FQNLGPSKNRM = null)
	{
		return default(GearBonusSingleLayoutConfig);
	}

	public static JJHFPNTSRLT.PQRIQGIOGQT[] KRHROMLKNTE(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL, int ETNRRGQSKEG, GearBonusLayoutsConfigQuality[] LNHQLNJEOQH, System.Random FQNLGPSKNRM = null)
	{
		return null;
	}

	public static Sprite QTSMPKEMOTN(KNSKIMFQMTH OJTGHRGORLS)
	{
		return null;
	}

	public static Sprite STMKFTQIFRN(MNJMPEKHPTO HSLQJLPMLMH)
	{
		return null;
	}

	public static string QMJTNGSERPK(MNJMPEKHPTO HSLQJLPMLMH)
	{
		return null;
	}

	public static string ORNLSOSMFQT(MNJMPEKHPTO HSLQJLPMLMH)
	{
		return null;
	}

	public static string HHOOKQEKNTN(KNSKIMFQMTH OJTGHRGORLS)
	{
		return null;
	}

	public static bool PGGTHRHTOLF(MNJMPEKHPTO HSLQJLPMLMH)
	{
		return false;
	}

	public static bool EPKKPHFONIQ(MNJMPEKHPTO ESOQLISNTTH)
	{
		return false;
	}

	public static void MGMPRMTLNGJ(Bonus TMMOGJKFPSF, MTGKQSJELIM JTKONROLIJE)
	{
	}

	public static void FQMMQSRNGST(in List<Bonus> JPHINENGGRQ, MTGKQSJELIM JTKONROLIJE)
	{
	}

	public static KNSKIMFQMTH GNIFJMMKOGO(SHTSPMQQFMP HSLQJLPMLMH)
	{
		return default(KNSKIMFQMTH);
	}

	public static List<KNSKIMFQMTH> FSGILSSSMKE(bool QPSESITMTTM = false)
	{
		return null;
	}

	public static void KRSLMRSGGEJ(ref ItemGear NTISFTTTKEK)
	{
	}

	public static int PIKMRESROJK(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return 0;
	}

	public static int PJROOPQSLTG(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return 0;
	}

	public static int PTKKNEPRQNG(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return 0;
	}

	public static int REQNOJRKHML(ItemGear NTISFTTTKEK)
	{
		return 0;
	}

	public static int SQKISHLLKTT(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return 0;
	}

	public static float SNPFLFNHGPK(JJHFPNTSRLT.PQRIQGIOGQT KKTEFOLQSFF, int KTFKHGHKOER)
	{
		return 0f;
	}

	public static int KSJLSKQRTNR()
	{
		return 0;
	}

	public static LootList QSPPFGPHSPP(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int TSJKJENJJSN, bool MTNHLRLHIHQ = true, bool HNMOFHNIRKF = false)
	{
		return null;
	}

	public static LootList KKHPEQFQEHT(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
		return null;
	}

	[CompilerGenerated]
	internal static LootList IEQORHMJKGN(ItemGear HPJMQLRTORF)
	{
		return null;
	}

	[CompilerGenerated]
	internal static GearBonusSingleLayoutConfig GMETGGRNSQT()
	{
		return default(GearBonusSingleLayoutConfig);
	}

	[CompilerGenerated]
	internal static LootList PQJRORRSFRK()
	{
		return null;
	}

	[CompilerGenerated]
	internal static LootList SKFQETOISLJ()
	{
		return null;
	}
}
