using System;

namespace SayKitInternal
{
	[Serializable]
	public class InAppResponseData
	{
		public bool success;

		public bool seen_before;

		public string message;

		public string adjust_iap_token;
	}
}
