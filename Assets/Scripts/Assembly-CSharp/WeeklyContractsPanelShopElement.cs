using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeeklyContractsPanelShopElement : MonoBehaviour
{
	public enum NLLNSSNERIE
	{
		SUCCESS = 0,
		NOT_ENOUGH_COINS = 1,
		NOT_ENOUGH_LEVEL = 2,
		SOLD_OUT = 3,
		UNKNOWN = 404
	}

	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private CardCellVisual item;

	[SerializeField]
	private GameObject overlayPurchased;

	[SerializeField]
	private GameObject blockAccountLevel;

	[SerializeField]
	private Text accountLevelLabel;

	[SerializeField]
	private GameObject priceBlock;

	[SerializeField]
	private RectTransform claimedMark;

	[SerializeField]
	private GameObject purchaseCountBlock;

	[SerializeField]
	private Text labelPurchaseCount;

	[SerializeField]
	private Transform particlesPosition;

	[SerializeField]
	private GameObject weaponPartSelect;

	[SerializeField]
	private Text labelAmountWeaponPartSelect;

	[SerializeField]
	private Image backgroundWeaponPartSelect;

	private IMTOMKMLMSK.ShopItem TSRPFHOJKSG;

	private bool INJHILSGRPL;

	private GameObject LSIHGRMKHQQ;

	public event Action<NLLNSSNERIE> ISPORJTIGOT
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public bool Setup(IMTOMKMLMSK.ShopItem MTLGKNIHTMR)
	{
		return false;
	}

	public void CreateCover()
	{
	}

	public void DestroyCover()
	{
	}

	private Image MIEREIMFIHM()
	{
		return null;
	}

	private void PNTFONJOKKT()
	{
	}

	private void PGLIONNHHPM()
	{
	}

	private Transform JMQOTIQERSK()
	{
		return null;
	}

	public LootElement GetLootReward()
	{
		return default(LootElement);
	}

	public int GetPrice()
	{
		return 0;
	}

	public IMTOMKMLMSK.ShopItem GetData()
	{
		return default(IMTOMKMLMSK.ShopItem);
	}

	public CardCellVisual GetCellVisual()
	{
		return null;
	}

	public void OnClick()
	{
	}

	[CompilerGenerated]
	private void GTKJINNIEOL()
	{
	}
}
