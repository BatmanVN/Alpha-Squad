using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Expedition;
using UnityEngine;

public class ExpeditionLevelRewardList : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GKINLGIEPEG
	{
		public ExpeditionLevelRewardList _003C_003E4__this;

		public ExpeditionData.ExpeditionRewardSingle rewData;

		public Action<RRMFSKNJIOH> _003C_003E9__6;

		internal void _003CClaimReward_003Eb__1()
		{
		}

		internal void _003CClaimReward_003Eb__2()
		{
		}

		internal void _003CClaimReward_003Eb__3()
		{
		}

		internal void _003CClaimReward_003Eb__6(RRMFSKNJIOH x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class PQRGSFNIEPQ
	{
		public ChestOpenPopup chestPopup;

		public GKINLGIEPEG CS_0024_003C_003E8__locals1;
	}

	[SerializeField]
	private UICurrencyElement prefabLoot;

	[SerializeField]
	private CellExpeditionCustom prefabCustom;

	[SerializeField]
	private CellExpeditionChest prefabChest;

	[SerializeField]
	private GambleRandom prefabRandom;

	[SerializeField]
	private CellGameOver prefabDefaultLoot;

	[SerializeField]
	private GameObject prefabClaimed;

	[SerializeField]
	private RectTransform cellParent;

	[SerializeField]
	private CanvasGroup cg;

	[NonSerialized]
	public ExpeditionLevelCell owner;

	private ExpeditionPanel TGSOSNJRHGI;

	private List<Transform> LJHQJMJQINE;

	private List<ExpeditionData.ExpeditionRewardSingle> RMPGHRNTQFN;

	public void Setup(ExpeditionData.ExpeditionLevel TSRPFHOJKSG, bool SPELFKQJMIJ = false, bool NRKSERSOKKP = true, bool ESPKSFLQFIM = true)
	{
	}

	private void MSKKFTMRLFN(ExpeditionData.ExpeditionRewardSingle QFJFSEMOOEH, bool SPELFKQJMIJ, bool NRKSERSOKKP)
	{
	}

	public Sequence PlayClaimAnimation()
	{
		return null;
	}

	private void SJGEQPGLGQJ(Transform HRNFSTRKHFP, ExpeditionData.ExpeditionRewardSingle KHNJRSPENIL, Sequence STRHRQLNREP)
	{
	}

	public void AssignExpeditionPanel(ExpeditionPanel LKPTTJHGQFT)
	{
	}
}
