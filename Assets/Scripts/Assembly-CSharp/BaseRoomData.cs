using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class BaseRoomData
{
	public enum FLRJREHIJKL
	{
		INVALID = 0,
		UNAVAILABLE = 1,
		UNLOCKED = 2,
		CAN_BUILD = 3,
		BUILDING = 4,
		CAN_CLAIM = 5,
		BUILT = 6
	}

	public FLRJREHIJKL state;

	public int frame;

	public ObscuredLong timestamp;

	[Obsolete]
	public List<GridObjectSave> gridObjects;

	public List<BaseItemSave> placedObjects;

	public void NFINNIKNGKE()
	{
	}

	public void HRMSPHLJPFH()
	{
	}

	public void JMHFORLIGLL(List<BaseObject> OSNPKEOLNOS)
	{
	}
}
