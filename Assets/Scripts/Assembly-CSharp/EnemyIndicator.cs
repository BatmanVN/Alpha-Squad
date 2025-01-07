using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIndicator : MonoBehaviour
{
	[Serializable]
	private struct Entry
	{
		public MeshRenderer meshRenderer;

		public float rotationSpeed;
	}

	[SerializeField]
	private Material gray;

	[SerializeField]
	private Material targeted;

	[SerializeField]
	private Transform animTransform;

	[SerializeField]
	private List<Entry> entries;

	private bool SKFFGTKPTJK;

	public void SetState(bool OSJPJOTOKEH)
	{
	}

	private void LateUpdate()
	{
	}
}
