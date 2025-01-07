using UnityEngine;
using UnityEngine.UI;

public class ScrapRewardCell_OLD : MonoBehaviour
{
	public enum LFPNRHISSGT
	{
		CASH = 0,
		MATS = 1,
		WEAPON_SCRAP = 2,
		WRENCHES = 3,
		WEAPON_PARTS = 4,
		WEAPON_CHEST_TOKENS = 5,
		RARE_CHEST_TOKENS = 6,
		ATTRIBUTE_SHARDS = 7
	}

	public LFPNRHISSGT type;

	private WeaponData.OHHQFFINRQH QJLIEETNMRM;

	private JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF;

	private int ISLTSKEPJPI;

	private JJHFPNTSRLT.WeaponPartIdentifier JSFNHPQTFGM;

	[SerializeField]
	private Image cashIcon;

	[SerializeField]
	private Image weaponPartIcon;

	[SerializeField]
	private Image weaponPartBackground;

	[SerializeField]
	private Text labelAmount;

	[SerializeField]
	private GameObject weaponChestTokens;

	[SerializeField]
	private Image weaponChestTokensBg;

	[SerializeField]
	private Image weaponChestTokensIcon;

	[SerializeField]
	private GameObject scrapIconparent;

	[SerializeField]
	private Image weaponScrapIcon;

	[SerializeField]
	private GameObject wrenchIcon;

	[SerializeField]
	private Image backgroundCash;

	[SerializeField]
	private Image scrapCountBg;

	[Space]
	[SerializeField]
	private Sprite sprtieCountBgWrenches;

	[SerializeField]
	private Sprite spriteCountBgWeaponChestTokens;

	[SerializeField]
	private Sprite spriteCountBgRareChestTokens;

	[SerializeField]
	private Sprite sprtieCountBgParts;

	[Space]
	[SerializeField]
	private Text labelPurchasableAmount;

	[SerializeField]
	private Text labelPurchasePrice;

	[SerializeField]
	private Image coverPurchasable;

	[SerializeField]
	private GameObject checkmarkPurchased;

	[SerializeField]
	private GameObject outlinePurchasing;

	[Space]
	[SerializeField]
	private Sprite spriteOutlinePurchaseBlock;

	[SerializeField]
	private Sprite spriteCoverPurchaseBlock;

	[SerializeField]
	private Sprite spriteOutlinePurchaseTools;

	[SerializeField]
	private Sprite spriteCoverPurchaseTools;

	[SerializeField]
	private Image coverPurchase;

	[SerializeField]
	private Image outlinePurchase;

	[SerializeField]
	private RectTransform purchasePosTools;

	private bool QEGIKENFOJF;

	public CurrencyData current;

	public CurrencyData price;

	public void SetupCash(int ISLTSKEPJPI)
	{
	}

	public void SetupWeaponScrap(WeaponData.OHHQFFINRQH EMKNPKTIJPF, int ISLTSKEPJPI)
	{
	}

	public void SetupWrench(int ISLTSKEPJPI)
	{
	}

	public void SetupWeaponParts(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH, int ISLTSKEPJPI)
	{
	}

	public void SetupWeaponChestTokens(int ISLTSKEPJPI)
	{
	}

	public void SetupRareChestTokens(int ISLTSKEPJPI)
	{
	}

	public void SetupAttributeShards(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL, int ISLTSKEPJPI)
	{
	}

	public bool TryUpdate(LFPNRHISSGT EOOEIROQJOE, int ISLTSKEPJPI, WeaponData.OHHQFFINRQH FIQMIIMGTNE, JJHFPNTSRLT.WeaponPartIdentifier PLKFROSLRHP)
	{
		return false;
	}

	private void TKSTHFRSHSH()
	{
	}

	public bool IsPurchasable()
	{
		return false;
	}

	public bool ShouldAdd()
	{
		return false;
	}

	public void PlayAppear(float PRRKGRQILFR = 0.1f)
	{
	}

	public void PlayValueChange(float PRRKGRQILFR = 0f)
	{
	}

	public void OnClick()
	{
	}
}
