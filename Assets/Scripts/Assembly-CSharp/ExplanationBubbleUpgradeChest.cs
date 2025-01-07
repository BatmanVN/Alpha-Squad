using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ExplanationBubbleUpgradeChest : ExplanationBubble
{
	[Serializable]
	private struct ChanceBlock
	{
		public LootElement.TOINELPLRQP type;

		public GameObject block;
	}

	[CompilerGenerated]
	private sealed class GJETQQTKHJP
	{
		public LootElement.TOINELPLRQP type;

		internal bool _003CSetupReward_003Eb__0(ChanceBlock x)
		{
			return false;
		}
	}

	[SerializeField]
	private List<ChanceBlock> chanceBlocks;

	[SerializeField]
	private GameObject featuredBlock;

	[SerializeField]
	private Text labelFeaturedChance;

	public void Setup((List<LootElement.TOINELPLRQP>, List<int>) OPHQESJTOLF, int PLRENSFLELK, int NKSJHNGGFLG)
	{
	}

	private void HFKLLSKHOGQ(LootElement.TOINELPLRQP EOOEIROQJOE, int RQIIJRNJPFS, int MLSREPGRJSI)
	{
	}
}
