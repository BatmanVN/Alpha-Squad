using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RiftConfig : ScriptableObject
{
	[Serializable]
	public struct LevelIncrease
	{
		public int endFloor;

		public int levelIncrease;
	}

	[Serializable]
	public struct BracketConfig
	{
		public List<GameModifierSpecific> modifiers;
	}

	public const int FLOORS_PER_BRACKET = 5;

	public string id;

	public uint seedOffset;

	public Sprite icon;

	public int startLevel;

	public List<LevelIncrease> levelIncrease;

	public List<MinibossConfig> bosses;

	public List<BracketConfig> brackets;

	public WorldRiftData worldData;

	public int[] stages;

	public SerializableDictionary<EnemySpot.SMMGLQPTJET, int> enemies;

	public RiftRewardConfig rewards;

	public int MHISJGQMHOS(int EERRGHKNKNK)
	{
		return 0;
	}

	public uint TEMSTIIKNGJ(int EERRGHKNKNK, int MTFHQPOPFKQ = 0)
	{
		return 0u;
	}

	public int MFJHMFRLEKG(int EERRGHKNKNK, int MTFHQPOPFKQ)
	{
		return 0;
	}

	public int MOJOOFPLGSE()
	{
		return 0;
	}
}
