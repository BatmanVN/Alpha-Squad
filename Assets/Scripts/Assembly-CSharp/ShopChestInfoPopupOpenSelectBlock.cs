using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ShopChestInfoPopupOpenSelectBlock : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LRGONKGTMKM
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CSetup_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RNHPGTQLHPK
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CSetup_003Eb__1(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[SerializeField]
	private GameObject blockOpenSelect;

	[SerializeField]
	private GameObject blockOpenSelectAvailable;

	[SerializeField]
	private GameObject blockOpenSelectUnavailable;

	[SerializeField]
	private GameObject chestCell;

	[SerializeField]
	private GameObject partCell;

	[SerializeField]
	private Text labelOpenSelect;

	[SerializeField]
	private Text labelSelectChestName;

	[SerializeField]
	private SlicedFilledImage fillOpenSelect;

	[SerializeField]
	private GameObject explanationSelectChest;

	[SerializeField]
	private GameObject explanationSelectPart;

	[SerializeField]
	private GameObject partQuestionMark;

	[SerializeField]
	private GameObject chestQuestionMark;

	[SerializeField]
	private GameObject claimablePartIcon;

	[SerializeField]
	private GameObject claimableChestIcon;

	[SerializeField]
	private Sprite spriteBackgroundWeaponChest;

	[SerializeField]
	private Sprite spriteBackgroundLegendaryWeaponChest;

	[SerializeField]
	private Sprite spriteWeaponPartIcon;

	[Space]
	[SerializeField]
	private List<JJHFPNTSRLT.RaritySprite> rarityBackgrounds;

	[SerializeField]
	private Image chestBg;

	[SerializeField]
	private Image chestIcon;

	[SerializeField]
	private Image claimablePartBg;

	[SerializeField]
	private Image chestCellBg;

	private ChestController.ChestData LIEEKNMLQJJ;

	public void Setup(ChestController.ChestData NKSTGGFNTSP)
	{
	}

	public void OpenExplanation()
	{
	}

	public void CloseExplanation()
	{
	}

	public void Hide()
	{
	}
}
