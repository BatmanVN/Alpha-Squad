using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;

namespace SayKitInternal
{
	public class SKManager
	{
		public int Version;

		private static SKManager _instance;

		public LJLJQMNIHHP CurrentLanguage;

		public int InitCount;

		private EInitState _initState;

		public static SKManager Instance => null;

		public HINLTFJIHHT Config { get; private set; }

		public RemoteConfig RemoteConfig => null;

		public RuntimeInfo RuntimeInfo => null;

		public SayKitGameConfig GameConfig => null;

		public string BuildVersion => null;

		public bool IsInitialized => false;

		public float InitializedProgress { get; private set; }

		public bool IsPremium => false;

		public EInitState GetInitState()
		{
			return default(EInitState);
		}

		internal void UpdateInitState(int number, float progress)
		{
		}

		public void Initialize(HINLTFJIHHT sayKitConfig)
		{
		}

		private void OnSayKitInitialized()
		{
		}

		public void EnablePremium()
		{
		}

		public void DisablePremium()
		{
		}

		public void ShowBanner(bool isExternalCall = false)
		{
		}

		public void HideBanner(bool isExternalCall = false)
		{
		}

		public float GetBackgroundBannerSize()
		{
			return 0f;
		}

		public bool IsInterstitialAvailable(string place, int countdown = 0)
		{
			return false;
		}

		public bool IsInterstitialWithCustomPopup(string place)
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

		public bool ShowInterstitial(string place, bool showPopup, int countdown = 0, Action onCloseCallback = null)
		{
			return false;
		}

		public void ShowRewarded(string place, Action<bool> onCloseCallback)
		{
		}

		public void TrackInterstitialOffer(string place, string extra)
		{
		}

		public void TrackRewardedOffer(string place, string extra)
		{
		}

		public bool IsFacebookSDKInitialized()
		{
			return false;
		}

		public void LogFacebookEvent(string logEvent, float valueToSum, Dictionary<string, object> parameters = null)
		{
		}

		public void LogFirebaseEvent(string eventName, string paramName, object paramValue)
		{
		}

		public void LogFirebaseEvent(string eventName, float valueToSum, Dictionary<string, object> parameters = null)
		{
		}

		public void LogFirebaseEvent(string eventName, string extraParam = "")
		{
		}

		public void SetCrashlyticsParam(string paramName, string paramValue)
		{
		}

		public void LogCrashlyticsException(Exception exception)
		{
		}

		public void LogCrashlytics(string message)
		{
		}

		public void SetFirebaseUserProperty(string key, string value = "")
		{
		}

		public void TrackLevelStarted(int level)
		{
		}

		public void TrackLevelStarted(string tag, int level, int score = 0, string extra1 = "", int number = 0, string extra2 = "")
		{
		}

		public void TrackLevelCompleted(int level, int score)
		{
		}

		public void TrackLevelCompleted(string tag, int level, int score, string extra1 = "", int number = 0, string extra2 = "")
		{
		}

		public void TrackLevelFailed(int level, int score)
		{
		}

		public void TrackLevelFailed(string tag, int level, int score, string extra1 = "", int number = 0, string extra2 = "")
		{
		}

		public void TrackLevelExtraStarted(string tag, string extra1)
		{
		}

		public void TrackLevelExtraStarted(string tag = "", int number = 0, string extra1 = "", string extra2 = "")
		{
		}

		public void TrackLevelExtraCompleted(int score)
		{
		}

		public void TrackLevelExtraCompleted(string tag, int score, string extra1)
		{
		}

		public void TrackLevelExtraCompleted(string tag = "", int score = 0, int number = 0, string extra1 = "", string extra2 = "")
		{
		}

		public void TrackLevelExtraFailed(int score)
		{
		}

		public void TrackLevelExtraFailed(string tag, int score, string extra1 = "")
		{
		}

		public void TrackLevelExtraFailed(string tag, int score, int number, string extra1, string extra2)
		{
		}

		public void TrackLevelStageStarted(int number)
		{
		}

		public void TrackLevelStageStarted(string tag, int number, string extra1 = "", string extra2 = "")
		{
		}

		public void TrackLevelStageCompleted(int number, int score)
		{
		}

		public void TrackLevelStageCompleted(string tag, int number, int score)
		{
		}

		public void TrackLevelStageCompleted(string tag, int number, int score, string extra1, string extra2)
		{
		}

		public void TrackLevelStageFailed(int number, int score)
		{
		}

		public void TrackLevelStageFailed(string tag, int number, int score)
		{
		}

		public void TrackLevelStageFailed(string tag, int number, int score, string extra1, string extra2)
		{
		}

		public void TrackChunkStarted(string name, int sequenceNumber, Dictionary<string, object> customData = null)
		{
		}

		public void TrackChunkCompleted(Dictionary<string, object> customData = null)
		{
		}

		public void TrackChunkFailed(Dictionary<string, object> customData = null)
		{
		}

		public void TrackTutorialCompleted()
		{
		}

		public void TrackTutorialStep(string tutorialName, string stepName)
		{
		}

		public void TrackEvent(string eventName, int eventParam1 = 0, int eventParam2 = 0, string eventParam = "")
		{
		}

