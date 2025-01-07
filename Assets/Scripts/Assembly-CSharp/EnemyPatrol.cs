using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
	public enum QERFRNLJINJ
	{
		IDLE = 0,
		GO_TO = 1,
		LOOK_AT = 2,
		LOOK_RANDOM = 3
	}

	[Serializable]
	public class Activity
	{
		public QERFRNLJINJ type;

		public Transform to;

		public float time;

		public bool QLIGRLSOKSM(float TNEOQIMLNOS)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct RNSFOMLFTTI
	{
		public Vector3 offset;
	}

	private int FTMNGRMGRHQ;

	private float GJOFGJEPITE;

	private float MPERQJOJQJT;

	private float SJEOPOSFNLO;

	private bool PHTMTNIIKNS;

	private Vector3 JROIMMIRMJE;

	public Activity[] actions;

	public Vector3 lastPatrolLocation;

	private Soldier RIQSLLTIFLG;

	private void Awake()
	{
	}

	public void Act()
	{
	}

	private void TISOFOHOOHJ()
	{
	}

	private void SFEGISKLSRH(Activity HHRGQEQGGIS)
	{
	}

	private void OnDrawGizmos()
	{
	}

	[CompilerGenerated]
	internal static void JRORMKTSROP(Transform EESTGTGKLJG, Transform NJLTOMFTSHK, Color POSNHINOJRL, ref RNSFOMLFTTI P_3)
	{
	}

	[CompilerGenerated]
	internal static void GLFKMHMGGOQ(Transform EESTGTGKLJG, Transform NJLTOMFTSHK, ref RNSFOMLFTTI P_2)
	{
	}
}
