using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		public struct Options
		{
			public float weight;

			public bool spine;

			public bool chest;

			public bool hands;

			public bool feet;

			public JointType joints;

			public float jointRange;

			public float colliderLengthOverlap;

			public ColliderType torsoColliders;

			public ColliderType headCollider;

			public ColliderType armColliders;

			public ColliderType handColliders;

			public ColliderType legColliders;

			public ColliderType footColliders;

			public static Options Default => default(Options);
		}

		public bool canBuild;

		public BipedRagdollReferences references;

		public Options options;

		private void OpenUserManual()
		{
		}

		private void OpenScriptReference()
		{
		}

		private void OpenTutorial()
		{
		}

		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		public static bool IsClear(BipedRagdollReferences r)
		{
			return false;
		}

		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}
	}
}
