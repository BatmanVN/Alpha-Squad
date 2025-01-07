using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class OfferAds : OfferData
{
	[CompilerGenerated]
	private sealed class TOKSFSMLLOQ
	{
		public int idx;

		internal bool _003CGetCooldownRemainingForReward_003Eb__0(int x)
		{
			return false;
		}
	}

	private const int MAX_REWARDS = 4;

	public List<int> activeCooldownEnds;

	public List<int> claimedIndexes;

	public int lastResetTimestamp;

	private int resetInterval;

	private int[] rewardCooldown;

	private int[][] cashScaling;

	private int startTimestamp;

	private int claimsPerReset;

	[CompilerGenerated]
	private Action OnRewardsChanged;

	private static string SOURCE;

	public event Action MQTSQNOJISQ
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

	protected override ShopController.IQHJOMNOSOS KPMTISGSLPK()
	{
		return default(ShopController.IQHJOMNOSOS);
	}

	protected override void GTLHTGQITLO(ShopController.SJQRHINLPLS SOSLGOOOIPG)
	{
	}

	private int FFSSRFNTEQS(LootElement.TOINELPLRQP KGTIPOFHMLS)
	{
		return 0;
	}

	protected override void MOJPJNJTNSO()
	{
	}

	private void OLFKRMOSRQN()
	{
	}

	private void OQLRHSLMITF()
	{
	}

	private int OJJGMQHIMII()
	{
		return 0;
	}

	public bool QGTOGERORIR(int PNIQKIGEHLF)
	{
		return false;
	}

	public bool OGTLOHTPGMR()
	{
		return false;
	}

	public bool THFMORIINGS(LootElement.TOINELPLRQP SMOSQLQMMMF)
	{
		return false;
	}

	public int OQLPQTNOGEK(int PNIQKIGEHLF)
	{
		return 0;
	}

	public void SJGEQPGLGQJ(int PNIQKIGEHLF)
	{
	}

	public LootElement IKSLJHTPOQR(int PNIQKIGEHLF)
	{
		return default(LootElement);
	}

	private int LPFLFSIEHNE()
	{
		return 0;
	}

	private unsafe ref List<int> FKOHFEHFMKO()
	{
		return ref *(List<int>*)null;
	}

	public override int QPKJIQOLGJS()
	{
		return 0;
	}

	public void NSJIPOPMPFG()
	{
	}
}
