using System.Security.Cryptography;

namespace Sabresaurus.PlayerPrefsExtensions
{
	public static class SimpleEncryption
	{
		private static string key;

		private static RijndaelManaged provider;

		private static void SetupProvider()
		{
		}

		public static string EncryptString(string sourceString)
		{
			return null;
		}

		public static string DecryptString(string sourceString)
		{
			return null;
		}

		public static string EncryptFloat(float value)
		{
			return null;
		}

		public static string EncryptInt(int value)
		{
			return null;
		}

		public static string EncryptBool(bool value)
		{
			return null;
		}

		public static float DecryptFloat(string sourceString)
		{
			return 0f;
		}

		public static int DecryptInt(string sourceString)
		{
			return 0;
		}

		public static bool DecryptBool(string sourceString)
		{
			return false;
		}
	}
}
