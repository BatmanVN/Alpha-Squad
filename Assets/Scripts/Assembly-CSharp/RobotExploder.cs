using System;
using System.Collections.Generic;
using UnityEngine;

public class RobotExploder : MonoBehaviour
{
	[Serializable]
	public struct Parts
	{
		public RigidbodyCollection collection;

		public Vector2Int amount;

		public Vector2 scale;
	}

	public bool pooled;

	private const float RSHKTKSGQIE = 0.25f;

	private Actor NIHPIGRSJMO;

	[SerializeField]
	protected GameObject explosionFx;

	[SerializeField]
	protected ParticleSystem explosionPartFx;

	[SerializeField]
	protected float explosionPartChance;

	[SerializeField]
	protected float verticalForce;

	[SerializeField]
	protected float horizontalForce;

	[SerializeField]
	protected Vector2 velocityMultiplier;

	[SerializeField]
	protected bool cameraShake;

	public Collider spawnArea;

	public List<Parts> parts;

	private List<GameObject> FIRKNTJQOLI;

	protected void Start()
	{
	}

	protected virtual void EPRGRFJFINS(LQJTRNFQISM EMERMLLSHSL, Actor NIHPIGRSJMO)
	{
	}

	protected void HOMKJKTHSTL(Vector3 PFGONKFEGKT)
	{
	}

	public List<GameObject> GetExplodedParts()
	{
		return null;
	}

	protected virtual void PIMJMQQRORP()
	{
	}
}
