using System.Collections.Generic;
using Gear;
using Pass;
using UnityEngine;

[CreateAssetMenu]
public class Reference : ScriptableObject
{
	public List<WorldData> worlds;

	public CustomStagesReference customStages;

	public EnemyMap enemyMap;

	[Space]
	public GameObject flyingCash;

	public GameObject flyingGems;

	public GameObject flyingXp;

	public GameObject flyingPassXp;

	public GameObject flyingRaidTicket;

	public GameObject flyingHammers;

	public GameObject flyingClanCoins;

	public GameObject flyingHonor;

	public GameObject flyingClanTokens;

	public GameObject flyingClanLeagueTicket;

	public GameObject flyingReviveToken;

	public GameObject flyingSkullToken;

	public GameObject flyingKeys;

	public GameObject pointingFinger;

	public FloatingErrorText floatingErrorText;

	public GameModifierExtraInfo gameModifierInfo;

	[Space]
	public List<ChestConfigData> chestConfigs;

	public LootBoostData chestBoostData;

	[Space]
	public List<SpecialLootConfigData> specialLootConfigs;

	[Space]
	public WeaponPartReference weaponpartRef;

	public AffixReferences affix;

	public EffectsReferences effects;

	public OpeartionElementReference operationElements;

	public GearResourceReference gearResources;

	public RarityReference rarityReference;

	public RemoteOfferReference remoteOfferReference;

	[Space]
	public List<PassData> passes;

	public ArcadePassConfig arcadePassConfig;

	[Space]
	public EnhancementReference enhancementRef;

	public CustomUIReference customUIRef;

	public IconReference iconRef;

	public BackgroundReference backgroundRef;

	public AvatarReference avatarReference;

	[Space]
	public BoostReference boostRef;

	public GameModifierConfigs gameModifierConfigs;

	public List<GameModifier.Icon> gameModifierIcons;

	[Space]
	public LootBoostData gambleLootBoostData;

	[Space]
	public BlueprintsSpritesData blueprintSprites;

	public CommonBaseItemData baseData;

	public Lootbox lootbox;

	public LootboxGems lootboxGems;

	public LootboxAgentCards lootboxAgentCards;

	public LootboxWeaponScrap lootboxWeaponScrap;

	public Bomb bomb;

	public List<WorkshopRecipe> workshopRecipes;

	public PlayerPathConfig playerPathConfig;

	public List<TripleOfferConfig> tripleOffers;

	public List<TripleOfferVisualConfig> tripleOfferIcons;

	public List<WeekendOfferDealConfig> weekendOfferDealConfigs;

	public SkirmishConfigs skirmishConfigs;

	public SkirmishQuestConfigs skirmishQuestConfigs;

	public RiftsMainConfig riftConfig;

	public ExpeditionsConfigs expeditionConfigs;

	public GambleControllerConfiguration gambleConfig;

	public WeeklyContractsConfig weeklyContractsConfig;

	public HalloweenEventConfig halloweenConfig;

	public ChristmasTemporaryEventConfig christmasConfig;

	public MrBitEventConfig mrBitEventConfig;

	public EasterEventConfig easterConfig;

	public ClanEmblemData clanEmblemParts;

	public ParticleSystem roomUpgradeVFX;

	public Sprite clanCoinIcon;

	public Sprite clanTokenIcon;

	public ClanShopItemData clanInventory;

	public ClanLeaguesReference clanLeagues;

	public ClanMissionConfig localClanMissionConfig;

	public List<JJHFPNTSRLT.EnemyVector3> enemyModelOffsets;

	public List<SkinData> shopSkins;
}
