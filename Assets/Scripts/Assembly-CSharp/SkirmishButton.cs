using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkirmishButton : MonoBehaviour
{
	[SerializeField]
	private SkirmishQuestRewardCell prefabRewardCell;

	[SerializeField]
	private GameObject prefabGambleDie;

	[SerializeField]
	private Image iconWorld;

	[SerializeField]
	private Image iconPlayMode;

	[SerializeField]
	private Image iconThreat;

	[SerializeField]
	private Image ribbonPlayMode;

	[SerializeField]
	private Text labelPlayType;

	[SerializeField]
	private Text labelThreat;

	[SerializeField]
	private RectTransform rewardsBlock;

	[SerializeField]
	private Animator threatAnimator;

	[SerializeField]
	private List<ParticleSystem> startParticles;

	public void Setup()
	{
	}

	public void OnTimerEnd()
	{
	}

	public void EnableStartParticles()
	{
	}
}
