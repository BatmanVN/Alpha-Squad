using System.Runtime.CompilerServices;
using UnityEngine;

public class ElectroBall : DamageEntity
{
	[CompilerGenerated]
	private sealed class HFIIMITTSTP
	{
		public LightningRenderer zap;

		internal void _003CHitActor_003Eb__0()
		{
		}
	}

	[SerializeField]
	private LightningRenderer prefabShock;

	[SerializeField]
	private float damageMultiplerPerHit;

	[SerializeField]
	private float hitInterval;

	[SerializeField]
	private SoundEffect damagedSound;

	[SerializeField]
	private float radius;

	private Actor FNJLLHKNGOR;

	private WeaponInfo LENQOPNFMTG;

	private const float JKHLMPMOSIG = 4f;

	private float SFKTTGTOEKH;

	private Vector3 GLGRLNQLHJL;

	private void Awake()
	{
	}

	private void OnValidate()
	{
	}

	public void Setup(Actor TNKMMOJJPPI, Actor ETGMMEJFEOP, WeaponInfo QGPIMPLNPPI)
	{
	}

	private void Update()
	{
	}

	private void IHFOJSNIJMO()
	{
	}

	private void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	private void STNSQIGGHFI(Actor ETGMMEJFEOP)
	{
	}

	public override LQJTRNFQISM GenerateHit()
	{
		return null;
	}
}
