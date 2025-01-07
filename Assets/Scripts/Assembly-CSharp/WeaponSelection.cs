using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeaponSelection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class FPHNHPPTOSE
	{
		public WeaponData weaponData;

		internal bool _003CGetItem_003Eb__0(WeaponSelectionItem i)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QSLOQHFMGHS
	{
		public WeaponData weaponData;

		internal bool _003CIndexOfItem_003Eb__0(WeaponSelectionItem i)
		{
			return false;
		}
	}

	public static Action<WeaponSelectionItem> OnWeaponSelectionItemClicked;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private WeaponSelectionItem itemPrefab;

	[SerializeField]
	private Transform listTransform;

	[NonSerialized]
	public List<WeaponSelectionItem> items;

	private void Awake()
	{
	}

	private void GEKTRFITETP()
	{
	}

	private void HPHINJJPLQI(WeaponInfo JFOHOOPNEKE)
	{
	}

	public void Setup()
	{
	}

	private void Update()
	{
	}

	public void UpdateEmptyItem(int PSPJIJNTMOI)
	{
	}

	private void ERNJNLPPIPM()
	{
	}

	public WeaponSelectionItem GetItem(WeaponData KROTEKTFGLI)
	{
		return null;
	}

	public int IndexOfItem(WeaponData KROTEKTFGLI)
	{
		return 0;
	}
}
