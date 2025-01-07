using System;
using System.Collections.Generic;

namespace SayKitInternal
{
	[Serializable]
	internal class StorageData
	{
		public string idfv;

		public bool consetWasGranted;

		public bool rateAppPopupWasShowed;

		public LJLJQMNIHHP overriddenSystemLanguage;

		public Dictionary<string, int> adsGroupPeriodEnds;

		public Dictionary<string, int> adsGroupPeriodImpressions;

		public bool isPremium;
	}
}
