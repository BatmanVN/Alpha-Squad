using System;
using System.Threading.Tasks;
using DG.Tweening;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class ClanChatMessage : MonoBehaviour
{
	public enum KMIGKPRKPGR
	{
		Test = -1,
		Unset = 0,
		LevelUp = 1,
		StartedUpgrade = 2,
		FinishedUpgrade = 3,
		DonationReward = 4,
		LeaderTransfer = 5,
		EmblemChange = 6,
		ReadyToClaimUpgrade = 7,
		LeagueFinished = 8,
		PromoteToOfficer = 12,
		DemoteToMember = 13,
		KickUser = 14
	}

	[Serializable]
	public struct ServerMessage
	{
		public KMIGKPRKPGR id;

		public int intParam;

		public int intParam2;

		public string userId;

		public string userId2;
	}

	private const float ETFNRMOMGEN = 174f;

	public RectTransform thisRect;

	public ClanChatMessageInternal myMessage;

	public ClanChatMessageInternal otherMessage;

	public GameObject systemBlock;

	public Text systemMessage;

	public Sprite[] systemMessageSprites;

	public Image systemMessageImage;

	private Tweener RTSEELIFJSE;

	private bool QFFPGMIOJGS;

	public void Setup(IApiChannelMessage TSRPFHOJKSG, ClanChatUI QFNGLSEJERE)
	{
	}

	public static bool IsSystemMessage(IApiChannelMessage TSRPFHOJKSG)
	{
		return false;
	}

	private Task KJROPLORSJG(IApiChannelMessage TSRPFHOJKSG)
	{
		return null;
	}

	private Task PJHNOFPGIFM(string LPFPNRLGQGE)
	{
		return null;
	}

	private Task<string> HKSJGPTGGNO(string KMJOPIEMFRK)
	{
		return null;
	}

	public void AnimateAppear()
	{
	}

	private void LQJMPFMNQOM()
	{
	}

	private void QQMGKIQNEFM(bool JTFQTJFPHRR)
	{
	}

	private void GMNGSRKILSM(int PSPJIJNTMOI)
	{
	}
}
