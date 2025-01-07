using RemoteOffers;
using UnityEngine;
using UnityEngine.UI;

public class MiniOfferRemoteTriple : MiniOfferRemoteBase_ProductMultiple
{
	[SerializeField]
	private UITextTimer timer;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image icon;

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

	public override void SetupRemoteOffer(RemoteOfferData GLNTLSLQFFS)
	{
	}
}
