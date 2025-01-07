using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoadoutButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	public enum PLPQNTLLGES
	{
		None = 0,
		PlayerLevel = 1,
		Gems = 2
	}

	private const float NNGKNPFFRSF = 0.15f;

	private const float OSJEGPGQSHR = 0.45f;

	[SerializeField]
	private int index;

	[SerializeField]
	private PLPQNTLLGES unlockType;

	[SerializeField]
	private Text title;

	[SerializeField]
	private GameObject lockObject;

	[SerializeField]
	private GameObject selectedObject;

	[SerializeField]
	private GameObject profileBlock;

	[SerializeField]
	private GameObject profileActiveDot;

	[SerializeField]
	private GameObject profileLoadingDot;

	[SerializeField]
	private Image profileLoadingFill;

	private MenuViewInventory TLNEKIPINSH;

	private bool PKGLSMJOJOT;

	private bool QOOPLGKOOLG;

	private float NKEQIOGKLNM;

	private bool OKRTQKGJHLK;

	public void Setup(MenuViewInventory LERGTKNMHTG)
	{
	}

	public void SetLocked(bool HLKTNOKPKOP)
	{
	}

	public void OnClick()
	{
	}

	public void SetSelected(bool ILSTPSQKNNP)
	{
	}

	public void SetProfileActive(bool SMJFTKGRFLJ)
	{
	}

	private void EEILKSENFJK()
	{
	}

	private void Update()
	{
	}

	public virtual void PlayFillSFX(float NGLJJHHTQTH)
	{
	}

	private void RIFFSHFTIJR()
	{
	}

	public void OnPointerDown(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerUp(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerExit(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerEnter(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerClick(PointerEventData QSSIJRMPEQF)
	{
	}
}
