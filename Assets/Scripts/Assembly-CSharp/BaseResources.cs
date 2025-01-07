using UnityEngine;

public class BaseResources : MonoBehaviour
{
	public static BaseResources instance;

	public BaseVisualData baseVisuals;

	public BaseItemDatabase itemDatabase;

	public BaseReferences refs;

	private void Awake()
	{
	}
}
