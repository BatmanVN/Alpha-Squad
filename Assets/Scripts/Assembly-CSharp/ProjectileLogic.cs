using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ProjectileLogic : WeaponDamageEntity
{
	[CompilerGenerated]
	private sealed class NLIJMGSNSIJ
	{
		public GameObject go;

		internal void _003CDestroy_003Eb__0()
		{
		}
	}

	public Action OnSetup;

	public Action OnCollisionPreDestroy;

	public Action<Collider> OnTriggerPreDestroy;

	[SerializeField]
	private SoundEffect hitSfxOverride;

	[SerializeField]
	private GameObject hitTargetFxOverride;

	[NonSerialized]
	public Rigidbody rb;

	public Collider myCollider;

	protected List<Collider> RGKTRKMKMFE;

	protected HashSet<Actor> SHLJNELOFFT;

	protected Vector3 GLGRLNQLHJL;

	protected Vector3 QQENINJSIOO;

	private LayerMask HKTSKJTRKGR;

	protected float QMOTKOSPIOL;

	protected float OJJSGIMTNNS;

	protected Vector3 KGGENJPEMKR;

	public int ricochetCount;

	public bool hasPierced;

	public bool forked;

	public int ammoIndex;

	private const float GGKFHFMRJJP = 6f;

	private const float GLQNPKITIQH = 1.5f;

	protected bool QEOFRTQRSJI;

	public Vector3 RNSIHFJHQGS => default(Vector3);

	public Vector3 GEFFTRLENKS => default(Vector3);

	public bool SISRFOPMJPM => false;

	protected virtual void Awake()
	{
	}

	protected virtual void Update()
	{
	}

	public override void Setup(Actor TNKMMOJJPPI, WeaponInfo GLRSKRPPLFQ, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = 0)
	{
	}

	protected virtual bool RNLSLTGSRGS()
	{
		return false;
	}

	protected bool QKRLHQGSROM(LQJTRNFQISM EMERMLLSHSL)
	{
		return false;
	}

	protected bool SKRNSOTJGRE(LQJTRNFQISM EMERMLLSHSL)
	{
		return false;
	}

	protected bool TJONLEHEMMO()
	{
		return false;
	}

	public virtual void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	private void FLHTLQOPRHJ(Collider FKQLEGQSLHF)
	{
	}

	protected virtual void QEJLSEMMQSG(TQFOFKOSKRQ IRPOKKFIOIO)
	{
	}

	protected virtual void OnCollisionEnter(Collision QFRIINRRGIM)
	{
	}

	protected virtual bool KMGJNKEREFI(Collision QFRIINRRGIM)
	{
		return false;
	}

	protected virtual void LFJKRISJLGQ(Collision QFRIINRRGIM)
	{
	}

	protected bool MIRMHOLHGJF(Actor HGIHSMNORFF)
	{
		return false;
	}

	protected void PSSJNJJFHKT(Vector3 SLHGEGQHRIK)
	{
	}

	public override Vector3 GetPushForce()
	{
		return default(Vector3);
	}

	public override Vector3 GetRagdollPushForce()
	{
		return default(Vector3);
	}

	protected virtual void OnEnable()
	{
	}

	protected new virtual void Destroy(bool NRLORILTSJR = false)
	{
	}

	private void RROINLQOEML()
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}
}
