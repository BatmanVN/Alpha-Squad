using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShopDailyOffers : ShopOffer
{
	public enum MSTONPRTFHS
	{
		UNSET = 0,
		WEAPON_PART = 1,
		WEAPON = 2,
		CURRENCY = 3,
		AGENT_CARDS = 4,
		RAID_TICKET = 5,
		GEAR_FRAGMENT = 6,
		WEAPON_SCRAP = 7,
		HAMMERS = 8,
		GEAR_SCRAP = 9
	}

	public enum MFTTQOKSJGM
	{
		CASH = 0,
		GEMS = 1
	}

	[Serializable]
	private struct Data
	{
		public int lastResetTimestamp;

		public Offer[] currenShopOffers;

		public bool hasNewDailyOffers;

		public int gemOfferClaims;

		public int lastGemOfferClaimTimestamp;
	}

	[Serializable]
	public class Offer
	{
		public bool purchased;

		public MFTTQOKSJGM priceType;

		public int price;

		public MSTONPRTFHS type;

		public CurrencyData currencies;

		public ItemWeapon weapon;

		public LootElement NORPRQSQQNI()
		{
			return default(LootElement);
		}

		public bool TQRFPGNKJIT()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MHNELIHSPPE
	{
		public Offer offer;

		public ShopDailyOfferElement offerElement;

		public ShopDailyOffers _003C_003E4__this;
	}

	[CompilerGenerated]
	private sealed class QNHRPLHLLTS
	{
		public List<Agent> unlockedAgents;

		internal bool _003CGenerateOfferAgentCards_003Eb__0(JJHFPNTSRLT.PQRIQGIOGQT x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QGOLMSFRQOP
	{
		public JJHFPNTSRLT.PQRIQGIOGQT x;

		internal bool _003CGenerateOfferAgentCards_003Eb__1(Agent o)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NITQRONRNRK
	{
		public GameObject flyObject;

		internal void _003CFlyOffer_003Eb__0()
		{
		}
	}

	private static Data TSRPFHOJKSG;

	private static bool OHQHKQJEILO;

	[SerializeField]
	private ShopDailyOfferElement prefabElement;

	[SerializeField]
	private RectTransform elementParent;

	[SerializeField]
	private UITextTimer timer;

	[SerializeField]
	private Transform flyToLocation;

	[SerializeField]
	private GameObject freeOffer;

	[SerializeField]
	private GameObject freeOfferBlock;

	[SerializeField]
	private NotificationBubble notificationBubble;

	private global::HIJIFHMGTTR<float> OKNHIMHELMG;

	private List<ShopDailyOfferElement> SILFMMSJLIJ;

	public static string KEY;

	public static event Action NTGPNGJIEFM
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

	public static event Action<Offer> JHFGOKRTHQM
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

	public override bool IsAvailable()
	{
		return false;
	}

	public override void Setup(MenuViewShop QJPITOLEQFL)
	{
	}

	public int OnlyShowOffersWithReward(LootElement.TOINELPLRQP EOIPPTIGKGT, bool JTGMLTOKHTO = false)
	{
		return 0;
	}

	private float GKNKGFLNFRO()
	{
		return 0f;
	}

	private void EOQKLPFGEFS(bool EFPQEHRGHSE = true)
	{
	}

	public override void Recheck()
	{
	}

	public override void OnViewEntered(bool HMHSTQGOQTP = false)
	{
	}

	private static void MLNESSGJRME()
	{
	}

	public static void Clear()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	private void PMITOIOJNOT()
	{
	}

	public override void ResetData()
	{
	}

	private void MHKGMRGGGLI()
	{
	}

	private void FSSMJTQEJOJ()
	{
	}

	public void OnTimerEnd()
	{
	}

	private void EFHLTJNFHGQ()
	{
	}

	public void OnOfferClicked(ShopDailyOfferElement ONRTTHNHMLH)
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	public Offer[] GetActiveOffers(out bool JGOMHNJMKQT)
	{
		JGOMHNJMKQT = default(bool);
		return null;
	}

	private Offer GQOILPQTTPP()
	{
		return null;
	}

	private Offer PFSHRTNJEIE(bool RJNIQQSNONH = false)
	{
		return null;
	}

	private Offer LGTRTHGIPMG()
	{
		return null;
	}

	private Offer IRLFJSJEMIM()
	{
		return null;
	}

	private Offer HNLGHINPIII()
	{
		return null;
	}

	private Offer EPMTJKFHEPK(int NNEIIEFGIGG = 0, List<JPHMLSJQLNL> IEHKSMFGGIS = null)
	{
		return null;
	}

	private Offer RFLMEGFMEEL(int EHEHKSMHOIK, bool RJNIQQSNONH)
	{
		return null;
	}

	private Offer HKLGJIJMNQR(int EHEHKSMHOIK = 1)
	{
		return null;
	}

	private Offer GPTPPRLQQHR(int EHEHKSMHOIK)
	{
		return null;
	}

	public void PrintData()
	{
	}

	private void JIEFMQSSQGR(Offer KJOIKHTSLJO)
	{
	}

	private void OFIJJLIRGJQ(Offer KJOIKHTSLJO)
	{
	}

	private void GMTEPTTJMME(ShopDailyOfferElement ONRTTHNHMLH)
	{
	}

	public void AnimateIn()
	{
	}

	public bool HasNewDailyOffers()
	{
		return false;
	}

	public void SetDailyOffersSeen()
	{
	}

	public static int GetSecondsTillNextReset()
	{
		return 0;
	}

	public static int GetOfferResetInterval()
	{
		return 0;
	}

	private bool ROTIFKIMPQK()
	{
		return false;
	}

	public void HideNotificationBubble()
	{
	}

	public static bool IsFreeOfferAvailable()
	{
		return false;
	}

	private void MRTQHMIPPPS()
	{
	}

	private void NLTMRSINITR()
	{
	}

	private static int IMJLEPJREPM()
	{
		return 0;
	}

	private int LHKEKKQOGLP()
	{
		return 0;
	}

	private static int OHQFRPOEHFJ()
	{
		return 0;
	}

	private LootElement KHTIQENHMFG()
	{
		return default(LootElement);
	}

	private static int PJMFRHPKKEE()
	{
		return 0;
	}

	private void JGKRINRMOSK()
	{
	}

	public void OnFreeOfferClicked()
	{
	}

	public void OnFreeOfferTimerUp()
	{
	}

	private Offer OOEGIQLRETQ(int GJGGIMQQELS)
	{
		return null;
	}

	[CompilerGenerated]
	private void EHLHJFQEJQL()
	{
	}

	[CompilerGenerated]
	private void PSKSRLNKJNQ()
	{
	}

	[CompilerGenerated]
	private void TGQEGTIRRJJ(bool SILMTFJJQIJ)
	{
	}
}
