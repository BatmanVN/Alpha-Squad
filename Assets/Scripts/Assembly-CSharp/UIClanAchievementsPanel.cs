using System.Collections.Generic;
using UnityEngine;

public class UIClanAchievementsPanel : UIPanel
{
	[SerializeField]
	private UIClanAchievementCell achievementCellPrefab;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private Transform achievementHolder;

	[SerializeField]
	private SoundEffect openSoundEffect;

	[SerializeField]
	private SoundEffect claimSound;

	private bool QOOPLGKOOLG;

	private List<UIClanAchievementCell> NGSENMILRPO;

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public static bool IsAchievementValid(EOQPNKSSOTM.ClanAchievementConfig GJFPMSOEQTM)
	{
		return false;
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public void ClaimAchievement(UIClanAchievementCell GGOKJRGSMRT)
	{
	}

	public void RefreshAchievements()
	{
	}

	public void OnBack()
	{
	}
}
