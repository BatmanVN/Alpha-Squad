using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ChestInfoPopupBlockBestDrop : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class SJGNKGSFKHP
	{
		public JJHFPNTSRLT.PQRIQGIOGQT highestWeapon;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[SerializeField]
	private GameObject blockBestWeapon;

	[SerializeField]
	private GameObject blockBestAgent;

	[SerializeField]
	private GameObject raysBestWeapon;

	[SerializeField]
	private GameObject raysBestAgent;

	[SerializeField]
	private Image imageBestWeapon;

	[SerializeField]
	private Image imageBestAgent;

	[SerializeField]
	private WeaponRarityStars starsBestWeapon;

	public void Setup(bool MSQSLHMQJTM, JJHFPNTSRLT.PQRIQGIOGQT ELQPGFMRTKN, JJHFPNTSRLT.PQRIQGIOGQT LJJQGILNLIL)
	{
	}

	public void Setup(bool MSQSLHMQJTM, ChestController.ChestData IEHEOOQKSKK)
	{
	}

	public bool IsActive()
	{
		return false;
	}
}
