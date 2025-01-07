using UnityEngine;
using UnityEngine.UI;

public class ClanMissionBossItem : MonoBehaviour
{
	public enum RFRTRISGEHJ
	{
		Hidden = 0,
		Unlocking = 1,
		Unlocked = 2,
		Finished = 3
	}

	[SerializeField]
	private Image bossIcon;

	[SerializeField]
	private Image iconFrame;

	[SerializeField]
	private GameObject lockIcon;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private Image arrow;

	[SerializeField]
	private Transform lockTransform;

	[SerializeField]
	private GameObject hiddenBlock;

	[SerializeField]
	private Text hiddenTitleLabel;

	[SerializeField]
	private CanvasGroup hiddenCanvasGroup;

	[SerializeField]
	private GameObject unlockingBlock;

	[SerializeField]
	private Text unlockingTitleLabel;

	[SerializeField]
	private CanvasGroup unlockingTitleCanvasGroup;

	[SerializeField]
	private Text requirementsLabel;

	[SerializeField]
	private CanvasGroup requirementsCanvasGroup;

	[SerializeField]
	private GameObject unlockedBlock;

	[SerializeField]
	private Text nameLabel;

	[SerializeField]
	private Text clearedFloorLabel;

	[SerializeField]
	private Image bottomFrame;

	[SerializeField]
	private FirstClearDisplay firstClearDisplay;

	[SerializeField]
	private GameObject finishedBlock;

	[SerializeField]
	private Text finishedNameLabel;

	[SerializeField]
	private Text finishedClearedFloorLabel;

	[SerializeField]
	private Text gemsLabel;

	[SerializeField]
	private Text scoreLabel;

	[SerializeField]
	private Image finishedBottomFrame;

	[SerializeField]
	private GameObject lockFxPrefab;

	[SerializeField]
	private Sprite bossIconHidden;

	[SerializeField]
	private Sprite spriteBgLocked;

	[SerializeField]
	private Sprite spriteBg;

	[SerializeField]
	private Sprite spriteBgTorment;

	[SerializeField]
	private Sprite spriteArrowLocked;

	[SerializeField]
	private Sprite spriteArrow;

	[SerializeField]
	private Sprite spriteArrowTorment;

	[SerializeField]
	private Sprite spriteFrameLocked;

	[SerializeField]
	private Sprite spriteFrame;

	[SerializeField]
	private Sprite spriteFrameUnlocking;

	[SerializeField]
	private Sprite spriteBottomFrame;

	[SerializeField]
	private Sprite spriteBottomFrameTorment;

	[SerializeField]
	private Animation animHidden;

	[SerializeField]
	private Animation animUnlocking;

	[SerializeField]
	private Animation animUnlocked;

	[SerializeField]
	private Animation animFinished;

	public RFRTRISGEHJ state;

	private int PSPJIJNTMOI;

	public void SetupHidden(int QFOPFRIRJGQ)
	{
	}

	public void SetupUnlocking(int QFOPFRIRJGQ, ClanMissionConfig.LeagueMissionConfig.MinibossConfigTorment LIQGLGKPMPE, int OPQPJILLNIM = 0, int JQTSHIQLSEN = 0)
	{
	}

	public void SetupUnlocked(int QFOPFRIRJGQ, ClanMissionConfig.LeagueMissionConfig.MinibossConfigTorment LIQGLGKPMPE, int EERRGHKNKNK, string OIJOOFIEGRN)
	{
	}

	public void SetupFinished(int QFOPFRIRJGQ, ClanMissionConfig.LeagueMissionConfig.MinibossConfigTorment LIQGLGKPMPE, int EERRGHKNKNK, int SIKLEOFJHSE)
	{
	}

	public void SetRequirementsLabel(int NGLJJHHTQTH, int NHJLNIHMJRG)
	{
	}

	public void PlayAnimation(RFRTRISGEHJ NEEHHLHELHH)
	{
	}

	private void HSKMPFHMOLG(int EERRGHKNKNK, Text KKNIRQLIKET, Image IOTMPGKLTMT)
	{
	}

	public void OnClick()
	{
	}

	private void JPFPRGMIRSR()
	{
	}

	private void QHRKJOGQEOF()
	{
	}
}
