using System.Collections;

namespace SayKitInternal
{
	internal class RemoteConfigManager
	{
		public bool Initialized;

		private bool _shouldInitLocal;

		public RemoteConfig Config;

		public static RemoteConfigManager Instance { get; }

		private string GetUrl()
		{
			return null;
		}

		private static string GetCachePath()
		{
			return null;
		}

		public void InitializeLocalGameMessages(string appKey)
		{
		}

		public void InitializeLocalConfig(string appKey, string version)
		{
		}

		public IEnumerator RequestRemoteConfigUpdate()
		{
			return null;
		}

		private IEnumerator DownloadConfigV1()
		{
			return null;
		}

		public void ConfigInitialized(string data)
		{
		}
	}
}
