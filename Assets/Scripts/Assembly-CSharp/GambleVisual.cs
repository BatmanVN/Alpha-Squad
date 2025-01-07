using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class GambleVisual : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class SNSIHGMLREG
	{
		public GambleVisual _003C_003E4__this;

		public bool playIdle;

		internal void _003CPlayOpenAnim_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class HOKRQFNNOGI
	{
		public GambleVisual _003C_003E4__this;

		public Vector2 pTop;

		public Vector2 pBot;

		internal void _003CPlayArrowJump_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class IQNSEELPFFP
	{
		public GambleRewardCell cell;

		public int idx;

		public GambleVisual _003C_003E4__this;

		internal void _003CPlayIdleAnimation_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class JTLPEJPFKPN
	{
		public RKTKKOOERQQ.GambleReward rw;

		public GambleVisual _003C_003E4__this;

		internal bool _003CPlayGambleAnimAndGetReward_003Eb__1(GambleRewardCell x)
		{
			return false;
		}

		internal bool _003CPlayGambleAnimAndGetReward_003Eb__2(GambleRewardCell x)
		{
			return false;
		}

		internal void _003CPlayGambleAnimAndGetReward_003Eb__5()
		{
		}

		internal void _003CPlayGambleAnimAndGetReward_003Eb__6()
		{
		}
	}

	[CompilerGenerated]
	private sealed class KRFRSMJMFKJ
	{
		public GambleRewardCell cell;

		public JTLPEJPFKPN CS_0024_003C_003E8__locals1;

		internal void _003CPlayGambleAnimAndGetReward_003Eb__7()
		{
		}
	}

	[CompilerGenerated]
	private sealed class OHTEEGJONFN
	{
		public RKTKKOOERQQ.GambleReward rw;

		internal bool _003CGetRandomReward_003Eb__1(GambleRewardCell x)
		{
			return false;
		}
	}

	[SerializeField]
	private GambleRewardCell prefabCell;

	[SerializeField]
	private GameObject prefabStarParticles;

	[SerializeField]
	private GameObject visual;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private RectTransform rewardParent;

	[SerializeField]
	private RectTransform rewardContent;

	[SerializeField]
	private RectTransform selectionArrow;

	[SerializeField]
	private GambleRandom gambleRarity;

	[SerializeField]
	private RectTransform arrowTop;

	[SerializeField]
	private RectTransform arrowBot;

	[SerializeField]
	private RectTransform particlesParent;

	private int ONTTTPGTRME;

	private GambleRewardCell OIGEMJSPIRF;

	private Action RLLTNLPRJPS;

	private Sequence QRJGMGFMRNO;

	private int RHNRTRIGIRH;

	private float ILNJKGRSINJ;

	private Tween KMJTJFPQINF;

	private Tween POFMSJIPSRI;

	private List<GambleRewardCell> IIFNPERNKPQ;

	private List<RKTKKOOERQQ.GambleReward> QLSIPKPMJTJ;

	private int PEPRFTIRFJN;

	public bool clickableCells;

	private Tween TRRHEMOTHRS;

	private void OnEnable()
	{
	}

	public void Setup(RKTKKOOERQQ.GambleReward[] OPHQESJTOLF, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
	}

	public void HideAnimator()
	{
	}

	public void PlayOpenAnim(float PRRKGRQILFR, bool SNIGSEEOPTN = true)
	{
	}

	private void PMQLOOMFJLR()
	{
	}

	private void PMEJISGTOTQ(float PRRKGRQILFR = 0f)
	{
	}

	private GambleRewardCell EOIIJQSPFHO(RKTKKOOERQQ.GambleReward PNLNMHFJMSG)
	{
		return null;
	}

	public void PlayGambleAnimAndGetReward(Action PINJHONRINP)
	{
	}

	public void DisableCellClicks()
	{
	}

	public void EnableCellClicks()
	{
	}

	private void Update()
	{
	}

	private void FQLGSIKGFHM(GambleRewardCell QFJFSEMOOEH)
	{
	}

	public void GetRandomReward()
	{
	}

	private void LPHGQGIHPIS()
	{
	}

	private void SJGEQPGLGQJ(RKTKKOOERQQ.GambleReward QFJFSEMOOEH)
	{
	}

	private void MEITHROGGPP()
	{
	}

	[CompilerGenerated]
	private void MFERJLKKKHN()
	{
	}
}
