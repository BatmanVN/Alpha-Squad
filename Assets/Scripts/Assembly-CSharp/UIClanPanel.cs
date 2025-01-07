using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIClanPanel : UIPanel
{
	[SerializeField]
	public UIClanInfo clanInfo;

	[SerializeField]
	private UIClanMembers clanMembers;

	[SerializeField]
	public ClanChatUI clanChatUI;

	[SerializeField]
	public GameObject spinner;

	[SerializeField]
	private List<GameObject> tabs;

	[SerializeField]
	private List<GameObject> tabsSelected;

	[SerializeField]
	private GameObject contentClan;

	[SerializeField]
	private GameObject contentMembers;

	[SerializeField]
	private GameObject contentChat;

	[SerializeField]
	private GameObject searchClanButton;

	[SerializeField]
	private Text tabMemberLabel;

	[SerializeField]
	private SoundEffect tabSwitch;

	[SerializeField]
	private SoundEffect openSound;

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public void Reset()
	{
	}

	public void UpdateMembersCount()
	{
	}

	private void JITNJSQRJSO(int FIPHTRRRPET)
	{
	}

	public void OnTabClan()
	{
	}

	public void OnTabMembers()
	{
	}

	public void OnTabChat()
	{
	}

	public static bool IsChatDisabled()
	{
		return false;
	}

	public void OnBackButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	private static void GHKJHETHETQ()
	{
	}

	public override void OnShowFinished()
	{
	}

	public static void HandleGettingKickedRealtime()
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnSearchClansButton()
	{
	}
}
