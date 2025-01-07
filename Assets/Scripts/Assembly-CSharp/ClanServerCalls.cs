using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;

public class ClanServerCalls : Singleton<ClanServerCalls>
{
	public enum RSSENPLGIQE
	{
		SuperAdmin = 0,
		Admin = 1,
		Member = 2,
		WaitingForInvite = 3
	}

	public struct SJOQFLQJOGN
	{
		public string SMKIJLNPSMP;

		public string QKQMRGKQOMI;

		public string LEMGFIIIJQK;
	}

	public enum SSQEPNESKEM
	{
		FAILURE = -1,
		RPC_SUCCESS = 0,
		RPC_FAILED_NO_CLAN = 1,
		RPC_FAILED_ALREADY_DONATED = 2,
		RPC_FAILED_JOINED_TODAY = 3,
		RPC_FAILED_DONATE_LIMIT = 4,
		RPC_FAILED_ALREADY_ASSISTED = 5,
		RPC_FAILED_ONLY_LEADER_ACTION = 6,
		RPC_FAILED_NOT_MET_CONDITIONS = 7,
		RPC_FAILED_ASSIST_LIMIT = 8,
		RPC_FAILED_WEEKLY_DONATE_LIMIT = 9,
		RPC_FAILED_RECEIPT_PROCESSED = 10,
		RPC_FAILED_NOT_ENOUGH_TICKETS = 11,
		RPC_FAILED_NOT_ENOUGH_MISSION_TICKETS = 12,
		RPC_FAILED_LEAGUE_NOT_PLAYABLE = 13,
		RPC_FAILED_MISSION_NOT_IN_PROGRESS = 14,
		RPC_FAILED_MISSION_TIMED_OUT = 15,
		RPC_FAILED_NO_LEAGUE_INFO = 16,
		RPC_FAILED_COULDNT_ASSIGN_CLAN_TO_BUCKETS = 17,
		RPC_FAILED_MAX_CONTRACTS_COMPLETED = 18,
		RPC_FAILED_CLAN_MAX_CONTRACTS_COMPLETED = 19,
		RPC_FAILED_BOSS_NOT_UNLOCKED = 20,
		RPC_FAILED_ROOM_IS_BUILDING = 105,
		RPC_FAILED_ROOM_NOT_READY = 106,
		RPC_FAILED_PURCHASE_FAILED = 107,
		RPC_FAILED_NOT_ENOUGH_CLAN_TOKENS = 108,
		RPC_FAILED_REWARD = 109,
		RPC_FAILED_NOT_ENOUGH_ACTIVITY = 110,
		RPC_FAILED_BOOST_NOT_READY = 111,
		RPC_FAILED_BOOST_IS_UPGRADING = 112,
		RPC_FAILED_REQUEST_DATA = 400,
		RPC_FAILED_INTERNAL = 500,
		RPC_MAINTENANCE = 1000,
		RPC_LEAGUES_MAINTENANCE = 1001
	}

	[Serializable]
	public class RpcPayload
	{
		public string group_id;

		public bool test_user;

		public RpcPayload()
		{
		}

		public RpcPayload(string IQFJKESQILQ, bool LPKTMIPNEME = false)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string FSKHQEPGNOJ()
		{
			return null;
		}
	}

	[Serializable]
	public class RpcPayloadMap : RpcPayload
	{
		private Dictionary<string, object> dataTable;

		public RpcPayloadMap(string IQFJKESQILQ, bool LPKTMIPNEME = false)
		{
		}

		public RpcPayloadMap JKQLRSFREJN(string EFKRFLHRFPJ, object RRPSNPOTQNT)
		{
			return null;
		}

		public override string FSKHQEPGNOJ()
		{
			return null;
		}

		[CompilerGenerated]
		internal static string NMKJPKERQGJ(string EFKRFLHRFPJ, object RRPSNPOTQNT, bool GOLSLKFJOTM)
		{
			return null;
		}
	}

	[Serializable]
	public class RpcBuildPayload : RpcPayload
	{
		public int room_id;
	}

	[Serializable]
	public class RpcBoostPayload : RpcPayload
	{
		public int boost_id;
	}

	[Serializable]
	public class RpcRandomGroups : RpcPayload
	{
		public int date;

		public int activity;

		public int limit;

		public bool openOnly;

		public bool includeFull;

