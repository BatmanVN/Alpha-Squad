using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class RiftGenerationSettings : ScriptableObject
{
	[Serializable]
	public class ModifierEntry
	{
		public enum FLERQFOPMST
		{
			None = 0,
			Primary = 1,
			Seconary = 2
		}

		[Serializable]
		public struct BracketValue
		{
			public int minBracket;

			public int maxBracket;

			public float value;
		}

		public OEJQQGFOSRJ type;

		public int minBracket;

		public int maxBracket;

		public List<BracketValue> bracketValues;

		public FLERQFOPMST group;

		public float RKQINGQKGLT(int FQRHETETEMR)
		{
			return 0f;
		}
	}

	[CompilerGenerated]
	private sealed class OHQSSSOGPJL
	{
		public OEJQQGFOSRJ type;

		public ModifierEntry.FLERQFOPMST group;

		public Func<ModifierEntry, bool> _003C_003E9__1;

		internal bool _003CRemoveActiveModifiersOfSameGroup_003Eb__0(ModifierEntry m)
		{
			return false;
		}

		internal bool _003CRemoveActiveModifiersOfSameGroup_003Eb__1(ModifierEntry mod)
		{
			return false;
		}
	}

	public List<EnemySpot.SMMGLQPTJET> easyBosses;

	public int easyBossesMaxFloor;

	public int minNonRepeatingBosses;

	public List<ModifierEntry> activeModifiers;

	public List<ModifierEntry> passiveModifiers;

	public GameModifierSpecific KNJGFRTIQFP(int FQRHETETEMR, List<OEJQQGFOSRJ> FTFKTMJHJTE)
	{
		return null;
	}

	public GameModifierSpecific QGMFIMEHSOS(int FQRHETETEMR, List<OEJQQGFOSRJ> FTFKTMJHJTE)
	{
		return null;
	}

	private GameModifierSpecific OGINOEIEPOP(List<ModifierEntry> ENITSSOJHIH, int FQRHETETEMR, List<OEJQQGFOSRJ> FTFKTMJHJTE)
	{
		return null;
	}

	public void GMPTSFRLLLG(ref List<OEJQQGFOSRJ> FTFKTMJHJTE, OEJQQGFOSRJ EOOEIROQJOE)
	{
	}
}
