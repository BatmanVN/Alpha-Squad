using System.Runtime.CompilerServices;
using UnityEngine;

public class ExplosiveBasicProjectile : BasicProjectile
{
	[CompilerGenerated]
	private sealed class KRRHJMJFIRP
	{
		public ExplosiveBasicProjectile _003C_003E4__this;

		public Vector3 collisionPoint;

		internal void _003CSetup_003Eb__0()
		{
		}
	}

	public float radius;

	public float acceleration;

	public float minDamageMultiplier;

	[SerializeField]
	protected SoundEffect explosionSoundSfx;

	[SerializeField]
	protected SoundEffect contactPointSfx;

	[SerializeField]
	protected GameObject explosionFx;

	[SerializeField]
	private float noCollideTime;

	[SerializeField]
	private GameObject contactPointFX;

	[SerializeField]
	protected Grenade.QNTIJGKTKPG contactPointType;

	[SerializeField]
	protected float contactPointDuration;

	[SerializeField]
	protected EFIIOMLOOHE teamFallback;

	[SerializeField]
	private ITKSRPQLPQN damageType;

	[SerializeField]
	private bool damageDropOffOverDistance;

	protected bool QFNMNRLMLFL;

	protected GameObject NTJJQRSTEMM;

	private float RJHNQQPQORE;

	private float HMKGQERQTHF;

	public override void Setup(Actor TNKMMOJJPPI, float QHPEGHJEESR, Vector3 NFFNFMETPLT)
	{
	}

	protected override void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	protected bool GHKSTLOIGTJ(Actor FKQLEGQSLHF)
	{
		return false;
	}

	protected override void OnCollisionEnter(Collision QFRIINRRGIM)
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void FixedUpdate()
	{
	}

	protected virtual void HOMKJKTHSTL()
	{
	}

	private float ILTPRPHNFOO(float RTGEPIFMSES)
	{
		return 0f;
	}

	private Vector3 PLMGPNJMGJH(out float KLHERHJPFKI)
	{
		KLHERHJPFKI = default(float);
		return default(Vector3);
	}

	private void OTPRLRLJIJR(Vector3 FRFPPSKGSHH)
	{
	}
}
