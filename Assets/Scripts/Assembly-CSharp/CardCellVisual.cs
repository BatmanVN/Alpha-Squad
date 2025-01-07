using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CardCellVisual : CellVisual
{
	[SerializeField]
	private GameObject viewCurrencyBasic;

	[SerializeField]
	private GameObject viewBasicLargeIcon;

	[SerializeField]
	private GameObject viewWeapon;

	[SerializeField]
	private GameObject viewWeaponPart;

	[SerializeField]
	private GameObject viewWeaponScraps;

	[SerializeField]
	private GameObject viewAgentTags;

	[SerializeField]
	private GameObject viewEventCurrency;

	[SerializeField]
	private GameObject viewAgentShards;

	[SerializeField]
	private GameObject viewAgentSkin;

	[SerializeField]
	private GameObject viewGear;

	[SerializeField]
	protected Image background;

	[SerializeField]
	private GameObject stickerNew;

	[Space]
	[SerializeField]
	private Image iconBasic;

	[SerializeField]
	private Text labelBasic;

	[SerializeField]
	private Image agentTagIcon;

	[SerializeField]
	private Text labelAgentTagCount;

	[SerializeField]
	private Image iconBasicLarge;

	[SerializeField]
	private Text labelBasicLarge;

	[SerializeField]
	protected WeaponRarityStars weaponStars;

	[SerializeField]
	private Text labelWeaponTitle;

	[SerializeField]
	private Text labelWeaponCP;

	[SerializeField]
	private Text labelWeaponLvl;

	[SerializeField]
	private Image weaponIcon;

	[SerializeField]
	private Text labelGearTitle;

	[SerializeField]
	private Image gearIcon;

	[SerializeField]
	private Text labelScrapType;

	[SerializeField]
	private Text labelScrapCount;

	[SerializeField]
	private Image scrapicon;

	[SerializeField]
	private Image toolsicon;

	[SerializeField]
	private Image bulletIcon;

	[SerializeField]
	private Image scrapCog;

	[SerializeField]
	private Image scrapBackground;

	[SerializeField]
	private Text labelPartTitle;

	[SerializeField]
	private Text labelPartCount;

	[SerializeField]
	private Image iconWeaponpart;

	[SerializeField]
	private Image materialsIcon;

	[SerializeField]
	private Image iconSkin;

	[SerializeField]
	private Image eventCurrencyIcon;

	[SerializeField]
	private Text eventCurrencyAmountLabel;

	[SerializeField]
	private Image iconAgentShards;

	[SerializeField]
	private Text labelAgentShardsAmount;

	private LootElement EGLSRLSPNSO;

	public void Setup(LootElement INNLJIGRFOG, bool TGLFHRJKLOS = false)
	{
	}

	protected virtual void ILKNMFOIFFN()
	{
	}

	public void PlayBoostAnim()
	{
	}

	public override Image GetBackground()
	{
		return null;
	}

	[CompilerGenerated]
	private bool ESGITFLRNOH(SkinData HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private void KLOMOLTGMFN(float HNLHQPIFJNS)
	{
	}
}
