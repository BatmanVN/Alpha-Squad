using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DamagingMovingLine : DamageEntity
{
	[SerializeField]
	private float tickInterval;

	[SerializeField]
	private float duration;

	[SerializeField]
	private float radius;

	[SerializeField]
	private ITKSRPQLPQN damageType;

	public float moveSpeed;

	[NonSerialized]
	private float NSQGRQMGOJS;

	[SerializeField]
	private ParticleSystem particles;

	[SerializeField]
	private ParticleSystem[] particlesScaleEmissionRate;

	[SerializeField]
	private GameObject visual;

	[SerializeField]
	private SoundEffect damagedSound;

	[SerializeField]
	private float effectScaleMultiplier;

	[SerializeField]
	private bool testDrawGizmos;

	[SerializeField]
	private LineRenderer lineRenderer;

	private float SININPQKTPH;

	private bool SMJFTKGRFLJ;

	private Actor FNJLLHKNGOR;

	private Vector3 PGNJKOGGIRL;

	private Vector3 GNFPJSRMGIN;

	private float PRERLFOLGTE;

	private float[] EFNEGGMLOTL;

	private RaycastHit[] HHSNMPPINMQ;

	private void Awake()
	{
	}

	public virtual void Setup(Actor TNKMMOJJPPI, float QHPEGHJEESR, Vector3 JSMLIQPPPQS)
	{
	}

	public virtual void UpdateEndpoint(Vector3 ERINLTKNSFO)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OHQKLRNQFIQ()
	{
	}

	private void MMRTMTRQNTF(bool NRLORILTSJR = false)
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}

	[CompilerGenerated]
	private void KTNJFLJGOFT()
	{
	}
}
