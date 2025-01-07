using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChestOpenPopup : UIPopup
{
	[Serializable]
	public struct ChestQualityObject
	{
		public ChestController.MFRETPOLGOE quality;

		public GameObject gameObject;
	}

	[CompilerGenerated]
	private sealed class HRLGFPGSPFQ
	{
		public MenuChestCard c;

		public LootElement cle;

		internal void _003CDoubleRewards_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class KIQGJSFSJMK
	{
		public List<int> availableCards;

		public ChestOpenPopup _003C_003E4__this;

		public MenuChestCard boostedCard;

		public int highlights;

		internal void _003CAnimateCardBoost_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class QPQNILMQLNR
	{
		public float t;

		public int k;

		public KIQGJSFSJMK CS_0024_003C_003E8__locals1;

		internal void _003CAnimateCardBoost_003Eb__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class SLTONMQPOSM
	{
		public int k;

		public ChestOpenPopup _003C_003E4__this;

		internal void _003CShowBoostOutcome_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class NSFMPFONRIS
	{
		public LootElement rw;

		internal bool _003CAddCardForReward_003Eb__0(MenuChestCard c)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NNTITHNFTSJ
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CIsRewardRare_003Eb__0(JJHFPNTSRLT.RarityNumber x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HNKIKMNPIIK
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CIsRewardVeryRare_003Eb__0(JJHFPNTSRLT.RarityNumber x)
		{
			return false;
		}
	}

	[SerializeField]
	private MenuChestCard prefabCard;

	[SerializeField]
	private GameObject prefabLayoutRow;

	[SerializeField]
	private MenuChestCardDrop chestCardDrop;

	[SerializeField]
	private List<MenuChestCard> allCards;

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[Space]
	[SerializeField]
	private RectTransform chestLocation;

	[SerializeField]
	private RectTransform cardsLocation;

	[SerializeField]
	private RectTransform cardSpawnLocation;

	[SerializeField]
	private RectTransform finalCardsParent;

	[Space]
	[SerializeField]
	private Button okButton;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private Button boostButton;

	[SerializeField]
	private Button boostVipButton;

	[SerializeField]
	private Button boostGemsButton;

	[SerializeField]
	private Button boostFreeButton;

	[SerializeField]
	private Button open1MoreTokensButton;

	[SerializeField]
	private Button open10MoreTokensButton;

	[SerializeField]
	private Button open1MoreGemsButton;

	[SerializeField]
	private Button open10MoreGemsButton;

	[SerializeField]
	private Button skipButton;

	[SerializeField]
	private AdFetchSpinner boostButtonSpinner;

	[Space]
	[SerializeField]
	private Text labelPrice1MoreGems;

	[SerializeField]
	private Text labelPrice10MoreGems;

	[SerializeField]
	private Text labelPrice1MoreTokens;

	[SerializeField]
	private Text labelPrice10MoreTokens;

	[Space]
	[SerializeField]
	private Text labelBoost;

	[SerializeField]
	private Text labelBoostFree;

	[SerializeField]
	private Text labelBoostVip;

	[Space]
	[SerializeField]
	private Image iconChestTokens;

	[SerializeField]
	private Image backgroundChestTokens;

	[SerializeField]
	private Image iconChestTokens10;

	[SerializeField]
	private Image backgroundChestTokens10;

	[SerializeField]
	private GameObject effectExplosion;

	[SerializeField]
	private GameObject effectExplosionLegendary;

	[SerializeField]
	private Transform locationEffectExplosion;

	private Transform NPQSJLOIKNE;

	[SerializeField]
	private GameObject effectCardBlow;

	[SerializeField]
	private GameObject effectCardBlowLegendary;

	[SerializeField]
	private Transform locationEffectCardBlow;

	[Space]
	private LootList OPHQESJTOLF;

	private Animator GMEJIMGLTOG;

	private ChestController.MFRETPOLGOE QJMNKNLSJTO;

	private ChestController.ChestData STSHQFSJQGT;

	private bool EMQMRLOTRKJ;

	private int EGJSGSFPHLQ;

	private bool GOHIIROOFPG;

	private bool IPHHJQOHSOE;

	private bool RIRLSMJLKGS;

	private bool JFRTGIPMIFF;

	private int IGSEJOMOONT;

	private RectTransform MIELMMTFKTR;

	private int GQQJQFKSTMK;

	private const int KRISELOOOHJ = 4;

	private bool RSERSJERFNJ;

	private Vector3 MNFGPEHSPKO;

	private Tween TMPMSGPPJJP;

	private bool SHKMHRGRERO;

	private Sequence MFIMPSSMSGO;

	private bool NTFNEKRQQMJ;

	private bool GFKQFEMKGQT;

	private List<JJHFPNTSRLT.RarityNumber> GNOTMGFONMF;

	private int PMJQGTHLHTE;

	private int FQMEFNFGPJF;

	private int MIKTFLIJJOF;

	private LootElement TSQQTMRJRTN;

	public event Action<ChestController.ChestData> JHHIFJTQPON
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

	protected override void MGKPMPHSLFR()
	{
	}

	public static bool Open(ChestController.ChestData TSRPFHOJKSG)
	{
		return false;
	}

	public static bool OpenForward(ChestController.ChestData TSRPFHOJKSG, bool FSGSLJETSLF = true)
	{
		return false;
	}

	private new void Awake()
	{
	}

	public void Setup(ChestController.ChestData OTSSKRRHTOO, bool HILRPHJFQNF = true, int QEQPJGEFRMJ = 1, bool FSGSLJETSLF = true)
	{
	}

	public void Setup(ChestController.ChestData OTSSKRRHTOO, LootList QFJFSEMOOEH, bool HILRPHJFQNF = true, bool FSGSLJETSLF = true)
	{
	}

	private void PFKEMGSKMOH()
	{
	}

	private void OnEnable()
	{
	}

	private void QPOIQRQLSHE(bool RHOIJKGIEEP = false)
	{
	}

	private void MTLMFLRHOOL()
	{
	}

	private string GONKOFSKPNH()
	{
		return null;
	}

	private string GPGMPEKFLPL()
	{
		return null;
	}

	private KMRKTMLSKEE.LGIGEMPPJRT EGEHOFSRENJ()
	{
		return default(KMRKTMLSKEE.LGIGEMPPJRT);
	}

	public void OnScreenTouch()
	{
	}

	public void OnOKButton()
	{
	}

	public void OnBoostButton()
	{
	}

	public void OnBoostVipButton()
	{
	}

	public void OnBoostGemsButton()
	{
	}

	public void OnBoostFreeButton()
	{
	}

	public void OnOpen1MoreGems()
	{
	}

	public void OnOpen10MoreGems()
	{
	}

	public void OnOpen1MoreTokens()
	{
	}

	public void OnOpen10MoreTokens()
	{
	}

	public void OnOpen10MoreWpTokens()
	{
	}

	public void OnSkipButton()
	{
	}

	private void LGKSHFELLRH(Button ELEIPINNGGJ)
	{
	}

	private void FNFRKMFSQMK()
	{
	}

	private void PGKHQIHRKQF()
	{
	}

	private void KEEMFMKRRMH(bool SSGKQJMORSG)
	{
	}

	private void MNRLPRPGEGQ(Button ELEIPINNGGJ, float PRRKGRQILFR = 0f)
	{
	}

	private void OEHJEKHTLJT(float PRRKGRQILFR = 0f)
	{
	}

	private void QLITTRLPTIN()
	{
	}

	private void NFRNPLRESKN()
	{
	}

	private void RMTIFSNFTPI()
	{
	}

	private void HIKRREGJGPI()
	{
	}

	private void NMTKGHFQEHI()
	{
	}

	private void PRRMKGKSNIO(Transform HSSNSPQEIGR, LootElement INNLJIGRFOG, int ISLTSKEPJPI = -1)
	{
	}

	public bool IsWeaponTokenPaymentAvailable()
	{
		return false;
	}

	public int GetWeaponTokenPaymentTimeRemaining()
	{
		return 0;
	}

	private void EQRTESFNHQF()
	{
	}

	private void NSEMJSIKGJH(bool JEPRTELNILG = true, bool TMLGLFQPHJN = false)
	{
	}

	private bool TFRPHPTLGHR()
	{
		return false;
	}

	private void QGIONLGTGKG(LootElement QFJFSEMOOEH, bool LQQOJMNLORE = true)
	{
	}

	private void IMFIQMJIGHI()
	{
	}

	private void FGFKSNQSKRN(bool HPPQLMNLMQR = false)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public override void OnShowFinished()
	{
	}

	public override void OnHideFinished()
	{
	}

	private void KRPGSHQEKNI(LootList IHRKNRPNGOM, bool FSGSLJETSLF)
	{
	}

	private void ITSMNPSILIR(LootList IHRKNRPNGOM)
	{
	}

	private void POEGKSNRIFJ()
	{
	}

	private void QTETOLLGSMG()
	{
	}

	private void LERKKIGQEEM()
	{
	}

	private void SENMJLIGFGQ()
	{
	}

	private void NQKEJKJJGHQ()
	{
	}

	private void QTNTMFQMEON()
	{
	}

	private void HIJMOFEKGPJ()
	{
	}

	public void MenuChestCardDrop_OnPlay()
	{
	}

	public void MenuChestCardDrop_OnCardArrived()
	{
	}

	public void MenuChestCardDrop_OnAnimEnd()
	{
	}

	private void JRHRQHMNLOT(bool FPITTGNIQOS)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	private bool EGSLHKTGLSP(LootElement QFJFSEMOOEH)
	{
		return false;
	}

	private bool SGMJSLJLKIJ(LootElement QFJFSEMOOEH)
	{
		return false;
	}

	public static bool IsRewardLegendary(LootElement QFJFSEMOOEH)
	{
		return false;
	}

	private int NGPPONJOHLM()
	{
		return 0;
	}

	private int RSLNPJLISPO(LootElement OEESQHTSGJL)
	{
		return 0;
	}

	private FloatingErrorText KMQIMTNTOMN(string HETQTIKJGNI, Transform HSSNSPQEIGR = null, bool JIETLHRJEEJ = true, float OHGGOMMGTIP = 1f)
	{
		return null;
	}

	[CompilerGenerated]
	private void NOQJNPRGPOS(bool SILMTFJJQIJ)
	{
	}

	[CompilerGenerated]
	private void KLKQTHQHJJJ()
	{
	}

	[CompilerGenerated]
	private void NRMEHMOQSHO()
	{
	}

	[CompilerGenerated]
	private void HOGJKLLESGJ()
	{
	}

	[CompilerGenerated]
	private void FMFGOHRISGL()
	{
	}

	[CompilerGenerated]
	private void PJRTENFEIPO()
	{
	}

	[CompilerGenerated]
	private void GNOPKOSIQMM()
	{
	}

	[CompilerGenerated]
	private void HTMRKMKKJGG()
	{
	}

	[CompilerGenerated]
	private void IPPIMJGRGRT()
	{
	}

	[CompilerGenerated]
	private void NREKEIPGFHT()
	{
	}

	[CompilerGenerated]
	private void TSFHRQJTNSF()
	{
	}

	[CompilerGenerated]
	private int IFOMIGJGRJM(MenuChestCard HHRGQEQGGIS, MenuChestCard ELEIPINNGGJ)
	{
		return 0;
	}

	[CompilerGenerated]
	private void FHFFOHEQRPJ()
	{
	}

	[CompilerGenerated]
	private void FPQFQSTESHF()
	{
	}
}
