using UnityEngine;

public class ClanBaseRoom : MonoBehaviour
{
	public enum JFKMJEPEHOK
	{
		INVALID = -1,
		HALL = 0,
		ARMORY = 1,
		REGISTRY = 2,
		FACTORY = 3,
		TAILORY = 4,
		MISSIONS = 5,
		DONATION = 6,
		GENERAL_SHOP = 7,
		HONOR_SHOP = 8,
		LABORATORY = 9
	}

	[SerializeField]
	private ClanRoomVisual roomVisual;

	[SerializeField]
	private Transform levelUpEffectParent;

	[SerializeField]
	private Transform roomArrowPointPos;

	[SerializeField]
	private Transform roomProgressPointPos;

	private ClanBaseManager TLKOMLRFSMM;

	public JFKMJEPEHOK roomType;

	private Transform FHJIIMLHNHG => null;

	public void Setup()
	{
	}

	public void UpdateRoomVisual()
	{
	}

	public void DebugSetRoomVisual(int TOHTOFEHMHM)
	{
	}

	public Transform GetSpawnPoint()
	{
		return null;
	}

	private void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	private void OnTriggerExit(Collider FKQLEGQSLHF)
	{
	}

	public Transform GetLevelUpEffectParent()
	{
		return null;
	}

	public Transform GetRoomArrowPointPos()
	{
		return null;
	}

	public Transform GetRoomProgressPointPos()
	{
		return null;
	}
}
