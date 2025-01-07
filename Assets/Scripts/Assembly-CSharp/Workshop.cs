using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class Workshop : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		public ObscuredInt level;

		public ObscuredInt exp;

		public List<PJLTIFIPFSM> seenRecipes;

		public List<JJHFPNTSRLT.RecipeIdInteger> recipeCrafts;

		public List<PJLTIFIPFSM> autoMaxLockedRecipes;
	}

	[Serializable]
	public struct Config
	{
		public int max_level;

		public int[] xp_requirements;

		public int[][] gear_rarity_craft_weights;

		public int free_crafts_gear_body;

		public int[] fuse_prices;
	}

	[CompilerGenerated]
	private sealed class TFNIPEOFPMS
	{
		public PJLTIFIPFSM id;

		internal bool _003CGetRecipeForId_003Eb__0(WorkshopRecipe x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct OMMOFJEIIGP
	{
		public List<JJHFPNTSRLT.PQRIQGIOGQT> rarities;

		public List<JJHFPNTSRLT.RarityNumber> weights;
	}

	[CompilerGenerated]
	private sealed class TKRGLOITIJP
	{
		public PJLTIFIPFSM rid;

		internal int _003CGetFreeCraftCountLeft_003Eb__0(JJHFPNTSRLT.RecipeIdInteger x)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class HRTIPHPJMMG
	{
		public WorkshopRecipe.NOMPPKKTNOF c;

		internal bool _003CAnyNewRecipesInCategory_003Eb__0(WorkshopRecipe x)
		{
			return false;
		}
	}

	private static Data TSRPFHOJKSG;

	private static bool JREGORLKOST;

	private static Config SOSLGOOOIPG;

	public static string KEY;

	public static event Action PFOQQSTJLSE
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<WorkshopRecipe, int> HKTHSNSKPNF
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private static void MLNESSGJRME()
	{
	}

	public static void Clear()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	public static void ResetData()
	{
	}

	private static void KLJEPKORMLM()
	{
	}

	private static void PMITOIOJNOT()
	{
	}

	public static List<WorkshopRecipe> GetAllRecipesCopy()
	{
		return null;
	}

	public static List<WorkshopRecipe> GetAllAvailableRecipes()
	{
		return null;
	}

	public static WorkshopRecipe GetRecipeForId(PJLTIFIPFSM HSLQJLPMLMH)
	{
		return null;
	}

	public static void RecipeCrafted(WorkshopRecipe LQKPOLSLLJQ, int GIJGIMNHKOF, int SGNNHEROROI, List<LootElement> KGNOQPRPSEQ, List<LootElement> NFLKJJONJML)
	{
	}

	public static List<JJHFPNTSRLT.RarityNumber> GetCurrentRarityWeights()
	{
		return null;
	}

	public static List<JJHFPNTSRLT.RarityNumber> GetRarityWeightsForLevel(int IQLQQNIPTPQ)
	{
		return null;
	}

	public static void BoostGearCraftWeights(ref List<JJHFPNTSRLT.RarityNumber> QJOQTPIHSPM)
	{
	}

	public static int GetFreeCraftCountLeft(PJLTIFIPFSM EJTQSQFTLRR, int QKIFMEFNTNI)
	{
		return 0;
	}

	public static int GetTotalFreeCraftCount(PJLTIFIPFSM HSLQJLPMLMH)
	{
		return 0;
	}

	public static bool IsRecipeUnlocked(PJLTIFIPFSM HSLQJLPMLMH)
	{
		return false;
	}

	public static List<JJHFPNTSRLT.RarityNumber> GetFusePrices()
	{
		return null;
	}

	public static void GainExperience(int PQJFJINPGPL)
	{
	}

	private static void PLIQQENFTTH(bool LIPENRNHTJL)
	{
	}

	public static int GetCurrentExperience()
	{
		return 0;
	}

	public static int GetCurrentExperienceGoal()
	{
		return 0;
	}

	public static int GetCurrentWorkshopLevel()
	{
		return 0;
	}

	public static bool IsMaxLevel()
	{
		return false;
	}

	public static int GetMaxLevel()
	{
		return 0;
	}

	public static int GetExperienceGoalAtLevel(int NERGMFPHLIM)
	{
		return 0;
	}

	public static bool IsLevelMaxLevel(int NERGMFPHLIM)
	{
		return false;
	}

	public static void DebugGainLevel()
	{
	}

	public static int CalculateTotalExperience()
	{
		return 0;
	}

	public static void OnRecipeEntered(PJLTIFIPFSM EJTQSQFTLRR)
	{
	}

	public static bool IsRecipeSeen(PJLTIFIPFSM EJTQSQFTLRR)
	{
		return false;
	}

	public static bool AnyNewRecipes()
	{
		return false;
	}

	public static bool AnyNewRecipesInCategory(WorkshopRecipe.NOMPPKKTNOF KSIMSNROKFP)
	{
		return false;
	}

	public static bool IsRecipeCraftable(PJLTIFIPFSM HSLQJLPMLMH)
	{
		return false;
	}

	public static bool IsAnyRecipeCraftable()
	{
		return false;
	}

	public static bool IsRecipeAutoMaxLocked(PJLTIFIPFSM EJTQSQFTLRR)
	{
		return false;
	}

	public static void SetRecipeAutoMaxLocked(PJLTIFIPFSM EJTQSQFTLRR)
	{
	}

	public static void UnsetRecipeAutoMaxLocked(PJLTIFIPFSM EJTQSQFTLRR)
	{
	}

	public static int GetRecipeCraftsForId(PJLTIFIPFSM EJTQSQFTLRR)
	{
		return 0;
	}

	[CompilerGenerated]
	internal static void RFQNGTISQJR(ref OMMOFJEIIGP P_0)
	{
	}
}
