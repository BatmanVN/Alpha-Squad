using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DonationPanelBlock : MonoBehaviour
{
	[SerializeField]
	private EOQPNKSSOTM.GJMQMORNOSQ donateType;

	[SerializeField]
	private GameObject donateButton;

	[SerializeField]
	private GameObject donateButtonInactive;

	[SerializeField]
	private Transform clanGetsBlock;

	[SerializeField]
	private Transform youGetBlock;

	[SerializeField]
	private ParticleSystem buttonParticles;

	[SerializeField]
	private RectTransform clanCoinsRect;

	[SerializeField]
	private RectTransform clanTokensRect;

	[SerializeField]
	private AnimationCurve moveUpCurve;

	[SerializeField]
	private AnimationCurve returnFromUpCurve;

	[SerializeField]
	private ParticleSystem clanGetsParticles;

	[SerializeField]
	private AnimationCurve moveDownCurve;

	[SerializeField]
	private AnimationCurve returnFromDownCurve;

	[SerializeField]
	private ParticleSystem youGetParticles;

	[SerializeField]
	private Text buttonAmountActiveText;

	[SerializeField]
	private Text buttonAmountInactiveText;

	[SerializeField]
	private Text youGetCoinsText;

	[SerializeField]
	private Text clanGetsCoinsText;

	[SerializeField]
	private Text clanGetsXpText;

	[SerializeField]
	private Text donateAvailableText;

	[SerializeField]
	private Text bonusPercent;

	[SerializeField]
	private UITextTimer nextAvailableTimer;

	[SerializeField]
	private GameObject bonusBanner;

	private Vector3 SEQFOMLTFIS;

	private Vector3 SOJIIHMSHGR;

	private Sequence HRLFOHLJFMN;

	private Sequence MNRMIMJKQNQ;

	private static int[] LJKSQILHFSR;

	private void Start()
	{
	}

	public Transform GetButtonPosition()
	{
		return null;
	}

	public static bool HasEnoughCurrency(bool TPTKFISFNGT, EOQPNKSSOTM.DonationConfig SOSLGOOOIPG)
	{
		return false;
	}

	public void UpdateAmountColor(bool JHSHFQOGPFO)
	{
	}

	public void UpdateButtons()
	{
	}

	public void ShowCooldownFloating()
	{
	}

	public void UpdateTexts(int MJPKLHHTJTJ, int RLMMKKFHREK, int FOQIJNNSRNI = 0)
	{
	}

	public static bool HaveTicketForTier(int FOQIJNNSRNI)
	{
		return false;
	}

	public void PlayAnimation()
	{
	}

	public RectTransform GetClanTokensRect()
	{
		return null;
	}

	public RectTransform GetClanCoinsRect()
	{
		return null;
	}
}
