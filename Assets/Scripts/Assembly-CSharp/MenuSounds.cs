using UnityEngine;
using UnityEngine.Audio;

public class MenuSounds : ScriptableObject
{
	public SoundEffect testSound;

	public AudioMixer master;

	public SoundEffect tileClick;

	public SoundEffect buttonScaleOnPointerClick;

	public SoundEffect inventoryClick;

	public SoundEffect defaultPopup;

	public SoundEffect defaultPopupWhoosh;

	public SoundEffect defaultPopupQuick;

	public SoundEffect backButton;

	public SoundEffect openInfo;

	public SoundEffect swapWeaponInInfo;

	public SoundEffect lockToggle;

	public SoundEffect checkmark;

	public SoundEffect tabClick;

	public SoundEffect clickFast;

	public SoundEffect invAddonClick;

	public SoundEffect startAddonClick;

	public SoundEffect shopAddonClick;

	public SoundEffect opsAddonCLick;

	public SoundEffect lockedTile;

	public SoundEffect boostCardBleep;

	public SoundEffect boostCardInit;

	public SoundEffect agentShardSelect;

	public SoundEffect boostChestRewardSeq;

	public SoundEffect craftInit;

	public SoundEffect craftResultAppear;

	public SoundEffect craftMultiResultAppear;

	public SoundEffect craftResultBlockApper;

	public SoundEffect craftViewSelectPopup;

	public SoundEffect craftValueUpdate;

	public SoundEffect craftPanelOpen;

	public SoundEffect craftButtonClicked;

	public SoundEffect craftPanelClose;

	public SoundEffect cellAddToCraft;

	public SoundEffect cellRemoveFromCraft;

	public SoundEffect craftXpFill;

	public SoundEffect craftXpLevelUp;

	public SoundEffect craftCellAppear;

	public SoundEffect gearFilterUpdate;

	public SoundEffect gearBoostGlowShow;

	public SoundEffect gearBoostGlowHide;

	public SoundEffect gearEquip;

	public SoundEffect gearEquipAddonHead;

	public SoundEffect gearEquipAddonHeadFilter;

	public SoundEffect gearEquipAddonWrist;

	public SoundEffect gearEquipAddonWristFilter;

	public SoundEffect gearEquipAddonGadget;

	public SoundEffect gearEquipAddonGadgetFilter;

	public SoundEffect gearEquipAddonBody;

	public SoundEffect gearEquipAddonBodyFilter;

	public SoundEffect gearUnequipSound;

	public SoundEffect countCombatPower;

	public SoundEffect xpSpawn;

	public SoundEffect xpCount;

	public SoundEffect flyingGemsReach;

	public SoundEffect flyingCashReach;

	public SoundEffect flyingElementSpawn;

	public SoundEffect flyingRaidTicketsSpawn;

	public SoundEffect flyingRaidTicketsReach;

	public SoundEffect agentShardsSelectionOpen;

	public SoundEffect worldUnlocked;

	public SoundEffect episodeUnlocked;

	public SoundEffect episodeLockBreak;

	public SoundEffect getGemsPopup;

	public SoundEffect getCashPopup;

	public SoundEffect agentGunReceivedInfoBlock;

	public SoundEffect agentUnlockedSfx;

	public SoundEffect levelUpPupup;

	public SoundEffect ratePupup;

	public SoundEffect whatsNewPupup;

	public SoundEffect operationRewardLayoutAppear;

	public SoundEffect loadoutSwitch;

	public SoundEffect buy;

	public SoundEffect buy2;

	public SoundEffect shopBoughtParticles;

	public SoundEffect vipPopupSeq;

	public SoundEffect shopRerollWeaponChest;

	public SoundEffect shopOfferAttentionScale;

	public SoundEffect openAgentScreen;

	public SoundEffect selectAgent;

	public SoundEffect agentSelectApply;

	public SoundEffect agentUpgrade;

	public SoundEffect agentUpgradeCoverOpen;

	public SoundEffect agentUpgradeCoverClose;

	public SoundEffect enhancePopup;

	public SoundEffect imprint;

	public SoundEffect enhanceLevelUp;

	public SoundEffect enhanceUltimateActivate;

	public SoundEffect enhancementUpgrade;

	public SoundEffect visibleLoadoutChangeSuccess;

	public SoundEffect visibleLoadoutChangeTick;

	public SoundEffect outfitsOpen;

	public SoundEffect outfitsClose;

	public SoundEffect outfitsSelect;

	public SoundEffect outfitsClick;

	public SoundEffect equipSound;

	public SoundEffect unequipSound;

	public SoundEffect equipModeIn;

	public SoundEffect upgradeWeapon;

	public SoundEffect rankUpWeapon;

	public SoundEffect compare;

	public SoundEffect limitBreakOpen;

	public SoundEffect limitBreakFlyMat;

	public SoundEffect limitBreakCountMat;

	public SoundEffect limitLastHit;

	public SoundEffect limitBreakUnderLayer;

	public SoundEffect limitNoMaterials;

	public SoundEffect scrapSelectItem;

	public SoundEffect scrap;

	public SoundEffect starSelect;

	public SoundEffect scrapOpen;

	public SoundEffect chestOpen;

	public SoundEffect chestReady;

	public SoundEffect chestCardAppear;

	public SoundEffect chestSpecialCardAppear;

	public SoundEffect chestShake;

	public SoundEffect chestStartTimer;

