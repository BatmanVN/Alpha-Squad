using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class ClanInfoPopup : UIPopup, ClanMemberElement.RSSTLQGLGSL
{
	public enum PMNEIHNTHQG
	{
		Success = 0,
		Failed = 1,
		IncorrectPassword = 2
	}

	[CompilerGenerated]
	private sealed class KPPFOJFRMTT
	{
		public IApiGroup _group;

		public int kickBanDuration;

		public int tsNow;

		internal bool _003CIsBannedFromGroup_003Eb__0(EOQPNKSSOTM.Ban b)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TGMJFIITTTO
	{
		public EOQPNKSSOTM.CoreData coreData;

		internal int _003CGetOrderedMembersListByActivity_003Eb__0(IGroupUserListGroupUser m)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class KNFJMSTLRET
	{
		public IApiLeaderboardRecordList lbRecords;

		internal long _003CGetOrderedMembersListByScore_003Eb__0(IGroupUserListGroupUser m)
		{
			return 0L;
		}
	}

	[CompilerGenerated]
	private sealed class PHKSTLJQKRJ
	{
		public IGroupUserListGroupUser m;

		internal bool _003CGetOrderedMembersListByScore_003Eb__3(IApiLeaderboardRecord u)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class PGMEMKRPKIO
	{
		public List<ClanMissionWinController.FILIROQFIHJ> lbRecords;

		internal int _003CGetOrderedMembersListByScore_003Eb__0(IGroupUserListGroupUser m)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class QPIQKIMKTHT
	{
		public IGroupUserListGroupUser m;

		internal bool _003CGetOrderedMembersListByScore_003Eb__3(ClanMissionWinController.FILIROQFIHJ u)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KTEHLSJHHOO
	{
		public IApiLeaderboardRecordList lbRecords;

		internal long _003CGetOrderedMembersListByScoreOnly_003Eb__0(IGroupUserListGroupUser m)
		{
			return 0L;
		}
	}

	[CompilerGenerated]
	private sealed class PHPPQKPTRRN
	{
		public IGroupUserListGroupUser m;

		internal bool _003CGetOrderedMembersListByScoreOnly_003Eb__1(IApiLeaderboardRecord u)
		{
			return false;
		}
	}

	[SerializeField]
	private Text clanName;

	[SerializeField]
	private Text clanDescription;

	[SerializeField]
	private Text clanLevel;

	[SerializeField]
	private Text membersTitle;

	[SerializeField]
	private ClanEmblem emblem;

	[SerializeField]
	private Image leagueIcon;

	[SerializeField]
	private ActivityDisplay activity;

	[SerializeField]
	private UIClanPanelRoom[] rooms;

	[SerializeField]
	private ClanMemberElement clanMemberPrefab;

	[SerializeField]
	private Transform clanMemberList;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private GameObject joinButton;

	[SerializeField]
	private RectTransform joinLabel;

	[SerializeField]
	private GameObject joinButtonDisabled;

	[SerializeField]
	private ClanLockDisplay lockDisplay;

	[SerializeField]
	private GameObject withPasswordLabel;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private ScrollRect scroll;

	private IApiGroup NTIPSJNKNOE;

	private EOQPNKSSOTM TRIJQOEGHKQ;

	private List<ClanMemberElement> NNIQGGQJIHT;

	private EOQPNKSSOTM.Metadata JGTOKGTFLOO;

	public static Task<bool> Open(IApiGroup NTIPSJNKNOE)
	{
		return null;
	}

	private Task<bool> Setup(IApiGroup PIHERQGOOSE)
	{
		return null;
	}

	public void ShowJoinLockedClanPopup()
	{
	}

	private bool OMGRHFNOLKH()
	{
		return false;
	}

	private Task<bool> FIIJJIGSHSI(IApiGroup PIHERQGOOSE)
	{
		return null;
	}

	private bool MSLLOGSOOSL()
	{
		return false;
	}

	private bool MTNTOEFGSIT(IApiGroup PIHERQGOOSE)
	{
		return false;
	}

	public static bool HasTooManyLeaves()
	{
		return false;
	}

	private string MFOQMPLRSOP()
	{
		return null;
	}

	private Task IOKQLNSMLRP()
	{
		return null;
	}

	public static List<IGroupUserListGroupUser> GetOrderedMembersListByLevel(List<IGroupUserListGroupUser> JKGQLSPNIRP)
	{
		return null;
	}

	public static List<IGroupUserListGroupUser> GetOrderedMembersListByName(List<IGroupUserListGroupUser> JKGQLSPNIRP)
	{
		return null;
	}

	public static List<IGroupUserListGroupUser> GetOrderedMembersListByActivity(List<IGroupUserListGroupUser> JKGQLSPNIRP, EOQPNKSSOTM.CoreData PRSKRIHHILK)
	{
		return null;
	}

	public static List<IGroupUserListGroupUser> GetOrderedMembersListByScore(List<IGroupUserListGroupUser> JKGQLSPNIRP, IApiLeaderboardRecordList MHONTQLFSRF)
	{
		return null;
	}

	public static List<IGroupUserListGroupUser> GetOrderedMembersListByScore(List<IGroupUserListGroupUser> JKGQLSPNIRP, List<ClanMissionWinController.FILIROQFIHJ> MHONTQLFSRF)
	{
		return null;
	}

	public static List<IGroupUserListGroupUser> GetOrderedMembersListByScoreOnly(List<IGroupUserListGroupUser> JKGQLSPNIRP, IApiLeaderboardRecordList MHONTQLFSRF)
	{
		return null;
	}

	private void KTTQTTIIMGO()
	{
	}

	private void NIOIONHGIJH()
	{
	}

	private void GMOPRJKGMNS()
	{
	}

	public void DeselectAllElements()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnJoinButton()
	{
	}

	public void OnClicked()
	{
	}

	public void OnKick(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void OnTransferLead(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void OnPromoteToOfficer(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void OnDemoteToMember(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public static Task<PMNEIHNTHQG> TryJoinClan(string HSLQJLPMLMH, string RQNJGERQGJT, Action JNEHEJHNGME, Action GSIKEFLMFOR, Transform QRROGLLTSNE, Transform IJEIEJHITTG)
	{
		return null;
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	private void JJIMMTQHFHE()
	{
	}

	public void ShowSpinner()
	{
	}

	public void HideSpinner()
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}
}
