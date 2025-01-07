using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class ClanMemberElement : MonoBehaviour
{
	public interface RSSTLQGLGSL
	{
		void OnClicked();

		void OnKick(IGroupUserListGroupUser EJIRLENHFJM);

		void OnTransferLead(IGroupUserListGroupUser EJIRLENHFJM);

		void OnPromoteToOfficer(IGroupUserListGroupUser EJIRLENHFJM);

		void OnDemoteToMember(IGroupUserListGroupUser EJIRLENHFJM);

		void ShowSpinner();

		void HideSpinner();
	}

	public enum MPLMKRKMIFI
	{
		Default = 0,
		Selected = 1
	}

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private Text labelName;

	[SerializeField]
	private Text labelState;

	[SerializeField]
	private PlayerAvatar playerAvatar;

	[SerializeField]
	private Image background;

	[SerializeField]
	private ActivityDisplay activity;

	[SerializeField]
	private Sprite[] backgroundSprites;

	public IGroupUserListGroupUser user;

	public IApiGroup clan;

	public RSSTLQGLGSL owner;

	public EOQPNKSSOTM.CoreData coreData;

	public int index;

	private bool JKPEPJKJIOI;

	public void Setup(RSSTLQGLGSL JKFPSLRREIJ, IGroupUserListGroupUser KOKILLKGQRQ, IApiGroup HJTFKOPIKEQ, EOQPNKSSOTM.CoreData SNRMSKRLSOM, int QFOPFRIRJGQ)
	{
	}

	private void TJIPGFNJMKO(string HSLQJLPMLMH)
	{
	}

	protected void PKKQIJOFIEF(MPLMKRKMIFI PTHIFGMSJIP)
	{
	}

	public virtual void OnClick()
	{
	}

	public void Deselect()
	{
	}

	public void ShowProfile()
	{
	}
}
