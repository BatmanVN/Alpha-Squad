using System;
using UnityEngine;

namespace Lean.Touch
{
	public class LeanOpenUrl : MonoBehaviour
	{
		public Vector3 BaseScale;

		public float Size;

		public float PulseInterval;

		public float PulseSize;

		public float Dampening;

		[NonSerialized]
		private float counter;

		public void Open(string url)
		{
		}

		protected virtual void Update()
		{
		}
	}
}
