using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

[Serializable]
public class ItemWeapon : Item
{
	[Serializable]
	public class RerollMemory
	{
		public Bonus rerollBonus;

		public ObscuredInt bonusIndex;

		public ObscuredInt rerollCount;
	}

	public enum SHJHMMOOGGJ
	{
		REGULAR = 0,
		RANK = 1,
		LIMIT_BREAK = 2
	}

	public enum RGPEMGEPIJF
	{
		FIRE_RATE = 0,
		DAMAGE = 1,
		PROJECTILE_SPEED = 2,
		CRITICAL_CHANCE = 3,
		CRITICAL_DAMAGE = 4,
		RANGE = 5,
		DAMAGE_TO_ELITES = 6,
		INCREASE_KNOCKBACK = 7,
		DECREASE_COOLDOWN = 8,
		INCREASED_AMMO = 9,
		ACCURACY = 10,
		COOLDOWN_RESET = 11,
		BULLETS = 12,
		HEADSHOT = 13,
		EXPLOSION_AREA = 14,
		DOUBLESHOT = 15,
		MOD_DAMAGE_BUFF_ON_KILL = 16,
		MOD_TAKE_INCREASED_DAMAGE_AFTER_HIT = 17,
		MOD_STUNS = 18,
		MOD_BLEED_LIGHT = 19,
		MOD_SLOW = 20,
		BOUNCING_WALL = 21,
		PIERCE = 22,
		REDUCE_SPREAD = 23,
		RICOCHET = 24,
		MOD_CHILL = 25,
		MOD_CHANCE_STUNS = 26,
		MOD_CHANCE_STUN_GRENADE = 27,
		MOD_POISON_ENEMIES = 28,
		MOD_BLEED_HEAVY = 29,
		DAMAGE_TO_BOSSES = 30,
		EXPLOSIVE_FINAL_ROUND = 31,
		INCREASE_DAMAGE_TO_LOW_HEALTH_ENEMIES = 32,
		CHANCE_PRESERVE_AMMO = 33,
		INCREASE_DAMAGE_OVER_RANGE = 34,
		CHANCE_ZAP_ON_KILL = 35,
		MOD_MOVESPEED_ON_KILL = 36,
		INCREASE_DAMAGE_MISSING_AMMO = 37,
		MOD_PERCENT_SHIELD_ON_HIT = 38,
		DAMAGE_TO_DOTTED_TARGET = 39,
		MOD_BURNING = 40,
		MOD_CHANCE_TO_FREEZE = 41,
		FORK = 42,
		MOD_HEAVY_PERCENT_SHIELD_ON_HIT = 43,
		MOD_MOVESPEED_ON_RELOAD = 44,
		HEAVY_RICOCHET = 1001,
		ZAP_ON_CRIT = 1002,
		INCREASE_DAMAGE_TO_CLOSE_ENEMIES = 1003,
		MOD_CRIT_CHANCE_BUFF_AFTER_RELOAD = 1004,
		CLUSTER_GRENADES_ON_PROJECTILE_HIT = 1005,
		SOUL_HARVEST = 1006,
		BLACK_HOLE = 1007,
		BLIZZARD_CHANCE = 1008,
		METEOR_STRIKE_CHANCE = 1009,
		ULTIMATE_CHARGE_ON_HIT = 1010,
		INCREASE_DAMAGE_WHEN_LOW_HEALTH = 1011,
		MOD_MOVESPEED_ON_HIT = 1012,
		INCREASE_RICOCHET_DAMAGE = 1013,
		MOD_HEAVY_SLOW = 1014,
		MOD_RELOAD_DISCHARGE = 1015,
		MOD_PLAGUE = 1016,
		SHOCKWAVE_ON_RELOAD = 1017,
		CONSUME_DOTS = 1018,
		DOUBLESHOT_SPRINGFIELD = 1019,
		IMPALE = 1020,
		SAWS_ON_HIT = 1021,
		KILLER_FINAL_ROUND = 1022
	}

	public static class EFFQFKSHPET
	{
		public const float LOFNFTHRILG = 3f;

		public const float KGHJPHSNJKR = 0.5f;

		public const float QTIPSSTLKKI = 30f;

		public const float IKQRKNOSMLK = 3f;

		public const float FJFNHKGOIHO = 12f;

		public const float QKRPGENSENM = 5f;

		public const float FGTSSOOOTJO = 36f;

		public const float TTTHJKKNPIM = 3f;

		public const int SKMMNESSQLG = 6;

		public const int REIRHOTLNMI = 10;

