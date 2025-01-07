using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PassLevelList : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class TFMGFEITNLE
	{
		public PassLevelList _003C_003E4__this;

		public int level;

		internal void _003COnBuyLevel_003Eb__0()
		{
		}
	}

	[SerializeField]
	private GameObject prefabLevel;

	[SerializeField]
	private GameObject prefabLock;

	[SerializeField]
	private GameObject prefabLevelCurrent;

	[SerializeField]
	private GameObject prefabFinalSafe;

	[SerializeField]
	private RectTransform lvlParent;

	[NonSerialized]
	public PassPanel owner;

	[SerializeField]
	private RectTransform lineRegular;

	[SerializeField]
	private RectTransform lineLocked;

	[SerializeField]
	private List<Transform> levelTransforms;

	private GameObject IMOGJHOTGNE;

	private RectTransform SPRHMOGLQHP;

	private Button RPKTMQSOKJL;

	private int OFROPHRMOIG;

	private bool KPLHQGRFJMK;

	private void OnGUI()
	{
	}

	public void Setup()
	{
	}

	public Transform GetTransformForIndex(int PNIQKIGEHLF)
	{
		return null;
	}

	private void RIHFIHFSFSG(int NERGMFPHLIM, bool TSKHKJHREOH = false)
	{
	}

	private void SOEKGSPPNQN(int NERGMFPHLIM)
	{
	}

	private void EOEGEOMHEJQ()
	{
	}

	private void JTJFQPTTGKG()
	{
	}

	public void SetupLines()
	{
	}

	private void HTGNNPJJPET()
	{
	}

	public GameObject GetFinalSafe()
	{
		return null;
	}

	public void RepositionFinalSafe()
	{
	}
}
