using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class SkirmishConfigs : ScriptableObject
{
	[Serializable]
	public struct QuestReward
	{
		public int minLvl;

		public int maxLvl;

		public LootIdentifier id;

		public int amount;

		public int weight;
	}

	[CompilerGenerated]
	private sealed class NTQMSRNMTJP
	{
		public ERTTJTQLQJE gm;

		internal bool _003CGetIconForGameplayMode_003Eb__0(JJHFPNTSRLT.GameplayModeSprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MOQMIGQHQQM
	{
		public ERTTJTQLQJE gm;

		internal bool _003CGetRibbonForGameplayMode_003Eb__0(JJHFPNTSRLT.GameplayModeSprite x)
		{
			return false;
		}
	}

	public List<WorldData.JQNPLTQOFMJ> worlds;

	public List<QuestReward> questRewards;

	public List<QuestReward> rareQuestRewards;

	public float rareRewardChance;

	[SerializeField]
	private List<JJHFPNTSRLT.SpriteWithNumber> threatIcons;

	public Sprite modifierIconPositive;

	public Sprite modifierIconSuperPositive;

	public Sprite modifierIconNegative;

	public Sprite modifierIconSuperNegative;

	[Space]
	public Sprite modifierBgPositive;

	public Sprite modifierBgSuperPositive;

	public Sprite modifierBgNegative;

	public Sprite modifierBgSuperNegative;

	public List<JJHFPNTSRLT.GameplayModeSprite> gameplayModeIcons;

	public List<QuestReward> JGPFFSHSKNJ(int EKRNPSRGFRM)
	{
		return null;
	}

	public List<QuestReward> KQGSKORQTPM(int EKRNPSRGFRM)
	{
		return null;
	}

	public Sprite TPGRIKNQFPP(ERTTJTQLQJE KTPQIOLKPKQ)
	{
		return null;
	}

	public Sprite SLPGHEJKENF(ERTTJTQLQJE KTPQIOLKPKQ)
	{
		return null;
	}

	public Sprite TIETQLSHOOT(int EHMSPNPMKOG)
	{
		return null;
	}

	public Sprite QFTNMORRRFS(PJSMMJIROFF FOQIJNNSRNI)
	{
		return null;
	}

	public Sprite NSTNNKHKRQI(PJSMMJIROFF FOQIJNNSRNI)
	{
		return null;
	}
}
