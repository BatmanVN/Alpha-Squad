using UnityEngine;

public abstract class CircleElement : MonoBehaviour
{
	public float widthDegrees;

	private void OnValidate()
	{
	}

	public Vector2 GetDegreeRange()
	{
		return default(Vector2);
	}

	public virtual void SetWidth(float PNFTNKPRRQO)
	{
	}

	public abstract void UpdateLayout();
}
