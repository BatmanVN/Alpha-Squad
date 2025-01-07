using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MiscStructures;
using UnityEngine;

namespace Pass
{
	[CreateAssetMenu]
	public class PassData : ScriptableObject
	{
		public enum NJGPFKKNOFQ
		{
			UNSET = -1,
			CHEST = 0,
			LOOT = 1,
			WEAPON = 2,
			SELECT_WEAPON_SCRAP = 3,
			SELECT_WEAPON_PART = 4,
			SELECT_SHARDS = 5,
			SELECT_GEAR_SCRAP = 6
		}

		[Serializable]
		public struct PassReward
		{
			[CompilerGenerated]
			private sealed class SILJPPOFRGQ
			{
				public ERLKIIFQKSI rwCat;

				public Action<List<LootElement>> OnClaimed;

				public PassReward rw;

				internal void _003CClaim_003Eb__0(List<ItemWeapon> x)
				{
				}

				internal void _003CClaim_003Eb__1(WeaponData.OHHQFFINRQH x)
				{
				}

				internal void _003CClaim_003Eb__2(KNSKIMFQMTH x)
				{
				}

				internal void _003CClaim_003Eb__3(List<JJHFPNTSRLT.WeaponPart> parts)
				{
				}

				internal void _003CClaim_003Eb__4(RRMFSKNJIOH x)
				{
				}
			}

			public NJGPFKKNOFQ type;

			public bool highlighted;

			public string highlightTitle;

			public ChestController.MFRETPOLGOE chestId;

			public LootElement loot;

			public ItemWeaponMin weapon;

			public List<RRMFSKNJIOH> agents;

			public int amount;

			public JJHFPNTSRLT.PQRIQGIOGQT rarity;

			private bool PGLIONNHHPM()
			{
				return false;
			}

			public bool KJRSTTPKHEH(PassReward ELEIPINNGGJ)
			{
				return false;
			}

			public static void ORMRLEPTNGG(PassReward QFJFSEMOOEH, int PSPJIJNTMOI, Action<List<LootElement>> SRTSRMMFHLP, ERLKIIFQKSI JLNPMQIGRMG)
			{
			}
		}

		public int seasonLength;

		public KKRGOHJEOSR id;

		public string title;

		public Sprite icon;

		public List<Sprite> iconsPassPlusPopup;

		public List<Sprite> iconsPassPopup;

		public bool showBeams;

		public Color backgroundColor;

		public Color glowColor;

		public List<PassReward> freeRewards;

		public List<PassReward> paidRewards;

		public List<PassReward> premiumRewards;

		public int xpBase;

		public int xpScalingAdd;

		public int xpCap;

		public int GSPONQLPHFT()
		{
			return 0;
		}

		public bool TLMHJGFRRPJ()
		{
			return false;
		}

		public int RTOEMGHOMPR(int IQLQQNIPTPQ)
		{
			return 0;
		}

		public PassData IQTEEOQKMFP()
		{
			return null;
		}
	}
}
