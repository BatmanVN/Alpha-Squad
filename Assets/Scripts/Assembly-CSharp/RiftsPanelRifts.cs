using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RiftsPanelRifts : RiftsPanelView
{
	[Serializable]
	private struct Data
	{
		public int lastHighestFloor;

		public int lastHighestCompletedFloor;
	}

	[CompilerGenerated]
	private sealed class SLKITLTPGIR
	{
		public int tempCBracket;

		public float scrollT;

		public RiftsPanelRifts _003C_003E4__this;

		internal void _003CPlayRiftProgressedAnimation_003Eb__2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class SNHQHEIIPES
	{
		public int idx;

		internal bool _003CConvertBracketIndexToPage_003Eb__0(RiftsPanelBracketElement x)
		{
			return false;
		}
	}

	private static readonly string JKPNPHQEOKN;

	[SerializeField]
	private RiftsPanelBracketElement prefabBracket;

	[SerializeField]
	private ScrollRectStepped bracketScroll;

	[SerializeField]
	private RectTransform parentBracket;

	[SerializeField]
	private VerticalLayoutGroup bracketsLayout;

	[SerializeField]
	private ContentSizeFitter bracketContentSize;

	private List<RiftsPanelBracketElement> EMITIOKKMGI;

	private bool QOOPLGKOOLG;

	private const bool HEOLTMKNQSH = true;

	private bool HEGLEOTLSTR;

	private Data TSRPFHOJKSG;

	private bool EHFKRJIEEMQ;

	public static void ResetInitialized()
	{
	}

	private void EFTPIHORRKT()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void SetupView(RiftsPanel TNKMMOJJPPI)
	{
	}

	public override void OnEnter()
	{
	}

	private void IQGRIQTKIPI(int OQTTPPIGNGP, int ETJPSQOMKKJ)
	{
	}

	private void LRGSIMEIPJR()
	{
	}

	private void EPOGNKRHSPI()
	{
	}

	private void JJESEFEHGKE()
	{
	}

	private void KLJEPKORMLM()
	{
	}

	private void PMITOIOJNOT()
	{
	}

	public static void ResetData()
	{
	}

	private void NONGLLPRKGK(int STSFGQMGSNP, int EEHLRFERSGN)
	{
	}

	private void SQJQHLITQRT()
	{
	}

	public bool IsAnimationInProgress()
	{
		return false;
	}

	private int RJQOINNERNE(int PNIQKIGEHLF)
	{
		return 0;
	}

	public void OnScrollFinished(int FIPHTRRRPET)
	{
	}

	private void NQOMSTQEHQP(int FIPHTRRRPET)
	{
	}

	[CompilerGenerated]
	private void IFRIQMGHPPG()
	{
	}

	[CompilerGenerated]
	private void NHKFQIEHIJG()
	{
	}
}
