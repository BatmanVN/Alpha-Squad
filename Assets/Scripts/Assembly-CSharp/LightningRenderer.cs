using UnityEngine;

public class LightningRenderer : MonoBehaviour
{
	protected enum FORJGOEQLQP
	{
		Fixed = 0,
		Dynamic = 1
	}

	public Vector3 endPoint;

	public float width;

	[SerializeField]
	protected FORJGOEQLQP resolutionMode;

	[SerializeField]
	protected int resolution;

	[SerializeField]
	protected LineRenderer lineRenderer;

	[SerializeField]
	protected bool jitter;

	[SerializeField]
	protected float jitterStrength;

	private void Start()
	{
	}

	public void SetEndpoint(Vector3 ITOPPNRENFH)
	{
	}

	private void Update()
	{
	}

	public LineRenderer GetLineRenderer()
	{
		return null;
	}

	public virtual void UpdateRenderer()
	{
	}

	public void ClearPoints()
	{
	}

	protected int QROREOEORQL()
	{
		return 0;
	}

	private void OnValidate()
	{
	}
}
