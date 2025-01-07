using System;

namespace SayKitInternal
{
	public class LiveRequestManager
	{
		public static LiveRequestManager Instance { get; }

		public void RequestPayerPrediction(Action<LiveRequestPayerPrediction> onRequestResult)
		{
		}

		public void RequestLiveServer(string requestName, string requestData, Action<string> onRequestResult)
		{
		}
	}
}
