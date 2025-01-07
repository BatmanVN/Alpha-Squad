using System;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
	[Serializable]
	public class MaterialDict : SerializableDictionary<WorldData.JQNPLTQOFMJ, MaterialArray>
	{
	}

	[Serializable]
	public struct MaterialArray
	{
		public Material[] array;
	}

	public MaterialDict map;

	private Renderer PKFHHGNHRGI;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void KETMPLEJILK(WorldData RPGTQNGQTSS)
	{
	}
}
