using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuChestCardDrop : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class JMEPRHHRSTK
	{
		public MenuChestCardDrop _003C_003E4__this;

		public LootElement chestReward;

		public RectTransform spawnLocation;

		public RectTransform endLocation;

		internal void _003CPlaySpecial_003Eb__0()
		{
		}
	}

	[SerializeField]
	private CardCellVisual visual;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Text labelTitle;

	public UnityEvent OnAnimEnd;

	public UnityEvent OnCardArrived;

	public UnityEvent OnPlay;

	private Tween GJTGRKJEOJT;

	private Tween LGKPKHEFOPR;

	public LootElement lootElement;

	private bool EQHFHEQRGEK;

	private bool REKLQTFLFIK;

	public void Play(LootElement NTFLTHQSIJT, RectTransform ERSMQMITGIH, RectTransform LMSTHSSIGKP, bool EKJPLTPEKLE = false)
	{
	}

	public void PlaySpecial(LootElement NTFLTHQSIJT, RectTransform ERSMQMITGIH, RectTransform LMSTHSSIGKP, float PRRKGRQILFR)
	{
	}

	public void ResetMoveTween()
	{
	}

	private void ERKRELEQRNR()
	{
	}

	public void OnCardAnimationEnd()
	{
	}

	public void SpeedUp()
	{
	}

	private void TPTOMRNMJKF()
	{
	}

	private void RMHRTPSLKGQ()
	{
	}

	public void Hide()
	{
	}

	private void OTKFERFLMQN()
	{
	}
}
