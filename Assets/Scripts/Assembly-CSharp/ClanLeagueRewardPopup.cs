using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanLeagueRewardPopup : UIPopup
{
	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private Animation anim;

	[SerializeField]
	private Text rankLabel;

	[SerializeField]
	private Text scoreLabel;

	[SerializeField]
	private Text clanNameLabel;

	[SerializeField]
	private Image promotionImage;

	[SerializeField]
	private Sprite spritePromotion;

	[SerializeField]
	private Sprite spriteDemotion;

	[SerializeField]
	private Text yourScore;

	[SerializeField]
	private Text totalHonorRewardLabel;

	[SerializeField]
	private GameObject participatedBlock;

	[SerializeField]
	private GameObject didNotParticipate;

	[SerializeField]
	private ClanLeagueDisplay previousLeagueDisplay;

	[SerializeField]
	private ClanLeagueDisplay nextLeagueDisplay;

	[SerializeField]
	private GameObject leagueArrows;

	[SerializeField]
	private GameObject rankedInBlock;

	[SerializeField]
	private Text rankedInLabel;

	private static string MSLNFFPNFSO;

	public static void Open(ILTPGJQJTTT.HTPSHMLIFFM FRHSQTFJEET, EOQPNKSSOTM.LeagueInfo JOMLRMTGQKN, int IJJTJIJIIJG, bool FNLJIMTFMIS)
	{
	}

	public void Init(ILTPGJQJTTT.HTPSHMLIFFM FRHSQTFJEET, EOQPNKSSOTM.LeagueInfo JOMLRMTGQKN, int IJJTJIJIIJG, bool FNLJIMTFMIS)
	{
	}

	public Task<string> AsyncGetPlayerScore(long RGIQMITHPGS)
	{
		return null;
	}

	public void OnCloseButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}
}
