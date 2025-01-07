using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			Colliders = 0,
			Joints = 1
		}

		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[HideInInspector]
		public Collider selectedCollider;

		[HideInInspector]
		public bool symmetry;

		[HideInInspector]
		public Mode mode;

		private void OpenUserManual()
		{
		}

		private void OpenScriptReference()
		{
		}

		private void OpenTutorial()
		{
		}
	}
}
