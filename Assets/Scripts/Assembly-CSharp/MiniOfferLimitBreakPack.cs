using UnityEngine;

public class MiniOfferLimitBreakPack : MiniOfferBase
{
	[SerializeField]
	private UITextTimer timer;

	[SerializeField]
	private MenuChestCardWeaponParts[] parts;

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
