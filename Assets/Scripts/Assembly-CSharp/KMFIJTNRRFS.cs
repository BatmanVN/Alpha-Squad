using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;

public static class KMFIJTNRRFS
{
	[Serializable]
	public class LocalData
	{
		public List<uint> seenLocalIds;

		public List<uint> seenGlobalIds;
	}

	[Serializable]
	public class Mail
	{
		public enum OMRQMJRLJMQ
		{
			Announcement = 0,
			Update = 1,
			Event = 2,
			KnownIssue = 3,
			MissingItems = 4,
			Compensation = 5,
			Celebration = 6,
			Notification = 7
		}

		public enum NHHQMTIGGNJ
		{
			None = 0,
			Claimed = 1
		}

		[Serializable]
		public class Reward
		{
			public enum LFSEGMHFGNS
			{
				LootIdentifier = 0,
				VIP = 1
			}

			public LFSEGMHFGNS type;

			public string payload;

			public R MJSSGIHSRIG()
			{
				return null;
			}
		}

		[Serializable]
		public class Requirements
		{
			public string minVersion;

			public int minBuild;

			public int minAccountLevel;

			public string platform;

			public bool IGRENPTPOJO()
			{
				return false;
			}

			public bool FKHJJIPTHTK()
			{
				return false;
			}
		}

		public uint id;

		public OMRQMJRLJMQ type;

		public string uniqueId;

		public string msg;

		public string locKey;

		public long createTs;

		public long deleteTs;

		public bool support;

		public bool discord;

		public List<Reward> reward;

		public NHHQMTIGGNJ status;

		private List<R> rList;

		public Requirements requirements;

		public Requirements rewardRequirements;

		public virtual bool NQNPNQKIROK()
		{
			return false;
		}

		public virtual bool LOEHJMHKRNN()
		{
			return false;
		}

		public virtual bool LRFRSTGEQHS()
		{
			return false;
		}

		public virtual void INOTLLTKENE(List<R> HLOETTHIOQF)
		{
		}

		public List<R> KJHOOLTLTRS()
		{
			return null;
		}

		public virtual bool NKOPLKINNRR()
		{
			return false;
		}

		public bool KGJLJFMLMIK()
		{
			return false;
		}

		public long QPELTKKEMTM()
		{
			return 0L;
		}

		public bool LEHEPNMNKGO()
		{
			return false;
		}

		public bool NRMRQOSMMFI()
		{
			return false;
		}

		public bool MFLRRFREJPO()
		{
			return false;
		}

		public bool KFRPOLJENER()
		{
			return false;
		}
	}

	[Serializable]
	public class PlayerMail
	{
		public List<Mail> mail;

		public List<uint> claimedGlobal;
	}

	[Serializable]
	public class GlobalMail
	{
		public List<Mail> mail;
	}

	[Serializable]
	private class ClaimMailPayload
	{
		public uint id;

		public bool local;

		public string FSKHQEPGNOJ()
		{
			return null;
		}
	}

	[Serializable]
	public class ClaimMailResponse
	{
		public enum GENNEFLLPSJ
		{
			RPC_SUCCESS = 0,
			RPC_NO_SUCH_MAIL = 1,
			RPC_ALREADY_CLAIMED = 2,
			RPC_FAILED_REQUEST_DATA = 400,
			RPC_FAILED_INTERNAL = 500,
			RPC_MAINTENANCE = 1000
		}

		public GENNEFLLPSJ status;

		public Mail mail;
	}

	[CompilerGenerated]
	private sealed class KTEGGEEQKEN
	{
		public Mail mail;

		internal bool _003CSetMailAsClaimedLocally_003Eb__1<T>(T m) where T : Mail
		{
			return false;
		}
	}

	private static readonly string GLSNLMRJPHT;

	public const int HTPLTKKMSTT = 60;

	public static PlayerMail HQFQEGHLIIM;

	public static GlobalMail SNGHHQMOQEH;

	private static bool QOOPLGKOOLG;

	private static QHOERPGGPPJ.MNRNEFEHKKJ PLHMPFGSGQM;

	private static LocalData TSRPFHOJKSG;

	private static long HJQGKTGKFRF;

	private static float OIEROTHMNOF;

	public static string EQPTLIGHNQF;

	public static string RSLSKORLQIK;

	public static string ENPRSKIHEFK;

	public static string JKPNPHQEOKN;

	private static ISession KJHGSKOEGNN => null;

	private static Client NEKNOQIIIKO => null;

	public static event Action HKPMPFIFJQO
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

	public static event Action RHJNKSSFEIL
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

	public static event Action GJPHRIKGQJQ
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

	public static void MLNESSGJRME()
	{
	}

	public static bool OOEIGMHSEHG()
	{
		return false;
	}

	private static void JFNFTJGITNH()
	{
	}

	public static void MGRLTPGGSSI()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	public static void PMITOIOJNOT()
	{
	}

	public static Task RKEKGGRHOLO()
	{
		return null;
	}

	public static bool HJRJKHQFPNR()
	{
		return false;
	}

	public static void TSKOGKHLIPG()
	{
	}

	private static void EROINJHPFFL(Mail RJQOJELGTLH)
	{
	}

	public static void FKMSSLTFJTQ()
	{
	}

	public static bool JLLJITJIRHS()
	{
		return false;
	}

	public static bool GONFSEKFNSG()
	{
		return false;
	}

	public static QHOERPGGPPJ.MNRNEFEHKKJ HREPFQKHIPT()
	{
		return default(QHOERPGGPPJ.MNRNEFEHKKJ);
	}

	public static Task KSHGGRPGOST()
	{
		return null;
	}

	public static Task<ClaimMailResponse> HRHQNTKJLSH(bool NPKPHOPHNIH, uint HSLQJLPMLMH)
	{
		return null;
	}

	private static void HKKQISOFRRK(LootList HGPMKKGJFHI)
	{
	}

	private static LootList EGGKKILFKKR(Mail RJQOJELGTLH)
	{
		return null;
	}

	public static bool RIRKPPHGSPO(Mail RJQOJELGTLH)
	{
		return false;
	}

	private static void JLRLFPMELSK(Mail RJQOJELGTLH, bool NPKPHOPHNIH)
	{
	}

	public static bool HLSLKFQEHEE(Mail RJQOJELGTLH)
	{
		return false;
	}

	public static bool RFQHGRSFTRK(Mail RJQOJELGTLH)
	{
		return false;
	}

	private static bool LHSSTJLHGNN()
	{
		return false;
	}
}
