using System.Collections.Generic;

namespace SayKitInternal
{
	public static class SKPerformanceTrackerService
	{
		private class SegmentSampler
		{
			public string Tag;

			private int[] fpsBins;

			public void Start()
			{
			}

			private void Reset()
			{
			}

			public void Update(float currentFps)
			{
			}

			public int[] GetFpsHistogram()
			{
				return null;
			}
		}

		private static readonly float _histogramStep;

		private const int HistogramColumns = 12;

		private static Dictionary<string, SegmentSampler> _dictSamplers;

		public static void Start(string name, string tag)
		{
		}

		public static void Update()
		{
		}

		public static void End(string name, string endTag)
		{
		}

		private static void SendEvent(FpsTrackerData data, string extra)
		{
		}
	}
}
