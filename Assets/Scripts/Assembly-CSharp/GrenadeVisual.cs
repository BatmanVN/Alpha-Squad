using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

public class GrenadeVisual : WeaponDamageEntityVisual
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct OMRGGJMNHPG
	{
		public Material material;
	}

	[SerializeField]
	public GameObject visual;

	[SerializeField]
	public TrailRenderer[] trails;

	[SerializeField]
	public ParticleSystem particles;

	[SerializeField]
	public GameObject explosionFx;

	[SerializeField]
	public bool cameraShake;

	[SerializeField]
	public SoundEffect explosionSfx;

	[SerializeField]
	public SoundEffect grenadeCollisionSound;

	public WeaponDamagingZoneVisual weaponDamagingZoneVisual;

	protected Grenade SPJNRSNIJFQ;

	protected Material EGMKGFOERSE;

	public event Action<Grenade> MGKPMPHSLFR
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

	protected virtual void Awake()
	{
	}

	public virtual void Setup(Grenade MRQTTISPFJF)
	{
	}

	protected virtual void FEKKIHMRMQE(bool LFOPPIKPRFQ)
	{
	}

	private void GLOSFEHETFL(Collision QFRIINRRGIM)
	{
	}

	private void GPNHQJPMQJL()
	{
	}

	public static void AnimateBlinking(Material PPGGTFESMHN, float JFGETRHIGPL)
	{
	}

	public static Material CreateMaterialInstance(Transform SGNGLTOOMKT)
	{
		return null;
	}

	protected virtual void IEIQJREKKIF(Grenade IKONITGHGEQ)
	{
	}

	protected static void KRLGTMTOHEQ()
	{
	}

	private void OnDisable()
	{
	}

	protected void PIMJMQQRORP()
	{
	}

	protected void LMKHQNPNGIF()
	{
	}

	[CompilerGenerated]
	internal static void HRSMQTPSLNI(Sequence MHNOIFFONJM, float JPKGQSMKSTF, ref OMRGGJMNHPG P_2)
	{
	}
}
