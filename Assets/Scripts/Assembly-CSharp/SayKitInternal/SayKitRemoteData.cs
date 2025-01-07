using System;
using System.Collections.Generic;

namespace SayKitInternal
{
	[Serializable]
	public class SayKitRemoteData
	{
		public int Version;

		public string Error;

		public string Platform;

		public List<SayKitRemoteConfiguration> Configuration;
	}
}