		public int maxMinPlayerLevel;

		public int minClanLevel;

		public string name;

		public int minLeague;
	}

	[Serializable]
	public class RpcBuyPayload : RpcPayload
	{
		public int room_id;

		public int item_id;

		public int amount;
	}

	[Serializable]
	public class RpcPurchaseInappTicketPayload : RpcPayload
	{
		public EOQPNKSSOTM.InappReceipt receipt;

		public int tier;
	}

	[Serializable]
	public class RpcPurchaseLeagueTicketsPayload : RpcPayload
	{
		public EOQPNKSSOTM.InappReceipt receipt;

		public int amount;
	}

	[Serializable]
	public class PayloadIds
	{
		public string[] ids;
	}

	[Serializable]
	public class FetchedDataEntry
	{
		public string key;

		public string value;
	}

	[Serializable]
	public struct TimeValue
	{
		public int seconds;

		public string QSGJQSOJLSF()
		{
			return null;
		}
	}

	[Serializable]
	public struct OpenValue
	{
		public bool value;
	}

	[Serializable]
	public class ApiGroup : IApiGroup
	{
		[SerializeField]
		private string avatar_url;

		[SerializeField]
		private TimeValue create_time;

		[SerializeField]
		private string creator_id;

		[SerializeField]
		private string description;

		[SerializeField]
		private int edge_count;

		[SerializeField]
		private string id;

		[SerializeField]
		private string lang_tag;

		[SerializeField]
		private int max_count;

		[SerializeField]
		private string metadata;

		[SerializeField]
		private string name;

		[SerializeField]
		private OpenValue open;

		[SerializeField]
		private TimeValue update_time;

		public string AvatarUrl => null;

		public string CreateTime => null;

		public string CreatorId => null;

		public string Description => null;

		public int EdgeCount => 0;

		public string Id => null;

		public string LangTag => null;

		public int MaxCount => 0;

		public string Metadata => null;

		public string Name => null;

		public bool Open => false;

		public string UpdateTime => null;
	}

	[Serializable]
	public class ApiGroupList : IApiGroupList
	{
		[SerializeField]
		private List<ApiGroup> groups;

		[SerializeField]
		private string cursor;

		public string Cursor => null;

		public IEnumerable<IApiGroup> Groups => null;

		public void KNSMJJORRJF()
		{
		}
	}

	[Serializable]
	public class RpcRandomGroupsResponse
	{
		public SSQEPNESKEM status;

		public ApiGroupList groupList;

		public string error;
	}

	[Serializable]
	public class RpcResponse
	{
		public SSQEPNESKEM status;

		public FetchedDataEntry[] fetchedData;

		public string error;

		public bool Success => false;

		public string IMLOHJMOIJM()
		{
			return null;
		}

		public bool RMEKOMSHFTP()
		{
			return false;
		}
	}

	[Serializable]
	public class UserInfoResponse
	{
		public UserInfo[] result;

		public string error;
	}

	[Serializable]
	public class UserProfileResponse
	{
		public UserProfile[] result;

		public string error;
	}

	[CompilerGenerated]
	private sealed class QGISIHJQHGI
	{
		public ClanServerCalls _003C_003E4__this;

		public string userId;

		public int limit;

