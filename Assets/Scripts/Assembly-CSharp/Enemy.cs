using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : Actor
{
	private const float STFHHSLHOIO = 0.75f;

	private const float PKJQTPSEOJO = 1.5f;

	public const float RIFTS_BOSS_HEALTH_MULTIPLIER = 3f;

	public const float HELL_BOSS_HEALTH_MULTIPLIER = 3f;

	public const float CLAN_MISSION_BOSS_HEALTH_MULTIPLIER = 1.75f;

	private const float RTJRNQPLQRR = 1.25f;

	private const float JERRJRSJOMH = 1.25f;

	[SerializeField]
	private WeaponData weapon;

	public string title;

	public EnemySpot.SMMGLQPTJET type;

	public int level;

	public int damage;

	protected bool QKEJESOJMNN;

	protected bool MNKONLNNNTJ;

	public float lootDropDelay;

	[SerializeField]
	protected LayerMask blocksView;

	[SerializeField]
	protected EnemyIndicator targetIndicator;

	public Affixes affixes;

	[SerializeField]
	private bool randomAimAhead;

	[SerializeField]
	private Vector2 aimAheadRange;

	protected float GOMJOQIPHPP;

	public Func<float, float> ModifyHeal;

	public LayerMask QPKPNKINFOT => default(LayerMask);

	public float RMTMRMEJFFE => 0f;

	public event Action FJGGSKRNLKJ
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

	public virtual void OnPlayerFire()
	{
	}

	public virtual void OnPlayerEnterVision(Player OPQHPOGPSFI)
	{
	}

	public virtual void OnPlayerExitVision(Player OPQHPOGPSFI)
	{
	}

	protected override void Awake()
	{
	}

	public override void InitImprovements()
	{
	}

	private void PSFGSIELORN()
	{
	}

	protected override void Start()
	{
	}

	public void PrepareWeapon()
	{
	}

	protected override void OnDestroy()
	{
	}

	public virtual void Setup(int TESLKRGRTQR, EnemySpot.OOSTRKKLKGI NLPKPQMRSGL)
	{
	}

	public static float GetRiftsBossHealthMultiplier()
	{
		return 0f;
	}

	private void FRPOJISFGRG()
	{
	}

	public void MultiplyMaxHealth(float HMQKOKJOPGG)
	{
	}

	public void HealPercentage(float JSORONLPIRG)
	{
	}

	public bool IsElite()
	{
		return false;
	}

	public bool IsMiniboss(bool TJQLMEMJPRE = true)
	{
		return false;
	}

	public bool IsMinibossAssistant()
	{
		return false;
	}

	public override bool CanBeInstaKilled()
	{
		return false;
	}

	public virtual void SetAttackTarget(Actor ETGMMEJFEOP)
	{
	}

	public string GetTitle()
	{
		return null;
	}

	public WeaponData GetWeaponData()
	{
		return null;
	}

	protected override void Update()
	{
	}

	public bool CanAct()
	{
		return false;
	}

	public void SetTargeted(bool GLJGISGOMGG, bool LTGKEPSKRNM = false)
	{
	}

	public bool IsSkulled()
	{
		return false;
	}

	public virtual bool IsAttacking()
	{
		return false;
	}

	private float TRMHGFNLQLO()
	{
		return 0f;
	}

	public void Announce(float RRRRTQIMKTG)
	{
	}

	public virtual void OnReceiveAnnouncement(Transform EESTGTGKLJG, float IMJQQHHMJEQ)
	{
	}

	public override void LostAllHealth(LQJTRNFQISM EMERMLLSHSL = null)
	{
	}

	protected virtual void SQNGKHQRMIH()
	{
	}

	public void SetCanDropLoot(bool RRPSNPOTQNT)
	{
	}

	public override EFIIOMLOOHE GetTeam()
	{
		return default(EFIIOMLOOHE);
	}

	public override float CalculateDamage(ref LQJTRNFQISM EMERMLLSHSL)
	{
		return 0f;
	}

	public void SetBodyColliderEnabled(bool PONLLSSTOOI)
	{
	}

	protected virtual bool LHTJHJMMHSP(Actor ETGMMEJFEOP, float RRRRTQIMKTG)
	{
		return false;
	}

	protected virtual bool RLGOERHPRRK(Actor ETGMMEJFEOP, float RRRRTQIMKTG)
	{
		return false;
	}

	protected virtual void KRKRKTTPFIQ()
	{
	}

	public virtual bool InCombat()
	{
		return false;
	}

	[CompilerGenerated]
	private void ROPMGGKQJRG()
	{
	}

	[CompilerGenerated]
	private void RJGNTLIQLHR()
	{
	}
}
