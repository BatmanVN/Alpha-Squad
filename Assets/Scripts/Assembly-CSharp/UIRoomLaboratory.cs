using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class UIRoomLaboratory : UIRoom
{
	public enum RGLHHOFPFMK
	{
		Damage = 0,
		CritChance = 1,
		CritDamage = 2,
		CooldownReduction = 3,
		Health = 4,
		AllResistance = 5
	}

	[Serializable]
	public struct BoostLevel
	{
		public RGLHHOFPFMK boost;

		public int level;
	}

	[SerializeField]
	private UIRoomBoosterElement boosterPrefab;

	private List<UIRoomBoosterElement> NNIQGGQJIHT;

	private static float[] GTESOGGJTFP;

	public static void ApplyBoostsToImprovements(List<BoostLevel> GOKEHIEESMJ, MTGKQSJELIM JTKONROLIJE)
	{
	}

	public static void Clear()
	{
	}

	public static float GetBoostValuePerLevel(RGLHHOFPFMK JPLFGIEHPJE)
	{
		return 0f;
	}

	public static string GetBoostValueForVisual(RGLHHOFPFMK JPLFGIEHPJE, int IQLQQNIPTPQ)
	{
		return null;
	}

	public static Sprite GetBoostIcon(RGLHHOFPFMK JPLFGIEHPJE)
	{
		return null;
	}

	public static string GetBoostName(RGLHHOFPFMK JPLFGIEHPJE)
	{
		return null;
	}

	protected override void TPRKMSSROGR()
	{
	}

	public Task OnClickUpgrade(UIRoomBoosterElement MMFGGGGJGHJ)
	{
		return null;
	}

	public void OnClickAssist(UIRoomBoosterElement MMFGGGGJGHJ)
	{
	}

	public void OnClickFinish(UIRoomBoosterElement MMFGGGGJGHJ)
	{
	}

	protected override void NJPGIPPLNNI()
	{
	}
}
