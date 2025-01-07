using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Modifications : TMIIMQSTIRJ
{
	public enum FRLLMTOOMJO
	{
		WEAPON_ON_ENEMY_HIT = 0,
		SHIELD_ON_SHOT_AR = 1
	}

	public enum PLNNLMSLLHK
	{
		ULTIMATE_TOXIC_POOL = 0,
		WEAPON_SLOW = 1,
		GEAR_EXPLOSIVES_SLOW = 2,
		GEAR_SLOW_ADJACENT_ON_KILL = 3,
		MODIFIER = 4,
		SLOW_FIELD = 5,
		WEAPON_SHOCKWAVE_SLOW = 5
	}

	public enum QRJTSQHKRFS
	{
		ON_HIT_TAKEN = 0,
		ENHANCEMENT_ON_KILL = 1,
		WEAPON_ON_KILL = 2,
		MODIFIER_ON_CRIT = 3,
		WEAPON_ON_HIT = 4,
		WEAPON_ON_RELOAD = 5
	}

	public enum RNSMLJGLKSO
	{
		WEAPON_BONUS_ON_KILL = 0,
		AFFIX_DAMAGE_AURA = 1,
		GAME_MOD_DEBUFF = 2,
		GEAR_PERK_EXPLOSIVE_HIT = 3,
		GEAR_CRIT_STACKING_DAMAGE = 4,
		GEAR_LONG_AFTER_KILL = 5,
		GEAR_ONSHOT = 6,
		COLT_ENHANCEMENT = 7,
		RICK_ENHANCEMENT = 8
	}

	public static class IQGLTNJSJEN
	{
		public const float SEENLLKMFNT = 2f;
	}

	private struct NJIPTGJOSKK
	{
		public NNFTTJERLEM PFPFNLQONOG;

		public List<int> NKSLRJJMSJJ;
	}

	public enum EJNHFNIFFEO
	{
		UPDATE = 0,
		STACK = 1,
		INCREASE = 2,
		STACK_WITH_IDENTIFIER = 3,
		STACK_MAX = 4,
		STACK_WITH_ACTOR = 5
	}

	public enum KIKFPKSIOIO
	{
		SINGLE = 0,
		SUM = 1,
		CUSTOM = 2,
		MULTIPLY = 3,
		MULTIPLY_PER_IDENTIFIER = 4
	}

	[Serializable]
	public struct ModificationData
	{
		public float startTime;

		public float duration;

		public float value;

		public NNFTTJERLEM mod;

		public float userValueFloat;

		public int userValueInt;

		public Actor applier;

		public bool QSRLKSRLPGE()
		{
			return false;
		}

		public bool OFOTKEMGMKJ(float HNMPLNRTRHH)
		{
			return false;
		}

		public float MHGETGRLMIM()
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}

	private struct LITQPRRGSSK
	{
		public NNFTTJERLEM PFPFNLQONOG;

		public Utils.Timer EKFSSTEMLFQ;
	}

	[CompilerGenerated]
	private sealed class ESOKGRJQTTN
	{
		public NNFTTJERLEM mod;

		internal bool _003CApplyMod_003Eb__0(ModificationData x)
		{
			return false;
		}
	}

	public static readonly Dictionary<NNFTTJERLEM, EJNHFNIFFEO> APPLICATION_TYPES;

	public static readonly Dictionary<NNFTTJERLEM, KIKFPKSIOIO> CALCULATION_TYPES;

	private static readonly NNFTTJERLEM[] NON_SPREADABLE_MODS;

	public static readonly List<NNFTTJERLEM> MULTIVALUE_MODS;

	private static List<NJIPTGJOSKK> UNIQUE_IDENTIFIERS_CACHE;

	public const float FROZEN_DAMAGE_MULTIPLIER = 2.5f;

	[NonSerialized]
	public Actor owner;

	[CompilerGenerated]
	private Action<ModificationData, bool> OnModApplied;

	[CompilerGenerated]
	private Action<ModificationData> OnModEnded;

	[SerializeField]
	private List<ModificationData> modData;

	private FEFFRELGMTT.LFOSJEMQPKI cooldowns;

	private global::HIJIFHMGTTR<float> cachedTotalShield;

	private float totalShieldCacheExpirationTime;

	private Dictionary<int, float> tempList;

	private float[] slows;

	private float[] speedBoosts;

	public event Action<ModificationData, bool> QGOQSRPHISS
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

	public event Action<ModificationData> NKGSESHNFRR
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

	public bool NLOHQIHQONK(NNFTTJERLEM PFPFNLQONOG)
	{
		return false;
	}

	public float MSOSTOQTMNM(NNFTTJERLEM PFPFNLQONOG)
	{
		return 0f;
	}

	public List<ModificationData> JEKLFJSELNF(NNFTTJERLEM PFPFNLQONOG)
	{
		return null;
	}

	public int PTFISKHOKKR(NNFTTJERLEM PFPFNLQONOG)
	{
		return 0;
	}

	public bool GEEOSSEJPNS(NNFTTJERLEM PFPFNLQONOG)
	{
		return false;
	}

	private float MNMKJMGOMKS(ModificationData KPERIOFQLEM, bool SKHLPGHTFJE)
	{
		return 0f;
	}

	public void MIEIPOSIJGR(NNFTTJERLEM PFPFNLQONOG, float RRPSNPOTQNT, float MKLLHHINHJP, Actor OHKRJEKTLSM, int PNJLHENNJFS = 0, bool IFHTEMSPILL = true)
	{
	}

	public void ERFKGHQSGRT(NNFTTJERLEM PFPFNLQONOG, float RRPSNPOTQNT, float MKLLHHINHJP, Actor OHKRJEKTLSM, int GQNQLIEOHPR, bool IFHTEMSPILL = true)
	{
	}

	public void FOEEMPOPOSF()
	{
	}

	public void LOJPFJNTGGR(NNFTTJERLEM PFPFNLQONOG, bool KMTEKIGLJHF = false)
	{
	}

	public ModificationData HJTGSOSTIJQ(NNFTTJERLEM PFPFNLQONOG)
	{
		return default(ModificationData);
	}

	private void KPIIJHIESRM(NNFTTJERLEM PFPFNLQONOG)
	{
	}

	public static int SOLIEHPKSHH(NNFTTJERLEM PFPFNLQONOG)
	{
		return 0;
	}

	public static void GLMMIOIROHP(NNFTTJERLEM PFPFNLQONOG, int HSLQJLPMLMH)
	{
	}

	public static void LFRKMLGRHEE()
	{
	}

	public void ROOROHMLQEM()
	{
	}

	private void FMTIOGJMHTH(NNFTTJERLEM PFPFNLQONOG, float NSQGRQMGOJS, Actor OHKRJEKTLSM, bool JGLKFNOQIQS = true, bool TOSOGHJTFQT = true)
	{
	}

	private ITKSRPQLPQN NQMRHGILTMS(NNFTTJERLEM PFPFNLQONOG)
	{
		return default(ITKSRPQLPQN);
	}

	public List<ModificationData> POTTHQRQEEP()
	{
		return null;
	}

	public int IOTEHQNFLNF()
	{
		return 0;
	}

	private void TPINMQEKMNO(NNFTTJERLEM JKRQSLILLQK)
	{
	}

	private float[] FPINORPRTIS()
	{
		return null;
	}

	private float[] ESEEGJNLQJK()
	{
		return null;
	}

	public float GRGLLIEGKMR()
	{
		return 0f;
	}

	public float OHIIHRLEMRP()
	{
		return 0f;
	}

	public float KLFOOQHKJHE()
	{
		return 0f;
	}

	public float PEHIFQQJNTQ()
	{
		return 0f;
	}

	public float KREOSJOSPPF(ModificationData QMTPESINPTO)
	{
		return 0f;
	}

	public float JJESISQNMMS(ModificationData QMTPESINPTO)
	{
		return 0f;
	}

	public void HGNHNEKIQPT(LQJTRNFQISM EMERMLLSHSL)
	{
	}

	public static bool LMPGFQEQRMT(NNFTTJERLEM PFPFNLQONOG)
	{
		return false;
	}

	public static bool SPNMHRIPOQE(NNFTTJERLEM PFPFNLQONOG)
	{
		return false;
	}

	public static bool MNNPTROPROO(NNFTTJERLEM PFPFNLQONOG)
	{
		return false;
	}

	public static bool GOGSTFGPKES(NNFTTJERLEM PFPFNLQONOG)
	{
		return false;
	}

	public static float ENITKETGJPQ(NNFTTJERLEM PFPFNLQONOG)
	{
		return 0f;
	}

	public static int GEGGELQIJMM(NNFTTJERLEM PFPFNLQONOG)
	{
		return 0;
	}

	public static int QNFSTIGTNKF(Actor NIHPIGRSJMO, WeaponData.OHHQFFINRQH EMKNPKTIJPF)
	{
		return 0;
	}

	public static bool NKOFEFJSLPJ(NNFTTJERLEM PFPFNLQONOG)
	{
		return false;
	}

	public void EIRPJQLMMIT(ref float NSQGRQMGOJS)
	{
	}

	public float LIEHTKFNPTS()
	{
		return 0f;
	}

	private void NKNNOMQTTNM()
	{
	}

	private void RFTHTLRGQEF()
	{
	}
}
