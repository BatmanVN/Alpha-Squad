using System;
using UnityEngine;
using UnityEngine.AI;

public class SpecialMeleeAdvance : SpecialActiveBase
{
	[Serializable]
	public struct DamageEntry
	{
		public float time;

		public Transform fx;
	}

	public float animationSpeedMultiplier;

	public float moveSpeed;

	public AnimationCurve speedCurve;

	public DamageEntry[] damageTiming;

	public float damageMultiplier;

	public float damageRadius;

	public float rotationSpeed;

	public Vector3 localDamagePosition;

	public float pushForce;

	public float ragdollPushForce;

	private Rigidbody ISKPFKOLSRK;

	private NavMeshPath LKKRLMGGEQS;

	private float GFTETRNTSJG;

	protected override void Awake()
	{
	}

	protected override void ITNGQTQIRME()
	{
	}

	public override void SpecialUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void MRMKPEMTESP()
	{
	}
}
