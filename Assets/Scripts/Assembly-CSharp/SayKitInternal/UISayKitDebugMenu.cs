using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SayKitInternal
{
	public class UISayKitDebugMenu : MonoBehaviour
	{
		private static UISayKitDebugMenu _instance;

		private string _selectedVersion;

		public Text configText;

		public Text sayKitVersionText;

		public Text idfaText;

		public Text ipCountryText;

		public Text localTimeText;

		public Text appKeyText;

		public Text gdprText;

		public Text sayKitLoadTime;

		public Text skAdNetworkStatus;

		public Text thermalState;

		public Text rateApp;

		public Button closeButton;

		public Button closeAndReloadButton;

		public Text selectVersionTitleText;

		public Button rewardedOffBtn;

		public Button interstitialOffBtn;

		public Button bannerOffBtn;

		public GameObject versionScrollViewContent;

		public UISayKitVersionItem versionCardView;

		private List<UISayKitVersionItem> _versionCards;

		public Text minFPSRateText;

		public Text minFPSSpikesText;

		public Text fpsTagsText;

		public Button reloadConfigBtn;

		public Button openConfigsBtn;

		public Button closeConfigBtn;

		public GameObject goConfigsWindow;

		public Button medDebuggerBtn;

		public GameObject goAdsInfoWindow;

		public GameObject adInfoScrollViewContent;

		public UISayKitAdInfoItem adInfoCardView;

		private List<UISayKitAdInfoItem> _adInfoCards;

		public Button openAdsInfoBtn;

		public Button closeAdsInfoBtn;

		public GameObject toast;

		private long _lastThermalCheckTimestampMs;

		public static UISayKitDebugMenu GetInstance()
		{
			return null;
		}

		private void Update()
		{
		}

		public void ShowPopup()
		{
		}

		public void HidePopup()
		{
		}

		private void UpdateSelectedVersionInList()
		{
		}

		public void SelectNewConfigVersion(string version)
		{
		}

		public void ConfigUpdated(bool updated)
		{
		}

		private void OnCloseBtnClicked()
		{
		}

		private void OnCloseAndReloadBtnClicked()
		{
		}

		private void OnRewardedOffBtnClick()
		{
		}

		private void OnInterstitialOffBtnClick()
		{
		}

		private void OnBannerOffBtnClick()
		{
		}

		private void OnReloadConfigOffBtnClick()
		{
		}

		private void UpdateReloadConfigBtn()
		{
		}

		private void OpenAdsInfoWindow()
		{
		}

		private void OpenConfigsWindow()
		{
		}

		private void CloseConfigsWindow()
		{
		}

		private void CloseAdsInfoWindow()
		{
		}

		private void OpenMediationDebugger()
		{
		}
	}
}
