using System.Runtime.CompilerServices;
using UnityEngine;

public class OrbTurret : Turret, ScanOrb.OOFRTHTTIPE
{
	[CompilerGenerated]
	private sealed class IGQNGKRKLKM
	{
		public GameObject zap;

		internal void _003CTryZapPlayer_003Eb__0()
		{
		}
	}

	[SerializeField]
	private bool dropLoot;

	[SerializeField]
	protected ScanOrb orbPrefab;

	[SerializeField]
	protected GameObject zapPrefab;

	[SerializeField]
	protected float spawnInterval;

	[SerializeField]
	protected float zapDuration;

	[SerializeField]
	protected float zapInterval;

	[SerializeField]
	protected float lockDuration;

	[SerializeField]
	protected bool targetLocked;

	[SerializeField]
	private SoundEffect scanOrb;

	[SerializeField]
	private SoundEffect ShotOrb;

	protected float RGQESMLLGKN;

	protected float HHFMRGFHTPS;

	protected float GOTFSPOOMJP;

	private bool KKNESEHPMPJ;

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	public override bool InCombat()
	{
		return false;
	}

	private void HIEOPRQTQES()
	{
	}

	public void OnPlayerTriggered(ScanOrb JMGEOPGKMOS)
	{
	}

	protected void MPOKJGIEGSQ()
	{
	}

	private bool JSMGLTKRFHN(Vector3 ERINLTKNSFO, out Vector3 FRFPPSKGSHH)
	{
		FRFPPSKGSHH = default(Vector3);
		return false;
	}

	public override bool Hit(LQJTRNFQISM EMERMLLSHSL)
	{
		return false;
	}

	public override void OnReceiveAnnouncement(Transform EESTGTGKLJG, float IMJQQHHMJEQ)
	{
	}
}
