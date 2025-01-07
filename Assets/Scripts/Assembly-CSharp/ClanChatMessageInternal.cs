using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class ClanChatMessageInternal : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class QHFMJFFLSKQ
	{
		public IApiChannelMessage data;

		internal bool _003CSetup_003Eb__0(IGroupUserListGroupUser u)
		{
			return false;
		}
	}

	public Text title;

	public Text message;

	public Text timeLabel;

	public Text stateLabel;

	public PlayerAvatar playerAvatar;

	public RectTransform messageRect;

	public int heightOffset;

	public RectTransform rect;

	private string LEMGFIIIJQK;

	private GameObject KKTJLJFLQFN;

	private ClanChatUI QFNGLSEJERE;

	public Task Setup(IApiChannelMessage TSRPFHOJKSG, bool QFFPGMIOJGS, ClanChatUI FPLFGNSNSMQ)
	{
		return null;
	}

	public void OnProfileClick()
	{
	}

	public float GetHeight()
	{
		return 0f;
	}
}
