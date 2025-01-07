using System;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.Dynamics
{
	public abstract class BehaviourBase : MonoBehaviour
	{
		public delegate void BehaviourDelegate();

		public delegate void HitDelegate(MuscleHit hit);

		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		public struct PuppetEvent
		{
			public string switchToBehaviour;

			public AnimatorEvent[] animations;

			public UnityEvent unityEvent;

			private const string empty = "";

			public bool switchBehaviour => false;

			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		public class AnimatorEvent
		{
			public string animationState;

			public float crossfadeTime;

			public int layer;

			public bool resetNormalizedTime;

			private const string empty = "";

			public void Activate(Animator animator, Animation animation)
			{
			}

			private void Activate(Animator animator)
			{
			}

			private void Activate(Animation animation)
			{
			}
		}

		[HideInInspector]
		public PuppetMaster puppetMaster;

		public BehaviourDelegate OnPreActivate;

		public BehaviourDelegate OnPreInitiate;

		public BehaviourDelegate OnPreFixedUpdate;

		public BehaviourDelegate OnPreUpdate;

		public BehaviourDelegate OnPreLateUpdate;

		public BehaviourDelegate OnPreDeactivate;

		public BehaviourDelegate OnPreFixTransforms;

		public BehaviourDelegate OnPreRead;

		public BehaviourDelegate OnPreWrite;

		public HitDelegate OnPreMuscleHit;

		public CollisionDelegate OnPreMuscleCollision;

		public CollisionDelegate OnPreMuscleCollisionExit;

		public BehaviourDelegate OnHierarchyChanged;

		public BehaviourDelegate OnPostActivate;

		public BehaviourDelegate OnPostInitiate;

		public BehaviourDelegate OnPostFixedUpdate;

		public BehaviourDelegate OnPostUpdate;

		public BehaviourDelegate OnPostLateUpdate;

		public BehaviourDelegate OnPostDeactivate;

		public BehaviourDelegate OnPostDrawGizmos;

		public BehaviourDelegate OnPostFixTransforms;

		public BehaviourDelegate OnPostRead;

		public BehaviourDelegate OnPostWrite;

		public HitDelegate OnPostMuscleHit;

		public CollisionDelegate OnPostMuscleCollision;

		public CollisionDelegate OnPostMuscleCollisionExit;

		[HideInInspector]
		public bool deactivated;

		private bool initiated;

		public bool forceActive { get; protected set; }

		public abstract void OnReactivate();

		public virtual void Resurrect()
		{
		}

		public virtual void Freeze()
		{
		}

		public virtual void Unfreeze()
		{
		}

		public virtual void KillStart()
		{
		}

		public virtual void KillEnd()
		{
		}

		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		protected virtual void OnActivate()
		{
		}

		protected virtual void OnDeactivate()
		{
		}

		protected virtual void OnInitiate()
		{
		}

		protected virtual void OnFixedUpdate()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void OnLateUpdate()
		{
		}

		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		protected virtual void OnFixTransformsBehaviour()
		{
		}

		protected virtual void OnReadBehaviour()
		{
		}

		protected virtual void OnWriteBehaviour()
		{
		}

		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		public void Initiate()
		{
		}

		public void OnFixTransforms()
		{
		}

		public void OnRead()
		{
		}

		public void OnWrite()
		{
		}

		public void OnMuscleHit(MuscleHit hit)
		{
		}

		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		private void OnEnable()
		{
		}

		public void Activate()
		{
		}

		private void OnDisable()
		{
		}

		public void FixedUpdateB()
		{
		}

		public void UpdateB()
		{
		}

		public void LateUpdateB()
		{
		}

		protected virtual void OnDrawGizmos()
		{
		}

		protected void RotateTargetToRootMuscle()
		{
		}

		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return false;
		}
	}
}
