using UnityEngine;

namespace RootMotion.Dynamics
{
	public class BehaviourTemplate : BehaviourBase
	{
		public SubBehaviourCOM centerOfMass;

		public LayerMask groundLayers;

		public PuppetEvent onLoseBalance;

		public float loseBalanceAngle;

		protected override void OnInitiate()
		{
		}

		protected override void OnActivate()
		{
		}

		public override void OnReactivate()
		{
		}

		protected override void OnDeactivate()
		{
		}

		protected override void OnFixedUpdate()
		{
		}

		protected override void OnLateUpdate()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}
	}
}
