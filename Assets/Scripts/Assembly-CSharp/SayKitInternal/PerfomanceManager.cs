using System.Collections;
using System.Collections.Generic;

namespace SayKitInternal
{
	public class PerfomanceManager
	{
		private static int _enabled;

		public static float MinFPSRate;

		public static int MinSpikes;

		private static float _deltaTime;

		private static int _screenSpikes;

		private static int _screenTimestamp;

		private static string _screenName;

		private static int _appFrameRate;

		private static List<TagItem> _tagList;

		public static List<string> LastTrackedTags;

		private static string _lastTrackedFPS;

		public static string GameContext;

		private static void UpdateParameters(int minFPSRate, int minSpikes)
		{
		}

		public static void Update()
		{
		}

		public static IEnumerator StartFPSRoutine(int enabled, int minFPSRate, int minSpikes)
		{
			return null;
		}

		public static string GetLastFPS()
		{
			return null;
		}

		private static void SaveFPS(int fps)
		{
		}

		public static void UpdateScreen(string screenName)
		{
		}

		public static void StartTag(string tagName, string extra)
		{
		}

		public static void EndTag(string tagName)
		{
		}

		private static void SaveNewTag(string tagName, TagItem tag, int duration)
		{
		}

		public static void StartTimeTag(string tagName, int seconds, string extra)
		{
		}

		private static void CheckTimeTags()
		{
		}

		private static void UpdateSpikes()
		{
		}
	}
}
