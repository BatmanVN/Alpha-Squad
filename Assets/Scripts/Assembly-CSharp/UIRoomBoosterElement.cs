using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIRoomBoosterElement : MonoBehaviour
{
	[SerializeField]
	protected Text buttonCostText;

	[SerializeField]
	protected Text displayCostText;

	[SerializeField]
	protected Text requiredLevelText;

	[SerializeField]
	protected Text nameText;

	[SerializeField]
	protected Text levelText;

	[SerializeField]
	protected Text currentValueText;

	[SerializeField]
	protected Text upgradeValueText;

	[SerializeField]
	protected GameObject upgradeValueIcon;

	[SerializeField]
	protected Image icon;

	[SerializeField]
	protected Text otherUpgradingText;

	[SerializeField]
	protected GameObject boostButtonActive;

	[SerializeField]
	protected GameObject boostButtonInactive;

	[SerializeField]
	protected UITextTimer inactiveButtonTimer;

	[SerializeField]
	protected Text boostTime;

	[SerializeField]
	protected UIRoomUpgradeProgress upgradeProgress;

	[SerializeField]
	protected GameObject stateLocked;

	[SerializeField]
	protected GameObject stateCanUpgradeLeader;

	[SerializeField]
	protected GameObject stateCanUpgradeMember;

	[SerializeField]
	protected GameObject stateCanFinishLeader;

	[SerializeField]
	protected GameObject stateCanFinishMember;

	[SerializeField]
	protected GameObject stateMaxLevelReached;

	[SerializeField]
	protected GameObject stateUpgrading;

	[SerializeField]
	protected GameObject stateOtherUpgrading;

	[SerializeField]
	private GameObject animBoostActive;

	[SerializeField]
	private GameObject animBoostInactive;

	[SerializeField]
	private GameObject animClaim;

	[SerializeField]
	private GameObject buttonChangeEffect;

	[SerializeField]
	public GameObject boostProgressEffect;

	[SerializeField]
	private GameObject boostUpgradeEffect;

	[SerializeField]
	private Transform floatingTextPos;

	private RectTransform IERIISNIJFH;

	protected UIRoomLaboratory FNJLLHKNGOR;

	protected UIRoomLaboratory.BoostLevel HPJMQLRTORF;

	private bool JLMOIGSKEEQ;

	public void Setup(UIRoomLaboratory.BoostLevel LMSPIEGSMRF, UIRoomLaboratory FNJLLHKNGOR)
	{
	}

	public void SetupStaticInfo()
	{
	}

	protected void EJSQNPFPTLF()
	{
	}

	private bool ENFPLGQEJGH()
	{
		return false;
	}

	public void Refresh()
	{
	}

	public void AnimateNextState()
	{
	}

	public void AnimateUpgradeFinished()
	{
	}

	public void AnimateAssist()
	{
	}

	public UIRoomLaboratory.RGLHHOFPFMK GetBoost()
	{
		return default(UIRoomLaboratory.RGLHHOFPFMK);
	}

	public void OnClickUpgrade()
	{
	}

	public void OnClickAssist()
	{
	}

	public void OnClickFinish()
	{
	}

	public virtual bool HaveEnoughCurrency()
	{
		return false;
	}

	public int GetCost()
	{
		return 0;
	}

	private void SPJNMQFIHGO()
	{
	}

	public Transform GetFloatingTextPos()
	{
		return null;
	}

	public RectTransform GetRect()
	{
		return null;
	}

	[CompilerGenerated]
	private void GLLSGRPQTSN()
	{
	}
}
