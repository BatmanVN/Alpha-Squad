using UnityEngine;

public class DisableIfReleaseBuild : MonoBehaviour
{
	public const bool DEBUG_ENABLED_IN_RELEASE = false;

	private void Start()
	{
	}

	public static bool IsDebug()
	{
		return false;
	}
}
