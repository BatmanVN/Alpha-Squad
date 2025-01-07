using System;
using UnityEngine;

[Serializable]
public struct CamFollowSettings
{
	public Vector2 deadZoneSize;

	public Vector2 horizontalLimit;

	public Vector2 verticalLimit;

	public Vector3 camOffset;

	public bool overrideTransitionDuration;

	public float transitionDuration;

	public bool useRotation;

	public Vector3 camRotation;

	public bool updateFov;

	public float fov;
}
