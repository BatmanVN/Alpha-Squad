using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RemoteOffers;
using UnityEngine;
using UnityEngine.UI;

public class RemoteOfferWeaponPartSelectPopup : RemoteOfferPopupBase_ProductSelect
{
	[CompilerGenerated]
	private sealed class GITIFJTQGPF
	{
		public JJHFPNTSRLT.WeaponPartIdentifier wpid;

		public CurrencyData.WeaponParts allWeaponParts;

		public Func<LootElement, bool> _003C_003E9__2;

		internal bool _003CInitLoot_003Eb__2(LootElement x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class STPEFSEGKQO
	{
		public JJHFPNTSRLT.WeaponPart wpart;

		internal bool _003CInitLoot_003Eb__3(JJHFPNTSRLT.WeaponPart x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class ESMOOKJKTMQ
	{
		public JJHFPNTSRLT.WeaponCategoryGameObject cat;

		internal int _003CInitLoot_003Eb__4(JJHFPNTSRLT.WeaponPart x)
		{
			return 0;
		}
	}

	[SerializeField]
	private GameObject blockCategories;

	[SerializeField]
	private List<JJHFPNTSRLT.WeaponCategoryGameObject> categoryButtons;

	[SerializeField]
	private RectTransform infoNotSelected;

	[SerializeField]
	private RectTransform infoSelected;

	[SerializeField]
	private List<GameObject> weaponParts;

	[SerializeField]
	private GridLayoutGroup partsLayout;

	private LootIdentifier NFEEQEMKTOP;

	private JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF;

	private WeaponData.OHHQFFINRQH GENIGLEFJPS;

	private WeaponData.OHHQFFINRQH PRPNOGSSSLJ;

	private List<JJHFPNTSRLT.WeaponPart> IMNHIJNTPJP;

	private int TIOLFGRIGPN;

	public static void Open(RemoteOfferData GLNTLSLQFFS, bool PRLEJONOPLK = true)
	{
	}

	protected override bool MLNESSGJRME(RemoteOfferData GLNTLSLQFFS)
	{
		return false;
	}

	private void PKPFTNINPEP()
	{
	}

	public void OnWeaponPartClicked(int PNIQKIGEHLF)
	{
	}

	public void OnCategoryClicked(int OJTGHRGORLS)
	{
	}

	private void JMNQITIQIOO(WeaponData.OHHQFFINRQH EMKNPKTIJPF)
	{
	}

	private int KLLIQPMLTOL()
	{
		return 0;
	}

	protected override List<LootElement> PLGLNGJIGHT()
	{
		return null;
	}

	protected override bool QIJMHIJRMPI()
	{
		return false;
	}

	[CompilerGenerated]
	internal static void FTNJTHRIQQS(ItemWeapon MGRTOPLOHGM, Image ITRKNMFTGIG, GameObject QIMGEOQLLHO)
	{
	}

	[CompilerGenerated]
	internal static ItemWeapon QQLFSPGQGLR(JJHFPNTSRLT.WeaponPartIdentifier PLKFROSLRHP)
	{
		return null;
	}
}
