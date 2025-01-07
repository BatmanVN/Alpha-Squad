namespace SayKitInternal
{
	public class TagItem
	{
		public string Name;

		public int Timestapm;

		public int Spikes;

		public int Seconds;

		public bool IsTimeTag;

		public string Extra;

		public TagItem(string name, int timestamp, string extra, int seconds = 0, bool isTimetag = false)
		{
		}
	}
}
