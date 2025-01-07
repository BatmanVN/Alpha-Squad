using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MenuLimitBreakPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class MLHTPNOQRTP
	{
		public JJHFPNTSRLT.WeaponPart p;

		internal bool _003COnNotEnough_003Eb__1(JJHFPNTSRLT.WeaponPartIdentifier x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TJIKLQETMKH
	{
		public MenuLimitBreakPopup _003C_003E4__this;

		public Vector3 originalpos;

		public float cs;

		public float rotMultiplier;

		public TweenCallback _003C_003E9__2;

		internal void _003CPlayLimitBreakAnimation_003Eb__2()
		{
		}

		internal void _003CPlayLimitBreakAnimation_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class IPFKELTETJH
	{
		public LimitBreakMaterialRequirementCell rq;

		public Vector3 p;

		public int indx;

		public TJIKLQETMKH CS_0024_003C_003E8__locals1;

		internal void _003CPlayLimitBreakAnimation_003Eb__1()
		{
		}

		internal void _003CPlayLimitBreakAnimation_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class IJRQHRNJOER
	{
		public MenuLimitBreakPopup _003C_003E4__this;

		public float k;

		internal void _003COnLimitBreakAnimFinished_003Eb__1(float x)
		{
		}

		internal void _003COnLimitBreakAnimFinished_003Eb__3(LimitBreakBonusElement x)
		{
		}
	}

	private ItemWeapon TSRPFHOJKSG;

	[SerializeField]
	private LimitBreakMaterialRequirementCell prefabMaterial;

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[SerializeField]
	private GameObject prefabBonusSeparator;

	[SerializeField]
	private GameObject prefabBonusSeparatorSmall;

	[SerializeField]
	private LimitBreakBonusElement prefabBonus;

	[SerializeField]
	private LimitBreakProgressCell prefabProgressCell;

	[SerializeField]
	private GameObject popup;

	[SerializeField]
	private RectTransform requirementsParent;

	[SerializeField]
	private Image weaponIcon;

	[SerializeField]
	private Image background;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> backgrounds;

	[SerializeField]
	private Sprite backgroundLegendary;

	[SerializeField]
	private List<LimitBreakMaterialRequirementCell> requirementList;

	[SerializeField]
	private List<LimitBreakBonusElement> activeBonusElements;

	[SerializeField]
	private List<LimitBreakProgressCell> progressCells;

	[SerializeField]
	private GameObject limitBreakButton;

	[SerializeField]
	private GameObject limitBreakBackgroundDisabled;

	[SerializeField]
	private GameObject limitBreakBackgroundEnabled;

	[SerializeField]
	private GameObject viewFewBonuses;

	[SerializeField]
	private GameObject viewManyBonuses;

	[SerializeField]
	private GameObject viewLimitBreaks;

	[SerializeField]
	private RectTransform bonusesParentFew;

	[SerializeField]
	private RectTransform bonusesParentMany;

	[SerializeField]
	private RectTransform progressParent;

	[Space]
	[SerializeField]
	private Text limitBreakButtonLabelEnabled;

	[SerializeField]
	private Text limitBreakButtonLabelDisabled;

	[SerializeField]
	private Text damageNext;

	[SerializeField]
	private Text damageIncrease;

	[SerializeField]
	private RectTransform animationElementParent;

	[SerializeField]
	private RectTransform materialFlyTo;

	[SerializeField]
	private RectTransform weaponParentForAnim;

	[SerializeField]
	private Animator arrowsAnimatorLeft;

	[SerializeField]
	private Animator arrowsAnimatorRight;

	[SerializeField]
	private GameObject continueButton;

	[SerializeField]
	private GameObject particlesExplosion;

	[SerializeField]
	private GameObject particlesSmoke;

	[SerializeField]
	private GameObject[] particlesHit;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private ConstantRotation rotatingBeams;

	[Space]
	[SerializeField]
	private AttributeUIVisualsData attributeVisuals;

	private GameObject TPLPNGGTQTN;

	private global::HIJIFHMGTTR<Vector3> MSSTTSJTLPH;

	private float ORPEQIPFPLM;

	private LootList HNOKQFNSTPP;

	private bool KMOPHEKMHOL;

	private bool FMSORSGNJLO;

	private new void Awake()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public void SetupForItem(ItemWeapon TSRPFHOJKSG)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void GJLIOFJSGFI(int RSGJFSGHFTN)
	{
	}

	private void PJKTSJPJHOR()
	{
	}

	private void EREIEHHRTGM()
	{
	}

	private void SPMENIIKSIG()
	{
	}

	private void FRPOJISFGRG()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnLimitBreakButton()
	{
	}

	private void JGPTJFQQNHK()
	{
	}

	private bool RILHGPKRREP()
	{
		return false;
	}

	private List<JJHFPNTSRLT.WeaponPartIdentifier> OQGQRGGMQMH()
	{
		return null;
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private Vector3 HPKLILEFIMR()
	{
		return default(Vector3);
	}

	private void HGJQKIPMHEP()
	{
	}

	public void PlayLimitBreakAnimation()
	{
	}

	public void OnLimitBreakAnimFinished()
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	[CompilerGenerated]
	private bool KQKPPMQMFFH(JJHFPNTSRLT.RaritySprite QHSMPFPKNMM)
	{
		return false;
	}
}
