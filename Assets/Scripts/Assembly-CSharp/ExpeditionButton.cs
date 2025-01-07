using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpeditionButton : MonoBehaviour
{
	[SerializeField]
	private Text labelProgress;

	[SerializeField]
	private SlicedFilledImage fillProgress;

	[SerializeField]
	private UITextTimer timerTries;

	[SerializeField]
	private RectTransform triesRemaining;

	[SerializeField]
	private ExpeditionLevelRewardList nextRewards;

	[SerializeField]
	private ExpeditionLevelRewardList topReward;

	[SerializeField]
	private Image worldPhoto;

	[Space]
	[SerializeField]
	private Text labelEndsIn;

	[SerializeField]
	private GameObject viewRegular;

	[SerializeField]
	private GameObject viewCompleted;

	[SerializeField]
	private List<ParticleSystem> startParticles;

	public void Setup()
	{
	}

	public void SetupRegular()
	{
	}

	public void SetupCompleted()
	{
	}

	public void OnTimerUp()
	{
	}

	public void SetupTimers()
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	public void EnableStartParticles()
	{
	}
}
