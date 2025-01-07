using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GJKPFOLQQIR
	{
		public BaseLevelUpPopup lvlUpPopup;

		public TotalPrestigePopover prestigePopover;
	}

	public static BaseManager Instance;

	public static Action<int, GameObject> OnObjectLoaded;

	public static Action<bool> OnEnterBuildMode;

	public static Dictionary<int, MJRLTPKPHKE> loadObjects;

	[NonSerialized]
	public bool interactionsAllowed;

	public BaseBuilder Builder;

	public BaseRoomManager RoomManager;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void GTORLJTJJKT()
	{
	}

	private void HNPGFKNOLRF()
	{
	}

	private void QTIQMQSPIHI()
	{
	}

	private IEnumerator MFGMLSQEHEN()
	{
		return null;
	}

	private void OIEEETEHSJI()
	{
	}

	public void TryToShowRoomUnlock()
	{
	}

	public void Exit()
	{
	}

	public void EnterBuildMode()
	{
	}

	public void ExitBuildMode()
	{
	}

	private void NPOOSSRMMJR()
	{
	}

	private void OOFNSLOIQHO()
	{
	}

	private void NJPGIPPLNNI()
	{
	}

	private void THROMMPRRES(bool LKKOESPTGSK)
	{
	}

	private void HKQIIHJEGPP()
	{
	}

	private void LGRNENMFEIG(int SLIEEELQMQS)
	{
	}

	public BaseBuilder GetBaseBuilder()
	{
		return null;
	}

	public void StartBuilding(BaseItemSave IOGMNEPJEEM)
	{
	}

	public void OnPrestigeChange()
	{
	}

	public void LoadObjectVisual(int PNKSKFFMKMF)
	{
	}

	public bool IsObjectLoaded(int HSLQJLPMLMH)
	{
		return false;
	}

	public bool IsObjectLoading(int HSLQJLPMLMH)
	{
		return false;
	}

	public GameObject GetBaseObject(int HSLQJLPMLMH)
	{
		return null;
	}

	public void ClearLoaded()
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}
}
