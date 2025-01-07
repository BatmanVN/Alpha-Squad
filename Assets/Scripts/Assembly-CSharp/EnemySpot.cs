using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MersenneTwister;
using UnityEngine;

public class EnemySpot : MonoBehaviour
{
	public enum SMMGLQPTJET
	{
		None = 0,
		Pistol = 1,
		PistolElite = 2,
		PistolGunRange = 4,
		PistolGunRangeElite = 5,
		UziUser = 10,
		UziUserElite = 11,
		UziUserGunRange = 12,
		UziUserEliteGunRange = 13,
		OfficeRifle = 20,
		OfficeRifleElite = 21,
		CasinoShotgun = 30,
		CasinoShotgunElite = 31,
		Ninja = 40,
		NinjaElite = 41,
		LadySMG = 50,
		LadySMGElite = 51,
		EgyptSMG = 60,
		EgyptSMGElite = 61,
		ScientistGirl = 70,
		ScientistGirlElite = 71,
		FancyJacket = 72,
		FancyJacketElite = 73,
		ForestHunter = 74,
		ForestHunterElite = 75,
		AsiaRaiden = 76,
		AsiaRaidenElite = 77,
		NightCitySkater = 78,
		NightCitySkaterElite = 79,
		GymCoach = 80,
		GymCoachElite = 81,
		HandyMan = 84,
		HandyManElite = 85,
		Rockstar = 86,
		RockstarElite = 87,
		Bodyguard = 88,
		BodyguardElite = 89,
		Magician = 90,
		MagicianElite = 91,
		Shotgun = 100,
		ShotgunElite = 101,
		ShotgunnerGunRange = 102,
		ShotgunnerGunRangeElite = 103,
		RocketLauncher = 112,
		RocketLauncherElite = 113,
		ShieldBully = 120,
		ShieldBullyElite = 121,
		RPGEgypt = 130,
		RPGEgyptElite = 131,
		Sumo = 132,
		SumoElite = 133,
		TwoHeadedSoldier = 134,
		TwoHeadedSoldierElite = 135,
		HelmetLMG = 136,
		HelmetLMGElite = 137,
		AsiaQuadLauncher = 140,
		AsiaQuadLauncherElite = 141,
		BusinessMan = 142,
		BusinessManElite = 143,
		StrongWoman = 144,
		StrongWomanElite = 145,
		Melter = 146,
		MelterElite = 147,
		MurderClown = 148,
		MurderClownElite = 149,
		Bat = 200,
		BatElite = 201,
		Knife = 210,
		KnifeElite = 211,
		BatElectric = 220,
		BatElectricElite = 221,
		Machette = 230,
		MachetteElite = 231,
		Katana = 240,
		KatanaElite = 241,
		Lumberjack = 250,
		LumberjackElite = 251,
		Scimitar = 270,
		ScimitarElite = 271,
		Tentacles = 280,
		TentaclesElite = 281,
		MutantScientist = 290,
		MutantScientistElite = 291,
		Operator = 292,
		OperatorElite = 293,
		Boxer = 294,
		BoxerElite = 295,
		Miner = 296,
		MinerElite = 297,
		Mime = 298,
		MimeElite = 299,
		Grenadier = 300,
		GrenadierElite = 301,
		ElectroGrenadier = 310,
		ElectroGrenadierElite = 311,
		Mortar = 320,
		MortarElite = 321,
		MobRoller = 330,
		MobRollerElite = 331,
		RollerRobot = 332,
		RollerRobotElite = 333,
		FrankMonster = 334,
		FrankMonsterElite = 335,
		OfficeEngineer = 336,
		OfficeEngineerElite = 337,
		Longbow = 338,
		LongbowElite = 339,
		Dynamite = 340,
		DynamiteElite = 341,
		DreadedPunk = 342,
		DreadedPunkElite = 343,
		Molotov = 344,
		MolotovElite = 345,
		AsiaMonkBomber = 346,
		AsiaMonkBomberElite = 347,
		Traveller = 348,
		TravellerElite = 349,
		RollerRobbotMiniBoss = 350,
		Dumbell = 352,
		DumbellElite = 353,
		Geisha = 354,
		GeishaElite = 355,
		Painter = 356,
		PainterElite = 357,
		Fireworkist = 358,
		FireworkistElite = 359,
		Archer = 400,
		ArcherElite = 401,
		Sniper = 500,
		SniperElite = 501,
		CamoSniper = 510,
		CamoSniperElite = 511,
		CasinoSniper = 520,
		CasinoSniperElite = 521,
		SniperEgypt = 530,
		SniperEgyptElite = 531,
		SniperConstruction = 532,
		SniperConstructionElite = 533,
		SniperCircus = 534,
		SniperCircusElite = 535,
		Turret = 600,
		OrbTurret = 602,
		RocketTurret = 604,
		EngineerCaseTurret = 606,
		EngineerCaseTurretElite = 607,
		MinigunTurret = 608,
		LaserTurret = 610,
		TennisTurret = 612,
		CircusHumanTurret = 614,
		RoboDog = 700,
		RoboDogElite = 701,
		Raptor = 706,
		RaptorElite = 707,
		CircusHuman = 800,
		PistolMiniBoss = 1001,
		UziUserMiniBoss = 1010,
		OfficeRiffleMiniBoss = 1020,
		NinjaMiniBoss = 1040,
		LadySMGMiniBoss = 1050,
		EgyptsmgMiniBoss = 1060,
		ScientistGirlMiniBoss = 1070,
		FancyJacketMiniBoss = 1072,
		ForestHunterMiniBoss = 1074,
		HandyManMiniBoss = 1084,
		MagicianMiniBoss = 1090,
		ShotgunMiniBoss = 1100,
		RocketLauncherMiniBoss = 1112,
		SumoMiniBoss = 1132,
		TwoHeadedSoldierMiniBoss = 1134,
		HelmetLMGMiniBoss = 1136,
		MelterMiniboss = 1146,
		MurderClownMiniboss = 1144,
		BatMiniBoss = 1200,
		KnifeMiniBoss = 1210,
		BatElectricMiniBoss = 1220,
		KatanaMiniBoss = 1240,
		ScimitarMiniBoss = 1270,
		TentacleMiniBoss = 1280,
		MutantScientistMiniBoss = 1290,
		OperatorMiniboss = 1292,
		BoxerMiniBoss = 1294,
		GrenadierMiniBoss = 1300,
		MobRollerMiniBoss = 1330,
		OfficeEngineerMiniBoss = 1336,
		LongbowMiniBoss = 1338,
		DynamiteMiniBoss = 1340,
		MolotovMiniBoss = 1344,
		DumbellMiniBoss = 1352,
		FireworkistMiniBoss = 1358,
		ArcherMiniBoss = 1400,
		AsiaRaidenMiniBoss = 1401,
		SniperEgyptMiniBoss = 1530,
		EngineerCaseTurretMiniBoss = 1606,
		EngineerZapperTurretMiniBoss = 1608,
		FireworkistRocketTurretMiniBoss = 1610,
		SkeletonKnifer = 10000,
		SkeletonKniferElite = 10001,
		SkeletonBatter = 10002,
		SkeletonBatterElite = 10003
	}

