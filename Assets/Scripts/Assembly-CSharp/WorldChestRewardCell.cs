using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WorldChestRewardCell : MonoBehaviour
{
	public enum LPTNRPHMQJL
	{
		CLAIMED = 0,
		CLICKABLE = 1,
		REGULAR = 2
	}

	[Serializable]
	public struct GameObjectsForChestRarity
	{
		public ChestController.MFRETPOLGOE quality;

		public GameObject go;
	}

	[CompilerGenerated]
	private sealed class FTSJOITLSKK
	{
		public ChestController.MFRETPOLGOE rarity;

		internal void _003CSetup_003Eb__0(GameObjectsForChestRarity c)
		{
		}
	}

	[SerializeField]
	private RectTransform backgroundClickable;

	[SerializeField]
	private RectTransform chestIconParent;

	[SerializeField]
	private Button buttonMe;

	[SerializeField]
	private Text labelOpen;

	[SerializeField]
	private Text labelRequirement;

	[SerializeField]
	private GameObject checkmark;

	[SerializeField]
	private CanvasGroup canvas;

	[SerializeField]
	private List<GameObjectsForChestRarity> chestReferences;

	[SerializeField]
	private float chestYClickable;

	[SerializeField]
	private float chestYRegular;

	[SerializeField]
	private float chestScaleClickable;

	[SerializeField]
	private float chestScaleRegular;

	public void Setup(ChestController.MFRETPOLGOE MOTTITEELQF, LPTNRPHMQJL MJPJLPIKQFE, int LSGHOSTOGTM)
	{
	}

	public void SetStateClickable(LPTNRPHMQJL MJPJLPIKQFE)
	{
	}

	public void OnClick()
	{
	}
}
