using System;

namespace RemoteOffers
{
	[Serializable]
	public class RemoteOfferConfiguration
	{
		public RFQKSENFITG offerType;

		public int start;

		public int duration;

		public string id;

		public string uniqueId;

		public int version;

		public string extra;

		public RemoteOfferConfigurationCustomData customData;

		public int priority;
	}
}
