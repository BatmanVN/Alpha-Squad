using System;
using System.Runtime.CompilerServices;
using Lean.Touch;
using UnityEngine;

public class BaseInteractable : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KEMPTRNSPES
	{
		public GameObject cachedIndicator;

		internal void _003CHideArrowIndicator_003Eb__0()
		{
		}
	}

	[SerializeField]
	private bool saveState;

	[SerializeField]
	private bool interactOnce;

	public Action onClick;

	private BaseInteractionHelper[] HEQRLNMTNLP;

	private LeanSelectable GEFTMFNMRGR;

	private bool OIQMTRLQRPN;

	protected bool MGQTOQSGMMT;

	private BaseObject TOHRPNGSKFK;

	private GameObject ETFOFKPNQRQ;

	[SerializeField]
	private Vector3 arrowOffset;

	[SerializeField]
	private float arrowReappearDelay;

	[SerializeField]
	protected float minDelayBetween;

	[SerializeField]
	private bool cantInteractManually;

	[SerializeField]
	private SoundEffect fromDefault;

	[SerializeField]
	private SoundEffect toDefault;

	[SerializeField]
	protected bool interactOnTriggerEntered;

	protected float NMSILJTSOJO;

	protected virtual void Awake()
	{
	}

	protected void RPEJRFGMNRK()
	{
	}

	public void SetInteractionState(bool LKKOESPTGSK)
	{
	}

	private void FLIRJMIPTML(bool LKKOESPTGSK)
	{
	}

	public void ToggleMark(bool LKKOESPTGSK)
	{
	}

	protected virtual bool JQKLPSLQSKT()
	{
		return false;
	}

	protected virtual void TGJNNHEOIMM()
	{
	}

	private void IOEKSJSHPJF()
	{
	}

	public void Interact(LeanFinger ENHLRTGLJGO)
	{
	}

	protected virtual void NRLIMJNHLQH()
	{
	}

	protected virtual void GRFNSHMMLIN()
	{
	}

	protected virtual bool JREQIMMFEKS()
	{
		return false;
	}

	protected void FJOGLSMSEKT()
	{
	}

	public void ResetInteractionState()
	{
	}

	public void DisableScriptAnimations()
	{
	}

	protected virtual void OnTriggerEnter(Collider FKQLEGQSLHF)
	{
	}
}
