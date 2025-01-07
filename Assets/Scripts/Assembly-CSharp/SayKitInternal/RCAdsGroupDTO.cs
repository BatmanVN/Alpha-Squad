using System;

namespace SayKitInternal
{
	[Serializable]
	public class RCAdsGroupDTO
	{
		public string group;

		public int skip_after_start;

		public int skip_after_first_app_start;

		public int skip_after_interstitial;

		public int skip_after_rewarded;

		public int skip_period_duration;

		public int skip_period_limit;

		public int force_impression_every;

		public int show_popup;

		public RCAdsGroupDTO Clone()
		{
			return null;
		}
	}
}
