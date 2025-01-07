using UnityEngine;

public class ClanBotData : ScriptableObject
{
	public enum SENLJTHJOHI
	{
		Weapon = 0,
		Sit = 1,
		Stand = 2,
		Wall = 3,
		RailFront = 4,
		RailBack = 5,
		Box = 6
	}

	public enum NRKITGRESJJ
	{
		Invalid = 0,
		Idle1 = 1,
		Idle2 = 2,
		ConvoLeft = 3,
		ConvoRight = 4,
		Tablet = 5,
		Work = 6,
		Other = 7
	}

	public SerializableDictionary<SENLJTHJOHI, AnimatorOverrideController> overrides;

	public AnimationTypeMap gunAnimationMap;

	public GameObject tabletPrefab;

	public AnimatorOverrideController MNJRPOIQHJJ(SENLJTHJOHI EOOEIROQJOE)
	{
		return null;
	}

	public int KJTMISKGILM(NRKITGRESJJ HMRISTHTFOE)
	{
		return 0;
	}
}
