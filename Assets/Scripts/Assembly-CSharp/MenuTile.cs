using UnityEngine;
using UnityEngine.UI;

public class MenuTile : MonoBehaviour
{
	public enum QGIJSFQPNRQ
	{
		UNSET = 0,
		LOCKED = 1,
		AVAILABLE = 2,
		SELECTED = 3,
		BLOCKED = 4
	}

	public enum ONITTJRRQRK
	{
		SHOP = 0,
		GLOBAL = 1,
		OPERATIONS = 2,
		INVENTORY = 3,
		START_GAME = 4
	}

	public ONITTJRRQRK type;

	[SerializeField]
	private RectTransform stateLocked;

	[SerializeField]
	private RectTransform stateAvailable;

	[SerializeField]
	private RectTransform stateSelected;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private GameObject lockLevel;

	[SerializeField]
	private GameObject[] blackFridayEffects;

	[SerializeField]
	private Sprite spriteBlackFriday;

	[SerializeField]
	private GameObject[] disableIfLocked;

	[Space]
	public QGIJSFQPNRQ state;

	private QGIJSFQPNRQ PIONPMOSGKM;

	[HideInInspector]
	public MenuTileLayout owner;

	private LayoutElement GHPGJRHFNLE;

	private float OHTKIGLPJRJ;

	private float PLGJREHSFSH;

	private bool OHQHKQJEILO;

	private float KFRORIPSIPM;

	private bool LGJLOKEIOME;

	private Sprite IFEJMSLJRKI;

	private void MLNESSGJRME()
	{
	}

	private void PTMQEFIFSOS()
	{
	}

	private void LNJRREQQGGF()
	{
	}

	private void SQSRFREQGJE()
	{
	}

	private void Awake()
	{
	}

	public void SetState(QGIJSFQPNRQ MHNOIFFONJM, bool KQGHGPEKKTJ = true)
	{
	}

	public void Unselect(bool KQGHGPEKKTJ = true)
	{
	}

	public void TrySelect(bool KQGHGPEKKTJ = true)
	{
	}

	public bool IsBlocked()
	{
		return false;
	}

	public void Unlock()
	{
	}

	private void HFSQIKIHTPQ(bool KQGHGPEKKTJ = true)
	{
	}

	private void LNLPNJTHORT()
	{
	}

	private void QEKRONPSJSL()
	{
	}

	public void OnClick()
	{
	}

	public void SetEnabledClick(bool TIQIMIQITPM)
	{
	}
}
