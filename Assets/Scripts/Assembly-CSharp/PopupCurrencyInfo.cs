using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PopupCurrencyInfo : UIPopup
{
	[CompilerGenerated]
	private sealed class FNNMFSJOKFT
	{
		public PopupCurrencyInfo _003C_003E4__this;

		public PJLTIFIPFSM recipe;

		internal void _003CInitWorkshop_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class ENHIKOQHNGF
	{
		public GameObject obj;

		internal void _003CShowAnimation_003Eb__0()
		{
		}
	}

	[SerializeField]
	private GameObject prefabLabel;

	[SerializeField]
	private Text labelTitle;

	[SerializeField]
	private Text labelPartRarity;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image cog;

	[SerializeField]
	private Image backgroundImg;

	[SerializeField]
	private GameObject agentFragments;

	[SerializeField]
	private Image agentIcon;

	[SerializeField]
	[Space]
	private Sprite iconCash;

	[SerializeField]
	private Sprite iconTools;

	[SerializeField]
	private Sprite iconGems;

	[SerializeField]
	private Sprite iconRaidTicket;

	[SerializeField]
	private Sprite iconGearFragments;

	[SerializeField]
	private Sprite iconWeaponChestTokens;

	[SerializeField]
	private Sprite iconRareTokens;

	[SerializeField]
	private Sprite iconHammers;

	[SerializeField]
	private Sprite iconBaseTokens;

	[SerializeField]
	private Sprite iconResourceTokens;

	[SerializeField]
	private Sprite backgroundParts;

	[SerializeField]
	private Sprite backgroundCash;

	[SerializeField]
	private Sprite backgroundGems;

	[SerializeField]
	private Sprite backgroundTools;

	[SerializeField]
	private Sprite backgroundGearFragments;

	[SerializeField]
	private Sprite backgroundWeaponChestTokens;

	[SerializeField]
	private Sprite backgroundBaseTokens;

	[SerializeField]
	private Sprite backgroundResourceTokens;

	[SerializeField]
	private Sprite backgroundRareTokens;

	[Space]
	[SerializeField]
	private Transform parentUseFor;

	[SerializeField]
	private Transform parentGetFrom;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private List<GameObject> objectsForAnimation;

	[SerializeField]
	private Button workshopButton;

	private Action QILGMEOJJPE;

	private bool NKTKEIMJKNP;

	public static void SetAllowExtraButtons(bool MKOKMOKHKML)
	{
	}

	public static void OpenForLootElement(LootElement INNLJIGRFOG)
	{
	}

	public static void OpenForScrap(WeaponData.OHHQFFINRQH EMKNPKTIJPF)
	{
	}

	public static void OpenForGearScrap(KNSKIMFQMTH EMKNPKTIJPF)
	{
	}

	public static void OpenForTools()
	{
	}

	public static void OpenForCash()
	{
	}

	public static void OpenForGems()
	{
	}

	public static void OpenForRaidTicket()
	{
	}

	public static void OpenForGearFragmets()
	{
	}

	public static void OpenForParts(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH)
	{
	}

	public static void OpenForAgentTags(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
	}

	public static void OpenForAgentShards(RRMFSKNJIOH KGIEESPQHKH)
	{
	}

	public static void OpenForWeaponChestTokens()
	{
	}

	public static void OpenForHammers()
	{
	}

	public static void OpenForBaseTokens()
	{
	}

	public static void OpenForAttributeShards(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
	}

	public static void OpenForFurniture(int HSLQJLPMLMH, int GRIJOQOJLGJ)
	{
	}

	public static void OpenForRareTokens()
	{
	}

	public static void OpenForResourceTokens()
	{
	}

	public static void OpenForReviveTokens()
	{
	}

	public static void OpenForEventCurrency()
	{
	}

	public static void OpenForEventShopCurrency()
	{
	}

	public static void OpenForArcadePassCoins()
	{
	}

	public static void OpenForPresents()
	{
	}

	public static void OpenForMiddleManTokens()
	{
	}

	public static void OpenForClanCoins()
	{
	}

	public static void OpenForClanTokens()
	{
	}

	public static void OpenForHonor()
	{
	}

	public static void OpenForGearBoosters()
	{
	}

	private void OLTSLTLESFE(WeaponData.OHHQFFINRQH EMKNPKTIJPF)
	{
	}

	private void QIGJLJNRFTN(KNSKIMFQMTH EMKNPKTIJPF)
	{
	}

	private void RLQGOLTGNQI()
	{
	}

	private void RSQLGQFPRMI(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH)
	{
	}

	private void EJQJMJIOEKR()
	{
	}

	private void PGPHQKEFTGL()
	{
	}

	private void LPTOTPFNRQP()
	{
	}

	private void LHRLERQHRPH()
	{
	}

	private void OSNKERRQSSP(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
	}

	private void FROHTTJPNNK(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
	}

	private void JQMTITSRQST(RRMFSKNJIOH KGIEESPQHKH)
	{
	}

	private void HHMFJJMLENS()
	{
	}

	private void ILSIOLMLRHF()
	{
	}

	private void JOEHQOMJFRP()
	{
	}

	private void GIPPHNTTKEO(int HSLQJLPMLMH, int GRIJOQOJLGJ)
	{
	}

	private void GOENFMSSGFI()
	{
	}

	private void TKGJHKKLISS()
	{
	}

	private void OEPHSIOTLRK()
	{
	}

	private void SIHLLFEGTEK()
	{
	}

	private void GJJLFOFNMNN()
	{
	}

	private void FSFITLGSJRE()
	{
	}

	private void GJFFFREHMRQ()
	{
	}

	private void NMHSNHISSGJ()
	{
	}

	private void KLOHRPSGIMP()
	{
	}

	private void RMLMQOGPTLR()
	{
	}

	private void GJFFEQONNKK()
	{
	}

	private void IHMPGRKQSKE()
	{
	}

	private void NMMPQLHHIES()
	{
	}

	private void HEMOHIFGKFM()
	{
	}

	private void PGTFINNQEKP(string[] FLKQLPKJLES)
	{
	}

	private void ESOIERMPEKO(string[] FLKQLPKJLES)
	{
	}

	private static string SESNMELHOKE(string HIKMLGKLQJG)
	{
		return null;
	}

	public void OnHideButton()
	{
	}

	public void OnWorkshopButton()
	{
	}

	private void LOGOEGIRQRL(LootElement INNLJIGRFOG)
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

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	public void HideExtraButtons()
	{
	}
}
