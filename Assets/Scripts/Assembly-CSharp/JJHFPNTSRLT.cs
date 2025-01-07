using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.UI;

public static class JJHFPNTSRLT
{
	public enum NKSMTQENIRK
	{
		NONE = 0,
		ALL = 1,
		MELEE = 2,
		RANGED = 3,
		EXPLOSIVE = 4
	}

	[Serializable]
	public struct CustomChestPrefab
	{
		public ChestController.MFRETPOLGOE q;

		public GameObject prefab;

		public GameObject prefabSparks;
	}

	[Serializable]
	public struct ChestQualitySprite
	{
		public ChestController.MFRETPOLGOE quality;

		public Sprite sprite;
	}

	[Serializable]
	public struct ChestPurchaseData
	{
		public ChestController.MFRETPOLGOE id;

		public int price;
	}

	[Serializable]
	public struct ChestQualityGameObject
	{
		public ChestController.MFRETPOLGOE quality;

		public GameObject gameObject;
	}

	[Serializable]
	public struct ChestQualityNumber
	{
		public ChestController.MFRETPOLGOE quality;

		public int number;
	}

	[Serializable]
	public struct AttributeSprite
	{
		public ItemWeapon.RGPEMGEPIJF bonusType;

		public Sprite sprite;
	}

	[Serializable]
	public struct RarityGameObject
	{
		public PQRIQGIOGQT rarity;

		public GameObject gameObject;
	}

	[Serializable]
	public struct NumberGameObject
	{
		public int num;

		public GameObject gameObject;
	}

	[Serializable]
	public struct RarityWeaponID
	{
		public PQRIQGIOGQT rarity;

		public JPHMLSJQLNL id;
	}

	[Serializable]
	public struct RarityColor
	{
		public PQRIQGIOGQT rarity;

		public Color color;
	}

	[Serializable]
	public struct RaritySprite
	{
		public PQRIQGIOGQT rarity;

		public Sprite sprite;
	}

	[Serializable]
	public struct RarityNumber
	{
		public PQRIQGIOGQT rarity;

		public int amount;
	}

	[Serializable]
	public struct ResistTypeSprite
	{
		public NKSMTQENIRK resistType;

		public Sprite sprite;
	}

	[Serializable]
	public struct GearCategorySprite
	{
		public KNSKIMFQMTH category;

		public Sprite sprite;
	}

	[Serializable]
	public struct GearCategoryGameObject
	{
		public KNSKIMFQMTH category;

		public GameObject gameObject;
	}

	[Serializable]
	public struct GearBonusSprite
	{
		public MNJMPEKHPTO id;

		public Sprite sprite;
	}

	[Serializable]
	public struct GearIdCatPair
	{
		public MNJMPEKHPTO id;

		public KNSKIMFQMTH category;
	}

	[Serializable]
	public struct QualityColor
	{
		public ChestController.MFRETPOLGOE quality;

		public Color color;
	}

	[Serializable]
	public struct QualitySprite
	{
		public ChestController.MFRETPOLGOE quality;

		public Sprite sprite;
	}

	[Serializable]
	public struct RaidDifficultyGameObject
	{
		public RaidController.FKKMKISLFKI type;

		public GameObject gameObject;
	}

	[Serializable]
	public struct RaidDifficultySprite
	{
		public RaidController.FKKMKISLFKI type;

		public Sprite sprite;
	}

	[Serializable]
	public struct RaidDifficultyColor
	{
		public RaidController.FKKMKISLFKI type;

		public Color color1;

		public Color color2;
	}

	[Serializable]
	public struct WeaponCategoryWithCount
	{
		public WeaponData.OHHQFFINRQH category;

		public int count;
	}

	[Serializable]
	public struct WeaponCategoryGameObject
	{
		public WeaponData.OHHQFFINRQH category;

		public GameObject gameObject;
	}

	[Serializable]
	public struct EnhancementSprite
	{
		public RTMJNJJLEGL id;

		public Sprite sprite;
	}

	[Serializable]
	public struct LevelOffset
	{
		public int lvl;

		public int offset;
	}

	[Serializable]
	public struct EnemySprite
	{
		public EnemySpot.SMMGLQPTJET type;

