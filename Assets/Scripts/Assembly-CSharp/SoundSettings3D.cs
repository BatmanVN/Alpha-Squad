using UnityEngine;

[CreateAssetMenu]
public class SoundSettings3D : ScriptableObject
{
	public float dopplerLevel;

	public int spread;

	public float blend;

	public AudioRolloffMode volumeRolloff;

	public float minDistance;

	public float maxDistance;
}
