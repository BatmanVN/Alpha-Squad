using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DamagingZoneCollider : DamageEntity
{
	[SerializeField]
	private float tickInterval;

	[SerializeField]
	private float firstTickDelay;

	[SerializeField]
	private int totalTicks;

	[SerializeField]
	private float scale;

	[SerializeField]
	private float scaleDuration;

	[SerializeField]
	private ITKSRPQLPQN damageType;

	[NonSerialized]
	private float NSQGRQMGOJS;

	[SerializeField]
	private WeaponDamagingZone.ModEntry[] customMods;

	[SerializeField]
	private ParticleSystem particles;

	[SerializeField]
	private ParticleSystem[] particlesScaleEmissionRate;

	[SerializeField]
	private GameObject visual;

	[SerializeField]
	private Transform scaleTransform;

	[SerializeField]
	private float destroyDelay;

	[SerializeField]
	private SoundEffect damagedSound;

	[SerializeField]
	private SoundEffect indicatorSound;

	[SerializeField]
	private SoundEffect firstTickSound;

	[SerializeField]
	private float effectScaleMultiplier;

	[SerializeField]
	private bool testDrawGizmos;

	[NonSerialized]
	public EFIIOMLOOHE teamFallback;

	private List<Actor> RQFRLHIPITG;

	private float EKFSSTEMLFQ;

	private int FRRNRSOHOKO;

	private bool SMJFTKGRFLJ;

	private Actor FNJLLHKNGOR;

	private float LTPQMJKHLQM;

	private float RGMRTELMHMJ;

	private float[] EFNEGGMLOTL;

	private float LQPEKMKGJFR => 0f;

	private float TGIKKJQPJPT => 0f;

	private void Awake()
	{
	}

	public virtual void Setup(Actor TNKMMOJJPPI, float QHPEGHJEESR, Vector3 JSMLIQPPPQS)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OHQKLRNQFIQ()
	{
	}

	public void SetDuration(float TJOORNQEGLK)
	{
	}

	private void MMRTMTRQNTF(bool NRLORILTSJR = false)
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}

	public void SetScale(float GIMOOMNTEMJ)
	{
	}

	public int GetTotalTickCount()
	{
		return 0;
	}

	private float JGEIQTPELEG()
	{
		return 0f;
	}

	private void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	private void OnTriggerExit(Collider FKQLEGQSLHF)
	{
	}

	[CompilerGenerated]
	private void EFQGEFMERGF()
	{
	}
}
