using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeeklyContractsPanelVipBlock : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class QMRLOKLMNRN
	{
		public WeeklyContractsPanelActiveQuestElement[] quests;

		public int i;

		public Predicate<Quest> _003C_003E9__1;

		internal bool _003CSetup_003Eb__1(Quest x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RHFNHLOINET
	{
		public WeeklyContractsPanelActiveQuestElement q;

		internal bool _003CSetup_003Eb__0(Quest x)
		{
			return false;
		}
	}

	[SerializeField]
	private WeeklyContractsPanelActiveQuestElement prefabElement;

	[Space]
	[SerializeField]
	private RectTransform elementParent;

	[SerializeField]
	private GameObject stateLocked;

	[SerializeField]
	private GameObject stateAvailable;

	[SerializeField]
	private Text labelBonusContracts;

	[SerializeField]
	private Text labelBonusWeekly;

	[SerializeField]
	private CanvasGroup vipLockedCanvasGroupInternal;

	[SerializeField]
	private RectTransform vipRibbon;

	private bool KILTLTGITJG;

	public event Action<RectTransform> OTSPSJKGGQL
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Setup(bool KQGHGPEKKTJ = false)
	{
	}

	public void Show(bool KQGHGPEKKTJ)
	{
	}

	public void Hide(bool KQGHGPEKKTJ)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LFTPJTESNFK()
	{
	}

	private void SOKFRMGIEIP()
	{
	}

	private void HQLOELPESQK(RectTransform IERIISNIJFH)
	{
	}
}
