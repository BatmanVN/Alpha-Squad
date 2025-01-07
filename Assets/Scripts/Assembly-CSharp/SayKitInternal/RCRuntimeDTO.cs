using System;

namespace SayKitInternal
{
	[Serializable]
	public class RCRuntimeDTO
	{
		public int timestamp;

		public int segment;

		public string country;

		public string ip;

		public int debug;

		public int debug_mediation;

		public string hash;

		public int status;

		public int gdpr_applicable;

		public int request_config_timeout;

		public int new_consent_ui_disabled;

		public int fps_tag_min_rate;

		public int fps_tag_min_spikes;

		public int fps_tag_enabled;

		public int disable_rc_v2;

		public int disable_imp_manager;

		public int disable_cv_manager;

		public int disable_fb_purchase_manager;

		public int disable_settings_ping_events;

		public int disable_firebase_ad_impression;

		public int fb_purchase_ads_revenue;

		public int fb_purchase_ads_revenue_session;

		public int fb_purchase_iap_revenue;

		public int firebase_ad_impression_full_data;

		public int vip_expire_at;

		public int device_power_manager_disabled;

		public int disable_new_interstitial_ads;

		public int ads_free_memory_check_enabled;

		public int ads_free_memory_count;

		public int disable_live_request;

		public int sk_performance_service_enabled;
	}
}
