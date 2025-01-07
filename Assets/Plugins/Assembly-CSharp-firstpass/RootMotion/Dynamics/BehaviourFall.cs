using System.Collections;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public class BehaviourFall : BehaviourBase
	{
		public string stateName;

		public float transitionDuration;

		public int layer;

		public float fixedTime;

		public LayerMask raycastLayers;

		public string blendParameter;

		public float writheHeight;

		public float writheYVelocity;

		public float blendSpeed;

		public float blendMappingSpeed;

		public bool canEnd;

		public float minTime;

		public float maxEndVelocity;

		public PuppetEvent onEnd;

		private float timer;

		private bool endTriggered;

		private void OpenUserManual()
		{
		}

		private void OpenScriptReference()
		{
		}

		protected override void OnActivate()
		{
		}

		protected override void OnDeactivate()
		{
		}

		public override void OnReactivate()
		{
		}

		private IEnumerator SmoothActivate()
		{
			return null;
		}

		protected override void OnFixedUpdate()
		{
		}

		protected override void OnLateUpdate()
		{
		}

		public override void Resurrect()
		{
		}

		private float GetBlendTarget(float groundHeight)
		{
			return 0f;
		}

		private float GetGroundHeight()
		{
			return 0f;
		}
	}
}
