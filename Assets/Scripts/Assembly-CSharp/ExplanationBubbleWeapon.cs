using UnityEngine;
using UnityEngine.UI;

public class ExplanationBubbleWeapon : ExplanationBubble
{
	[Space]
	[SerializeField]
	private GameObject blockFeatured;

	[SerializeField]
	private GameObject blockUncommon;

	[SerializeField]
	private GameObject blockExceptional;

	[SerializeField]
	private GameObject blockRare;

	[SerializeField]
	private GameObject blockEpic;

	[SerializeField]
	private GameObject blockLegendary;

	[Space]
	[SerializeField]
	private Text labelChanceCommon;

	[SerializeField]
	private Text labelChanceUncommon;

	[SerializeField]
	private Text labelChanceExceptional;

	[SerializeField]
	private Text labelChanceRare;

	[SerializeField]
	private Text labelChanceEpic;

	[SerializeField]
	private Text labelChanceFeatured;

	[SerializeField]
	private Text labelChanceLegendary;

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private Image imgBackgroundFeatured;

	[SerializeField]
	private Image imgIconFeatured;

	[SerializeField]
	private WeaponRarityStars starsFeatured;

	[SerializeField]
	private GameObject chanceRibbon;

	public void Setup(int QJQINTKJTJQ, LootConfigData.RarityWeights QFJFSEMOOEH, int PEEOSEPOEEK, JJHFPNTSRLT.PQRIQGIOGQT KHFHOORTPOS, JPHMLSJQLNL ROHJRRLKFHR, bool EHROFTHEJRS = false, int HPISMELGNIJ = -1)
	{
	}
}
