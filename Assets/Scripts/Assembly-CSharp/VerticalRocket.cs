using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VerticalRocket : WeaponDamageEntity
{
	public float radius;

	public float speed;

	public float switchTime;

	public float flyDownDuration;

	public float weaponDamageMultiplier;

	[NonSerialized]
	public Rigidbody rb;

	[SerializeField]
	private GameObject visual;

	[SerializeField]
	private TrailRenderer[] trails;

	[SerializeField]
	private ParticleSystem particles;

	[SerializeField]
	private GameObject contactPointFX;

	[SerializeField]
	private GameObject explosionFx;

	[SerializeField]
	private SoundEffect explosionSfx;

	private Vector3 REOKGJKOSST;

	private GameObject NTJJQRSTEMM;

	private float GQERPTEJKRO;

	private void Awake()
	{
	}

	public override void Setup(Actor TNKMMOJJPPI, WeaponInfo GLRSKRPPLFQ, Vector3 NFFNFMETPLT, int JFGJNJQHNKK = 0)
	{
	}

	public void RotateToVelocity()
	{
	}

	private void MHROEOIFKMO()
	{
	}

	private void Update()
	{
	}

	private void ENORHNFMLFF()
	{
	}

	public float GetPushPower()
	{
		return 0f;
	}

	public float GetRagdollPushPower()
	{
		return 0f;
	}

	private void OnEnable()
	{
	}

	private new void Destroy(bool NRLORILTSJR = false)
	{
	}

	private void OnCollisionEnter(Collision QFRIINRRGIM)
	{
	}

	private void HOMKJKTHSTL()
	{
	}

	private Vector3 LOEJEEGGKSH()
	{
		return default(Vector3);
	}

	private float EJEFJEJSQMQ()
	{
		return 0f;
	}

	private Vector3 PLMGPNJMGJH()
	{
		return default(Vector3);
	}

	[CompilerGenerated]
	private void SEPOKJPFKTN()
	{
	}
}
