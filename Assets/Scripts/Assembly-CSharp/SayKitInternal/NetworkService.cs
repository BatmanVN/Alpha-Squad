using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace SayKitInternal
{
	public class NetworkService
	{
		public static NetworkReachability InternetReachability { get; set; }

		public static int GetInternetReachabilityState()
		{
			return 0;
		}

		public static Task PatchAsync(string url, string username, string password, Action<string, string> responseCallback = null)
		{
			return null;
		}

		public static Task PostWithHeaders(string url, int timeout, string json, Action<string, string> responseCallback)
		{
			return null;
		}

		public static Task Post(string url, int timeout, Dictionary<string, string> form, Action<int, string> responseCallback)
		{
			return null;
		}

		public static Task Post(string url, int timeout, string json, Action<string, string> responseCallback)
		{
			return null;
		}

		public static Task GetAsString(string url, int timeout, Action<string, string> responseCallback)
		{
			return null;
		}

		public static Task GetAsByteArray(string url, int timeout, Action<byte[], string> responseCallback)
		{
			return null;
		}
	}
}
