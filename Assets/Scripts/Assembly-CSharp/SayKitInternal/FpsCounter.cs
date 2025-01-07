using System.Collections;

namespace SayKitInternal
{
	public class FpsCounter
	{
		public static int FreeMemory;

		private static int lastFrames;

		private static float lastTime;

		private static int memoryCounter;

		private static bool _appWasPaused;

		private static int _appFrameRate;

		public static void Update()
		{
		}

		public static void ReportFps()
		{
		}

		public static IEnumerator ReportFpsRoutine()
		{
			return null;
		}

		public static void OnApplicationPause(bool pauseStatus)
		{
		}
	}
}
