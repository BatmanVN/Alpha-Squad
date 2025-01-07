using System;

namespace SayKitInternal
{
	[Serializable]
	public class RCAdsSettingsDTO
	{
		public string banner_placement;

		public string interstitial_placement;

		public string rewarded_placement;

		public string bidding_interstitial_placement;

		public string bidding_rewarded_placement;

		public int watchdog_interstitial;

		public int watchdog_rewarded;

		public int banner_disabled;

		public string banner_bg_color;

		public int banner_bg_padding;

		public string ping_events;

		public int bidding_enabled;

		public int bidding_fb_enabled;

		public string bidding_fb_app;

		public string bidding_fb_interstitial;

		public string bidding_fb_rewarded;

		public int bidding_al_enabled;

		public int bidding_sp_enabled;

		public int track_waterfall;

		public int saymed_enabled;

		public string saymed_banner_id;

		public string saymed_interstitial_id;

		public string saymed_rewarded_id;

		public int maxsdk_enabled;

		public string maxsdk_key;

		public string maxsdk_banner_id;

		public string maxsdk_interstitial_id;

		public string maxsdk_rewarded_id;

		public string disabled_networks;

		public int amazon_aps_enabled;

		public string amazon_aps_app_id;

		public string amazon_aps_banner_slot_id;

		public string amazon_aps_banner_leader_slot_id;

		public string amazon_aps_inter_slot_id;

		public string amazon_aps_rewarded_slot_id;

		public int interstitial_timeout;

		public int interstitial_timeout_hidden;

		public int interstitial_noads_hidden;

		public int interstitial_autoshow_disabled;
	}
}
