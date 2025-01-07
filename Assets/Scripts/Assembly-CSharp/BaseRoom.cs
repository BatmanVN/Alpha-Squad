using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BaseRoom : MonoBehaviour
{
	public class OMTHTKRKKGL
	{
		private static int SSRMKNNTMJQ;

		private static int RMLQRLOLTOH;

		private Plane OGHHHGOTKOI;

		private IIRHHTHKMHK JMGLSHPLLSQ;

		private Vector2Int HIQFLONLFRO;

		private Material JSKIOJNNTTK;

		public IIRHHTHKMHK GGSEQHMLLKS => null;

		public OMTHTKRKKGL(GameObject HPOGMTGHKGK, Vector3 JSMLIQPPPQS, Vector2Int QMHFIQMSKQJ, bool MFHLFTFTQKQ = false)
		{
		}

		public Vector3 RKJEOTNRGMJ(Ray EMOOJLTPJPP)
		{
			return default(Vector3);
		}

		private void REGQLMRSPMM(GameObject QORNERSEGPL, Vector3 JSMLIQPPPQS, Vector2Int QMHFIQMSKQJ)
		{
		}

		private static void TTJETSOHLRI()
		{
		}

		public Vector2Int KGOLOEIGJIE()
		{
			return default(Vector2Int);
		}

		public void QPOTQTENEQO()
		{
		}

		public void KQSHFFQIGQM()
		{
		}

		public void GRTKHPHMNLE(Vector3 PQNITOOPPOG)
		{
		}
	}

	[CompilerGenerated]
	private sealed class NSNEIEKLGJI
	{
		public BaseItemSave item;

		internal bool _003CItemIsBad_003Eb__0(BaseItemSave x)
		{
			return false;
		}
	}

	public static Action OnNewObjectPlaced;

	public static Action OnRoomClaimed;

	public List<BaseObject> placedObjects;

	private int OJJLFPMNEHN;

	private BaseRoomData TSRPFHOJKSG;

	private BaseRoomManager TLKOMLRFSMM;

	private BaseRoomFrame TKGLRSREGOK;

	private OMTHTKRKKGL RTKPKJSGHHQ;

	private UIBuildRoom ITFKNRTOQMS;

	private int JKTSJMKHLJI;

	[SerializeField]
	private GridLayerData defaultGrid;

	[SerializeField]
	private SerializableDictionary<int, GridLayerData> gridLayerVariants;

	private List<Vector3> SGLNMSTJNRQ;

	public BaseRoomData.FLRJREHIJKL IOLPJMHNPER => default(BaseRoomData.FLRJREHIJKL);

	public BaseRoomData QKTEKTSRTIK => null;

	public OMTHTKRKKGL EESEPQPKOJR => null;

	public IIRHHTHKMHK GGSEQHMLLKS => null;

	public int QHOQGTRMKHH => 0;

	private void Awake()
	{
	}

	public void Init(int HSLQJLPMLMH, BaseRoomData MHKTHRMFETH, Vector2Int QMHFIQMSKQJ, GameObject HPOGMTGHKGK)
	{
	}

	private bool JOFGQTKSQHS(BaseItemSave HPJMQLRTORF)
	{
		return false;
	}

	private bool ROOIGKOPJIM(BaseItemSave HPJMQLRTORF)
	{
		return false;
	}

	private void NIGNGKRLSSR(BaseItemSave IOGMNEPJEEM)
	{
	}

	public Vector3 Raycast(Ray EMOOJLTPJPP)
	{
		return default(Vector3);
	}

	public void SetupRoomFrame()
	{
	}

	public void ToggleCanBuildState(bool RRPSNPOTQNT)
	{
	}

	public void SetStyle(int NNOIFETRQRP, bool TEENRGPFHKL = true)
	{
	}

	private void QMMJJGQTRPO(BaseItemSave IOGMNEPJEEM)
	{
	}

	public void AdjustForNeighbors()
	{
	}

	public void ToggleWalls(bool RRPSNPOTQNT)
	{
	}

	private void OPRKNQRIJFT(bool RRPSNPOTQNT)
	{
	}

	private void LJOEJSMPTNQ()
	{
	}

	private List<GridLayerData> KQLPTQSKRME(List<int> TGJRKNPHROS)
	{
		return null;
	}

	public List<BaseObject> GetBadItemsAfterWallChange(int SLIEEELQMQS)
	{
		return null;
	}

	private void MKPPRHJNGLL()
	{
	}

	private void OFSIFKPNINS(BaseObject TJFMGSHMGLK, bool PTELSTKTLJT)
	{
	}

	public void StartBuild()
	{
	}

	private void SPRJRTRMJOL()
	{
	}

	public bool HurryBuild()
	{
		return false;
	}

	public void CheckBuildingState()
	{
	}

	public int TimeLeft()
	{
		return 0;
	}

	public void Claim()
	{
	}

	private void IMJKGQLKGST()
	{
	}

	private void KHMPHPMRIIJ()
	{
	}

	private int PGIEHFFQTNI()
	{
		return 0;
	}

	private bool SQEFQPKSRKN()
	{
		return false;
	}

	private void RFHSTMFSIEL()
	{
	}

	public void PlaceObject(BaseObject TJFMGSHMGLK, bool TESGTQPOSFP = false, bool PTELSTKTLJT = true)
	{
	}

	public void UpdateLayoutSave(bool JHREGFINHPQ = true, bool OQMQQNQPMHO = true)
	{
	}

	public void RemovePlaced(BaseObject HNTPNTJRJMH)
	{
	}

	public void StoreObject(BaseObject OLMQNNPQKIH, bool PHFLQMILKTR = false)
	{
	}

	public void UpdateLayout()
	{
	}

	public void TogglePlacedObjectColliders(bool RRPSNPOTQNT, BaseObject EQGSNMQTMGG = null)
	{
	}

	public Vector3 GetRoomCenter()
	{
		return default(Vector3);
	}

	public void OnEnterBuildMode()
	{
	}

	public void OnExitBuildMode()
	{
	}

	private void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}

	private void OnTriggerExit(Collider FKQLEGQSLHF)
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public bool IsBuilt()
	{
		return false;
	}

	[CompilerGenerated]
	private bool KFTOSFPJGKP(Vector2Int GGOKJRGSMRT)
	{
		return false;
	}

	[CompilerGenerated]
	private bool KTFFSKHRJQR(int HSLQJLPMLMH)
	{
		return false;
	}

	[CompilerGenerated]
	private bool SOHJQOQETIS(int HSLQJLPMLMH)
	{
		return false;
	}
}
