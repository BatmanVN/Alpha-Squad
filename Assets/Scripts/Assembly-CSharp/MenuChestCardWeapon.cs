using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MenuChestCardWeapon : MenuChestCardBase
{
	[CompilerGenerated]
	private sealed class MNKTILHSTKJ
	{
		public ItemWeapon w;

		internal bool _003CSetupVisuals_003Eb__0(JJHFPNTSRLT.RaritySprite e)
		{
			return false;
		}
	}

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Text labelCombatPower;

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private WeaponRarityStars rarityStars;

	[SerializeField]
	private GameObject stickerNew;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> backgrounds;

	[SerializeField]
	private Sprite backgroundLegendary;

	public override void Setup(LootElement FILOKRMHOJJ)
	{
	}

	private void HRFISTRLFPM()
	{
	}
}
