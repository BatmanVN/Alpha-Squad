using UnityEngine;

namespace SayKitInternal
{
	public class SKUtils
	{
		public static int currentTimestamp => 0;

		public static long currentTimestampMs => 0L;

		public static T FindComponentOnRootObjects<T>() where T : Component
		{
			return null;
		}

		public static string GetScriptingDefineSymbols()
		{
			return null;
		}

		public static byte[] DecompressGZIPData(byte[] data)
		{
			return null;
		}

		public static T CloneObjectViaJson<T>(T source)
		{
			return default(T);
		}

		private static TData DeserializeFromString<TData>(string settings)
		{
			return default(TData);
		}

		private static string SerializeToString<TData>(TData settings)
		{
			return null;
		}

		private static T DeserializeBSONToObject<T>(string bson)
		{
			return default(T);
		}

		private static string SerializeToBSON<T>(T data)
		{
			return null;
		}

		public static T DeepCopy<T>(T obj)
		{
			return default(T);
		}

		public static string CheckNullString(string value)
		{
			return null;
		}

		public static string GetIAPVersion()
		{
			return null;
		}
	}
}
