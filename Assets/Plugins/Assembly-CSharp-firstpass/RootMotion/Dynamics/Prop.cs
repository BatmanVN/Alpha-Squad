using UnityEngine;

namespace RootMotion.Dynamics
{
	public abstract class Prop : MonoBehaviour
	{
		public int propType;

		public ConfigurableJoint muscle;

		public Muscle.Props muscleProps;

		public bool forceLayers;

		public ConfigurableJoint additionalPin;

		public Transform additionalPinTarget;

		public float additionalPinWeight;

		private ConfigurableJointMotion xMotion;

		private ConfigurableJointMotion yMotion;

		private ConfigurableJointMotion zMotion;

		private ConfigurableJointMotion angularXMotion;

		private ConfigurableJointMotion angularYMotion;

		private ConfigurableJointMotion angularZMotion;

		private Collider[] colliders;

		public bool isPickedUp => false;

		public PropRoot propRoot { get; private set; }

		public void PickUp(PropRoot propRoot)
		{
		}

		public void Drop()
		{
		}

		public void StartPickedUp(PropRoot propRoot)
		{
		}

		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		protected virtual void OnDrop()
		{
		}

		protected virtual void OnStart()
		{
		}

		private void Start()
		{
		}

		private void ReleaseJoint()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
