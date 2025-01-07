using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DebugMenuUI : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		public bool showLevelSelectButtons;

		public int weaponRarity;

		public int weaponLevel;

		public int gearRarity;

		public int enemyLootLevel;

		public bool disableDynamicMenus;

		public bool freeWeaponUpgrades;

		public bool freeGearUpgrades;

		public bool freePurchases;

		public bool payingUserStatus;

		public bool experimentalMusic;

		public bool useTimeOffset;

		public bool useHapticInterval;

		public int timeOffset;

		public int daysOffset;

		public int hoursOffset;

		public bool eventDebug;

		public bool allEventTilesMystery;

		public bool freeEnhancementUpgrades;

		public bool showItemMirrorableIcons;

		public int hapticInterval;

		public bool disableRemoteOfferAutoPopup;

		public string deviceIdOverride;

		public bool useLocalClanMissionConfig;

		public long overrideLeagueIndex;

		public List<FKPELPRPORT.FFKJSTPLNNS> enabledGroups;
	}

	public class FKPELPRPORT
	{
		public enum FFKJSTPLNNS
		{
			Cloud = 0,
			Leagues = 1,
			Currencies = 2,
			Resets = 3,
			Offers = 4,
			Account = 5,
			Story = 6,
			Misc = 7
		}

		public FFKJSTPLNNS HSLQJLPMLMH;

		public readonly List<GameObject> OSNPKEOLNOS;
	}

	[CompilerGenerated]
	private sealed class KJENRSLPPKQ
	{
		public int toLevel;

		public DebugMenuUI _003C_003E4__this;

		internal void _003CInit_003Eb__131(int x)
		{
		}

		internal void _003CInit_003Eb__132()
		{
		}

		internal void _003CInit_003Eb__156(bool v)
		{
		}

		internal void _003CInit_003Eb__158(bool v)
		{
		}

		internal void _003CInit_003Eb__162()
		{
		}
	}

	[CompilerGenerated]
	private sealed class PFPFNFLKPTT
	{
		public Agent a;

		internal bool _003CInit_003Eb__174(SkinData s)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KOJGORKJRMK
	{
		public Agent a;

		internal bool _003CInit_003Eb__175(SkinData s)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TTSJOMFIMQO
	{
		public FKPELPRPORT.FFKJSTPLNNS id;

		public FKPELPRPORT group;

		internal bool _003CCreateGroup_003Eb__0(FKPELPRPORT.FFKJSTPLNNS groupId)
		{
			return false;
		}

		internal void _003CCreateGroup_003Eb__1(bool on)
		{
		}
	}

	[CompilerGenerated]
	private sealed class GFQJSKIIMMM
	{
		public Text valueText;

		internal void _003CCreateSlider_003Eb__0(float value)
		{
		}
	}

	[CompilerGenerated]
	private sealed class HQETRLJHFNS
	{
		public Text valueText;

		public UnityAction<int> onChanged;

		public Slider slider;

		public int min;

		internal void _003CCreateSlider_003Eb__0(float value)
		{
		}

		internal void _003CCreateSlider_003Eb__1(float floatValue)
		{
		}

		internal void _003CCreateSlider_003Eb__2()
		{
		}

		internal void _003CCreateSlider_003Eb__3()
		{
		}

		internal void _003CCreateSlider_003Eb__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class NFFIPHSMRPJ
	{
		public Text valueText;

		public UnityAction<int> onChanged;

		public Slider slider;

		public int smallStep;

		public int min;

		internal void _003CCreateTimeSlider_003Eb__0(float value)
		{
		}

		internal void _003CCreateTimeSlider_003Eb__1(float floatValue)
		{
		}

		internal void _003CCreateTimeSlider_003Eb__2()
		{
		}

		internal void _003CCreateTimeSlider_003Eb__3()
		{
		}

		internal void _003CCreateTimeSlider_003Eb__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class ROTJJHELIKS
	{
		public UnityAction<GameObject> onBothButtons;

		public GameObject buttonGO;

		internal void _003CCreateLeftRightButton_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class JNPOMJGNTSJ
	{
		public UnityAction<GameObject> onBothButtons;

		public GameObject buttonGO;

		internal void _003CCreateLeftRightRetriggerButton_003Eb__0()
		{
		}
	}

	private static Data TSRPFHOJKSG;

	public GameObject togglePrefab;

	public GameObject sliderPrefab;

	public GameObject buttonPrefab;

	public GameObject inlinePanelPrefab;

	public GameObject inlineTogglePrefab;

	public GameObject leftRightButtonPrefab;

	public GameObject leftRightRetriggerButtonPrefab;

	public GameObject textInputPrefab;

	public GameObject groupTogglePrefab;

	private GameObject LKTNPHQMGRP;

	private GameObject JHJLRERJQFP;

	private GameObject GEPQIFLMEOL;

	private GameObject GRMQKHSKHQF;

	private GameObject RTGORJOFKMG;

	private GameObject OHGQGQIPFKP;

	private GameObject QIOKIIRREEP;

	private GameObject GKGTINLKMFM;

	private int RNFEJLFPOKS;

	public bool pauseWhileOpen;

	[SerializeField]
	private Transform itemList;

	private bool QOOPLGKOOLG;

	private static bool HQOOJOSJKQK;

	private static int FMOHGRGJKTO;

	public const int MAX_UPGRADE_LEVEL = 230;

	private readonly List<FKPELPRPORT> ENNFOIJKKIO;

	public static string KEY;

	public static Data GetData()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public static void LoadPrefs()
	{
	}

	private void OnDisable()
	{
	}

	private void OMPTJLSEEFM()
	{
	}

	private void SSLGMQOREGN()
	{
	}

	private void TKSKQLLMEIO()
	{
	}

	private static IRHNENTFPPM KEIKILHLTJE()
	{
		return default(IRHNENTFPPM);
	}

	public static void InjectAccount(string NFPMMFPIINT)
	{
	}

	public void Init()
	{
	}

	public bool IsInitialized()
	{
		return false;
	}

	private void EHRSTETMIHO(FKPELPRPORT.FFKJSTPLNNS HSLQJLPMLMH, Color POSNHINOJRL)
	{
	}

	private void MQREOOFJLRM(GameObject FMGEHJFFJIS)
	{
	}

	private void TPQFMIRGLRL(string HETQTIKJGNI, bool LQGOLGFFLMQ, UnityAction<bool> OFQFFMEHIOP)
	{
	}

	private GameObject PSHQNTQELNM(string HETQTIKJGNI, float PMQHJOLGQLM, float PRRKFGTQTJK, float NHJLNIHMJRG, UnityAction<float> OFQFFMEHIOP)
	{
		return null;
	}

	private GameObject PSHQNTQELNM(string HETQTIKJGNI, int PMQHJOLGQLM, int PRRKFGTQTJK, int NHJLNIHMJRG, UnityAction<int> OFQFFMEHIOP, UnityAction<GameObject> SELPKIGHQHN = null)
	{
		return null;
	}

	private GameObject MJJTRLMSINI(string HETQTIKJGNI, int PMQHJOLGQLM, int PRRKFGTQTJK, int NHJLNIHMJRG, UnityAction<int> OFQFFMEHIOP, UnityAction<GameObject> SELPKIGHQHN = null, int KNIMNOKRPKL = 60)
	{
		return null;
	}

	private GameObject TQINMPNLPFR(string QHFKPNOPTLP, UnityAction<string> FTIRORMSPEK)
	{
		return null;
	}

	private GameObject GMOLIEJJNPO(string HETQTIKJGNI, Color POSNHINOJRL, UnityAction LNOEEIHPRIE)
	{
		return null;
	}

	private GameObject PSOJIORQISG(string HETQTIKJGNI, Color POSNHINOJRL, UnityAction QIEPEMKNKSL, UnityAction PHIRGEFLLNE, UnityAction<GameObject> FSQQISJMRQM = null)
	{
		return null;
	}

	private GameObject STRRTGENFLN(string HETQTIKJGNI, Color POSNHINOJRL, UnityAction QIEPEMKNKSL, UnityAction PHIRGEFLLNE, UnityAction<GameObject> FSQQISJMRQM = null)
	{
		return null;
	}

	private GameObject KRRNNIMEOIL()
	{
		return null;
	}

	private GameObject OORENTSTJFG(Transform JKFPSLRREIJ, string HETQTIKJGNI, bool LQGOLGFFLMQ, UnityAction<bool> OFQFFMEHIOP)
	{
		return null;
	}

	[CompilerGenerated]
	internal static string HRQRMOEMFEK()
	{
		return null;
	}

	[CompilerGenerated]
	internal static bool TMNEFGFFHTO(QuestList PINOQRIOMNF)
	{
		return false;
	}

	[CompilerGenerated]
	internal static void KMQREKHJNGO(WeaponData.OHHQFFINRQH OJTGHRGORLS)
	{
	}

	[CompilerGenerated]
	internal static Task KNSQKKKSGFH()
	{
		return null;
	}

	[CompilerGenerated]
	private bool KEQNJJESFEM(FKPELPRPORT.FFKJSTPLNNS GNKIKJOFGRI)
	{
		return false;
	}

	[CompilerGenerated]
	internal static string SQKMQLFPRGR(int RRPSNPOTQNT)
	{
		return null;
	}
}
