using System;
using System.Collections.Generic;
using UnityEngine;

public class ClanMissionConfig : ScriptableObject
{
	[Serializable]
	public class GameplayConfig
	{
		public int[] worldVariations;

		public int timeLimit;

		public int[][] enemyLevels;

		public int[][] enemies;

		public int LMJSROSIFEK(int LIQGLGKPMPE, int EERRGHKNKNK)
		{
			return 0;
		}
	}

	[Serializable]
	public class LeagueMissionConfig
	{
		[Serializable]
		public class BossConfig
		{
			public List<int> stages;

			public uint seed;

			public List<GameModifierSpecific> modifiers;

			public List<GameModifierSpecific> tormentModifiers;

			public MinibossConfigTorment boss;
		}

		[Serializable]
		public class MinibossConfigTorment : MinibossConfig
		{
			public GTIMJFKHLHH[] tormentAffixes;
		}

		public BossConfig[] bosses;

		public string minVersion;

		public int minBuild;
	}

	public LeagueMissionConfig missionConfig;

	public string PKNEGNOSOEF(LeagueMissionConfig GJFPMSOEQTM)
	{
		return null;
	}

	public static LeagueMissionConfig MGHRGPQFEMR(string TSRPFHOJKSG)
	{
		return null;
	}
}
