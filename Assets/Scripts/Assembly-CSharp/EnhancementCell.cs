using System;
using UnityEngine;
using UnityEngine.UI;

public class EnhancementCell : MonoBehaviour
{
	private enum MQNNISEFLGG
	{
		AVAILABLE = 0,
		SELECTED = 1,
		LOCKED = 2,
		BLOCKED = 3
	}

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private Image iconUltimate;

	[SerializeField]
	private Image backgroundImageUltimate;

	[SerializeField]
	private Image lockImage;

	[SerializeField]
	private Image availableImage;

	[SerializeField]
	private Sprite backgroundRegular;

	[SerializeField]
	private Sprite backgroundAvailable;

	[SerializeField]
	private Sprite backgroundLocked;

	[SerializeField]
	private Sprite backgroundSelected;

	[SerializeField]
	private Sprite backgroundUltimate;

	[SerializeField]
	private Sprite backgroundUltimateLocked;

	[SerializeField]
	private Sprite backgroundUltimateAvailable;

	[SerializeField]
	private Sprite backgroundUltimateUpgrade;

	[SerializeField]
	private Sprite iconAvailableRegular;

	[SerializeField]
	private Sprite iconAvailableUltimate;

	[SerializeField]
	private Sprite lockRegular;

	[SerializeField]
	private Sprite lockUltimate;

	[Space]
	[SerializeField]
	private GameObject voverLock;

	[SerializeField]
	private GameObject voverAvailable;

	[SerializeField]
	private GameObject voverSelected;

	[SerializeField]
	private GameObject voverUltimate;

	[SerializeField]
	private GameObject voverUltimateUpgrade;

	[SerializeField]
	private GameObject voverGlobal;

	[SerializeField]
	private GameObject vunderAvailable;

	[SerializeField]
	private GameObject vunderAvailableUltimate;

	[Space]
	[SerializeField]
	private RectTransform iconLocationRegular;

	[SerializeField]
	private RectTransform iconLocationUltimate;

	[SerializeField]
	private Vector2 voverSelectedLocationUltimate;

	[SerializeField]
	private GameObject upgradeLevel;

	[SerializeField]
	private GameObject upgradeLevelMaxOverlay;

	[SerializeField]
	private Text labelUpgradeLevel;

	[NonSerialized]
	public EnhancementTierBlock owner;

	private bool TEILKPETLEJ;

	private bool ILSTPSQKNNP;

	private bool RLMMKKFHREK;

	private int LOKRLJSMJQI;

	private RTMJNJJLEGL NSORQMEFLIH;

	private Enhancement JPEEEILROQN;

	private MQNNISEFLGG MJPJLPIKQFE;

	private Agent IFLMHEQTKLS;

	private bool GQLOTPOHOTF;

	public void Setup(Enhancement NGOKJKTIJMM, Agent OFFERRTFLNG, bool FNTITJPHIOI, int OHILGIPFTNM, bool GMGMEKQRHJS, bool EFIEKJNTSON, bool HRQQKMHIGQM = true, bool TTTFREEOGQP = true)
	{
	}

	private void KQTQERNLJSS()
	{
	}

	public void OnClick()
	{
	}

	private void OnSelect()
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public bool IsSelected()
	{
		return false;
	}
}
