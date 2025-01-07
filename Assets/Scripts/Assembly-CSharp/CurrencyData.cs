using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public struct CurrencyData
{
	[Serializable]
	public struct WeaponParts
	{
		[CompilerGenerated]
		private sealed class MESJLJSJOQJ
		{
			public WeaponData.OHHQFFINRQH cat;

			public JJHFPNTSRLT.PQRIQGIOGQT rarity;

			public int type;

			internal bool _003CGet_003Eb__0(JJHFPNTSRLT.WeaponPart x)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class RJPROINIIIK
		{
			public JJHFPNTSRLT.WeaponPartIdentifier identifier;

			internal bool _003CGet_003Eb__0(JJHFPNTSRLT.WeaponPart x)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class PJORHMFRNRK
		{
			public JJHFPNTSRLT.WeaponPart wp;

			internal bool _003CJoin_003Eb__0(JJHFPNTSRLT.WeaponPart x)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class FQEMJMLINFE
		{
			public JJHFPNTSRLT.WeaponPart wp;

			internal bool _003CRemove_003Eb__0(JJHFPNTSRLT.WeaponPart x)
			{
				return false;
			}
		}

		public List<JJHFPNTSRLT.WeaponPart> weaponParts;

		public int EJTNFHTLPTG(WeaponData.OHHQFFINRQH OJTGHRGORLS, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int EOOEIROQJOE)
		{
			return 0;
		}

		public int EJTNFHTLPTG(JJHFPNTSRLT.WeaponPartIdentifier GQNQLIEOHPR)
		{
			return 0;
		}

		public void MFEFSLSRRFT(WeaponData.OHHQFFINRQH OJTGHRGORLS, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int EOOEIROQJOE, int ISLTSKEPJPI)
		{
		}

		public void MFEFSLSRRFT(JJHFPNTSRLT.WeaponPartIdentifier GQNQLIEOHPR, int ISLTSKEPJPI)
		{
		}

		public void THTHNSPOMOP(WeaponParts FKQLEGQSLHF)
		{
		}

		public void LHHJEQJOTKL(WeaponParts FKQLEGQSLHF)
		{
		}

		public int QTIKMTISGPN()
		{
			return 0;
		}
	}

	[Serializable]
	public struct AgentTag
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public ObscuredInt amount;
	}

	[Serializable]
	public struct AgentShard
	{
		public RRMFSKNJIOH agentId;

		public ObscuredInt amount;
	}

	[Serializable]
	public struct AttributeShard
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public ObscuredInt amount;
	}

	[CompilerGenerated]
	private sealed class NQTGHEJRMLF
	{
		public KNSKIMFQMTH gearCategory;

		internal int _003CGetGearScrap_003Eb__0(SLERLGELELO.GearScrap x)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class IEPEJRNSLIE
	{
		public JJHFPNTSRLT.PQRIQGIOGQT r;

		internal int _003CGetAttributeShards_003Eb__0(AttributeShard x)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class TFFSTQFKJEH
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal int _003CGetAgentTags_003Eb__0(AgentTag x)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class SMQOKPTEHRP
	{
		public LootList ret;

		internal void _003CGetLootElementList_003Eb__0(AgentTag x)
		{
		}

		internal void _003CGetLootElementList_003Eb__1(AgentShard x)
		{
		}

		internal void _003CGetLootElementList_003Eb__2(JJHFPNTSRLT.WeaponPart x)
		{
		}
	}

	public ObscuredInt cash;

	public ObscuredInt gems;

	public ObscuredInt wrenches;

	public ObscuredInt raidTickets;

	public ObscuredInt weaponChestTokens;

	public ObscuredInt rareChestToken;

	public ObscuredInt resourceChestTokens;

	public ObscuredInt mmTokens;

	public ObscuredInt gearBooster;

	public ObscuredInt reviveTokens;

	public ObscuredInt hammers;

	public ObscuredInt baseToken;

	public ObscuredInt pistolParts;

	public ObscuredInt shotgunParts;

	public ObscuredInt submachinegunParts;

	public ObscuredInt assaultrifleParts;

	public ObscuredInt sniperParts;

	public ObscuredInt explosiveParts;

	public ObscuredInt lmgParts;

	public List<AgentTag> agentTags;

	public List<AgentShard> agentShards;

	public List<SLERLGELELO.GearScrap> gearScraps;

	public List<AttributeShard> attributeShards;

	public ObscuredInt gearFragments;

	public WeaponParts weaponParts;

	public int cachedClanCoins;

	public int cachedClanHonor;

	public bool MTHNKEPKFJI()
	{
		return false;
	}

	public void MFEFSLSRRFT(CurrencyData FKQLEGQSLHF)
	{
	}

	public void LHHJEQJOTKL(CurrencyData FKQLEGQSLHF)
	{
	}

	public void MFEFSLSRRFT(WeaponData.OHHQFFINRQH THOSOJFTLST, int ISLTSKEPJPI)
	{
	}

	public int EJTNFHTLPTG(WeaponData.OHHQFFINRQH THOSOJFTLST)
	{
		return 0;
	}

	public void MFEFSLSRRFT(JJHFPNTSRLT.WeaponPartIdentifier MPOQOTNTMEO, int ISLTSKEPJPI)
	{
	}

	public int EJTNFHTLPTG(JJHFPNTSRLT.WeaponPartIdentifier MPOQOTNTMEO)
	{
		return 0;
	}

	public void JRFGFEMLRQQ(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int ISLTSKEPJPI)
	{
	}

	public void ITLNMSQRRPS(RRMFSKNJIOH HSLQJLPMLMH, int ISLTSKEPJPI)
	{
	}

	public void PIRGTJMIQOJ(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int ISLTSKEPJPI)
	{
	}

	public void SFGEMPQLLGT(KNSKIMFQMTH QQKJLIFKMHM, int ISLTSKEPJPI)
	{
	}

	public int LPMGTPJSMPM(KNSKIMFQMTH QQKJLIFKMHM)
	{
		return 0;
	}

	public int PRTLPPQHISK(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return 0;
	}

	public int HHOITISIEKE(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
		return 0;
	}

	public int RSTLKKKMOOL(RRMFSKNJIOH HSLQJLPMLMH)
	{
		return 0;
	}

	public int KSFMFRSMFRN()
	{
		return 0;
	}

	public int PJLILFTGFQI()
	{
		return 0;
	}

	public int QEGGOIJOENO()
	{
		return 0;
	}

	public int NRONGPMSHFH()
	{
		return 0;
	}

	public int FQTOMHKQFTO()
	{
		return 0;
	}

	public int QMRTJTONRQL()
	{
		return 0;
	}

	public List<LootElement> TMPQNKKGQSG()
	{
		return null;
	}
}
