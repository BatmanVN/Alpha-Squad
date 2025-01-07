using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class WeekendOfferDealConfig : ScriptableObject
{
	[Serializable]
	public struct WeekendOfferDealLoot
	{
		public JJHFPNTSRLT.LootIdentifierWithAmount loot;

		public int minPlayerLevel;

		public int maxPlayerLevel;

		public int weight;
	}

	[CompilerGenerated]
	private sealed class GTGMTHSOJHH
	{
		public int accountLevel;

		public List<LootElement.TOINELPLRQP> otherRewards;

		public Func<LootElement, bool> _003C_003E9__4;

		internal bool _003CGenerateReward_003Eb__0(WeekendOfferDealLoot x)
		{
			return false;
		}

		internal bool _003CGenerateReward_003Eb__3(WeekendOfferDealLoot x)
		{
			return false;
		}

		internal bool _003CGenerateReward_003Eb__4(LootElement x)
		{
			return false;
		}
	}

	public List<WeekendOfferDealLoot> tier1Rewards;

	public List<WeekendOfferDealLoot> tier2Rewards;

	public List<WeekendOfferDealLoot> tier3Rewards;

	public LootElement KNFQGTNSIRI(int FOQIJNNSRNI, System.Random JMRISHQTJQF = null, List<LootElement.TOINELPLRQP> JTMQQOTHNJO = null)
	{
		return default(LootElement);
	}

	public LootElement OSSIJEKNETJ(int FOQIJNNSRNI)
	{
		return default(LootElement);
	}
}
