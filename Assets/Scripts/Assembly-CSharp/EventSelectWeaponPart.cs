using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Pass;
using UnityEngine;
using UnityEngine.UI;

public class EventSelectWeaponPart : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class SJPPSRMLTPP
	{
		public PassData.PassReward reward;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[SerializeField]
	private Text labelParts;

	[SerializeField]
	private Text labelAmount;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image mainIcon;

	[SerializeField]
	private Sprite partIcon;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> partRarityIcons;

	[SerializeField]
	private Image background;

	public void Setup(PassData.PassReward FILOKRMHOJJ, bool FKPPEQLPJHJ)
	{
	}

	public Image GetBackground()
	{
		return null;
	}
}
