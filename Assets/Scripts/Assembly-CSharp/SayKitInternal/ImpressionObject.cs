using System;

namespace SayKitInternal
{
	[Serializable]
	public class ImpressionObject
	{
		public string Type;

		public int Timestamp;

		public float CPM;

		public ImpressionObject(string type, int timestamp)
		{
		}
	}
}
