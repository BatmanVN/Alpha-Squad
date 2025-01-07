using UnityEngine;
using UnityEngine.UI;

public class UIShopElement : MonoBehaviour
{
	[SerializeField]
	protected Text limitText;

	[SerializeField]
	protected Text costText;

	[SerializeField]
	protected Text requiredLevelText;

	[SerializeField]
	protected GameObject stateCooldown;

	[SerializeField]
	protected GameObject stateLocked;

	[SerializeField]
	protected GameObject cellDarken;

	[SerializeField]
	private Transform floatingTextPos;

	[SerializeField]
	private GameObject newBadge;

	private RectTransform IERIISNIJFH;

	protected UIRoom FNJLLHKNGOR;

	protected EOQPNKSSOTM.ShopItem HPJMQLRTORF;

	protected LootIdentifier GTNLNSRKHET;

	protected bool PQPGFQQNQKQ;

	public virtual void Setup(EOQPNKSSOTM.ShopItem MSHFNNSJFPT, UIRoom FNJLLHKNGOR)
	{
	}

	public virtual void SetupItemInfo(EOQPNKSSOTM.ShopItem MSHFNNSJFPT)
	{
	}

	protected virtual void PHTSTJJSLFI(LootIdentifier GTNLNSRKHET, bool PQPGFQQNQKQ)
	{
	}

	protected virtual void JEOJEEHITRE(EOQPNKSSOTM.ShopItem MSHFNNSJFPT)
	{
	}

	protected virtual int LNLFMQOKELN(EOQPNKSSOTM.ShopItem MSHFNNSJFPT)
	{
		return 0;
	}

	public void Refresh()
	{
	}

	protected virtual void SSJMPTFGPOP(bool IJHNLHLIFKG, bool TEILKPETLEJ)
	{
	}

	public virtual bool HaveEnoughCurrency()
	{
		return false;
	}

	public int GetCost()
	{
		return 0;
	}

	protected virtual void IORNHPGORPS(bool TEILKPETLEJ)
	{
	}

	protected virtual void OSREELPOFOG(int OHLSPMTFTIM)
	{
	}

	public EOQPNKSSOTM.ShopItem GetItem()
	{
		return null;
	}

	public LootIdentifier GetLoot()
	{
		return default(LootIdentifier);
	}

	public int GetAmount()
	{
		return 0;
	}

	public Transform GetFloatingTextPos()
	{
		return null;
	}

	public RectTransform GetRect()
	{
		return null;
	}
}
