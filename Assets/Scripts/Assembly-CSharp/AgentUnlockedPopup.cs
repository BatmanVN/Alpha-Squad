using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AgentUnlockedPopup : UIPopup
{
	[Serializable]
	private struct ShownPopups
	{
		public List<RRMFSKNJIOH> agentids;
	}

	[CompilerGenerated]
	private sealed class HSMHQFKFQIJ
	{
		public JJHFPNTSRLT.PQRIQGIOGQT weaponRarity;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HOSRGQGHMJL
	{
		public RRMFSKNJIOH aid;

		internal bool _003CSetupAgentIntro_003Eb__0(JJHFPNTSRLT.AgentIdGameObject x)
		{
			return false;
		}
	}

	[SerializeField]
	private Image gunBackground;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private RectTransform popupParent;

	[SerializeField]
	private WeaponRarityStars stars;

	[SerializeField]
	private Text weaponTitle;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> rarityBackgrounds;

	[SerializeField]
	private InventoryAgentCardCell agentCardCell;

	[SerializeField]
	private GameObject agentCardParent;

	[SerializeField]
	private List<JJHFPNTSRLT.AgentIdGameObject> agentIntros;

	[SerializeField]
	private RectTransform agentIntroParent;

	private global::HIJIFHMGTTR<Vector2> TTRLQRIGTNR;

	private AgentData IFLMHEQTKLS;

	public static string KEY_SHOWN_POPUPS;

	public static void Open(RRMFSKNJIOH KGIEESPQHKH)
	{
	}

	public static void ForceOpen(RRMFSKNJIOH KGIEESPQHKH)
	{
	}

	public void Setup(RRMFSKNJIOH KGIEESPQHKH)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private void JRKLPKOMNOT()
	{
	}

	public bool ShouldShowFor(RRMFSKNJIOH KGIEESPQHKH)
	{
		return false;
	}

	private void LEHFKLEMKRL(RRMFSKNJIOH KGIEESPQHKH)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	private void PHMQSRQPPGS(float PRRKGRQILFR = 0f)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnOkButton()
	{
	}

	public static void ResetShownPopups()
	{
	}

	[CompilerGenerated]
	private void EGSKNORMFKO()
	{
	}
}
