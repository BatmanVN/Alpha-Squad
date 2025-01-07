using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ClanLeaguesReference : ScriptableObject
{
	public enum IRSSFTFLIKK
	{
		UNRANKED = -1,
		BRONZE = 0,
		SILVER = 1,
		GOLD = 2,
		PLATINUM = 3,
		ALPHA = 4
	}

	[Serializable]
	public struct Entry
	{
		public IRSSFTFLIKK league;

		public Sprite icon;

		public Sprite background;

		public Sprite backgroundBox;

		public string titleKey;

		public Color colorGradient;

		public Color colorLine;

		public Color colorEmblemGradient;

		public string MHGHGKRQMJE()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class JPEJTJQQQTI
	{
		public IRSSFTFLIKK league;

		internal bool _003CGet_003Eb__0(Entry l)
		{
			return false;
		}
	}

	public List<Entry> leagues;

	public Entry EJTNFHTLPTG(IRSSFTFLIKK PSLQPFEKSHG)
	{
		return default(Entry);
	}

	public Entry EJTNFHTLPTG(int PSLQPFEKSHG)
	{
		return default(Entry);
	}
}
