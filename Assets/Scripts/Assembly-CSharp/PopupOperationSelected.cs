using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PopupOperationSelected : UIPopup
{
	[CompilerGenerated]
	private sealed class NGIEQGNPRQS
	{
		public OperationController.JMSSNJLGTFN diff;

		internal bool _003CInit_003Eb__0(JJHFPNTSRLT.DifficultyColor x)
		{
			return false;
		}

		internal bool _003CInit_003Eb__1(JJHFPNTSRLT.DifficultyColor x)
		{
			return false;
		}

		internal bool _003CInit_003Eb__2(JJHFPNTSRLT.DifficultyBackground x)
		{
			return false;
		}

		internal bool _003CInit_003Eb__3(JJHFPNTSRLT.DifficultySprite x)
		{
			return false;
		}

		internal bool _003CInit_003Eb__4(JJHFPNTSRLT.DifficultyColor x)
		{
			return false;
		}
	}

	[NonSerialized]
	public MenuViewOperations owner;

	[Space]
	[SerializeField]
	private FloatingErrorText prefabFloatingErrorText;

	[SerializeField]
	private GambleVisual gambleVisualList;

	[SerializeField]
	private Image backgroundImg;

	[SerializeField]
	private Image backgroundTiles;

	[SerializeField]
	private Image titleBg;

	[SerializeField]
	private Image lightBeams;

	[SerializeField]
	private Image glow;

	[SerializeField]
	private Image chestIcon;

	[SerializeField]
	private Image chestGlow;

	[SerializeField]
	private Text chestTitle;

	[SerializeField]
	private Text labelPrice;

	[SerializeField]
	private List<JJHFPNTSRLT.DifficultyImage> icons;

	[SerializeField]
	private List<JJHFPNTSRLT.DifficultySprite> titleBackgrounds;

	[SerializeField]
	private List<JJHFPNTSRLT.DifficultyColor> beamColors;

	[SerializeField]
	private List<JJHFPNTSRLT.DifficultyColor> glowColors;

	[SerializeField]
	private List<JJHFPNTSRLT.DifficultyColor> chestGlowColors;

	[SerializeField]
	private List<JJHFPNTSRLT.DifficultyBackground> backgroundColors;

	[SerializeField]
	private Text operationTitle;

	[SerializeField]
	private Text operationXpGain;

	[SerializeField]
	private Text operationPassXpGain;

	[SerializeField]
	private GameObject xpPassBlock;

	[Space]
	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private Button buttonClose;

	[SerializeField]
	private Button buttonPlay;

	[SerializeField]
	private Button buttonInstant;

	[SerializeField]
	private GameObject prestigeIcon;

	[NonSerialized]
	public OperationCell exCell;

	private Material FQKERJOJOGO;

	private Tween NENEQLQIKEI;

	public void Open(OperationCell GGOKJRGSMRT, MenuViewOperations FNJLLHKNGOR)
	{
	}

	private void MLNESSGJRME()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Hide(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnPlayButton()
	{
	}

	public void OnInstantCompleteButton()
	{
	}

	private void KMQIMTNTOMN(Transform HSSNSPQEIGR, string HETQTIKJGNI, bool FNEHITKNEGR = true)
	{
	}

	[CompilerGenerated]
	private void QSHHEHTSLEE()
	{
	}
}
