using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class ShopResourceChestData
{
	[Serializable]
	public struct LevelLootConfig
	{
		public int level;

		public JJHFPNTSRLT.MinMaxValueInt scrapAmount;

		public int scrapWeight;

		public JJHFPNTSRLT.MinMaxValueInt gearMaterialsAmount;

		public int gearMaterialsWeight;

		public JJHFPNTSRLT.MinMaxValueInt toolsAmount;

		public int toolsWeight;

		public JJHFPNTSRLT.MinMaxValueInt gearBoostersAmount;

		public int gearBoostersWeight;

		public int featuredWeight;

		public bool featuredAgentCardsAvailable;

		public JJHFPNTSRLT.PQRIQGIOGQT featuredAgentCardsRarity;

		public JJHFPNTSRLT.MinMaxValueInt featuredAgentCardsAmount;

		public bool featuredGearBoostersAvailable;

		public JJHFPNTSRLT.MinMaxValueInt featuredGearBoostersAmount;

		public bool featuredRareWeaponTokensAvailable;

		public JJHFPNTSRLT.MinMaxValueInt featuredRareWeaponTokensAmount;

		public bool featuredGearScrapAvailable;

		public JJHFPNTSRLT.MinMaxValueInt featuredGearScrapAmount;

		public bool featuredAgentShardsAvailable;

		public JJHFPNTSRLT.MinMaxValueInt featuredAgentShardsAmount;

		public bool featuredWeaponChipsAvailable;

		public JJHFPNTSRLT.PQRIQGIOGQT featuredWeaponChipsRarity;

		public JJHFPNTSRLT.MinMaxValueInt featuredWeaponChipsAmount;

		public int MIRKIQFMHFN()
		{
			return 0;
		}

		public (List<LootElement.TOINELPLRQP>, List<int>) STFFEONFFHE()
		{
			return default((List<LootElement.TOINELPLRQP>, List<int>));
		}

		public JJHFPNTSRLT.MinMaxValueInt LEFLLNKHONR(LootElement.TOINELPLRQP EOOEIROQJOE)
		{
			return default(JJHFPNTSRLT.MinMaxValueInt);
		}

		public List<LootElement> SLNNROQOMNP(Random FQNLGPSKNRM = null)
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class OJNEJGTSJQF
	{
		public LevelLootConfig cfg;

		public ShopResourceChestData _003C_003E4__this;

		public bool featuredWon;

		public LootList ll;

		internal bool _003CGetRewards_003Eb__2(LootElement x)
		{
			return false;
		}
	}

	public int priceGems;

	public int priceTokens;

	public int featuredTimestampEnd;

	public bool seen;

	protected LevelLootConfig[] levelLootConfig;

	private int refreshInterval;

	private int startTime;

	private Action SaveData;

	public List<LootElement> featuredRewards;

	public List<string> wonFeaturedRewards;

	private bool initialised;

	public static string SOURCE;

	public void MLNESSGJRME()
	{
	}

	public void LLGPNISPSSP(int SGNNHEROROI)
	{
	}

	public void JNFIFMTJNFI(int SGNNHEROROI = 1)
	{
	}

	public LootList IHNGHSJFHLP(int QJQINTKJTJQ = -1, int SGNNHEROROI = 1)
	{
		return null;
	}

	public List<LootElement> NPGKREMSKPI()
	{
		return null;
	}

	private bool GTJRETOHGLJ()
	{
		return false;
	}

	public int SNJLGPIRENO()
	{
		return 0;
	}

	private void KPQGOINMOEJ()
	{
	}

	private void SLNNROQOMNP()
	{
	}

	public bool PPNHTNOPHQF(LootElement INNLJIGRFOG)
	{
		return false;
	}

	private void HGQNRGKKSJP(LootElement INNLJIGRFOG)
	{
	}

	public LevelLootConfig RQPMNPLJQPM(int QJQINTKJTJQ = -1)
	{
		return default(LevelLootConfig);
	}

	public bool QGTOGERORIR(LootElement INNLJIGRFOG)
	{
		return false;
	}

	public bool LLESRPNJJIH()
	{
		return false;
	}

	public bool FKFIKOFHKRN()
	{
		return false;
	}

	public bool TJFSPIGJTJO()
	{
		return false;
	}

	public void REFSJQPMQLL()
	{
	}
}
