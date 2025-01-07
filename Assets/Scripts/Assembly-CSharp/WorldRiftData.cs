using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class WorldRiftData : WorldData
{
	[Serializable]
	public struct EdgeElement
	{
		public AssetReferenceT<GameObject> prefab;

		public float length;
	}

	[Serializable]
	public struct EdgeCornerElement
	{
		public AssetReferenceT<GameObject> prefab;

		public float angle;
	}

	public AssetReferenceT<GameObject> background;

	public List<EdgeElement> edges;

	public List<EdgeCornerElement> edgeCorners;
}
