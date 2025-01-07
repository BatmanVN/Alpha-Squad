using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseConfirmPopup : UIPopup
{
	public enum MMNENTPNPQQ
	{
		UNSET = 0,
		OPEN_WEAPON_CHEST_10 = 1,
		OPEN_LEGENDARY_CHEST_10 = 2,
		OPEN_RESOURCE_CHEST_10 = 3,
		OPEN_WEAPON_CHEST_1 = 4,
		OPEN_LEGENDARY_CHEST_1 = 5,
		OPEN_RESOURCE_CHEST_1 = 6,
		REROLL_WEAPON = 7,
		OPEN_WEAPON_PART_CHEST_1 = 8,
		OPEN_WEAPON_PART_CHEST_10 = 9,
		REROLL_LEGENDARY_WEAPON = 10,
		EASTER_GEM_ROLL_CONFIRM = 11
	}

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private Image iconCurrency;

	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private Text labelInfo;

	[SerializeField]
	private Toggle toggleDontShow;

	private MMNENTPNPQQ HSLQJLPMLMH;

	private int SJNSPJGESHJ;

	private LootElement.TOINELPLRQP NTMROGSFPEK;

	public static string KEY;

	private event Action GFKKNHQHIFI
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

	private event Action EIEHQFLELET
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

	public static void Open(MMNENTPNPQQ JOLIOOIMMQM, int ELEIMILTJMS, Action JJIPJOJEFHG, Action ITRHIJQENLJ = null, bool NFJFTIOHLRE = true)
	{
	}

	public static void ForceOpen(MMNENTPNPQQ JOLIOOIMMQM, int ELEIMILTJMS, Action JJIPJOJEFHG, Action ITRHIJQENLJ = null)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnYesButton()
	{
	}

	public void OnNoButton()
	{
	}

	private string STPRSHJJESG(MMNENTPNPQQ JOLIOOIMMQM)
	{
		return null;
	}

	private void JHTMJGTFJLS()
	{
	}

	private static bool TSPFSSFETHK()
	{
		return false;
	}

	public static void ResetState()
	{
	}

	public void PrintAllFormatLabels()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}
}
