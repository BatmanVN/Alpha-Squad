namespace KinematicCharacterController
{
	public enum MovementSweepState
	{
		Initial = 0,
		AfterFirstHit = 1,
		FoundBlockingCrease = 2,
		FoundBlockingCorner = 3
	}
}
