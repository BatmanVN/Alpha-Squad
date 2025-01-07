using System.Runtime.CompilerServices;
using UnityEngine;

public class RocketTurret : Turret
{
	[CompilerGenerated]
	private sealed class SKRLQSNTSTF
	{
		public Vector3 pos;

		public int index;

		public RocketTurret _003C_003E4__this;

		internal void _003CFireSalvo_003Eb__0()
		{
		}
	}

	[SerializeField]
	protected VerticalRocket rocketPrefab;

	[SerializeField]
	protected float fireInterval;

	[SerializeField]
	protected int rocketCount;

	[SerializeField]
	protected float delayBetweenRockets;

	[SerializeField]
	protected float lineLength;

	[SerializeField]
	protected float lineWidth;

	[SerializeField]
	protected SoundEffect fireRocketSfx;

	[SerializeField]
	protected float idleRotationSpeed;

	[SerializeField]
	protected float targetedRotationSpeed;

	[SerializeField]
	protected Transform rotatingPart;

	[SerializeField]
	protected Transform[] spawnPoints;

	[SerializeField]
	protected GameObject muzzleFlash;

	[SerializeField]
	private bool dropLoot;

	protected float JSRFTMFGQIN;

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	protected override void OHQFORJQPJN(LQJTRNFQISM EMERMLLSHSL, Actor NIHPIGRSJMO)
	{
	}

	private void PMKTQRHNGQQ()
	{
	}

	private void JQRNJEHFTTR()
	{
	}

	private void PRGTQOFMJQM(Vector3 SQKRIEEPPEG, int PSPJIJNTMOI)
	{
	}
}
