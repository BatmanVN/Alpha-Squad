using System;

namespace SayKitInternal
{
	[Serializable]
	public class InAppRequestData
	{
		public string product_id;

		public string store_product_id;

		public string currency;

		public float price;

		public string transaction_id;

		public string json;

		public string signature;
	}
}
