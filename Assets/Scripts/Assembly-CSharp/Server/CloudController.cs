using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;

namespace Server
{
	public class CloudController : Singleton<CloudController>
	{
		public interface SLGJGMIGTGQ
		{
			(string, string, int, string) GLPQSSOESHQ();

			void PMITOIOJNOT(Data TSRPFHOJKSG);

			Data KLJEPKORMLM();

			void OKMRNGEHLLH();

			List<FKJTHFJMIEF> RREEGNRFPTP();

			void ROJNOQLGOKS(List<FKJTHFJMIEF> GRJRQRKLHIH);

			List<string> MNIOKKERFNE();

			List<string> FTKPQISONPH();

			int GLMOGISGRKN();

			bool KIPJNTEPLJL(string HHRGQEQGGIS, string ELEIPINNGGJ);

			int QLQMPRJMGFQ();

			bool FRLKJOLQLOO();

			bool ITSRQMPQEQS();

			void TQEETFMQLPJ();

			bool KKKEKKSGJKF();

			void FIPRMKSJRHM(string EOIROQRKLLG, ServerController.SMMMFNGFINP MKMFHGOJTEH);

			void EGRMMQTHKKJ(string EFKRFLHRFPJ);

			Task<string> NSQFRISLLGE();

			Task RNFTPMFQFSN();

			Task<bool> MNKOMHRKIHP();

			Task<bool> OGIQGLSNKOF(List<FKJTHFJMIEF> JSGNQIMOMJN, int LMJNFLONIJI);

			Task<bool> JLNOPNOFTSN(List<FKJTHFJMIEF> HPTMMFTPHIL);

			void HLRINKPIHPT(string KGNFSPSOOOT);
		}

		public class FKJTHFJMIEF
		{
			public string QKQMRGKQOMI;

			public string TSRPFHOJKSG;

			public string TLFEJFMEHLK;

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public struct ChecksumEntry
		{
			public string key;

			public int checksum;
		}

		[Serializable]
		public struct VersionEntry
		{
			public string key;

			public string version;
		}

		[Serializable]
		public class Data
		{
			public string accountId;

			public int saveTimestamp;

			public bool dirtyOffline;

			public bool socialLoggedIn;

			public List<ChecksumEntry> checksums;

			public List<VersionEntry> versions;
		}

		[Serializable]
		public class Metadata
		{
			public int timestamp;

			public string version;

			public int build;

			public Metadata(int MQSTJHFMETT)
			{
			}
		}

		[Serializable]
		private struct LogDataConflictPayload
		{
			public bool choseLocal;

			public string deviceId;

			public string FSKHQEPGNOJ()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class JLKGSOPGMJS
		{
			public FKJTHFJMIEF entry;

			internal bool _003CRemoveUnchangedEntries_003Eb__0(ChecksumEntry e)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class EFOGJSLQRPQ
		{
			public ChecksumEntry chcEntry;

			internal bool _003CUpdateChecksums_003Eb__0(ChecksumEntry e)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class QTNMMQRNKQO
		{
			public string key;

			internal bool _003CUpdateVersion_003Eb__0(VersionEntry e)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class OOEMNJOLGMI
		{
			public FKJTHFJMIEF save;

			internal bool _003CInjectVersions_003Eb__0(VersionEntry v)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class PRQGGLGIPNE
		{
			public FKJTHFJMIEF cloudEntry;

			internal bool _003CCheckIfDatasAreIdentical_003Eb__0(FKJTHFJMIEF s)
			{
				return false;
			}
		}

		private static Data TSRPFHOJKSG;

		private static bool QOOPLGKOOLG;

		private static SLGJGMIGTGQ LLKNHTHGMMI;

		private static bool IONEFIHLTPI;

		public static string SERVER_DATA_COLLECTION;

		public static string METADATA_KEY;

		public static string METADATA_COLLECTION;

		public static void Init()
		{
		}

		public static bool HasImplementation()
		{
			return false;
		}

		public static void SetImplementation(SLGJGMIGTGQ QMQFQSTMKFF)
		{
		}

		public static SLGJGMIGTGQ GetImplementation()
		{
			return null;
		}

		public static void ClearData()
		{
		}

		public static void Log(string GLQPJGLOFLS)
		{
		}

		public static void LogError(string GLQPJGLOFLS)
		{
		}

		public static Data GetData()
		{
			return null;
		}

		public static bool HaveAccountId()
		{
			return false;
		}

		public static string GetUsername()
		{
			return null;
		}

		public static long GetCreateTime()
		{
			return 0L;
		}

		private bool PPOEJHTSSSJ(ServerController.SMMMFNGFINP MKMFHGOJTEH)
		{
			return false;
		}

		private bool NMIIFTNPMOH(ISession OKTFKLTNSOE)
		{
			return false;
		}

		public Task<bool> TryConnectToPlatform(ServerController.SMMMFNGFINP MKMFHGOJTEH)
		{
			return null;
		}

		private Task KQFQRLTOQJI(ISession OPFQTSEJKIG)
		{
			return null;
		}

		private Task IEIEJKTTJTH(string EOIROQRKLLG)
		{
			return null;
		}

		public Task<bool> CreateAccount(ServerController.SMMMFNGFINP MKMFHGOJTEH = ServerController.SMMMFNGFINP.AccountId)
		{
			return null;
		}

		public static string GetAccountId()
		{
			return null;
		}

		public static void SetDirtyOffline(bool TTTOKGEEOPS = true)
		{
		}

		public static bool IsDirtyOffline()
		{
			return false;
		}

		public Task<bool> LoginSequence(bool HFRKKLLITTJ = true)
		{
			return null;
		}

		public Task<int> GetServerConfirmedTimestamp(ISession HJJPFMTRSEI = null)
		{
			return null;
		}

		public Task<Metadata> GetServerMetadata(ISession HJJPFMTRSEI = null)
		{
			return null;
		}

		public Task LoadServerSaveAndSaveToLocal(int LMJNFLONIJI)
		{
			return null;
		}

		public static Task<bool> TrySaveToCloud()
		{
			return null;
		}

		private Task<bool> PFEROTOSSSR(bool LHLOPPLJMKE = false)
		{
			return null;
		}

		public void SetSocialLoggedIn(bool THOLFILSIMG = true, bool LIPENRNHTJL = true)
		{
		}

		private void FTJJOITSPGI(List<FKJTHFJMIEF> GRJRQRKLHIH, out List<ChecksumEntry> ENFGPNJQMSF)
		{
			ENFGPNJQMSF = null;
		}

		private void IMFIRSQOTLJ(List<FKJTHFJMIEF> GRJRQRKLHIH, int LMJNFLONIJI)
		{
		}

		private void JLRMJTKFMQP(List<ChecksumEntry> ENFGPNJQMSF)
		{
		}

		private void QJIFGGEJGLH(IApiStorageObjectAcks LTTHOGIHMMQ)
		{
		}

		private void OKFIFMIRMGP(string QKQMRGKQOMI, string TLFEJFMEHLK)
		{
		}

		private void TMQEQOSOKOR(ref List<FKJTHFJMIEF> SKRTNKRHQMK)
		{
		}

		private void LQJOFGKROJN(int LMJNFLONIJI)
		{
		}

		private int RJRRSPOMFOM(string MTLGKNIHTMR)
		{
			return 0;
		}

		private bool PRPLLSPNEFJ(List<FKJTHFJMIEF> NPKPHOPHNIH, List<FKJTHFJMIEF> MTGILFLNMMK)
		{
			return false;
		}

		public static Task RpcLogDataConflict(bool KRJNHMROSOF)
		{
			return null;
		}
	}
}
