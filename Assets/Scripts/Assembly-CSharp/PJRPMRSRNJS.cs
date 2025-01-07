using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Gear;
using UnityEngine;

public static class PJRPMRSRNJS
{
	[Serializable]
	public class DropCollection
	{
		public List<ItemWeapon> items;

		public CurrencyData currencyData;
	}

	public enum QPGSTGNNKII
	{
		PILE_OF_TOOLS = 0,
		PILE_OF_MATERIALS = 1,
		AGENT_SHARDS = 2
	}

	[Serializable]
	public class ShopDataPre146
	{
		[SerializeReference]
		public OfferDataLMG lmgOffer;

		[SerializeReference]
		public OfferDataRaidTickets raidTicketOffer;

		[SerializeReference]
		public OfferDataTripleOffer tripleOffer;

		[SerializeReference]
		public OfferBlackFriday blackFriday;

		public int startPack_timeStart;

		public int limitbreakPack_timeStart;

		public int chestPack_timeStart;

		public int agentsshardsPack_timeStart;

		public int toolsPack_timeStart;

		public int materialsMegaBundle_timeStart;

		public ItemWeapon starterPackWeapon;

		public int purchased_resourcePack_tier;

		public int purchased_upgradePack_tier;

		public bool purchased_starterPack;

		public bool purchased_chestPack;

		public bool purchased_limitbreakPack;

		public bool purchased_agentsshardsPack;

		public bool purchased_toolsPack;

		public bool purchased_gemPack;

		public bool purchased_materialsMegaBundle;

		public int limitbreakPack_lastRarity;

		public bool enabled_limitbreakPack;

		public bool enabled_toolsPack;

		public bool enabled_chestPack;

		public bool enabled_agentshardsPack;

		public bool enabled_materialsMegaBundle;

		public bool seen_starterPack;

		public bool seen_limitbreakPack;

		public bool seen_toolsPack;

		public bool seen_chestPack;

		public bool seen_agentshardsPack;

		public bool seen_materialsMegaBundle;

		public LootList chestPack_rewards_weaponChest;

		public LootList chestPack_rewards_upgradeChest;

		public JJHFPNTSRLT.WeaponPartIdentifier limitbreakPack_selectedWeaponpart;

		public RRMFSKNJIOH agentShardsPack_selectedAgent;

		public LootList toolsPack_rewards_upgradeChest;

		public int reccurts_limitbreakPack;

		public int reccurts_chestPack;

		public int reccurts_toolsPack;

		public int reccurts_agentshardsPack;

		public JJHFPNTSRLT.WeaponPartIdentifier[] limitbreakOffer_WeaponParts;

		public JJHFPNTSRLT.WeaponPartIdentifier[] limitbreakOffer_WeaponParts_Uncommon;

		public List<string> purchasedIds;

		public int monthly_offer_start_last;

		public List<QPGSTGNNKII> monthly_purchases_current;

		public List<JJHFPNTSRLT.RarityWeaponID> weapon_chest_featured_list;

		public List<JJHFPNTSRLT.RarityWeaponID> weapon_chest_featured_list_previous;

		public bool weapon_chest_featured_weapon_won;

		public int weapon_chest_featured_seen;

		public int weapon_chest_current_featured_index;

		public int weapon_chest_featured_end_timestamp;

		public bool weapon_chest_featured_popup_seen;

		public int upgrade_chest_timer_start_last;

		public LootElement[] upgrade_chest_featured_items;

		public List<string> upgrade_chest_won_featured_items_ids;

		public int upgrade_chest_generated_index;
	}

	[Serializable]
	public class ItemGearPre158
	{
		public string uuid;

		public bool isNew;

		public bool locked;

		public SHTSPMQQFMP id;

		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public Bonus[] bonuses;

		public List<SLERLGELELO.GearStat> stats;

		public ItemGear QLMPKPRKSQJ()
		{
			return null;
		}
	}

	[Serializable]
	public class InventoryDataPre158
	{
		public List<ItemWeapon> weapons;

		public List<ItemGearPre158> gear;

		public List<Agent> agents;

		public List<IRHNENTFPPM> unlockedSkins;

		public ObscuredInt slotCount;

		public ObscuredInt slotCountGear;
	}
}