		public Sprite sprite;
	}

	[Serializable]
	public struct MissionBoostSprite
	{
		public UIRoomLaboratory.RGLHHOFPFMK boost;

		public Sprite sprite;
	}

	[Serializable]
	public struct EnemyVector3
	{
		public EnemySpot.SMMGLQPTJET type;

		public Vector3 vector;
	}

	[Serializable]
	public struct RandomizedValue
	{
		public float[] v;

		public float OLELSOTMLFF(float LSEHENKQSRO)
		{
			return 0f;
		}

		public float RKQINGQKGLT()
		{
			return 0f;
		}

		public float RENTKOGKOGP()
		{
			return 0f;
		}

		public float EPLGMEIRGOR()
		{
			return 0f;
		}

		public static RandomizedValue GILJLILRGTS(string QPNIRNRNJON)
		{
			return default(RandomizedValue);
		}
	}

	[Serializable]
	public struct MinMaxValueFloat
	{
		public float min;

		public float max;

		public float EJTNFHTLPTG()
		{
			return 0f;
		}

		public float EJTNFHTLPTG(System.Random FQNLGPSKNRM)
		{
			return 0f;
		}

		public bool ESNNRFRTKEF()
		{
			return false;
		}

		public float PEHPITPEFHG(float OGFKHSKTHHR)
		{
			return 0f;
		}

		public string PGNSQTKGSEM(string TIKKOOIRKRH = "0.0")
		{
			return null;
		}

		public string GHNISHPPFLN()
		{
			return null;
		}
	}

	[Serializable]
	public struct MinMaxValueInt
	{
		public int min;

		public int max;

		public int EJTNFHTLPTG()
		{
			return 0;
		}

		public int EJTNFHTLPTG(System.Random FQNLGPSKNRM)
		{
			return 0;
		}

		public bool ESNNRFRTKEF()
		{
			return false;
		}

		public int PEHPITPEFHG(float OGFKHSKTHHR)
		{
			return 0;
		}

		public MinMaxValueInt TPSEGFENGKG(float JKRQSLILLQK)
		{
			return default(MinMaxValueInt);
		}

		public string PGNSQTKGSEM()
		{
			return null;
		}

		public MinMaxValueInt TKHFKGMPSTS(float JKRQSLILLQK)
		{
			return default(MinMaxValueInt);
		}

		public override string ToString()
		{
			return null;
		}

		public static MinMaxValueInt FLJMERSMIIH(MinMaxValueInt HHRGQEQGGIS, MinMaxValueInt ELEIPINNGGJ, float QPNIRNRNJON)
		{
			return default(MinMaxValueInt);
		}

		public static MinMaxValueInt MGEIIRPMIFN(int[] JGTIHIJPMRI)
		{
			return default(MinMaxValueInt);
		}
	}

	[Serializable]
	public struct WeaponPartIdentifier
	{
		public WeaponData.OHHQFFINRQH category;

		public PQRIQGIOGQT rarity;

		public int type;

		public bool REQTNKGENTT(WeaponData.OHHQFFINRQH OJTGHRGORLS, PQRIQGIOGQT OEESQHTSGJL, int OGFKHSKTHHR)
		{
			return false;
		}

		public bool REQTNKGENTT(WeaponPartIdentifier HSLQJLPMLMH)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public string NOILPIKFGJM()
		{
			return null;
		}
	}

	[Serializable]
	public struct WeaponPart
	{
		public WeaponPartIdentifier identifier;

		public ObscuredInt amount;

		public bool REQTNKGENTT(WeaponData.OHHQFFINRQH OJTGHRGORLS, PQRIQGIOGQT OEESQHTSGJL, int OGFKHSKTHHR)
		{
			return false;
		}

		public bool REQTNKGENTT(WeaponPartIdentifier HSLQJLPMLMH)
		{
			return false;
		}
	}

	[Serializable]
	public struct WeaponPartGeneral
	{
		public PQRIQGIOGQT rarity;

		public int type;

		public int amount;

		public WeaponPart RKHSKKPIEJI(WeaponData.OHHQFFINRQH EMKNPKTIJPF)
		{
			return default(WeaponPart);
		}
	}

