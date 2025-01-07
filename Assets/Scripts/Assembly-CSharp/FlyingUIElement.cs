using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class FlyingUIElement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class EHQJOMEGROF<T> where T : FlyingUIElement
	{
		public Vector2 viewportMin;

		public Vector2 viewportMax;

		public float zPos;

		public Camera cam;

		public bool cancelPreSpawning;

		public float targetScale;

		public List<FlyingUIElement> spawned;

		public Transform flyTransfrom;

		public Vector3 flyLocation;

		public float flightAccel;

		public int rewardAmountPerCoin;

		public int rewardLeft;

		public int visualCoins;
	}

	[CompilerGenerated]
	private sealed class EMRPQFELJTQ<T> where T : FlyingUIElement
	{
		public int index;

		public EHQJOMEGROF<T> CS_0024_003C_003E8__locals1;

		internal void _003CSpawnSquare_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class RTJJEIMNNHF<T> where T : FlyingUIElement
	{
		public float radius;

		public float aspectRatio;

		public float posX;

		public float posY;

		public float zPos;

		public Camera cam;

		public bool cancelPreSpawning;

		public float targetScale;

		public List<FlyingUIElement> spawned;

		public Transform flyTransfrom;

		public Vector3 flyLocation;

		public float flightAccel;

		public int rewardAmountPerCoin;

		public int rewardLeft;

		public int visualCoins;
	}

	[CompilerGenerated]
	private sealed class TLQETIJPQRR<T> where T : FlyingUIElement
	{
		public int index;

		public RTJJEIMNNHF<T> CS_0024_003C_003E8__locals1;

		internal void _003CSpawnCircle_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class GSRFQHPPMEP<T> where T : FlyingUIElement
	{
		public RectTransform inRect;

		public bool inbounds;

		public Camera cam;

		public float targetScale;

		public bool cancelPreSpawning;

		public List<FlyingUIElement> spawned;

		public Transform flyTransfrom;

		public Vector3 flyLocation;

		public float flightAccel;

		public int rewardAmountPerCoin;

		public int rewardLeft;

		public int visualCoins;
	}

	[CompilerGenerated]
	private sealed class NRENSSPLHOF<T> where T : FlyingUIElement
	{
		public int index;

		public GSRFQHPPMEP<T> CS_0024_003C_003E8__locals1;

		internal void _003CSpawnRectTransform_003Eb__0()
		{
		}
	}

	public const float FLY_CAM_Z_DISTANCE_UI = 27f;

	private static int HGOREIMNEMH;

	public bool flying;

	public float flyAcceleration;

	public float scaledownDistance;

	private float HEPSQFLNMMJ;

	private Vector3 FGOQFRNHRMI;

	private Vector3 MTOSOSLJNFG;

	private Camera RSOHOGMFHRK;

	private List<FlyingUIElement> SELSREJENPP;

	private float RENFLFPEMGE;

	protected float TKTJGHTROMT;

	protected float RMHNKOLQLNK;

	public bool randomizeColor;

	public Color colorMin;

	public Color colorMax;

	private float PRRFSJGPTNH;

	private float LFHGJTNORKP;

	[NonSerialized]
	public int rewardAmount;

	public Action<int> OnReachUI;

	public Transform visual;

	protected Vector2 KRKILIKILSS;

	private Vector3 QPJHKFRRNEQ;

	protected abstract Transform RJTSQTMOLOL();

	protected abstract void NFHISFKQLGF(int RRPSNPOTQNT);

	protected abstract void KKTRFJHREFS(int RRPSNPOTQNT);

	protected abstract int GFGSISFSRNE();

	protected abstract int NTLLMTHSMTT();

	protected abstract void NSHOJEEIFGS(List<FlyingUIElement> SELSREJENPP);

	protected abstract void PFQQMLKTQTF();

	protected abstract void HRQMIKGGITN();

	protected abstract void POIGMHLPGOK(bool QMQJTFKHNGJ);

	protected abstract void IRRPQGMTMQK();

	protected abstract GameObject OKFHLMIJNQH();

	private static T RGIMSRTOLFJ<T>(Transform JKFPSLRREIJ, Vector3 PQNITOOPPOG) where T : FlyingUIElement
	{
		return null;
	}

	public static void SpawnSquare<T>(int ISLTSKEPJPI, float EIRGGHFNGSH = 1f, int KGSEHOTPRNI = 100, float JGIOSLSFSQI = 10f, float GNJIRMJHNNO = 1f, float EIHIILEKGJR = 1f, float RILSHJHFORI = 1f) where T : FlyingUIElement
	{
	}

	public static void SpawnCircle<T>(int ISLTSKEPJPI, float NNMQJRJFISN = 1f, int KGSEHOTPRNI = 100, float JGIOSLSFSQI = 10f, float GNJIRMJHNNO = 1f, float EIHIILEKGJR = 1f, float LKPSJRQFKRT = 0.5f, float IQFSMIGJJPL = 0.5f, float RILSHJHFORI = 1f) where T : FlyingUIElement
	{
	}

	public static void SpawnRectTransform<T>(int ISLTSKEPJPI, RectTransform IRGELFJFIQM, int KGSEHOTPRNI = 100, float JGIOSLSFSQI = 10f, float GNJIRMJHNNO = 1f, float EIHIILEKGJR = 1f, bool FTNRFNIHNGP = false, float RRIGNONKQIS = 1f, float RILSHJHFORI = 1f) where T : FlyingUIElement
	{
	}

	protected virtual void NGHFQRREIJN()
	{
	}

	public void SetTargetScale(float RRIGNONKQIS = 1f)
	{
	}

	protected void Update()
	{
	}

	private void NRRLGQKOLIL()
	{
	}

	private void IKMTQJNEGIL()
	{
	}

	protected virtual bool JRHNMFPJFFT()
	{
		return false;
	}

	public void AnimateSpawnUI()
	{
	}

	public void AnimateSpawnUIInRect()
	{
	}

	private void HORIGEKPTPT()
	{
	}

	private static Camera RHTRRETOEIS()
	{
		return null;
	}

	[CompilerGenerated]
	internal static bool QIPSOHHPLMR(Camera KSIMSNROKFP)
	{
		return false;
	}
}
