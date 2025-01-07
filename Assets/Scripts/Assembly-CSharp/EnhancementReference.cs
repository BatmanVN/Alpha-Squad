using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class EnhancementReference : ScriptableObject
{
	[Serializable]
	public struct Element
	{
		public RTMJNJJLEGL id;

		public Sprite icon;

		public string titleKey;

		public string title => null;
	}

	[CompilerGenerated]
	private sealed class FMGFMNPLTEQ
	{
		public RTMJNJJLEGL enhancementID;

		internal bool _003CPrintMissing_003Eb__0(Element x)
		{
			return false;
		}
	}

	public List<Element> enhancements;

	public Sprite iconDefault;

	public Element RSTSIKIGHEM(RTMJNJJLEGL HSLQJLPMLMH)
	{
		return default(Element);
	}

	public void HFHSKOKRPOQ()
	{
	}
}
