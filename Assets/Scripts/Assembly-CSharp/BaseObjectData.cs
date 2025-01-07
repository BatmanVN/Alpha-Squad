using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class BaseObjectData : ScriptableObject
{
	public enum LKKQKTPQSNS
	{
		Invalid = 0,
		Furniture = 1,
		Leisure = 2,
		Decor = 3,
		Floor = 4,
		Wall = 5,
		Misc = 6
	}

	[Flags]
	public enum EMHHQRNKSHJ
	{
		Furniture = 2,
		Leisure = 4,
		Decor = 8,
		Floor = 0x10,
		Wall = 0x20,
		Misc = 0x40
	}

	public enum SSIHJRNKHTT
	{
		Forward = 0,
		Right = 1,
		Back = 2,
		Left = 3
	}

	[Flags]
	public enum PFHSSTLRNHS
	{
		Ground = 1,
		Carpet = 2,
		Wall = 4
	}

	public enum OMISKGRTQRO
	{
		Decoration = 0,
		Device = 1,
		Trophy = 2
	}

	public enum PTGOHOTMOKK
	{
		Cash = 0,
		Gem = 1,
		Tickets = 2
	}

	public enum KRTQMMNJKOH
	{
		Small = 0,
		Medium = 1,
		Large = 2
	}

	public enum TOORKGEFHOK
	{
		Invalid = 0,
		Ground = 1,
		Carpet = 2,
		Wall = 3
	}

	private TOORKGEFHOK placement;

	public string label;

	public bool overrideLabel;

	public OMISKGRTQRO type;

	public string trophySourceLabel;

	public PTGOHOTMOKK deviceType;

	public AssetReference assetReference;

	public Sprite icon;

	public bool isInteractable;

	public bool canMirror;

	public int width;

	public int height;

	public LKKQKTPQSNS category;

	public EMHHQRNKSHJ additionalCategories;

	public JJHFPNTSRLT.PQRIQGIOGQT rarity;

	private PFHSSTLRNHS[,] inspectorLayers;

	[HideInInspector]
	public PFHSSTLRNHS[] cellLayers;

	private PFHSSTLRNHS inspectorForceLayer;

	[HideInInspector]
	public bool finalized;

	[NonSerialized]
	public int cachedPrice;

	[NonSerialized]
	public int cachedPrestige;

	public string KKEIQMNNJTJ()
	{
		return null;
	}

	public static string IMIRJTPMNHO(LKKQKTPQSNS OJTGHRGORLS)
	{
		return null;
	}

	public static Color JHLHSLIHIRM(PFHSSTLRNHS TEQEEPPOKFJ)
	{
		return default(Color);
	}

	public KRTQMMNJKOH PORNJEEPSLP()
	{
		return default(KRTQMMNJKOH);
	}

	public static SSIHJRNKHTT RRGMIFRTTJN(SSIHJRNKHTT IEKPNHIFTGS)
	{
		return default(SSIHJRNKHTT);
	}

	public PFHSSTLRNHS[] HQIORIHJRTJ(SSIHJRNKHTT IEKPNHIFTGS)
	{
		return null;
	}

	public Vector2Int HKHSGMIOHEI(SSIHJRNKHTT IEKPNHIFTGS)
	{
		return default(Vector2Int);
	}

	public Vector2Int IKNMFFGTJNG(SSIHJRNKHTT IEKPNHIFTGS)
	{
		return default(Vector2Int);
	}

	public int TRIQKFSGTEH(SSIHJRNKHTT IEKPNHIFTGS)
	{
		return 0;
	}

	public List<Vector2Int> GQIQMHSKHHE(Vector2Int KRKILIKILSS, SSIHJRNKHTT IEKPNHIFTGS)
	{
		return null;
	}

	public TOORKGEFHOK FLMETLGNHHJ()
	{
		return default(TOORKGEFHOK);
	}

	public string KSLGLENPJEG()
	{
		return null;
	}

	public void PJJRRMNTGPM()
	{
	}

	public void RQFOFGNPOEQ()
	{
	}
}
