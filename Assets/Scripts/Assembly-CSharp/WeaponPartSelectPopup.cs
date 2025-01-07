using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPartSelectPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class TKNLIIIQRSS
	{
		public int idx;

		public WeaponPartSelectPopup _003C_003E4__this;

		internal void _003CSetupSize_003Eb__0()
		{
		}

		internal void _003CSetupSize_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class QFLRLPGSJHT
	{
		public WeaponData.OHHQFFINRQH cat;

		internal int _003CSetupInternal_003Eb__2(JJHFPNTSRLT.WeaponPart x)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class OMGJPFKRRGL
	{
		public WeaponData.OHHQFFINRQH cat;

		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public CurrencyData.WeaponParts allWeaponParts;

		internal bool _003CAnyLimitBreakableWeaponsInCat_003Eb__1(LootElement x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FNIRPGLEKEQ
	{
		public JJHFPNTSRLT.WeaponPartIdentifier id;

		internal bool _003CSetupParts_003Eb__1(JJHFPNTSRLT.WeaponPart x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class JGEIPOMKGMF
	{
		public JJHFPNTSRLT.WeaponPartIdentifier id;

		internal int _003CSetupParts_003Eb__2(JJHFPNTSRLT.WeaponPart x)
		{
			return 0;
		}
	}

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private GameObject claimButton;

	[Space]
	[SerializeField]
	private Text labelTitle;

	[SerializeField]
	private Text labelLeft;

	[SerializeField]
	private List<JJHFPNTSRLT.WeaponCategoryGameObject> categoryButtons;

	[SerializeField]
	private RectTransform infoNotSelected;

	[SerializeField]
	private RectTransform infoSelected;

	[SerializeField]
	private GameObject craftButton;

	[SerializeField]
	private GameObject claimButtonEnabled;

	[SerializeField]
	private GameObject claimButtonDisabled;

	[SerializeField]
	private GameObject craftButtonPrestigeIcon;

	[SerializeField]
	private GameObject honorButton;

	[SerializeField]
	private GameObject honorButtonDisabled;

	[SerializeField]
	private List<InventoryWeaponPartCell> weaponParts;

	[SerializeField]
	private GameObject partSelectInfoField;

	[SerializeField]
	private Text labelSelectEnabled;

	[SerializeField]
	private Text labelSelectDisabled;

	[SerializeField]
	private Text labelCraftPrice;

	[SerializeField]
	private Text labelHonorPrice;

	[SerializeField]
	private Text labelHonorPriceDisabled;

	[SerializeField]
	private float sizeRegular;

	[SerializeField]
	private float sizeExtended;

	[SerializeField]
	private LayoutElement infoLayout;

	[SerializeField]
	private GameObject blockPrice;

	[SerializeField]
	private GameObject blockPriceDisabled;

	[SerializeField]
	private Image iconPrice;

	[SerializeField]
	private Image iconPriceDisabled;

	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private Text labelPriceDisabled;

	private WeaponData.OHHQFFINRQH PRPNOGSSSLJ;

	private int SGNNHEROROI;

	private JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF;

	private Action<List<JJHFPNTSRLT.WeaponPart>> RKFRINSKQTT;

	private bool JPIHONGTEFE;

	private bool PTOLNNSGFQO;

	private bool ONSHSOEGIPO;

	private List<JJHFPNTSRLT.WeaponPart> IMNHIJNTPJP;

	private bool MNKFQSRTERQ;

	private static readonly int SLQLNOHLOHM;

	public static bool hideOnClaim;

	public static void Open(int ISLTSKEPJPI, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, Action<List<JJHFPNTSRLT.WeaponPart>> RKFRINSKQTT, string OLPSGPIMEJE = null, string TFILGIFJKJH = null, bool NLRHMFFEMFG = false, int SJNSPJGESHJ = -1, bool HQHRSELQJMR = false, bool KRKRSKOGSRP = true)
	{
	}

	public static void OpenForClanShop(int ISLTSKEPJPI, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, Action<List<JJHFPNTSRLT.WeaponPart>> RKFRINSKQTT, int SJNSPJGESHJ = -1, string OLPSGPIMEJE = null)
	{
	}

	private void NGHFQRREIJN(int ISLTSKEPJPI, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, bool NLRHMFFEMFG = false, bool HQHRSELQJMR = false)
	{
	}

	private void FLTPNGGSTMO()
	{
	}

	private void PNKNJHHPQHH()
	{
	}

	private void FNFRKMFSQMK()
	{
	}

	private void QSSSMOKGEOF(bool TEENRGPFHKL)
	{
	}

	public static bool AnyLimitBreakableWeaponsInCat(WeaponData.OHHQFFINRQH OJTGHRGORLS, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
		return false;
	}

	private void TOMJPGLKGHQ(bool TEENRGPFHKL)
	{
	}

	public void OnPartClicked(int PSPJIJNTMOI)
	{
	}

	public void OnPartAdd(int PSPJIJNTMOI)
	{
	}

	public void OnPartRemove(int PSPJIJNTMOI)
	{
	}

	private void QROTGJEJISH()
	{
	}

	public void SetPrice(int SJNSPJGESHJ, Sprite ITRKNMFTGIG, Vector3 TMSKFKKQNRO)
	{
	}

	public void OnCategoryButtonClicked(int FMRQENKSKRO)
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnClaimButton()
	{
	}

	public void OnDisabledClaimButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private FloatingErrorText KMQIMTNTOMN(string HETQTIKJGNI, Transform HSSNSPQEIGR = null)
	{
		return null;
	}

	[CompilerGenerated]
	private void RLOOJHFNQMG(Transform GGOKJRGSMRT, WeaponData.OHHQFFINRQH OJTGHRGORLS)
	{
	}

	[CompilerGenerated]
	private bool JMNTLPFQIKJ(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH)
	{
		return false;
	}
}
