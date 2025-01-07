using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RiftsPanelFloorElement : MonoBehaviour
{
	private enum SSKHRIKOMRF
	{
		UNSET = 0,
		LOCKED = 1,
		UNLOCKED = 2,
		COMPLETED = 3,
		COLLECT = 4
	}

	[CompilerGenerated]
	private sealed class SJONKLNQKLF
	{
		public RiftsPanelFloorElement _003C_003E4__this;

		public bool first;

		internal void _003CPlayUnlockAnimation_003Eb__0()
		{
		}

		internal void _003CPlayUnlockAnimation_003Eb__1()
		{
		}
	}

	[SerializeField]
	private GameObject prefabClaimParticles;

	[SerializeField]
	private GameObject prefabRiftsLock;

	[SerializeField]
	private Sprite spriteBackgroundRegular;

	[SerializeField]
	private Sprite spriteBackgroundStart;

	[SerializeField]
	private Sprite spriteBackgroundTimeSuccess;

	[SerializeField]
	private Sprite spriteBackgroundTimeFail;

	[Space]
	[SerializeField]
	private Image background;

	[SerializeField]
	private Button button;

	[SerializeField]
	private Image blockClear;

	[SerializeField]
	private Text labelFloor;

	[SerializeField]
	private Text labelFloorLocked;

	[SerializeField]
	private Text labelClear;

	[SerializeField]
	private Text labelEnemyLevelCenter;

	[SerializeField]
	private GameObject overlayLocked;

	[SerializeField]
	private DeselectButton doubleTap;

	[SerializeField]
	private GameObject lockIcon;

	[SerializeField]
	private Transform particlesClaimParent;

	[SerializeField]
	private Transform riftLockParent;

	[SerializeField]
	private GameObject blockRecommended;

	private SSKHRIKOMRF KFMKSFHTNIL;

	private int EERRGHKNKNK;

	private bool PKGLSMJOJOT;

	public static readonly int ANIM_LOCK_UNLOCK;

	public static readonly int ANIM_LOCK_UNLOCK_SPECIAL;

	public event Action<int> MNPOEKJLNQM
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

	public void Setup(int JTRTLOSKQIT)
	{
	}

	public void SetupWithHighestFloor(int JTRTLOSKQIT, int RNPFHRLMPPG, int FHOOGITQKOE)
	{
	}

	private SSKHRIKOMRF MOLLQITEILG(int GHMJOHENJMQ, int FHOOGITQKOE)
	{
		return default(SSKHRIKOMRF);
	}

	public void ClearParticles()
	{
	}

	public void Refresh()
	{
	}

	public Tween PlayUnlockAnimation(bool JQSENNJINNM = false)
	{
		return null;
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public int GetFloor()
	{
		return 0;
	}

	public void OnSelect()
	{
	}

	public void OnDeselect()
	{
	}

	public void OnStartButton()
	{
	}
}
