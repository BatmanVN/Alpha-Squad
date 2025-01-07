using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class Inventory
{
	[Serializable]
	public class Data
	{
		[CompilerGenerated]
		private sealed class RGJEISESTPL
		{
			public string uuid;

			internal bool _003CGetItemWeaponForUUID_003Eb__0(ItemWeapon w)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class ERTRFLFKTQN
		{
			public string uuid;

			internal bool _003CGetItemGearForUUID_003Eb__0(ItemGear w)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class ELRNETJKQTG
		{
			public RRMFSKNJIOH id;

			internal bool _003CGetAgentForId_003Eb__0(Agent a)
			{
				return false;
			}
		}

		public List<ItemWeapon> weapons;

		public List<ItemGear> gear;

		public List<Agent> agents;

		public List<IRHNENTFPPM> unlockedSkins;

		public ObscuredInt slotCount;

		public ObscuredInt slotCountGear;

		public ItemWeapon KLORTTHTROS(string KRLSSTQSQRJ)
		{
			return null;
		}

		public ItemGear HSQOFHPMNQJ(string KRLSSTQSQRJ)
		{
			return null;
		}

		public Agent TKESNMOMRQK(RRMFSKNJIOH HSLQJLPMLMH)
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class LLRMTNNGKIN
	{
		public ItemWeapon i;

		internal bool _003CAddItemWeapon_003Eb__0(ItemWeapon x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QSGNQNSNILQ
	{
		public JPHMLSJQLNL id;

		internal bool _003CGetAllWeaponsWithId_003Eb__0(ItemWeapon i)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MJHEGFFHMIP
	{
		public WeaponData.OHHQFFINRQH category;

		internal bool _003CGetAllWeaponsWithCategory_003Eb__0(ItemWeapon i)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class OKHTLSQOIGT
	{
		public RRMFSKNJIOH agent;

		internal bool _003CUnlockAgent_003Eb__0(Agent x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class SMFGIQSPSKP
	{
		public ItemGear i;

		internal bool _003CAddItemGear_003Eb__0(ItemGear x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class FMGEROLLMMI
	{
		public string uuid;

		internal bool _003CIsUUIDUnique_003Eb__0(ItemWeapon w)
		{
			return false;
		}

		internal bool _003CIsUUIDUnique_003Eb__1(ItemGear x)
		{
			return false;
		}
	}

	public Data data;

	private ItemController ic;

	[CompilerGenerated]
	private Action OnInventoryChanged;

	[CompilerGenerated]
	private Action<RRMFSKNJIOH> OnAgentUnlocked;

	[CompilerGenerated]
	private Action<string> OnItemReceived;

	[CompilerGenerated]
	private Action<string> OnItemLost;

	[CompilerGenerated]
	private Action<IRHNENTFPPM> OnSkinUnlocked;

	[CompilerGenerated]
	private Action<RRMFSKNJIOH, IRHNENTFPPM> OnSkinChanged;

	public static string KEY;

	public event Action TTFSNSNJGHE
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

	public event Action<RRMFSKNJIOH> FOKJFHSFNTL
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

	public event Action<string> OREEIKKMEFJ
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

	public event Action<string> PSSILRTPLJL
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

	public event Action<IRHNENTFPPM> HQKIKPIMKQK
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

	public event Action<RRMFSKNJIOH, IRHNENTFPPM> OGTINOLJHSS
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

	private void SGREKJMJNRS()
	{
	}

	private void QPOELIQONJJ()
	{
	}

	private void FRHLTSNTNTQ()
	{
	}

	private void GIENJKIJMML()
	{
	}

	private void LLRGIEOSPNP()
	{
	}

	private void SMEPQROLLTH()
	{
	}

	public void QMLQETPPKSL()
	{
	}

	public void JFSRHHMSMJJ(string KRLSSTQSQRJ)
	{
	}

	public void PMITOIOJNOT()
	{
	}

	public void QQKJEHETKEG(bool HRTHMOOEFFS = true, bool EPEOKSGENTK = true, bool LIPENRNHTJL = true)
	{
	}

	public void FJMKSILKOIQ(bool HRTHMOOEFFS = true, bool EPEOKSGENTK = true, bool LIPENRNHTJL = true)
	{
	}

	public bool PSOOLGGKLSI(JJHFPNTSRLT.QMNJMEELPPP NNIGGHJLLKR)
	{
		return false;
	}

	public void GJOHELEJPMP(ItemWeapon KQQINSRPRNP, bool EPEOKSGENTK = true, bool LIPENRNHTJL = true)
	{
	}

	public void SKHRFJNGOFN(ItemWeapon KQQINSRPRNP, bool EPEOKSGENTK = true, bool LIPENRNHTJL = true)
	{
	}

	public List<ItemWeapon> MOEPGKIGLQG()
	{
		return null;
	}

	public List<ItemWeapon> FLPRLJKGFPQ()
	{
		return null;
	}

	public List<ItemWeapon> MQKRQMPMMMN(JPHMLSJQLNL HSLQJLPMLMH)
	{
		return null;
	}

	public List<ItemWeapon> SEENNQSQEHR(WeaponData.OHHQFFINRQH EMKNPKTIJPF)
	{
		return null;
	}

	public bool OHMQTKMQIGN()
	{
		return false;
	}

	public ItemWeapon KLORTTHTROS(string KRLSSTQSQRJ)
	{
		return null;
	}

	public void OGOMMTMHPFG(RRMFSKNJIOH IFLMHEQTKLS, bool EPEOKSGENTK = true, bool OGISTEESPIJ = true, int FNGNTFHMLFM = 0)
	{
	}

	public bool LPHJRRNOJHP(IRHNENTFPPM QHTSIIGGMOP, bool EPEOKSGENTK = true)
	{
		return false;
	}

	public bool OSEEHFGSFRL()
	{
		return false;
	}

	public bool OLFPLMGMGSQ(RRMFSKNJIOH IFLMHEQTKLS)
	{
		return false;
	}

	public bool JGFHPKLGMSK(IRHNENTFPPM QHTSIIGGMOP)
	{
		return false;
	}

	public void LKSROGRPTRG(RRMFSKNJIOH KGIEESPQHKH, IRHNENTFPPM OJRQNTQHSHO, bool EPEOKSGENTK = true)
	{
	}

	public Agent TKESNMOMRQK(RRMFSKNJIOH HSLQJLPMLMH)
	{
		return null;
	}

	public List<Agent> RFKQGLRLHQO()
	{
		return null;
	}

	public void TITKJSRKNOR(Agent IFLMHEQTKLS)
	{
	}

	private void SSSPPFIERRI(RRMFSKNJIOH TMQJMGQNQQR, bool EPEOKSGENTK = true)
	{
	}

	public List<ItemGear> MKHRIPLESPF()
	{
		return null;
	}

	public List<ItemGear> OFLRSQOINEL()
	{
		return null;
	}

	public void SERRFSEGPMP(ItemGear KQQINSRPRNP, bool EPEOKSGENTK = true, bool LIPENRNHTJL = true, bool JOJTHHPFONQ = true)
	{
	}

	public void QRJOSNSHRJK(ItemGear KQQINSRPRNP, bool EPEOKSGENTK = true, bool LIPENRNHTJL = true, bool JOJTHHPFONQ = true)
	{
	}

	public ItemGear HSQOFHPMNQJ(string KRLSSTQSQRJ)
	{
		return null;
	}

	public bool POTLNLIJFLN()
	{
		return false;
	}

	private bool MIQJTGEGFLG(string KRLSSTQSQRJ)
	{
		return false;
	}

	public static string MFJHTJQRIEE()
	{
		return null;
	}

	public bool IOHFLEHERKG()
	{
		return false;
	}

	public bool GOGELMTGTIQ(JJHFPNTSRLT.QMNJMEELPPP HPLEMOEHNLF)
	{
		return false;
	}

	[CompilerGenerated]
	private bool JTTMTRHKMRK(ItemWeapon HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	private bool RLFTNPHRMOL(ItemGear HNLHQPIFJNS)
	{
		return false;
	}

	[CompilerGenerated]
	internal static int TKESTSNJMLR(Agent ORJKLRMKMKI)
	{
		return 0;
	}
}
