using UnityEngine;

namespace RootMotion.Dynamics
{
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		private void OnJointBreak()
		{
		}
	}
}
