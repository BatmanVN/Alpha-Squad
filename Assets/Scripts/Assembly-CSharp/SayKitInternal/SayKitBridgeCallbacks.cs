namespace SayKitInternal
{
	public class SayKitBridgeCallbacks : ISayKitBridgeCallbacks
	{
		public static SayKitBridgeCallbacks Instance { get; }

		public void Initialize()
		{
		}

		private void SetSayKitBridgeCallbacks(ISayKitBridgeCallbacks listener)
		{
		}

		public void OnAdShown(string type, string time, string network, string creativeId)
		{
		}

		public void OnAdRevenuePaid(string type, string adRevenueInfo)
		{
		}

		public void OnAdDisplayed(string type, string adInfo)
		{
		}

		public void OnInAppProductChecked(string json)
		{
		}

		public void OnInitStateChanged(int number, float progress)
		{
		}

		public void OnNotificationTokenReceived(string token)
		{
		}

		public void OnRemoteConfigUpdated(string path)
		{
		}

		public void OnInterstitialClosed()
		{
		}

		public void OnRewardedClosed(bool rewarded)
		{
		}

		public void OnSayCatalogueShown(string placement)
		{
		}
	}
}
