using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class Board : MonoBehaviour
{
	[Serializable]
	public class TrackEventData
	{
		public int hoursLeft;

		public string resource;

		public int amount;

		public int total_amount;

		public int dice_number;

		public string reward_resource;

		public int reward_amount;

		public string reward_total_amount;
	}

	[CompilerGenerated]
	private sealed class HIIFMLHEJJT
	{
		public Board _003C_003E4__this;

		public List<(int, int, int, LootElement)> rollMoves;
	}

	[CompilerGenerated]
	private sealed class PRMEOLJENNP
	{
		public int index;

		public HIIFMLHEJJT CS_0024_003C_003E8__locals1;

		internal void _003CRollDiceMultiple_003Eb__2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class FIHIKTJLMNK
	{
		public Board _003C_003E4__this;

		public int moveFrom;

		public int finalPos;

		public LootElement reward;

		public bool lapPassed;

		public Action onCompleted;

		internal void _003CInstantMove_003Eb__0()
		{
		}

		internal void _003CInstantMove_003Eb__1()
		{
		}

		internal void _003CInstantMove_003Eb__2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class MOGGRNSEMPS
	{
		public Board _003C_003E4__this;

		public int finalPos;

		public LootElement reward;

		public Action onCompleted;

		internal void _003CAnimate_003Eb__0()
		{
		}

		internal void _003CAnimate_003Eb__1()
		{
		}

		internal void _003CAnimate_003Eb__2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class SPJEENSGIII
	{
		public int newPos;

		public MOGGRNSEMPS CS_0024_003C_003E8__locals1;

		internal void _003CAnimate_003Eb__3()
		{
		}

		internal void _003CAnimate_003Eb__4()
		{
		}
	}

	private static bool LLNJMLFGHLT;

	private static readonly int MFMJISTSPNJ;

	private static readonly int OTLNOFTEFHK;

	private static readonly int NJPJSHFJENP;

	private static readonly int RRJOOGHSROE;

	private static readonly int EHKKETJLNKI;

	private static readonly int QNTMHPEFTLJ;

	private static readonly int TSPKROEKRGH;

	private static readonly int JHSIRLQOSGG;

	[SerializeField]
	private BoardTile tilePrefab;

	[SerializeField]
	private GameObject tokenPrefab;

	[SerializeField]
	private BoardRewardDisplay rewardDisplay;

	[SerializeField]
	private Transform buttons;

	[SerializeField]
	private Transform dice;

	[SerializeField]
	private Animator rollAnimator;

	[SerializeField]
	private BaseEventSounds BaseEventSounds;

	[SerializeField]
	private float tokenMoveDelay;

	[SerializeField]
	private EventLaptop eventLaptop;

	private List<BoardTile> QLQEHIQHHHJ;

	private BoardToken NKQJJMRGNLS;

	private Action JORTGLGTMLH;

	private Sequence QRLHHHQKRFH;

	public Action OnRollingStarted;

	public Action OnRollingEnded;

	private HFOHRLHFNRL HESSKMEKTLF;

	private int PIKGGGLQFTO;

	private bool ONSFJFGJOGN;

	private bool NSHPJKPFEEQ;

	private float JPMOQRTRJEM;

	private const float GQOEERGFGNF = 1f;

	private const float KRRSQIKSKQS = 3f;

	private const int MIHPEQKRLNL = 2;

	public event Action RNLRGHPQQPR
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

	public void Setup(Action JISONJTEQJJ, HFOHRLHFNRL PIKHJJRRMKS)
	{
	}

	private void KMPHJLHGQNP()
	{
	}

	private void MGRLTPGGSSI()
	{
	}

	private void EGMSROHTINM()
	{
	}

	private void HHJESSOTSPT(LootElement GTNLNSRKHET, BoardTile JOTSJKFPFFF)
	{
	}

	private void QROLRQHJERO(ref TrackEventData GFOLQSRRELP, int JEFLOELTQGJ, LootElement FILOKRMHOJJ)
	{
	}

	public void RollDice(ref TrackEventData GFOLQSRRELP)
	{
	}

	public void RollDiceMultiple(int THJTILRESHL, ref TrackEventData GFOLQSRRELP)
	{
	}

	public void DebugRoll(int THJTILRESHL)
	{
	}

	public void RunTestMystery(int THJTILRESHL)
	{
	}

	public void RunTEstRegular(int THJTILRESHL)
	{
	}

	public void SetInstantAnimations(bool QPNIRNRNJON)
	{
	}

	public bool IsInstantAnimations()
	{
		return false;
	}

	public bool IncreaseAnimationSpeed()
	{
		return false;
	}

	private void SLKHGMIKGQK()
	{
	}

	public bool CanRoll()
	{
		return false;
	}

	private void SQQNMKJTQSM()
	{
	}

	private void SQNOPNRETTQ(int JRREEHSFTMH, int RTGEPIFMSES, LootElement FILOKRMHOJJ, Action SQEPQEOJHOK)
	{
	}

	private void KSGLPFEJITM(int OGIJEMOETEL, int REMQPHSNQOL, LootElement FILOKRMHOJJ, Action SQEPQEOJHOK)
	{
	}

	private void JHRKMJMRMRO(int OGIJEMOETEL, int REMQPHSNQOL, LootElement FILOKRMHOJJ, Action SQEPQEOJHOK)
	{
	}

	private float LRHKOSQLEQR(int PQNITOOPPOG)
	{
		return 0f;
	}

	private void OOLLHIMIGRG(int JSMLIQPPPQS)
	{
	}

	private void HNEKLOMMQIO(int JSMLIQPPPQS)
	{
	}

	private void GNIRFSEQETE(int JSMLIQPPPQS, GameObject LSEIEENGTPO)
	{
	}

	public void UpdateCardState(bool NTFHGJLTGHR)
	{
	}

	private void GMPSRMPOLRL(int JSMLIQPPPQS, LootElement FILOKRMHOJJ, GameObject LSEIEENGTPO)
	{
	}

	private void QKJTEKSLNFS(int PQNITOOPPOG)
	{
	}

	private static string QTTPMOEIKNS(LootElement.TOINELPLRQP HSLQJLPMLMH)
	{
		return null;
	}

	private int FJIITFHFMFG(LootElement GTNLNSRKHET)
	{
		return 0;
	}

	private BoardTile KLQJEQHKRES()
	{
		return null;
	}

	private BoardTile SMOGQFNSKTH(int PSPJIJNTMOI)
	{
		return null;
	}

	private void RLFKQOJGPPI(int RRPSNPOTQNT)
	{
	}

	private bool JMMIPNEGFRO(int EESTGTGKLJG, int INSONFSFJGR)
	{
		return false;
	}

	private void RLFMEPTJNNG()
	{
	}

	private Vector3 PLIFLOONHJG(int RRPSNPOTQNT)
	{
		return default(Vector3);
	}

	private void JGPSSQSQKJG(int GPRNIQOOQJM)
	{
	}

	public int GetRollsRemaining()
	{
		return 0;
	}
}
