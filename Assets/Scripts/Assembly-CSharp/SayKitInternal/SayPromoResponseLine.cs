using System;

namespace SayKitInternal
{
	[Serializable]
	internal class SayPromoResponseLine
	{
		public string external_id;

		public string app_title;

		public string app_store_id;

		public string app_scheme;

		public string click_url;

		public string impression_url;

		public string result_url;

		public string creative_text;

		public string creative_button;

		public string creative_type;

		public string creative_url;

		public bool _wasLoaded;

		public bool _wasInstalled;

		private string _localName;

		public bool hasCatalog;

		public string catalogParams;

		public string GetLocalName()
		{
			return null;
		}

		public bool IsReady()
		{
			return false;
		}
	}
}
