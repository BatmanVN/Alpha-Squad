using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DebugClanBaseUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PJLHGJHFRIJ
	{
		public int roomIdx;

		public ClanBaseRoom.JFKMJEPEHOK[] types;

		public int level;

		public DebugClanBaseUI _003C_003E4__this;

		public int boostIdx;

		public int maxBoostId;

		public int boostLevel;

		public int maxBoostLevel;

		public int clanCoinsAmount;

		public int clanTokensAmount;

		public int xp;

		internal void _003CInit_003Eb__13()
		{
		}

		internal void _003CInit_003Eb__14()
		{
		}

		internal void _003CInit_003Eb__15(GameObject go)
		{
		}

		internal void _003CInit_003Eb__16()
		{
		}

		internal void _003CInit_003Eb__17()
		{
		}

		internal void _003CInit_003Eb__18(GameObject go)
		{
		}

		internal void _003CInit_003Eb__19()
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

		internal void _003CInit_003Eb__23()
		{
		}

		internal void _003CInit_003Eb__24()
		{
		}

		internal void _003CInit_003Eb__25(GameObject go)
		{
		}

		internal void _003CInit_003Eb__26()
		{
		}

		internal void _003CInit_003Eb__27(string arg0)
		{
		}

		internal void _003CInit_003Eb__28()
		{
		}

		internal void _003CInit_003Eb__29(string arg0)
		{
		}

		internal void _003CInit_003Eb__30()
		{
		}

		internal void _003CInit_003Eb__31(string arg0)
		{
		}

		internal void _003CInit_003Eb__32()
		{
		}
	}

	[CompilerGenerated]
	private sealed class IRKETIHPOQL
	{
		public Text valueText;

		internal void _003CCreateSlider_003Eb__0(float value)
		{
		}
	}

	[CompilerGenerated]
	private sealed class GJQPHJOKJPN
	{
		public Text valueText;

		public UnityAction<int> onChanged;

		internal void _003CCreateSlider_003Eb__0(float value)
		{
		}

		internal void _003CCreateSlider_003Eb__1(float floatValue)
		{
		}
	}

	[CompilerGenerated]
	private sealed class SLIEJIPMTMG
	{
		public UnityAction<GameObject> onBothButtons;

		public GameObject buttonGO;

		internal void _003CCreateLeftRightButton_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class LJPMHTLSOJE
	{
		public UnityAction<GameObject> onBothButtons;

		public GameObject buttonGO;

		internal void _003CCreateLeftRightRetriggerButton_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class TEOJMFHPFFN
	{
		public Text valueText;

		public UnityAction<int> onChanged;

		internal void _003CCreateTimeSlider_003Eb__0(float value)
		{
		}

		internal void _003CCreateTimeSlider_003Eb__1(float floatValue)
		{
		}
	}

	public GameObject togglePrefab;

	public GameObject sliderPrefab;

	public GameObject buttonPrefab;

	public GameObject inlinePanelPrefab;

	public GameObject inlineTogglePrefab;

	public GameObject leftRightButtonPrefab;

	public GameObject leftRightRetriggerButtonPrefab;

	public GameObject textInputPrefab;

	[SerializeField]
	private Transform itemList;

	private GameObject LKTNPHQMGRP;

	private GameObject RTGORJOFKMG;

	private GameObject OHGQGQIPFKP;

	private GameObject GKGTINLKMFM;

	private GameObject KKMSKENLLFF;

	public bool pauseWhileOpen;

	private bool QOOPLGKOOLG;

	private static bool HQOOJOSJKQK;

	private static DebugMenuUI.Data TSRPFHOJKSG;

	[NonSerialized]
	public static bool showRoomDebug;

	[NonSerialized]
	public static bool debugNPCs;

	[NonSerialized]
	public static bool showDonationDebug;

	private static int PLNGRQSRTJG;

	public bool IsInitialized()
	{
		return false;
	}

	private void OMPTJLSEEFM()
	{
	}

	private void Awake()
	{
	}

	public static void LoadPrefs()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Hide()
	{
	}

	public void Init()
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

	private GameObject MJJTRLMSINI(string HETQTIKJGNI, int PMQHJOLGQLM, int PRRKFGTQTJK, int NHJLNIHMJRG, UnityAction<int> OFQFFMEHIOP, UnityAction<GameObject> SELPKIGHQHN = null)
	{
		return null;
	}

	private Task SNINRSHQOKL(bool EFGPQFIJRJF, int ISLTSKEPJPI)
	{
		return null;
	}

	private Task TQLGEIFKISH(int PQJFJINPGPL)
	{
		return null;
	}

	private Task LRIQOLEPKRM(int OJJLFPMNEHN, int IQLQQNIPTPQ)
	{
		return null;
	}

	private Task IGPEGSQOOSG(int OJJLFPMNEHN, int IQLQQNIPTPQ)
	{
		return null;
	}

	[CompilerGenerated]
	internal static void HGSSSKGNGIF()
	{
	}

	[CompilerGenerated]
	internal static string QFRPTELIOHM(int RRPSNPOTQNT)
	{
		return null;
	}
}
