using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public abstract class UIRoom : UIPanel
{
	[CompilerGenerated]
	private sealed class LFENTHOSQOR
	{
		public int lastSeenLevel;

		public int currentLevel;

		internal bool _003CGetNewItems_003Eb__0(EOQPNKSSOTM.ShopItem item)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KGGHLKPROPG
	{
		public int id;

		internal bool _003CIsNewItem_003Eb__0(int itemId)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FJTMFMRFOKH
	{
		public UIRoom _003C_003E4__this;

		public EOQPNKSSOTM.ShopItem shopItem;

		public UIShopElement element;

		internal void _003CShowPurchaseConfirmation_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class JSJFTHLHIIT
	{
		public LootList rw;

		internal void _003CClaimPurchase_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class EOIKTHRGIEE
	{
		public Action onEndCallback;

		internal void _003CScrollToRect_003Eb__0()
		{
		}
	}

	[SerializeField]
	protected Transform itemHolder;

	protected VerticalLayoutGroup PFPGSLSHITN;

	[SerializeField]
	private UIShopElement shopElementPrefab;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private GameObject spinnerWithSpinner;

	[SerializeField]
	private UIRoomUpgrade uiRoomUpgrade;

	[SerializeField]
	private UITextTimer timer;

	[SerializeField]
	protected UIRoomShopElementOverlay elementOverlay;

	[SerializeField]
	private ScrollRectEx scroll;

	private List<UIShopElement> PETLTREEEHN;

	[SerializeField]
	protected ClanShopConfirmationPopup confirmationPopup;

	protected List<JJHFPNTSRLT.WeaponPart> MMTHMSINOGN;

	protected UIShopElement NJHRHHHGHKI;

	public ClanBaseRoom.JFKMJEPEHOK roomType;

	private bool QOOPLGKOOLG;

	private int PRKILKNKNKS;

	public ClanShopItemData PIKJTQGJFMG => null;

	public int NRLQISRHTTQ => 0;

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	protected void FPRSKHGLOIT()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OPENKMJGPOK()
	{
	}

	public void TryToUpgrade()
	{
	}

	public void TryToAssist(Action KQGHTRIGRTT)
	{
	}

	public void TryToClaim()
	{
	}

	protected virtual void TPRKMSSROGR()
	{
	}

	public ClanShopItem GetItem(EOQPNKSSOTM.ShopItem HPJMQLRTORF)
	{
		return null;
	}

	public LootIdentifier GetLoot(EOQPNKSSOTM.ShopItem HPJMQLRTORF)
	{
		return default(LootIdentifier);
	}

	public virtual List<int> GetNewItems()
	{
		return null;
	}

	public bool IsNewItem(int HSLQJLPMLMH)
	{
		return false;
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public virtual void OnBack()
	{
	}

	public int GetShopId()
	{
		return 0;
	}

	public virtual void TryToPurchase(EOQPNKSSOTM.ShopItem HPJMQLRTORF, UIShopElement MMFGGGGJGHJ = null, Action LNERFQEJNNE = null)
	{
	}

	protected virtual int RPPPMPPOHOE()
	{
		return 0;
	}

	private Task<bool> JESKEINGTIR(UIShopElement MMFGGGGJGHJ)
	{
		return null;
	}

	public Task<bool> CheckPurchaseRequirements(int QIROGTNPJFG, Transform NTJQOGJKPQT)
	{
		return null;
	}

	public void SpawnNotEnoughCurrencyFloatingText(UIShopElement MMFGGGGJGHJ)
	{
	}

	protected virtual void PITKGNKGRPS(Transform NTJQOGJKPQT)
	{
	}

	public void ShowPurchaseConfirmation(UIShopElement MMFGGGGJGHJ)
	{
	}

	public void ShowLootSelection(UIShopElement MMFGGGGJGHJ)
	{
	}

	public virtual bool HaveEnoughCurrency(int QIROGTNPJFG)
	{
		return false;
	}

	private void NOJSNFHKNJE(List<JJHFPNTSRLT.WeaponPart> NJEOLRESTJM)
	{
	}

	private void FJNNMSJKRTL(EOQPNKSSOTM.ShopItem HPJMQLRTORF, int SMJQEMMNNIG)
	{
	}

	public void ClaimPurchase(LootIdentifier GTNLNSRKHET, int ISLTSKEPJPI, int QIROGTNPJFG, int SMJQEMMNNIG)
	{
	}

	protected virtual void FIQJQNTMOKI(int QIROGTNPJFG, int SMJQEMMNNIG, LootList FJJJFHTQFHP)
	{
	}

	protected virtual void NJPGIPPLNNI()
	{
	}

	private void KFOOEQJRMHK()
	{
	}

	private void FSNHSSMHSET()
	{
	}

	private void JJPNTSINTFS()
	{
	}

	private void KOOPFKJSKGE(bool TEENRGPFHKL = false)
	{
	}

	private void JHSJJRMKIKE()
	{
	}

	public bool IsItemLimitReached(EOQPNKSSOTM.ShopItem HPJMQLRTORF)
	{
		return false;
	}

	public virtual bool IsUnlockRequirementMet(EOQPNKSSOTM.ShopItem HPJMQLRTORF)
	{
		return false;
	}

	private void NTPJRIPEIGF(RectTransform MMFGGGGJGHJ, float JPKGQSMKSTF = 0f, Action NRRHLFONPPM = null, Ease GNGNKIOHLMF = Ease.InOutSine)
	{
	}

	public void ToggleInputBlocker(bool RRPSNPOTQNT, bool TEENRGPFHKL = false, bool OIQNLGSSLET = false)
	{
	}

	public virtual void StartCraftAnimation(UIShopElement MMFGGGGJGHJ)
	{
	}

	public string GetItemName(LootIdentifier GTNLNSRKHET)
	{
		return null;
	}

	protected virtual void OLLLMQOKGEH(UIShopElement MMFGGGGJGHJ, ClanServerCalls.RpcResponse MHGSOKIEHQE)
	{
	}

	protected virtual void OJKOMSRTJKN()
	{
	}

	protected virtual string JTSQLOPPRTF()
	{
		return null;
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	[CompilerGenerated]
	private void IPHFQEPEPHL()
	{
	}

	[CompilerGenerated]
	private void NNMFFFISLRT()
	{
	}

	[CompilerGenerated]
	private void KJJLLTGTLSE()
	{
	}
}
