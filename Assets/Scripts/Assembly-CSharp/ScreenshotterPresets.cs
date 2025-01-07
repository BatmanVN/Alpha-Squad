using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class ScreenshotterPresets : ScriptableObject
{
	[Serializable]
	public class PresetData
	{
		public string presetName;

		public float animationFrame;

		public string animationClip;

		public float aimingAngle;

		public float speed;

		public Quaternion sunRotation;

		public Color backgroundColor;

		public Quaternion headRotation;

		public Quaternion originalRotation;

		public Vector3 cameraOffset;

		public Quaternion cameraRotation;

		public float cameraDistance;

		public float fov;

		public bool setHeightAuto;
	}

	[CompilerGenerated]
	private sealed class PSFTENMMGHK
	{
		public string presetName;

		internal bool _003CRemovePreset_003Eb__0(PresetData p)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class GTLEPJLKETL
	{
		public string presetName;

		internal bool _003CGetPresetByName_003Eb__0(PresetData p)
		{
			return false;
		}
	}

	public List<PresetData> presets;

	public void GQREKLTHNSS(PresetData MLKHJOPTJFP)
	{
	}

	public void LMNHMTTGTGQ(string JJLGRLKTPGP)
	{
	}

	public PresetData TJSLHSTTGRJ(string JJLGRLKTPGP)
	{
		return null;
	}
}
