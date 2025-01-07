using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class ChestOpenPopupSelect : UIPopup
{
	[CompilerGenerated]
	private sealed class HFMFNQPOIMI
	{
		public List<JJHFPNTSRLT.WeaponPartIdentifier> weaponParts;

		internal bool _003CIsWeaponPartVariant_003Eb__0(JJHFPNTSRLT.WeaponPartIdentifier x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MRQJPNSEEMQ
	{
		public JJHFPNTSRLT.WeaponPartIdentifier x;

		internal bool _003CIsWeaponPartVariant_003Eb__1(JJHFPNTSRLT.WeaponPartIdentifier y)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct THHLPENERJO
	{
		public ChestOpenPopupSelect _003C_003E4__this;

		public JJHFPNTSRLT.PQRIQGIOGQT weaponPartRarity;
	}

	[CompilerGenerated]
	private sealed class RTTLKOPTHHN
	{
		public WeaponData.OHHQFFINRQH cat;

		internal int _003CUpdateCategoryButtons_003Eb__2(LootElement x)
		{
			return 0;
		}
	}

	[SerializeField]
	private Transform chestLocation;

	[SerializeField]
	private Transform chestPositionFinal;

	[SerializeField]
	private LootElementCarousel carousel;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private Button buttonClaim;

	[SerializeField]
	private GameObject buttonClaimActive;

	[SerializeField]
	private GameObject buttonClaimInactive;

	[SerializeField]
	private CanvasGroup spotlight;

	[SerializeField]
	private CanvasGroup overlay;

	[SerializeField]
	private GameObject effectExplosion;

	[SerializeField]
	private Transform locationEffectExplosion;

	[SerializeField]
	private Transform locationEffectCardBlow;

	[SerializeField]
	private GameObject blockWeapon;

	[SerializeField]
	private GameObject blockTitleWeapon;

	[SerializeField]
	private GameObject parentStarsWeapon;

	[SerializeField]
	private GameObject labelInfoWeapon;

	[SerializeField]
	private Text labelTitleRarityWeapon;

	[SerializeField]
	private GameObject blockWeaponParts;

	[SerializeField]
	private GameObject blockTitleWeaponParts;

	[SerializeField]
	private Text labelSelectWeaponParts;

	[SerializeField]
	private Text labelSwipeWeaponPart;

	[SerializeField]
	private Text labelTitleRarityWeaponPart;

	[SerializeField]
	private GameObject blockWeaponCategorySelect;

	[SerializeField]
	private List<JJHFPNTSRLT.WeaponCategoryGameObject> weaponCategoryButtons;

	[SerializeField]
	private GameObject buttonAdd;

	[SerializeField]
	private GameObject buttonRemove;

	[SerializeField]
	private GameObject backgroundAddButtons;

	private Transform NPQSJLOIKNE;

	private Animator GMEJIMGLTOG;

	private ChestController.ChestData STSHQFSJQGT;

	private ChestConfigData GGIPOQSOTPJ;

	private Vector3 MNFGPEHSPKO;

	private bool TGGETSNHHIK;

	private bool PORRTQQRFNJ;

	private int INPSSJKOJFL;

	private List<LootElement> OPHQESJTOLF;

	private LootList FEKPLTQJNLL;

	private WeaponData.OHHQFFINRQH NPLTLNHRKTR;

	public event Action<ChestController.ChestData> JHHIFJTQPON
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static bool Open(ChestController.ChestData OTSSKRRHTOO, List<LootElement> OPHQESJTOLF, bool HILRPHJFQNF = true)
	{
		return false;
	}

	public static bool OpenAndGenerateRewards(ChestController.ChestData OTSSKRRHTOO, bool HILRPHJFQNF = true)
	{
		return false;
	}

	private void MLNESSGJRME(ChestController.ChestData OTSSKRRHTOO, List<LootElement> OPELSFHJIST, bool IOPMGLNGTRJ)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	private void QEMNPNSFMNK(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
	}

	private void Update()
	{
	}

	private void POEGKSNRIFJ()
	{
	}

	private void LERKKIGQEEM()
	{
	}

	private void SENMJLIGFGQ()
	{
	}

	private void QTETOLLGSMG()
	{
	}

	private void PELMMNLFNER()
	{
	}

	public void OnOkButton()
	{
	}

	private void QFFMNGLNKLS()
	{
	}

	private void OFTFNEPSQLS()
	{
	}

	private void QPOIQRQLSHE()
	{
	}

	private void NNNGGNIFHLE()
	{
	}

	private void FKRTGSGQFHG()
	{
	}

	private void FIEJKOMMNLN()
	{
	}

	private void HRFISTRLFPM()
	{
	}

	private void EJORPQHIKGH()
	{
	}

	private void JFEMEJKOTHN()
	{
	}

	private void HMPQMQEPLIS()
	{
	}

	private bool LTMIHJEGNJF()
	{
		return false;
	}

	private void LNSHMFNKFJT(bool HHRGQEQGGIS)
	{
	}

	private void JRHRQHMNLOT(bool FPITTGNIQOS)
	{
	}

	public void OnSelectCategoryButton(int FMRQENKSKRO)
	{
	}

	private void ILEOSJNLKKK()
	{
	}

	private void PTQGNRGTGHT()
	{
	}

	private void LGNTEFLNQKO()
	{
	}

	private void STEGQLMJTIJ()
	{
	}

	private void HMRGNPTGHJO()
	{
	}

	public void OnAddWeaponPartButton()
	{
	}

	public void OnRemoveWeaponPartButton()
	{
	}

	private int FPNQJFMHMGH(JJHFPNTSRLT.WeaponPartIdentifier PLKFROSLRHP)
	{
		return 0;
	}

	private int FTKMSIJLLMP()
	{
		return 0;
	}

	private void LSHHHITINRO()
	{
	}

	[CompilerGenerated]
	private bool KSLPTOKFOTJ(LootElement HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private void TQMRLOIONTP(GameObject GKKFNISSPRI, int OOQRGIQMEQS, bool SMJFTKGRFLJ, WeaponData.OHHQFFINRQH OJTGHRGORLS, ref THHLPENERJO P_4)
	{
	}

	[CompilerGenerated]
	private int OGIRRMNPGIR(WeaponData.OHHQFFINRQH OJTGHRGORLS, ref THHLPENERJO P_1)
	{
		return 0;
	}

	[CompilerGenerated]
	internal static void SQNTRMRGKNS(GameObject ELEIPINNGGJ, bool SMJFTKGRFLJ)
	{
	}

	[CompilerGenerated]
	internal static void GTHKMKFLKGQ(Transform OGFKHSKTHHR, float PRRKGRQILFR)
	{
	}

	[CompilerGenerated]
	internal static void NLKHLNNGOMQ(Transform OGFKHSKTHHR)
	{
	}
}
