using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class PrestigeInfoPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class HFTPOFHFNGS
	{
		public PrestigeInfoPopup _003C_003E4__this;

		public float from;

		public float to;

		internal void _003CMovePlayer_003Eb__0(float f)
		{
		}
	}

	[CompilerGenerated]
	private sealed class QMOGNGQKQHS
	{
		public PrestigeInfoPopup _003C_003E4__this;

		public float anchoredPos;

		public float time;

		public Action onEndCallback;

		internal void _003CScrollToRect_003Eb__0()
		{
		}

		internal void _003CScrollToRect_003Eb__1()
		{
		}
	}

	[SerializeField]
	private GameObject topItemSeparator;

	[SerializeField]
	private GameObject prestigeGradientElement;

	[SerializeField]
	private UIPrestigeElement prestigeElement;

	[SerializeField]
	private UIPrestigeRank rankPrefab;

	[SerializeField]
	private GameObject comingSoon;

	[SerializeField]
	private BuildMenuSubtabs subtabs;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private RectTransform top;

	[SerializeField]
	private RectTransform bottom;

	[SerializeField]
	private Transform objectList;

	[SerializeField]
	private Transform bonustList;

	[SerializeField]
	private ScrollRectEx bonusScroll;

	[SerializeField]
	private ScrollRectEx itemScroll;

	[SerializeField]
	private Text totalPrestigeText;

	[SerializeField]
	private RectTransform darken;

	[SerializeField]
	private RectTransform playerIcon;

	[SerializeField]
	private GameObject touchBlocker;

	[SerializeField]
	private GameObject itemsLayer;

	[SerializeField]
	private GameObject bonusesLayer;

	[SerializeField]
	private float animationTime;

	private bool OTEQFFLMIRR;

	private bool ISFROEPORME;

	private int KPJLIKRFGJG;

	private int PHNGEEIJIEF;

	private UIPrestigeRank KSFGLMILMFL;

	private List<UIPrestigeRank> PLOKFFPRQIP;

	private List<UIPrestigeElement> EJTLJMJEINM;

	private Dictionary<int, int> HNOKQFNSTPP;

	[SerializeField]
	private int debugViewedPrestige;

	[SerializeField]
	private int debugFinalPrestige;

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void OnShowFinished()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void MGRLTPGGSSI()
	{
	}

	private void NGHFQRREIJN()
	{
	}

	private bool TOEGGPJPOMM()
	{
		return false;
	}

	private void EGTLONQRMRO()
	{
	}

	private IEnumerator GIMGNJHTPJP()
	{
		return null;
	}

	private void TNQTPNPSQHJ()
	{
	}

	private void QEPJPQOMJLL()
	{
	}

	private int ILHNJRKEQIG()
	{
		return 0;
	}

	private int OKPSLNRTPPF(int PSPJIJNTMOI)
	{
		return 0;
	}

	private int SHFKTGILFEO(int PSPJIJNTMOI)
	{
		return 0;
	}

	private void IIOPIHENJHN()
	{
	}

	private IEnumerator HOHTFTOKTKI()
	{
		return null;
	}

	private IEnumerator OLQOOOMPQOF()
	{
		return null;
	}

	private void KSIJFNIJIEL()
	{
	}

	private float FKORKELOILE(int HQHRSELQJMR)
	{
		return 0f;
	}

	private UIPrestigeRank OFPEQTNIKFN(int IRGJMLSOQIM)
	{
		return null;
	}

	private float QPPFIHMLQSN(int IRGJMLSOQIM, bool HQLLGLEOSEE = false)
	{
		return 0f;
	}

	public void TestOffsetPrestige(int HQHRSELQJMR)
	{
	}

	public void TestRestart()
	{
	}

	private Tween EQKNGFGTTQP(int HQHRSELQJMR, float JPKGQSMKSTF = 0f, Ease GNGNKIOHLMF = Ease.InOutSine)
	{
		return null;
	}

	private void PNJNFEFIPTT()
	{
	}

	public void OnExit()
	{
	}

	public void OnItemsTab()
	{
	}

	public void OnBonusesTab()
	{
	}

	private void NTPJRIPEIGF(int HQHRSELQJMR, float JPKGQSMKSTF = 0f, Action NRRHLFONPPM = null, Ease GNGNKIOHLMF = Ease.InOutSine)
	{
	}

	private void NTPJRIPEIGF(RectTransform LJIOGPNTJPN, float JPKGQSMKSTF = 0f, Action NRRHLFONPPM = null, Ease GNGNKIOHLMF = Ease.InOutSine)
	{
	}

	private void NTPJRIPEIGF(float FOMFIIFEKTS, float JPKGQSMKSTF = 0f, Action NRRHLFONPPM = null, Ease GNGNKIOHLMF = Ease.InOutSine)
	{
	}

	public void ToggleBlockForTutorial(bool RRPSNPOTQNT)
	{
	}

	public Button GetFirstRewardButton()
	{
		return null;
	}

	private void Update()
	{
	}
}
