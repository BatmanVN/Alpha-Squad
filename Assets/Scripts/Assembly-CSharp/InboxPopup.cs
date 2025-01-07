using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InboxPopup : UIPopup
{
	public enum FNKNHJNKREO
	{
		Inbox = 0,
		WhatsNew = 1
	}

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private MailItem mailItemPrefab;

	[SerializeField]
	private MailItemWithReward mailItemPrefabWithReward;

	[SerializeField]
	private RectTransform itemParent;

	[SerializeField]
	private GameObject contentInbox;

	[SerializeField]
	private GameObject contentWhatsNew;

	[SerializeField]
	private List<GameObject> tabs;

	[SerializeField]
	private List<GameObject> tabsSelected;

	[SerializeField]
	private List<Text> tabsLabels;

	[SerializeField]
	private SoundEffect tabSwitch;

	[SerializeField]
	private WhatsNewTab whatsNewTab;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private GameObject failedToRetrieve;

	[SerializeField]
	private GameObject inboxEmpty;

	[SerializeField]
	private GameObject cloudBlock;

	[SerializeField]
	private GameObject disabledBlock;

	[SerializeField]
	private GameObject claimSpinner;

	private List<MailItem> JPKSIOLNHGN;

	public FNKNHJNKREO tabToOpen;

	private bool OITHRLQJPOM;

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void OnDestroy()
	{
	}

	public void OnTabInbox()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void HKPMPFIFJQO()
	{
	}

	private void GJPHRIKGQJQ()
	{
	}

	public void OnTabWhatsNew()
	{
	}

	private void ERNJNLPPIPM()
	{
	}

	private MailItem EQJORJJNMGT(KMFIJTNRRFS.Mail RJQOJELGTLH, Transform JKFPSLRREIJ)
	{
		return null;
	}

	private bool GOIHFRJMEFJ(KMFIJTNRRFS.Mail RJQOJELGTLH)
	{
		return false;
	}

	private void MKIPMQTSSPL()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnRefreshButton()
	{
	}

	public void TryAutoRefresh()
	{
	}

	private void SJKFJJFIPEQ()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void JITNJSQRJSO(int QOSKLRJOTKH)
	{
	}

	public void ShowClaimSpinner(bool NTLEJOIRQEQ)
	{
	}

	public void OnDiscordButton()
	{
	}

	public void OnRateButton()
	{
	}

	public void OnSignInButton()
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}
}
