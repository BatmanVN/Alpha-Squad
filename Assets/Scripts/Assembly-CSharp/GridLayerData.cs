using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GridLayerData : ScriptableObject
{
	[Serializable]
	public class Doors
	{
		[CompilerGenerated]
		private sealed class SEROOQMIPNK
		{
			public Vector2Int cursorCoords;

			internal bool _003CIsDraggedThrough_003Eb__0(Vector2Int dCoord)
			{
				return false;
			}

			internal bool _003CIsDraggedThrough_003Eb__1(Vector2Int dCoord)
			{
				return false;
			}

			internal bool _003CIsDraggedThrough_003Eb__2(Vector2Int dCoord)
			{
				return false;
			}

			internal bool _003CIsDraggedThrough_003Eb__3(Vector2Int dCoord)
			{
				return false;
			}
		}

		public Vector2Int[] doorCoords;

		public int connectedRoom;

		public BaseObjectData.SSIHJRNKHTT direction;

		public bool KNIFMPEIEFG(Vector2Int HHIIELJQHEL)
		{
			return false;
		}
	}

	public int width;

	public int height;

	public Doors[] doors;

	private BaseObjectData.PFHSSTLRNHS[,] inspectorLayers;

	[HideInInspector]
	public BaseObjectData.PFHSSTLRNHS[] cellLayers;

	private BaseObjectData.PFHSSTLRNHS inspectorForceLayer;
}