	[Serializable]
	public struct LevelInteger
	{
		public int level;

		public int value;
	}

	[Serializable]
	public struct UpgradePrice
	{
		public WeaponData.OHHQFFINRQH category;

		public int cashPrice;

		public int scrapPrice;

		public int wrenchPrice;
	}

	[Serializable]
	public struct WeaponCategorySprite
	{
		public WeaponData.OHHQFFINRQH category;

		public Sprite sprite;
	}

	[Serializable]
	public struct AgentIdWithCount
	{
		public RRMFSKNJIOH id;

		public int count;

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public struct SpriteWithNumber
	{
		public int num;

		public Sprite sprite;
	}

	[Serializable]
	public struct ImageWithNumber
	{
		public int num;

		public Image image;
	}

	[Serializable]
	public struct DifficultyImage
	{
		public OperationController.JMSSNJLGTFN difficulty;

		public Image image;
	}

	[Serializable]
	public struct DifficultySprite
	{
		public OperationController.JMSSNJLGTFN difficulty;

		public Sprite sprite;
	}

	[Serializable]
	public struct DifficultyColor
	{
		public OperationController.JMSSNJLGTFN difficulty;

		public Color color;
	}

	[Serializable]
	public struct DifficultyBackground
	{
		public OperationController.JMSSNJLGTFN difficulty;

		public Color topColor;

		public Color botColor;

		public Color tileColor;
	}

	[Serializable]
	public struct BasicPurchase
	{
		public string id;

		public int amount;

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public struct GemPurchase
	{
		public int gemPrice;

		public int amount;
	}

	[Serializable]
	public struct DifficultyGameObject
	{
		public OperationController.JMSSNJLGTFN difficulty;

		public GameObject gameObject;
	}

	[Serializable]
	public struct DifficultyLootBox
	{
		public OperationController.JMSSNJLGTFN difficulty;

		public Lootbox lootbox;
	}

	[Serializable]
	public struct AgentIdGameObject
	{
		public RRMFSKNJIOH aid;

		public GameObject gameObject;
	}

	[Serializable]
	public struct RecipeIdInteger
	{
		public PJLTIFIPFSM id;

		public int value;
	}

	[Serializable]
	public struct LootIdentifierWeight
	{
		public LootIdentifier id;

		public int weight;
	}

	[Serializable]
	[Obsolete]
	public struct LootIdentifierAmount
	{
		public LootIdentifier id;

		public int amount;
	}

	[Serializable]
	public struct LootIdentifierWithAmount
	{
		public LootIdentifier id;

		public int amount;

		public int TRFEQIFFMQT()
		{
			return 0;
		}
	}

	[Serializable]
	public struct LootIdentifierWeightWithAmount
	{
		public LootIdentifier id;

		public int amount;

		public int weight;

		public LootIdentifierAmount RTGQJRSQNNI()
		{
			return default(LootIdentifierAmount);
		}

		public int TRFEQIFFMQT()
		{
			return 0;
		}
	}

	[Serializable]
	public struct LootIdentifierWithInteger
	{
		public LootIdentifier id;

		public int val;
	}

	[Serializable]
	[Obsolete]
	public struct LootIdentifierAmountWeight
	{
		public LootIdentifier id;

		public int amount;

		public int weight;

		public LootIdentifierAmount RTGQJRSQNNI()
		{
			return default(LootIdentifierAmount);
		}
	}

	[Serializable]
	public class DropControllerDataOld
	{
		public PJRPMRSRNJS.DropCollection picked;

		public PJRPMRSRNJS.DropCollection unpicked;
	}

	[Serializable]
	public struct GameplayModeSprite
	{
		public ERTTJTQLQJE type;

		public Sprite Icon;

		public Sprite Ribbon;
	}

	public struct GQREPPGJKKQ
	{
		public bool TOSKEQRHGFK;

		public float SGEPSIJNOOP;
	}

	public static class QGPTLOPREQR
	{
		public static string GNSQMRPKRPP;

		public static string SNHFHOJQRSO;

		public static string MMITGQERLET;

		public static string HLPSJIFOIGP;

		public static string TGHEKQOTQEO;

		public static string NSGFNNJSHOG;

		public static string QPHELRKMNLQ;

