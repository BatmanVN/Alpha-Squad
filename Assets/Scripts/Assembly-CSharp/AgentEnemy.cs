using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class AgentEnemy : Enemy
{
	public enum RFHHKIQGNIQ
	{
		Standard = 0,
		Long = 1,
		Heavy = 2
	}

	public class NMTOPLPRGTR
	{
		private float FJEHEPFMFGQ;

		private float RSKMETONFRO;

		private Vector3 IIQRNPKGOHE;

		public NMTOPLPRGTR(Vector3 QPNIRNRNJON, float OGFKHSKTHHR)
		{
		}

		public bool PHSTNKNSFQN()
		{
			return false;
		}

		public Vector3 PHRPTQNKPGP(float TRFFKNHKLFH)
		{
			return default(Vector3);
		}

		private float IMMPNRMNFIE()
		{
			return 0f;
		}
	}

	public static readonly Dictionary<RFHHKIQGNIQ, float> moveSpeed;

	[SerializeField]
	public NavMeshAgent agent;

	[SerializeField]
	public Rigidbody rb;

	[SerializeField]
	private float backToPostInterval;

	private float JRRKQJEPJQI;

	[SerializeField]
	public RFHHKIQGNIQ moveType;

	[SerializeField]
	public float acceleration;

	[SerializeField]
	public float walkSpeed;

	[SerializeField]
	public float runSpeed;

	[SerializeField]
	private float pushForceMultiplier;

	public bool DEBUG;

	protected List<NMTOPLPRGTR> MKNLOFQSEFP;

	protected NavMeshPath PKTMKEQHKSJ;

	protected NavMeshPath QGGRJGIFMOP;

	private Vector3 KOJSSOKNTGS;

	private Vector3 HQHIHOITPJR;

	protected float MRNPNKQHSGT;

	protected bool HOTGLKELJTJ;

	private float LRINLEMLLJJ;

	protected override void Awake()
	{
	}

	public override void Teleport(Vector3 PIKMETQIMKF, bool KLLPJSRLGEN = false)
	{
	}

	protected override void Update()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	public void MultiplySpeed(float HMQKOKJOPGG)
	{
	}

	protected virtual void ILNIRROTMNN()
	{
	}

	public void SetDestination(Vector3 PIKMETQIMKF, bool SOLRLPJRKGG = true)
	{
	}

	public bool IsCurrentDestinationReachable()
	{
		return false;
	}

	public bool IsDestinationReachable(Vector3 PIKMETQIMKF)
	{
		return false;
	}

	public bool IsCurrentDestinationReached()
	{
		return false;
	}

	public override float GetLastMoveTime()
	{
		return 0f;
	}

	public void TurnTo(Transform NJLTOMFTSHK, float JPKGQSMKSTF = 0.25f)
	{
	}

	public void TurnTo(Vector3 ETRKSFJPFHS, float JPKGQSMKSTF = 0.25f)
	{
	}

	private void ITMNQGORTNJ(Vector3 GLGRLNQLHJL, float JPKGQSMKSTF = 0.25f)
	{
	}

	public bool IsLookingAt(Transform NJLTOMFTSHK, float TIKKOOIRKRH = 0.9999f)
	{
		return false;
	}

	public bool IsLookingAt(Vector3 FHQPKFMENGQ, float TIKKOOIRKRH = 0.9999f)
	{
		return false;
	}

	protected bool LKQQSTQTOQR(Actor ETGMMEJFEOP, float RRRRTQIMKTG, Vector3 NHLNKMPPTKR)
	{
		return false;
	}

	protected bool GRGKLTPOOIP(Vector3 EESTGTGKLJG, Vector3 NJLTOMFTSHK, float RRRRTQIMKTG)
	{
		return false;
	}

	protected void GKKOSOOGRNN()
	{
	}

	public override void LostAllHealth(LQJTRNFQISM EMERMLLSHSL = null)
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

	public override Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public override bool Hit(LQJTRNFQISM EMERMLLSHSL)
	{
		return false;
	}

	public override void Push(LQJTRNFQISM EMERMLLSHSL)
	{
	}

	protected virtual void AddPush(LQJTRNFQISM EMERMLLSHSL)
	{
	}

	public virtual void AddPush(NMTOPLPRGTR MFRTHMTGLGI)
	{
	}

	[CompilerGenerated]
	internal static float LKOPJOSITTM()
	{
		return 0f;
	}
}