		public const float FQROKKIMQMG = 2f;

		public const float MNGQHISETNN = 0.25f;

		public const float QJMMHGRSHJE = 2.5f;

		public const float HTHELKFHLKQ = 3f;

		public const float MOEIIGQEPRT = 0.3f;

		public const float PGTOILTGKKN = 3f;

		public const float NPTMOPQMPKR = 1.5f;

		public const float KNMKGSEFSPS = 2.5f;

		public const float MGMPSFISSSP = 3f;

		public const float KNFHJFLEJOH = 5f;

		public const float KTHRIHTTMFT = 3f;

		public const float IHTKNEKJOOM = 10f;

		public const float SNRKEONTJPP = 8f;

		public const float QOTFTFKLHTE = 16f;

		public const float OGESGMEOPJM = 2f;

		public const float OMMOLQLTTKR = 2f;

		public const float SOQSNRHLGML = 1f;
	}

	[Serializable]
	public struct Bonus
	{
		public RGPEMGEPIJF type;

		public ObscuredFloat rankRoll;

		public bool forcedValueSet;

		public float forcedValue;

		public Bonus EMHTREEOMMT()
		{
			return default(Bonus);
		}

		public void EHTOTGHKLOI(float QPNIRNRNJON)
		{
		}

		public void GGSPMRRNGIL()
		{
		}

		public float RKQINGQKGLT(ItemWeapon LENQOPNFMTG)
		{
			return 0f;
		}

		public float RKQINGQKGLT(JJHFPNTSRLT.PQRIQGIOGQT OSTFJOEMJOG, int EJKFESGNQLK)
		{
			return 0f;
		}

		public JJHFPNTSRLT.MinMaxValueFloat LRFJFGKERIP(ItemWeapon LENQOPNFMTG)
		{
			return default(JJHFPNTSRLT.MinMaxValueFloat);
		}

		public JJHFPNTSRLT.MinMaxValueFloat LRFJFGKERIP(JJHFPNTSRLT.PQRIQGIOGQT OSTFJOEMJOG, int EJKFESGNQLK)
		{
			return default(JJHFPNTSRLT.MinMaxValueFloat);
		}

		public float GNFHOHQPJLR(ItemWeapon LENQOPNFMTG)
		{
			return 0f;
		}

		public float GNFHOHQPJLR(JJHFPNTSRLT.PQRIQGIOGQT OSTFJOEMJOG)
		{
			return 0f;
		}

		public float GELFPJFMGHM(int EJKFESGNQLK)
		{
			return 0f;
		}

		public float EPLGMEIRGOR(ItemWeapon LENQOPNFMTG)
		{
			return 0f;
		}

		public float EPLGMEIRGOR(JJHFPNTSRLT.PQRIQGIOGQT OSTFJOEMJOG, int EJKFESGNQLK)
		{
			return 0f;
		}

		public float RENTKOGKOGP(ItemWeapon LENQOPNFMTG)
		{
			return 0f;
		}

		public float RENTKOGKOGP(JJHFPNTSRLT.PQRIQGIOGQT OSTFJOEMJOG, int EJKFESGNQLK)
		{
			return 0f;
		}

		public bool TOJQFGPQLOO()
		{
			return false;
		}

		public void NGHFQRREIJN(System.Random JKLRKSJLKSH = null)
		{
		}

		public void NGHFQRREIJN(float JEFLOELTQGJ)
		{
		}

		public void NGHFQRREIJN(float TPLRGJIPHMJ, float FETFMKHKMME, System.Random JKLRKSJLKSH = null)
		{
		}
	}

	public struct GITTNMJFKMP
	{
		public int RPIIIJLLQMQ;

		public int LTTMJJNISIP;

		public int TLMHIPJSLSM;

		public int LHRJHLRNSOJ;

