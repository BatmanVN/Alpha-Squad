using UnityEngine;
using UnityEngine.UI;

public class MilestoneTrackCell : MonoBehaviour
{
	public enum OHMQOLIQSGS
	{
		INVALID = -1,
		EMPTY = 0,
		AVAILABLE = 1,
		NOT_ENOUGH_LAPS = 2,
		LOCKED = 3,
		CLAIMED = 4
	}

	[SerializeField]
	protected CardCellVisual visualLoot;

	[SerializeField]
	private CardCellSelectVisual visualSelect;

	[Space]
	[SerializeField]
	protected Transform animationTarget;

	[SerializeField]
	protected GameObject onClaimEffect;

	[SerializeField]
	protected SoundEffect onClaimSound;

	[SerializeField]
	private RectTransform cover;

	[Space]
	[SerializeField]
	protected GameObject viewActive;

	[SerializeField]
	protected GameObject viewAvailable;

	[SerializeField]
	protected GameObject viewAvailableFront;

	[SerializeField]
	protected GameObject viewLocked;

	[SerializeField]
	protected GameObject viewClaimed;

	private GameObject LSIHGRMKHQQ;

	protected MilestoneTrackElement FNJLLHKNGOR;

	protected LootIdentifier RJOMEOONNPR;

	protected OHMQOLIQSGS MJPJLPIKQFE;

	private bool PIJJTRQQEOS;

	private Button GKKFNISSPRI;

	private void Awake()
	{
	}

	public virtual void Setup(LootIdentifier SINTNFEMQER, MilestoneTrackElement TNKMMOJJPPI)
	{
	}

	private void GSJOEFOHRQG(Image MGTQNORKMOQ, bool ESOGSMPJFNR, bool IOSPLOEGRSL)
	{
	}

	private void HFKLLSKHOGQ()
	{
	}

	protected void SJGEQPGLGQJ()
	{
	}

	protected void QRKJONIPLTM()
	{
	}

	private void FKLFKSOQGTP()
	{
	}

	private void KOEIJTFOSFE()
	{
	}

	protected void RISGNQRHLER()
	{
	}

	public virtual void SetState(OHMQOLIQSGS MJPJLPIKQFE)
	{
	}

	private void EJGLNQJQOQO()
	{
	}

	private void SMRRIQLEQEG()
	{
	}

	public void PunchAnimation()
	{
	}

	public void AnimateClaimable()
	{
	}

	protected virtual Image MIEREIMFIHM()
	{
		return null;
	}

	protected void QPPSTMSPTET()
	{
	}

	protected void MRSSNROOJFK()
	{
	}

	public OHMQOLIQSGS GetState()
	{
		return default(OHMQOLIQSGS);
	}
}
