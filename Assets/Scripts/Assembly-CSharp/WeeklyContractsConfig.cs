using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class WeeklyContractsConfig : ScriptableObject
{
	public enum MSMOFNNQQLS
	{
		UNSET = 0,
		REGULAR_LOOT = 1,
		WEAPON_PART_SELECT = 2
	}

	[Serializable]
	public struct ShopOfferConfig
	{
		public int id;

		public MSMOFNNQQLS type;

		public LootIdentifier identifier;

		public int price;

		public int accountLevelRequirement;

		public int purchasesCount;

		[SerializeField]
		private int amount;

		public int TRFEQIFFMQT()
		{
			return 0;
		}
	}

	[Serializable]
	public struct QuestConfig
	{
		[CompilerGenerated]
		private sealed class QNEGFKTLNFO
		{
			public Quest q;

			internal bool _003CMatchesQuest_003Eb__0(Quest.Requirement x)
			{
				return false;
			}
		}

		public EJPTJGENOIN core;

		public int uid;

		public GameController.KFPHKOMNHSS[] playTypes;

		public int[] goalVariants;

		public List<Quest.Requirement> availableFilters;

		public int TGMFJEJMIQI()
		{
			return 0;
		}

		public Quest.Requirement LKMQKLSGTSR()
		{
			return default(Quest.Requirement);
		}

		public override string ToString()
		{
			return null;
		}

		public bool EQENJPJRMTR(Quest MROKKGHHGTN)
		{
			return false;
		}
	}

	[Serializable]
	public struct QuestReward
	{
		public LootIdentifier reward;

		public int weight;

		[SerializeField]
		private int amount;

		public int TRFEQIFFMQT()
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class SGJQIGHPGSP
	{
		public int id;

		internal bool _003CGetShopOfferById_003Eb__0(ShopOfferConfig x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class EPSTMRQKOPN
	{
		public List<Quest> questsToRemove;

		public List<int> generatedRewards;

		public List<QuestReward> rewards;

		internal bool _003CGenerateRandomQuests_003Eb__3(QuestConfig x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QHONNIHEJTE
	{
		public int rwi;

		internal bool _003CGenerateRandomQuests_003Eb__4(int x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NEMQMMLMMOT
	{
		public int idx;

		internal bool _003CGenerateRandomQuests_003Eb__5(int x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QRQSNTRKKMR
	{
		public QuestConfig quest;

		internal bool _003CGenerateRandomQuests_003Eb__6(QuestConfig x)
		{
			return false;
		}
	}

	public List<ShopOfferConfig> shopOffers;

	public List<QuestConfig> quests;

	public List<QuestReward> questRewards;

	public List<QuestReward> vipQuestRewards;

	public ShopOfferConfig ERQMPSJLETF(int HSLQJLPMLMH)
	{
		return default(ShopOfferConfig);
	}

	private bool KIPIKEMNLQP(QuestConfig ELNPIIPSRIQ)
	{
		return false;
	}

	public List<Quest> FFITJHGFTFM(int SGNNHEROROI, List<QuestReward> OPHQESJTOLF, List<Quest> LGNFIGFTIEE = null)
	{
		return null;
	}

	public List<QuestReward> QTHLERMFMGL()
	{
		return null;
	}

	public List<QuestReward> GQFETRENOTN()
	{
		return null;
	}
}
