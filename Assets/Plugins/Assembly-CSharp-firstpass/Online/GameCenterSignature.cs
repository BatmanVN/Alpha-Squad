namespace Online
{
	public class GameCenterSignature
	{
		public delegate void OnSucceeded(string PublicKeyUrl, ulong timestamp, string signature, string salt, string playerID, string alias, string bundleID);

		public delegate void OnFailed(string Reason);

		public static void Generate(OnSucceeded OnSucceeded, OnFailed OnFailed)
		{
		}
	}
}
