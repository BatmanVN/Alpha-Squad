using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class RiftsPanelBracketElement : MonoBehaviour
{
	[SerializeField]
	private RiftsPanelFloorElement prefabFloor;

	[SerializeField]
	private GameModifierCell prefabModifierCell;

	[Space]
	[SerializeField]
	private RectTransform parentFloors;

	[SerializeField]
	private RectTransform parentModifiers;

	[SerializeField]
	private Text labelLvl;

	[SerializeField]
	private GameObject lockedOverlay;

	[SerializeField]
	private GameObject modifiersBlock;

	[SerializeField]
	private GameObject modifiersBg;

	[SerializeField]
	private Animator modifiersAnimator;

	[SerializeField]
	private Text labelIndex;

	[SerializeField]
	private ScrollRectEx modifiersScroll;

	private RiftsPanel FNJLLHKNGOR;

	private List<RiftsPanelFloorElement> FIRJMNOSPEN;

	private RiftConfig.BracketConfig FQRHETETEMR;

	private int GFEIKHSGFGR;

	private int NIQHMTPRKPJ;

	private bool PKGLSMJOJOT;

	public int bracketIndex;

	public void Setup(RiftConfig.BracketConfig SHQOQJQHGHS, int QFOPFRIRJGQ, int PEPHKOMTPTT, int ELEQGRTMIIP, RiftsPanel TNKMMOJJPPI, bool HLKTNOKPKOP, int FNJTIPFGTMS, int ROJTGEMRRLP)
	{
	}

	public void ResetBracket()
	{
	}

	public void RefreshBracket()
	{
	}

	public void SetupVisualsOnEnterNoAnim()
	{
	}

	public bool IsUnlockedCurrent()
	{
		return false;
	}

	public bool IsUnlockedReal()
	{
		return false;
	}

	private void ELEOJQHJTPK(int GHMJOHENJMQ, int ROJTGEMRRLP)
	{
	}

	private void HRFISTRLFPM(bool KQGHGPEKKTJ = false)
	{
	}

	private void ITHOLKRKINR()
	{
	}

	public void MoveConcentToLeft()
	{
	}

	public void StartFloorButton(int EERRGHKNKNK)
	{
	}

	public (Tween, int) PlayProgressAnimation(int STSFGQMGSNP, int EEHLRFERSGN, ref bool JQSENNJINNM)
	{
		return default((Tween, int));
	}

	[CompilerGenerated]
	private void NEOPOTGGKTR()
	{
	}
}
