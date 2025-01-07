using System;
using UnityEngine;

namespace SayKitInternal
{
	internal class SayKitAssets : ScriptableObject
	{
		private const string AssetName = "SayKitAssets";

		[SerializeField]
		private SayKitUI _sayKitUI;

		[SerializeField]
		private SayKitUI _sayKitUiLandscape;

		[SerializeField]
		private SayKitInterstitialSplashPopup _sayKitInterstitialSplashPopup;

		[SerializeField]
		private SayKitInterstitialTimerPopup _sayKitInterstitialTimerPopup;

		[SerializeField]
		private SayKitAdIdPopup _sayKitAdIdPopup;

		[NonSerialized]
		private static SayKitAssets _instance;

		public SayKitUI SayKitUI => null;

		public SayKitInterstitialSplashPopup SayKitInterstitialSplashPopup => null;

		public SayKitInterstitialTimerPopup SayKitInterstitialTimerPopup => null;

		public SayKitAdIdPopup SayKitAdIdPopupPrefab => null;

		public static SayKitAssets Instance => null;
	}
}
