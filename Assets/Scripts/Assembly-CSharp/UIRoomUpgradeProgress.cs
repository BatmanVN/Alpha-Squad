using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIRoomUpgradeProgress : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ORLQQJMROHT
	{
		public UIRoomUpgradeProgress _003C_003E4__this;

		public int timeRequired;

		public int timeRemaining;

		public Color cUpdate;

		public Color cFinal;

		public Action onTimerUp;

		internal void _003CSetup_003Eb__2()
		{
		}

		internal void _003CSetup_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class OMTOFENPOEJ
	{
		public int previousTimer;

		public ORLQQJMROHT CS_0024_003C_003E8__locals1;

		internal void _003CSetup_003Eb__1(float x)
		{
		}
	}

	[SerializeField]
	private UITextTimer timer;

	[SerializeField]
	private Image fill;

	private Tween HSIETHRIJTS;

	private bool JEPRTELNILG;

	public void Setup(int FIKEOQTLFIP, int QFGENSTHNMR, Action SFKPJNTQOIP = null)
	{
	}

	public void AnimateNextSetup()
	{
	}
}
