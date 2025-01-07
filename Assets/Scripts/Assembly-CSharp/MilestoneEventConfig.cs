using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class MilestoneEventConfig : ScriptableObject
{
	[Serializable]
	public class EventMilestone
	{
		[CompilerGenerated]
		private sealed class PEOMHEGEGKT
		{
			public Func<bool, string> getSource;

			public bool paid;

			public Action onAfterClaim;
		}

		[CompilerGenerated]
		private sealed class TFFOFTGJRLG
		{
			public LootIdentifier rw;

			public PEOMHEGEGKT CS_0024_003C_003E8__locals1;
		}

		public int lapCount;

		public LootIdentifier freeReward;

		public LootIdentifier paidReward;

		public LootElement MHFHKOJTKFP(bool FKPPEQLPJHJ, Func<bool, string> JSOOORQNQSR)
		{
			return default(LootElement);
		}

		public bool QGTOGERORIR(bool FKPPEQLPJHJ)
		{
			return false;
		}

		public LootIdentifier FEFJIJJOMTF(bool FKPPEQLPJHJ)
		{
			return default(LootIdentifier);
		}

		public void ORMRLEPTNGG(bool FKPPEQLPJHJ, Func<bool, string> JSOOORQNQSR, Action JPLQMGKQFNP, uint MEMQOEIGNQN = 0u)
		{
		}
	}

	public List<EventMilestone> milestones;

	public Sprite currencyIcon;

	public Sprite currencyIconButton;

	public Sprite currencyIconHeader;

	public EventCurrencyDrop drop3d;

	public string currencyLocalization;

	public string sourceMilestonePaid;

	public string sourceMilestoneFree;

	public EventMilestone RRSJNPNOLMN(int PSPJIJNTMOI)
	{
		return null;
	}
}
