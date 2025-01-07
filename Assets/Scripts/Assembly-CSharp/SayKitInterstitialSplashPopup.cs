using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SayKitInterstitialSplashPopup : MonoBehaviour
{
	private enum ILLOTROQNPT
	{
		Automatically = 0,
		Continue = 1,
		NoAds = 2
	}

	[CompilerGenerated]
	private sealed class ENJKREKNQJQ
	{
		public SayKitInterstitialSplashPopup _003C_003E4__this;

		public string place;
	}

	[CompilerGenerated]
	private sealed class KHIHFLJGMIR
	{
		public bool isNoAdsClick;

		public ENJKREKNQJQ CS_0024_003C_003E8__locals1;

		internal void _003CInternalShow_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class REMOFGESEFP
	{
		public bool isContinueClick;

		public ENJKREKNQJQ CS_0024_003C_003E8__locals2;

		internal void _003CInternalShow_003Eb__1()
		{
		}
	}

	private static SayKitInterstitialSplashPopup EJQKKGFROSP;

	[SerializeField]
	private Text headerText;

	[SerializeField]
	private Slider progressBar;

	[SerializeField]
	private Button buttonNoAds;

	[SerializeField]
	private Button buttonContinue;

	private float KTHQKRMHPST;

	private float THFGTFKRFMS;

	private bool NSOPTKESFPT;

	private static string KFSPRJMQNHM;

	private static readonly string LNFNTKTRMHN;

	private static readonly string IJPSLESJPHO;

	private static readonly string ETJIOORRERR;

	private static readonly string RQGQEPMJOSJ;

	private void Update()
	{
	}

	public static SayKitInterstitialSplashPopup GetInstance()
	{
		return null;
	}

	public static void ShowPopup(int LIEHEFMHKON, bool QRROQREJNGF, string RSOSNOSITME)
	{
	}

	private void KHKMMKOHNMS(int LIEHEFMHKON, bool QRROQREJNGF, string RSOSNOSITME)
	{
	}

	private void ELEESTTPFLT(ILLOTROQNPT KLQSHTILHKT, string RSOSNOSITME)
	{
	}
}
