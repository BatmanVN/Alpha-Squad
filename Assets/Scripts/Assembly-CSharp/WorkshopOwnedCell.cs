using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopOwnedCell : MonoBehaviour
{
	[SerializeField]
	private LootElementUICell cell;

	[SerializeField]
	private LayoutElement layoutElement;

	[Space]
	[SerializeField]
	private GameObject equippedOverlay;

	[SerializeField]
	private List<GameObject> loadoutLocks;

	[SerializeField]
	private GameObject lockIcon;

	[SerializeField]
	private GameObject addIcon;

	[NonSerialized]
	public bool updated;

	private float KJHNSENKHEL;

	private float MJJMSPJMNQQ;

	private LootElement OMTNTFSPSJM;

	public event Action<WorkshopOwnedCell> IPTJEKORJRN
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Setup(LootElement INNLJIGRFOG, bool OIJJTLFRFQO)
	{
	}

	private void NHJJMHKNIHQ(LootElement INNLJIGRFOG)
	{
	}

	public void AnimUpdate()
	{
	}

	public void AnimAppear()
	{
	}

	public void OnButtonClick()
	{
	}

	public bool IsClickAllowed()
	{
		return false;
	}

	public LootElement GetLootElement()
	{
		return default(LootElement);
	}
}
