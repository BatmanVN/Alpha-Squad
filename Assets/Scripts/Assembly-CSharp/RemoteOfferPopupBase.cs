using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using RemoteOffers;
using UnityEngine;
using UnityEngine.UI;

public class RemoteOfferPopupBase : UIPopup
{
	[Serializable]
	public struct PriceBlock
	{
		public Text labelPrice;

		public Text labelPriceDiscount;

		public GameObject blockValue;

		public Text labelValue;

		public GameObject spinnerPrice;

		public GameObject blockPrice;

		public GameObject buyButton;

		[NonSerialized]
		public global::HIJIFHMGTTR<Color> shadowColor;

		[NonSerialized]
		public global::HIJIFHMGTTR<Color> outlineColor;

		[NonSerialized]
		public global::HIJIFHMGTTR<Color> textColor;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct TNEEFTIEGJG
	{
		public bool gs;
	}

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	protected GameObject blockTimer;

	[SerializeField]
	protected UITextTimer timer;

	[SerializeField]
	private Material grayscaleMaterial;

	[SerializeField]
	private Text title;

	[SerializeField]
	protected GameObject blockSingleTimeOffer;

	protected RemoteOfferData SKEEKPJTTNN;

	protected bool HNFLFTTTGOM;

	protected bool MHITGLMHRRO;

	[SerializeField]
	private SoundEffect openSound;

	[SerializeField]
	private SoundEffect closeSound;

	[SerializeField]
	protected SoundEffect buyAddon;

	protected static void IPLLTEMGMSM<T>(RemoteOfferData GLNTLSLQFFS, bool PRLEJONOPLK = true) where T : RemoteOfferPopupBase
	{
	}

	protected virtual bool MLNESSGJRME(RemoteOfferData GLNTLSLQFFS)
	{
		return false;
	}

	protected virtual void RHLILLSSOPO()
	{
	}

	protected virtual void FIOLGGPQKON()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual void MHKGMRGGGLI()
	{
	}

	protected virtual void Update()
	{
	}

	public virtual void OnCloseButton()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private Transform KHKPMSIGIPN()
	{
		return null;
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	public virtual void OnTimerUp()
	{
	}

	protected void PNGNNIHJGMM(in PriceBlock JKPISRSGQJG, string LJEQIGLOIKJ, string LTKHGRQPKJS, string RFIOOKSPKKF, string JNFOKHKPJSO)
	{
	}

	protected void PFSQFEGJFQR(ref PriceBlock JKPISRSGQJG, bool QNEIGQKFLSM)
	{
	}

	[CompilerGenerated]
	private void HPKPETMHTMN()
	{
	}

	[CompilerGenerated]
	private void PTEKMMOHEFI()
	{
	}

	[CompilerGenerated]
	private bool LSHFQTFOJJT(Transform OGFKHSKTHHR)
	{
		return false;
	}

	[CompilerGenerated]
	internal static Color HNMJGMTQHGI(Color KJOIKHTSLJO)
	{
		return default(Color);
	}

	[CompilerGenerated]
	internal static void ELKMTMIGQPF(ref Color KSIMSNROKFP, ref global::HIJIFHMGTTR<Color> TETMOGOSNNT, ref TNEEFTIEGJG P_2)
	{
	}
}