		public int IILLOMKPGQR;

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public struct AnalyticsContext
	{
		public int id;

		public int rarity;

		public int itemLevel;

		public int upgradeLevel;

		public int empowerLevel;

		public string Json => null;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct TGRTQGPNTRH
	{
		public float scalingBase;

		public float scalingExponent;
	}

	[CompilerGenerated]
	private sealed class RLNIGNMMIMK
	{
		public Bonus bonus;

		internal bool _003CCanRerollBonus_003Eb__0(JJHFPNTSRLT.PredefinedWeaponBonus x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class IRFQESPNGHL
	{
		public Bonus bonus;

		internal bool _003CCanUnlockBonus_003Eb__0(JJHFPNTSRLT.PredefinedWeaponBonus x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct HSNELMJROKM
	{
		public Actor _owner;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct SJKEEPOKHFT
	{
		public GameObject clusterPrefab;

		public WeaponInfo winfoCopy;
	}

	[CompilerGenerated]
	private sealed class GJILMPQELNQ
	{
		public Enemy e;

		internal bool _003CApplyWeaponAttributesOnReloadStarted_003Eb__2(Enemy x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class JFJQFTSNLIO
	{
		public Actor target;

		public Actor dmgOwner;

		internal bool _003CTestForSpecialsAfterActorHit_003Eb__2(Actor a)
		{
			return false;
		}
	}

	[NonSerialized]
	public Actor owner;

	public int itemLevel;

	public JPHMLSJQLNL weaponID;

	public int legendaryId;

	public KLSIJJEGQNH skinID;

	public ObscuredInt _upgradeLevel;

	public ObscuredInt _empowerLevel;

	public JJHFPNTSRLT.PQRIQGIOGQT rarity;

	public Bonus[] bonuses;

	private WeaponData cachedWeaponData;

	public List<RerollMemory> rerollMemory;

	[Obsolete]
	public Bonus lastRerollBonus;

	[Obsolete]
	public ObscuredInt rerolledBonusIndex;

	[Obsolete]
	public ObscuredInt bonusRerollCount;

	private global::HIJIFHMGTTR<GITTNMJFKMP> lastUpgradeValues;

	public AnalyticsContext RGKKFRJHEFK()
	{
		return default(AnalyticsContext);
	}

	public void NGHFQRREIJN(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int EESQJISERQF = 0, int HKGFNOEPMPN = 0)
	{
	}

	public string KKMPQSLHNNG()
	{
		return null;
	}

	public ItemWeapon EMHTREEOMMT()
	{
		return null;
	}

	public void MGHRGPQFEMR(Inventory IHKHPQHSLLK)
	{
	}

	public int JEJMISROJPR()
	{
		return 0;
	}

	public int GLJJIJFQKLM()
	{
		return 0;
	}

	public bool PJIIRIQONIR()
	{
		return false;
	}

	public bool KTSJPMRNPHG()
	{
		return false;
	}

	public bool EQOMRFOKSLH()
	{
		return false;
	}

	private void MNOQHSJNKSJ(int NERGMFPHLIM, bool GSOPMITFSTE = false)
	{
	}

	private void SPGSQRLNPMT(int NERGMFPHLIM)
	{
	}

	public int NQKPFFJEJLR()
	{
		return 0;
	}

	public JJHFPNTSRLT.PQRIQGIOGQT IMHILELJIQQ()
	{
		return default(JJHFPNTSRLT.PQRIQGIOGQT);
	}

	public bool NJJIPNIQESN()
	{
		return false;
	}

	public int OJEHPKMSFLQ()
	{
		return 0;
	}

	public WeaponLegendaryConfig GLESSREQNGK()
	{
		return null;
	}

	public JJHFPNTSRLT.LegendaryWeaponDefinition JIJRIGLHHFI()
	{
		return default(JJHFPNTSRLT.LegendaryWeaponDefinition);
	}

	public float HTEHETNOJLI()
	{
		return 0f;
	}

	public int MQFHIQNKIFI()
	{
		return 0;
	}

	public int EHERMMTHSLJ()
	{
		return 0;
	}

	public WeaponSkin SOLGOGOLRRN()
	{
		return null;
	}

	public Sprite EKIHLJFMQNM()
	{
		return null;
	}

	public WeaponDamageEntity RIESJOMFGLO()
	{
		return null;
	}

	public WeaponDamageEntityVisual KKFKNPGHGTR()
	{
		return null;
	}

	public T KKFKNPGHGTR<T>() where T : WeaponDamageEntityVisual
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public string QPFQFHJTKRR()
	{
		return null;
	}

	public WeaponData TQMLMQRITRM()
	{
		return null;
	}

	public WeaponInfo KHTNERFSJEO()
	{
		return null;
	}

	public int RNJMPJSMHFT()
	{
		return 0;
	}

	public int OQOTIHQGQSJ()
	{
		return 0;
	}

	public int MNFNPJLELQL()
	{
		return 0;
	}

	public int OQLFPGGSOHG()
	{
		return 0;
	}

	public int MHQSEOKLTQF()
	{
		return 0;
	}

	public int ORHORTEMPIK()
	{
		return 0;
	}

	public int KSINRGTQJHN()
	{
		return 0;
	}

	public int SRRJPQPIOJO()
	{
		return 0;
	}

	private int JPHHTGNGJRF(int QSLILFOTPHJ)
	{
		return 0;
	}

	private int EHNLFTJGJES(int QSLILFOTPHJ)
	{
		return 0;
	}

	public int OFHLJFITTPG()
	{
		return 0;
	}

	public GITTNMJFKMP NSLMFSKQGTS(int QSLILFOTPHJ)
	{
		return default(GITTNMJFKMP);
	}

	public float JSQQMHRSRSM(int FNGNTFHMLFM = 0)
	{
		return 0f;
	}

	public float NPQKIJJRQHS(int FNGNTFHMLFM = 0)
	{
		return 0f;
	}

	public float IFKOSORRLTQ()
	{
		return 0f;
	}

	public float TTMQOSMQJTF()
	{
		return 0f;
	}

	public float NEHJPLJHTEK(WeaponData TSRPFHOJKSG)
	{
		return 0f;
	}

	public float QHQNQSFMNNN(WeaponData TSRPFHOJKSG)
	{
		return 0f;
	}

	private float IFKOSORRLTQ(WeaponData TSRPFHOJKSG)
	{
		return 0f;
	}

	public float KREEFTNPJFF()
	{
		return 0f;
	}

	private float GJKSRJIQPJG(float PPTMHMLPFKL)
	{
		return 0f;
	}

	private float TTMQOSMQJTF(WeaponData TSRPFHOJKSG)
	{
		return 0f;
	}

	public void QJTPTMFHEIN(int IQLQQNIPTPQ, bool ETSOIHPPHHN = false)
	{
	}

	public void SSQOMPPOOPL(int RFEIJGJKNQM, bool ETSOIHPPHHN = false)
	{
	}

	public void FHOKRGKNRFN(int MOTTITEELQF, bool OELJSPNQIRI = true)
	{
	}

	public void SSIIELEELTM(int EEOIRNJPTQL = 1)
	{
	}

	public void QMTKHRFHMRS(int EEOIRNJPTQL = 1)
	{
	}

	public void EGONIEQPKFE(WeaponData LENQOPNFMTG)
	{
	}

	public bool HFNQJIEQOFO()
	{
		return false;
	}

	public bool QLNIRMEELES()
	{
		return false;
	}

	public bool OQRGNOMJPTJ()
	{
		return false;
	}

	public bool OPHTHTLGFNS()
	{
		return false;
	}

	public bool RILHGPKRREP()
	{
		return false;
	}

	private bool NSHJTRPSFPF()
	{
		return false;
	}

	private bool SRLOTNKHPSL()
	{
		return false;
	}

	public SHJHMMOOGGJ PTJPRNLLKKL()
	{
		return default(SHJHMMOOGGJ);
	}

	public LQJTRNFQISM TILRQQKREFK()
	{
		return null;
	}

	public float OTTNQIOLJQQ()
	{
		return 0f;
	}

	public float NHEHQRIQKNJ()
	{
		return 0f;
	}

	public bool LRKQFTOHLHS(RGPEMGEPIJF EOOEIROQJOE)
	{
		return false;
	}

	public float TOTLQGTFNMM(RGPEMGEPIJF EOOEIROQJOE)
	{
		return 0f;
	}

	public float MMTRPGSKIPH()
	{
		return 0f;
	}

	public float JNTHTNFIIQN()
	{
		return 0f;
	}

	public float IGPQJKHQMLK()
	{
		return 0f;
	}

	public float OOMFNLPLRJK()
	{
		return 0f;
	}

	public float NPHPKPGOIHI()
	{
		return 0f;
	}

	public float PKGELHROIGH()
	{
		return 0f;
	}

	public float EJOLJOJKFHP()
	{
		return 0f;
	}

	public float OSPRTSFILKM()
	{
		return 0f;
	}

	public float SNTRNSJRNEM()
	{
		return 0f;
	}

	public int REPGIQEPRLO()
	{
		return 0;
	}

	public float ITQQOINHTFK()
	{
		return 0f;
	}

	public float IFOJITTNNIF()
	{
		return 0f;
	}

	public int LPFTTMQTFJN()
	{
		return 0;
	}

	public bool IQLQIMGIILT()
	{
		return false;
	}

	public bool RNLSLTGSRGS()
	{
		return false;
	}

	public bool KMGJNKEREFI()
	{
		return false;
	}

	public bool SKRNSOTJGRE()
	{
		return false;
	}

	public bool QKRLHQGSROM()
	{
		return false;
	}

	public int PLTOFIJJELM()
	{
		return 0;
	}

	public JJHFPNTSRLT.GQREPPGJKKQ OIJJTETGSII(int JPKQGSQKETR, WeaponInfo GLRSKRPPLFQ)
	{
		return default(JJHFPNTSRLT.GQREPPGJKKQ);
	}

	public float GSRSLMKJFNK(LQJTRNFQISM EMERMLLSHSL, Actor ETGMMEJFEOP)
	{
		return 0f;
	}

	public float MEMRHSKPMTJ(ProjectileLogic JOJOKFISLEI)
	{
		return 0f;
	}

	public bool ELOQLHMROJS(float OERHTMGNIRQ)
	{
		return false;
	}

	public bool GLTTRHMRJSH()
	{
		return false;
	}

	public bool HGHROHNOGSJ()
	{
		return false;
	}

	public bool SISMLKQQFTS(float OERHTMGNIRQ = 1f)
	{
		return false;
	}

	public int LJEPIEPMSSM()
	{
		return 0;
	}

	public int RTQHJQTMOHI()
	{
		return 0;
	}

	public int IHOIJSPGRNQ()
	{
		return 0;
	}

	public float QPENPMINJHR()
	{
		return 0f;
	}

	public float LHITEMIQNNM()
	{
		return 0f;
	}

	public int SPPTHOGMHKJ()
	{
		return 0;
	}

	public RerollMemory RKPJTJLNMHS(int PSPJIJNTMOI)
	{
		return null;
	}

	private void IMRLKKFGEGE(RerollMemory QLLRIJPKLSO)
	{
	}

	public void LSMLJNHQPRL(int PSPJIJNTMOI)
	{
	}

	public void SRJRLGGNGKE(int PSPJIJNTMOI)
	{
	}

	public void LOLTIJGKFLI(int PSPJIJNTMOI)
	{
	}

	public bool FHQFEQHTFMQ()
	{
		return false;
	}

	public bool MPTLRMPERFF(int PSPJIJNTMOI)
	{
		return false;
	}

	public bool IIMPQMRPSKR(int PNIQKIGEHLF)
	{
		return false;
	}

	public bool JIQKOHEIEKP(int PNIQKIGEHLF)
	{
		return false;
	}

	public int OJHJPJIQHHG(InventoryDisplay.IKKLTMKGQHH LOGFMFHFPEP)
	{
		return 0;
	}

	public int SHHSGJSEPIT(InventoryDisplay.IKKLTMKGQHH LOGFMFHFPEP)
	{
		return 0;
	}

	public int FHHEOSJTFMT(InventoryDisplay.IKKLTMKGQHH LOGFMFHFPEP)
	{
		return 0;
	}

	public bool RSFPQIIGTHG(ProjectileLogic JOJOKFISLEI)
	{
		return false;
	}

	public void OMKMKKQGNFK(Actor TNKMMOJJPPI, Grenade SPJNRSNIJFQ, LQJTRNFQISM EMERMLLSHSL)
	{
	}

	public void EIHNQGLOPEN(ref LQJTRNFQISM EMERMLLSHSL, Grenade SPJNRSNIJFQ, Actor TNKMMOJJPPI, Actor ETGMMEJFEOP)
	{
	}

	public void MQFPFMKKLTG(Actor TNKMMOJJPPI)
	{
	}

	public void LEEQGFTRLHT(ref LQJTRNFQISM EMERMLLSHSL, Actor ETGMMEJFEOP)
	{
	}

	private void OGKOTIJGSHG(ref LQJTRNFQISM EMERMLLSHSL, Actor ETGMMEJFEOP)
	{
	}

	private void PJIHRIRJRFK(ref LQJTRNFQISM EMERMLLSHSL, Actor ETGMMEJFEOP)
	{
	}

	public void FJRTITKGKTM(ProjectileLogic JOJOKFISLEI, Actor ETGMMEJFEOP)
	{
	}

	public void REREMKFOJGL(ProjectileLogic JOJOKFISLEI)
	{
	}

	[CompilerGenerated]
	internal static float TEIFTRNMHRS(int EESTGTGKLJG, int NJLTOMFTSHK, ref TGRTQGPNTRH P_2)
	{
		return 0f;
	}

	[CompilerGenerated]
	internal static void TLLKRJHNMEI(Vector3 PQNITOOPPOG, Vector3 SQRGJORSPIT, ref HSNELMJROKM P_2, ref SJKEEPOKHFT P_3)
	{
	}
}
