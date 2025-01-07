using UnityEngine;

namespace RootMotion.Dynamics
{
	public struct MuscleHit
	{
		public int muscleIndex;

		public float unPin;

		public Vector3 force;

		public Vector3 position;

		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
			this.muscleIndex = 0;
			this.unPin = 0f;
			this.force = default(Vector3);
			this.position = default(Vector3);
		}
	}
}
