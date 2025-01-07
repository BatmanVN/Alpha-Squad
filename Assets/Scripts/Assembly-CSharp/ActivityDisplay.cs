using System.Runtime.CompilerServices;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class ActivityDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ESNSPMNKITE
	{
		public string user;

		internal bool _003CGetActivityPointsForUserInClan_003Eb__0(EOQPNKSSOTM.JoinDate u)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class PHNNRJMLRPT
	{
		public string user;

		internal bool _003CIsUserNewInClan_003Eb__0(EOQPNKSSOTM.JoinDate u)
		{
			return false;
		}
	}

	public const int DAY_DURATION = 86400;

	public Image icon;

	public GameObject newContainer;

	public GameObject activityContainer;

	public Sprite[] sprites;

	private static float[] MHGQJOEONGI;

	public void Setup(IApiGroup GLPQKQNRMER)
	{
	}

	public static bool CalculateClanIsNewAndCreateTS(IApiGroup GLPQKQNRMER, out long KESRHEGOLJK)
	{
		KESRHEGOLJK = default(long);
		return false;
	}

	public void Setup(string EJIRLENHFJM, EOQPNKSSOTM.CoreData PRSKRIHHILK)
	{
	}

	private static int GSGGMSMFQMQ()
	{
		return 0;
	}

	public void Setup(int GNRQPQRPKMM, bool NQMQSLSJFGK = false)
	{
	}

	public Sprite GetIconSpriteForActivity(int GNRQPQRPKMM)
	{
		return null;
	}

	public static int GetActivityPointsForActivityBracket(int FQRHETETEMR)
	{
		return 0;
	}

	public static int GetActivityPointsForUserInClan(string EJIRLENHFJM, EOQPNKSSOTM.CoreData LKLJJHJHRTG)
	{
		return 0;
	}

	public static int CalculateClanActivity(IApiGroup NTIPSJNKNOE, int KESRHEGOLJK)
	{
		return 0;
	}

	public static bool IsUserNewInClan(string EJIRLENHFJM, EOQPNKSSOTM.CoreData LKLJJHJHRTG)
	{
		return false;
	}
}
