using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WeaponPopupSideButtons : MonoBehaviour
{
	[SerializeField]
	private Button buttonCompare;

	[SerializeField]
	private Button buttonMax;

	[SerializeField]
	private Button buttonEquip;

	[Space]
	[SerializeField]
	private GameObject checkmarkMax;

	public UnityEvent OnCompareButton;

	public UnityEvent OnMaxButton;

	public UnityEvent OnEquipButton;

	private bool MHPTMEQOHLG;

	public void SetupDefault(bool NNOHFOJKIMS = false)
	{
	}

	public void SetupPreview(bool SNQKRQSTKPI = true)
	{
	}

	public void SetupPurchase()
	{
	}

	public void HideAll()
	{
	}

	public void SetShowingMaxed(bool FFENFPOEHRG)
	{
	}

	public void ToggleShowingMaxed()
	{
	}

	public bool IsShowingMaxed()
	{
		return false;
	}

	public void EquipButton()
	{
	}

	public void MaxButton()
	{
	}

	public void CompareButton()
	{
	}
}
