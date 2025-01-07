using UnityEngine;

public class CloudPrefabReferences : MonoBehaviour
{
	public UpdateVersionPopup updateVersionPopup;

	public DataConflictPopup accountSwitchPopupPrefab;

	public DataConflictPopup dataConflictPopupPrefab;

	public static CloudPrefabReferences Instance;

	private void Awake()
	{
	}
}
