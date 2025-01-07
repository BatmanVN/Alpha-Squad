using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleSpriteElement : CircleElement
{
	public float spriteDegrees;

	public Sprite sprite;

	public Color color;

	public GameObject prefab;

	public List<Image> images;

	public override void UpdateLayout()
	{
	}
}
