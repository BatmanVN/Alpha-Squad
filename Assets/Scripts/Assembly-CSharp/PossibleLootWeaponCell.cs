using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PossibleLootWeaponCell : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class HRKRPRSESMQ
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private WeaponRarityStars stars;

	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> backgrounds;

	public void Setup(WeaponData NHQFORNOPMI, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF)
	{
	}
}
