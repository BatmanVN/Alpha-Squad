namespace SayKitInternal
{
	public class SayKitWebRequest
	{
		private const string _defaultText = "";

		public string Url { get; }

		public string Text { get; private set; }

		public string ErrorMessage { get; private set; }

		public bool IsDone { get; private set; }

		public SayKitWebRequest(string url)
		{
		}

		public bool SendAndWait(float timeout = -1f)
		{
			return false;
		}
	}
}
