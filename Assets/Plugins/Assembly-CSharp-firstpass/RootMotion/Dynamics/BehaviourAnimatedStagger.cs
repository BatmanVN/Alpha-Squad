using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		public struct FallParams
		{
			public float startPinWeightMlp;

			public float startMuscleWeightMlp;

			public float losePinSpeed;
		}

		[Serializable]
		public struct FallParamsGroup
		{
			public Muscle.Group[] groups;

			public FallParams fallParams;
		}

		public LayerMask groundLayers;

		public float animationBlendSpeed;

		public float animationMag;

		public float momentumMag;

		public float unbalancedMuscleWeightMlp;

		public float unbalancedMuscleDamperAdd;

		public bool dropProps;

		public float maxGetUpVelocity;

		public float minHipHeight;

		public SubBehaviourCOM centerOfMass;

		public FallParams defaults;

		public FallParamsGroup[] groupOverrides;

		public PuppetEvent onUngrounded;

		public PuppetEvent onFallOver;

		public PuppetEvent onRest;

		[HideInInspector]
		public Vector3 moveVector;

		[HideInInspector]
		public bool isGrounded;

		[HideInInspector]
		public Vector3 forward;

		protected override void OnInitiate()
		{
		}

		protected override void OnActivate()
		{
		}

		public override void OnReactivate()
		{
		}

		private IEnumerator LoseBalance()
		{
			return null;
		}

		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}
	}
}