	[Flags]
	public enum OOSTRKKLKGI
	{
		None = 0,
		Melee = 2,
		Ranged = 4,
		Heavy = 8,
		Throwing = 0x10,
		Sniper = 0x20,
		Turret = 0x40
	}

	[CompilerGenerated]
	private sealed class NQRSHLSLHIP
	{
		public SMMGLQPTJET enemyToSpawn;

		internal bool _003CAssignType_003Eb__1(EnemyMap.EnemyAddressableEntry x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KIKSTHHLJEJ
	{
		public LevelController lc;

		internal bool _003CGetValidTypesFromCategory_003Eb__0(SMMGLQPTJET e)
		{
			return false;
		}
	}

	private static Vector3 NFTOSNMSHEE;

	private static Vector3 KREHPLPMNPT;

	private const int EGKGQLPMEJH = 5;

	[NonSerialized]
	public SMMGLQPTJET type;

	public OOSTRKKLKGI category;

	public bool canBeElite;

	public bool canBeMiniboss;

	public int densityLevel;

	public int group;

	public bool forceSpecific;

	public SMMGLQPTJET specificType;

	private Enemy PFIHOFSRMEH;

	private bool RREHMPPRKKR;

	private bool QIGSKIIPRJP;

	public virtual Task Create(MTRandom MQORMJQMJRH, EnemySpot[] OTTOHSRRKJJ)
	{
		return null;
	}

	public virtual Task Create(SMMGLQPTJET ISLISTMNHST, bool IEQTGJESMKS = false, float KOHQOOKQRRS = 1f)
	{
		return null;
	}

	private void NOLNPEHSLTF()
	{
	}

	protected bool PQOSSILTMIJ(MTRandom MQORMJQMJRH, EnemySpot[] OTTOHSRRKJJ)
	{
		return false;
	}

	public static List<SMMGLQPTJET> GetValidTypesFromCategory(OOSTRKKLKGI OJTGHRGORLS)
	{
		return null;
	}

	protected virtual Task KGNPEQHEIOQ()
	{
		return null;
	}

	private void OnValidate()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public bool IsTypeAssigned()
	{
		return false;
	}

	public bool HasSpawned()
	{
		return false;
	}

	public Enemy GetSpawnedEnemy()
	{
		return null;
	}

	public static SMMGLQPTJET ToBaseType(SMMGLQPTJET ISLISTMNHST)
	{
		return default(SMMGLQPTJET);
	}

	private void ITTKIOJLIJF(OOSTRKKLKGI NLPKPQMRSGL, ref Vector3 KRKILIKILSS)
	{
	}

	public void AddPatrol()
	{
	}

	public virtual Task CreateMinibossAsync(MinibossConfig LKIORIIOGMP)
	{
		return null;
	}

	private bool QMRLPFSTRRG()
	{
		return false;
	}

	private bool GSRELMIGSIR(MTRandom MQORMJQMJRH)
	{
		return false;
	}

	public static bool CheckCanBeElite(MTRandom MQORMJQMJRH, SMMGLQPTJET ISLISTMNHST)
	{
		return false;
	}

	public static bool HasEliteForm(SMMGLQPTJET ISLISTMNHST)
	{
		return false;
	}

	public static bool IsElite(SMMGLQPTJET ISLISTMNHST)
	{
		return false;
	}

	public static bool IsMiniboss(SMMGLQPTJET ISLISTMNHST)
	{
		return false;
	}

	private bool RTHLRSFSTSR(MTRandom MQORMJQMJRH)
	{
		return false;
	}

	private bool MGEEPLFLMIN(MTRandom MQORMJQMJRH, EnemySpot[] OTTOHSRRKJJ)
	{
		return false;
	}
}
