using UnityEngine;

public class MiniOfferGearBoosters : MiniOfferBase
{
	[SerializeField]
	private UITextTimer timer;

	public override void Init()
	{
	}

	public override void OnClick()
	{
	}

	public override bool ShouldShow()
	{
		return false;
	}
}
