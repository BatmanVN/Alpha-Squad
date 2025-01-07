using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class ROTEMKIJGSP
{
	private enum SRQGLISQOLH
	{
		DEFAULT = 0,
		BLOCKED = 1,
		GUARANTEED = 2
	}

	[Serializable]
	private struct Config
	{
		public float item_drop_percent;

		public float cash_drop_percent;

		public float gem_drop_percent;

		public float wrench_drop_percent;

		public float scrap_drop_percent;

		public float bonus_droprate_from_pass;

		public float drop_item_level_multiplier;

		public int drop_item_level_addition_max;

		public float cash_drop_multiplier;

		public DropConfigRow[] drop_table;

		public float cash_multiplier_min;

		public float cash_multiplier_max;

		public float cash_elite_multiplier;

		public int[] lootbox_drop_enemy_count;

		public float item_drop_chance_stacking_increase;

		public float wrench_drop_chance_stacking_increase;

		public float elite_item_drop_multiplier;

		public int max_item_level;

		public float modifier_droprate_gm_kill_enemies;

		public float modifier_droprate_gm_bomb;

		public float modifier_droprate_gm_waves;

		public float legendary_upgrade_chance;

		public bool legendary_always_max_level;
	}

	[Serializable]
	private struct Data
	{
		public bool weaponDropsAllowed;
	}

	[Serializable]
	public struct DropConfigRow
	{
		public int lootLevel;

		public int[] itemWeights;

		public int[] materialWeights;

		public int cashDrop;

		public static DropConfigRow GKHFTNIILSM(DropConfigRow HHRGQEQGGIS, DropConfigRow ELEIPINNGGJ, float OGFKHSKTHHR)
		{
			return default(DropConfigRow);
		}

		public DropConfigRow EMHTREEOMMT()
		{
			return default(DropConfigRow);
		}

		public override string ToString()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class HSNENFQLPFL
	{
		public KNSKIMFQMTH category;

		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CCreateItemGear_003Eb__0(GearData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class OHFSKLHFNFI
	{
		public KNSKIMFQMTH category;

		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CCreateItemGear_003Eb__0(GearData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class GKNEKPMPERS
	{
		public int enemyLevel;

		internal bool _003CGetWeaponsForEnemyLevel_003Eb__0(WeaponData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MSKJGJTNOPG
	{
		public WeaponData.OHHQFFINRQH categoryRoll;

		internal bool _003CGenerateItemWeapon_003Eb__0(WeaponData x)
		{
			return false;
		}
	}

	public static string JKPNPHQEOKN;

	private static Config SOSLGOOOIPG;

	private static Data TSRPFHOJKSG;

	private static bool QOOPLGKOOLG;

	private static Random TTTRRFJLTEN;

	public static bool TIHGKEIIRSH;

	private static Dictionary<int, DropConfigRow> SKPRMRGSHHS;

	private static readonly List<int> NTHIHMQMJPJ;

	private static readonly List<int> HGPMRFGRTEG;

	public static readonly List<WeaponData.OHHQFFINRQH> HEOMNTHFNTO;

	private static List<WeaponData> INSOOLEIRNI;

	private static JJHFPNTSRLT.PQRIQGIOGQT[] SQTTFHKHMEQ;

	private static void MLNESSGJRME()
	{
	}

	public static void PMITOIOJNOT()
	{
	}

	public static void MGRLTPGGSSI()
	{
	}

	public static void RKQNFPGQNOP(int IFIKFFPOPSP)
	{
	}

	public static void MRTSGFKOOET(Random IFQMLFLTGNG)
	{
	}

	public static Random GSGHRJLGFQO()
	{
		return null;
	}

	public static void MPRMRMJPEKK(GameController.KFPHKOMNHSS NSQRHJPNSGL)
	{
	}

	public static float NLLLFHHGTNN()
	{
		return 0f;
	}

	public static ItemWeapon HPSQRKFRNIT(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int EESQJISERQF, JPHMLSJQLNL HSLQJLPMLMH, int HKGFNOEPMPN = 1, int OTESLRQHSKO = 0)
	{
		return null;
	}

	public static ItemGear TFMOEHKINGE(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
		return null;
	}

	public static ItemGear TFMOEHKINGE(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, KNSKIMFQMTH EMKNPKTIJPF)
	{
		return null;
	}

	public static ItemGear TFMOEHKINGE(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, MNJMPEKHPTO OKKIQNGEFPQ, KNSKIMFQMTH OJTGHRGORLS)
	{
		return null;
	}

	public static LootList LSTFNILIKHF(int QJQINTKJTJQ, EnemySpot.SMMGLQPTJET PFIHOFSRMEH, LootList HGPMKKGJFHI = null)
	{
		return null;
	}

	public static LootList JETOEKMFGIL(int NGKTHMIHMIK, int HSLQJLPMLMH)
	{
		return null;
	}

	public static LootList EMNTOHMKTHQ(int NGKTHMIHMIK, int HSLQJLPMLMH)
	{
		return null;
	}

	public static LootList MIGEHHHROPR(int QJQINTKJTJQ, LootboxSpot.QHMTEIRRMIM EOOEIROQJOE, OperationController.JMSSNJLGTFN IPMQOGFTQMG = OperationController.JMSSNJLGTFN.UNSET)
	{
		return null;
	}

	private static LootList PFNESLHIRER(int QJQINTKJTJQ, OperationController.JMSSNJLGTFN OPJNKTMSTJR)
	{
		return null;
	}

	private static LootList QFJPTLIJOQH(int QJQINTKJTJQ)
	{
		return null;
	}

	private static LootList ENSIIORITOO(int NGKTHMIHMIK)
	{
		return null;
	}

	private static LootList JRLFLRTTFNO(int QJQINTKJTJQ)
	{
		return null;
	}

	private static LootList NSIKNJOPOKQ(int QJQINTKJTJQ)
	{
		return null;
	}

	private static int SRKQQRRJEML(DropConfigRow PTPGRRKHSNQ, bool IEQTGJESMKS)
	{
		return 0;
	}

	public static List<WeaponData> NNJJIJEJGPG(int HHFHLJFISQF)
	{
		return null;
	}

	private static ItemWeapon SNETNHRHGMP(DropConfigRow PTPGRRKHSNQ, bool QSMMKSJRSQG = true, bool OERLQPLHQKQ = false)
	{
		return null;
	}

	public static ItemWeapon SNETNHRHGMP(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int QJQINTKJTJQ, bool QSMMKSJRSQG = true, bool QSJORHOJILM = false, List<JPHMLSJQLNL> SFQHSRJROLE = null, bool OERLQPLHQKQ = false)
	{
		return null;
	}

	public static ItemWeapon MIITIIPNNJG(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, WeaponData.OHHQFFINRQH OJTGHRGORLS, int QJQINTKJTJQ, bool QSMMKSJRSQG = true, bool QSJORHOJILM = false, List<JPHMLSJQLNL> SFQHSRJROLE = null, bool OERLQPLHQKQ = false)
	{
		return null;
	}

	public static List<WeaponData> QRPHTGIRIFG(List<JPHMLSJQLNL> SFQHSRJROLE, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int QJQINTKJTJQ, bool FNPIMFIPPLT = false, WeaponData.OHHQFFINRQH OJTGHRGORLS = WeaponData.OHHQFFINRQH.UNSET)
	{
		return null;
	}

	public static List<JJHFPNTSRLT.LegendaryWeaponDefinition> FEGMTLSPQPO(List<JPHMLSJQLNL> SFQHSRJROLE, List<JJHFPNTSRLT.LegendaryWeaponDefinition> OIITJETIPPH, int QJQINTKJTJQ)
	{
		return null;
	}

	private static JJHFPNTSRLT.PQRIQGIOGQT JPIPHMINERK(DropConfigRow LONRTOTEOGE)
	{
		return default(JJHFPNTSRLT.PQRIQGIOGQT);
	}

	public static DropConfigRow FIPRLLMKFRE(int QJQINTKJTJQ)
	{
		return default(DropConfigRow);
	}

	private static float JOPKNGELJOP()
	{
		return 0f;
	}

	private static SRQGLISQOLH JGSLMMEISOL()
	{
		return default(SRQGLISQOLH);
	}

	private static bool TQFSOESSEMS(LootElement.TOINELPLRQP EOOEIROQJOE)
	{
		return false;
	}

	public static bool SJGPNEKENNN()
	{
		return false;
	}

	private static float SLSNLPENIKL(bool IEQTGJESMKS)
	{
		return 0f;
	}

	private static float TOJMEQRKTQJ()
	{
		return 0f;
	}

	private static float ROQNHFSTPKT()
	{
		return 0f;
	}

	private static float TTRPRNLPFGJ(bool IEQTGJESMKS)
	{
		return 0f;
	}

	private static float QKQKIISQHIL(int JNRRKFLIGRF)
	{
		return 0f;
	}

	private static float KTSFFRNHERR()
	{
		return 0f;
	}

	public static void GQGSSOHGSEI(bool HHRGQEQGGIS)
	{
	}

	public static int QFTPRMETPGF(int QJQINTKJTJQ, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, bool FNPIMFIPPLT, int ONOJQQFFHII = 0)
	{
		return 0;
	}

	public static JJHFPNTSRLT.MinMaxValueInt QIEEJLMLLTO(int QJQINTKJTJQ)
	{
		return default(JJHFPNTSRLT.MinMaxValueInt);
	}

	public static int GSLIEETNIMT()
	{
		return 0;
	}

	public static bool IFOKGJOMISK()
	{
		return false;
	}
}
