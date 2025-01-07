using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class MiniOfferBase : MonoBehaviour
{
	[SerializeField]
	protected string titleLocalization;

	private bool OFGPIRTOLLS;

	private CanvasGroup NHMETPLFHPS;

	private string MOPJNHLRGFG;

	public string RKJTFRTJSIR
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public event Action<MiniOfferBase> LIROOIFKKJT
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

	public abstract void Init();

	private void Awake()
	{
	}

	public CanvasGroup GetCanvasGroup()
	{
		return null;
	}

	private void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void KILSLLMGMPG(bool SILMTFJJQIJ)
	{
	}

	public abstract void OnClick();

	public abstract bool ShouldShow();

	public virtual void OnTimerEnded()
	{
	}

	protected virtual bool RRKSJSSPQES()
	{
		return false;
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual string GetOfferTitle()
	{
		return null;
	}
}
