using System.Collections.Generic;
using UnityEngine;

public class CircularLayout : MonoBehaviour
{
	public float layoutDegrees;

	public List<int> weights;

	public List<CircleElement> elements;

	public CircleElement elementPrefab;

	public bool liveUpdate;

	private void OnValidate()
	{
	}

	public void UpdateElementCount()
	{
	}

	public void UpdateLayout()
	{
	}
}
