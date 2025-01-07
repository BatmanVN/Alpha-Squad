using System;
using System.Collections.Generic;
using MiscStructures;
using UnityEngine;

namespace Expedition
{
	[Serializable]
	[CreateAssetMenu]
	public class ExpeditionData : ScriptableObject
	{
		public enum IFKHHMRJRKE
		{
			UNSET = -1,
			CHEST = 0,
			LOOT = 1,
			WEAPON = 2,
			RANDOM_SCRAP = 3,
			RANDOM_WEAPON_PART = 4,
			RANDOM_SHARDS = 5,
			RANDOM = 6,
			AGENT_CARDS = 7
		}

		[Serializable]
		public struct ExpeditionRewardSingle
		{
			public IFKHHMRJRKE type;

			public ChestController.MFRETPOLGOE chestId;

			public GambleRewardData.THHKQRSSPFN randomType;

			public LootElement loot;

			public ItemWeaponMin weapon;

			public List<RRMFSKNJIOH> agents;

			public int amount;

			public int addedChestLevels;

			public JJHFPNTSRLT.PQRIQGIOGQT rarity;

			[HideInInspector]
			public JJHFPNTSRLT.WeaponPartIdentifier weaponPartIdentifier;

			private bool PGLIONNHHPM()
			{
				return false;
			}

			private bool HLOPOPNPGSI()
			{
				return false;
			}
		}

		[Serializable]
		public struct ExpeditionLevel
		{
			public List<ExpeditionRewardSingle> rewards;

			public bool boss;

			public int maxAffixes;

			public int stageCount;

			public bool IQQMETPRREK()
			{
				return false;
			}

			public ExpeditionLevel EMHTREEOMMT()
			{
				return default(ExpeditionLevel);
			}
		}

		[Serializable]
		public struct ExpeditionLevelReward
		{
			public List<ExpeditionRewardSingle> rewards;
		}

		[Serializable]
		public struct ExpeditionLevelRewardSaved
		{
			public int lvl;

			public List<ExpeditionRewardSingle> rewards;
		}

		public int id;

		public int type;

		public Sprite rewardIcon;

		public List<ExpeditionLevel> levels;

		public ExpeditionLevel IKSLJHTPOQR(int PSPJIJNTMOI)
		{
			return default(ExpeditionLevel);
		}
	}
}
