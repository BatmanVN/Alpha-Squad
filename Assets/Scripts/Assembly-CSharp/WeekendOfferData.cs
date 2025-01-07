using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class WeekendOfferData
{
	[Serializable]
	public struct OfferData
	{
		public LootElement loot;

		public int tier;
	}

	[CompilerGenerated]
	private sealed class LQPRIPRPOOQ
	{
		public int elvl;

		internal bool _003CTryGenerateOffer_003Eb__0(WeekendOfferConfig.DealLayoutConfig x)
		{
			return false;
		}
	}

	public int startTimestamp;

	public int endTimestamp;

	public int offerStartTimestamp;

	public int offerEndTimestamp;

	public int offerCompletedTimestamp;

	public List<int> revealed;

	public List<int> purchased;

	public OfferData currentOfferPurchasing;

	public List<OfferData> offers;

	public bool newDeals;

	[NonSerialized]
	private bool initialised;

	[NonSerialized]
	private Action Save;

	[CompilerGenerated]
	private Action OnChanged;

	public event Action SPHRSHMKNPN
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

	public void MLNESSGJRME()
	{
	}

	~WeekendOfferData()
	{
	}

	public bool OMIHPLSQQEJ()
	{
		return false;
	}

	public void GJPQMLSQNTR()
	{
	}

	public void JJKOLSERNQG()
	{
	}

	public bool JENTMKKGFTG(int PSPJIJNTMOI)
	{
		return false;
	}

	public void JHFGOKRTHQM(string MQNHOQLRLQO)
	{
	}

	private void HTGQHMLFTLH(bool QMLEHJIFQTF)
	{
	}

	public void ELIERJSIMRN(string MQNHOQLRLQO)
	{
	}

	private void NEEFIGNTQNQ()
	{
	}

	private bool KPENEMIGFFM(string MQNHOQLRLQO)
	{
		return false;
	}

	public string KSKEPGJMJHM(int FOQIJNNSRNI)
	{
		return null;
	}

	public string HPFQGTEPPHP(string MQNHOQLRLQO)
	{
		return null;
	}

	public int HEHJFQTQTGS()
	{
		return 0;
	}

	public void IFLLTROTLLK()
	{
	}

	private void IEHMGLTINER(OfferData FTMHSEPTHPR)
	{
	}

	private void NTSFRQRIKFL(int PNIQKIGEHLF)
	{
	}

	private void PJPSNMMQTFM()
	{
	}

	private void QOIMKSIJGIR()
	{
	}

	public LootElement QTONRKTHGLH()
	{
		return default(LootElement);
	}

	public void TFEQTETFMQK(int PSPJIJNTMOI)
	{
	}

	private void NIFSNOHPJRG()
	{
	}

	public int PGRFHFPKSOM()
	{
		return 0;
	}

	public bool RNHESOMINSR(int OREMGIQJPRP)
	{
		return false;
	}

	public bool TTJHQTLFQQL(int OREMGIQJPRP)
	{
		return false;
	}

	public bool OOEEPRIGJQK()
	{
		return false;
	}

	public void RSRFNJTERFM()
	{
	}
}
