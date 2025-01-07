using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SkirmishPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class SFKMLNSRJQN
	{
		public GameModifierTiered modifier;

		public Transform c;

		public int t;

		public SkirmishPopup _003C_003E4__this;

		internal void _003CInitModifiers_003Eb__2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class RGPSNNNIJHJ
	{
		public GameModifierTiered modifier;

		internal bool _003CTryRefreshModifiers_003Eb__0(GameModifierCell x)
		{
			return false;
		}
	}

	[SerializeField]
	private SkirmishQuestCell prefabQuestCell;

	[SerializeField]
	private GameModifierCell prefabModifierCell;

	[Space]
	[SerializeField]
	private GameObject blockGamble;

	[SerializeField]
	private GameObject blockQuests;

	[SerializeField]
	private GameObject blockModifiers;

	[Space]
	[SerializeField]
	private RectTransform parentQuests;

	[SerializeField]
	private RectTransform parentModifiers;

	[SerializeField]
	private RectTransform threatExplanation;

	[SerializeField]
	private Image iconWorld;

	[SerializeField]
	private Image iconThreat;

	[SerializeField]
	private Text labelEndsInSkirmish;

	[SerializeField]
	private Text title;

	[SerializeField]
	private Text labelThreatLevel;

	[SerializeField]
	private Image iconPlayMode;

	[SerializeField]
	private Image ribbonPlayMode;

	[SerializeField]
	private Animator threatAnimator;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private Button buttonClose;

	[SerializeField]
	private GameObject timerBlock;

	[SerializeField]
	private UITextTimer skirmishTimer;

	[SerializeField]
	private CircleClock timerCircle;

	[SerializeField]
	private GameObject blockXp;

	[SerializeField]
	private GameObject blockPassXp;

	[SerializeField]
	private Text labelXp;

	[SerializeField]
	private Text labelPassXp;

	[SerializeField]
	private GameObject blockXpClaimed;

	[SerializeField]
	private GameObject blockPassXpClaimed;

	private bool QQKNGRHOINJ;

	private Tween NENEQLQIKEI;

	private List<GameModifierCell> RIQRQIQQKHO;

	private bool PRTMENTMMIL;

	public static void Open(bool KQGHGPEKKTJ = true, bool QQFENHRLKSH = false)
	{
	}

	private void MLNESSGJRME()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void FTFLHLRNHNG(bool KQGHGPEKKTJ = false)
	{
	}

	private void LIQIJJOOKMI(bool LRMTQQJFSLS)
	{
	}

	private void NPMTRSPRLNL()
	{
	}

	private void JJPNTSINTFS()
	{
	}

	public void OnThreatAnimationChangeTime()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
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

	public void OnStartButton()
	{
	}

	private void JGQPSGPKNFP()
	{
	}

	public void OnCloseButton()
	{
	}

	public void OnRerollButton()
	{
	}

	public void AttachToRerollModifiersPopup()
	{
	}

	public void OnThreatButton()
	{
	}

	private void KRLNGSHGQOM()
	{
	}

	private void JMNTHRMSPFH()
	{
	}

	private void JHSENSSTRGP()
	{
	}

	[CompilerGenerated]
	private GameModifierCell INFQLJOKLIP(GameModifierTiered JKPJLSEQFMF)
	{
		return null;
	}

	[CompilerGenerated]
	private void LEIGELJPTNF(List<GameModifierTiered> GJNOFRJIRIP, bool JEPRTELNILG, float FGRMMQIRMTH)
	{
	}

	[CompilerGenerated]
	private void GTTMHOKISNJ()
	{
	}
}
