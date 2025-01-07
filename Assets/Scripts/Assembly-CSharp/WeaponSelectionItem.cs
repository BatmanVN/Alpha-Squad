using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectionItem : MonoBehaviour
{
	public enum PSLSKNSEENE
	{
		None = 0,
		Active = 1
	}

	private const float IHLTEJSMTJT = 0.4f;

	private const float LIQQOSTSNFN = 0.2f;

	[SerializeField]
	private Image selectedBorder;

	[SerializeField]
	private RectTransform internalTransform;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> backgroundsDefault;

	[SerializeField]
	private Sprite backgroundLegendary;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image backgroundEmpty;

	[SerializeField]
	[Space]
	private Text barText;

	[SerializeField]
	private Text infinityIcon;

	[SerializeField]
	private Image reloadIcon;

	[SerializeField]
	private GameObject magazineIcon;

	[SerializeField]
	private GameObject progressBarContainer;

	[SerializeField]
	private Image progressBar;

	[SerializeField]
	private Image progressBarBackground;

	[Space]
	[SerializeField]
	private Text levelLabel;

	[Space]
	[SerializeField]
	private RectTransform weaponIconContainer;

	[SerializeField]
	private GameObject cooldownOverlay;

	[SerializeField]
	private Text cooldownTimeText;

	[SerializeField]
	private Image cooldownCircleImage;

	[SerializeField]
	private Image weaponIcon;

	[SerializeField]
	private Sprite progressBarRegular;

	[SerializeField]
	private Sprite progressBarSelected;

	[SerializeField]
	private Sprite agentWeaponCooldownTimerSprite;

	[SerializeField]
	private CanvasGroup reloadLoadingCanvasGroup;

	[SerializeField]
	private Image reloadLoadingImage;

	[SerializeField]
	private GameObject disabledOverlay;

	[SerializeField]
	private Text disabledTimeText;

	[SerializeField]
	private Image disabledCircleImage;

	public WeaponInfo weaponInfo;

	public PSLSKNSEENE state;

	private float OJLRRLFJOEF;

	private bool ILSTPSQKNNP;

	private float HOOORFHKGQO;

	private bool ORIOMITNRRS;

	private int IJMGTMIFLQR;

	private int PSPJIJNTMOI;

	public void Setup(WeaponInfo JFOHOOPNEKE)
	{
	}

	public bool IsEmptyItem()
	{
		return false;
	}

	public void SetupEmpty()
	{
	}

	private void LQKTMEIREQP(bool SJHSLENLRSG)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void JSILOOQIGFF(WeaponInfo QHNGKJKPMOH)
	{
	}

	private void GIKGLPKGRQO()
	{
	}

	private void Update()
	{
	}

	public void OnPointerDown()
	{
	}

	public bool ThisWeaponSelected()
	{
		return false;
	}

	public void OnPointerUp()
	{
	}

	public bool CanReload()
	{
		return false;
	}

	public bool CanSelect()
	{
		return false;
	}

	private bool OOEIGMHSEHG()
	{
		return false;
	}

	private bool NOSNQOTRGOJ()
	{
		return false;
	}

	public void RefreshState()
	{
	}

	public void SetState(PSLSKNSEENE PTHIFGMSJIP)
	{
	}

	public void SetSelected(bool GLSLKMMJIKL)
	{
	}

	[CompilerGenerated]
	private bool FFKHONKHETR(JJHFPNTSRLT.RaritySprite QHSMPFPKNMM)
	{
		return false;
	}
}
