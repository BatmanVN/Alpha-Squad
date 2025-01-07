using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LootBoostData : ScriptableObject
{
	[Serializable]
	public struct BoostData
	{
		public LootIdentifier id;

		public int boostAmount;

		public int weight;
	}

	public List<BoostData> boostData;
}
