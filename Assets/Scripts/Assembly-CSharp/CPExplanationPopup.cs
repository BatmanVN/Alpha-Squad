using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CPExplanationPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class FIJENGHMESN
	{
		public JJHFPNTSRLT.PQRIQGIOGQT r;

		internal bool _003CGetBackgroundRarity_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[Space]
	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> backgrounds;

	[SerializeField]
	private Sprite backgroundLegendary;

	[SerializeField]
	private List<GameObject> weaponVisuals;

	[SerializeField]
	private List<GameObject> weaponPluses;

	[SerializeField]
	private GameObject agentVisual;

	[SerializeField]
	private Text totalCpLabel;

	[SerializeField]
	private List<Text> cpLabels;

	[SerializeField]
	private GameObject gearBlock;

	[SerializeField]
	private GameObject gearPlus;

	[SerializeField]
	private List<GameObject> gearVisuals;

	[SerializeField]
	private List<GameObject> gearPluses;

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void OOQOFTGLEJO(ref int QOTRTQIGNKK)
	{
	}

	private Sprite MIEREIMFIHM(ItemWeapon LENQOPNFMTG)
	{
		return null;
	}

	private Sprite FKOIIRQNMPK(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return null;
	}

	public void OnCloseButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}
}
