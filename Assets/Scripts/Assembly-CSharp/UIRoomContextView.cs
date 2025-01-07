using UnityEngine;
using UnityEngine.UI;

public class UIRoomContextView : MonoBehaviour
{
	public enum RTLMQFFRPNM
	{
		INVALID = 0,
		HALL = 1,
		CRAFT_ROOM = 2,
		DONATE_ROOM = 3,
		GENERAL_SHOP = 4,
		MISSION_ROOM = 5,
		HONOR_SHOP = 6,
		LABORATORY = 7
	}

	private UIRoomContext FNJLLHKNGOR;

	private int IFROIFJGPPK;

	private int KEJSEINNIEM;

	public RTLMQFFRPNM contextType;

	[SerializeField]
	private Text roomName;

	[SerializeField]
	private Text roomLevel;

	[SerializeField]
	protected Button ctaButton;

	[SerializeField]
	protected UITextTimer resetTimer;

	[SerializeField]
	private Image ribbon;

	[Space]
	[SerializeField]
	private Button debugButton;

	[SerializeField]
	private GameObject roomDebug;

	[SerializeField]
	private Text debugText;

	public void Setup(UIRoomContext FNJLLHKNGOR)
	{
	}

	public void Show(int OJJLFPMNEHN)
	{
	}

	protected virtual void KKPPHMIEOSK()
	{
	}

	public void UpdateRoomRibbon(Sprite GROQQGSIEKK)
	{
	}

	public void ChangeDebugRoomLevel(bool PITFEETNKEK)
	{
	}

	private void PFSJENORKJK()
	{
	}

	private void TQRHKQTENIK()
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}
}