	public SoundEffect chestLand;

	public SoundEffect chestSpawnSmall;

	public SoundEffect chestCountCards;

	public SoundEffect chestCardHide;

	public SoundEffect chestPopupWhoosh;

	public SoundEffect spawnCarousel;

	public SoundEffect chestOpenCarousel;

	public SoundEffect claimCarousel;

	public SoundEffect increaseInventorySize;

	public SoundEffect decreaseInventorySize;

	public SoundEffect buyInventorySize;

	public SoundEffect inventoryExpandPopup;

	public SoundEffect inventoryGetMorePopup;

	public SoundEffect elitePassClaimedParticleSfx;

	public SoundEffect elitePassMilestoneClaimedSfx;

	public SoundEffect elitePassOpen;

	public SoundEffect elitePassClose;

	public SoundEffect elitePassSkip;

	public SoundEffect elitePassPopup;

	public SoundEffect elitePassTabSwitch;

	public SoundEffect elitePassPurchased;

	public SoundEffect elitePassScrollToMilestone;

	public SoundEffect elitePassScroll;

	public SoundEffect openExpeditions;

	public SoundEffect startExpedition;

	public SoundEffect expeditionsRewardFlyStart;

	public SoundEffect expeditionsRewardOnReach;

	public SoundEffect expeditionsCellUnlock;

	public SoundEffect expeditionsElevate;

	public SoundEffect expeditionsAutoComplete;

	public SoundEffect huntCheckmark;

	public SoundEffect huntOpen;

	public SoundEffect huntStart;

	public SoundEffect trippleOfferBuy;

	public SoundEffect trippleOfferCellAppear;

	public SoundEffect modifierSmokePositive;

	public SoundEffect modifierSmokeNegative;

	public SoundEffect openHalloweenPanel;

	public SoundEffect threatLevelUp;

	public SoundEffect questComplete;

	public SoundEffect questBarAppear;

	public SoundEffect gambleLayoutAppear;

	public SoundEffect transitionMusic;

	public SoundEffect easterOpen;

	public SoundEffect easterClose;

	public SoundEffect riftPreselect;

	public SoundEffect riftCompare;

	public SoundEffect riftLockBreak;

	public SoundEffect riftButtonPop;

	public SoundEffect riftButtonWhoosh;

	public SoundEffect riftPanelOpen;

	public SoundEffect riftFloorButtonToClaimable;

	public SoundEffect reroll;

	public SoundEffect rerollResult;

	public SoundEffect rerollSelect;

	public SoundEffect agentWeeklyShardsBuy;

	public SoundEffect agentWeeklyShardFly;

	public SoundEffect hellModsOpen;

	public SoundEffect hellModsClose;

	public SoundEffect weeklyContractsOpen;

	public SoundEffect weeklyContractsShopOpen;

	public SoundEffect weeklyContractsShopClose;

	public SoundEffect weeklyContractsBuy;

	public SoundEffect weeklyContractsReroll;

	public SoundEffect claimQuest;

	public SoundEffect switchToAndFromHell;

	public SoundEffect rerollCellAppear;

	public SoundEffect specialDealReveal;

	public SoundEffect contractsAppearFirstTime;

	public SoundEffect giftBoxParticles;

	public SoundEffect giftBoxparticles2;

	public SoundEffect maxUpgrade;

	public SoundEffect maxDowngrade;

	public SoundEffect maxDowngradePopup;

	public SoundEffect playerPathLineScaleX;

	public SoundEffect playerPathRibbonScale;

	public SoundEffect playerPathBecameClaimable;

	public SoundEffect playerPathClaim;

	public SoundEffect playerPathOpen;

	public SoundEffect claimMrBitEasterEventScrap;

	public SoundEffect rollTrackerUpdate;

	public SoundEffect openArcadeEvent;

	public SoundEffect openArcadeEventTvOn;

	public SoundEffect gearDowngrade;

	public SoundEffect gearMaxOut;

	public SoundEffect arcadeBotFlyLeft;

	public SoundEffect arcadeBotRight;

	public SoundEffect clanMissionBossItemUnlock;

	public SoundEffect clanMissionReachTopShimmer;

	public SoundEffect clanMissionAppearBoss;

	public SoundEffect clanMissionAutoclaim;

	public SoundEffect playerAvatarIconSelect;

	public SoundEffect playerAvatarFrameSelect;

	public SoundEffect playerAvatarItemUnlock;

	public SoundEffect reviveTokenSpawn;

	public SoundEffect reviveTokenReach;

	public SoundEffect changeScore;

	public SoundEffect changeRank;

	public SoundEffect elementScaleUp;

	public SoundEffect elementScaleDown;

	public SoundEffect elementScaleNoMove;

	public SoundEffect skullCurrencySpawn;

	public SoundEffect christmasOpen;

	public SoundEffect christmasTopRewardSlide;

	public SoundEffect skullCurrencyCount;

	public void KLOHEFHJMHG(float LNKLGKGMSIJ = 1500f, bool NRLORILTSJR = false)
	{
	}

	public void HFOOLLIHKRT()
	{
	}

	public void OQRFIMMOIHF()
	{
	}

	public void JRKMSLNPPKN()
	{
	}

	public void ESJRPENJRLP()
	{
	}

	public void SFTNOQGKEFO()
	{
	}

	public void TRGOJTJRLJP()
	{
	}

	public void TQRLOKPHIJQ()
	{
	}
}