		public static string HKHPITKQORP;

		public static string SLQIRPFGQJJ;

		public static string NPNHOSGSPTM;

		public static string TGJGNNJTOSR;

		public static string RFSGKLENEPF;

		public static string RLFJFITEMHP;

		public static string OFMQREIOHEN;

		public static string OROFKPQGQME;

		public static string LPPSKLMKHNS;

		public static string QPJLMRLHIQE;

		public static string TEGEKKLHFSK;

		public static string PGSELTHGQST;
	}

	[Serializable]
	public struct PredefinedWeaponBonus
	{
		public ItemWeapon.RGPEMGEPIJF bonus;

		public bool overrideRolls;

		public MinMaxValueFloat minMaxRoll;
	}

	[Serializable]
	public struct LegendaryWeaponDefinition
	{
		public int legendaryId;

		public JPHMLSJQLNL weaponId;

		public bool EENFGQRELSP(in LegendaryWeaponDefinition FKQLEGQSLHF)
		{
			return false;
		}
	}

	[Serializable]
	public struct GearCategoryWeight
	{
		public int weight;

		public KNSKIMFQMTH category;
	}

	[Serializable]
	public struct GearCategoryWithCount
	{
		public int count;

		public KNSKIMFQMTH category;
	}

	[Serializable]
	public struct GearCategoryWeightList
	{
		public GearCategoryWeight[] weights;

		public int RFRILRHREQN(KNSKIMFQMTH EMKNPKTIJPF)
		{
			return 0;
		}

		public KNSKIMFQMTH NGOEOGPSFGH(System.Random TTTRRFJLTEN = null)
		{
			return default(KNSKIMFQMTH);
		}
	}

	[Serializable]
	public struct LootElementTypeWeight
	{
		public LootElement.TOINELPLRQP type;

		public int weight;
	}

	[Serializable]
	public struct LootElementTypeGameObject
	{
		public LootElement.TOINELPLRQP type;

		public GameObject go;
	}

	[Serializable]
	public struct GearDropData
	{
		public float chance;

		public PQRIQGIOGQT rarity;

		public KNSKIMFQMTH category;
	}

	public enum PQRIQGIOGQT
	{
		UNSET = -1,
		COMMON = 0,
		UNCOMMON = 1,
		EXCEPTIONAL = 2,
		RARE = 3,
		EPIC = 4,
		ELITE = 5,
		LEGENDARY = 6
	}

	public enum ERELIOTMHIS
	{
		CASH = 0,
		GEMS = 1
	}

	public enum QMNJMEELPPP
	{
		UNSET = -1,
		WEAPONS = 0,
		GEAR = 1
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct POLLITIOHJE
	{
		public List<LootElement> loot;
	}

	[CompilerGenerated]
	private sealed class PRJKQSNQHTN
	{
		public LootElement le;

