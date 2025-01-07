using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class UltimateDash : UltimateBase
{
	[CompilerGenerated]
	private sealed class FKNGFPRSOLG
	{
		public UltimateDash _003C_003E4__this;

		public UltimateUI ui;

		public Player player;

		public CameraController cam;
	}

	[CompilerGenerated]
	private sealed class NKSTTPHQKJR
	{
		public Vector3 toPos;

		public Vector3 teleportDirection;

		public Vector3 from;

		public bool last;

		public FKNGFPRSOLG CS_0024_003C_003E8__locals1;

		public TweenCallback _003C_003E9__1;

		internal void _003CStartDash_003Eb__0()
		{
		}

		internal void _003CStartDash_003Eb__1()
		{
		}
	}

	public int charges;

	public float maxPlacementTime;

	public float maxDistance;

	public float damageRadius;

	public float dmgCPMultiplier;

	public float slowmoAmount;

	public float INITIAL_DELAY;

	public float DASH_DELAY;

	public float FLASH_DURATION;

	public float MOVE_DURATION;

	public float GLOBAL_MULTIPLIER;

	public GameObject fxFrom;

	public GameObject marker;

	public GameObject markerValid;

	public GameObject markerInvalid;

	public GameObject pathMarker;

	public GameObject altPlayerVisual;

	public Transform playerLockPos;

	public LineRenderer pathRenderer;

	public TrailRenderer trail;

	public RangeIndicator rangeIndicator;

	public Transform rotateTransform;

	private int SNKHQTEJRSG;

	private float RRQKLTHJTSE;

	private int IGKQEMHTIEH;

	private bool KHEJKPLJPLM;

	private List<Vector3> ITTRSKEJQFJ;

	private List<GameObject> MQLEGTHITOS;

	private Vector3 FIIMTKMSNOQ;

	private RaycastHit[] HHSNMPPINMQ;

	public SoundEffect placeMarkerSound;

	public SoundEffect dashSound;

	public SoundEffect activateSound;

	protected override void Awake()
	{
	}

	public override void OnClick()
	{
	}

	private float NLPIINTFTJG()
	{
		return 0f;
	}

	public void OnClickWorld(Vector3 ETRKSFJPFHS)
	{
	}

	public void OnHoldWorld(Vector3 ETRKSFJPFHS)
	{
	}

	private Vector3 LMQQQSKJNFJ()
	{
		return default(Vector3);
	}

	public void OnReleaseWorld(Vector3 ETRKSFJPFHS)
	{
	}

	private void SLTNSKIMTQE(Vector3 ETRKSFJPFHS)
	{
	}

	private void LNGNONLKHEO()
	{
	}

	private void Update()
	{
	}

	private void GNNNJSITRTL()
	{
	}

	private void IQEINPNNQHQ(Vector3 PGNJKOGGIRL, Vector3 GNFPJSRMGIN)
	{
	}

	private LQJTRNFQISM TILRQQKREFK()
	{
		return null;
	}

	private void SIENNNKMTGN()
	{
	}

	public override void AddCharge(float ISLTSKEPJPI)
	{
	}

	private void FFSOENGMLRR()
	{
	}

	public override float GetActiveProgress()
	{
		return 0f;
	}

	public override string GetActiveText()
	{
		return null;
	}

	public override bool ClickableWhenActive()
	{
		return false;
	}

	public override string GetInfoText()
	{
		return null;
	}

	private void NTHNOKSEMIK(Vector3 ETRKSFJPFHS)
	{
	}

	private bool MIKLMSFOSKT(Vector3 ETRKSFJPFHS, out Vector3 HMQEEEHSMHE, Vector3 TLSJLLILROG)
	{
		HMQEEEHSMHE = default(Vector3);
		return false;
	}

	[CompilerGenerated]
	private void GJPEINMKNLK()
	{
	}
}
