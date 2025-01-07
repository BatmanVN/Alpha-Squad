namespace SayKitInternal
{
	public class SayKitDebug
	{
		private static bool _debugFlag;

		private static LogLevel _logLevel;

		public static bool disableSayKitLogs;

		private const string LogTag = "[SayKit Unity]: ";

		private const string LogTagError = "[SayKit Unity][Error]: ";

		public static void InitDebugLogs(bool debugFlag)
		{
		}

		public static void Log(string logMessage)
		{
		}

		public static void LogError(string logMessage)
		{
		}

		public static void LogFormat(string format, params object[] args)
		{
		}

		private static void LogMessage(string message)
		{
		}
	}
}
