using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HeaderMenuCustomCurrency : UIHeader
{
	[Serializable]
	private struct CurrencyBlock
	{
		[CompilerGenerated]
		private sealed class QRKRJSKOHPM
		{
			public Text vl;

			internal void _003CSetValue_003Eb__0(float x)
			{
			}
		}

		[CompilerGenerated]
		private sealed class NJMGOTQPRQF
		{
			public CurrencyBlock self;

			internal bool _003CIsTypeInList_003Eb__0(LootElement.TOINELPLRQP x)
			{
				return false;
			}
		}

		public LootElement.TOINELPLRQP leType;

		public GameObject block;

		public Text valueLabel;

		private int valuePrevious;

		[NonSerialized]
		public SPMSMEESGQL value;

		public void TQTQOQLTOEP(bool MHNOIFFONJM)
		{
		}

		public void OOEEOGMFKNG(int QPNIRNRNJON, bool KQGHGPEKKTJ = false)
		{
		}

		public bool HEGQPPJFHTG(List<LootElement.TOINELPLRQP> TREKEFGFMPK)
		{
			return false;
		}
	}

	private class SPMSMEESGQL
	{
		public int RRRPJQJMRME;

		public int PITFEETNKEK;

		public bool ERQGETFJPLG;
	}

	[SerializeField]
	private List<CurrencyBlock> currencyBlocks;

	[SerializeField]
	private Image eventCurrencyIcon;

	[SerializeField]
	private RectTransform blockPlayerLevel;

	[SerializeField]
	private Image levelProgressFill;

	[SerializeField]
	private Text levelLabel;

	[SerializeField]
	private Text xpLabel;

	[SerializeField]
	private Text gemLabel;

	[SerializeField]
	private Button gemButton;

	[SerializeField]
	private Text cashLabel;

	[SerializeField]
	private Button cashButton;

	private bool EINTLMJQKNL;

	private List<LootElement.TOINELPLRQP> EGNRFJTENLQ;

	private bool RSELGQQLKIT;

	private HeaderMenuAll FMFOEQFGKPI;

	private HeaderClanBaseAll HMSOMPKSIIN;

	public static void Open(bool HINLLQLKJHF, LootElement.TOINELPLRQP[] TREKEFGFMPK, bool PQJFJINPGPL)
	{
	}

	protected override void MGKPMPHSLFR()
	{
	}

	public override void OnRemove()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void QQLOGJJEKFF()
	{
	}

	private void LERKPKKKNRF()
	{
	}

	public void UpdateCurrencyValues()
	{
	}

	public Transform GetCurrencyTransform(LootElement.TOINELPLRQP MSNGHRRMKQO)
	{
		return null;
	}

	public void SetMainCurrenciesUpdated()
	{
	}

	public void OnGemsButton()
	{
	}

	public void OnCashButton()
	{
	}

	public void OnEventCurrencyButton()
	{
	}

	public void OnEventShopCurrencyButton()
	{
	}

	public void OnArcadePassButton()
	{
	}

	private HeaderMenuAll HRMJQEHMJLG()
	{
		return null;
	}

	private HeaderClanBaseAll GJSSPSPFOFT()
	{
		return null;
	}

	private void Update()
	{
	}

	private void HPNKFSIOFIM()
	{
	}

	private int MGHQFKELKMQ(LootElement.TOINELPLRQP EOOEIROQJOE)
	{
		return 0;
	}

	private void ERLHTTLGHEP(ref int GSJNPHNGPLM, int PITFEETNKEK, Text ESRIRITTSIG)
	{
	}

	public void SetAutoUpdateBlocked(LootElement.TOINELPLRQP INNLJIGRFOG, bool ELEIPINNGGJ)
	{
	}

	public bool IsAutoUpdateBlocked(LootElement.TOINELPLRQP INNLJIGRFOG)
	{
		return false;
	}

	public void AddToValue(LootElement.TOINELPLRQP INNLJIGRFOG, int ISLTSKEPJPI)
	{
	}

	private bool HFQLPOGJKNI(LootElement.TOINELPLRQP RSIGLLHPHPR)
	{
		return false;
	}

	private void HJNIJGEQFHR(LootElement.TOINELPLRQP INNLJIGRFOG, int SIOORQNHKTP)
	{
	}

	private void SKJKNRRQIOJ(LootElement.TOINELPLRQP INNLJIGRFOG, int SIOORQNHKTP)
	{
	}

	private int ILKESNJKSTL(LootElement.TOINELPLRQP INNLJIGRFOG)
	{
		return 0;
	}

	private int QIRLGFERHLJ(LootElement.TOINELPLRQP INNLJIGRFOG)
	{
		return 0;
	}

	private CurrencyBlock EIPRIPFQTKT(LootElement.TOINELPLRQP INNLJIGRFOG)
	{
		return default(CurrencyBlock);
	}

	private void GJGOSTEFIPS(LootElement.TOINELPLRQP INNLJIGRFOG, CurrencyBlock ELEIPINNGGJ)
	{
	}
}
