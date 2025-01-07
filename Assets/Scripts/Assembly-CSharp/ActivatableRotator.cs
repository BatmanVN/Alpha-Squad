using UnityEngine;

public class ActivatableRotator : Activatable
{
	[SerializeField]
	private Vector3 startingRotation;

	[SerializeField]
	private Vector3 goalRotation;

	private void Awake()
	{
	}

	private void OnValidate()
	{
	}

	public override void SetActivatedAction(bool OFNQFKQQKQJ)
	{
	}
}
