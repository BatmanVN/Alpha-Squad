using UnityEngine;

public class SpecialShoot : MonoBehaviour, SRLPFFRNIOO
{
	private enum JNPSMOSGHPS
	{
		None = 0,
		Preparing = 1,
		Active = 2,
		Recovering = 3
	}

	[SerializeField]
	private Vector2 specialInterval;

	[SerializeField]
	private Vector2 distanceLimits;

	public float prepareDuration;

	public float recoveryDuration;

	public float triggerInterval;

	public float animationSpeedMultiplier;

	public int ammo;

	public bool overrideAimPosition;

	public float angle;

	public float angleOffset;

	public float inaccuracyRadius;

	public WeaponDamageEntity projectileOverride;

	public GameObject readyVisual;

	private JNPSMOSGHPS MJPJLPIKQFE;

	private float HREPMHQLTOL;

	private float EKFSSTEMLFQ;

	private float ONOIREHTETT;

	private int PGFRMJGOMSR;

	public SoundEffect sfx;

	private Soldier FIRQTKNHJLL;

	private Animator HMRISTHTFOE;

	private AttackModule LMORQQRTQHH;

	private void Awake()
	{
	}

	private void EROPPSHMOSP()
	{
	}

	private void MHFNOHPTKKI(Modifications.ModificationData KPERIOFQLEM, bool PEJJOSEKFPK)
	{
	}

	public virtual void SpecialUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void EIPFIMRRKMT()
	{
	}

	public void Process()
	{
	}

	private void NKNSQHHMEGM(Vector3 PQNITOOPPOG)
	{
	}

	private void NIJSHFJGGKI()
	{
	}

	public Vector3 CalculateAimPosition()
	{
		return default(Vector3);
	}

	private float EOKPJINIPQS()
	{
		return 0f;
	}

	private float HFMOJONTSIF()
	{
		return 0f;
	}

	private void FIQTSIGPJTE()
	{
	}

	public bool ShouldActivate()
	{
		return false;
	}
}