		internal bool _003CLootIdentifierToOwnedLoot_003Eb__1(LootElement x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class ENHEHQSEHEF
	{
		public float delay;

		public Transform flyTo;
	}

	[CompilerGenerated]
	private sealed class FNOENPNQMIO
	{
		public GameObject flyPrefab;

		public Vector3 pos;

		public ENHEHQSEHEF CS_0024_003C_003E8__locals1;

		public TweenCallback _003C_003E9__0;

		internal void _003CFlyCopyGameObject_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class RNIEQFGIEFP
	{
		public GameObject flyObject;

		internal void _003CFlyCopyGameObject_003Eb__1()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct RLKRMKQQPEE
	{
		public Quest quest;
	}

	private static readonly Vector3 GGEQPQNHKMT;

	private static LayerMask HKTSKJTRKGR;

	private static LayerMask IGGMJOPKEKR;

	public const float JTKTRGFKPQT = 0.8f;

	public const float TLLHFOLPGMK = 1.5f;

	public const float OLRINKOPNSO = 1.5f;

	public const float IKTFLPFFKOH = 0.65f;

	public static int QGEENTOOFLI;

	public static float[] GFHIPTFPGIG;

	private static Dictionary<int, string> FQIRTPQGHEL;

	private static readonly Collider[] GQJFJJKLJLO;

	public static string SPFIGRKRNSO;

	public static string HHHIFNJKJEO;

	public static string QSHQLHQQEJT;

	public static string RPMJGFKIPRH;

	public static string MTRKFPRTPIM;

	public static LayerMask ORPMNINOHQF => default(LayerMask);

	public static LayerMask KKQLORQEILI => default(LayerMask);

	public static string HKKQMLOIOFM(string HETQTIKJGNI, string POSNHINOJRL)
	{
		return null;
	}

	public static int PSKMLHIQMJN()
	{
		return 0;
	}

	public static void QPPSTMSPTET(ref GameObject LSIHGRMKHQQ, ref RectTransform QKGHRPIMIGE, in Image GPPGLQHTFTH)
	{
	}

	public static float ILKJNLKESPQ(float[] GGKOKSPHIPI, Actor FNJLLHKNGOR)
	{
		return 0f;
	}

	public static float TMOKIFJJLGO(float[] GOKEHIEESMJ)
	{
		return 0f;
	}

	public static string KFTJNFFSIRL(TimeSpan HLKKFKRJMLO, string POSNHINOJRL = "yellow")
	{
		return null;
	}

	public static string JLFTMPQNQSN(TimeSpan HLKKFKRJMLO, bool RNELHIPRHEJ = true)
	{
		return null;
	}

	public static string INKLSGQRHSH(TimeSpan HOIQPJFQGEO, string POSNHINOJRL = "yellow")
	{
		return null;
	}

	public static string GOMLTKRETMN(int NORMEKSGTNF)
	{
		return null;
	}

	public static string HNGLHJEQGRI(float RRPSNPOTQNT)
	{
		return null;
	}

	public static string LGSFLEOMINJ(ItemWeapon.RGPEMGEPIJF GHQLOLGHJOO, string POSNHINOJRL)
	{
		return null;
	}

	public static string KHTTKROTJMR(ItemWeapon.RGPEMGEPIJF GHQLOLGHJOO, string POSNHINOJRL)
	{
		return null;
	}

	public static string PMTQHOKFESN(ItemWeapon.RGPEMGEPIJF GHQLOLGHJOO, float RRPSNPOTQNT)
	{
		return null;
	}

	public static string ISJEFKGJIFT(ItemWeapon.RGPEMGEPIJF GHQLOLGHJOO)
	{
		return null;
	}

	public static string QOJFOQKJKGK(int OQQEETRKKQQ, int RPHTQRGRLII)
	{
		return null;
	}

	public static string QOJFOQKJKGK(float FOJNGMITMNI)
	{
		return null;
	}

	public static int QRIMTSGSEPQ()
	{
		return 0;
	}

	public static int RQSLLGEKERO(List<ItemWeapon> EEHPKGGSNSL)
	{
		return 0;
	}

	public static float GTHOHTNMOSM(params ItemGear[] GMRMTTQOIML)
	{
		return 0f;
	}

	public static int MGIRPNSRORE(LoadoutWithDataAndGlobalEnhancements RHTOFNFGHOT, Inventory.Data IHKHPQHSLLK)
	{
		return 0;
	}

	public static int LKQFTMQEEGI(LoadoutWithDataAndAgents RHTOFNFGHOT)
	{
		return 0;
	}

	public static int GJQNIMGNPHN(Inventory.Data IHKHPQHSLLK, Loadout RHTOFNFGHOT)
	{
		return 0;
	}

	public static FloatingErrorText KMQIMTNTOMN(string HETQTIKJGNI, Transform HSSNSPQEIGR = null, Transform JKFPSLRREIJ = null, bool PQGNNHQEFIS = true)
	{
		return null;
	}

	public static FloatingErrorText OKHMLPFENKM(string HETQTIKJGNI, Transform HSSNSPQEIGR = null, Transform JKFPSLRREIJ = null, float REMQPHSNQOL = 1f, Color POSNHINOJRL = default(Color), int ONSFMHKHSTH = 0)
	{
		return null;
	}

	public static void GPJSMLNRPTG(Transform JKJPTOGSOSL)
	{
	}

	public static string GQMQGHIKNMK(float NSQGRQMGOJS)
	{
		return null;
	}

	public static bool LPPNREROOFH(ref Vector3 PQNITOOPPOG, float ILLHLNPFESP = 0.5f)
	{
		return false;
	}

	public static string KGIHOHEIGMO(float GTPHKTIPLIQ)
	{
		return null;
	}

	public static int HNKNSGKFRLR(float NRNGTJKLSHG)
	{
		return 0;
	}

	public static float PHQHRJRTTQM(int PILQJQRIFSO)
	{
		return 0f;
	}

	public static string HHOOKQEKNTN(WeaponData.OHHQFFINRQH EMKNPKTIJPF, bool KRGQNJQRGRN = false)
	{
		return null;
	}

	public static string KOTJLGJLKMP()
	{
		return null;
	}

	public static string FITQRNTTNFJ()
	{
		return null;
	}

	public static string QLQMPRJMGFQ()
	{
		return null;
	}

	public static int GGGQMGSJOTP()
	{
		return 0;
	}

	public static string SOJTNGSMKNT(float RRPSNPOTQNT)
	{
		return null;
	}

	public static bool HMPJGSQLNGJ()
	{
		return false;
	}

	public static bool JPJSEOTELPF(Vector3 JRREEHSFTMH, Vector3 GLGRLNQLHJL, out Vector3 FRFPPSKGSHH)
	{
		FRFPPSKGSHH = default(Vector3);
		return false;
	}

	public static bool JPJSEOTELPF(Ray EESKEHNPLEQ, out Vector3 FRFPPSKGSHH)
	{
		FRFPPSKGSHH = default(Vector3);
		return false;
	}

	public static bool JPJSEOTELPF(Ray EESKEHNPLEQ, out RaycastHit HIJKLETTMNG)
	{
		HIJKLETTMNG = default(RaycastHit);
		return false;
	}

	public static Vector3 OLJNTGQHQFN(Vector3 ERINLTKNSFO)
	{
		return default(Vector3);
	}

	public static Vector3 HJEPQRMLNTM(Vector3 ERINLTKNSFO, out bool TJRGNEQGLLJ)
	{
		TJRGNEQGLLJ = default(bool);
		return default(Vector3);
	}

	public static Vector3 HJEPQRMLNTM(Vector3 ERINLTKNSFO)
	{
		return default(Vector3);
	}

	public static bool TSHGKQLETRM(Vector3 ERINLTKNSFO, out RaycastHit EMERMLLSHSL)
	{
		EMERMLLSHSL = default(RaycastHit);
		return false;
	}

	public static VisualController.MPMMIGIJJIN PJTSMMSNOFM(GameObject HLNOJTSONOS)
	{
		return default(VisualController.MPMMIGIJJIN);
	}

	public static float LOSPLJMOGRP(Vector3 EESTGTGKLJG, Vector3 NJLTOMFTSHK, float FMOIOTSGGPN, float PQLGPPIRJPN = 0f)
	{
		return 0f;
	}

	public static bool QMFGGFOGJTH(Actor HHRGQEQGGIS, Actor ELEIPINNGGJ, float RRRRTQIMKTG)
	{
		return false;
	}

	public static List<Actor> QLFTJLPFSEF(Vector3 PQNITOOPPOG, float MPKSKIHFJSF)
	{
		return null;
	}

	public static List<Actor> QLFTJLPFSEF(Vector3 PQNITOOPPOG, float MPKSKIHFJSF, Func<Actor, bool> GPQHQGNSIEM)
	{
		return null;
	}

	public static Enemy LHTFFGHEPLR(Enemy GRMOIOOPGSL, EnemySpot.OOSTRKKLKGI EMKNPKTIJPF, Vector3 PQNITOOPPOG, Vector3 JMTGJHSMOIK, int IQLQQNIPTPQ)
	{
		return null;
	}

	public static Enemy QJTGQOMFLMK(Enemy GRMOIOOPGSL, EnemySpot.OOSTRKKLKGI EMKNPKTIJPF, Vector3 PQNITOOPPOG, Vector3 JMTGJHSMOIK, int IQLQQNIPTPQ)
	{
		return null;
	}

	public static bool FTLGISOHMQH(Vector3 EESTGTGKLJG, Vector3 NJLTOMFTSHK, float OHGGOMMGTIP, float THFGTFKRFMS)
	{
		return false;
	}

	public static bool PJLSJRPEOIT(Vector3 JRREEHSFTMH, Vector2 LNINPSTFFEF, out Vector3 PQNITOOPPOG)
	{
		PQNITOOPPOG = default(Vector3);
		return false;
	}

	public static string KNJFMPNJKJR(PQRIQGIOGQT OEESQHTSGJL)
	{
		return null;
	}

	public static string GJOTQRSEPRI(PQRIQGIOGQT OEESQHTSGJL)
	{
		return null;
	}

	public static float SSJIJTHIMTS(float NSQGRQMGOJS, Enemy PFIHOFSRMEH)
	{
		return 0f;
	}

	public static List<LootElement> LTLMTKLMNRF(List<LootElement> QTFKEHIFPFL)
	{
		return null;
	}

	public static List<LootElement> LTLMTKLMNRF(List<LootIdentifier> QTFKEHIFPFL, bool RPKQONLPJES = false)
	{
		return null;
	}

	public static string RRFFLJKFSHF(NKSMTQENIRK OEESQHTSGJL)
	{
		return null;
	}

	public static long KTOFETTRISH()
	{
		return 0L;
	}

	public static int KSEPMPNPSTT(LevelOffset[] QPRLPKRHFKN, int HHFHLJFISQF)
	{
		return 0;
	}

	public static void OSHOEFJSOTN(ItemWeapon MGRTOPLOHGM, RectTransform EPHEQFRROGP, RectTransform GSNGTMFNEMK)
	{
	}

	public static void MHTQSGQTHJS(GameObject FMGEHJFFJIS)
	{
	}

	public static void NKSSNOEOQIK(GameObject HHNEPQJNQSP, Transform NQLTIPINNNT, int JPPTTPFGKOM, float PRRKGRQILFR = 0f)
	{
	}

	public static string NMJSMMRTPQS(int HFQHNGSGNJM)
	{
		return null;
	}

	public static WeaponPartIdentifier RSNEKLKRPPJ(WeaponData.OHHQFFINRQH EMKNPKTIJPF = WeaponData.OHHQFFINRQH.UNSET, PQRIQGIOGQT MOTTITEELQF = PQRIQGIOGQT.UNSET, int EOOEIROQJOE = -1, System.Random JMRISHQTJQF = null)
	{
		return default(WeaponPartIdentifier);
	}

	public static List<WeaponPartIdentifier> HNROJSIGPOR(WeaponData.OHHQFFINRQH EMKNPKTIJPF = WeaponData.OHHQFFINRQH.UNSET, PQRIQGIOGQT OEESQHTSGJL = PQRIQGIOGQT.UNSET, int EOOEIROQJOE = -1)
	{
		return null;
	}

	public static string SHNTRONOISR(Quest ERPQFMEFQLM, bool RRSMGMGFMPJ)
	{
		return null;
	}

	public static string LIETOQHKFMN(GameController.KFPHKOMNHSS HKFOJSGMRMJ)
	{
		return null;
	}

	public static string PRHLSIHOTKM(Vip.RSQHEFIJIQL OGFKHSKTHHR)
	{
		return null;
	}

	public static string MFQKGGTEETR(ERTTJTQLQJE EOOEIROQJOE)
	{
		return null;
	}

	public static bool SNMSKFHLIHS<T>(this AssetReferenceT<T> RIQSLLTIFLG) where T : UnityEngine.Object
	{
		return false;
	}

	public static bool LFKNTPOJNPE<T>(object QKQMRGKQOMI, out IResourceLocator IQJOHOEIKFS)
	{
		IQJOHOEIKFS = null;
		return false;
	}

	[CompilerGenerated]
	internal static void RNTPIPQGQME(LootElement INNLJIGRFOG, ref POLLITIOHJE P_1)
	{
	}

	[CompilerGenerated]
	internal static void QINPNGTNNTE(ref string QPNIRNRNJON, string GTKOJISNPOE, string RRPSNPOTQNT)
	{
	}

	[CompilerGenerated]
	internal static string RINRKIPLHON(ref RLKRMKQQPEE P_0)
	{
		return null;
	}
}
