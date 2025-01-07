using System.Collections.Generic;
using UnityEngine;

namespace KinematicCharacterController
{
	public class KinematicCharacterSystem : MonoBehaviour
	{
		private static KinematicCharacterSystem _instance;

		public static List<KinematicCharacterMotor> CharacterMotors;

		public static List<PhysicsMover> PhysicsMovers;

		private static float _lastCustomInterpolationStartTime;

		private static float _lastCustomInterpolationDeltaTime;

		public static KCCSettings Settings;

		public static void EnsureCreation()
		{
		}

		public static KinematicCharacterSystem GetInstance()
		{
			return null;
		}

		public static void SetCharacterMotorsCapacity(int capacity)
		{
		}

		public static void RegisterCharacterMotor(KinematicCharacterMotor motor)
		{
		}

		public static void UnregisterCharacterMotor(KinematicCharacterMotor motor)
		{
		}

		public static void SetPhysicsMoversCapacity(int capacity)
		{
		}

		public static void RegisterPhysicsMover(PhysicsMover mover)
		{
		}

		public static void UnregisterPhysicsMover(PhysicsMover mover)
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		public static void PreSimulationInterpolationUpdate(float deltaTime)
		{
		}

		public static void Simulate(float deltaTime, List<KinematicCharacterMotor> motors, List<PhysicsMover> movers)
		{
		}

		public static void PostSimulationInterpolationUpdate(float deltaTime)
		{
		}

		private static void CustomInterpolationUpdate()
		{
		}
	}
}
