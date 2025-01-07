using System;
using UnityEngine;

public class ChestAnimationListener : MonoBehaviour
{
	public Transform sparksLocation;

	public Action OnAnimatorFree;

	public Action OnDrop;

	public Action OnOpen;

	public Action OnInitialOpen;

	public void OnEnterIdleState()
	{
	}

	public void OnAppearEnded()
	{
	}

	public void LootBoxDrop()
	{
	}

	public void OpenSparks()
	{
	}

	public void InitialOpen()
	{
	}
}