		internal Task<IApiUserGroupList> _003CAsyncFetchUserClans_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class QELLMOIJPKE
	{
		public ClanServerCalls _003C_003E4__this;

		public string clanName;

		public string description;

		public string emblem;

		internal Task<IApiGroup> _003CAsyncCreateClan_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class GKJSOMNJRGS
	{
		public ClanServerCalls _003C_003E4__this;

		public int limit;

		public string finalName;

		internal Task<IApiGroupList> _003CAsyncGetClanList_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class SLOJHKTIKHO
	{
		public ClanServerCalls _003C_003E4__this;

		public string groupId;

		public int limit;

		internal Task<IApiGroupUserList> _003CAsyncGetMemberList_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class SQNEQHJHFFE
	{
		public ClanServerCalls _003C_003E4__this;

		public string clanId;

		internal Task _003CAsyncLeaveClan_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class IMGFPOLSSOG
	{
		public ClanServerCalls _003C_003E4__this;

		public StorageObjectId[] objects;

		internal Task<IApiStorageObjects> _003CAsyncFetch_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class HOOPKQIPRSM
	{
		public ClanServerCalls _003C_003E4__this;

		public string groupId;

		public string clanName;

		public bool open;

		public string description;

		public string emblem;

		internal Task _003CAsyncUpdateClan_003Eb__0()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class OKSRNTRFFTM
	{
		public ClanServerCalls _003C_003E4__this;

		public string callId;

		public string payload;

		internal Task<IApiRpc> _003CAsyncRpc_003Eb__0()
		{
			return null;
		}
	}

	public static readonly string CLANS_COLLECTION;

	public static readonly string CLAN_SETTINGS_COLLECTION;

	public static readonly string CLAN_PLAYERS_COLLECTION;

	public static readonly string CLAN_LEAGUES_COLLECTION;

	public static readonly string CLAN_MISSIONS_COLLECTION;

	private static readonly string OGERLJRRIGS;

	private static readonly string NJQEPJIQQIL;

	private static readonly string GKOPPNKIPJJ;

	private static readonly string LFPHHENOSEO;

	private static readonly string NPFRPIRKOIE;

	private static readonly string IKEFRRNQQQK;

	private static readonly string HRJGEMTSHFG;

	private static readonly string MHFJETHOLQK;

	private static readonly string TFKGOKJTLTE;

	private static readonly string OELKJNREGLR;

	private static readonly string LIMIKMJJOQM;

	private static readonly string EEIKIQJILQM;

	private static readonly string TGFHNKSJHTH;

	private static readonly string PNSPPEFROPT;

	private static readonly string RKFRRKNHKJF;

	private static readonly string LKGOGSFKETM;

	private static readonly string LGQMIKQFKKN;

	private static readonly string QPJOHENHRQT;

	private static readonly string TKEHLPSOPLP;

	private static readonly string GKPMMOGQRQG;

	private static readonly string FELFNPFPGKJ;

	private static readonly string MIRLSFMQFMT;

	private static readonly string RKLEFQOOGNR;

	private static readonly string ONFHMKRPLPL;

	private static readonly string PRGMIIOIPGG;

	private static readonly string GPMHONILSFM;

	private static readonly string ESRPIEKOKGE;

	private static readonly string ILSNEKOTJMF;

	private static readonly string QLNSGHTGJFN;

	private static readonly string FMRIQQRJTQN;

	private static readonly string MEKFFLFRSNT;

	private static readonly string HQEKGQIPILQ;

	private static readonly string INLHHOSJPMJ;

	private static readonly string TJFTSOFLORF;

	private static readonly string PMGGLLPELTS;

	private static readonly string SFFPLRPEKLO;

	private static readonly string NSQIISPNOJO;

	private static readonly string PPSPGKPFNHJ;

	private static readonly string THNHTEHIGNF;

	private static readonly string OLOKTLGHHSN;

	private static readonly string EROOHGMFRFE;

	private static readonly string LJPOIOMIOTK;

	private static readonly string EFQHQMRJQHK;

	private static readonly string OLQJGOTGTPE;

	private static readonly string OPKPQFQERQF;

	private const int KRSNNKTTILS = 86400;

	private static global::PIJRIGHMFQP<string, IApiGroup> EPQQHELGRQO;

	public static string PKKKFLRHPMG => null;

	private ISession KJHGSKOEGNN => null;

	private Client NEKNOQIIIKO => null;

	private bool LHSSTJLHGNN()
	{
		return false;
	}

	private bool TOLQQKRKOKM(int MJPJLPIKQFE)
	{
		return false;
	}

	public static string GetClanDataKey(string OKOMLNLEIOQ)
	{
		return null;
	}

	public static string GetBaseDataKey(string OKOMLNLEIOQ)
	{
		return null;
	}

	public static string GetLeagueDataKey(string OKOMLNLEIOQ)
	{
		return null;
	}

	private static RpcResponse NKFNQHTSGMM()
	{
		return null;
	}

	public static SJOQFLQJOGN ConstructFetchStruct(string SMKIJLNPSMP, string QKQMRGKQOMI, string EJIRLENHFJM)
	{
		return default(SJOQFLQJOGN);
	}

	public static SJOQFLQJOGN ConstructClanStruct(string TPHNQKGGIGF)
	{
		return default(SJOQFLQJOGN);
	}

	public static SJOQFLQJOGN ConstructBaseStruct(string TPHNQKGGIGF)
	{
		return default(SJOQFLQJOGN);
	}

	public static SJOQFLQJOGN ConstructLeagueStruct(string TPHNQKGGIGF)
	{
		return default(SJOQFLQJOGN);
	}

	public static SJOQFLQJOGN ConstructPlayerStruct(string JKFKJSQJEOG)
	{
		return default(SJOQFLQJOGN);
	}

	public static SJOQFLQJOGN ConstructCoreConfigStruct()
	{
		return default(SJOQFLQJOGN);
	}

	public static SJOQFLQJOGN ConstructBaseConfigStruct()
	{
		return default(SJOQFLQJOGN);
	}

	public static SJOQFLQJOGN ConstructLeagueConfigStruct()
	{
		return default(SJOQFLQJOGN);
	}

	public Task<IApiUserGroupList> AsyncFetchUserClans(string LEMGFIIIJQK, int TJIGSLIMHGK)
	{
		return null;
	}

	public Task<(IApiGroup, bool)> AsyncGetJoinedClan(string LEMGFIIIJQK)
	{
		return null;
	}

	public Task<IApiGroup> AsyncCreateClan(string MOQMMKPQIHP, string OSEGHJSRPPN, string QJOQFQJQGGS)
	{
		return null;
	}

	public Task<RpcResponse> AsyncJoinClan(string GNKIKJOFGRI, string RQNJGERQGJT)
	{
		return null;
	}

	public Task<RpcResponse> AsyncLockClan(string GNKIKJOFGRI, bool PNRKOFTKNLL)
	{
		return null;
	}

	public Task<bool> AsyncSetMinimumPlayerLevel(string GNKIKJOFGRI, int IQLQQNIPTPQ)
	{
		return null;
	}

	public Task<IApiGroupList> AsyncGetClanList(string NPHHRQRGRSR, int TJIGSLIMHGK)
	{
		return null;
	}

	public Task<IApiGroupUserList> AsyncGetMemberList(string GNKIKJOFGRI, int TJIGSLIMHGK)
	{
		return null;
	}

	public Task<bool> AsyncLeaveClan(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<IApiStorageObjects> AsyncFetch(List<SJOQFLQJOGN> FEMPQRSQTIT)
	{
		return null;
	}

	public Task<IApiStorageObjects> AsyncFetch(string SMKIJLNPSMP, string QKQMRGKQOMI, string LEMGFIIIJQK)
	{
		return null;
	}

	public Task<bool> AsyncUpdateClan(string GNKIKJOFGRI, string MOQMMKPQIHP, bool PFPQKTJHPHL, string OSEGHJSRPPN, string QJOQFQJQGGS)
	{
		return null;
	}

	private Task<RpcResponse> IGORHJKNKKK(string JEQPEIKTFTK, string TQSRMJTSKJK)
	{
		return null;
	}

	private Task<RpcResponse> IGORHJKNKKK(string JEQPEIKTFTK, RpcPayload TQSRMJTSKJK)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDonate(string TPHNQKGGIGF, bool TPTKFISFNGT, int ISLTSKEPJPI = 1, bool LPKTMIPNEME = false, bool TJTFEONRIIM = false)
	{
		return null;
	}

	public Task<RpcResponse> AsyncPurchaseInappTicket(string TPHNQKGGIGF, EOQPNKSSOTM.InappReceipt SMFHTMQOHMH, int FOQIJNNSRNI)
	{
		return null;
	}

	public Task<RpcResponse> AsyncSpendInappTicket(string TPHNQKGGIGF, int FOQIJNNSRNI)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDonationReward(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDonationRewardReset(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncClaimDonationReward(string TPHNQKGGIGF, int FOQIJNNSRNI, int EOOEIROQJOE)
	{
		return null;
	}

	public Task<RpcResponse> AsyncStartBuilding(string TPHNQKGGIGF, int SLIEEELQMQS)
	{
		return null;
	}

	public Task<RpcResponse> AsyncAssistBuilding(string TPHNQKGGIGF, int SLIEEELQMQS)
	{
		return null;
	}

	public Task<RpcResponse> AsyncCompleteBuilding(string TPHNQKGGIGF, int SLIEEELQMQS)
	{
		return null;
	}

	public Task<RpcResponse> AsyncStartUpgradingBoost(string TPHNQKGGIGF, int JPLFGIEHPJE)
	{
		return null;
	}

	public Task<RpcResponse> AsyncAssistBoostUpgrade(string TPHNQKGGIGF, int JPLFGIEHPJE)
	{
		return null;
	}

	public Task<RpcResponse> AsyncFinishBoostUpgrade(string TPHNQKGGIGF, int JPLFGIEHPJE)
	{
		return null;
	}

	public Task<RpcResponse> AsyncBuyItem(string TPHNQKGGIGF, int OJJLFPMNEHN, int PLNGRQSRTJG, int ISLTSKEPJPI)
	{
		return null;
	}

	public Task<RpcResponse> AsyncBuySkin(string TPHNQKGGIGF, IRHNENTFPPM LPIPSETJMQR)
	{
		return null;
	}

	public Task<RpcResponse> AsyncClaimAchievement(string TPHNQKGGIGF, int RHPEJKRREFF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncTransferLeader(string TPHNQKGGIGF, string LEMGFIIIJQK)
	{
		return null;
	}

	public Task<RpcResponse> AsyncPromoteToOfficer(string TPHNQKGGIGF, string LEMGFIIIJQK)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDemoteToMember(string TPHNQKGGIGF, string LEMGFIIIJQK)
	{
		return null;
	}

	public Task<RpcResponse> AsyncKickUser(string TPHNQKGGIGF, string LEMGFIIIJQK)
	{
		return null;
	}

	public Task<RpcResponse> AsyncCheckLeaderActivity(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncChangeEmblem(string TPHNQKGGIGF, string QJOQFQJQGGS)
	{
		return null;
	}

	public Task<RpcResponse> AsyncRpcDeleteClan(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncRpcFetchAll(string TPHNQKGGIGF)
	{
		return null;
	}

	private RpcResponse PGHGKJPFKOM(string TQSRMJTSKJK)
	{
		return null;
	}

	public Task<EOQPNKSSOTM.PrivateData> AsyncGetPrivateData(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<UserInfo[]> AsyncGetUserInfo(IEnumerable<string> QTFKEHIFPFL)
	{
		return null;
	}

	public Task<UserProfile[]> AsyncGetUserProfile(IEnumerable<string> QTFKEHIFPFL)
	{
		return null;
	}

	public Task<IApiGroupList> AsyncGetRandomGroups(int QNKRGGJTQIT, int MQSTJHFMETT, int TJIGSLIMHGK, bool NOSREFROJIQ = true, bool QGJHNQNOSOT = false, int QPJFITKSOHQ = 0, int EGFGQGKHHES = 1, string EFKRFLHRFPJ = "", int RRLHNKHGRME = -1)
	{
		return null;
	}

	public Task<IApiGroupList> AsyncGetGroups(IEnumerable<string> QTFKEHIFPFL)
	{
		return null;
	}

	public Task<RpcResponse> AsyncCreateLeagueInfo(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncConsumeMissionTicket(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncMissionCompleted(string TPHNQKGGIGF, int PQPIEJGPJJO, int GPFLNRGSTES)
	{
		return null;
	}

	public Task<RpcResponse> AsyncCompleteContracts(string TPHNQKGGIGF, int ISLTSKEPJPI)
	{
		return null;
	}

	public Task<RpcResponse> AsyncCheckLeagueReward(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncPurchaseLeagueTickets(string TPHNQKGGIGF, EOQPNKSSOTM.InappReceipt SMFHTMQOHMH, int ISLTSKEPJPI)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugResetAssists(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugResetPurchases(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugSetPlayerCoins(string TPHNQKGGIGF, int EFGPQFIJRJF, int ISLTSKEPJPI)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugResetWeek(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugSetRoomLevel(string TPHNQKGGIGF, int OJJLFPMNEHN, int IQLQQNIPTPQ)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugSetBoostLevel(string TPHNQKGGIGF, int KLJPMRIJMPT, int IQLQQNIPTPQ)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugAskForServerMessage(string TPHNQKGGIGF)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugAddXp(string TPHNQKGGIGF, int ISLTSKEPJPI)
	{
		return null;
	}

	public Task<RpcResponse> AsyncDebugSetClanMissionContractsCompleted(string TPHNQKGGIGF, int ISLTSKEPJPI)
	{
		return null;
	}

	private RpcPayload ORHREHTFKST(string GNKIKJOFGRI)
	{
		return null;
	}
}
