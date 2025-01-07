using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace SayKitInternal
{
	public class AdInfo
	{
		[JsonProperty]
		public string MaxAdUnit;

		[JsonProperty]
		public string NetworkName;

		[JsonProperty]
		public string MaxCreativeId;

		[JsonProperty]
		public double Cpm;

		[JsonConstructor]
		[Preserve]
		public AdInfo()
		{
		}
	}
}
