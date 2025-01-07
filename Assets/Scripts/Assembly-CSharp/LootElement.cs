using System;
using UnityEngine;

[Serializable]
public struct LootElement
{
	public enum TOINELPLRQP
	{
		UNSET = -1,
		CASH = 0,
		AGENT = 1,
		WEAPON = 3,
		GEMS = 4,
		WEAPON_SCRAP = 5,
		WEAPON_PART = 6,
		RAID_TICKETS = 7,
		AGENT_CARD = 8,
		TOOLS = 9,
		AGENT_SHARDS = 10,
		GEAR_FRAGMENT = 11,
		GEAR = 12,
		WEAPON_CHEST_TOKEN = 13,
		AGENT_SKIN = 14,
		RARE_TOKENS = 15,
		ATTRIBUTE_SHARDS = 16,
		MIDDLEMAN_TOKENS = 17,
		RESOURCE_CHEST_TOKEN = 18,
		GEAR_BOOSTER = 19,
		GEAR_SCRAP = 20,
		REVIVE_TOKENS = 21,
		HAMMERS = 100,
		BASE_TOKENS = 101,
		BASE_RIFT_TROPHY = 102,
		BASE_BLUEPRINT = 103,
		BASE_ITEM = 104,
		CLAN_COINS = 200,
		CLAN_TOKENS = 201,
		CLAN_HONOR = 202,
		EVENT_CURRENCY = 1000,
		EVENT_PRESENTS = 1001,
		EVENT_DECORATION = 1002,
		ARCADE_PASS_COINS = 1003,
		EVENT_SHOP_CURRENCY = 1004
	}

	public static Action<LootElement> OnRemoved;

	public string customIdentifier;

	[HideInInspector]
	public bool boosted;

	public TOINELPLRQP type;

	[HideInInspector]
	public string source;

	public RRMFSKNJIOH agentId;

	[SerializeReference]
	public ItemWeapon weapon;

	[SerializeReference]
	public ItemGear gear;

	public JJHFPNTSRLT.PQRIQGIOGQT rarity;

	public JJHFPNTSRLT.WeaponPartIdentifier wpIdentifier;

	public WeaponData.OHHQFFINRQH scrapType;

	public KNSKIMFQMTH gearCategory;

	public IRHNENTFPPM skinId;

	public int intId;

	public int seasonIndex;

	public int amount;

	private bool forceSource;

	public bool IsUnset => false;

	public override string ToString()
	{
		return null;
	}

	public void GGFGGQGFLLI(bool NNJLFSIQJHH)
	{
	}

	public bool HOMINKNPIJP()
	{
		return false;
	}

	public static bool TKOMKMNJKHN(LootElement INNLJIGRFOG)
	{
		return false;
	}

	public static void ORMRLEPTNGG(LootElement QFJFSEMOOEH, bool NHNHJLLPNOR = false, bool SERNMTTFJHL = true, bool EPEOKSGENTK = true, bool LIPENRNHTJL = true)
	{
	}

	public static void LHHJEQJOTKL(LootElement QFJFSEMOOEH, bool SERNMTTFJHL = true, bool EPEOKSGENTK = true, bool LIPENRNHTJL = true)
	{
	}

	private bool LKMFJILROPR()
	{
		return false;
	}

	private bool MESIEMRIMRR()
	{
		return false;
	}

	private bool OEGQMSPSKHN()
	{
		return false;
	}

	private bool GSHKPHTRSQJ()
	{
		return false;
	}

	public bool EENFGQRELSP(LootElement FKQLEGQSLHF, bool IENTPKOQSQE = true)
	{
		return false;
	}

	public static string OLPEOIENPIM(LootElement INNLJIGRFOG)
	{
		return null;
	}

	public static string GPROQTFHLOH(TOINELPLRQP EOOEIROQJOE)
	{
		return null;
	}

	public static string RQSMKQKNJGM(TOINELPLRQP OGFKHSKTHHR)
	{
		return null;
	}
}
