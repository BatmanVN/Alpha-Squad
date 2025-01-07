using System;
using System.Collections.Generic;

namespace RootMotion.Dynamics
{
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		public class PuppetUpdateLimit
		{
			public int puppetsPerFrame;

			private int index;

			public void Step(int puppetCount)
			{
			}

			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return false;
			}
		}

		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		public PuppetUpdateLimit freeUpdateLimit;

		public PuppetUpdateLimit fixedUpdateLimit;

		public bool collisionStayMessages;

		public bool collisionExitMessages;

		public float activePuppetCollisionThresholdMlp;

		private List<PuppetMaster> _puppets;

		public int currentlyActivePuppets { get; private set; }

		public int currentlyKinematicPuppets { get; private set; }

		public int currentlyDisabledPuppets { get; private set; }

		public List<PuppetMaster> puppets => null;

		public void Register(PuppetMaster puppetMaster)
		{
		}

		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return false;
		}

		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return false;
		}

		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return false;
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
