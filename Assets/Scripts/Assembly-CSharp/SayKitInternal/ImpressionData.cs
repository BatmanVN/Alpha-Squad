using System;
using System.Collections.Generic;

namespace SayKitInternal
{
	[Serializable]
	public class ImpressionData
	{
		public int FirstStartTimestamp;

		public List<ImpressionObject> Data;

		public List<string> AnalyzedEvents;
	}
}
