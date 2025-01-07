using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RemoteOffers
{
	[Serializable]
	public class RemoteOfferData_ProductMultiple : RemoteOfferData
	{
		[Serializable]
		public struct OfferData
		{
			public int count;

			public List<LootElement> loot;
		}

		[Serializable]
		public struct OfferDataIntermediate
		{
			public int count;

			public List<LootIdentifier> loot;
		}

		[Serializable]
		public class Intermediate
		{
			public List<OfferDataIntermediate> loot;

			public string productId;

			public string discountValue;
		}

		public List<OfferData> loot;

		public string[] productId;

		public string[] discountValue;

		[JsonProperty]
		private List<string> purchasedIds;

		public static RemoteOfferData_ProductMultiple TMIPNERISPT(RemoteOfferConfiguration GJFPMSOEQTM, string FFJPETQOPQO)
		{
			return null;
		}

		public override void SGGEQJHLSOT(string IQONSGKROOT)
		{
		}

		public override bool FGJLGKMOITK(string IQONSGKROOT = null)
		{
			return false;
		}

		public int QROFNKFKRFM(int PSPJIJNTMOI)
		{
			return 0;
		}

		public int EQMRMRFEHKH(string IQONSGKROOT)
		{
			return 0;
		}

		public int FSIRRHSQGSM(int PSPJIJNTMOI)
		{
			return 0;
		}

		public int JKENEHSTGFM(string IQONSGKROOT)
		{
			return 0;
		}

		public int EMGLORNKJKR()
		{
			return 0;
		}

		public bool GRFHLNJMNPP(int PSPJIJNTMOI)
		{
			return false;
		}

		public string KFEHGSQNSFT(int PSPJIJNTMOI)
		{
			return null;
		}

		public string QTENHLLFIPL(int PSPJIJNTMOI)
		{
			return null;
		}

		public List<LootElement> LHFEEOHIKSO(int PSPJIJNTMOI)
		{
			return null;
		}

		public override bool NQNJNLLGRPJ(string IQONSGKROOT)
		{
			return false;
		}

		public bool LIKQRRLQMEM(int PSPJIJNTMOI)
		{
			return false;
		}

		public string LKRMFNSGIMH(int PSPJIJNTMOI)
		{
			return null;
		}

		public string NTNRFLNMGRI(int PSPJIJNTMOI)
		{
			return null;
		}

		public string QNTENMKNOLP(int PSPJIJNTMOI)
		{
			return null;
		}

		public override LootList SJGEQPGLGQJ(string IQONSGKROOT)
		{
			return null;
		}

		public override void KPIGSOHMOQE(ref List<RemoteOfferDataSmall> TSRPFHOJKSG)
		{
		}
	}
}
