using System.Collections.Generic;
using UnityEngine;

public class BaseReferences : ScriptableObject
{
	public BaseObjectPlaceholder BaseObjectPlaceholder;

	public SerializableDictionary<BaseObjectData.LKKQKTPQSNS, Sprite> categoryIcons;

	public Material gridMat;

	public Material validCellMat;

	public Material invalidCellMat;

	public Material edgeCellMat;

	public Material windowHighlightUiMat;

	public Sprite gemIcon;

	public Sprite cashIcon;

	public Sprite ticketIcon;

	public Sprite hammersIcon;

	public List<Sprite> prestigeRanks;

	public Sprite genGemIcon;

	public Sprite genCashIcon;

	public Sprite genTicketIcon;

	public Sprite activeTileBg;

	public Sprite inactiveTileBg;

	public FloatingErrorText errorText;

	public GameObject baseGridArrow;

	public GameObject flyingXp;

	public GameObject flyingHammer;

	public GameObject flyingBaseToken;

	public FlyingStorageBox flyingStorageBox;

	public GameObject tutorialRewardToken;

	public GameObject flyingTicket;

	public GameObject uiGeneratorBubble;

	public GameObject uiBuildRoom;

	public GameObject tutorialRewardBox;

	public GameObject pointingFinger;

	public GameObject generatorPickup;

	public GameObject animatedLock;

	public GameObject interactableArrow;

	public ParticleSystem generatorParticles;

	public ParticleSystem buildDust;

	public ParticleSystem buildConfetti;

	public ParticleSystem buttonHitParticles;

	public ParticleSystem attentionBeam;

	public GameObject collectBeamGems;

	public GameObject collectBeamCash;

	public GameObject collectBeamTickets;

	public Shader stencilWall;

	public Shader stencilFloor;

	public Shader stencilMask;

	public List<UIRankRewardBoost> rankRewards;
}
