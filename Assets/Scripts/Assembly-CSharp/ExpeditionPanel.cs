using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Expedition;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class ExpeditionPanel : UIPanel
{
	[Serializable]
	private struct Data
	{
		public int lastLevel;

		public bool introAnimationPlayed;

		public int previousExpeditionIndex;
	}

	[CompilerGenerated]
	private sealed class QTRFEQSNMFP
	{
		public ExpeditionLevelCell cell;

		internal void _003CInitPositionsAndAnimate_003Eb__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class PTESLFKFSHN
	{
		public Vector3 towerP;

		public ExpeditionPanel _003C_003E4__this;

		internal void _003COpenMoveAnimation_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class LSQRLINORRH
	{
		public ExpeditionPanel _003C_003E4__this;

		public int clvl;

		public ExpeditionData exData;

		public TweenCallback _003C_003E9__1;

		public TweenCallback _003C_003E9__2;

		internal void _003CClaimMoveAnimation_003Eb__1()
		{
		}

		internal void _003CClaimMoveAnimation_003Eb__2()
		{
		}

		internal void _003CClaimMoveAnimation_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class MOFPLPFMREO
	{
		public GameObject goCopy;

		public ExpeditionPanel _003C_003E4__this;

		internal void _003CFlyTowardsPlayer_003Eb__1()
		{
		}
	}

	[SerializeField]
	private ExpeditionLevelCell prefabCell;

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[SerializeField]
	private GameObject prefabEffectHit;

	[SerializeField]
	private GameObject popupCompleted;

	[SerializeField]
	private CanvasGroup popupCompleteBg;

	[SerializeField]
	private RectTransform popupCompletedRect;

	[SerializeField]
	private UITextTimer labelPopupCompletedEventEnd;

	[SerializeField]
	private ScrollRectEx scroll;

	[SerializeField]
	private GameObject inputBlocker;

	[SerializeField]
	private GameObject keycardBlock;

	[SerializeField]
	private FollowTransform startButtonFollower;

	[SerializeField]
	private Text labelWorld;

	[SerializeField]
	private RectTransform layoutTries;

	[SerializeField]
	private Transform rewardFlyToLocation;

	[SerializeField]
	private Text labelFullAttempts;

	[SerializeField]
	private UITextTimer labelNextAttempt;

	[SerializeField]
	private UITextTimer labelEventEnd;

	[SerializeField]
	private RectTransform cellsParent;

	[SerializeField]
	private UIPlayerPreview agentPreview;

	[SerializeField]
	private RectTransform towerViewport;

	[SerializeField]
	private CanvasGroup bg;

	[SerializeField]
	private CanvasGroup top;

	[SerializeField]
	private CanvasGroup bottom;

	[SerializeField]
	private GameObject buttonPlay;

	[SerializeField]
	private GameObject buttonNoKeycards;

	[Space]
	[SerializeField]
	private Image playButtonBg;

	[SerializeField]
	private Color playButtonBgRegular;

	[SerializeField]
	private Color playButtonBgBoss;

	[SerializeField]
	private UITextTimer nextExpeditionTimer;

	[SerializeField]
	private CircleClock timerCircle;

	[Space]
	[SerializeField]
	private GameObject autoCompleteButton;

	[SerializeField]
	private Text labelRaidTicketPrice;

	[SerializeField]
	private GameObject loadingBlock;

	[SerializeField]
	private Image loadingBlockProgress;

	[SerializeField]
	private AnimatedLabelText completingLabel;

	private List<ExpeditionLevelCell> PHTKEJTOQRG;

	private List<GameObject> JPQMQHMTHMP;

	private Sequence HJHGIGMPQIO;

	private Tween GOJSSIETRIL;

	private Sequence ISSLIHISQIT;

	private Data TSRPFHOJKSG;

	public static string KEY;

	private void KLJEPKORMLM()
	{
	}

	private void PMITOIOJNOT()
	{
	}

	protected override void MGKPMPHSLFR()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void MLNESSGJRME()
	{
	}

	private void JJPNTSINTFS()
	{
	}

	private void FNKSJQGMMGJ()
	{
	}

	private void NTEGJPSNQKN()
	{
	}

	private void ELRINSNRSHR()
	{
	}

	private void IHOEINTPHSS()
	{
	}

	private Sequence MOOSFJISMIR(int JPKTONLRSRI, bool EKJSGPNEOIL = true)
	{
		return null;
	}

	private Sequence JLNIOLPRSPT(int GSJNPHNGPLM, bool KQGHGPEKKTJ = true)
	{
		return null;
	}

	public void TryPauseClaimSequence()
	{
	}

	public void TryPlayClaimSequence()
	{
	}

	private bool KKKSSRPHSER()
	{
		return false;
	}

	public Tween FlyTowardsPlayer(GameObject FMGEHJFFJIS)
	{
		return null;
	}

	private void GTFSLTPRHOS()
	{
	}

	private void METLQGQIKSL()
	{
	}

	private void SEHLLOHTHEM()
	{
	}

	public void OnExitButton()
	{
	}

	public void OnStartButton()
	{
	}

	public void OnAutoCompleteButton()
	{
	}

	public void OnNoKeycardsButton()
	{
	}

	private void QNHNPMMLNGJ()
	{
	}

	public void OnCompletePopupOkButton()
	{
	}

	private void RFQNFOEILMG()
	{
	}

	public void OnTestButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private FloatingErrorText KMQIMTNTOMN(string HETQTIKJGNI, Transform HSSNSPQEIGR = null)
	{
		return null;
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	public void OnKeycardRecharged()
	{
	}

	public void OnNewExpedition()
	{
	}

	[CompilerGenerated]
	private void LFMSHTJKPON()
	{
	}

	[CompilerGenerated]
	private void FLHHFKFSFIH()
	{
	}

	[CompilerGenerated]
	private void GRNNQJKKQPP()
	{
	}

	[CompilerGenerated]
	private void MHEEOMPQGFS()
	{
	}

	[CompilerGenerated]
	private void HMJTGREKPRJ()
	{
	}

	[CompilerGenerated]
	private void JFELNQOILKH()
	{
	}
}
