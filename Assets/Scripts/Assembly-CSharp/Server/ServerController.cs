using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;

namespace Server
{
	public class ServerController : Singleton<ServerController>
	{
		public enum SMMMFNGFINP
		{
			AccountId = 0,
			Social = 1,
			Facebook = 2
		}

		public enum NRTIISFEIGQ
		{
			NoRead = 0,
			OwnerRead = 1,
			PublicRead = 2
		}

		[CompilerGenerated]
		private sealed class TOPRSKHNPGF
		{
			public ServerController _003C_003E4__this;

			public string randomUUID;

			public string username;

			internal Task<ISession> _003CCreateBackupAccount_003Eb__0()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class TMSPOFNLNSJ
		{
			public ServerController _003C_003E4__this;

			public string userId;

			internal Task _003CLinkGoogle_003Eb__0()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class MNQNRLNIKJI
		{
			public ServerController _003C_003E4__this;

			public IEnumerable<string> ids;

			public IEnumerable<string> usernames;

			internal Task<IApiUsers> _003CGetUsersAsync_003Eb__0()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class QQETHIMNILP<T>
		{
			public ServerController _003C_003E4__this;

			public ISession session;

			public string collection;

			public string key;

			public string userId;

			internal Task<IApiStorageObjects> _003CLoadJsonData_003Eb__0()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class MNQELQKTJRQ
		{
			public ServerController _003C_003E4__this;

			public string key;

			public string collection;

			public string data;

			public NRTIISFEIGQ permissionRead;

			internal Task<IApiStorageObjectAcks> _003CSaveJsonData_003Eb__0()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class EERRTHHPTTL
		{
			public ServerController _003C_003E4__this;

			public ISession session;

			public StorageObjectId[] objects;

			internal Task<IApiStorageObjects> _003CLoadSaveData_003Eb__0()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class JTHHFRTGSGM
		{
			public ServerController _003C_003E4__this;

			public WriteStorageObject[] objects;

			internal Task<IApiStorageObjectAcks> _003CSaveData_003Eb__0()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class GHTLKRRGNFT
		{
			public ServerController _003C_003E4__this;

			public StorageObjectId[] objects;

			internal Task _003CDeleteKeys_003Eb__0()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class SFFMOIILJML
		{
			public ServerController _003C_003E4__this;

			public StorageObjectId[] objects;

			internal Task<IApiStorageObjects> _003CDeleteKeysIfExist_003Eb__0()
			{
				return null;
			}
		}

		private const bool TIHGKEIIRSH = false;

		private ISession HJJPFMTRSEI;

		private Client GMFKGEOQGRO;

		private const int TENOPPHPNRI = 4;

		private static readonly TimeSpan[] JHRKOPFELRJ;

		public ISession KJHGSKOEGNN => null;

		public Client NEKNOQIIIKO => null;

		public bool IsClientSetup()
		{
			return false;
		}

		public void Setup(string ETOHGGLPSRH, string JGTEHGRFJJI, int LPFSTLOTQMS, string QKQMRGKQOMI)
		{
		}

		public Task<bool> CreateSession()
		{
			return null;
		}

		public Task<bool> ReauthenticateSession()
		{
			return null;
		}

		public static Task<T> RetryWithReauth<T>(Func<Task<T>> RIJMSEKSFKN)
		{
			return null;
		}

		public static Task RetryWithReauth(Func<Task> RIJMSEKSFKN)
		{
			return null;
		}

		public ISession GetSession()
		{
			return null;
		}

		public bool IsLoggedIn()
		{
			return false;
		}

		public void OverrideSession(ISession OPFQTSEJKIG)
		{
		}

		public Task<string> CreateAccount(SMMMFNGFINP MKMFHGOJTEH)
		{
			return null;
		}

		public Task<ISession> CreateBackupAccount(string EOIROQRKLLG)
		{
			return null;
		}

		public Task LinkPlatformID(SMMMFNGFINP MKMFHGOJTEH)
		{
			return null;
		}

		public Task LinkFacebook(string NKQJJMRGNLS)
		{
			return null;
		}

		public Task LinkEmail(string SHTNTOSNMOJ, string RQNJGERQGJT)
		{
			return null;
		}

		public Task LinkGoogle(string LEMGFIIIJQK)
		{
			return null;
		}

		public Task LinkGoogleOld(string NKQJJMRGNLS)
		{
			return null;
		}

		public Task LinkGameCenter(string NIHGKQNELQM, string JKFKJSQJEOG, string KNLTKKTSTSI, string OOHQKHGQPRI, string MLRHHJMTERP, string LMJNFLONIJI)
		{
			return null;
		}

		public Task<bool> HasAccountPlatformID(SMMMFNGFINP MKMFHGOJTEH)
		{
			return null;
		}

		public void LogOutFromPlatform(SMMMFNGFINP MKMFHGOJTEH)
		{
		}

		public void LogOutFromAllPlatformsExcept(SMMMFNGFINP MKMFHGOJTEH)
		{
		}

		public Task<IApiAccount> GetAccountAsync()
		{
			return null;
		}

		public Task<string> GetDisplayNameAsync()
		{
			return null;
		}

		public Task<IApiUser> GetUserAsync(string HSLQJLPMLMH, string EOIROQRKLLG = null)
		{
			return null;
		}

		public Task<IApiUsers> GetUsersAsync(IEnumerable<string> QTFKEHIFPFL, IEnumerable<string> RIORRQRHOFP = null)
		{
			return null;
		}

		public Task<ISession> TryAuthenticatePlatform(SMMMFNGFINP MKMFHGOJTEH)
		{
			return null;
		}

		private Task<ISession> PTHGTONQKKS(string LEMGFIIIJQK)
		{
			return null;
		}

		private Task<ISession> HIKILMFJJMO(string NKQJJMRGNLS)
		{
			return null;
		}

		public Task<ISession> TryAuthenticateGameCenter(string NIHGKQNELQM, string JKFKJSQJEOG, string KNLTKKTSTSI, string OOHQKHGQPRI, string MLRHHJMTERP, string LMJNFLONIJI)
		{
			return null;
		}

		public Task<ISession> TryAuthenticateCustom(string JRTNJTHJSJT)
		{
			return null;
		}

		public Task<T> LoadJsonData<T>(string QKQMRGKQOMI, string SMKIJLNPSMP = "saves", string LEMGFIIIJQK = null, ISession TIGGLKHSNGE = null)
		{
			return null;
		}

		public Task<bool> SaveJsonData(string QKQMRGKQOMI, string SMKIJLNPSMP, string TSRPFHOJKSG, NRTIISFEIGQ FITIHKMNGGF = NRTIISFEIGQ.OwnerRead)
		{
			return null;
		}

		public Task<List<CloudController.FKJTHFJMIEF>> LoadSaveData(List<string> NPESSLSLIJO, ISession TIGGLKHSNGE = null)
		{
			return null;
		}

		public Task<IApiStorageObjectAcks> SaveData(List<CloudController.FKJTHFJMIEF> GMILHEKSMTS, CloudController.Metadata TIJMLFELRGS)
		{
			return null;
		}

		public Task DeleteKeys(List<string> NPESSLSLIJO)
		{
			return null;
		}

		public Task DeleteKeysIfExist(List<string> NPESSLSLIJO)
		{
			return null;
		}

		public static bool HasInternetConnection()
		{
			return false;
		}

		[CompilerGenerated]
		private Task<IApiAccount> GOTFSJJKOOH()
		{
			return null;
		}
	}
}
