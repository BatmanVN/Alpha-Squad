namespace SayKitInternal
{
	public interface ISayKitBridgeCallbacks
	{
		void OnAdShown(string type, string time, string network, string creativeId);

		void OnAdRevenuePaid(string type, string adRevenueInfo);

		void OnAdDisplayed(string type, string adInfo);

		void OnInAppProductChecked(string json);

		void OnInitStateChanged(int number, float progress);

		void OnNotificationTokenReceived(string token);

		void OnRemoteConfigUpdated(string path);

		void OnInterstitialClosed();

		void OnRewardedClosed(bool rewarded);

		void OnSayCatalogueShown(string placement);
	}
}
