using System;

[Serializable]
[Obsolete]
public struct GridObjectSave
{
	[Serializable]
	[Flags]
	public enum States
	{
		Interacted = 2
	}

	public int objectId;

	public int dirId;

	public States states;

	public int cellX;

	public int cellY;
}
