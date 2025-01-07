using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class OfferBlackFriday : OfferData
{
	[CompilerGenerated]
	private sealed class NSREFNPEENE
	{
		public List<ItemWeapon> weapons;

		public OfferBlackFriday _003C_003E4__this;

		public Action onPurchased;

		public Action<bool> _003C_003E9__1;

		internal void _003COpenPurpleChestPurchase_003Eb__0(List<ItemWeapon> x)
		{
		}

		internal void _003COpenPurpleChestPurchase_003Eb__1(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class MKGJPRTETJK
	{
		public OfferBlackFriday _003C_003E4__this;

		public Action onPurchased;

		public Action<bool> _003C_003E9__1;

		internal void _003COpenUncommonWeaponPartPurchase_003Eb__0(List<JJHFPNTSRLT.WeaponPart> x)
		{
		}

		internal void _003COpenUncommonWeaponPartPurchase_003Eb__1(bool ok)
		{
		}
	}

	[CompilerGenerated]
	private sealed class RMIGJTGLGHN
	{
		public OfferBlackFriday _003C_003E4__this;

		public Action onPurchased;

		public Action<bool> _003C_003E9__1;

		internal void _003COpenExceptionalWeaponPartPurchase_003Eb__0(List<JJHFPNTSRLT.WeaponPart> x)
		{
		}

		internal void _003COpenExceptionalWeaponPartPurchase_003Eb__1(bool ok)
		{
		}
	}

	private int start;

	private int duration;

	private int recurInterval;

	public List<string> purchasedProducts;

	public ItemWeapon selectedWeapon;

	public JJHFPNTSRLT.WeaponPartIdentifier selectedUncommonWeaponPart;

	public JJHFPNTSRLT.WeaponPartIdentifier selectedExceptionalWeaponPart;

	private readonly string[] TIER_0_PURCHASES;

	private readonly string[] TIER_1_PURCHASES;

	private readonly string[] TIER_2_PURCHASES;

	public static string DEEP_LINK_KEY;

	protected override ShopController.IQHJOMNOSOS KPMTISGSLPK()
	{
		return default(ShopController.IQHJOMNOSOS);
	}

	protected override void GTLHTGQITLO(ShopController.SJQRHINLPLS SOSLGOOOIPG)
	{
	}

	protected override void MOJPJNJTNSO()
	{
	}

	private int ITFFITSGHSF()
	{
		return 0;
	}

	private void OLFKRMOSRQN(bool RHOIJKGIEEP)
	{
	}

	public override int QPKJIQOLGJS()
	{
		return 0;
	}

	public bool NGNGISRIMLJ(string RKJTFRTJSIR)
	{
		return false;
	}

	public ItemWeapon RRQEGOQSJNE()
	{
		return null;
	}

	public JJHFPNTSRLT.WeaponPartIdentifier QKPLHMPHMPO()
	{
		return default(JJHFPNTSRLT.WeaponPartIdentifier);
	}

	public JJHFPNTSRLT.WeaponPartIdentifier FSQGGKFQKGL()
	{
		return default(JJHFPNTSRLT.WeaponPartIdentifier);
	}

	public void OGRNMLHSPET(string RKJTFRTJSIR)
	{
	}

	public static LootList ILSEGKPPGMR(string RKJTFRTJSIR)
	{
		return null;
	}

	public void NHPKEESQLGK(Action KFHITMGHHTR)
	{
	}

	public void GEPHTEMIEHN(Action KFHITMGHHTR)
	{
	}

	public void TNKMLSKMLLQ(Action KFHITMGHHTR)
	{
	}

	public bool RGFHEMQKOLH(int FOQIJNNSRNI)
	{
		return false;
	}

	public bool PEJEQIPTSHK()
	{
		return false;
	}

	public bool ITINJRJGNGG()
	{
		return false;
	}

	public bool KREMPFPMHFJ()
	{
		return false;
	}

	public int LMMQJIFKLIK(string RKJTFRTJSIR)
	{
		return 0;
	}

	public void NJPJSHFJENP()
	{
	}

	[CompilerGenerated]
	private bool KPMJSHHKLTP(string HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private bool FRJMLPLJSKI(string HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private bool TETEFMNIJKP(string HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private bool FQMHHMLENKP(string HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private bool GPSKKNOIGFI(string HNLHQPIFJNS)
	{
		return false;
	}
}
