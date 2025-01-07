using System;
using System.Collections.Generic;

namespace MiscStructures
{
	[Serializable]
	public struct ChestRewardsMin
	{
		public ChestController.MFRETPOLGOE chestId;

		public string chestIdStr;

		public List<JJHFPNTSRLT.AgentIdWithCount> agents;

		public int cash;

		public int gems;

		public int raidTickets;

		public int tools;

		public int rareTokens;

		public int regularTokens;

		public int resourceTokens;

		public int gearFragments;

		public int gearBoosters;

		public int baseCurrency;

		public List<ItemWeaponMin> weapons;

		public List<WeaponPartMin> weaponParts;

		public List<JJHFPNTSRLT.WeaponCategoryWithCount> weaponScraps;

		public List<JJHFPNTSRLT.GearCategoryWithCount> gearScraps;

		public List<JJHFPNTSRLT.RarityNumber> agentTags;

		public List<JJHFPNTSRLT.RarityNumber> weaponChips;

		public List<JJHFPNTSRLT.AgentIdWithCount> agentShards;

		public int eventCurrency;

		public int eventShopCurrency;

		public int eventPresents;

		public int arcadePassCoins;

		public static ChestRewardsMin EGEINKOGJIR(LootList TTSIIHOQINK)
		{
			return default(ChestRewardsMin);
		}
	}
}
