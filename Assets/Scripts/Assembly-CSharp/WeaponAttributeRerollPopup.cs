using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class WeaponAttributeRerollPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class OIFJNSRRNHM
	{
		public ItemWeapon.Bonus b;

		internal bool _003CRerollAnimationFinished_003Eb__0(JJHFPNTSRLT.PredefinedWeaponBonus x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TKQSERQGNFP
	{
		public CanvasGroup block;

		internal void _003CHideAllViews_003Eb__2()
		{
		}
	}

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[Space]
	[SerializeField]
	private WeaponInfoBonusElement prefabBonusElement;

	[SerializeField]
	private GameObject closeButton;

	[SerializeField]
	private GameObject infoButton;

	[Space]
	[SerializeField]
	private CanvasGroup blockRegular;

	[SerializeField]
	private CanvasGroup blockAnimation;

	[SerializeField]
	private CanvasGroup blockCompleted;

	[SerializeField]
	private Text labelPriceShards;

	[SerializeField]
	private Text labelPriceCash;

	[SerializeField]
	private UICurrencyElement shardCurrencyVisual;

	[SerializeField]
	private WeaponInfoBonusElement bonusElement;

	[SerializeField]
	private RectTransform rerollButton;

	[SerializeField]
	private RectTransform blockCash;

	[SerializeField]
	private RectTransform blockShards;

	[SerializeField]
	private Text labelRerollInfo;

	[SerializeField]
	private GameObject blockTutorialList;

	[SerializeField]
	private Image rerollProgressBar;

	[SerializeField]
	private WeaponInfoBonusElement animationBonusElement;

	[SerializeField]
	private AnimatedLabelText animatedText;

	[SerializeField]
	private RectTransform otherBonusesParent;

	[SerializeField]
	private WeaponInfoBonusElement previousBonus;

	[SerializeField]
	private WeaponInfoBonusElement newBonus;

	[SerializeField]
	private Image bgPreviousSelected;

	[SerializeField]
	private Image bgPreviousUnselected;

	[SerializeField]
	private Image bgNewSelected;

	[SerializeField]
	private Image bgNewUnselected;

	[SerializeField]
	private GameObject cpArrowBlock;

	[SerializeField]
	private Image cpArrow;

	[SerializeField]
	private Sprite cpArrowUp;

	[SerializeField]
	private Sprite cpArrowDown;

	[SerializeField]
	private Sprite cpArrowSame;

	[SerializeField]
	private Text labelCombatPowerTotal;

	[SerializeField]
	private Text labelCombatPowerChange;

	[SerializeField]
	private GameObject completedBlockAttributePower;

	[SerializeField]
	private GameObject completedBlockOtherBonuses;

	[SerializeField]
	private GameObject completedBlockBonusSelect;

	[SerializeField]
	private GameObject completedBlockInfoBlock;

	[SerializeField]
	private GameObject completedBlockButtonBlock;

	[SerializeField]
	private List<GameObject> attributeSelectParticles;

	[SerializeField]
	private GameObject acceptButtonEnabled;

	[SerializeField]
	private GameObject acceptButtonDisabled;

	private int PQPGFQQNQKQ;

	private int JGJKRTGMSMP;

	private ItemWeapon LENQOPNFMTG;

	private LootElement GIJGIMNHKOF;

	private LootElement GNOOTTGPRTE;

	private Tween LMMTRONPIGF;

	private float GRTPFGTESGT;

	private bool OQSOEKFNEQK;

	private global::HIJIFHMGTTR<Vector2> LKNOLNKFKMK;

	private global::HIJIFHMGTTR<Vector2> JRLOQJSOQRN;

	public static void Open(ItemWeapon QGPIMPLNPPI, int IRFHGEHFHGT)
	{
	}

	private bool MLNESSGJRME(ItemWeapon QGPIMPLNPPI, int IRFHGEHFHGT)
	{
		return false;
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnRerollButton()
	{
	}

	public void OnInfoButton()
	{
	}

	public void OnCancelRerollButton()
	{
	}

	public void OnSelectNewAttribute()
	{
	}

	public void OnSelectOldAttribute()
	{
	}

	public void OnAcceptButton()
	{
	}

	public void OnClickShards()
	{
	}

	public void OnClickCash()
	{
	}

	private void PFFRGILMJJH(RectTransform QIMGEOQLLHO, ref global::HIJIFHMGTTR<Vector2> LMQPNNFTNQJ)
	{
	}

	private bool TNHENMLLJNJ()
	{
		return false;
	}

	private void FNPQSMRPOGM()
	{
	}

	private void JSKOKNIMTIM()
	{
	}

	private void HTPHFMSJPHM()
	{
	}

	private void HRPOOMOOKPO(bool KQGHGPEKKTJ)
	{
	}

	private void GMQMESGSEMS(bool KQGHGPEKKTJ)
	{
	}

	private void NGRGMRJTPMP(bool KQGHGPEKKTJ)
	{
	}

	private void IMTMLFTOPSL(bool KQGHGPEKKTJ)
	{
	}

	private void TKGEJTJFSSF()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	[CompilerGenerated]
	private void TSKNOHJQGLM(float HNLHQPIFJNS)
	{
	}

	[CompilerGenerated]
	internal static void TOHLSRQIJNH(CanvasGroup QIMGEOQLLHO)
	{
	}

	[CompilerGenerated]
	internal static void KJSTKQJSNTL(CanvasGroup QIMGEOQLLHO)
	{
	}

	[CompilerGenerated]
	internal static Tween NQTNGSFTKPH(GameObject QIMGEOQLLHO, float PRRKGRQILFR)
	{
		return null;
	}

	[CompilerGenerated]
	internal static void KTELHRETKIT(GameObject QIMGEOQLLHO)
	{
	}

	[CompilerGenerated]
	private void IJNQFEIIOKO()
	{
	}
}
