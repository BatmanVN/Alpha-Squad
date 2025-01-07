using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gear;
using ItemControllerConfigs;
using UnityEngine;

public class ItemController : MonoBehaviour
{
	[Serializable]
	[StructLayout(0, Size = 1)]
	public struct Data
	{
	}

	[CompilerGenerated]
	private sealed class TNHKGSJRRKS
	{
		public WeaponData weapon;

		public int i;

		public Func<JJHFPNTSRLT.PredefinedWeaponBonus, bool> _003C_003E9__1;

		internal bool _003CGenerateBonusesForWeapon_003Eb__1(JJHFPNTSRLT.PredefinedWeaponBonus x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MJSPLQQMHRG
	{
		public ItemWeapon.Bonus bonus;

		internal bool _003CGenerateBonusesForWeapon_003Eb__0(ItemWeapon.RGPEMGEPIJF x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class JNRSRHMOTNH
	{
		public ItemWeapon.Bonus previousBonus;

		public ItemWeapon item;

		internal bool _003CGetAllAvailableReplacementBonuses_003Eb__1(ItemWeapon.RGPEMGEPIJF x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FOSGFNNJQHN
	{
		public ItemWeapon.RGPEMGEPIJF bt;

		internal bool _003CGetAllAvailableReplacementBonuses_003Eb__2(ItemWeapon.Bonus x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HPLSRQFEHIM
	{
		public ItemControllerConfig config;

		public int singlePrice;

		public int baseSize;

		internal int _003CGetInventoryExpandPrice_003Eb__0(int i, int n)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class EHQRFJMIKTO
	{
		public MNJMPEKHPTO bonus;

		internal bool _003CGetGearBonusMinimumRarity_003Eb__0(Gear.BonusConfig x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KRHHEKNNOSN
	{
		public MNJMPEKHPTO bonus;

		internal bool _003CGetGearBonusMaximumRarity_003Eb__0(Gear.BonusConfig x)
		{
			return false;
		}
	}

	[Space]
	public Inventory inventory;

	public Equipment equipment;

	private static bool MESGNJHQHRK;

	private static ItemControllerConfig ONKGJLSHESO;

	public Data data;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private static void ERFGNOLKSNQ()
	{
	}

	public static ItemControllerConfig GetConfig()
	{
		return default(ItemControllerConfig);
	}

	private void KLJEPKORMLM()
	{
	}

	public void ApplyOverrides()
	{
	}

	public void SaveAllData()
	{
	}

	public void ForceEmitAll()
	{
	}

	public ItemWeapon GenerateTemporaryItemWeapon(WeaponData TSRPFHOJKSG)
	{
		return null;
	}

	public void UnequipAllWeapons()
	{
	}

	public void TestItemGeneration()
	{
	}

	public void TestAgentPrice(int NERGMFPHLIM)
	{
	}

	public void GenerateBonusesForWeapon(ItemWeapon HPJMQLRTORF)
	{
	}

	public ItemWeapon.Bonus RegenerateSingleBonusForWeapon(ItemWeapon HPJMQLRTORF, ItemWeapon.Bonus SNFOJHFPJPM, int QIJRQLQNGRI)
	{
		return default(ItemWeapon.Bonus);
	}

	public List<ItemWeapon.RGPEMGEPIJF> GetAllAvailableReplacementBonuses(ItemWeapon HPJMQLRTORF, ItemWeapon.Bonus SNFOJHFPJPM)
	{
		return null;
	}

	public void GenerateBonusesForGear(ItemGear GIMISJFQPLI, KNSKIMFQMTH EMKNPKTIJPF, MNJMPEKHPTO MGHREHILRML = MNJMPEKHPTO.UNSET, System.Random FQNLGPSKNRM = null)
	{
	}

	public List<Bonus> GenerateGearBonuses(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL, KNSKIMFQMTH EMKNPKTIJPF, MNJMPEKHPTO MGHREHILRML, System.Random FQNLGPSKNRM = null, MNJMPEKHPTO[] SFQHSRJROLE = null)
	{
		return null;
	}

	public List<Bonus> GenerateGearBonusesForQuality(int ETNRRGQSKEG, JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL, KNSKIMFQMTH EMKNPKTIJPF, MNJMPEKHPTO MGHREHILRML, System.Random FQNLGPSKNRM = null, MNJMPEKHPTO[] SFQHSRJROLE = null, Bonus[] KFLKPEMNSTJ = null)
	{
		return null;
	}

	public AgentData GetAgentForWeapon(WeaponData QTRSFNTGTSR)
	{
		return null;
	}

	public int GetInventoryExpandPrice(int QRTKTFSTNJJ, JJHFPNTSRLT.QMNJMEELPPP HPLEMOEHNLF)
	{
		return 0;
	}

	public static int GetPartsTypeMaxValue(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
		return 0;
	}

	public void PrintGearNames()
	{
	}

	public static int GetWeaponPartSalvagePrice(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH)
	{
		return 0;
	}

	public static (LootElement, LootElement) GetAttributeRerollPrice(JJHFPNTSRLT.PQRIQGIOGQT OSTFJOEMJOG)
	{
		return default((LootElement, LootElement));
	}

	public static (LootElement, LootElement) GetAttributeUnlockPrice(JJHFPNTSRLT.PQRIQGIOGQT OSTFJOEMJOG)
	{
		return default((LootElement, LootElement));
	}

	public int GetAgentEnhancementCashUpgradePrice(int SHNHTOMQIMT)
	{
		return 0;
	}

	public int GetAgentLevelRequirementForEnhancementUpgradeLevel(int GNLGMGMPNJK)
	{
		return 0;
	}

	public JJHFPNTSRLT.PQRIQGIOGQT GetGearBonusMinimumRarity(MNJMPEKHPTO TMMOGJKFPSF)
	{
		return default(JJHFPNTSRLT.PQRIQGIOGQT);
	}

	public JJHFPNTSRLT.PQRIQGIOGQT GetGearBonusMaximumRarity(MNJMPEKHPTO TMMOGJKFPSF)
	{
		return default(JJHFPNTSRLT.PQRIQGIOGQT);
	}
}
