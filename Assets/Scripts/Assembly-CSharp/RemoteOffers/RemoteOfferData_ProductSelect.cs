using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RemoteOffers
{
	[Serializable]
	public class RemoteOfferData_ProductSelect : RemoteOfferData
	{
		[Serializable]
		public class Intermediate
		{
			public List<LootIdentifier> loot;

			public string productId;

			public string discountValue;
		}

		public List<LootIdentifier> loot;

		public string productId;

		public string discountValue;

		[JsonProperty]
		protected bool purchased;

		[JsonProperty]
		protected List<LootElement> selectedLoot;

		public static RemoteOfferData_ProductSelect TMIPNERISPT(RemoteOfferConfiguration GJFPMSOEQTM, string FFJPETQOPQO)
		{
			return null;
		}

		public void FSFMLOSGORF(List<LootElement> QJPHEFMMFFG)
		{
		}

		public override bool FGJLGKMOITK(string IQONSGKROOT = null)
		{
			return false;
		}

		public override void SGGEQJHLSOT(string IQONSGKROOT)
		{
		}

		public bool LIKQRRLQMEM()
		{
			return false;
		}

		public string LKRMFNSGIMH()
		{
			return null;
		}

		public string NTNRFLNMGRI()
		{
			return null;
		}

		public string QNTENMKNOLP()
		{
			return null;
		}

		public override bool NQNJNLLGRPJ(string IQONSGKROOT)
		{
			return false;
		}

		public override LootList SJGEQPGLGQJ(string IQONSGKROOT)
		{
			return null;
		}

		public override void KPIGSOHMOQE(ref List<RemoteOfferDataSmall> TSRPFHOJKSG)
		{
		}

		public override bool NQNJNLLGRPJ(in RemoteOfferData FKQLEGQSLHF)
		{
			return false;
		}
	}
}
