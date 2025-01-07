using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UIClanHonorShopPanel : UIRoom
{
	public enum RPQNHJIOMRL
	{
		Items = 0,
		Skins = 1
	}

	[CompilerGenerated]
	private sealed class EKTFNEHFJPP
	{
		public UIClanHonorShopPanel _003C_003E4__this;

		public Action onSuccess;

		internal void _003CTryToPurchase_003Eb__0()
		{
		}
	}

	public static Action OnHonorShopClosed;

	[SerializeField]
	private List<GameObject> tabsSelected;

	[SerializeField]
	private Transform particleParent;

	[SerializeField]
	private ParticleSystem particlePrefab;

	[SerializeField]
	private GameObject itemsBlock;

	[SerializeField]
	private GameObject skinsBlock;

	[SerializeField]
	private HonorSkinsShop skinsShop;

	private ParticleSystem MHGHKTTPGHM;

	private RPQNHJIOMRL NQTPJLQQLRE;

	[SerializeField]
	private ClanBoothKeeper shopKeeper;

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void OJKOMSRTJKN()
	{
	}

	protected override void TPRKMSSROGR()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnTabItems()
	{
	}

	public void OnTabSkins()
	{
	}

	public void SetupBasedOnTabs()
	{
	}

	public override void TryToPurchase(EOQPNKSSOTM.ShopItem HPJMQLRTORF, UIShopElement MMFGGGGJGHJ = null, Action LNERFQEJNNE = null)
	{
	}

	public void OnPurchaseSucceeded()
	{
	}

	public override void OnBack()
	{
	}

	public override void StartCraftAnimation(UIShopElement MMFGGGGJGHJ)
	{
	}

	protected override void OLLLMQOKGEH(UIShopElement MMFGGGGJGHJ, ClanServerCalls.RpcResponse MHGSOKIEHQE)
	{
	}

	protected override void FIQJQNTMOKI(int QIROGTNPJFG, int SMJQEMMNNIG, LootList FJJJFHTQFHP)
	{
	}

	protected override void PITKGNKGRPS(Transform NTJQOGJKPQT)
	{
	}

	public override bool IsUnlockRequirementMet(EOQPNKSSOTM.ShopItem HPJMQLRTORF)
	{
		return false;
	}

	private bool HGNIRGJFJEE(EOQPNKSSOTM.ShopItem HPJMQLRTORF)
	{
		return false;
	}

	private bool KGOJJGIHGTQ(EOQPNKSSOTM.ShopItem HPJMQLRTORF, int GFEIKHSGFGR, int NIQHMTPRKPJ)
	{
		return false;
	}

	public override List<int> GetNewItems()
	{
		return null;
	}

	protected override string JTSQLOPPRTF()
	{
		return null;
	}

	public override bool HaveEnoughCurrency(int QIROGTNPJFG)
	{
		return false;
	}

	private void JITNJSQRJSO()
	{
	}
}
