using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SayKitInternal;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

public class Purchaser : Singleton<Purchaser>, IStoreListener
{
	private struct TSOJJHPEPNR
	{
		public string HSLQJLPMLMH;

		public Action<bool> KQGHTRIGRTT;
	}

	[Serializable]
	private struct PurchaseCount
	{
		public string id;

		public int count;
	}

	[Serializable]
	private class Data
	{
		public List<PurchaseCount> purchases;

		public float totalMoneySpent;

		public float averagePurchase;

		public int lastPurchaseTimestamp;
	}

	public struct KGEIKQHSJRT
	{
		public ProductType EOOEIROQJOE;

		public Action<Product> ETLGJKKSMOJ;

		public bool MTGILFLNMMK;

		public KGEIKQHSJRT(ProductType EOOEIROQJOE, Action<Product> ETLGJKKSMOJ, bool MTGILFLNMMK = false)
		{
			this.EOOEIROQJOE = default(ProductType);
			this.ETLGJKKSMOJ = null;
			this.MTGILFLNMMK = false;
		}
	}

	[CompilerGenerated]
	private sealed class QPTFKOEFJHJ
	{
		public string purchaseKey;

		internal bool _003CGetPurchaseCount_003Eb__0(PurchaseCount x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KEFHFOQNRLT
	{
		public Purchaser _003C_003E4__this;

		public string id;

		public Product product;

		public Action<bool> callback;

		internal void _003CBuyProduct_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct SIONPJMENIF
	{
		public string productPrice;
	}

	public static HashSet<Product> pendingProducts;

	private static IStoreController JNEJHNMNNFQ;

	private static IExtensionProvider TPFQFJOJIMS;

	public bool DEBUG;

	[SerializeField]
	private UnityEvent OnPurchaserInitialize;

	private Dictionary<string, KGEIKQHSJRT> EORINHHEIEP;

	private List<TSOJJHPEPNR> TGSHTQMGFNE;

	private static Data TSRPFHOJKSG;

	private CultureInfo NGNTIGRLQIE;

	private static string EQHNLNMKKLG;

	private static string JISFRQILEGG;

	private static string RNSIOJOMHIM;

	private static string SMMNOLNTEPL;

	public static string LAST_PURCHASE_KEY;

	public static string KEY;

	public event Action TNSGOMROPGF
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

	public event Action LNPNJOQNHSO
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

	public event Action<bool> KMTRSHKQRTO
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

	public event Action<bool, string> NRRHQJMLKSN
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

	public bool IsInitialized()
	{
		return false;
	}

	public void Initialize()
	{
	}

	public bool HasMadeAPurchase()
	{
		return false;
	}

	public bool HasMadeAPurchaseLastDays(int PEITEOESSJM)
	{
		return false;
	}

	public static void Clear()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static void ForceLoad()
	{
	}

	public static void ForceSave()
	{
	}

	private static void PMITOIOJNOT()
	{
	}

	private void IGPRSTOHQNT(string PFNRHNGPHRH)
	{
	}

	public int GetPurchaseCount(string PFNRHNGPHRH)
	{
		return 0;
	}

	public void OnInitialized(IStoreController ERPRSLOFJSM, IExtensionProvider SGGRIMKSGFI)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason SFESIOJKLIM)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason SFESIOJKLIM, string MRFTETPMTNJ)
	{
	}

	public void OnPurchaseFailed(Product PIRRFTRTOFP, PurchaseFailureReason SKOJGTGOPIF)
	{
	}

	private void KFEMRFJLMOM(Product QFLHGLLPPNR)
	{
	}

	private void SIQRIPHGERR(string HSLQJLPMLMH, bool QMLEHJIFQTF)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs QHSMPFPKNMM)
	{
		return default(PurchaseProcessingResult);
	}

	private void LQRHIHELRTL(InAppProduct MHGSOKIEHQE)
	{
	}

	public void ConfirmPendingPurchase(Product QFLHGLLPPNR)
	{
	}

	private void ISIEIEPGQTM()
	{
	}

	public void AddProduct(string HSLQJLPMLMH, KGEIKQHSJRT TSRPFHOJKSG)
	{
	}

	public void BuyProduct(string HSLQJLPMLMH, Action<bool> KQGHTRIGRTT)
	{
	}

	private void JPPPHLLLMTQ(PurchaseEventArgs RHJFPMHGGEO, Action<InAppProduct> EGKNPEKELSJ = null)
	{
	}

	public string GetPrice(string HSLQJLPMLMH)
	{
		return null;
	}

	public void RestorePurchases()
	{
	}

	public Product GetProduct(string HSLQJLPMLMH)
	{
		return null;
	}

	private KGEIKQHSJRT GOLFFQGKJKT(string HSLQJLPMLMH)
	{
		return default(KGEIKQHSJRT);
	}

	private void IEEGRLQKRNH()
	{
	}

	public float GetTotalMoneySpent()
	{
		return 0f;
	}

	public void ForceResetData()
	{
	}

	public CultureInfo GetCultureInfoFromISOCurrencyCode(string KHQMKRLQGMM, string TEGJIHIQEHF)
	{
		return null;
	}

	[CompilerGenerated]
	private void QFSPRGNMLSP(bool IQJOHOEIKFS)
	{
	}

	[CompilerGenerated]
	internal static bool EIRPMERKFFG(CultureInfo ELJGPRHPKGQ, ref SIONPJMENIF P_1)
	{
		return false;
	}
}
