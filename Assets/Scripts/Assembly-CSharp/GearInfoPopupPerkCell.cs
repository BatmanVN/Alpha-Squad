using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gear;
using UnityEngine;
using UnityEngine.UI;

public class GearInfoPopupPerkCell : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MJFGNOFNQGN
	{
		public Bonus bonus;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MTSTLHLTGPI
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[SerializeField]
	private Text labelPerkTitle;

	[SerializeField]
	private Text labelPerkLevel;

	[SerializeField]
	private Text labelPerkDescription;

	[SerializeField]
	private Image background;

	[SerializeField]
	private SlicedFilledImage rollFill;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private GameObject iconDoesntStack;

	[SerializeField]
	private ExplanationBubble doesntStackExplanation;

	[SerializeField]
	private Text labelDoesntStackInfo;

	[Space]
	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> raritySprites;

	public void Setup(Bonus TMMOGJKFPSF, bool OPERHTSLMRG = true, bool MINGITGNKPP = false)
	{
	}

	public void Setup(BonusConfig GJFPMSOEQTM, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, bool MINGITGNKPP = false)
	{
	}

	private void NQQLSGLFKLN(MNJMPEKHPTO HSLQJLPMLMH, bool MINGITGNKPP)
	{
	}
}
