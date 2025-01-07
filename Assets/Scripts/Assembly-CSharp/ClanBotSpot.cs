using UnityEngine;
using UnityEngine.Events;

public class ClanBotSpot : MonoBehaviour
{
	public ClanBotData.SENLJTHJOHI animType;

	public ClanBotData.NRKITGRESJJ anim;

	public bool disableColliders;

	public GameObject colliderParent;

	public GameObject disableIfThisActive;

	public UnityEvent onSpawn;

	public void CheckActivation()
	{
	}

	public bool CanBeActive()
	{
		return false;
	}

	public void CreateBotSpotGrid()
	{
	}

	public void OnSpawn()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
