using System;
using UnityEngine;
using UnityEngine.UI;

public class AgentSkinCell : MonoBehaviour
{
	[NonSerialized]
	public AgentPanelSkinsCover owner;

	[SerializeField]
	private UIPlayerPreview preview;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image floorGlow;

	[SerializeField]
	private GameObject legendaryOverlays;

	[SerializeField]
	private GameObject selectedOverlays;

	[SerializeField]
	private GameObject selectedOverlay2;

	[SerializeField]
	private GameObject vipOverlays;

	[SerializeField]
	private Image activeOverlay;

	[SerializeField]
	private GameObject lockedOverlay;

	[SerializeField]
	private Image vipRays;

	[Space]
	[SerializeField]
	private Sprite backgroundRegular;

	[SerializeField]
	private Sprite backgroundLegendary;

	[SerializeField]
	private Sprite backgroundVip;

	[SerializeField]
	private Sprite spriteActiveLegendary;

	[SerializeField]
	private Sprite spriteActiveRegular;

	[SerializeField]
	private Sprite spriteActiveVip;

	[SerializeField]
	private Color colorGlowRegular;

	[SerializeField]
	private Color colorGlowLegendary;

	[SerializeField]
	private Color colorGlowVip;

	private bool SMJFTKGRFLJ;

	private bool ENEPLNPLJTO;

	private AgentData QPQITJOLQFS;

	private SkinData LSQFETTHSFJ;

	public void Setup(AgentData IFLMHEQTKLS, SkinData LPIPSETJMQR)
	{
	}

	public void SetupLocked()
	{
	}

	public bool Is(SkinData MHNOIFFONJM)
	{
		return false;
	}

	public SkinData GetSkinData()
	{
		return null;
	}

	private void KIQSKPJQGJH()
	{
	}

	public bool IsSelected()
	{
		return false;
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void OnClicked()
	{
	}

	public void UpdateState(SkinData EPTTIIQFGRS)
	{
	}
}
