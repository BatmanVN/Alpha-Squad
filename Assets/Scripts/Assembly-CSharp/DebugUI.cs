using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DebugUI : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		public bool useMainListIndex;

		public int mainListIndex;

		public bool playerCantAttack;

		public bool playerInvulnerable;

		public bool enemiesInvulnerable;

		public int weaponIndex;

		public bool enemyCountOverride;

		public bool forceLootboxes;

		public bool forceGemLootboxes;

		public bool forceScrapLootboxes;

		public bool forceAgentLootboxes;

		public bool friendlyFire;

		public bool allowAllEnemies;

		public bool alwaysSpawnElites;

		public bool alwaysSpawnMiniBosses;

		public bool forceEnemyType;

		public bool overrideVisual;

		public int worldIndex;

		public int worldVariation;

		public int stageSeed;

		public int enemyLevel;

		public int minibossBreakpoints;

		public bool autoWeaponSwitch;

		public bool reloadWeaponOnSwitch;

		public bool reloadWeaponOnTap;

		public bool reloadHold;

		public bool ignoreDropMinimumEnemyLevel;

		public bool ignoreDropMinimumRarity;

		public bool joystickVisible;

		public bool joystickForceMax;

		public bool debugButtonsVisible;

		public bool visualsHidden;

		public bool minibossAnimSkip;

		public bool forceHaveUltimate;

		public bool infiniteRevives;

		public bool wavesGameplayMode;

		public bool bombGameplayMode;

		public float moveSpeed;

		public float moveAcceleration;

		public bool showBossHealth;

		public float hapticDelay;

		public List<GTIMJFKHLHH> affixes;

		public EnemySpot.SMMGLQPTJET miniboss;

		public EnemySpot.OOSTRKKLKGI category;

		public EnemySpot.SMMGLQPTJET enemyType;

		public float hapticAmplitude;

		public float hapticFrequency;

		public float hapticDuration;

		public int forcedStageId;

		public bool dpsMeterEnabled;

		public List<RJGIFRHIHHO.NQMHMQLQQJR> enabledGroups;
	}

	public class RJGIFRHIHHO
	{
		public enum NQMHMQLQQJR
		{
			Core = 0,
			Level = 1,
			Adjustments = 2,
			UI = 3,
			Haptic = 4
		}

		public NQMHMQLQQJR HSLQJLPMLMH;

		public readonly List<GameObject> OSNPKEOLNOS;
	}

	[CompilerGenerated]
	private sealed class SEJPFHTISOI
	{
		public DebugUI _003C_003E4__this;

		public GameObject sliderGO;

		public GameObject minibossGrid;

		public GameObject affixGrid;

		public GameObject categoryGrid;

		public GameObject enemyGrid;

		public Transform gridItems;

		internal void _003CInit_003Eb__0(int x)
		{
		}

		internal void _003CInit_003Eb__1(float v)
		{
		}

		internal void _003CInit_003Eb__2(bool x)
		{
		}

		internal void _003CInit_003Eb__3(bool x)
		{
		}

		internal void _003CInit_003Eb__4(bool x)
		{
		}

		internal void _003CInit_003Eb__5(bool x)
		{
		}

		internal void _003CInit_003Eb__6(bool x)
		{
		}

		internal void _003CInit_003Eb__7(bool x)
		{
		}

		internal void _003CInit_003Eb__8(bool x)
		{
		}

		internal void _003CInit_003Eb__9(bool x)
		{
		}

		internal void _003CInit_003Eb__10(bool x)
		{
		}

		internal void _003CInit_003Eb__12(bool x)
		{
		}

		internal void _003CInit_003Eb__13(bool x)
		{
		}

		internal void _003CInit_003Eb__55(int x)
		{
		}

		internal void _003CInit_003Eb__14(bool x)
		{
		}

		internal void _003CInit_003Eb__15(GameObject go)
		{
		}

		internal void _003CInit_003Eb__16(string val)
		{
		}

		internal void _003CInit_003Eb__17(bool x)
		{
		}

		internal void _003CInit_003Eb__18(GameObject go)
		{
		}

		internal void _003CInit_003Eb__19(GameObject go)
		{
		}

		internal void _003CInit_003Eb__20()
		{
		}

		internal void _003CInit_003Eb__21()
		{
		}

		internal void _003CInit_003Eb__22(GameObject go)
		{
		}

		internal void _003CInit_003Eb__23(bool x)
		{
		}

		internal void _003CInit_003Eb__24(bool x)
		{
		}

		internal void _003CInit_003Eb__25(bool x)
		{
		}

		internal void _003CInit_003Eb__26(bool x)
		{
		}

		internal void _003CInit_003Eb__27(bool x)
		{
		}

		internal void _003CInit_003Eb__28(bool x)
		{
		}

		internal void _003CInit_003Eb__29(bool x)
		{
		}

		internal void _003CInit_003Eb__30(bool x)
		{
		}

		internal void _003CInit_003Eb__31(bool x)
		{
		}

		internal void _003CInit_003Eb__32(bool x)
		{
		}

		internal void _003CInit_003Eb__34(bool x)
		{
		}

		internal void _003CInit_003Eb__35(float x)
		{
		}

		internal void _003CInit_003Eb__36(float x)
		{
		}

		internal void _003CInit_003Eb__37(bool x)
		{
		}

		internal void _003CInit_003Eb__38(bool x)
		{
		}

		internal void _003CInit_003Eb__39(bool x)
		{
		}

		internal void _003CInit_003Eb__40(bool x)
		{
		}

		internal void _003CInit_003Eb__41()
		{
		}

		internal void _003CInit_003Eb__42()
		{
		}

		internal void _003CInit_003Eb__43(GameObject obj)
		{
		}

		internal void _003CInit_003Eb__44()
		{
		}

		internal void _003CInit_003Eb__45(float x)
		{
		}

		internal void _003CInit_003Eb__46(float x)
		{
		}

		internal void _003CInit_003Eb__47(float x)
		{
		}

		internal void _003CInit_003Eb__48(float x)
		{
		}

		internal void _003CInit_003Eb__49()
		{
		}
	}

	[CompilerGenerated]
	private sealed class EJMNMEEMTFH
	{
		public GTIMJFKHLHH a;

		public SEJPFHTISOI CS_0024_003C_003E8__locals1;

		internal void _003CInit_003Eb__51(bool x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class GORLSNSEKRL
	{
		public EnemySpot.SMMGLQPTJET e;

		public SEJPFHTISOI CS_0024_003C_003E8__locals2;

		internal void _003CInit_003Eb__52()
		{
		}
	}

	[CompilerGenerated]
	private sealed class IERLJQMJRPI
	{
		public EnemySpot.OOSTRKKLKGI c;

		public SEJPFHTISOI CS_0024_003C_003E8__locals3;

		internal void _003CInit_003Eb__53()
		{
		}
	}

	[CompilerGenerated]
	private sealed class GJIMNTPKSGK
	{
		public EnemySpot.SMMGLQPTJET e;

		public IERLJQMJRPI CS_0024_003C_003E8__locals4;

		internal void _003CInit_003Eb__54()
		{
		}
	}

	[CompilerGenerated]
	private sealed class JPRROTOSLQE
	{
		public GameObject sliderGO2;

		internal void _003CInit_003Eb__56(float v)
		{
		}
	}

	[CompilerGenerated]
	private sealed class OTJQGMPGFEJ
	{
		public RJGIFRHIHHO.NQMHMQLQQJR id;

		public RJGIFRHIHHO group;

		public DebugUI _003C_003E4__this;

		internal bool _003CCreateGroup_003Eb__0(RJGIFRHIHHO.NQMHMQLQQJR groupId)
		{
			return false;
		}

		internal void _003CCreateGroup_003Eb__1(bool on)
		{
		}
	}

	[CompilerGenerated]
	private sealed class SILMMNPNJJG
	{
		public Text valueText;

		internal void _003CCreateSlider_003Eb__0(float value)
		{
		}
	}

	[CompilerGenerated]
	private sealed class IRHPKOQSKSP
	{
		public Text valueText;

		public UnityAction<int> onChanged;

		public Slider slider;

		public int smallStep;

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
	private sealed class IFJRRGQHLSO
	{
		public UnityAction<GameObject> onBothButtons;

		public GameObject buttonGO;

		internal void _003CCreateLeftRightButton_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class LEIERFQNEGP
	{
		public UnityAction<GameObject> onBothButtons;

		public GameObject buttonGO;

		internal void _003CCreateLeftRightRetriggerButton_003Eb__0()
		{
		}
	}

	public Data data;

	public GameObject togglePrefab;

	public GameObject sliderPrefab;

	public GameObject buttonPrefab;

	public GameObject inlinePanelPrefab;

	public GameObject inlineTogglePrefab;

	public GameObject leftRightButtonPrefab;

	public GameObject leftRightRetriggerButtonPrefab;

	public GameObject gridPrefab;

	public GameObject gridTogglePrefab;

	public GameObject textInputPrefab;

	public GameObject groupTogglePrefab;

	private GameObject LKTNPHQMGRP;

	private Text GLMPJMOJKIR;

	private InputField QGOOHGHQQLS;

	private int RNFEJLFPOKS;

	public bool pauseWhileOpen;

	[SerializeField]
	private Transform itemList;

	private bool QOOPLGKOOLG;

	private readonly List<RJGIFRHIHHO> ENNFOIJKKIO;

	public static string KEY;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void LoadPrefs()
	{
	}

	private void OnDisable()
	{
	}

	private void OMPTJLSEEFM()
	{
	}

	private void EOHRPGTTTME(int HSLQJLPMLMH)
	{
	}

	public void ClearEnterStageIdField()
	{
	}

	public void Init()
	{
	}

	private string RGGPLOOJFNI()
	{
		return null;
	}

	public void UpdateStageSelectButton()
	{
	}

	public bool IsInitialized()
	{
		return false;
	}

	private void EHRSTETMIHO(RJGIFRHIHHO.NQMHMQLQQJR HSLQJLPMLMH, Color POSNHINOJRL)
	{
	}

	private void MQREOOFJLRM(GameObject FMGEHJFFJIS)
	{
	}

	private void TPQFMIRGLRL(string HETQTIKJGNI, bool LQGOLGFFLMQ, UnityAction<bool> OFQFFMEHIOP)
	{
	}

	private GameObject REGQLMRSPMM()
	{
		return null;
	}

	private GameObject FHHQLRLJLQJ(string HETQTIKJGNI, bool LQGOLGFFLMQ, UnityAction<bool> OFQFFMEHIOP)
	{
		return null;
	}

	private GameObject PSHQNTQELNM(string HETQTIKJGNI, float PMQHJOLGQLM, float PRRKFGTQTJK, float NHJLNIHMJRG, UnityAction<float> OFQFFMEHIOP)
	{
		return null;
	}

	private GameObject PSHQNTQELNM(string HETQTIKJGNI, int PMQHJOLGQLM, int PRRKFGTQTJK, int NHJLNIHMJRG, UnityAction<int> OFQFFMEHIOP, UnityAction<GameObject> SELPKIGHQHN = null, int KNIMNOKRPKL = 60)
	{
		return null;
	}

	private GameObject TQINMPNLPFR(string QHFKPNOPTLP, UnityAction<string> FTIRORMSPEK)
	{
		return null;
	}

	private GameObject GMOLIEJJNPO(string HETQTIKJGNI, Color POSNHINOJRL, UnityAction LNOEEIHPRIE, bool HRLFEQKHMSH = false)
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
	private bool PJGTKPKLFOO(RJGIFRHIHHO.NQMHMQLQQJR GNKIKJOFGRI)
	{
		return false;
	}
}
