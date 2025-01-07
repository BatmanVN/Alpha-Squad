using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class EventLaptop : MonoBehaviour
{
	public enum HPGFRKLLSLM
	{
		Idle = 0,
		IdleGem = 1,
		RewardQ1 = 2,
		RewardQ2 = 3,
		RewardSimple1 = 4,
		RewardSimple2 = 5,
		Rolling1 = 6,
		Rolling2 = 7,
		Denying = 8
	}

	[SerializeField]
	private SerializableDictionary<HPGFRKLLSLM, LaptopMoodData> moods;

	[SerializeField]
	private Image moodDisplay;

	[SerializeField]
	private Image pixelShadowDisplay;

	private const float HGQTTNILPGF = 0.04f;

	private Tween JTEMHIGHRHE;

	private LaptopMoodData RPHJTEGHFJH;

	private Coroutine ITJQOTNPRMS;

	private IEnumerator SPSIQLHPLKJ()
	{
		return null;
	}

	public void PlayMood(HPGFRKLLSLM GEELOQGJNLP)
	{
	}

	private void OnEnable()
	{
	}
}
