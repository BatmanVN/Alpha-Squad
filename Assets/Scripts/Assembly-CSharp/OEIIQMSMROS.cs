using UnityEngine;

public interface OEIIQMSMROS
{
	RectTransform GetLevelTransform();

	GameObject GetGameObject();

	int GetLevel();

	void UpdateToClaimable();

	bool IsActive();

	void Deactivate();

	void Activate();
}
