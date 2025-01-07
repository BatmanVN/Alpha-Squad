using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailItemWithReward : MailItem
{
	[SerializeField]
	protected Image itemImage;

	[SerializeField]
	protected GameObject glow;

	[SerializeField]
	protected Sprite spriteRewardActive;

	[SerializeField]
	protected Sprite spriteNoReward;

	[SerializeField]
	protected GameObject updateButton;

	[SerializeField]
	protected GameObject supportButton;

	[SerializeField]
	protected GameObject discordButton;

	[SerializeField]
	protected GameObject claimButton;

	[SerializeField]
	protected GameObject claimButtonDisabled;

	[SerializeField]
	protected Text claimButtonDisabledLabel;

	[SerializeField]
	protected GameObject claimButtonBlik;

	[SerializeField]
	protected GameObject rewardsContainer;

	[SerializeField]
	protected RDisplay rDisplay;

	public override void Setup(KMFIJTNRRFS.Mail NHGSHOSQRFQ)
	{
	}

	public override float GetExtraHeight()
	{
		return 0f;
	}

	protected override bool JIQNTFRLELO()
	{
		return false;
	}

	private void PHTSTJJSLFI(bool LKHQFGQPINQ)
	{
	}

	public void OnClaimButton()
	{
	}

	public void OnUpdateButton()
	{
	}

	private bool PLTOJPEQGPI()
	{
		return false;
	}

	private bool LRFRSTGEQHS(List<R> NPTGGGGSFTE)
	{
		return false;
	}
}
