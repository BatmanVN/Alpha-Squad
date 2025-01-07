using UnityEngine;

public class SpecialSummon : SpecialActiveBase
{
	public int count;

	public float initialSpeed;

	public float distance;

	public Enemy prefab;

	public EnemySpot.OOSTRKKLKGI category;

	public GameObject activateVfx;

	public GameObject spawnVfx;

	public bool spawnAround;

	public float spawnRadius;

	protected float OFKJFSORGOE;

	protected int ETOFHTMGKHK;

	protected Collider[] NHOGEHTEPKE;

	protected Vector3 LIIPOKNKPTR;

	protected override void Awake()
	{
	}

	protected override void MLHRFERJRGK()
	{
	}

	protected virtual Enemy PNEINOKEIPP(Vector3 HSSNSPQEIGR)
	{
		return null;
	}

	public override bool ShouldActivate()
	{
		return false;
	}

	protected virtual bool HOJEITEIRGO(out Vector3 PQNITOOPPOG)
	{
		PQNITOOPPOG = default(Vector3);
		return false;
	}
}
