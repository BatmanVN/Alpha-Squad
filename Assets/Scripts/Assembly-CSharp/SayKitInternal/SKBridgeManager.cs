using System;

namespace SayKitInternal
{
	public class SKBridgeManager
	{
		public static SKBridgeManager Instance { get; }

		public bool IsInitialized()
		{
			return false;
		}

		public float GetInitStateProgress()
		{
			return 0f;
		}

		public int GetInitStateNumber()
		{
			return 0;
		}

		public void InitIfNeeded(string configJson, string environmentParams)
		{
		}

		public float GetBackgroundBannerSize()
		{
			return 0f;
		}

		public void HideBanner()
		{
		}

		public void ShowBanner()
		{
		}

		public bool IsInterstitialWithCustomPopup(string place)
		{
			return false;
		}

		public bool IsRewardedPlacementAvailable(string place)
		{
			return false;
		}

		public bool IsInterstitialAvailable(string place, int countdown)
		{
			return false;
		}

		public bool ShowInterstitial(string place, int countdown)
		{
			return false;
		}

		public bool ShowInterstitialWithPopup(string place, int countdown)
		{
			return false;
		}

		public bool IsRewardedAvailable(string place)
		{
			return false;
		}

		public bool ShowRewarded(string place)
		{
			return false;
		}

		public void TrackInterstitialOffer(string place, string extra)
		{
		}

		public void TrackRewardedOffer(string place, string extra)
		{
		}

		public int GetSubscriptionExpirationTimestamp()
		{
			return 0;
		}

		public bool IsAppStoreAvailable()
		{
			return false;
		}

		public string GetPrivacyPolicyLink()
		{
			return null;
		}

		public bool IsAppInstalled(string packageName)
		{
			return false;
		}

		public void OpenGooglePlaySubscriptionCenter(string productId)
		{
		}

		public void OpenStoreProductView(int storeId, string skadData, string storeUrl)
		{
		}

		public string OpenSupportPage(string extra)
		{
			return null;
		}

		public bool IsFacebookSdkInitialized()
		{
			return false;
		}

		public void LogFacebookEvent(string name, float valueToSum, string paramsJson)
		{
		}

		public void LogFirebaseEvent(string name, float valueToSum, string paramsJson)
		{
		}

		public void SetFirebaseUserProperty(string key, string value)
		{
		}

		public void LogCrashlytics(string message)
		{
		}

		public void LogCrashlyticsException(Exception exception)
		{
		}

		public void SetCrashlyticsParam(string key, string value)
		{
		}

		public void TrackApplicationLoaded()
		{
		}

		public void TrackAvailableMemory()
		{
		}

		public void TrackEvent(string name, int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0, string extra1 = "", string extra2 = "", string tag = "")
		{
		}

		public void TrackLevelStarted(int level, int score, int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackLevelCompleted(int level, int score, int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackLevelFailed(int level, int score, int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackLevelExtraStarted(int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackLevelExtraCompleted(int score, int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackLevelExtraFailed(int score, int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackLevelStageStarted(int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackLevelStageCompleted(int score, int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackLevelStageFailed(int score, int number, string extra1, string extra2, string tag)
		{
		}

		public void TrackChunkStarted(string name, int number, string paramsJson)
		{
		}

		public void TrackChunkCompleted(string paramsJson)
		{
		}

		public void TrackChunkFailed(string paramsJson)
		{
		}

		public void TrackTutorialCompleted()
		{
		}

		public void TrackTutorialStep(string name, string step)
		{
		}

		public void TrackItem(string name, int ownedItems, int sourceType, string paramsJson)
		{
		}

		public void TrackItemLoss(string name, int ownedItems, int sourceType, string paramsJson)
		{
		}

		public void TrackClick(string screen, string element)
		{
		}

		public void TrackScreen(string screen)
		{
		}

		public void TrackHardIncome(int amount, int total, string place, string extra)
		{
		}

		public void TrackHardOutcome(int amount, int total, string place, string extra)
		{
		}

		public void TrackSoftIncome(int amount, int total, string place, string extra)
		{
		}

		public void TrackSoftOutcome(int amount, int total, string place, string extra)
		{
		}

		public void CheckInAppProduct(string json)
		{
		}

		public int GetRequestConfigTimestamp()
		{
			return 0;
		}

		public void RequestConfigMigration(string sourceVersion)
		{
		}

		public bool RequestRemoteConfigUpdate()
		{
			return false;
		}

		public bool ShowCustomRateAppPopup(int rate)
		{
			return false;
		}

		public bool ShowRateAppPopup()
		{
			return false;
		}

		public bool IsPremium()
		{
			return false;
		}

		public void DisablePremium()
		{
		}

		public void EnablePremium()
		{
		}

		public bool GetGdprStatus()
		{
			return false;
		}

		public bool IsGdprApplicable()
		{
			return false;
		}

		public void RevokeGdprConsent()
		{
		}

		public string GetNotificationToken()
		{
			return null;
		}

		public void RequestNotificationToken()
		{
		}

		public string GetLocalizedString(string key, string val1, string val2, string val3, string val4, string val5)
		{
			return null;
		}

		public string GetLocalizedTuple(string key, string val1, string val2, string val3, string val4, string val5)
		{
			return null;
		}

		public bool HasLocalizedMessage(string key)
		{
			return false;
		}

		public int GetCurrentLanguage()
		{
			return 0;
		}

		public string GetSystemLanguage()
		{
			return null;
		}

		public void OverrideSystemLanguage(int language)
		{
		}

		public int GetFreeMemory()
		{
			return 0;
		}

		public int GetTotalMemory()
		{
			return 0;
		}

		public string GetRuntimeInfo()
		{
			return null;
		}

		public string GetAdvertisingId()
		{
			return null;
		}

		public string GetAppVersion()
		{
			return null;
		}

		public string GetDeviceId()
		{
			return null;
		}

		public string GetDeviceModel()
		{
			return null;
		}

		public string GetDeviceOs()
		{
			return null;
		}

		public string GetLanguage()
		{
			return null;
		}

		public int GetAppVersionCode()
		{
			return 0;
		}

		public string GetAppVersionFullName()
		{
			return null;
		}

		public string GetAppVersionOriginalName()
		{
			return null;
		}

		public int GetSdkVersionCode()
		{
			return 0;
		}

		public string GetSdkVersionName()
		{
			return null;
		}

		public string GetThermalState()
		{
			return null;
		}

		public void ChangeLanguage(int language)
		{
		}

		public void DisableLogs()
		{
		}

		public void OverrideTrackLevel(int level)
		{
		}

		public void ShowMaxMediationDebug()
		{
		}

		public bool GetRateAppShown()
		{
			return false;
		}

		public string GetATTStatus()
		{
			return null;
		}

		public void SetSayKitBridgeCallbacks(ISayKitBridgeCallbacks listener)
		{
		}

		public void ShowSayCatalogue(string placement, string catalogParams = "")
		{
		}

		public void TrackSayCatalogueOffer(string sourceType)
		{
		}

		public void TrackInAppOffer(string place, string extra)
		{
		}

		public void SetPlayerId(string playerId)
		{
		}

		public void OpenSystemSettings()
		{
		}

		public int GetPlayingTime()
		{
			return 0;
		}

		public void RequestLiveServer(string requestName, string requestData, Action<string> onRequestResult)
		{
		}

		public void SetExperimentDeviceId(string deviceId)
		{
		}

		public string GetSessionId()
		{
			return null;
		}
	}
}
