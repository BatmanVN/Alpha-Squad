using UnityEngine;

namespace KinematicCharacterController
{
	[CreateAssetMenu]
	public class KCCSettings : ScriptableObject
	{
		public bool AutoSimulation;

		public bool Interpolate;

		public bool SyncInterpolatedPhysicsTransforms;
	}
}
