using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class WorldData : ScriptableObject
{
	public enum JQNPLTQOFMJ
	{
		UNDEFINED = -1,
		CITY = 0,
		FOREST = 1,
		CASINO = 2,
		DIGSITE = 3,
		OFFICE = 4,
		NEONCITY = 5,
		ECOOFFICE = 6,
		TRAINSTATION = 7,
		GUNRANGE = 8,
		ASIANFOREST = 9,
		LABORATORY = 10,
		JUNGLE = 11,
		PORT = 12,
		FACTORY = 13,
		GYM = 14,
		AIRPORT = 15,
		CONSTRUCTION = 16,
		JAMAICA = 17,
		SKIRESORT = 18,
		EGYPTTOMB = 19,
		MEDIEVAL = 20,
		CHINA = 21,
		RIFT_CORRUPTEDFOREST_T1 = 22,
		RIFT_SCIFI = 23,
		RIFT_STEAMPUNK = 24,
		RIFT_FANTASYFOREST = 25,
		HELL = 26,
		RIFT_ROYAL = 27,
		RIFT_CRYSTAL = 28,
		SKOREA = 29,
		USA = 30,
		CM_BR = 31,
		CUSTOM_EVENT = 32,
		CIRCUS = 33,
		RIFT_BRIGHTFUTURECITY = 34
	}

	[Serializable]
	public struct ParticleColors
	{
		public Color color1;

		public Color color2;

		public VisualController.GSSKEEQOMII[] forElements;
	}

	[Serializable]
	public struct WorldElementReplacement
	{
		public VisualController.GSSKEEQOMII element;

		public AssetReferenceT<GameObject> gameObject;
	}

	[Serializable]
	public struct CategoryHitFX
	{
		public VisualController.MPMMIGIJJIN category;

		public GameObject prefab;

		public Color particleColor1;

		public Color particleColor2;
	}

	[CompilerGenerated]
	private sealed class KKHLMRPRNEI
	{
		public VisualController.GSSKEEQOMII el;

		internal bool _003CGetElementForTypeAsync_003Eb__0(WorldElementReplacement wr)
		{
			return false;
		}

		internal bool _003CGetElementForTypeAsync_003Eb__1(WorldElementReplacement wr)
		{
			return false;
		}

		internal bool _003CGetElementForTypeAsync_003Eb__2(WorldElementReplacement wr)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class QKKNRFJFNSM
	{
		public VisualController.MPMMIGIJJIN cat;

		internal bool _003CGetEffectForCategory_003Eb__0(CategoryHitFX e)
		{
			return false;
		}

		internal bool _003CGetEffectForCategory_003Eb__1(CategoryHitFX c)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HLLEKTEPKQP
	{
		public VisualController.MPMMIGIJJIN cat;

		internal bool _003CGetParticleColorPairForCategory_003Eb__0(CategoryHitFX e)
		{
			return false;
		}

		internal bool _003CGetParticleColorPairForCategory_003Eb__1(CategoryHitFX e)
		{
			return false;
		}
	}

	public JQNPLTQOFMJ type;

	public string title_key;

	public Sprite icon;

	public Sprite coverImage;

	public GameObject illustration;

	public List<WorldVariation> variations;

	public Texture2D lightGradient;

	public Color lightenToColor;

	public bool customLightDirection;

	public Vector3 lightDirection;

	public List<WorldElementReplacement> elements;

	public List<WorldElementReplacement> elements1;

	public List<WorldElementReplacement> elements2;

	public List<CategoryHitFX> hitEffects;

	public bool despawnSideObjects;

	public float despawnOffset;

	public AssetReferenceT<Material> groundMaterialData;

	public AssetReferenceT<Material> outOfBoundsGroundData;

	public AssetReferenceT<Material> borderMaterialData;

	public WorldAnimator worldAnimator;

	public bool generateCables;

	public CableGenerator.Settings[] cableSettings;

	public AudioClip musicIdle;

	public string title => null;

	public string UppercaseTitle => null;

	public Task<GameObject> HESOJFLMTFH(VisualController.GSSKEEQOMII KPGROEIJTSP)
	{
		return null;
	}

	public CategoryHitFX EHTHHLSGSHG(VisualController.MPMMIGIJJIN OJTGHRGORLS)
	{
		return default(CategoryHitFX);
	}

	public Tuple<Color, Color> HFLHHGPNJGE(VisualController.MPMMIGIJJIN OJTGHRGORLS)
	{
		return null;
	}

	public void PPQGTFFKIHE()
	{
	}

	public int SMOQOPHMLJH()
	{
		return 0;
	}
}
