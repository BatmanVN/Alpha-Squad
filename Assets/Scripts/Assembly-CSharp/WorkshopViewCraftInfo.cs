using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class WorkshopViewCraftInfo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GMQGKHSPNSK
	{
		public JJHFPNTSRLT.PQRIQGIOGQT r;

		public Func<JJHFPNTSRLT.RarityNumber, bool> _003C_003E9__0;

		internal bool _003CShowFloatingUnlockText_003Eb__0(JJHFPNTSRLT.RarityNumber x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class ESSMROSTOMN
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		internal bool _003CSetupInitial_003Eb__2(JJHFPNTSRLT.RarityNumber x)
		{
			return false;
		}

		internal bool _003CSetupInitial_003Eb__3(JJHFPNTSRLT.RarityNumber x)
		{
			return false;
		}
	}

	[NonSerialized]
	public WorkshopPanel owner;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private CanvasGroup background;

	[Space]
	[SerializeField]
	private Text labelWorkshopLevel;

	[SerializeField]
	private List<GameObject> chanceValueBlocks;

	[SerializeField]
	private List<GameObject> raritySelectButtons;

	[Space]
	[SerializeField]
	private Text labelTitlePerks;

	[SerializeField]
	private WorkshopSelectGearCell prefabPerkCell;

	[SerializeField]
	private RectTransform parentCells;

	[SerializeField]
	private ScrollRectEx scroll;

	[SerializeField]
	private GameObject blockInfo;

	private JJHFPNTSRLT.PQRIQGIOGQT KJOFHLHKOGK;

	private JJHFPNTSRLT.PQRIQGIOGQT PLPEQLOEQGK;

	private KNSKIMFQMTH QQKJLIFKMHM;

	private void NGHFQRREIJN()
	{
	}

	public void OnSelectRarity(int MOTTITEELQF)
	{
	}

	private void PEGISQMNESI(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
	}

	private GameObject NRILEQLKSJT(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return null;
	}

	private void TSFMPLRPNLS()
	{
	}

	private void NLOEQPKIQGK()
	{
	}

	public void Show(WorkshopRecipe LQKPOLSLLJQ)
	{
	}

	public void Hide()
	{
	}

	public void OnCloseButton()
	{
	}

	[CompilerGenerated]
	private void QFLJLSTQKOK()
	{
	}
}
