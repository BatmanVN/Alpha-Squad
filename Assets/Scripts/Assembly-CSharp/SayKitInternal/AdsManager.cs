using System;

namespace SayKitInternal
{
	internal class AdsManager
	{
		private const string ADS_PLACE_STATUS_OFF = "off";

		private Action _interstitialCallback;

		private Action<bool> _rewardedCallback;

		private int _lastInterstitialCheckTimestampMs;

		private int _lastRewardedCheckTimestampMs;

		private bool _hasInterstitialAd;

		private bool _hasRewardedAd;

		public static AdsManager Instance { get; }

		public void ShowBanner()
		{
		}

		public void HideBanner()
		{
		}

		public bool IsInterstitialAvailable(string place, int countdown = 0)
		{
			return false;
		}

		public bool ShowInterstitial(string place, Action onCloseCallback, bool showPopup, int countdown)
		{
			return false;
		}

		public bool ShowInterstitialWithResult(string place)
		{
			return false;
		}

		public bool IsRewardedAvailable(string place)
		{
			return false;
		}

		public bool IsRewardedPlacementAvailable(string place)
		{
			return false;
		}

		public void ShowRewarded(string place, Action<bool> onCloseCallback)
		{
		}

		private bool IsPlaceStatusOff(string place, bool isRewarded)
		{
			return false;
		}

		private bool IsInterstitialPlaceWithPopup(string place, bool showPopup)
		{
			return false;
		}

		public bool IsInterstitialWithCustomPopup(string place)
		{
			return false;
		}

		private EInterstitialPopupType GetPopupType(string place)
		{
			return default(EInterstitialPopupType);
		}

		internal void OnInterstitialClosed()
		{
		}

		internal void OnRewardedClosed(bool rewarded)
		{
		}
	}
}