		public void TrackEvent(string eventName, int eventParam1, string eventParam2)
		{
		}

		public void TrackEvent(string eventName, int eventParam1, int eventParam2, int eventParam3, string eventParam = "")
		{
		}

		public void TrackEvent(string eventName, string eventParam, string eventParam2 = "")
		{
		}

		public void TrackEvent(string eventName, int eventParam1, string eventParam2, string eventParam3)
		{
		}

		public void TrackEvent(string eventName, int eventParam1, int eventParam2, string eventParam3, string eventParam4)
		{
		}

		public void TrackTagEvent(string eventName, string tag, int eventParam1, int eventParam2, string eventParam3, string eventParam4)
		{
		}

		public void TrackTagEvent(string eventName, string tag, int eventParam1, int eventParam2, int eventParam3, string eventParam4, string eventParam5)
		{
		}

		public void TrackTagEvent(string eventName, string tag, int eventParam1, int eventParam2, int eventParam3, int eventParam4, string eventParam5, string eventParam6)
		{
		}

		public void TrackItem(string item)
		{
		}

		public void TrackItem(string item, int ownedItems, SourceType sourceId, Dictionary<string, object> customData)
		{
		}

		public void TrackItem(string item, int ownedItems, string customData, SourceType sourceId)
		{
		}

		public void TrackItemLoss(string item, int ownedItems, SourceType sourceId, Dictionary<string, object> customData)
		{
		}

		public void TrackItemLoss(string item, int ownedItems, string customData, SourceType sourceId)
		{
		}

		public void TrackScreen(string screen)
		{
		}

		public void TrackClick(string screen, string element)
		{
		}

		public void TrackSoftIncome(int amount, int total, string place = "", string extra = "")
		{
		}

		public void TrackSoftOutcome(int amount, int total, string place = "", string extra = "")
		{
		}

		public void TrackHardIncome(int amount, int total, string place = "", string extra = "")
		{
		}

		public void TrackHardOutcome(int amount, int total, string place = "", string extra = "")
		{
		}

		public void TrackApplicationLoaded()
		{
		}

		public void TrackEventWithoutInit(string eventName, string eventParamString)
		{
		}

		public void TrackPurchase(PurchaseEventArgs purchaseEventArgs, Action<InAppProduct> validationCallback, string offer = null, string placement = null)
		{
		}

		public void TrackPurchase(Product purchasedProduct, Action<InAppProduct> validationCallback, string offer = null, string placement = null)
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

		public int GetRequestConfigTimestamp()
		{
			return 0;
		}

		public string OpenSupportPage(string extra)
		{
			return null;
		}

		public string GetPrivacyPolicyLink()
		{
			return null;
		}

		public bool ShowRateAppPopup()
		{
			return false;
		}

		public bool ShowCustomRateAppPopup(int rate)
		{
			return false;
		}

		public bool IsRateAppPopupShown()
		{
			return false;
		}

		public void RevokeGdprConsent()
		{
		}

		public bool IsGdprApplicable()
		{
			return false;
		}

		public bool GetGdprStatus()
		{
			return false;
		}

		public void RequestNotificationToken()
		{
		}

		public string GetNotificationToken()
		{
			return null;
		}

		public string GetLocalizedString(string key, string val1 = null, string val2 = null, string val3 = null, string val4 = null, string val5 = null)
		{
			return null;
		}

		public (string, bool) GetLocalizedTuple(string key, string val1 = null, string val2 = null, string val3 = null, string val4 = null, string val5 = null)
		{
			return default((string, bool));
		}

		public bool HasLocalizedMessage(string key)
		{
			return false;
		}

		public LJLJQMNIHHP GetCurrentLanguage()
		{
			return default(LJLJQMNIHHP);
		}

		public void StartFPSTag(string tagName)
		{
		}

		public void EndFPSTag(string tagName)
		{
		}

		public void StartTimeFPSTag(string tagName, int seconds)
		{
		}

		public void ChangeLanguage(LJLJQMNIHHP language)
		{
		}

		public void OverrideSystemLanguage(LJLJQMNIHHP language)
		{
		}

		public void OverrideTrackLevel(int level)
		{
		}

		public void RequestConfigMigration(string sourceVersion)
		{
		}

		public bool RequestRemoteConfigUpdate()
		{
			return false;
		}

		public void OpenGooglePlaySubscriptionCenter(string productId)
		{
		}

		public int GetTotalMemory()
		{
			return 0;
		}

		public int GetFreeMemory()
		{
			return 0;
		}

		public void SetFPSGameContext(string data)
		{
		}

		public void DisableSayKitLogs()
		{
		}

		public void SetUnityExceptionContext(string data)
		{
		}

		public void TrackInAppOffer(string place, string extra)
		{
		}

		public void ShowMaxMediationDebug()
		{
		}

		public bool IsDebugUser()
		{
			return false;
		}

		public void SetPlayerId(string playerId)
		{
		}

		public int GetPlayingTime()
		{
			return 0;
		}

		public void RequestLiveServer(string requestName, string requestData, Action<string> onRequestResult)
		{
		}

		public void RequestPayerPrediction(Action<LiveRequestPayerPrediction> onRequestResult)
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
