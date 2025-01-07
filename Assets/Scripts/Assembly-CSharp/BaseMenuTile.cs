using UnityEngine;
using UnityEngine.UI;

public class BaseMenuTile : MonoBehaviour
{
	public enum TFFJNIPGISN
	{
		UNSET = 0,
		LOCKED = 1,
		AVAILABLE = 2,
		SELECTED = 3,
		BLOCKED = 4
	}

	public enum OFELPTRRILJ
	{
		SHOP = 0,
		BUILD = 1,
		STORAGE = 2,
		DEVICES = 3
	}

	private TFFJNIPGISN MJPJLPIKQFE;

	public OFELPTRRILJ type;

	private bool LGJLOKEIOME;

	private bool OHQHKQJEILO;

	[SerializeField]
	private RectTransform stateAvailable;

	[SerializeField]
	private RectTransform stateSelected;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image tileBg;

	[SerializeField]
	private GameObject highlight;

	private float OKNHIMHELMG;

	private float OHTKIGLPJRJ;

	private float PLGJREHSFSH;

	[HideInInspector]
	public BaseMenuTileLayout owner;

	private LayoutElement GHPGJRHFNLE;

	private void Awake()
	{
	}

	private void MLNESSGJRME()
	{
	}

	public void SetState(TFFJNIPGISN MHNOIFFONJM, bool KQGHGPEKKTJ = true)
	{
	}

	private void HFSQIKIHTPQ(bool KQGHGPEKKTJ = true)
	{
	}

	public void Unselect(bool KQGHGPEKKTJ = true)
	{
	}

	public void TrySelect(bool KQGHGPEKKTJ = true)
	{
	}

	public void Unlock()
	{
	}

	public void OnClick()
	{
	}

	public void ForceBumpAnimation()
	{
	}

	public RectTransform GetIconRect()
	{
		return null;
	}

	public void SetEnabledClick(bool TIQIMIQITPM)
	{
	}

	public Button GetTileButton()
	{
		return null;
	}

	public void ToggleTileHighlight(bool LKKOESPTGSK)
	{
	}
}
