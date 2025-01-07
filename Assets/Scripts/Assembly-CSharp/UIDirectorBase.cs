using UnityEngine;

public class UIDirectorBase : UIDirector
{
	[SerializeField]
	private PurchasesLoadingController purchasesLoadingPopup;

	public override void Start()
	{
	}

	public bool IsAnyViewActive()
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	public bool IsAnyLivePopup()
	{
		return false;
	}

	public void Update()
	{
	}
}
