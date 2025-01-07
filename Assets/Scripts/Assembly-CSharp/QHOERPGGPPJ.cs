using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;
using Server;

public class QHOERPGGPPJ
{
	public enum MNRNEFEHKKJ
	{
		None = 0,
		Requested = 1,
		TimedOut = 2,
		Received = 3
	}

	[CompilerGenerated]
	private sealed class GIRMNLPSOSR
	{
		public QHOERPGGPPJ _003C_003E4__this;

		public long score;

		public long subscore;

		public string metadata;

		internal Task<IApiLeaderboardRecord> _003CSubmitScore_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class PPFMQTGGMMP
	{
		public QHOERPGGPPJ _003C_003E4__this;

		public IEnumerable<string> ids;

		public long? expiry;

		public int limit;

		public string cursor;

		internal Task<IApiLeaderboardRecordList> _003CGetLeaderboard_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class LNTHKQSKGQL
	{
		public QHOERPGGPPJ _003C_003E4__this;

		public string accountId;

		public long? expiry;

		public int limit;

		internal Task<IApiLeaderboardRecordList> _003CGetLeaderboardAroundPlayer_003Eb__0()
		{
			return null;
		}
	}

	public string HSLQJLPMLMH;

	public List<IApiLeaderboardRecordList> LOGTNKITFPM;

	private ServerController MTSPGFQTFEH;

	private int NPTIPLIIREF;

	private float ISIQEOLHGJN;

	private int HKRGNOQLQTJ;

	private int NFFSIMFEMJH;

	private MNRNEFEHKKJ MJPJLPIKQFE;

	private static readonly string MMJPROJRQGM;

	public event Action<QHOERPGGPPJ> NIMSTKRQNTJ
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public QHOERPGGPPJ(string KHNIRLKORRE, ServerController SLHPMKQNOQS, int GQGOJFERLRL = 3600)
	{
	}

	public MNRNEFEHKKJ MOLLQITEILG()
	{
		return default(MNRNEFEHKKJ);
	}

	public void MSHTFSRTKGS()
	{
	}

	public IApiLeaderboardRecord OLEKPPLNJGS(int PSPJIJNTMOI)
	{
		return null;
	}

	public IApiLeaderboardRecord IOTPJQQMGPO(int PSPJIJNTMOI)
	{
		return null;
	}

	public int JKIMKHFMHNI()
	{
		return 0;
	}

	public int TLKFNJRTQJL()
	{
		return 0;
	}

	public Task<bool> MKSJILSMJNP(long PMNGMSRTHLP, long GKNHPFIPMPO = 0L, string JGTOKGTFLOO = null)
	{
		return null;
	}

	public Task<IApiLeaderboardRecordList> ERTLQTKTPQT(int TJIGSLIMHGK = 1, int FIPHTRRRPET = 0, Action<QHOERPGGPPJ, int> KQGHTRIGRTT = null, IEnumerable<string> QTFKEHIFPFL = null, long? MTMMJRNPQPP = null)
	{
		return null;
	}

	public Task<IApiLeaderboardRecordList> KGKFPLIPPSP(int TJIGSLIMHGK = 1)
	{
		return null;
	}

	public Task<IApiLeaderboardRecordList> KQQSNQHGFIG(string NFPMMFPIINT, int TJIGSLIMHGK = 1, long? MTMMJRNPQPP = null)
	{
		return null;
	}

	public bool JJIMKGONJTS(int FIPHTRRRPET)
	{
		return false;
	}

	public static string TGGEFPNPEKO(ISession OKTFKLTNSOE, long PMNGMSRTHLP, long GKNHPFIPMPO)
	{
		return null;
	}

	private static string MFLOMMLOHKI(string HETQTIKJGNI)
	{
		return null;
	}

	private static string ONMNOSPIOEE(ISession OKTFKLTNSOE, long PMNGMSRTHLP, long HMSEMMJRRSI)
	{
		return null;
	}
}
