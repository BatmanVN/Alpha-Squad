using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAgent : Enemy
{
	protected const float RSHQJTNRGLP = 1f;

	protected const float JSJHNGLJQQS = 0.2f;

	[SerializeField]
	public NavMeshAgent agent;

	protected float ONQOLTKHGJE;

	public event Action LSSJIOORFST
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

	protected override void Update()
	{
	}

	protected virtual void RJPLEOMKRMH()
	{
	}

	public override void Teleport(Vector3 PIKMETQIMKF, bool KLLPJSRLGEN = false)
	{
	}

	public void SetDestination(Vector3 PIKMETQIMKF)
	{
	}

	public override void LostAllHealth(LQJTRNFQISM EMERMLLSHSL = null)
	{
	}

	public void ResetForReuse()
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
}
