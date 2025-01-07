using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class Equipment
{
	[Serializable]
	public struct Data
	{
		public int activeLoadout;

		public int profileLoadout;

		public List<Loadout> loadouts;

		public RRMFSKNJIOH activeAgent;

		public List<string> equippedWeapons;

		public string equippedHead;

		public string equippedBody;

		public string equippedAccessory;

		public string equippedGadget;

		public Loadout KLGGQQSEJPN()
		{
			return default(Loadout);
		}

		public bool OLTTKPQSJIQ()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KMPQHLMPLEQ
	{
		public ItemGear previousGear;

		public ItemGear ig;

		public Loadout lo;

		public Equipment _003C_003E4__this;

		public bool emit;

		internal void _003CEquipItemGear_003Eb__1(bool transfer)
		{
		}
	}

	[CompilerGenerated]
	private sealed class KGOHNRMGGKM
	{
		public ItemWeapon weapon;

		public Func<string, bool> _003C_003E9__1;

		internal bool _003CIsItemWeaponEquipped_003Eb__0(Loadout x)
		{
			return false;
		}

		internal bool _003CIsItemWeaponEquipped_003Eb__1(string uuid)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class SOSTTMLHPIT
	{
		public Equipment _003C_003E4__this;

		public JPHMLSJQLNL id;

		internal bool _003CIsWeaponSameIDEquipped_003Eb__0(string x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HSEGPMHFPTI
	{
		public Equipment _003C_003E4__this;

		public ItemWeapon weapon;

		internal bool _003CIsLegendaryEquipped_003Eb__0(string x)
		{
			return false;
		}
	}

	private ItemController ic;

	[CompilerGenerated]
	private Action OnEquipmentChanged;

	[CompilerGenerated]
	private Action<ItemWeapon> OnAutoEquippedWeapon;

	public const int MAX_LOADOUT_COUNT = 4;

	public Data data;

	public static string KEY;

	public event Action MPSINRELJQJ
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ItemWeapon> HILSTSGJHOE
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void NGHFQRREIJN(ItemController NJTPNQMTJOR)
	{
	}

	private void OOTHKOEMSFP()
	{
	}

	private int LTQIMOSOKEI()
	{
		return 0;
	}

	public LoadoutWithDataAndGlobalEnhancements RKMIQQQGIKR()
	{
		return null;
	}

	public Loadout GQQLNOONOEE()
	{
		return default(Loadout);
	}

	public int TFTTQKQEGNI()
	{
		return 0;
	}

	public int KSSITKJOSQG()
	{
		return 0;
	}

	public Loadout FSSQEMEORHF()
	{
		return default(Loadout);
	}

	private void PHTMGOHHJNR(Loadout FLSIITIJMSK)
	{
	}

	public void QMLQETPPKSL()
	{
	}

	public void PMITOIOJNOT()
	{
	}

	private void QIMEGRQEKSR()
	{
	}

	public void QQTNJNTHJKN()
	{
	}

	public void NTFLSIRIRGM()
	{
	}

	public void SNOIMKQEPKF(int PNIQKIGEHLF)
	{
	}

	public void OLPQNKPNJTG(int PNIQKIGEHLF)
	{
	}

	private void RRPREINLGQT()
	{
	}

	public void KMSETPNOQET(ItemGear NTISFTTTKEK, bool EPEOKSGENTK = true, bool NIOEKIIFGME = true)
	{
	}

	public void RJKGHHOSQML(ItemGear NTISFTTTKEK, bool EPEOKSGENTK = true)
	{
	}

	public bool SFOGQRKOQPG(ItemGear GIMISJFQPLI)
	{
		return false;
	}

	public bool MOLOTKKKOPG(ItemGear GIMISJFQPLI)
	{
		return false;
	}

	public List<ItemGear> FENTRRSEFKT()
	{
		return null;
	}

	public ItemGear HOGENNESHPL(KNSKIMFQMTH EHEHKSMHOIK)
	{
		return null;
	}

	public List<int> TIQSSLOMRNG(ItemGear GIMISJFQPLI)
	{
		return null;
	}

	public bool HINMSIJRTEG(ItemWeapon LENQOPNFMTG)
	{
		return false;
	}

	public List<int> RLQNMTMGPIR(ItemWeapon LENQOPNFMTG)
	{
		return null;
	}

	public bool ROSHSNREEEJ(ItemWeapon LENQOPNFMTG)
	{
		return false;
	}

	public bool EHRTMEQSLPR(JPHMLSJQLNL HSLQJLPMLMH)
	{
		return false;
	}

	public bool JEPNHNSEQHJ(ItemWeapon LENQOPNFMTG)
	{
		return false;
	}

	public void GNQIRGJFRPI(ItemWeapon LENQOPNFMTG, int EHEHKSMHOIK = -1, bool EPEOKSGENTK = true)
	{
	}

	public bool PHTFLFNMQER(int GQMLFHITQPE, int LLMRGJPTORT, bool EPEOKSGENTK = true)
	{
		return false;
	}

	public bool EIGEJSIQFJQ(ItemWeapon LENQOPNFMTG)
	{
		return false;
	}

	public void GGPNGGIQOJH(int EHEHKSMHOIK = 0, bool EPEOKSGENTK = true)
	{
	}

	public void GGPNGGIQOJH(ItemWeapon LENQOPNFMTG)
	{
	}

	public bool RPIEKRNJHME(List<ItemWeapon> EEHPKGGSNSL = null)
	{
		return false;
	}

	private void IHLPITFQKPM()
	{
	}

	public List<ItemWeapon> FRHNTGEGNOO()
	{
		return null;
	}

	public List<ItemWeapon> ONNNFTKSMFE()
	{
		return null;
	}

	public int MGLLHOELHFT()
	{
		return 0;
	}

	public int IPNRHTHTTRE()
	{
		return 0;
	}

	public int ROLIOGJNTKE()
	{
		return 0;
	}

	public int LITNJQRLKOS()
	{
		return 0;
	}

	public void PPEEENHSNSI(bool EPEOKSGENTK = true)
	{
	}

	public void HGLFTHOHINH(Agent IFLMHEQTKLS, bool EPEOKSGENTK = true)
	{
	}

	public void LHLJSPLFSIF(RRMFSKNJIOH HSLQJLPMLMH, bool EPEOKSGENTK = true)
	{
	}

	public void TITKJSRKNOR(Agent IFLMHEQTKLS)
	{
	}

	public bool TSIQSQRTMHJ(RRMFSKNJIOH TMQJMGQNQQR)
	{
		return false;
	}

	public Agent GNLJRMGMNKO()
	{
		return null;
	}
}
