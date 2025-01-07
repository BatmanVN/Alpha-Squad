using System.Runtime.CompilerServices;
using UnityEngine;

public class BasicGrenadeSafeZone : BasicGrenade
{
	[CompilerGenerated]
	private sealed class NEGEGHQLJNH
	{
		public BasicGrenadeSafeZone _003C_003E4__this;

		public Vector3 collisionPoint;

		internal void _003CSetup_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class TFMHIELTHMF
	{
		public GameObject toDestroy;

		internal void _003CDisableSafeZoneIndicator_003Eb__0()
		{
		}
	}

	public float safeZoneRadius;

	public Transform safeZoneIndicator;

	[SerializeField]
	protected RangeIndicator safeZoneIndicatorRange;

	[SerializeField]
	protected GameObject safeZoneContactPointIndicator;

	private GameObject TKIJIRPFHLS;

	public override void Setup(Actor TNKMMOJJPPI, float NRNGTJKLSHG, float QHPEGHJEESR, Vector3 QQENINJSIOO, int JFGJNJQHNKK = 0)
	{
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void MMRTMTRQNTF(bool NRLORILTSJR = false)
	{
	}

	private void ISJFSMSIKKE()
	{
	}

	public GameObject PrespawnSafeZoneIndicator(Vector3 HSSNSPQEIGR)
	{
		return null;
	}

	public void AssignSafeZoneIndicatorInstance(GameObject TTLRNQPERJO)
	{
	}

	private void EPRIQQQKOHG(Vector3 FRFPPSKGSHH)
	{
	}

	protected override void QSJQTSQFQKE(LFIQQKLISIS GKFKHFITKTO)
	{
	}

	protected override void MOMQRQJSTIP()
	{
	}
}
