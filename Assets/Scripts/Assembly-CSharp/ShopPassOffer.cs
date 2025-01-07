using UnityEngine;
using UnityEngine.UI;

public class ShopPassOffer : ShopOffer
{
	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private Text labelSeason;

	[SerializeField]
	private Image seasonIcon;

	[SerializeField]
	private Image beams;

	public override bool IsAvailable()
	{
		return false;
	}

	public override void Setup(MenuViewShop QJPITOLEQFL)
	{
	}

	public override void InitPrice()
	{
	}

	public void Hide()
	{
	}

	public void OnClick()
	{
	}
}
