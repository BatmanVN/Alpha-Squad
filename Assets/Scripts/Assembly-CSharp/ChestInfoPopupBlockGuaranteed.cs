using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ChestInfoPopupBlockGuaranteed : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GRHHSIRFQSN
	{
		public JJHFPNTSRLT.PQRIQGIOGQT weaponRarity;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[SerializeField]
	private GameObject blockWeapon;

	[SerializeField]
	private GameObject blockAgent;

	[SerializeField]
	private Image backgroundWeapon;

	[SerializeField]
	private Image backgroundAgent;

	[SerializeField]
	private Text labelWeapon;

	[SerializeField]
	private Text labelAgent;

	[SerializeField]
	private WeaponRarityStars rarityStarsWeapon;

	public void Setup(bool MSQSLHMQJTM, ChestController.ChestData IEHEOOQKSKK)
	{
	}

	public void Setup(bool MSQSLHMQJTM, JJHFPNTSRLT.PQRIQGIOGQT OSTFJOEMJOG, JJHFPNTSRLT.PQRIQGIOGQT KGSKJFQLFSF, int EIMHOMTNKMS, int PPEPOJPMQSE)
	{
	}

	public bool IsActive()
	{
		return false;
	}
}
