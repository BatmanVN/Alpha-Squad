using System;
using System.Collections.Generic;
using UnityEngine;

public class BulletHoleBuffer : MonoBehaviour
{
	[Serializable]
	public struct BulletHoleRef
	{
		public GameObject original;

		public GameObject ingame;
	}

	public int maxBulletHoles;

	public List<BulletHoleRef> reference;

	public GameObject GetBulletHoleInstance(GameObject GRMOIOOPGSL)
	{
		return null;
	}
}
