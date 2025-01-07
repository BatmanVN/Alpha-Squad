using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace RemoteOffers
{
	public class RemoteOffersController : MonoBehaviour
	{
		[Serializable]
		public struct Data
		{
			public List<RemoteOfferData> activeOffers;

			public int lastPullTimestamp;

			public List<RemoteOfferDataSmall> minPreviousOffers;

			public List<RemoteOfferData> processingOffers;
		}

		[Serializable]
		public struct Config
		{
			public int pullInterval;

			public int popupReopenInterval;

			public int dataVersion;

			public string abVersion;
		}

		[CompilerGenerated]
		private sealed class NJOKLRKTGTO
		{
			public RemoteOfferData[] offers;

			public RemoteOffersController _003C_003E4__this;
		}

		[CompilerGenerated]
		private sealed class JNKKJLOHJTF
		{
			public int i;

			public NJOKLRKTGTO CS_0024_003C_003E8__locals1;

			internal bool _003CSetupLocalOfferData_003Eb__2(RemoteOfferData x)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class JLPHMOEEGEF
		{
			public int i;

			public NJOKLRKTGTO CS_0024_003C_003E8__locals2;

			internal bool _003CSetupLocalOfferData_003Eb__3(RemoteOfferData x)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class PLGJMSQHMKN
		{
			public int i;

			public NJOKLRKTGTO CS_0024_003C_003E8__locals3;

			internal bool _003CSetupLocalOfferData_003Eb__4(RemoteOfferData x)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class PMTRNSQSQFN
		{
			public int ts;

			public RemoteOffersController _003C_003E4__this;

			internal bool _003CGetHighestPriorityOffer_003Eb__2(RemoteOfferData x)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class TNMRHHOPJFG
		{
			public Action<bool> OnCompleted;

			public RemoteOfferData offer;

			public RemoteOffersController _003C_003E4__this;

			internal void _003CPurchaseOffer_003Eb__0(bool ok)
			{
			}
		}

		public static readonly string[] PURCHASE_IDS;

		private Data TSRPFHOJKSG;

		private Config SOSLGOOOIPG;

		private bool LFJSQKHPEHG;

		[SerializeField]
		private SerializableDictionary<RFQKSENFITG, MiniOfferRemoteBase> miniOffers;

		private bool JJSETFRFIFR;

		public static string KEY;

		public event Action QTJJHNJNQIO
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

		private void Start()
		{
		}

		private void KLJEPKORMLM()
		{
		}

		private static Data LPIRFJFFOQO()
		{
			return default(Data);
		}

		private static Data JNKJNEPTOSS()
		{
			return default(Data);
		}

		private static void HRLRLIEJRLF(Data TSRPFHOJKSG)
		{
		}

		private void PMITOIOJNOT()
		{
		}

		private void ERFGNOLKSNQ()
		{
		}

		private void EFHLTJNFHGQ()
		{
		}

		public static void ClearSavedData()
		{
		}

		private Task QMPOFQFPLKM()
		{
			return null;
		}

		private Task<string> PPGGNTGSGMQ()
		{
			return null;
		}

		private void OETKMLGQPJF(string FFJPETQOPQO)
		{
		}

		private void GSPHFJRGLSI(bool PPGOPOMSKNQ = true)
		{
		}

		private RemoteOfferData KHNGEQTFSLL()
		{
			return null;
		}

		public RemoteOfferData GetActiveOfferForProductId(string MQNHOQLRLQO)
		{
			return null;
		}

		public RemoteOfferData GetActiveOfferForUniqueId(string QTPQKINSGJH)
		{
			return null;
		}

		public RemoteOfferData GetProcessingOfferForProductId(string MQNHOQLRLQO)
		{
			return null;
		}

		public void RemoteOfferDataUpdated()
		{
		}

		private void INFTMFLPPLT()
		{
		}

		private static void EPNEETMLFKI(RemoteOfferData GLNTLSLQFFS, string IQONSGKROOT, ref Data TSRPFHOJKSG)
		{
		}

		private void OQTPFKQHKLS()
		{
		}

		private void PELJPFEIHHS()
		{
		}

		public static void OpenPopupForOffer(RemoteOfferData GLNTLSLQFFS, bool PRLEJONOPLK = false)
		{
		}

		private void KKHLSPOTIMO()
		{
		}

		public static void OnRemoteOfferPopupClosedManual()
		{
		}

		public List<MiniOfferRemoteBase> GenerateMiniOffers()
		{
			return null;
		}

		public bool AreNewOffersReceived()
		{
			return false;
		}

		public void PurchaseOffer(RemoteOfferData FTMHSEPTHPR, string IQONSGKROOT, Action<bool> OELSIJKFHEH)
		{
		}

		public static void OnPurchaseCompleted(string RKJTFRTJSIR)
		{
		}

		public static void OnPurchaseFailed(string SMNOJKIKPIE)
		{
		}

		public static string GetDefaultPriceForPurchaseId(string RKJTFRTJSIR)
		{
			return null;
		}

		public static bool IsPurchaseIdCorrect(string RKJTFRTJSIR)
		{
			return false;
		}

		public bool IsOfferPurchased(RemoteOfferData FTMHSEPTHPR)
		{
			return false;
		}

		private void HTPMHSEONEH(RemoteOfferData FTMHSEPTHPR)
		{
		}

		public bool CanProcessOffer(RemoteOfferData FTMHSEPTHPR)
		{
			return false;
		}

		private static RemoteOfferData NOHJNHNQPIF(string MQNHOQLRLQO, Data TSRPFHOJKSG)
		{
			return null;
		}

		private static void OSMHGOOIROI(RemoteOfferData FTMHSEPTHPR, ref Data TSRPFHOJKSG)
		{
		}

		public static Task PerformReset(bool GQGGQKLPPHJ = false, bool EJMNPGNSIFJ = true)
		{
			return null;
		}

		public static Task PerformHardReset()
		{
			return null;
		}

		public static Task DevRequestAllOffers()
		{
			return null;
		}

		private static Task FOGRJTTTMSL()
		{
			return null;
		}

		public int GetActiveOfferCount()
		{
			return 0;
		}

		[CompilerGenerated]
		internal static List<RemoteOfferData> LMRSKKRPKKI(JArray QQQJREISRGJ)
		{
			return null;
		}

		[CompilerGenerated]
		private void OIIEOKRMONP(UIPopup OPTGJRKGKTO)
		{
		}
	}
}
