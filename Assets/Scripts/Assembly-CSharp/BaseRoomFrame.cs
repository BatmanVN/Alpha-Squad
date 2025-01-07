using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BaseRoomFrame : MonoBehaviour
{
	[Serializable]
	public class AffectedObjects
	{
		public List<GameObject> enableOnBuilt;

		public List<GameObject> disableOnBuilt;

		public void OTOSINMGSPK(bool RRPSNPOTQNT = true)
		{
		}
	}

	[SerializeField]
	private MeshRenderer floorRenderer;

	[SerializeField]
	private List<MeshRenderer> wallRenderers;

	[SerializeField]
	private List<GameObject> hideableWalls;

	[SerializeField]
	private GameObject stateBuilt;

	[SerializeField]
	private GameObject stateBuilding;

	[SerializeField]
	private GameObject stateCanBuild;

	private Material LSTQIRHMOOJ;

	private Material SGITPFTKIQK;

	private BaseRoomData TSRPFHOJKSG;

	private Queue<int> HTFNMFJFEHL;

	private bool OLTHGRKITON;

	private static int ENHJESIKNPH;

	private static int EELENSEGHQQ;

	private int PLLPNRRLKHP;

	[SerializeField]
	private SerializableDictionary<BaseRoomData.FLRJREHIJKL, AffectedObjects> onRoomState;

	public void Setup(BaseRoomData MHKTHRMFETH)
	{
	}

	private void ESSHOIGNMIG()
	{
	}

	private static void TTJETSOHLRI()
	{
	}

	private bool KESHGJEENGL()
	{
		return false;
	}

	public void SetStyle(int NNOIFETRQRP, bool TEENRGPFHKL = false)
	{
	}

	private void JGJMFFGGNFP()
	{
	}

	public void ToggleWalls(bool LKKOESPTGSK)
	{
	}

	public void ToggleCanBuildState(bool RRPSNPOTQNT)
	{
	}

	private void LHMHNEMNOHI()
	{
	}

	private void QHKTKSLPREK()
	{
	}

	private void LPNJQOENMMN()
	{
	}

	private void TGJISRSLIHH()
	{
	}

	public void PlayClaimAnimation()
	{
	}

	[CompilerGenerated]
	private IEnumerator FPSOGKNLJNM()
	{
		return null;
	}
}
