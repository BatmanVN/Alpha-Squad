using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[CreateAssetMenu]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		public class HumanoidMuscle
		{
			[HideInInspector]
			[SerializeField]
			public string name;

			public HumanBodyBones bone;

			public Muscle.Props props;
		}

		public PuppetMaster.State state;

		public PuppetMaster.StateSettings stateSettings;

		public PuppetMaster.Mode mode;

		public float blendTime;

		public bool fixTargetTransforms;

		public int solverIterationCount;

		public bool visualizeTargetPose;

		public float mappingWeight;

		public float pinWeight;

		public float muscleWeight;

		public float muscleSpring;

		public float muscleDamper;

		public float pinPow;

		public float pinDistanceFalloff;

		public bool updateJointAnchors;

		public bool supportTranslationAnimation;

		public bool angularLimits;

		public bool internalCollisions;

		public HumanoidMuscle[] muscles;

		public void ApplyTo(PuppetMaster p)
		{
		}

		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}
	}
}
