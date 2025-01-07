using UnityEngine;

public class UIDirectorClanBase : UIDirector
{
	[SerializeField]
	private PurchasesLoadingController purchasesLoadingPopup;

	public override void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	public bool IsAnyLivePopup()
	{
		return false;
	}

	public void HideUI(bool RRPSNPOTQNT)
	{
	}
}
