using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class LootConfigData : ScriptableObject
{
	[Serializable]
	public class LootLevelData
	{
		[CompilerGenerated]
		private sealed class NOOOMQTRHIO
		{
			public RRMFSKNJIOH id;

			internal bool _003CGetAgentShardsAmount_003Eb__0(JJHFPNTSRLT.AgentIdWithCount x)
			{
				return false;
			}
		}

		public int level;

		public RarityWeights weaponRarityWeights;

		public WeaponCategoryWeightList weaponCategoryWeightList;

		public WeaponDropData[] weaponDropData;

		public RarityWeights gearRarityWeights;

		public JJHFPNTSRLT.GearCategoryWeightList gearCategoryWeightList;

		public JJHFPNTSRLT.GearDropData[] gearDropData;

		public RarityWeights agentCoinWeights;

		public JJHFPNTSRLT.MinMaxValueInt agentCoinCounts;

		public WeaponCategoryWeightList scrapWeights;

		public JJHFPNTSRLT.MinMaxValueInt scrapCounts;

		public JJHFPNTSRLT.MinMaxValueInt cashCount;

		public JJHFPNTSRLT.MinMaxValueInt gemCount;

		public RarityWeights partWeights;

		public JJHFPNTSRLT.MinMaxValueInt partCounts;

		public WeaponCategoryWeightList partCategoryWeights;

		public NumberCount guaranteedWeapon;

		public NumberCount guaranteedAgent;

		public float toolsChance;

		public JJHFPNTSRLT.MinMaxValueInt guaranteedTools;

		public float gearMaterialChance;

		public JJHFPNTSRLT.MinMaxValueInt gearMaterialsCount;

		public JJHFPNTSRLT.MinMaxValueInt honorTokenCounts;

		public JJHFPNTSRLT.MinMaxValueInt hammersCount;

		public JJHFPNTSRLT.MinMaxValueInt baseTokensCount;

		public JJHFPNTSRLT.MinMaxValueInt tickets;

		public JJHFPNTSRLT.MinMaxValueInt rareTokensCount;

		public JJHFPNTSRLT.MinMaxValueInt regularTokensCount;

		public JJHFPNTSRLT.MinMaxValueInt resourceTokensCount;

		public JJHFPNTSRLT.MinMaxValueInt gearBoosterCount;

		public JJHFPNTSRLT.RarityNumber[] weaponChips;

		public List<JJHFPNTSRLT.AgentIdWithCount> agentShards;

		public float agentShardsVariation;

		public int RGKJPINQHQT()
		{
			return 0;
		}

		public int LNONOPIJTMF()
		{
			return 0;
		}

		public bool KNQJOHFPPFI()
		{
			return false;
		}

		public JJHFPNTSRLT.MinMaxValueInt TLELGPPHGGJ(RRMFSKNJIOH HSLQJLPMLMH)
		{
			return default(JJHFPNTSRLT.MinMaxValueInt);
		}
	}

	[Serializable]
	public struct RarityWeights
	{
		public int[] weights;

		public static RarityWeights PFHSEMJJHEF(RarityWeights LPGPMTILRJS, RarityWeights KTOQTLGEKQR, float QPNIRNRNJON)
		{
			return default(RarityWeights);
		}

		public bool FRKPIKSNNGF(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
		{
			return false;
		}

		public int OLNOMFHSLNG(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0;
		}

		public JJHFPNTSRLT.PQRIQGIOGQT FSEEFGIIRIS()
		{
			return default(JJHFPNTSRLT.PQRIQGIOGQT);
		}

		public float LMOLPPHIEIS(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
		{
			return 0f;
		}

		public JJHFPNTSRLT.PQRIQGIOGQT MJSLQTGILSK(System.Random SEENNJHQHRF = null)
		{
			return default(JJHFPNTSRLT.PQRIQGIOGQT);
		}

		private List<JJHFPNTSRLT.PQRIQGIOGQT> JHQKRJJELHP(bool PMOOHFPQNFP = true)
		{
			return null;
		}

		public bool FIPRGLQLSJN()
		{
			return false;
		}

		public RarityWeights EMHTREEOMMT()
		{
			return default(RarityWeights);
		}
	}

	[Serializable]
	public struct WeaponCategoryWeightList
	{
		public WeaponCategoryWeight[] weights;

		public int RFRILRHREQN(WeaponData.OHHQFFINRQH EMKNPKTIJPF)
		{
			return 0;
		}

		public WeaponData.OHHQFFINRQH NGOEOGPSFGH()
		{
			return default(WeaponData.OHHQFFINRQH);
		}

		public WeaponData.OHHQFFINRQH NGOEOGPSFGH(System.Random FQNLGPSKNRM)
		{
			return default(WeaponData.OHHQFFINRQH);
		}
	}

	[Serializable]
	public struct WeaponCategoryWeight
	{
		public int weight;

		public WeaponData.OHHQFFINRQH category;
	}

	[Serializable]
	public struct WeaponDropData
	{
		public float chance;

		public JPHMLSJQLNL weaponId;

		public JJHFPNTSRLT.PQRIQGIOGQT rarity;
	}

	[Serializable]
	public struct AgentIDWeight
	{
		public RRMFSKNJIOH id;

		public int weight;
	}

	[Serializable]
	public struct AgentIdWeightList
	{
		public AgentIDWeight[] agentIdWeights;

		public bool JIIFJTMLOHL()
		{
			return false;
		}

		public RRMFSKNJIOH RKLQFPTHOPH(System.Random SEENNJHQHRF = null)
		{
			return default(RRMFSKNJIOH);
		}
	}

	[Serializable]
	public struct AgentCounts
	{
		public int[] counts;

		public int splits;

		public float variation;

		public int SIOIOEGPNRS(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0;
		}

		public int SIFOOFMTNTM(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0;
		}

		public int MMSHRRKGJRP(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0;
		}

		public int FPISSGHFFLG(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0;
		}
	}

	[Serializable]
	public struct NumberCount
	{
		public int rarity;

		public int count;
	}

	[Serializable]
	public struct AgentShardReward
	{
		public JJHFPNTSRLT.MinMaxValueInt amount;

		public RRMFSKNJIOH id;

		public int weight;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct MNSJENGPNKI
	{
		public LootConfigData _003C_003E4__this;

		public int level;
	}

	[CompilerGenerated]
	private sealed class MOORNPPEKQE
	{
		public JJHFPNTSRLT.RarityNumber vto;

		internal bool _003CLerp_003Eb__0(JJHFPNTSRLT.RarityNumber x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MJFRIHHJMIK
	{
		public JJHFPNTSRLT.RarityNumber vto;

		internal bool _003CLerp_003Eb__1(JJHFPNTSRLT.RarityNumber x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QSLKEKGKMRM
	{
		public JJHFPNTSRLT.AgentIdWithCount f;

		internal bool _003CLerp_003Eb__2(JJHFPNTSRLT.AgentIdWithCount x)
		{
			return false;
		}
	}

	public LootLevelData[] levelTables;

	public bool interpolateTables;

	public void IGJKOJTFSFN(int IQLQQNIPTPQ, int MLNNEIRRGEK)
	{
	}

	public void KOEEGEIPEST(LootLevelData[] NIPNSLJTQLT)
	{
	}

	public LootLevelData NMONQPNMIOS(int NERGMFPHLIM)
	{
		return null;
	}

	private LootLevelData GKHFTNIILSM(LootLevelData EESTGTGKLJG, LootLevelData NJLTOMFTSHK, float OGFKHSKTHHR, int NERGMFPHLIM)
	{
		return null;
	}

	[CompilerGenerated]
	private LootList SJIMGGITJIE(ref MNSJENGPNKI P_0)
	{
		return null;
	}
}
