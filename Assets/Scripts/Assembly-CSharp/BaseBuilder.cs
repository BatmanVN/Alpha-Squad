using System;
using System.Runtime.CompilerServices;
using Lean.Touch;
using UnityEngine;
using UnityEngine.Events;

public class BaseBuilder : MonoBehaviour
{
	public enum IFSIKTGELOS
	{
		Invalid = 0,
		PickUp = 1,
		Build = 2,
		Storage = 3
	}

	public class QHKLSGKKOGG
	{
		public BaseObject HNTPNTJRJMH;

		public IFSIKTGELOS EOOEIROQJOE;

		public IIRHHTHKMHK.JTRFMNHKNOT GRKISMOINFO;

		public bool GEMOEFJFFQN;

		public int QHOQGTRMKHH => 0;

		public BaseObjectData QKTEKTSRTIK => null;

		public BaseObjectData.SSIHJRNKHTT OHOJLKMJLRJ => default(BaseObjectData.SSIHJRNKHTT);

		public void NJPJSHFJENP()
		{
		}

		public void PKNEGNOSOEF()
		{
		}
	}

	[SerializeField]
	private UIBuildControls buildControls;

	[SerializeField]
	private float objectMoveLerpSpeed;

	[SerializeField]
	private float holdToSelectThreshold;

	public static Action<bool> onTogglePlacement;

	public static Action onStoredItemPlaced;

	[NonSerialized]
	public UnityEvent onCancel;

	private bool MSLMKNGFTGT;

	private bool IHLJKIQNLFS;

	private bool GJLJSHMIKFO;

	private LeanFinger ENHLRTGLJGO;

	private Vector2Int LQLSKTIOHTF;

	private float JKKORSNSSHJ;

	private BaseCameraController JENMQGETMLK;

	private BaseRoom SLIEEELQMQS;

	private QHKLSGKKOGG PQPGFQQNQKQ;

	private SphereCollider FGGPPJHMTEF;

	public BaseItemSave GQIKELTJIKJ => null;

	public BaseObject JHTMNSTGOJE => null;

	public IFSIKTGELOS QRGJHKTOPRJ => default(IFSIKTGELOS);

	public void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void NIRKGPRNTGH(int OJJLFPMNEHN)
	{
	}

	public void EnterBuildMode(BaseRoom RQKKORTKOJH)
	{
	}

	public void ExitBuildMode()
	{
	}

	private void OQEKKNHKRFH()
	{
	}

	public bool IsBuildMode()
	{
		return false;
	}

	private void GPJEFKPNFRQ()
	{
	}

	private void OPMJKJLETGI()
	{
	}

	private void IKFMTLHKJRP()
	{
	}

	private void FEGGJOOJSIJ()
	{
	}

	public void StartPlacing(BaseItemSave IOGMNEPJEEM)
	{
	}

	private bool JINQFGKMOFH(IIRHHTHKMHK.JTRFMNHKNOT GGOKJRGSMRT)
	{
		return false;
	}

	private void Update()
	{
	}

	private void IFGQHIOQERQ(BaseObject TJFMGSHMGLK)
	{
	}

	private void HPNSRRJLLPS(BaseItemSave IOGMNEPJEEM)
	{
	}

	private void QORMJMKHLFE()
	{
	}

	private void RFNGTGMIOJK()
	{
	}

	private void RNESOMHSPQF(IIRHHTHKMHK.JTRFMNHKNOT GGOKJRGSMRT, bool KTJGEIPFMKT = false, bool MSPQOHFSIJR = true)
	{
	}

	private void IOPRSJLIREJ()
	{
	}

	private void MOKHPTFNISJ(bool KTJGEIPFMKT)
	{
	}

	private void LMFMJQQPIHE(bool KTJGEIPFMKT)
	{
	}

	private bool HTGKNKILQLI()
	{
		return false;
	}

	private void HFFFNGEJMTP()
	{
	}

	private void GHKJKTITRLK(BaseObject HNTPNTJRJMH)
	{
	}

	private void EFRSQFIKMSF(BaseObject HNTPNTJRJMH)
	{
	}

	private void QQQKFEFRIFN(BaseObject HNTPNTJRJMH)
	{
	}

	private void JIKNIJJQOEM(BaseObject HNTPNTJRJMH)
	{
	}

	private void PPQNHKIHTMS(BaseObject HNTPNTJRJMH)
	{
	}

	public Vector3 GetBuildControlsPos()
	{
		return default(Vector3);
	}

	private bool JGSHMINPMKF()
	{
		return false;
	}

	public static bool RaycastForObject(Ray EESKEHNPLEQ, out RaycastHit EMERMLLSHSL)
	{
		EMERMLLSHSL = default(RaycastHit);
		return false;
	}

	private IIRHHTHKMHK.JTRFMNHKNOT HRMKILELEOK()
	{
		return null;
	}

	private void OMEOIKLKREP()
	{
	}

	private bool QGHQRPESHOE(Vector2Int OIGJTFSEPTF)
	{
		return false;
	}

	private IIRHHTHKMHK.JTRFMNHKNOT HTFGMGQPOQM()
	{
		return null;
	}

	private Vector2Int OJJRLRIJJLI(Vector2Int MQJNJMFPGLM)
	{
		return default(Vector2Int);
	}

	private Vector3 MGOEGJTJORR(Vector2 QEQJIIKSKTQ)
	{
		return default(Vector3);
	}

	private bool HSNKJGLQTGO(out bool IIEKEOREPJT)
	{
		IIEKEOREPJT = default(bool);
		return false;
	}

	private bool PQKIOESLIOM()
	{
		return false;
	}

	private bool HIHJJPSTMLK()
	{
		return false;
	}

	public void OnRotateButton()
	{
	}

	public void OnMirrorButton()
	{
	}

	public void OnConfirmButton()
	{
	}

	public void OnCancelButton()
	{
	}

	public void OnToStorage()
	{
	}

	private void RINSLERQFGL()
	{
	}

	private void HKLPHQSTTOS()
	{
	}

	private void EFPJIPQPNGP(BaseObject OLMQNNPQKIH, bool PHFLQMILKTR = false)
	{
	}

	private void FNSFMPOKGHR(BaseObject HNTPNTJRJMH)
	{
	}

	private void EJQHJQPIRIK()
	{
	}

	private void HOGFRLITENH()
	{
	}

	private void EFQLQPKTRTN()
	{
	}

	private void QLQGPHFTSSR()
	{
	}

	private void HEPOHRKOQIJ()
	{
	}

	public void PlaceNewObject(BaseObject TJFMGSHMGLK, bool TESGTQPOSFP = false, bool PTELSTKTLJT = true)
	{
	}

	private void HHINHNESSSN(bool FFLSTHLJOQK)
	{
	}

	private void TNMHFHKJMTT()
	{
	}

	private void ROOEROKLISL()
	{
	}

	[CompilerGenerated]
	private bool OMTMOHRRPMR(Vector2 KREHJHIJMHE)
	{
		return false;
	}
}
