using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[Serializable]
public class UserInfo
{
	[CompilerGenerated]
	private sealed class NEMJLNIRTGP
	{
		public string id;

		internal Task<UserInfo> _003CAsyncGetUserInfo_003Eb__0()
		{
			return null;
		}
	}

	private const int CACHE_DURATION = 86400;

	private static global::PIJRIGHMFQP<string, UserInfo> cache;

	public string id;

	public string displayName;

	public int level;

	public ProfileIcon.LOQMGTKOSMM icon;

	public ProfileIcon profileIcon;

	public static bool EPKPQGQOHMF(string HSLQJLPMLMH)
	{
		return false;
	}

	public static Task<UserInfo> TEOKHQFEOFG(string HSLQJLPMLMH)
	{
		return null;
	}

	public static Task RNMGPIKKRKJ(IEnumerable<string> QTFKEHIFPFL)
	{
		return null;
	}

	private static Task<UserInfo> GTLIJPJQTJM(string HSLQJLPMLMH)
	{
		return null;
	}
}
