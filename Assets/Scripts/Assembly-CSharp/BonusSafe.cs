using UnityEngine;
using UnityEngine.UI;

public class BonusSafe : MonoBehaviour
{
	private enum FLIFTOGGOJK
	{
		LOCKED = 0,
		IN_PROGRESS = 1,
		CLAIM = 2,
		COMPLETED = 3
	}

	[SerializeField]
	private GameObject lockedState;

	[SerializeField]
	private GameObject inProgressState;

	[SerializeField]
	private GameObject claimState;

	[SerializeField]
	private GameObject completedState;

	[SerializeField]
	private RectTransform cashRect;

	[SerializeField]
	private GameObject increaseCashAd;

	[SerializeField]
	private Text safeFullAmountCash;

	[SerializeField]
	private Text inProgressInfoLabel;

	[SerializeField]
	private Text inProgressLeftLabel;

	[SerializeField]
	private Text claimAmountLabel;

	[SerializeField]
	private Text lockedInfoLabel;

	[SerializeField]
	private Text labelSafeInfo;

	[SerializeField]
	private Text labelSafeInfoTop;

	[SerializeField]
	private Text labelPriceRefill;

	[SerializeField]
	private Image progressBar;

	private void JKMJHHLLITS(FLIFTOGGOJK MJPJLPIKQFE)
	{
	}

	public void OnEnable()
	{
	}

	private void JIQOQGNHLFO()
	{
	}

	public void OnClaimButtonClick()
	{
	}

	public void OnResetSafeButton()
	{
	}
}
