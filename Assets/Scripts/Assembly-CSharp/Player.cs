using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class Player : Actor
{
	[Serializable]
	public struct Data
	{
		public ObscuredFloat healthPercentage;

		public ObscuredFloat ultimateCharge;

		public ObscuredFloat shield;
	}

	public struct IQPIIHSIRPS
	{
		public int PSPJIJNTMOI;

		public float IPEPFTOQGES;

		public float MKLLHHINHJP;
	}

	[CompilerGenerated]
	private sealed class LIPFHGLNHJG
	{
		public int index;

		internal bool _003CDisableWeaponSlot_003Eb__0(IQPIIHSIRPS i)
		{
			return false;
		}

		internal bool _003CDisableWeaponSlot_003Eb__1(IQPIIHSIRPS i)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RRNJHFJFPML
	{
		public WeaponInfo weaponInfo;

		public Player _003C_003E4__this;

		internal void _003CSetupAttackModule_003Eb__0()
		{
		}

		internal void _003CSetupAttackModule_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class MLRKTKIQONG
	{
		public WeaponData weaponData;

		internal bool _003CGetWeaponInfoFromData_003Eb__0(WeaponInfo wi)
		{
			return false;
		}
	}

	public const float SIGHT_SPHERECAST_RADIUS = 0.15f;

	public static string DATA_KEY;

	private const bool TIHGKEIIRSH = false;

	public List<WeaponInfo> weapons;

	public List<IQPIIHSIRPS> disabledWeapons;

	public Transform visual;

	public Vector2 input;

	public bool inputActive;

	public float rotationSpeed;

	public bool forcedMovement;

	public float incomingHealing;

	public LayerMask raycastBlockMask;

	[SerializeField]
	private RangeVisual attackRangeVisual;

	[SerializeField]
	private Transform moveIndicator;

	[SerializeField]
	private GameObject[] weaponSwitchFXPrefab;

	public MovementController movementController;

	public Data data;

	public TMSFJGGGSLO ultimate;

	private Agent EITKISQOFNO;

	private bool PGNSNMTQQTI;

	private bool IITSSOGIQHE;

	private bool ELPEQEJFLPM;

	private bool KGEFQTFONKO;

	private float EEGHLLKPGFS;

	public List<Task> loadingTasks;

	private bool NTMRKHRMQRI;

	private bool NNFLLKMJKJI;

	private float LRINLEMLLJJ;

	private bool KNFHQRSPQOS;

	public event Action<WeaponInfo> KOIMQGRGQMK
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

	public event Action ELORFINQNPI
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

	public void TestHeal()
	{
	}

	protected override void Awake()
	{
	}

	private void JTRKOEQQIGQ()
	{
	}

	private void JIRNTPLQFPO()
	{
	}

	protected override void Start()
	{
	}

	private void IGIQTHHJEFE()
	{
	}

	public override void InitImprovements()
	{
	}

	private void TTPLKMIPEKR()
	{
	}

	protected override void REHNMIPHJJI()
	{
	}

	protected void REIQINPKSKQ()
	{
	}

	private void JSILOOQIGFF(WeaponInfo QHNGKJKPMOH)
	{
	}

	private int HORELFEFQFM()
	{
		return 0;
	}

	private void JNQJPHQGPGJ()
	{
	}

	private void ILKGHTKLRJN()
	{
	}

	private void HENELGRIJLH()
	{
	}

	private void GEKTRFITETP()
	{
	}

	private void HPSHLHGSHIH(ItemWeapon LENQOPNFMTG)
	{
	}

	public void DisableWeaponSlot(int PSPJIJNTMOI, float MKLLHHINHJP)
	{
	}

	public bool IsWeaponSlotDisabled(int PSPJIJNTMOI)
	{
		return false;
	}

	public IQPIIHSIRPS GetDisabledWeaponSlot(int PSPJIJNTMOI)
	{
		return default(IQPIIHSIRPS);
	}

	private void KLJEPKORMLM()
	{
	}

	private void RSGJNTSIIOK()
	{
	}

	public bool HasLoadedWeapos()
	{
		return false;
	}

	private WeaponInfo HHSGPOJPIJF(ItemWeapon QTRSFNTGTSR)
	{
		return null;
	}

	private void PMITOIOJNOT()
	{
	}

	public static void ClearData()
	{
	}

	private void IKFJNJOHFIL(bool MPPOHPQMPNK = true)
	{
	}

	public void SetupWeaponInitialStates()
	{
	}

	public override float CalculateMaxHealth()
	{
		return 0f;
	}

	public void SelectWeapon(int PSPJIJNTMOI)
	{
	}

	public void SelectWeapon(WeaponInfo QIHJTTETOPN)
	{
	}

	public void FindAndSelectExistingWeapon()
	{
	}

	private bool HRFLILONJRE()
	{
		return false;
	}

	private void FGHEIFJIKJE()
	{
	}

	public void StartReloadingCurrentWeapon()
	{
	}

	public WeaponInfo GetSelectedWeaponInfo()
	{
		return null;
	}

	public override void Revive()
	{
	}

	protected override void Update()
	{
	}

	private void NLGTJMRQKJJ()
	{
	}

	private void NQTLQQGFHPP()
	{
	}

	public override float GetMoveSpeedMultiplier()
	{
		return 0f;
	}

	private void QRPEOPEIMLQ()
	{
	}

	private void EFKGSRHKTJL(WeaponInfo QIHJTTETOPN)
	{
	}

	private void JMRNMHJTKTS()
	{
	}

	private void IFSQKRHSRFN(WeaponInfo QIHJTTETOPN)
	{
	}

	public Agent GetActiveAgent()
	{
		return null;
	}

	public void ProcGadgetGuyAbility(AgentData QPQITJOLQFS)
	{
	}

	public void ShowNoAmmoText()
	{
	}

	private WeaponInfo HQETMNFQFEM(WeaponData KROTEKTFGLI)
	{
		return null;
	}

	private bool GSFELQJSFTP(WeaponInfo QIHJTTETOPN)
	{
		return false;
	}

	public override float CalculateDamage(ref LQJTRNFQISM EMERMLLSHSL)
	{
		return 0f;
	}

	public override bool Hit(LQJTRNFQISM EMERMLLSHSL)
	{
		return false;
	}

	public override void Push(LQJTRNFQISM EMERMLLSHSL)
	{
	}

	public override float GetLastMoveTime()
	{
		return 0f;
	}

	private static bool ITSPQJHRGJK()
	{
		return false;
	}

	public void SetTimedInvulnerability(float MKLLHHINHJP, bool RQSTOMPHHHQ = false)
	{
	}

	private void PMKTQRHNGQQ()
	{
	}

	private void GFRFMEFNPOS()
	{
	}

	public override float GetNormalizedSpeed()
	{
		return 0f;
	}

	public override float GetMaxSpeed()
	{
		return 0f;
	}

	public void RefreshMoveSpeed()
	{
	}

	public override bool IsGrounded()
	{
		return false;
	}

	public bool IsTryingToMove()
	{
		return false;
	}

	public bool HasValidTarget()
	{
		return false;
	}

	public void SetShootingDisabled(bool MPGHMIRKNON)
	{
	}

	public void SetTargetingActive(bool SMJFTKGRFLJ)
	{
	}

	private void LSOJSFMQGQT()
	{
	}

	public bool IsTargetingActive()
	{
		return false;
	}

	private void HTPKPEQEEFE(Actor RSJOKOFTLTS)
	{
	}

	public bool CanShootAtCurrentTarget()
	{
		return false;
	}

	public bool CanShootAtActor(Actor NIHPIGRSJMO)
	{
		return false;
	}

	private bool JQFRKQSRQRK(Actor NIHPIGRSJMO)
	{
		return false;
	}

	private bool GMNQPPLPRIS(Actor NIHPIGRSJMO)
	{
		return false;
	}

	private bool LEIJQGMRKGE()
	{
		return false;
	}

	public override Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public override Vector3 GetForwardDir()
	{
		return default(Vector3);
	}

	public override EFIIOMLOOHE GetTeam()
	{
		return default(EFIIOMLOOHE);
	}

	public override void Teleport(Vector3 PIKMETQIMKF, bool KLLPJSRLGEN = false)
	{
	}

	public bool IsAcceptingHealthPickups()
	{
		return false;
	}

	private bool GRGHNKJIGSN(Actor NIHPIGRSJMO)
	{
		return false;
	}

	private void GPRJTTNNSSF(WeaponInfo QIHJTTETOPN)
	{
	}

	protected override void SJFIQRIKNFK()
	{
	}

	protected override void FPRPJIRFIKK(WeaponInfo QHNGKJKPMOH)
	{
	}

	[CompilerGenerated]
	private void MIGJQHMKSTT(LQJTRNFQISM EMERMLLSHSL, Actor NIHPIGRSJMO)
	{
	}
}
