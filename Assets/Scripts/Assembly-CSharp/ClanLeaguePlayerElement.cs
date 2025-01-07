using System;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class ClanLeaguePlayerElement : MonoBehaviour
{
	public enum KHOPLEHRGLR
	{
		Default = 0,
		Selected = 1
	}

	[Serializable]
	public struct Meta
	{
		public string clanName;

		public UserInfo userInfo;
	}

	[SerializeField]
	private Text labelName;

	[SerializeField]
	private Text labelClanName;

	[SerializeField]
	private Text labelScore;

	[SerializeField]
	private Text rankLabel;

	[SerializeField]
	private PlayerAvatar playerAvatar;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image rankImage;

	[SerializeField]
	private Sprite[] rankSprites;

	[SerializeField]
	private Sprite[] backgroundSprites;

	public int index;

	private bool JKPEPJKJIOI;

	private string LEMGFIIIJQK;

	public void Setup(IApiLeaderboardRecord HNPGPKHIMKF, int QFOPFRIRJGQ)
	{
	}

	protected void PKKQIJOFIEF(KHOPLEHRGLR PTHIFGMSJIP)
	{
	}

	public virtual void OnClick()
	{
	}

	public void Select()
	{
	}

	public void Deselect()
	{
	}

	public void ShowProfile()
	{
	}
}
