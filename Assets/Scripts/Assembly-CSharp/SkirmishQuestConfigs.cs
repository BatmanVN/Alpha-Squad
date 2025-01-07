using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class SkirmishQuestConfigs : ScriptableObject
{
	[Serializable]
	public struct Config
	{
		public EJPTJGENOIN core;

		public int uid;

		public int[] goalVariants;

		public ERTTJTQLQJE[] availablePlayModes;

		public List<Quest.Requirement> availableFilters;

		public int TGMFJEJMIQI()
		{
			return 0;
		}

		public Quest.Requirement LKMQKLSGTSR()
		{
			return default(Quest.Requirement);
		}
	}

	[CompilerGenerated]
	private sealed class HRRQJSJIITR
	{
		public ERTTJTQLQJE pm;

		internal bool _003CGetAllAvailableQuestsForPlayMode_003Eb__0(Config x)
		{
			return false;
		}
	}

	public List<Config> questConfigs;

	public List<Config> TJIOTJETGPK(ERTTJTQLQJE MEFMKOESONR)
	{
		return null;
	}

	public void IJHJFJPOPHS()
	{
	}
}
