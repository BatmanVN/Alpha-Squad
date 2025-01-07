using System;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class BaseItemSave
{
	[Serializable]
	[Flags]
	public enum States
	{
		Interacted = 2,
		Mirrored = 4
	}

	public enum GRQGRGGHHIH
	{
		Default = 0,
		Device = 1,
		RiftTrophy = 2
	}

	public ObscuredInt id;

	public int x;

	public int y;

	public int dir;

	public States states;

	public GRQGRGGHHIH type;

	public ObscuredInt paramInt1;

	public BaseItemSave()
	{
	}

	public BaseItemSave(int HSLQJLPMLMH)
	{
	}

	public BaseItemSave(int HSLQJLPMLMH, GRQGRGGHHIH EOOEIROQJOE)
	{
	}

	public virtual bool OLNNMNLOHQM(BaseItemSave FKQLEGQSLHF)
	{
		return false;
	}

	public virtual bool JMGNKMTJKPE()
	{
		return false;
	}

	public BaseItemSave KENFNEGQKSN()
	{
		return null;
	}

	public int KHGOHQLJOJH()
	{
		return 0;
	}

	public BaseItemSave EMHTREEOMMT(BaseItemSave FKQLEGQSLHF)
	{
		return null;
	}
}
