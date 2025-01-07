using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class InventoryScrapPanel : UIPanel
{
	private enum KNMFIPIEKGK
	{
		UNSET = 0,
		WEAPONS = 1,
		GEAR = 2
	}

	[Serializable]
	private struct AnalyticsContext
	{
		public int levelIndex;

		public ItemWeapon.AnalyticsContext[] items;
	}

	[CompilerGenerated]
	private sealed class QISEJKENLIG
	{
		public int i;

		internal bool _003CUpdateReward_003Eb__2(ScrapItemCell c)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class THQIMRNRTNR
	{
		public int i;

		internal bool _003CUpdateReward_003Eb__5(ScrapItemCell c)
		{
			return false;
		}
	}

	private const float ISRFJNRGEFR = 0.02f;

	public const int SALVAGE_UNLOCK_LEVEL = 9;

	[NonSerialized]
	public MenuViewInventory owner;

	[SerializeField]
	private ScrapWeaponCell prefabWeaponCell;

	[SerializeField]
	private ScrapGearCell prefabGearCell;

	[SerializeField]
	private ScrapRewardList rewardList;

	[SerializeField]
	private RectTransform cellParentWeapons;

	[SerializeField]
	private RectTransform cellParentGear;

	[SerializeField]
	private RectTransform scrollContent;

	[SerializeField]
	private ScrapAreYouSure confirmPopup;

	[Space]
	[SerializeField]
	private Toggle[] qualityTogglesWeapon;

	[SerializeField]
	private Toggle[] qualityTogglesGear;

	[SerializeField]
	private Transform particleParent;

	[SerializeField]
	private GameObject salvagePriceBlock;

	[SerializeField]
	private Text scrapPriceLabel;

	[SerializeField]
	private Text flavorLabel;

	[SerializeField]
	private Text salvagedResourcesLabel;

	[SerializeField]
	private Button scrapButton;

	[SerializeField]
	private Color colorButtonShadowActive;

	[SerializeField]
	private Color colorButtonShadowInactive;

	[SerializeField]
	private Image cogImage;

	[SerializeField]
	private Shadow scrapButtonShadow;

	[SerializeField]
	private NicerOutline scrapButtonOutline;

	[SerializeField]
	private GameObject noItemsText;

	[SerializeField]
	private Material scrapMaterial;

	[SerializeField]
	private GameObject tabWeapons;

	[SerializeField]
	private GameObject tabGear;

	[SerializeField]
	private GameObject qualityListWeapons;

	[SerializeField]
	private GameObject qualityListGear;

	[SerializeField]
	private GameObject particlesExplosion;

	[SerializeField]
	private GameObject particlesSmoke;

	public static Action<ItemWeapon> OnItemSalvaged;

	private bool NKRTRMTIKGK;

	private List<ScrapItemCell> PHTKEJTOQRG;

	private Text[] PGLOMJKFJSR;

	private Text[] RSJFONHPMMI;

	private ItemWeapon NKJIILGPIMM;

	private KNMFIPIEKGK OIGIHGHENJK;

	private KNMFIPIEKGK OTTNJNIPHQE;

	private bool JJGMHTFHIML;

	private bool KPNMLLRMJFO;

	private static string JKPNPHQEOKN;

	public bool GQHKQNHOTPH => false;

	protected override void MGKPMPHSLFR()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ERJQOPNSKIQ()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public static void OpenGearTab()
	{
	}

	public static void OpenWeaponTab()
	{
	}

	private void NGHFQRREIJN()
	{
	}

	private void MONOIPIREQF(bool RHOIJKGIEEP = false)
	{
	}

	public void SetOpenAfterClose(ItemWeapon FKKJGTNIISP)
	{
	}

	private void MEOGJQHGNGL()
	{
	}

	public void OnCellClicked(ScrapItemCell GGOKJRGSMRT)
	{
	}

	private void ISGQNIHTKRP(ScrapWeaponCell GGOKJRGSMRT)
	{
	}

	private void KRKGTHRMTPH(ScrapGearCell GGOKJRGSMRT)
	{
	}

	public void OnScrapButton()
	{
	}

	public void OnExitButton()
	{
	}

	public void OnCheckmark(int PSPJIJNTMOI)
	{
	}

	public void OnTabWeapons()
	{
	}

	public void OnTabGears()
	{
	}

	public void SelectActiveCellsOfRarity(int MOTTITEELQF, bool ILSTPSQKNNP, bool HJTSKKHKFNG = true)
	{
	}

	private void JQGTRKRIHHJ()
	{
	}

	private void POLMTMFFPNE(bool GTMLTMHONOK = true)
	{
	}

	public void SelectCellForWeapon(ItemWeapon QTRSFNTGTSR)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	[CompilerGenerated]
	internal static void IQSPKNMJTPF(ref Text[] LNQGGGGHHKE, Toggle[] EPTLITTQPHI)
	{
	}

	[CompilerGenerated]
	private void ELMTERISJIK()
	{
	}

	[CompilerGenerated]
	private void ITJNORKSJSK(ScrapRewardCell HNLHQPIFJNS)
	{
	}

	[CompilerGenerated]
	private bool IGNFGHPITQE(ScrapItemCell GGOKJRGSMRT)
	{
		return false;
	}

	[CompilerGenerated]
	internal static void LGKMQIQSHPH(GameObject EGHSSGOITHG, bool HHRGQEQGGIS)
	{
	}
}
