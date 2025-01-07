using System;
using UnityEngine;
using UnityEngine.UI;

public class BaseObjUIElement : MonoBehaviour
{
	public enum HIGINOOHREN
	{
		Invalid = 0,
		Blueprint = 1,
		Storage = 2
	}

	public static Action<BaseItemSave, bool, BaseObjUIElement> onItemSelected;

	[SerializeField]
	private Image iconImg;

	[SerializeField]
	private Image rarityImg;

	public HIGINOOHREN type;

	[SerializeField]
	private Text countLabel;

	[SerializeField]
	private Text priceLabel;

	[SerializeField]
	private GameObject pricePanel;

	[SerializeField]
	private GameObject newLabel;

	[SerializeField]
	private GameObject isInteractableIcon;

	[SerializeField]
	private GameObject prestigeIncrease;

	[SerializeField]
	private GameObject seasonObject;

	[SerializeField]
	private Text seasonText;

	[SerializeField]
	private Text idText;

	[SerializeField]
	private GameObject debugIsMirrorableIcon;

	private BaseItemSave HPJMQLRTORF;

	private int TISJIOHIGFO;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void SetupDisplay(BaseObjectData HFNFSIESRKF, bool OQKSPNKJHSQ = true)
	{
	}

	private void KQEFPGFOLHE(int PNKSKFFMKMF, BaseObjectData HFNFSIESRKF, int SGNNHEROROI = -1, bool OQKSPNKJHSQ = true, bool THLEITEHLEO = false)
	{
	}

	private static bool LOELGGGIRRK(BaseObjectData HFNFSIESRKF)
	{
		return false;
	}

	public virtual void Setup(BaseItemSave IOGMNEPJEEM, BaseObjectData HFNFSIESRKF, int SGNNHEROROI = -1, bool OQKSPNKJHSQ = true, bool THLEITEHLEO = false)
	{
	}

	private void PHTJPJLLERQ(BaseObjectData HFNFSIESRKF, BaseItemSave IOGMNEPJEEM)
	{
	}

	public int GetObjectId()
	{
		return 0;
	}

	public virtual void HideCount()
	{
	}

	public void OnClick()
	{
	}

	private void HGNQIPKSTKJ()
	{
	}

	private void OGILPQFQPMK(int PNKSKFFMKMF)
	{
	}

	private void NMLLFKRNOHR()
	{
	}

	private void NGJHIHNLTNP(bool RRPSNPOTQNT)
	{
	}

	public void ToggleInteractable(bool LKKOESPTGSK)
	{
	}

	public Button GetElementButton()
	{
		return null;
	}
}
