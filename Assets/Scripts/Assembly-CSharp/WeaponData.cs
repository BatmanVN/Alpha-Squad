using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponData : ScriptableObject
{
	public enum OHHQFFINRQH
	{
		UNSET = -1,
		PISTOL = 0,
		SUBMACHINE_GUN = 1,
		SHOTGUN = 2,
		ASSAULT_RIFLE = 3,
		SNIPER = 4,
		EXPLOSIVE = 5,
		LIGHT_MACHINE_GUN = 6
	}

	public enum NPFHJORTJIG
	{
		None = 0,
		Melee = 1,
		Ranged = 2
	}

	public enum EROOPMNJEIR
	{
		None = 0,
		Swing = 1,
		Stab = 100
	}

	public enum FOTPMHNRNFK
	{
		None = 0,
		OneHanded = 1,
		TwoHanded = 100,
		TwoHandedHeavy = 110,
		TwoHandedLMG = 120,
		DualWield = 200,
		Thrown = 300,
		Launcher = 400,
		RPG = 500
	}

	public enum ONFRJOIITTH
	{
		Always = 0,
		LockOnStartAim = 1,
		LockOnFinishAim = 2,
		LockBeforeShot = 3
	}

	public enum GPPGLSMSEMS
	{
		TargetPoint = 0,
		Root = 1
	}

	public enum RSMPHJOIIQO
	{
		Random = 0,
		Constant = 1
	}

	[Serializable]
	public struct MeleeHit
	{
		public float time;

		public float range;
	}

	public JPHMLSJQLNL id;

	public WeaponSkin[] raritySkins;

	public bool droppable;

	public List<string> titleKeys;

	public OHHQFFINRQH category;

	public JJHFPNTSRLT.PQRIQGIOGQT minimumRarity;

	public int minimumEnemyLevel;

	public int baseCombatPower;

	public List<ItemWeapon.RGPEMGEPIJF> weaponSpecificBonuses;

	public WeaponLegendaryConfig[] legendaryVariations;

	public NPFHJORTJIG weaponType;

	public EROOPMNJEIR meleeAnimationType;

	public FOTPMHNRNFK rangedAnimationType;

	public ONFRJOIITTH aimType;

	public GPPGLSMSEMS aimTarget;

	public bool dualWield;

	public bool reloadAnimation;

	public bool prepareAfterReload;

	public Ragdoll.FKHQTISHHSK ragdollArea;

	public float pushForce;

	public float ragdollPushForce;

	public float prepareAnimationMultiplier;

	public float reloadAnimationMultiplier;

	public float shootAnimationMultiplier;

	public float damage;

	public float range;

	public float loudnessRange;

	public float projectileLoudnessRange;

	public int bullets;

	public int ammo;

	[HideInInspector]
	public int clips;

	public float spreadAngle;

	public RSMPHJOIIQO spreadType;

	public float bulletSpeed;

	public float critChance;

	public float critMultiplier;

	public bool ignoreLineOfSight;

	public bool burst;

	public int burstBullets;

	public float aimTime;

	public float lockOnAimTimePercent;

	public float reloadCooldown;

	public float shotCooldown;

	public float burstCooldown;

	public float fireDelay;

	public MeleeHit[] meleeHitTimings;

	public WeaponDamageEntity damageEntity;

	public List<Sprite> icons;

	public WeaponInfo HJQIKEHHRSO(bool KLERJOHMHJR = false)
	{
		return null;
	}

	public bool SRIMPSRETOK()
	{
		return false;
	}

	public float PQSGJSOJQJM()
	{
		return 0f;
	}

	public float NEOTKNPKHHR()
	{
		return 0f;
	}

	public string OKFHPMLIGIJ(bool FNTRGTGOOTP = false)
	{
		return null;
	}

	public float JOENEPENISF(bool FNTRGTGOOTP = false)
	{
		return 0f;
	}

	public LQJTRNFQISM TILRQQKREFK()
	{
		return null;
	}

	public WeaponSkin GIGKOFKGRII(int FOQIJNNSRNI = 0)
	{
		return null;
	}

	public WeaponSkin LFLTFKFGIES(int RLEOTJHQFJH)
	{
		return null;
	}

	public Sprite MTFFMFMHSRJ(int MOTTITEELQF = 0, int RLEOTJHQFJH = -1)
	{
		return null;
	}

	public string RMTTLLROMMM(int FOQIJNNSRNI = 0)
	{
		return null;
	}

	public void MONERHOQQIP(JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF = JJHFPNTSRLT.PQRIQGIOGQT.COMMON, int IQLQQNIPTPQ = 0, int OTESLRQHSKO = 0)
	{
	}

	public void OHQGHESRQTE()
	{
	}

	public void KHHLNLLENGS()
	{
	}

	public void EOFPPMGJTPR(int EESQJISERQF)
	{
	}

	public bool LJSFENGSQOF()
	{
		return false;
	}

	private float JLGRIOIHLPI()
	{
		return 0f;
	}

	private float QERILKOQPKM(int PMTESSEOGRH = 1)
	{
		return 0f;
	}

	private float HIJGLRPHHTJ()
	{
		return 0f;
	}
}
