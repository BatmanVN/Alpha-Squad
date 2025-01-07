using System;
using System.Collections.Generic;

namespace SayKitInternal
{
	[Serializable]
	public class RemoteConfig
	{
		private class LocalizedMessage
		{
			public List<string> messages;

			public bool defaultValue;
		}

		public RCAdsPlaceDTO[] ads_places;

		public RCAdsGroupDTO[] ads_groups;

		public RCAdsSettingsDTO ads_settings;

		public RCLocalizedMessagesDTO[] game_messages;

		public RCRuntimeDTO runtime;

		public RCSettingsDTO settings;

		public SayKitGameConfig game_settings;

		public const string SAYKIT_UNITY_OVERRIDE_SYSTEM_LANGUAGES = "SAYKIT_UNITY_OVERRIDE_SYSTEM_LANGUAGES";

		private Dictionary<string, LocalizedMessage> localizedMessages;

		public RCAdsPlaceDTO findAdsPlace(string place)
		{
			return null;
		}

		public RCAdsGroupDTO findAdsGroup(string group)
		{
			return null;
		}

		public void InitLocalizations()
		{
		}

		public void SaveOverrideLanguage(LJLJQMNIHHP language)
		{
		}

		private int GetOverrideLanguage()
		{
			return 0;
		}

		public bool hasLocalizedMessage(string code)
		{
			return false;
		}

		public (string, bool) getLocalizedMessage(string code, string val1 = null, string val2 = null, string val3 = null, string val4 = null, string val5 = null)
		{
			return default((string, bool));
		}

		public void setupLocalization(LJLJQMNIHHP systemLanguage)
		{
		}

		public void UpdateAdsPlaces(RCAdsPlaceDTO[] newAdsPlaces)
		{
		}

		public void UpdateAdsGroups(RCAdsGroupDTO[] newAdsGroups)
		{
		}

		public void UpdateGameMessages(RCLocalizedMessagesDTO[] messages)
		{
		}

		public RemoteConfig DeepCopy()
		{
			return null;
		}
	}
}
