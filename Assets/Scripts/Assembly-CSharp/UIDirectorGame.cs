using UnityEngine;

public class UIDirectorGame : UIDirector
{
	[SerializeField]
	private PurchasesLoadingController purchasesLoadingPopup;

	public override void Start()
	{
	}

	protected override void OnDestroy()
	{
	}
}
