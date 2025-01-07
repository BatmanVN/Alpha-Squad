using UnityEngine;
using UnityEngine.UI;

public class LimitBreakMaterialRequirementCell : MonoBehaviour
{
	[SerializeField]
	private Text nameLabel;

	[SerializeField]
	private Text infoLabel;

	[SerializeField]
	private Text rarityLabel;

	[SerializeField]
	private Image checkmark;

	[SerializeField]
	private Image cross;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image background;

	[SerializeField]
	private RectTransform visual;

	public JJHFPNTSRLT.WeaponPart weaponPart;

	public void Show(bool KQGHGPEKKTJ = true, float PRRKGRQILFR = 0f)
	{
	}

	public void Setup(JJHFPNTSRLT.WeaponPart FHQPKFMENGQ)
	{
	}

	public GameObject CreateFlyableIcon(Transform JKFPSLRREIJ)
	{
		return null;
	}

	public bool EnoughMats()
	{
		return false;
	}

	public void OnClick()
	{
	}

	public void HighlightAnimation()
	{
	}
}
