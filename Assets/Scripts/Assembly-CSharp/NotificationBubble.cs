using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class NotificationBubble : MonoBehaviour
{
	public enum FESLOLTPINT
	{
		UNSET = 0,
		INVENTORY_CHANGE = 1,
		OPERATIONS = 4,
		AGENT_ENHANCEMENT = 7,
		AGENT_BROAD = 8,
		AGENT_UPGRADE = 9,
		WORKSHOP_NEW_RECIPE = 10,
		WORKSHOP_NEW_RECIPE_SINGLE = 11,
		WORKSHOP_NEW_RECIPE_CATEGORY = 12,
		NEW_GEAR = 13,
		GLOBAL_TAB_FIRST = 16,
		RIFTS_AVAILABLE = 17,
		BASE_TOKENS_AVAILABLE = 19,
		BASE_GENERATOR_FULL = 20,
		BASE_NOT_VISITED = 21,
		BASE_GENERATOR_ABOVE_THRESHOLD = 22,
		TEMPORARY_EVENT_ACTION_AVAILABLE = 23,
		BASE_CLAIMABLE_ROOM = 24,
		RIFTS_REWARDS = 25,
		CLAN_BLOCK_NOT_CLICKED = 27,
		MAIL = 28,
		PLAYER_PATH_UNCLAIMED_REWARDS = 30,
		ANY_EQUIPPED_UPGRADEABLE = 31,
		CONTRACTS_NEW_SHOP = 34,
		CHEST_NOT_STARTED = 35,
		SHOP_AD_REWARDS = 36,
		SHOP_REALMONEY_OFFERS = 37,
		SHOP_INGAMECURRENCY_OFFERS = 38,
		LEGENDARY_CHEST_CLAIM = 39,
		WEAPON_CHEST_CLAIM = 40,
		PART_CHEST_CLAIM = 41,
		ELITE_PASS_CLAIM = 43,
		CONTRACTS_CLAIM = 44,
		ARCADE_PASS_CLAIM = 45,
		FREE_RAID_AVAILABLE = 46,
		BLACK_FRIDAY_SHOP = 47,
		CHRISTMAS_SHOP = 48,
		REUSABLE_VIP_SHOP = 49
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct FQGNOJJGROR
	{
		public bool shouldActivate;
	}

	public FESLOLTPINT type;

	public RRMFSKNJIOH agentID;

	public PJLTIFIPFSM workshopRecipeId;

	public WorkshopRecipe.NOMPPKKTNOF workshopRecipeCategory;

	private FESLOLTPINT[] LLFNLMJEFKI;

	public bool checkOnEnable;

	public bool invertState;

	[SerializeField]
	private Transform visual;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private bool IRNKQIFJGRI(FESLOLTPINT OGFKHSKTHHR)
	{
		return false;
	}

	private void JSKPRQMNTKN()
	{
	}

	private void TFQEKPRMTSN()
	{
	}

	private void MKELOGIFJRQ()
	{
	}

	private bool OLKEPOMSFNJ()
	{
		return false;
	}

	private void QKEOFIITIFQ(string ENSHQFNLRJT)
	{
	}

	public void ManualCheckState()
	{
	}

	private void JOQGLQQSLJN(MenuView QPNIRNRNJON)
	{
	}

	private void TSPKELMKPHP()
	{
	}

	private void NPHSHMPTORT()
	{
	}

	private void JOGTEKPITLS(bool KQGHGPEKKTJ = true)
	{
	}

	private void PTTFSNOSHIM(bool KQGHGPEKKTJ = true)
	{
	}

	private bool MGSNNTKTHTP()
	{
		return false;
	}

	private bool NQHSSLTIKGM()
	{
		return false;
	}

	[CompilerGenerated]
	private void MTIQJJIHNFQ(RRMFSKNJIOH KGIEESPQHKH)
	{
	}

	[CompilerGenerated]
	private void JTOHNNPFGFT(RRMFSKNJIOH TMQJMGQNQQR)
	{
	}

	[CompilerGenerated]
	internal static bool RNQTQMHSPSF(string HSEHTKMSMPJ, ref FQGNOJJGROR P_1)
	{
		return false;
	}
}
