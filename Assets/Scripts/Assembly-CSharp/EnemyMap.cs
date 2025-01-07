using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class EnemyMap : ScriptableObject
{
	[Serializable]
	public class EnemyMapDict : SerializableDictionary<EnemySpot.SMMGLQPTJET, Enemy>
	{
	}

	[Serializable]
	public class EnemyCategoryDict : SerializableDictionary<EnemySpot.OOSTRKKLKGI, EnemyList>
	{
	}

	[Serializable]
	public struct EnemyList
	{
		public List<EnemySpot.SMMGLQPTJET> list;
	}

	[Serializable]
	public class EnemyAddressableEntry
	{
		public EnemySpot.SMMGLQPTJET type;

		public AssetReferenceT<GameObject> enemy;
	}

	public List<EnemyAddressableEntry> enemyEntries;

	public EnemyCategoryDict categoryMap;

	public EnemyAddressableEntry TOMHFHMGRNJ(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return null;
	}

	public Task<Enemy> RRKKSQFJPTF(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return null;
	}

	public List<EnemySpot.SMMGLQPTJET> PJOOMKMJLEF(EnemySpot.OOSTRKKLKGI EMKNPKTIJPF)
	{
		return null;
	}

	public EnemySpot.OOSTRKKLKGI HPRJGHPEKNR(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return default(EnemySpot.OOSTRKKLKGI);
	}

	private static uint FIHPELENGGM(uint HNLHQPIFJNS)
	{
		return 0u;
	}
}
