using System;
using System.Collections.Generic;
using UnityEngine;

public class BaseItemDatabase : ScriptableObject
{
	[Serializable]
	public struct MappedData
	{
		public int id;

		public BaseObjectData data;
	}

	public List<BaseCollectionData> collections;

	public Dictionary<BaseObjectData.LKKQKTPQSNS, List<MappedData>> categoryMap;

	public Dictionary<JJHFPNTSRLT.PQRIQGIOGQT, List<MappedData>> rarityMap;

	public Dictionary<JJHFPNTSRLT.PQRIQGIOGQT, List<MappedData>> lockerRarityMap;

	public Dictionary<BaseObjectData.PTGOHOTMOKK, MappedData> devices;

	[NonSerialized]
	public List<MappedData> trophies;

	public void NGHFQRREIJN()
	{
	}

	public BaseObjectData NHTLJNMHSHQ(int TQKKSJHFKSM)
	{
		return null;
	}

	public string TQISHSSFMFT(int TQKKSJHFKSM)
	{
		return null;
	}

	public string TTTHLEKOSHM(int TQKKSJHFKSM)
	{
		return null;
	}

	public int ETTNSJHIGJK(int TQKKSJHFKSM)
	{
		return 0;
	}
}
