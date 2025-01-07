using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class MilestoneTrack : MonoBehaviour
{
	public class OIGQMMOIFTI
	{
		public Func<int> NNPPIIFJHQL;

		public Func<bool> PFTMSKKSIQP;

		public Func<bool, string> MNQEJORHKNM;

		public Func<int, bool> MOKTORIIORH;

		public Func<int, bool, bool> SOTOOLEIRGQ;

		public Action<int, bool> SJGEQPGLGQJ;

		public Action HTTFEFSEQKP;

		private OIGQMMOIFTI()
		{
		}

		public OIGQMMOIFTI(Func<int> ISEFKGOLOSK, Func<bool> IQESIRQGFJK, Func<bool, string> HKPPPLEFKSP, Func<int, bool> SFIOFKMQFOP, Func<int, bool, bool> PLJFPRMPLSG, Action<int, bool> KTIFMRORIFS, Action JLRMKHKNNQM)
		{
		}
	}

	[CompilerGenerated]
	private sealed class POLQTHMIQRE
	{
		public GameObject block;

		internal void _003COnPurchaseCompleted_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class FQLHIITOIJJ
	{
		public MilestoneTrack _003C_003E4__this;

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
	private MilestoneTrackElement trackElementPrefab;

	[SerializeField]
	private MilestoneTrackElement trackTrophyPrefab;

	[SerializeField]
	private RectTransform rewardsHolder;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private CanvasGroup scrollCanvas;

	[SerializeField]
	private ScrollRectEx scroll;

	[SerializeField]
	private TrackLine lines;

	[SerializeField]
	private Transform lapsTransform;

	[SerializeField]
	private Text lapsText;

	[SerializeField]
	private GameObject banner;

	[SerializeField]
	private GameObject buyBanner;

	[SerializeField]
	private GameObject boughtBanner;

	[SerializeField]
	private GameObject bannerBlik;

	[SerializeField]
	private GameObject reachPrefab;

	[SerializeField]
	private SoundEffect reachMilestoneSound;

	[SerializeField]
	private SoundEffect reachTrophySound;

	[SerializeField]
	private Animator bannerAnimator;

	[SerializeField]
	private Text labelBuyPass;

	[NonSerialized]
	public string keyBuyPassNotPurchased;

	[NonSerialized]
	public string keyBuyPassPurchased;

	private List<MilestoneTrackElement> PFRLSKJGNEG;

	[SerializeField]
	private float spacing;

	[SerializeField]
	private Padding padding;

	private int LRTLFNLHHIK;

	public OIGQMMOIFTI resources;

	private event Action LHTGFMLSSNS
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

	public void SetupTrack(in List<MilestoneEventConfig.EventMilestone> ETMGFQTPSQR, OIGQMMOIFTI JSQMJKGLSTE)
	{
	}

	public void InitScroll(float JPKGQSMKSTF)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public Transform GetBannerTransform()
	{
		return null;
	}

	public void SetOnPurchaseButton(Action NQMLJGLSPTP)
	{
	}

	public void OpenPurchase()
	{
	}

	public void CheckPrevious()
	{
	}

	public void OnPurchaseCompleted(bool JEPRTELNILG)
	{
	}

	public void AnimateLapsValue()
	{
	}

	public void ReachedNew(int QNLPQKPQLEF)
	{
	}

	private void JEPHRJSFKML(bool QMLEHJIFQTF = false)
	{
	}

	private void RHENTSPKTQR(List<MilestoneEventConfig.EventMilestone> ETMGFQTPSQR)
	{
	}

	public void UpdateLapCounter()
	{
	}

	private void PPEIPPSMQHE(List<MilestoneEventConfig.EventMilestone> ETMGFQTPSQR)
	{
	}

	private void IMQJKFFJKFN(MilestoneTrackElement GRMOIOOPGSL, MilestoneEventConfig.EventMilestone SOSLGOOOIPG, int RQTKGSEETSH)
	{
	}

	private float JPTPSRGEMOM()
	{
		return 0f;
	}

	private float FMMHQJREINE(RectTransform FLPFJGNNFJN, int KQQINSRPRNP)
	{
		return 0f;
	}

	public void UpdateMilestones(bool JEPRTELNILG = true)
	{
	}

	private void RQJTHELHPFJ(int GSEIILTRIMG, bool JEPRTELNILG)
	{
	}

	private void MKEMNFKSGTR()
	{
	}

	private void IMMRNLNMTPJ()
	{
	}

	private void HMERKSGLSKP()
	{
	}

	private void ERNMRIIRERE()
	{
	}

	private float RHOHSFSNJTL(int GSEIILTRIMG)
	{
		return 0f;
	}

	private void NTPJRIPEIGF(float FOMFIIFEKTS, float JPKGQSMKSTF = 0f, Action NRRHLFONPPM = null, Ease GNGNKIOHLMF = Ease.InOutSine, bool ESQOGELGSRI = false)
	{
	}

	public void ClaimCell(int PSPJIJNTMOI, bool FKPPEQLPJHJ)
	{
	}

	public void TryOpenBuyPopup()
	{
	}

	public void ScrollToFirstClaimableReward()
	{
	}
}
