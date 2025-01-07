using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gear;

namespace ItemControllerConfigs
{
	[Serializable]
	public struct ItemControllerConfig
	{
		[CompilerGenerated]
		private sealed class IPQIRMSEPFK
		{
			public KNSKIMFQMTH category;

			public JJHFPNTSRLT.PQRIQGIOGQT rarity;

			public List<MNJMPEKHPTO> except;

			internal bool _003CGetBonusPoolForGear_003Eb__0(Gear.BonusConfig x)
			{
				return false;
			}

			internal bool _003CGetBonusPoolForGear_003Eb__1(Gear.BonusConfig x)
			{
				return false;
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct EIRPOTQPJQH
		{
			public ItemControllerConfig self;

			public WeaponData.OHHQFFINRQH cat;

			public LootList rewards;
		}

		public BonusSelectionConfig[] weapon_bonus_selection_config;

		public BonusConfig[] weapon_bonus_configs;

		public Gear.BonusConfig[] gear_bonus;

		public SLERLGELELO.GearStatsConfig[] gear_stats;

		public SLERLGELELO.GearBonusLayoutsConfig[] gear_bonus_layout;

		public SLERLGELELO.GearBonusLayoutsConfigQuality[] gear_bonus_quality_layout;

		public int[] gear_bonus_rarity_quality;

		public int[] gear_bonus_quality_growth;

		public int[][] gear_stat_reroll_prices;

		public int[][] gear_bonus_reroll_prices;

		public int[][] gear_bonus_reroll_prices_maxed;

		public int gear_bonus_locked_reroll_price_multiplier;

		public int[] gear_upgrade_max_levels;

		public int[] gear_upgrade_epic_added_levels;

		public int[][] gear_upgrade_bonus_health_brackets;

		public float[][] gear_upgrade_bonus_damage_brackets;

		public int[][] gear_upgrade_price_scrap_brackets;

		public int[][] gear_upgrade_price_cash_brackets;

		public float[] weapon_scaling_regular;

		public float[] weapon_scaling_rank;

		public float[] weapon_scaling_limitbreak;

		public float weapon_scaling_empower;

		public float weapon_scaling_exponent;

		public List<LimitBreakRequirement> weapon_limitbreak_requirements;

		public UpgradeConfig weapon_upgrade_requirements;

		public UpgradeConfig weapon_rankup_requirements;

		public UpgradeConfig weapon_empower_requirements;

		public int[] rank_max_levels;

		public int[] weapon_rank_upgrade_increments;

		public float weapon_itemlevel_scaling;

		public float weapon_rarities_scaling;

		public int[] weapon_upgrade_added_scrap;

		public int[] weapon_upgrade_added_cash;

		public AgentCardTierConfig[] agent_card_configs;

		public AgentOverrideStats[] agent_overrides;

		public int inventory_expand_slot_price;

		public int inventory_expand_step_price_increase;

		public int inventory_expand_step_size;

		public int inventory_max_size;

		public int[] salvage_weaponparts_gem_price;

		public int salvage_tools_gem_price;

		public ScrapRewards scrap_rewards;

		public int[] agent_upgrade_brackets;

		public int[] agent_upgrade_bracket_prices_cards;

		public int[] agent_upgrade_bracket_prices_cash;

		public int agent_enhancement_upgrade_cash_price_base;

		public int agent_enhancement_upgrade_cash_price_scale;

		public int agent_enhancement_upgrade_level_requirement_scale;

		public int agent_enhancement_upgrade_level_requirement_base;

		public float legendary_weapon_regular_bonus_roll_min;

		public float legendary_weapon_regular_bonus_roll_max;

		public Dictionary<ItemWeapon.RGPEMGEPIJF, BonusConfig> bonusMap;

		public int weapon_max_empower_level;

		public float LMHFOLJJROL(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0f;
		}

		public float SJFLQFNSSRK(int HKGFNOEPMPN)
		{
			return 0f;
		}

		public Gear.BonusConfig PRKLRIMTPTJ(MNJMPEKHPTO HSLQJLPMLMH)
		{
			return default(Gear.BonusConfig);
		}

		public BonusConfig MHRKFQJMMHM(ItemWeapon.RGPEMGEPIJF TMMOGJKFPSF)
		{
			return default(BonusConfig);
		}

		public float LEPNMFONTPP(ItemWeapon.Bonus TMMOGJKFPSF, ItemWeapon LENQOPNFMTG)
		{
			return 0f;
		}

		public float HKQSRFSPMEM(ItemWeapon.Bonus TMMOGJKFPSF, ItemWeapon LENQOPNFMTG)
		{
			return 0f;
		}

		public float IJIEKLILOPT(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0f;
		}

		public float QNOPRFKFNJT(ItemWeapon.RGPEMGEPIJF TMMOGJKFPSF, int IQLQQNIPTPQ)
		{
			return 0f;
		}

		public float MFMGKEIMPLN(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0f;
		}

		public float FNJLQTIQSJN(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0f;
		}

		public bool KOHNHNPMOLQ(ItemWeapon LENQOPNFMTG)
		{
			return false;
		}

		public int NNHTSIENOHP(RRMFSKNJIOH IFLMHEQTKLS)
		{
			return 0;
		}

		public JJHFPNTSRLT.MinMaxValueFloat NHGGILITOTI()
		{
			return default(JJHFPNTSRLT.MinMaxValueFloat);
		}

		public int HLMSTSKIPSO(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
		{
			return 0;
		}

		public int SLSPRKLNLTT(int ORSGPHEJRPG)
		{
			return 0;
		}

		public SLERLGELELO.GearStatsConfig HFPLPKPFNIO(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
		{
			return default(SLERLGELELO.GearStatsConfig);
		}

		public List<Gear.BonusConfig> TKJKITFLNHP(KNSKIMFQMTH EMKNPKTIJPF, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, List<MNJMPEKHPTO> HQMFNLFKSJE = null)
		{
			return null;
		}

		public List<ItemWeapon.RGPEMGEPIJF> QKMGFJNOTIE(WeaponData.OHHQFFINRQH EMKNPKTIJPF, int PPERIKLNNES)
		{
			return null;
		}

		public AgentUpgradePrice QPJFOQNFJFM(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int IQLQQNIPTPQ)
		{
			return default(AgentUpgradePrice);
		}

		public AgentUpgradePrice QPJFOQNFJFM(Agent IFLMHEQTKLS)
		{
			return default(AgentUpgradePrice);
		}

		public LootList ETLJFLPHREN(int JKQMILELTES, int SSHTGPPFLSP, WeaponData.OHHQFFINRQH OJTGHRGORLS)
		{
			return null;
		}

		public LootList ETLJFLPHREN(ItemWeapon LENQOPNFMTG)
		{
			return null;
		}

		public LootList HJJRRGHJJML(int PNIQKIGEHLF, WeaponData.OHHQFFINRQH OJTGHRGORLS)
		{
			return null;
		}

		public LootList HJJRRGHJJML(ItemWeapon LENQOPNFMTG)
		{
			return null;
		}

		public LootList LNRERSEPORQ(int PNIQKIGEHLF, WeaponData.OHHQFFINRQH OJTGHRGORLS)
		{
			return null;
		}

		public LootList LNRERSEPORQ(ItemWeapon LENQOPNFMTG)
		{
			return null;
		}

		public LootList TFSQITELGER(int PNIQKIGEHLF, WeaponData.OHHQFFINRQH FIQMIIMGTNE)
		{
			return null;
		}

		public LootList TFSQITELGER(ItemWeapon LENQOPNFMTG)
		{
			return null;
		}

		public LootList HJIGLPKTFER(ItemWeapon LENQOPNFMTG)
		{
			return null;
		}

		public LootList RLFRFEJMJRL(ItemWeapon LENQOPNFMTG)
		{
			return null;
		}

		public LootList HJIGLPKTFER(ItemGear GIMISJFQPLI)
		{
			return null;
		}

		public void OEPMHQGPEOO(ItemGear GIMISJFQPLI, ref LootList OPHQESJTOLF)
		{
		}

		public LootList QSGMNLJPKGQ(int EESQJISERQF, WeaponData.OHHQFFINRQH OJTGHRGORLS)
		{
			return null;
		}

		public LootList GTRLLJKJSFI(int SINJNQNEJKM, WeaponData.OHHQFFINRQH OJTGHRGORLS)
		{
			return null;
		}

		[CompilerGenerated]
		internal static void HKQIPFIKQQN(int EESTGTGKLJG, int NJLTOMFTSHK, int QEFHSEEFROM, ref EIRPOTQPJQH P_3)
		{
		}
	}
}
