using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class Soldier : AgentEnemy
{
	public enum STTLQKEELKQ
	{
		PATROLLING = 0,
		CHASING = 1,
		SHOOTING = 2,
		LOOKING = 3,
		STRAFING = 4,
		LOST = 5,
		SPECIAL = 6,
		NONE = 7
	}

	public SoundEffect alertedSound;

	[Space]
	public STTLQKEELKQ state;

	[SerializeField]
	private RangeIndicator targetIndicatorLogic;

	[SerializeField]
	private bool detectionConeVisible;

	[SerializeField]
	private float detectionRange;

	[SerializeField]
	private float detectionInterval;

	private float TLJKOMISJFK;

	[SerializeField]
	private Collider detectionCollider;

	private bool NRPNSJJTKJI;

	private EnemyPatrol LOJQOEKSIQK;

	private Vector3 NLNQJJRJMMP;

	private float LPKPTPFQJMM;

	private float HJKGFKGIQQR;

	public bool alerted;

	private Tween NRTEKRLTTNS;

	private float NRMGFTSNKEG;

	private float HEHLHKPEKIR;

	[SerializeField]
	private bool strafeEnabled;

	[SerializeField]
	private float strafeInterval;

	private float MRFMEIMPLIJ;

	private bool QSSPJINNIPT;

	private Vector3 INOGKEFSRQT;

	[SerializeField]
	private float maxStrafeDistance;

	[SerializeField]
	private float reactionInterval;

	private float FRFLOSIKTKR;

	[SerializeField]
	private float announceHit;

	[SerializeField]
	private float announceDeath;

	[SerializeField]
	private float listenShotDistMultiplier;

	[SerializeField]
	private bool mustFinishReloading;

	public SRLPFFRNIOO special;

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public bool CanShootAfterReload()
	{
		return false;
	}

	public override void Setup(int TESLKRGRTQR, EnemySpot.OOSTRKKLKGI NLPKPQMRSGL)
	{
	}

	protected override void Update()
	{
	}

	public bool IsSpecial()
	{
		return false;
	}

	public override bool IsAttacking()
	{
		return false;
	}

	public override void SetAttackTarget(Actor ETGMMEJFEOP)
	{
	}

	protected override void AddPush(LQJTRNFQISM EMERMLLSHSL)
	{
	}

	private void JIQOQGNHLFO()
	{
	}

	private void RQMEHGKHKRQ()
	{
	}

	protected virtual void SISKOSNLMGE()
	{
	}

	public virtual void DoChase()
	{
	}

	protected virtual void EIPFIMRRKMT()
	{
	}

	protected virtual void GMNRTGRMNSM()
	{
	}

	protected virtual void FHLNNFFQKKL()
	{
	}

	protected virtual void MTLNEFNHHLG()
	{
	}

	private void NRKNNNRLMTS()
	{
	}

	protected virtual float MFJHFIPLKKE()
	{
		return 0f;
	}

	protected virtual float IHGERRRMNKG()
	{
		return 0f;
	}

	private void IPNKKRQHSQO()
	{
	}

	private void OSINOOLPLPS(Actor ETGMMEJFEOP)
	{
	}

	public void TargetLock(Actor ETGMMEJFEOP)
	{
	}

	protected override void ILNIRROTMNN()
	{
	}

	public override void OnPlayerEnterVision(Player OPQHPOGPSFI)
	{
	}

	public override void OnPlayerExitVision(Player OPQHPOGPSFI)
	{
	}

	public override void OnReceiveAnnouncement(Transform EESTGTGKLJG, float IMJQQHHMJEQ)
	{
	}

	public override void OnPlayerFire()
	{
	}

	public override float GetNormalizedSpeed()
	{
		return 0f;
	}

	public override float GetMaxSpeed()
	{
		return 0f;
	}

	public override void LostAllHealth(LQJTRNFQISM EMERMLLSHSL = null)
	{
	}

	public override bool Hit(LQJTRNFQISM EMERMLLSHSL)
	{
		return false;
	}

	protected override void KRKRKTTPFIQ()
	{
	}

	[CompilerGenerated]
	private void EEKFFLTEGQT()
	{
	}
}
