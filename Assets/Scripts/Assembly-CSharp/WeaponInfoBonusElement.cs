using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class WeaponInfoBonusElement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PERERHSMIGJ
	{
		public float valueNow;

		public WeaponInfoBonusElement _003C_003E4__this;

		public ItemWeapon.Bonus bonus;

		internal void _003CUpdateVisual_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class EOFRHIGHPLT
	{
		public float vPrevious;

		public PERERHSMIGJ CS_0024_003C_003E8__locals1;

		internal void _003CUpdateVisual_003Eb__0(float x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class QSHRROEKPIJ
	{
		public ItemWeapon.RGPEMGEPIJF meType;

		internal bool _003CGetBonusPreviewString_003Eb__0(JJHFPNTSRLT.PredefinedWeaponBonus x)
		{
			return false;
		}
	}

	[SerializeField]
	private Image background;

	[SerializeField]
	private NicerOutline backgroundOutline;

	[SerializeField]
	private Text bonusLabel;

	[SerializeField]
	private Image progressFill;

	[SerializeField]
	private GameObject fillFull;

	[SerializeField]
	private GameObject fillRegular;

	[SerializeField]
	private GameObject animationFill;

	[SerializeField]
	private Image attributeIcon;

	[SerializeField]
	private AttributeUIVisualsData attributeVisuals;

	[SerializeField]
	private GameObject progressbar;

	[SerializeField]
	private Image iconBackground;

	[SerializeField]
	private Sprite iconBackgroundLegendary;

	[SerializeField]
	private Sprite iconBackgroundRegular;

	[SerializeField]
	private GameObject resetIcon;

	[SerializeField]
	private GameObject unlockIcon;

	[SerializeField]
	private Button buttonMe;

	[Space]
	[SerializeField]
	private Sprite sprBackgroundLegendary;

	[SerializeField]
	private Sprite sprBackgroundRegular;

	public ItemWeapon.Bonus data;

	private float KHENHQKQTLS;

	private int FPFPSOQPGSH;

	public Action OnClick;

	private bool OSQOGRHTEPF;

	private bool FGIRIRRJNPR;

	private int MNGPNOSLRIE;

	private ItemWeapon LENQOPNFMTG;

	private bool MINQOQJRJLG;

	private global::HIJIFHMGTTR<float> TFMLTNEKLIK;

	private static string TETMOGOSNNT;

	public void Setup(ItemWeapon.Bonus TMMOGJKFPSF, bool FNPIMFIPPLT, int PSPJIJNTMOI, ItemWeapon LENQOPNFMTG, bool HHFGGFFGNQK = false)
	{
	}

	public void SetupNoValue(bool FNPIMFIPPLT)
	{
	}

	public void DisableReroll()
	{
	}

	public void ForceEnableButton()
	{
	}

	public void UpdateVisual(ItemWeapon.Bonus TMMOGJKFPSF, float PRRKGRQILFR = 0f)
	{
	}

	private void KSNTNGJSSJJ()
	{
	}

	private string FLGOFESKSSM(ItemWeapon.RGPEMGEPIJF GIHKEEQMIMN, float RRPSNPOTQNT, string POSNHINOJRL = "yellow")
	{
		return null;
	}

	private string OJMFOQFKFNG(ItemWeapon.Bonus TMMOGJKFPSF, string POSNHINOJRL = "yellow")
	{
		return null;
	}

	private string LIQGKRKJTTF(ItemWeapon.RGPEMGEPIJF GIHKEEQMIMN, float RRPSNPOTQNT, float OGFKHSKTHHR, string POSNHINOJRL = "yellow")
	{
		return null;
	}

	public void OnButtonEvent()
	{
	}

	public void HideBackground(bool RGLQGKLMHNI = true)
	{
	}

	private int HGGTJKSMOSI()
	{
		return 0;
	}
}
