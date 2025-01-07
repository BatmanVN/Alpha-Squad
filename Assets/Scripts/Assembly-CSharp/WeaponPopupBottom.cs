using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPopupBottom : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class TGGTQFLIOLG
	{
		public JJHFPNTSRLT.WeaponPartIdentifier wpid;

		internal bool _003CGetLabelParts_003Eb__1(JJHFPNTSRLT.WeaponPart x)
		{
			return false;
		}
	}

	[SerializeField]
	private RectTransform maxUpgradeReachedRect;

	[SerializeField]
	private GameObject limitBreakButton;

	[SerializeField]
	private GameObject rankUpButton;

	[SerializeField]
	private GameObject empowerButton;

	[SerializeField]
	private GameObject buyButton;

	[SerializeField]
	private RectTransform upgradeButtonRect;

	[SerializeField]
	public Button upgradeButton;

	[SerializeField]
	public Button maxOutButton;

	[SerializeField]
	public Button downgradebutton;

	[SerializeField]
	public Button equipButton;

	[SerializeField]
	private GameObject upgradeBlock;

	[SerializeField]
	private Text labelLimitBreak;

	[SerializeField]
	private GameObject useBlock;

	[SerializeField]
	private Text buyPrice;

	[SerializeField]
	private Text buyLabel;

	[SerializeField]
	private Image priceIcon;

	[SerializeField]
	private GameObject priceIconParent;

	[SerializeField]
	private GameObject blockDowngrade;

	[SerializeField]
	private GameObject blockMaxOut;

	[SerializeField]
	private GameObject blockEquip;

	[SerializeField]
	private GameObject visualEquipAvailable;

	[SerializeField]
	private GameObject visualEquipUnavailable;

	[SerializeField]
	private GameObject visualDowngradeUnavailable;

	[SerializeField]
	private GameObject visualDowngradeAvailable;

	[SerializeField]
	private GameObject upgradeRequirements;

	[SerializeField]
	private Image iconScrap;

	[SerializeField]
	private Image iconBgParts;

	[SerializeField]
	private Text labelScraps;

	[SerializeField]
	private Text labelWrenches;

	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private Text labelParts;

	[SerializeField]
	public RectTransform scrapBlock;

	[SerializeField]
	public RectTransform wrenchesBlock;

	[SerializeField]
	public RectTransform cashBlock;

	[SerializeField]
	public RectTransform partBlock;

	[SerializeField]
	private GameObject reqScraps;

	[SerializeField]
	private GameObject reqCash;

	[SerializeField]
	private GameObject reqTools;

	[SerializeField]
	private GameObject reqParts;

	[Space]
	[SerializeField]
	private Sprite iconGem;

	[SerializeField]
	private Sprite iconCash;

	private global::HIJIFHMGTTR<Vector2> LFKGHLPMRSL;

	private global::HIJIFHMGTTR<Vector2> TOOFSJKMTGJ;

	private global::HIJIFHMGTTR<Vector2> PJRESHIJFIF;

	private ItemWeapon TSRPFHOJKSG;

	public void Setup(ItemWeapon TSRPFHOJKSG, bool KQGHGPEKKTJ = true, bool RMEGMGIRQIP = false)
	{
	}

	private string LMMHESLEESN(LootList GMONPNLHTLM, string FOJNSILTRNK, string GOJHMNJTRMM)
	{
		return null;
	}

	public void SetupForPurchase(bool TPTKFISFNGT, int SJNSPJGESHJ)
	{
	}

	public void OnRequirementsToolsClicked()
	{
	}

	public void OnRequirementsScrapClicked()
	{
	}

	public void OnRequirementsCashClicked()
	{
	}

	public void JumpScraps()
	{
	}

	public void JumpCash()
	{
	}

	public void JumpTools()
	{
	}

	public GameObject GetEquipButton()
	{
		return null;
	}

	public GameObject GetDowngradeButton()
	{
		return null;
	}
}
