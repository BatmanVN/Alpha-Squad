using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopPanel : UIPanel
{
	[CompilerGenerated]
	private sealed class KEENFTNEQSK
	{
		public WorkshopPanel _003C_003E4__this;

		public bool leveledUp;

		public int wslvl;

		public int wsxpg;
	}

	[CompilerGenerated]
	private sealed class MPIRGOMRQGQ
	{
		public int lvl;

		public int goal;

		public KEENFTNEQSK CS_0024_003C_003E8__locals1;

		internal void _003CSetupUnderlay_003Eb__3(float x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class FOLEFFGLEJJ
	{
		public int lastXp;

		public KEENFTNEQSK CS_0024_003C_003E8__locals2;

		internal void _003CSetupUnderlay_003Eb__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class FELOJLRQROP
	{
		public int lvl;

		public int xpS;

		public int xpE;

		public FOLEFFGLEJJ CS_0024_003C_003E8__locals3;

		internal void _003CSetupUnderlay_003Eb__6()
		{
		}
	}

	[SerializeField]
	private WorkshopViewCraftInfo viewCraftInfo;

	[SerializeField]
	public WorkshopViewRecipes viewRecipes;

	[SerializeField]
	public WorkshopViewCrafting viewCraft;

	[SerializeField]
	public WorkshopViewSelect viewSelect;

	[SerializeField]
	public WorkshopViewFinishedCraft viewFinishedCraft;

	[SerializeField]
	public WorkshopViewAreYouSure viewAreYouSure;

	[SerializeField]
	private Text labelTitle;

	[SerializeField]
	private Text labelProgressAmount;

	[SerializeField]
	private SlicedFilledImage fillProgress;

	[SerializeField]
	private Animator underlayAnimator;

	private int IJEIPFGPIOI;

	private int JTMNTPPRMLI;

	private int FRKTHKPGGSF;

	private bool KGNOHPHLTTR;

	private static readonly int ITPIQLRKKQE;

	protected override void MGKPMPHSLFR()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private void MMQMHJTJJIK(bool KQGHGPEKKTJ = true)
	{
	}

	public void HideAllViews()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnExitButton()
	{
	}

	public void OpenCraftForRecipe(WorkshopRecipe LQKPOLSLLJQ)
	{
	}

	public void OnItemsReceived(List<LootElement> INNLJIGRFOG)
	{
	}

	public void OnInfoButton()
	{
	}

	private void NPIQFIHNGRG()
	{
	}

	private void FTKKSFEFGFS()
	{
	}

	public void HighlightRecipeButtons(PJLTIFIPFSM[] QLRGKROGIRR)
	{
	}

	[CompilerGenerated]
	private void NOTQHQJKMFG(WorkshopRecipe LQKPOLSLLJQ, float PRRKGRQILFR)
	{
	}
}
