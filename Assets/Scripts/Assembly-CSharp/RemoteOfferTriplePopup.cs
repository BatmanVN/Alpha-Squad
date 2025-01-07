using System;
using RemoteOffers;
using UnityEngine;
using UnityEngine.UI;

public class RemoteOfferTriplePopup : RemoteOfferPopupBase_ProductMultiple
{
	[Serializable]
	private struct RewardBlock
	{
		public RectTransform rewardParent;

		public GameObject coverPurchased;

		public Text labelTitle;

		public Text labelRemaining;

		public GameObject blockRemaining;

		public GameObject blockTitle;

		public LootListLayoutRows lootLayout;
	}

	[SerializeField]
	private SmallCellVisual prefabLoot;

	[SerializeField]
	private RewardBlock[] rewardBlocks;

	[SerializeField]
	private GameObject buyButtonFirst;

	[SerializeField]
	private GameObject buyButtonSecond;

	[SerializeField]
	private GameObject buyButtonThird;

	public static void Open(RemoteOfferData GLNTLSLQFFS, bool PRLEJONOPLK = true)
	{
	}

	protected override bool MLNESSGJRME(RemoteOfferData GLNTLSLQFFS)
	{
		return false;
	}

	private void PKPFTNINPEP()
	{
	}

	public void OnBuyButtonFirst()
	{
	}

	public void OnBuyButtonSecond()
	{
	}

	public void OnBuyButtonThird()
	{
	}
}
