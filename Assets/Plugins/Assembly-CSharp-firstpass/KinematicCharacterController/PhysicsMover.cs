using System;
using UnityEngine;

namespace KinematicCharacterController
{
	public class PhysicsMover : MonoBehaviour
	{
		[ReadOnly]
		public Rigidbody Rigidbody;

		public bool MoveWithPhysics;

		[NonSerialized]
		public IMoverController MoverController;

		[NonSerialized]
		public Vector3 LatestInterpolationPosition;

		[NonSerialized]
		public Quaternion LatestInterpolationRotation;

		[NonSerialized]
		public Vector3 PositionDeltaFromInterpolation;

		[NonSerialized]
		public Quaternion RotationDeltaFromInterpolation;

		private Vector3 _internalTransientPosition;

		private Quaternion _internalTransientRotation;

		public int IndexInCharacterSystem { get; set; }

		public Vector3 InitialTickPosition { get; set; }

		public Quaternion InitialTickRotation { get; set; }

		public Transform Transform { get; private set; }

		public Vector3 InitialSimulationPosition { get; private set; }

		public Quaternion InitialSimulationRotation { get; private set; }

		public Vector3 TransientPosition
		{
			get
			{
				return default(Vector3);
			}
			private set
			{
			}
		}

		public Quaternion TransientRotation
		{
			get
			{
				return default(Quaternion);
			}
			private set
			{
			}
		}

		private void Reset()
		{
		}

		private void OnValidate()
		{
		}

		public void ValidateData()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		public void SetPosition(Vector3 position)
		{
		}

		public void SetRotation(Quaternion rotation)
		{
		}

		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		public PhysicsMoverState GetState()
		{
			return default(PhysicsMoverState);
		}

		public void ApplyState(PhysicsMoverState state)
		{
		}

		public void VelocityUpdate(float deltaTime)
		{
		}
	}
}
