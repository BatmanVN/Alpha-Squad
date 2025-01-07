using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class WorkshopRecipeReward
{
	public enum OOOJFTPENGM
	{
		UNSET = 0,
		RANDOM_WEAPON_PART = 1,
		LOOT_ELEMENT = 2,
		RANDOM_GEAR = 3,
		RELATIVE_GEAR = 4,
		SELECT_WEAPON_PART = 5,
		GEAR_FUSE = 6,
		GEAR_TRANSFORM = 7
	}

	[CompilerGenerated]
	private sealed class NHHGQNFJILM
	{
		public List<LootElement> used;

		public bool allowDuplicates;

		public List<LootElement> claimed;
	}

	[CompilerGenerated]
	private sealed class ILNKQMOOROR
	{
		public List<JJHFPNTSRLT.WeaponPartIdentifier> availWparts;

		public NHHGQNFJILM CS_0024_003C_003E8__locals1;
	}

	[CompilerGenerated]
	private sealed class MEPESIJTHTN
	{
		public JJHFPNTSRLT.WeaponPartIdentifier x;

		internal bool _003CGetClaimList_003Eb__1(LootElement y)
		{
			return false;
		}

		internal bool _003CGetClaimList_003Eb__2(LootElement y)
		{
			return false;
		}
	}

	public OOOJFTPENGM type;

	public int amount;

	public JJHFPNTSRLT.PQRIQGIOGQT rarity;

	public WeaponData.OHHQFFINRQH weaponCategory;

	public KNSKIMFQMTH gearCategory;

	public LootElement lootElement;

	[NonSerialized]
	public List<JJHFPNTSRLT.WeaponPart> selectedWeaponParts;

	[NonSerialized]
	public ItemGear selectedGearItem;

	public List<LootElement> QPQQOTIGHPL(List<LootElement> NFLKJJONJML, bool SERNMTTFJHL = true, bool JRSHRKTIETP = true)
	{
		return null;
	}

	public WorkshopRecipeReward EMHTREEOMMT()
	{
		return null;
	}

	private bool EOOQIRNMGGQ()
	{
		return false;
	}

	private bool SHGPLESPKJN()
	{
		return false;
	}

	private bool GHFRGMLFHHG()
	{
		return false;
	}

	private bool GFMENGHIMJE()
	{
		return false;
	}

	private bool GHPPKKPKMMM()
	{
		return false;
	}
}
