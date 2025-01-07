using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class SpecialBasicGrenadeNotOnTarget : SpecialBasicGrenade
{
	[CompilerGenerated]
	private sealed class MMJTKTMLNRL
	{
		public Vector3 at;

		public SpecialBasicGrenadeNotOnTarget _003C_003E4__this;

		internal void _003COnSetActive_003Eb__0()
		{
		}
	}

	[SerializeField]
	protected Vector2 distanceOffTarget;

	[SerializeField]
	private bool mustBeReachable;

	[SerializeField]
	private float addedTimeToReach;

	[SerializeField]
	private bool multiple;

	[SerializeField]
	private int projectileCount;

	[SerializeField]
	private float shotDelay;

	[SerializeField]
	private float minDistanceBetween;

	private List<Vector3> QRPLISEEHMQ;

	private GameObject TTLRNQPERJO;

	private RaycastHit[] HHSNMPPINMQ;

	private float OFKJFSORGOE;

	private int ETOFHTMGKHK;

	private List<Tween> KKRIRMIIHGK;

	protected override void Awake()
	{
	}

	protected override void ITNGQTQIRME()
	{
	}

	protected override void MLHRFERJRGK()
	{
	}

	protected override void FIQTSIGPJTE()
	{
	}

	protected override void PFSGROGPRJN(Vector3 JRREEHSFTMH, Vector3 SQKRIEEPPEG)
	{
	}

	private bool RGFJNOKEFLS(Vector3 QIOLLKMPNFO, out Vector3 PQNITOOPPOG)
	{
		PQNITOOPPOG = default(Vector3);
		return false;
	}

	public override bool ShouldActivate()
	{
		return false;
	}

	private bool PMEMLQNQJHF()
	{
		return false;
	}

	[CompilerGenerated]
	private void NKGTMKLSFMR(LQJTRNFQISM HHRGQEQGGIS, Actor ELEIPINNGGJ)
	{
	}
}
