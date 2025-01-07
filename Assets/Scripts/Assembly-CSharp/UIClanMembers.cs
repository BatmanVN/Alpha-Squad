using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class UIClanMembers : MonoBehaviour, ClanMemberElement.RSSTLQGLGSL
{
	public enum LIKSKFHJFOE
	{
		Score = 0,
		Name = 1,
		Activity = 2,
		Level = 3
	}

	[CompilerGenerated]
	private sealed class FRQFJKQKMRT
	{
		public IGroupUserListGroupUser user;

		internal bool _003CDisplayUserList_003Eb__1(IApiLeaderboardRecord u)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class STMEMQFNPFT
	{
		public IGroupUserListGroupUser user;

		internal bool _003CReorderMembers_003Eb__0(IApiLeaderboardRecord u)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class GMPQGJGTEJH
	{
		public UIClanMembers _003C_003E4__this;

		public IGroupUserListGroupUser user;

		internal void _003COnKick_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class KFFFEJRSJIN
	{
		public UIClanMembers _003C_003E4__this;

		public IGroupUserListGroupUser user;

		internal void _003COnTransferLead_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class PRHESMHERIG
	{
		public UIClanMembers _003C_003E4__this;

		public IGroupUserListGroupUser user;

		internal void _003CCheckForKickWarning_003Eb__0()
		{
		}
	}

	[SerializeField]
	private ClanMemberScoreElement clanMemberPrefab;

	[SerializeField]
	private RectTransform clanMemberList;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private GameObject failedToRetrieve;

	[SerializeField]
	private GameObject findNewMembers;

	[SerializeField]
	private GameObject activityTooltip;

	[SerializeField]
	private GameObject scoreTooltip;

	[SerializeField]
	private Text[] headerLabels;

	private List<ClanMemberScoreElement> NNIQGGQJIHT;

	private IApiLeaderboardRecordList SEIPEPRIPIO;

	private UIClanPanel IQTLHJTLPIL;

	public LIKSKFHJFOE sortType;

	private void OnEnable()
	{
	}

	private void MGRLTPGGSSI()
	{
	}

	private Task MHOLQKTLLMP()
	{
		return null;
	}

	public void OnHeaderClicked(int PSPJIJNTMOI)
	{
	}

	private LIKSKFHJFOE GROSGOTLLHE(int PSPJIJNTMOI)
	{
		return default(LIKSKFHJFOE);
	}

	private int KTTGJRNFJQK(LIKSKFHJFOE PLTPNIIJTMP)
	{
		return 0;
	}

	private void REGEHTFJSOF()
	{
	}

	private void OIMNSLRRJIM()
	{
	}

	private List<IGroupUserListGroupUser> EGPEEMKQQFS(List<IGroupUserListGroupUser> JKGQLSPNIRP, EOQPNKSSOTM.CoreData PRSKRIHHILK, IApiLeaderboardRecordList MHONTQLFSRF)
	{
		return null;
	}

	public void RetryButtonClick()
	{
	}

	public void OnFindNewMembersDiscordButton()
	{
	}

	public void CopyInfoToClipboard()
	{
	}

	private static IGroupUserListGroupUser FEQKPKIMTPJ()
	{
		return null;
	}

	public static bool CanKick(IGroupUserListGroupUser EJIRLENHFJM)
	{
		return false;
	}

	public static bool CanMakeLeader(IGroupUserListGroupUser EJIRLENHFJM)
	{
		return false;
	}

	public static bool CanPromote(IGroupUserListGroupUser EJIRLENHFJM)
	{
		return false;
	}

	public static bool CanDemote(IGroupUserListGroupUser EJIRLENHFJM)
	{
		return false;
	}

	public void DeselectAllElements()
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

	public void OnPromote(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void OnClicked()
	{
	}

	public void CheckForKickWarning(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void TryToKickUser(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void TryToTransferLead(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void TryToPromoteToOfficer(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void TryToDemoteToMember(IGroupUserListGroupUser EJIRLENHFJM)
	{
	}

	public void ShowActivityTooltip()
	{
	}

	public void CloseActivityTooltip()
	{
	}

	public void ShowScoreTooltip()
	{
	}

	public void CloseScoreTooltip()
	{
	}

	public void ShowSpinner()
	{
	}

	public void HideSpinner()
	{
	}
}
