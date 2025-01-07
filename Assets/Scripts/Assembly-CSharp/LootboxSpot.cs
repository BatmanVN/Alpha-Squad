using System.Collections.Generic;
using MersenneTwister;
using UnityEngine;

public class LootboxSpot : MonoBehaviour
{
	public enum QHMTEIRRMIM
	{
		NONE = -1,
		REGULAR = 0,
		GEM = 1,
		OPERATION = 2,
		AGENT_CARDS = 3,
		WEAPON_SCRAP = 4
	}

	private static readonly List<int> QJOQTPIHSPM;

	private static readonly List<QHMTEIRRMIM> LHJNQSGMGFQ;

	private static int[] INRQOGIESHM;

	private Lootbox HNTPNTJRJMH;

	public virtual Lootbox Create(MTRandom TSKHRTKQGRI)
	{
		return null;
	}

	public static QHMTEIRRMIM GetLootboxTypeToSpawn(MTRandom TSKHRTKQGRI)
	{
		return default(QHMTEIRRMIM);
	}

	public static bool ShouldSpawnLootbox()
	{
		return false;
	}

	public void OnValidate()
	{
	}

	public void OnDrawGizmos()
	{
	}
}
