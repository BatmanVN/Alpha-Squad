using UnityEngine;

namespace RootMotion.Dynamics
{
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[HideInInspector]
		[SerializeField]
		public int muscleIndex;

		private const string onMuscleHit = "OnMuscleHit";

		private const string onMuscleCollision = "OnMuscleCollision";

		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		private MuscleCollisionBroadcaster otherBroadcaster;

		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionStay(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}
	}
}
