using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MenuViewer : UIPanel
{
	[SerializeField]
	private MenuView[] views;

	[SerializeField]
	public MenuTileLayout tileLayout;

	[SerializeField]
	private ScrollRectStepped scroll;

	private bool QNFMLOOPTJO;

	private MenuView HGGHTIJFFSS;

	[NonSerialized]
	public bool enterDefaultView;

	[NonSerialized]
	public UIDirectorMenu.LJPHMKQSONN enterScreen;

	public static event Action<MenuView> OFEQRFJSMOK
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

	protected override void Awake()
	{
	}

	protected override void MGKPMPHSLFR()
	{
	}

	public override void OnRemove()
	{
	}

	protected override void Start()
	{
	}

	private void Update()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnTileClick(MenuTile JOTSJKFPFFF)
	{
	}

	public void EnterView<T>(bool KQGHGPEKKTJ = true) where T : MenuView
	{
	}

	public void OnScrollFinished(int FIPHTRRRPET)
	{
	}

	private void GFFFPJQQIJS(MenuView HGGHTIJFFSS = null)
	{
	}

	private void LGSSSNRGEPL(MenuView QLINOLJLIMP)
	{
	}

	public T GetView<T>() where T : MenuView
	{
		return null;
	}

	public void SetManualViewChangeEnabled(bool QHSMPFPKNMM)
	{
	}

	public void SetScrollEnabled(bool QHSMPFPKNMM)
	{
	}

	public void SetTileLayoutEnabled(bool QHSMPFPKNMM)
	{
	}

	public MenuView GetCurrentView()
	{
		return null;
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnBackButton()
	{
	}

	[CompilerGenerated]
	internal static bool ILKIFMPJJHQ<T>(MenuView QLINOLJLIMP) where T : MenuView
	{
		return false;
	}
}
