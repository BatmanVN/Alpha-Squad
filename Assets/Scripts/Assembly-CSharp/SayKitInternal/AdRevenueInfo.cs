using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace SayKitInternal
{
	public class AdRevenueInfo
	{
		[JsonProperty]
		public string ID;

		[JsonProperty]
		public string SubID;

		[JsonProperty]
		public double Amount;

		[JsonConstructor]
		[Preserve]
		public AdRevenueInfo()
		{
		}
	}
}
