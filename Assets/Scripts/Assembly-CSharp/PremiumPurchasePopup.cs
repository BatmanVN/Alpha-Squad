using System;
using UnityEngine;
using UnityEngine.UI;

public class PremiumPurchasePopup : UIPopup
{
	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[Space]
	[SerializeField]
	private Text title;

	[SerializeField]
	private GameObject blockExtra;

	[SerializeField]
	private Text labelExtra;

	[SerializeField]
	private Transform parentPurchasePreview;

	[SerializeField]
	private Button buyButton;

	[Space]
	[SerializeField]
	private Image iconPrice;

	[SerializeField]
	private Text labelPrice;

	private GameObject IHQGIOGGHLO;

	private LootElement SJNSPJGESHJ;

	public Action OnBuy;

	private bool MGMMOFGKHFE;

	public static void Open(GameObject IHQGIOGGHLO, LootElement SJNSPJGESHJ, Action GGPLTIROTHQ)
	{
	}

	public static void OpenNoPay(GameObject IHQGIOGGHLO, LootElement SJNSPJGESHJ, Action GGPLTIROTHQ)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public void SetTitle(string OGFKHSKTHHR)
	{
	}

	public void SetExtraLabel(string OGFKHSKTHHR)
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnBuyButton()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void GKJISJGRFNM()
	{
	}

	private void KTQKFKNFNKE()
	{
	}

	private void OOPJIIOEHOH()
	{
	}

	private Transform RJTSQTMOLOL()
	{
		return null;
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnClickPurchaseElement()
	{
	}

	public void SetPriceIcon(Sprite ITRKNMFTGIG, Vector3 RRIGNONKQIS)
	{
	}
}
