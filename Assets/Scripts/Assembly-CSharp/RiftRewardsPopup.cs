using System;
using UnityEngine;
using UnityEngine.UI;

public class RiftRewardsPopup : UIPopup
{
	[Serializable]
	public struct LeagueEffectsData
	{
		public PLEHFILISJN.QQNJQRQQTGM league;

		public GameObject particles;

		public SoundEffect appearSfx;
	}

	[SerializeField]
	private Text labelTitleMajor;

	[SerializeField]
	private Text labelPlacement;

	[SerializeField]
	private Text labelRewardsTitle;

	[SerializeField]
	private LootElementUIListWithChests rewardsList;

	[SerializeField]
	private RiftsPanelLeague leaguePanel;

	[SerializeField]
	private GameObject placementBlock;

	[Space]
	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private GameObject rewardsRanks;

	[SerializeField]
	private Image rewardsBG;

	[SerializeField]
	private Image rewardsTitleBG;

	[SerializeField]
	private GameObject rewardsLeagues;

	[SerializeField]
	private LootElementUIListWithChests rewardsListLeagues;

	[SerializeField]
	private RuntimeAnimatorController leagueRankAnimController;

	[SerializeField]
	private Animator leagueRankAnimator;

	[SerializeField]
	private Transform leagueRanksParent;

	[SerializeField]
	private Transform leagueRankEffectsParent;

	[SerializeField]
	private LeagueEffectsData[] leagueEffects;

	private GameObject FJPLEMMTOGN;

	private GameObject ELPQOSSEMKI;

	public static void Open(PLEHFILISJN.NPNPFMQTFNI NPNQSJJPTET, RiftRewardConfig.Reward HJTFJIISHNG, int MMMLOKLFTQE, int PSLSMIJRNSG)
	{
	}

	public static void Open(PLEHFILISJN.QQNJQRQQTGM PSLQPFEKSHG, int MKEEOHFLSEM, RiftRewardConfig.Reward FILOKRMHOJJ, int PSLSMIJRNSG)
	{
	}

	private void TOOFLRRTTTN(PLEHFILISJN.NPNPFMQTFNI NPNQSJJPTET, RiftRewardConfig.Reward HJTFJIISHNG, int MMMLOKLFTQE, int PSLSMIJRNSG)
	{
	}

	private void LQFLTPQFTSJ(PLEHFILISJN.QQNJQRQQTGM PSLQPFEKSHG, int MKEEOHFLSEM, RiftRewardConfig.Reward FILOKRMHOJJ, int PSLSMIJRNSG)
	{
	}

	private void PLTOJPEQGPI(RiftRewardConfig.Reward HJTFJIISHNG, LootElementUIListWithChests GRJRQRKLHIH)
	{
	}

	public void OnCloseButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private LeagueEffectsData PFSNTNJHQOQ(PLEHFILISJN.QQNJQRQQTGM PSLQPFEKSHG)
	{
		return default(LeagueEffectsData);
	}
}
