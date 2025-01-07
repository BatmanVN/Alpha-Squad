using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Expedition;
using Pass;
using UnityEngine;

public class Database : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OHJGFLOPKKI
	{
		public MNJMPEKHPTO gid;

		public KNSKIMFQMTH cat;

		internal bool _003CGetGearForId_003Eb__0(KeyValuePair<(MNJMPEKHPTO, KNSKIMFQMTH), GearData> x)
		{
			return false;
		}

		internal bool _003CGetGearForId_003Eb__1(KeyValuePair<(MNJMPEKHPTO, KNSKIMFQMTH), GearData> x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RMKNEKRQLIK
	{
		public IRHNENTFPPM sid;

		public Func<SkinData, bool> _003C_003E9__0;

		internal bool _003CGetAgentForSkinId_003Eb__0(SkinData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NKFQRRFNRIJ
	{
		public IRHNENTFPPM skinId;

		internal bool _003CGetSkinData_003Eb__0(SkinData s)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QTMTFTMQGJN
	{
		public ChestController.MFRETPOLGOE quality;

		internal bool _003CGetChestDataForQuality_003Eb__0(ChestConfigData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FMFLFHIPTJS
	{
		public SpecialLootConfigData.IJIFHOIRNIT id;

		internal bool _003CGetSpecialLootData_003Eb__0(SpecialLootConfigData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class ILQGEHOTNOE
	{
		public KKRGOHJEOSR id;

		internal bool _003CGetPassDataForPassId_003Eb__0(PassData x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class THLFJLNJQNR
	{
		public int id;

		internal bool _003CGetExpeditionDataForId_003Eb__0(ExpeditionsConfigs.ExpeditionRW x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class IGQNFMRPIQO
	{
		public EnemySpot.SMMGLQPTJET type;

		internal bool _003CGetEnemyModelOffset_003Eb__0(JJHFPNTSRLT.EnemyVector3 e)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class PRJMETRHQMT
	{
		public int subsetId;

		internal bool _003CGetTripleOfferIconForIndex_003Eb__0(TripleOfferVisualConfig x)
		{
			return false;
		}

		internal bool _003CGetTripleOfferIconForIndex_003Eb__1(TripleOfferVisualConfig x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MRNPKIKHHJM
	{
		public LSQGKNQIQMQ id;

		internal bool _003CGetTripleOfferDataForId_003Eb__0(TripleOfferConfig x)
		{
			return false;
		}

		internal bool _003CGetTripleOfferDataForId_003Eb__1(TripleOfferConfig x)
		{
			return false;
		}
	}

	public static Database instance;

	public Reference reference;

	public ReferenceItems referenceItems;

	private static Dictionary<JPHMLSJQLNL, WeaponData> SNQROITNMTR;

	private static Dictionary<(MNJMPEKHPTO, KNSKIMFQMTH), GearData> QORIOFMSTNH;

	private static Dictionary<RRMFSKNJIOH, AgentData> HRHHKTLHKNS;

	private static Dictionary<KLSIJJEGQNH, WeaponSkin> REPGKHOGRMO;

	public static Dictionary<WorldData.JQNPLTQOFMJ, WorldData> worldMap;

	private static bool QOOPLGKOOLG;

	public static AffixReferences MORQMEKQIQG => null;

	public static EffectsReferences JNFMHKPIMJP => null;

	public static ClanLeaguesReference QGMLSFHPHOI => null;

	private void Awake()
	{
	}

	private static void MLNESSGJRME()
	{
	}

	public static WeaponData GetWeaponForId(JPHMLSJQLNL LRNLKETJPSO)
	{
		return null;
	}

	public static GearData GetGearForId(MNJMPEKHPTO HSEHTKMSMPJ, KNSKIMFQMTH OJTGHRGORLS)
	{
		return null;
	}

	public static AgentData GetAgentForId(RRMFSKNJIOH TMQJMGQNQQR)
	{
		return null;
	}

	public static AgentData GetAgentForSkinId(IRHNENTFPPM QHTSIIGGMOP)
	{
		return null;
	}

	public static SkinData GetSkinData(IRHNENTFPPM OJRQNTQHSHO)
	{
		return null;
	}

	public static Dictionary<RRMFSKNJIOH, AgentData> GetAgentMap()
	{
		return null;
	}

	public static List<AgentData> GetAgentsForRarity(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return null;
	}

	public static WorldData GetWorld(WorldData.JQNPLTQOFMJ EOOEIROQJOE)
	{
		return null;
	}

	public static ChestConfigData GetChestDataForQuality(ChestController.MFRETPOLGOE ETNRRGQSKEG, ChestController.JPPJGGSMHMT EHMGIKQLPFH = ChestController.JPPJGGSMHMT.UNSET)
	{
		return null;
	}

	public static SpecialLootConfigData GetSpecialLootData(SpecialLootConfigData.IJIFHOIRNIT HSLQJLPMLMH)
	{
		return null;
	}

	public static PassData GetPassDataForPassId(KKRGOHJEOSR HSLQJLPMLMH, bool HSHMRNIEJSK = true)
	{
		return null;
	}

	public static ExpeditionData GetExpeditionDataForId(int HSLQJLPMLMH)
	{
		return null;
	}

	public static Sprite GetEnhancementIconSprite(RTMJNJJLEGL HSLQJLPMLMH)
	{
		return null;
	}

	public static EnhancementReference.Element GetEnhancementData(RTMJNJJLEGL HSLQJLPMLMH)
	{
		return default(EnhancementReference.Element);
	}

	public static LootBoostData GetChestBoostData()
	{
		return null;
	}

	public static RarityReference GetRarityReference()
	{
		return null;
	}

	public static Vector3 GetEnemyModelOffset(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return default(Vector3);
	}

	public static TripleOfferVisualConfig GetTripleOfferIconForIndex(int KTFQNKHGGGT)
	{
		return default(TripleOfferVisualConfig);
	}

	public static TripleOfferConfig GetTripleOfferDataForId(LSQGKNQIQMQ HSLQJLPMLMH)
	{
		return null;
	}
}
