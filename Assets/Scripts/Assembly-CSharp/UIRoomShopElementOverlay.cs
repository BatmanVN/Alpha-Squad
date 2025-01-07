using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Animations;

public class UIRoomShopElementOverlay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IERGFFLFTFL
	{
		public UIRoomShopElementOverlay _003C_003E4__this;

		public ClanServerCalls.RpcResponse response;
	}

	public Action OnCraftAnimEnded;

	[SerializeField]
	private UIRoomShopElement fakeElement;

	[SerializeField]
	private ParticleSystem particlesPrefab;

	[SerializeField]
	private GameObject craftingLayer;

	[SerializeField]
	private Transform amountText;

	[SerializeField]
	private Transform iconVisual;

	[SerializeField]
	private Transform floatingTextPos;

	[SerializeField]
	private SlicedFilledImage craftingFill;

	[SerializeField]
	private PositionConstraint constraint;

	[SerializeField]
	private GameObject craftSkipOverlayButton;

	private UIRoom FNJLLHKNGOR;

	private Sequence PFTHEPMSSLK;

	private int MNGEQPOQIOR;

	[SerializeField]
	private Ease fillEase;

	[SerializeField]
	private float fillAmountBegin;

	[SerializeField]
	private float fillDurationBegin;

	[SerializeField]
	private float fillDurationEnd;

	[SerializeField]
	private float iconScaleMultiplier;

	[SerializeField]
	private float iconScaleDuration;

	[SerializeField]
	private Ease iconScaleEase;

	[SerializeField]
	private float disappearDelay;

	[SerializeField]
	private AnimationCurve amountTextScaleCurve;

	[SerializeField]
	private float amountTextScaleDuration;

	[SerializeField]
	private float floatingTextAppearDelay;

	[SerializeField]
	private float amountTextFadeDelay;

	[SerializeField]
	private Ease fadeEase;

	public void StartCraftAnimation(UIShopElement KQRPMHFKSIR)
	{
	}

	public void FinishCraftAnimation(ClanServerCalls.RpcResponse MHGSOKIEHQE, Action KQGHTRIGRTT)
	{
	}

	private void PGFTSKFSKTK(ClanServerCalls.RpcResponse MHGSOKIEHQE)
	{
	}

	public void SetOwner(UIRoom FNJLLHKNGOR)
	{
	}

	public void EndCraftAnimation()
	{
	}
}
