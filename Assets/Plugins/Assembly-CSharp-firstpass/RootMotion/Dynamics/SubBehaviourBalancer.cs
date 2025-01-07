using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		public class Settings
		{
			public float damperForSpring;

			public float maxForceMlp;

			public float IMlp;

			public float velocityF;

			public Vector3 copOffset;

			public float torqueMlp;

			public float maxTorqueMag;
		}

		private Settings settings;

		private Rigidbody[] rigidbodies;

		private Transform[] copPoints;

		private PressureSensor pressureSensor;

		private Rigidbody Ibody;

		private Vector3 I;

		private Quaternion toJointSpace;

		public ConfigurableJoint joint { get; private set; }

		public Vector3 dir { get; private set; }

		public Vector3 dirVel { get; private set; }

		public Vector3 cop { get; private set; }

		public Vector3 com { get; private set; }

		public Vector3 comV { get; private set; }

		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		private void Solve()
		{
		}
	}
}
