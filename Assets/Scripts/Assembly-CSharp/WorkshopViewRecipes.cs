using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WorkshopViewRecipes : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class JNNMOTPNPKL
	{
		public WorkshopRecipe.NOMPPKKTNOF category;

		public GameObject go;

		public WorkshopViewRecipes _003C_003E4__this;

		internal bool _003CSetup_003Eb__0(WorkshopRecipe x)
		{
			return false;
		}
	}

	[SerializeField]
	private WorkshopRecipeCell prefabWorkshopRecipeCell;

	[SerializeField]
	private GameObject prefabMoreRecipes;

	[SerializeField]
	private GameObject prefabSeparator;

	[Space]
	[SerializeField]
	private RectTransform cellParent;

	[SerializeField]
	private RectTransform scrollContent;

	[Space]
	[SerializeField]
	private GameObject tabGear;

	[SerializeField]
	private GameObject tabResources;

	[NonSerialized]
	public WorkshopPanel owner;

	[NonSerialized]
	public WorkshopRecipe.NOMPPKKTNOF currentTab;

	private List<WorkshopRecipeCell> LNOHFMJFPKP;

	public void Setup(WorkshopRecipe.NOMPPKKTNOF EMKNPKTIJPF = WorkshopRecipe.NOMPPKKTNOF.GEAR, bool TEENRGPFHKL = true)
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	public void OnCellClicked(WorkshopRecipe LQKPOLSLLJQ)
	{
	}

	public void OnGearTabClick()
	{
	}

	public void OnResourceTabClick()
	{
	}

	public void SetActiveTab(WorkshopRecipe.NOMPPKKTNOF KSIMSNROKFP)
	{
	}

	private void POLMTMFFPNE()
	{
	}

	private void KSNIEEQKETQ()
	{
	}

	public WorkshopRecipeCell GetCellForRecipeId(PJLTIFIPFSM EJTQSQFTLRR)
	{
		return null;
	}
}
