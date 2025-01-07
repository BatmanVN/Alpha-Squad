using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

[Serializable]
public class Quest
{
	[Serializable]
	public struct Requirement
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct TERLOJRSKSP
		{
			public string ret;
		}

		public WeaponData.OHHQFFINRQH weaponCategory;

		public RRMFSKNJIOH agentId;

		public LootElement.TOINELPLRQP lootElementType;

		public bool meleeEnemies;

		public bool rangedEnemies;

		public bool eliteEnemies;

		public bool LFFJNQQEEHG(Requirement FKQLEGQSLHF)
		{
			return false;
		}

		public static Requirement RFQILLLGLGF()
		{
			return default(Requirement);
		}

		public Requirement EMHTREEOMMT()
		{
			return default(Requirement);
		}

		public override string ToString()
		{
			return null;
		}

		public string NOILPIKFGJM()
		{
			return null;
		}

		public bool EENFGQRELSP(Requirement FKQLEGQSLHF)
		{
			return false;
		}

		[CompilerGenerated]
		internal static void NMJQRLHNFKG(string HHRGQEQGGIS, ref TERLOJRSKSP P_1)
		{
		}
	}

	public const int SECONDS_CONVERT_MULTIPLIER = 1000;

	public EJPTJGENOIN id;

	public int tier;

	public List<GameController.KFPHKOMNHSS> completablePlayTypes;

	public LootElement reward;

	public bool rewardBoosted;

	[JsonProperty]
	protected int goal;

	[JsonProperty]
	protected int progress;

	[JsonProperty]
	protected int previousProgress;

	public bool locked;

	public bool previousLocked;

	public bool claimed;

	public Requirement requirement;

	public void ORMRLEPTNGG()
	{
	}

	public bool HLSLKFQEHEE()
	{
		return false;
	}

	public bool TPHQOESRQSL()
	{
		return false;
	}

	public void NRRHGPJHNFO()
	{
	}

	public void SKHQNMJPOTJ()
	{
	}

	public bool HKKORTFIEIP()
	{
		return false;
	}

	public Quest EMHTREEOMMT()
	{
		return null;
	}

	public bool FRLSHSJELQE(GameController.KFPHKOMNHSS NSQRHJPNSGL)
	{
		return false;
	}

	public bool QLIGRLSOKSM()
	{
		return false;
	}

	public bool IQIONLFGLIJ()
	{
		return false;
	}

	public void ELGGJLILMMR()
	{
	}

	public bool RQHQGHGMPRJ()
	{
		return false;
	}

	public bool SENKGHKJJHT(int QHPGKRKFSST = 1)
	{
		return false;
	}

	public string THLOPSNEENK(bool RRSMGMGFMPJ)
	{
		return null;
	}

	public string NOILPIKFGJM()
	{
		return null;
	}

	public int QMTSSERTRHP()
	{
		return 0;
	}

	public int RINMITPHTQJ()
	{
		return 0;
	}

	public int QLLKRKNKQNS()
	{
		return 0;
	}

	public int KJJTTTQJSPR()
	{
		return 0;
	}

	public void KJMHKOOFFIH(int ETEEKJTTIQS)
	{
	}

	public void OTOSIQERRIR(int IFHLLGTRFFL)
	{
	}
}
