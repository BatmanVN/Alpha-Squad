using System.Collections;
using System.Collections.Generic;
using SayKitInternal.Models.DTO;
using UnityEngine;

namespace SayKitInternal
{
	public class DebugService
	{
		public static string UnityExceptionContext;

		private int _lastExceptionEventTimestamp;

		public bool RewardedDisabled;

		public bool InterstitialDisabled;

		public bool BannerDisabled;

		public bool ReloadConfigEnabled;

		private Gyroscope _gyroscope;

		private long _lastGyroscopeCheckTimestampMs;

		private Quaternion _prevGyroscopeAttitude;

		private bool _gyroscopeRotateMistake;

		private int _gyroscopeRotateCount;

		public List<SayKitVersionDTO> VersionList;

		private string _selectedDebugVersion;

		private bool _manualRequestCall;

		private readonly int _requestTimeout;

		public long startInitTimeStamp;

		public readonly SayKitAdsInfoBuffer<SayKitAdInfo> SayKitAdsInfoBuffer;

		public static DebugService Instance { get; }

		public void InitDebugService()
		{
		}

		public void Update()
		{
		}

		private void UpdateGyroData()
		{
		}

		public void ChangeConfigVersion(string version)
		{
		}

		private string GetVersion()
		{
			return null;
		}

		public IEnumerator ReloadRemoteConfig()
		{
			return null;
		}

		public IEnumerator DownloadVersionList()
		{
			return null;
		}

		private IEnumerator CheckConfigVersion()
		{
			return null;
		}

		private IEnumerator RemoteConfigInitRoutine()
		{
			return null;
		}

		public void LogExceptionCallback(string condition, string stackTrace, LogType type)
		{
		}

		private void LogExceptionCallbackBase(string condition, string stackTrace, LogType type, string extra = "")
		{
		}

		private string TrimExtraString(string extra)
		{
			return null;
		}

		public void AddAdInfo(string adTime, string adType, string adNetwork, string creativeId)
		{
		}
	}
}
