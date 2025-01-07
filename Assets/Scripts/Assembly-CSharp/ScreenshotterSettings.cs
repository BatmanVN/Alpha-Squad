using UnityEngine;

[CreateAssetMenu]
public class ScreenshotterSettings : ScriptableObject
{
	public EnemyMap enemyMap;

	public AnimationTypeMap overrideAnimationsMap;

	public ScreenshotterPresets presetsDataFile;

	public ReferenceItems referenceItems;
}
