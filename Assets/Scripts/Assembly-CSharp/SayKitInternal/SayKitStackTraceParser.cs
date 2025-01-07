using System;
using System.Collections.Generic;

namespace SayKitInternal
{
	public static class SayKitStackTraceParser
	{
		private const string FrameArgsRegex = "\\s?\\(.*\\)";

		private const string FrameRegexWithoutFileInfo = "(?<class>[^\\s]+)\\.(?<method>[^\\s\\.]+)\\s?\\(.*\\)";

		private const string FrameRegexWithFileInfo = "(?<class>[^\\s]+)\\.(?<method>[^\\s\\.]+)\\s?\\(.*\\) .*[/|\\\\](?<file>.+):(?<line>\\d+)";

		private const string MonoFilenameUnknownString = "<filename unknown>";

		private static readonly string[] StringDelimiters;

		public static string ParseStackTraceString(Exception exception)
		{
			return null;
		}

		private static IEnumerable<Dictionary<string, string>> ParseStackTrace(string stackTrace)
		{
			return null;
		}

		private static bool ParseFrame(string stackTraceLine, out Dictionary<string, string> frameData)
		{
			frameData = null;
			return false;
		}

		private static void HandleError(Exception e)
		{
		}
	}
}
