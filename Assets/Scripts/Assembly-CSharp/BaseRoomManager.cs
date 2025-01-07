using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BaseRoomManager : MonoBehaviour
{
	public static Action<int> OnActiveRoomChanged;

	public static BaseRoomManager Instance;

	[NonSerialized]
	public List<BaseRoom> enteredRooms;

	[SerializeField]
	private GameObject gridVisualPrefab;

	[SerializeField]
	[HideInInspector]
	private List<Vector2Int> roomSizes;

	[SerializeField]
	private List<BaseRoom> rooms;

	private int JIFGHLSQTOO;

	public List<BaseRoom> TTMSMGNTRGI => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void CreateRooms()
	{
	}

	private void MGNJOLMJGMF(int OJJLFPMNEHN, BaseRoomData TSRPFHOJKSG)
	{
	}

	private GameObject KFJJGTOIKIF(Vector3 KRKILIKILSS, Vector2Int QMHFIQMSKQJ)
	{
		return null;
	}

	public void SetActiveRoom(int TJGIJMGHHON)
	{
	}

	private void JPEQEPHOTOQ(int SLIEEELQMQS)
	{
	}

	private void KJJHFJOGJNG()
	{
	}

	public void RegenerateRoomFrames()
	{
	}

	public void TogglePlacedObjectColliders(bool RRPSNPOTQNT, BaseObject EQGSNMQTMGG = null)
	{
	}

	public void UpdateLayouts()
	{
	}

	public BaseRoom GetCurrentRoom()
	{
		return null;
	}

	public bool CanBuildInCurrent()
	{
		return false;
	}

	public List<BaseObject> GetPlacedObjects(int SLIEEELQMQS = -1)
	{
		return null;
	}

	public List<BaseObject> GetPlacedObjects(BaseRoom SLIEEELQMQS)
	{
		return null;
	}

	public void UpdateRoomStyle(bool TEENRGPFHKL = true)
	{
	}

	public void PreviewRoomStyle(int KKONMSSJLKS)
	{
	}

	public void AdjustRoomsForNeighbors()
	{
	}

	public GameObject FindObjectById(int HSLQJLPMLMH, int OJJLFPMNEHN = -1)
	{
		return null;
	}

	public void SetActiveRoom(BaseRoom SLIEEELQMQS)
	{
	}

	public int GetActiveRoomId()
	{
		return 0;
	}

	public BaseRoom GetRoom(int HSLQJLPMLMH)
	{
		return null;
	}

	public int GetRoomId(BaseRoom SLIEEELQMQS)
	{
		return 0;
	}

	public void ActivateClaimableRoom()
	{
	}

	public bool IsRoomReachable(int SLIEEELQMQS)
	{
		return false;
	}

	public void EnterRoom(BaseRoom SLIEEELQMQS)
	{
	}

	public void ExitRoom(BaseRoom SLIEEELQMQS)
	{
	}

	private void EEOQNMJEHHK()
	{
	}

	[CompilerGenerated]
	private bool IRLKHPJKQNP(int HSLQJLPMLMH)
	{
		return false;
	}

	[CompilerGenerated]
	private bool HTPMLNKKPNN(int HSLQJLPMLMH)
	{
		return false;
	}
}
