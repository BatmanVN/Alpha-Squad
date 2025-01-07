using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuItemPopup : UIPopup
{
	private enum SRLKPNTHJFF
	{
		REGULAR = 0,
		PURCHASE = 1,
		SNEAK_PEAK = 2,
		PREVIEW = 3
	}

	private enum OKRHMPJMPSE
	{
		UP = 0,
		DOWN = 1,
		HOLD = 2
	}

	[CompilerGenerated]
	private sealed class IRNTIRPQNIT
	{
		public ItemWeapon data;

		internal bool _003CSetupForItem_003Eb__0(ItemWeapon x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct OELNQSPKSPQ
	{
		public List<string> allEquippedWeapons;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct HKGNGPEHRNJ
	{
		public List<string> allEquippedWeapons;
	}

	[NonSerialized]
	public MenuViewInventory inventoryView;

	[NonSerialized]
	public ItemWeapon data;

	private ItemWeapon HJTEKJQROSK;

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[SerializeField]
	private FloatingErrorText prefabFloatingUpgradeText;

	[SerializeField]
	private FadingResourceCount prefabFloatingIconUsed;

	[SerializeField]
	private GameObject prefabRankReached;

	[SerializeField]
	private GameObject popup;

	[SerializeField]
	private WeaponStatsVisual weaponStats;

	[SerializeField]
	public WeaponPreviewLarge weaponPreview;

	[SerializeField]
	private WeaponBonusesVisual weaponBonuses;

	[SerializeField]
	public WeaponPopupBottom bottomVisuals;

	[SerializeField]
	private WeaponPopupSideButtons sideButtons;

	[SerializeField]
	private Text weaponName;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private Transform upgradeErrorLocation;

	[SerializeField]
	private GameObject lockIconActive;

	[SerializeField]
	private GameObject lockIconInactive;

	[SerializeField]
	private GameObject lockParent;

	[SerializeField]
	private GameObject scrapParent;

	[SerializeField]
	private RectTransform rankParent;

	[SerializeField]
	private RectTransform empowerParent;

	[SerializeField]
	public Button lockButton;

	[SerializeField]
	private Image scrapButton;

	[SerializeField]
	private Image scrapCogs;

	[SerializeField]
	private Animator rankUpAnim;

	[SerializeField]
	private Animator empowerAnim;

	[SerializeField]
	private Material scrapButtonmaterial;

	[SerializeField]
	private float buttonHoldTime;

	[SerializeField]
	private float delayBeforeLbOrRank;

	[SerializeField]
	private float delayAfterLbOrRank;

	private SRLKPNTHJFF MJPJLPIKQFE;

	private bool SNQKRQSTKPI;

	private int EESQJISERQF;

	private bool NNOHFOJKIMS;

	public bool exitAllowed;

	private int QMENOSOPGRE;

	private int MNJPSOPMFGN;

	private GameObject JKLONMTORIK;

	private GameObject JHHQKFPSKST;

	private global::HIJIFHMGTTR<Vector3> FQJGGOHRPKT;

	private global::HIJIFHMGTTR<Vector3> MERKGPRIHSF;

	private ShopDailyOffers.Offer FEFEHHJPHJT;

	private bool JOTEMGQKMJS;

	private bool FKLPORMNPTH;

	private bool RTEEPENORSL;

	private OKRHMPJMPSE KSKLFETQFHS;

	private float JTTPGPJLPJK;

	private float KPGGGIJQTRN;

	private float IKKJPFEGIKS;

	private bool FMSORSGNJLO;

	private List<ItemWeapon> LKTSJTGMETH;

	private event Action OOLSLMJGRRK
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

	public static void OpenForItem(ItemWeapon TSRPFHOJKSG, bool SMSFFSFROEG = true, bool JEPRTELNILG = false, bool PRLEJONOPLK = true)
	{
	}

	public static void OpenForPurchase(Action NMMRHIIRFER, ShopDailyOffers.Offer FTMHSEPTHPR, bool PRLEJONOPLK = true)
	{
	}

	public static void OpenForPreview(ItemWeapon TSRPFHOJKSG, bool SNQKRQSTKPI = true, bool PRLEJONOPLK = true)
	{
	}

	public static void OpenForSneakPeak(ItemWeapon TSRPFHOJKSG, bool PRLEJONOPLK = true)
	{
	}

	protected override void MGKPMPHSLFR()
	{
	}

	private void GJLIOFJSGFI(int RSGJFSGHFTN)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void GMNEEGJPFSE(ItemWeapon TSRPFHOJKSG, bool SMSFFSFROEG = true, bool JEPRTELNILG = false)
	{
	}

	private void KMNTLOMFLNP(Action NMMRHIIRFER, ShopDailyOffers.Offer FTMHSEPTHPR)
	{
	}

	private void IMSLNRQPTET(ItemWeapon TSRPFHOJKSG, bool SIQMQOSLNOI = true)
	{
	}

	private void ETSGOKEPTFR(ItemWeapon TSRPFHOJKSG)
	{
	}

	private void SPMENIIKSIG(bool KQGHGPEKKTJ = false)
	{
	}

	private void PJKTSJPJHOR(bool ROMGOMISSOS = false)
	{
	}

	private void FRPOJISFGRG(bool NKQTMFETQKK = true, bool JEPRTELNILG = false)
	{
	}

	public void ShowMaxed()
	{
	}

	private void KEHJKTNEHER()
	{
	}

	public void Update()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnEquipButton()
	{
	}

	public void OnUpgradeButtonDown(BaseEventData QSSIJRMPEQF)
	{
	}

	public void OnUpgradeButtonUp(BaseEventData QSSIJRMPEQF)
	{
	}

	private void ESEHRHPSNIJ()
	{
	}

	private void QJLMKMRPNQQ()
	{
	}

	private void RTNPFLGOTGL(int KKRLLGIHMHT = -1)
	{
	}

	public void OnUpgradeButton()
	{
	}

	public void OnRankUpButton()
	{
	}

	public void OnEmpowerButton()
	{
	}

	public void OnBuyButton()
	{
	}

	public void OnCompareButton()
	{
	}

	public void OnMaxButton()
	{
	}

	public void OnDegradeButton()
	{
	}

	public void OnMaxOutButton()
	{
	}

	public void OnSwapButtonLeft()
	{
	}

	public void OnSwapButtonRight()
	{
	}

	private void QFSNPQTETOL(LootList HIQFHPSQQNT)
	{
	}

	private void THFKNHRJOOJ(LootList HIQFHPSQQNT)
	{
	}

	public void OnScrapButton()
	{
	}

	public void OnLimitBreakCommingSoon()
	{
	}

	private FloatingErrorText KMQIMTNTOMN(string HETQTIKJGNI, Transform HSSNSPQEIGR = null, bool JIETLHRJEEJ = true)
	{
		return null;
	}

	public void BlockAutoCloseUpdate()
	{
	}

	public void OnLimitBreakButton()
	{
	}

	public void OnLockButton()
	{
	}

	private void OTEEMQEMSGR(bool SMSFFSFROEG, bool PHRIGHKERON = false)
	{
	}

	private void TTJLJHQOJPF()
	{
	}

	private bool QLNIRMEELES()
	{
		return false;
	}

	private bool RILHGPKRREP()
	{
		return false;
	}

	private bool LSSKSRQIJJP()
	{
		return false;
	}

	private bool OHNIGRSQRGK()
	{
		return false;
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	private void TKGEJTJFSSF()
	{
	}

	public void BeginRankUpAnim(GameObject ETGMMEJFEOP)
	{
	}

	public void OnRankUpAnimAppeared()
	{
	}

	public void OnRankUpAnimFinished()
	{
	}

	public void BeginEmpowerAnim(GameObject ETGMMEJFEOP)
	{
	}

	public void OnEmpowerAnimAppeared()
	{
	}

	public void OnEmpowerAnimFinished()
	{
	}

	private void IHKRGQNSJQO()
	{
	}

	[CompilerGenerated]
	private void LPQOGEQSHQJ()
	{
	}

	[CompilerGenerated]
	private void MRNHPIHTEMG()
	{
	}

	[CompilerGenerated]
	private void NHQQPRTMFMI()
	{
	}

	[CompilerGenerated]
	private bool NHJHHLRKTHG(string HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	internal static int KTHFIEQOOEJ(int KQQINSRPRNP, ref OELNQSPKSPQ P_1)
	{
		return 0;
	}

	[CompilerGenerated]
	private bool KQFMTQPIPHP(string HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	internal static int MPFKOGKQMII(int KQQINSRPRNP, ref HKGNGPEHRNJ P_1)
	{
		return 0;
	}
}
