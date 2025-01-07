using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class BasePlayer : Actor
{
	public static readonly int INTERACT;

	[SerializeField]
	private Transform moveIndicator;

	[SerializeField]
	private RuntimeAnimatorController animController;

	public float speed;

	public Vector2 input;

	public bool inputActive;

	public MovementController movementController;

	public Transform visual;

	public float rotationSpeed;

	public bool forcedMovement;

	private Agent EITKISQOFNO;

	private float EGRRJEPEQOF;

	public List<Task> loadingTasks;

	private List<BaseInteractable> HEQRLNMTNLP;

	private float ILLHLNPFESP;

	protected override void Awake()
	{
	}

	private void JTRKOEQQIGQ()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void NIRKGPRNTGH(int SLIEEELQMQS)
	{
	}

	private void JMKPIKQHQLG(bool LKKOESPTGSK)
	{
	}

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	private void OONOSGJKNPI()
	{
	}

	private void KOPKRISOOIE()
	{
	}

	private void RNNLISRMHFJ()
	{
	}

	public void PlayInteract(Transform ETGMMEJFEOP)
	{
	}

	private void NQTLQQGFHPP()
	{
	}

	private float KNLIJHMMJSK()
	{
		return 0f;
	}

	public GameObject GetMoveIndicator()
	{
		return null;
	}

	private void PMKTQRHNGQQ()
	{
	}

	private void GFRFMEFNPOS()
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

	public void RefreshMoveSpeed()
	{
	}

	public override bool IsGrounded()
	{
		return false;
	}

	public bool IsTryingToMove()
	{
		return false;
	}

	public override Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public override Vector3 GetForwardDir()
	{
		return default(Vector3);
	}

	public override void Teleport(Vector3 PIKMETQIMKF, bool KLLPJSRLGEN = false)
	{
	}

	private bool GRGHNKJIGSN(Actor NIHPIGRSJMO)
	{
		return false;
	}
}
