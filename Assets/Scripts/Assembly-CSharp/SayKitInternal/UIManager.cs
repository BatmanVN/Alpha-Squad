using UnityEngine;

namespace SayKitInternal
{
	internal class UIManager : MonoBehaviour
	{
		private static bool _isInitializationRequired;

		public static UIManager Instance { get; private set; }

		internal static void Init()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnAfterSceneLoad()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
