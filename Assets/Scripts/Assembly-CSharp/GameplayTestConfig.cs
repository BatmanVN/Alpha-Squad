using System;
using System.Collections.Generic;
using MersenneTwister;
using Newtonsoft.Json;
using UnityEngine;

public class GameplayTestConfig : ScriptableObject
{
	[Serializable]
	public class Entry
	{
		public WorldData.JQNPLTQOFMJ worldType;

		public ERTTJTQLQJE modeType;

		[SerializeReference]
		public GameplayModeConfig gameplayModeConfig;

		public List<GameModifierSpecific> modifiers;

		public List<int> stages;

		public uint seed;

		public int timeLimit;

		public List<MinibossConfig> bosses;

		public Entry()
		{
		}

		protected Entry(Entry other)
		{
		}
	}

	public List<Entry> premadeConfigs;

	public static JsonSerializerSettings serializerSettings;

	public static readonly Dictionary<OEJQQGFOSRJ, Vector2> MODIFIER_VALUES;

	public static JsonSerializerSettings GetSerializerSettings()
	{
		return null;
	}

	public static Entry GenerateConfigFromSeed(uint seed, ERTTJTQLQJE modeType, int numModifiers, bool genBosses = false, bool baseRaid = false)
	{
		return null;
	}

	private static List<MinibossConfig> GenerateBosses(int count, MTRandom rng)
	{
		return null;
	}

	public string SaveConfigToJson()
	{
		return null;
	}

	public string Save(List<Entry> cfg)
	{
		return null;
	}

	public static List<Entry> Load(string data)
	{
		return null;
	}

	public void TestConfigSerialization()
	{
	}
}
