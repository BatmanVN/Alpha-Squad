using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MersenneTwister;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class VisualController : MonoBehaviour
{
	public enum GSSKEEQOMII
	{
		TEST_ELEMENT = 0,
		WallLarge = 1,
		Gate = 2,
		SmallTree_00 = 3,
		SmallTree_01 = 4,
		TallTree = 5,
		Stairs = 6,
		StairsPlatform = 7,
		Lamp = 8,
		Bench = 9,
		Cube1x1 = 10,
		Cube1x2 = 11,
		ShortCube1x1 = 12,
		ShortCube1x2 = 13,
		ShortCube2x2 = 14,
		StairRailling_00 = 15,
		StairRailling_01 = 16,
		StairRaillingCorner = 17,
		SidePropBlock_00a = 18,
		SidePropBlock_01a = 19,
		SidePropBlock_02a = 20,
		SidePropBlock_03a = 21,
		SidePropBlock_00b = 22,
		SidePropBlock_01b = 23,
		SidePropBlock_02b = 24,
		SidePropBlock_03b = 25,
		Side_SmallTree_00 = 26,
		Side_SmallTree_01 = 27,
		Side_TallTree = 28,
		StoneColumn = 29,
		StoneArc = 30,
		GroundProp = 31,
		Background_Wall_Top = 37,
		Background_Wall = 38,
		SideLongObject_a = 39,
		SideLongObject_b = 40,
		WallMedium = 41,
		WallSmall = 42,
		Wall_Corner_00 = 43,
		Wall_Angle_15 = 44,
		Wall_Angle_30 = 45,
		Wall_Angle_45 = 46,
		Wall_Angle_60 = 47,
		Stairs_Corner_00 = 48,
		Stairs_Corner_01 = 49,
		Stairs_Platform_Slice = 50,
		Stairs_Platform_Bridge = 51,
		Ground_Cutout_Square = 52,
		Ground_Cutout_Separator = 53,
		WideArc = 54,
		StairRailing_Scalable = 55,
		WideColumn = 56,
		SniperTower = 57,
		MaskSquare_Scalable = 58,
		SniperTowerHigh = 59,
		TurretTower = 60,
		TurretTowerHigh = 61
	}

	public enum MPMMIGIJJIN
	{
		Default = 0,
		None = 1,
		Stone = 2,
		Foliage = 3,
		Metal = 4,
		Wood = 5
	}

	[CompilerGenerated]
	private sealed class GNHQJPQMIIF
	{
		public VisualController _003C_003E4__this;

		public List<GameObject> replacedObjects;
	}

	[CompilerGenerated]
	private sealed class EPKSJSMMRTP
	{
		public Material mat;

		internal bool _003CApplyWorldVisual_003Eb__4(WorldVariation.MRFQMKTKOJJ x)
		{
			return false;
		}
	}

	[SerializeField]
	private Material groundMaterial;

	[SerializeField]
	private Material maskableGroundMaterial;

	[SerializeField]
	private Material outOfBoundsGroundMaterial;

	[SerializeField]
	private Material borderMaterial;

	[SerializeField]
	private AssetReferenceT<Material> groundReference;

	[SerializeField]
	private AssetReferenceT<Material> groundReferenceNonMaskable;

	[SerializeField]
	private AssetReferenceT<Material> outOfBoundsGroundReference;

	[SerializeField]
	private AssetReferenceT<Material> borderMaterialReference;

	[SerializeField]
	private CableGenerator cableGenerator;

	public MTRandom worldRandomizer;

	private Dictionary<string, Material> FJNOQEJHRKK;

	private WorldData TSRPFHOJKSG;

	private GameObject EPSKSSGFJMI;

	public event Action<WorldData> QFFEPRTMFRS
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public Material GetOutOfBoundsGroundMaterial()
	{
		return null;
	}

	public WorldData GetCurrentVisual()
	{
		return null;
	}

	public WorldVariation GetCurrentVariation()
	{
		return null;
	}

	private void Update()
	{
	}

	public Task ApplyWorldVisual(WorldData MTLGKNIHTMR, WorldVariation OQPGEQSKOSI = null)
	{
		return null;
	}

	private bool QOSLPNGKOOT(GSSKEEQOMII EOOEIROQJOE)
	{
		return false;
	}

	public void LevelController_OnLevelLoaded()
	{
	}

	public void DebugNextVariation()
	{
	}

	public void DebugPreviousVariation()
	{
	}

	public void DebugNextVisual()
	{
	}

	public void DebugPreviousVisual()
	{
	}

	public Tuple<Color, Color> GetParticleColorsForCurrentWorld(MPMMIGIJJIN OJTGHRGORLS)
	{
		return null;
	}

	[CompilerGenerated]
	internal static Task NOMIPJSMJEL(Material EGMKGFOERSE, AssetReferenceT<Material> METLSMHNQGQ)
	{
		return null;
	}

	[CompilerGenerated]
	internal static Task PJHOGKNTTEF(WorldData MTLGKNIHTMR, WorldReplaceable OEESQHTSGJL, GSSKEEQOMII OGFKHSKTHHR, List<GameObject> LRKLIOIKLOJ)
	{
		return null;
	}
}
