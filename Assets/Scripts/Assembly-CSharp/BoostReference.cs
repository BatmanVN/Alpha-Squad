using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoostReference : ScriptableObject
{
	[Serializable]
	public struct Data
	{
		public float value;

		public bool disabled;
	}

	[Serializable]
	public struct BoostConfig
	{
		public ITTKIKLHHEQ type;

		public Sprite icon;

		public Data[] data;
	}

	[Serializable]
	public struct BoostSlot
	{
		public ITTKIKLHHEQ type;

		public int rarity;
	}

	public List<BoostConfig> boosts;

	public BoostConfig TEHFIGMSMKG(ITTKIKLHHEQ EOOEIROQJOE)
	{
		return default(BoostConfig);
	}

	public float RKQINGQKGLT(BoostSlot JPLFGIEHPJE)
	{
		return 0f;
	}

	public bool SQPJTNEPGNJ(ITTKIKLHHEQ EOOEIROQJOE, int MOTTITEELQF)
	{
		return false;
	}

	public float RKQINGQKGLT(ITTKIKLHHEQ EOOEIROQJOE, int MOTTITEELQF)
	{
		return 0f;
	}
}
