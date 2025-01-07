using UnityEngine;

namespace SayKitInternal
{
	public static class SayKitToast
	{
		public static bool IsLoaded;

		private static UISayKitToast _toastUI;

		public static GameObject Toast;

		private static void Prepare()
		{
		}

		public static void Show(string text, float duration, Color color, ToastPosition position)
		{
		}

		public static void Dismiss()
		{
		}
	}
}
