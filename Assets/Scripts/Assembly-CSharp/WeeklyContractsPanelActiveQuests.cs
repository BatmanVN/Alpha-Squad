using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WeeklyContractsPanelActiveQuests : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ONPNINMTORJ
	{
		public WeeklyContractsPanelActiveQuestElement[] quests;

		public int i;

		public Predicate<Quest> _003C_003E9__2;

		internal bool _003CSetup_003Eb__2(Quest x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NTOJISESTOM
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
	private UITextTimer resetTimer;

	[SerializeField]
	private Text labelCompleted;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private GameObject rerollButton;

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

	public void SetSpinnerEnabled(bool LLFOSOHGPNO)
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

	public void OnTimerUp()
	{
	}

	private void HQLOELPESQK(RectTransform IERIISNIJFH)
	{
	}
}
