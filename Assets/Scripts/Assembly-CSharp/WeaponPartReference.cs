using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class WeaponPartReference : ScriptableObject
{
	[Serializable]
	public struct WeaponPartDataTop
	{
		public WeaponData.OHHQFFINRQH category;

		public List<WeaponPartDataBot> data;

		public List<WeaponPartDataTitle> titles;
	}

	[Serializable]
	public struct WeaponPartDataBot
	{
		public int type;

		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public Sprite icon;
	}

	[Serializable]
	public struct WeaponPartDataTitle
	{
		public int type;

		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public string title;
	}

	[CompilerGenerated]
	private sealed class IMESNSEESEP
	{
		public JJHFPNTSRLT.WeaponPartIdentifier id;

		internal bool _003CGetBackgroundForIdentifier_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RMHRSINEPOE
	{
		public JJHFPNTSRLT.PQRIQGIOGQT r;

		internal bool _003CGetBackgroundForRarity_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class SSLGJNMHOSK
	{
		public JJHFPNTSRLT.WeaponPartIdentifier id;

		internal bool _003CGetSquareBackgroundForIdentifier_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TPGSJINMPRM
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CGetSquareBackgroundForRarity_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	public List<WeaponPartDataTop> weaponPartElements;

	public List<JJHFPNTSRLT.RaritySprite> backgrounds;

	public List<JJHFPNTSRLT.RaritySprite> backgroundsSquare;

	public WeaponPartDataBot RGEHGEQMLFT(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH)
	{
		return default(WeaponPartDataBot);
	}

	public string ETLRGMEPEQQ(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH)
	{
		return null;
	}

	public Sprite GISJLNRPEMQ(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH)
	{
		return null;
	}

	public Sprite TEPJSKHSIQF(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return null;
	}

	public Sprite RTFHQSLFLJI(JJHFPNTSRLT.WeaponPartIdentifier HSLQJLPMLMH)
	{
		return null;
	}

	public Sprite LLJFRRRQEKN(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
		return null;
	}
}
