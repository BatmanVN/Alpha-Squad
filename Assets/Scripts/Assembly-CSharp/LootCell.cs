using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class LootCell : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> amountBlocks;

	[SerializeField]
	protected Button buttonSelf;

	private bool QNHHGGTIGNF;

	public abstract Image GetBackground();

	public virtual void SetAmountShown(bool MHNOIFFONJM)
	{
	}

	public bool IsAmountShown()
	{
		return false;
	}

	public void SetButtonEnabled(bool MHNOIFFONJM)
	{
	}

	public bool IsInteractable()
	{
		return false;
	}
}
