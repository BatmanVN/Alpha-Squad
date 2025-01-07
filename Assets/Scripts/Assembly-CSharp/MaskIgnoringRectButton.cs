using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MaskIgnoringRectButton : UIBehaviour
{
	public Button.ButtonClickedEvent OnClick;

	public bool interactable;

	private Camera GKIELNGLQJL;

	private RectTransform IERIISNIJFH;

	private bool NOPTIKIRJMK;

	private readonly List<CanvasGroup> PLNSGQOQNOT;

	protected override void Start()
	{
	}

	protected override void OnCanvasGroupChanged()
	{
	}

	private void Update()
	{
	}

	public virtual bool IsInteractable()
	{
		return false;
	}
}
