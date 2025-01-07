using UnityEngine;

public class RangeIndicator : MonoBehaviour
{
	public float range;

	public float width;

	public bool compensateWidth;

	public float rotationSpeed;

	[SerializeField]
	protected int resolution;

	[SerializeField]
	protected LineRenderer lineRenderer;

	private void Start()
	{
	}

	public void SetRange(float MRMOIIEFORK)
	{
	}

	public LineRenderer GetLineRenderer()
	{
		return null;
	}

	protected virtual void Update()
	{
	}

	public virtual void UpdateRenderer()
	{
	}

	public void ClearPoints()
	{
	}

	private void OnValidate()
	{
	}
}
