using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpecialActiveBase : MonoBehaviour, SRLPFFRNIOO
{
	protected enum SNPSPNGMQJO
	{
		None = 0,
		Preparing = 1,
		Active = 2,
		Recovering = 3
	}

	[Serializable]
	public struct ReadyVisualEntry
	{
		public Transform visual;

		public bool scale;
	}

	[CompilerGenerated]
	private sealed class NKSQFTNJIPG
	{
		public ReadyVisualEntry entry;

		internal void _003CSetVisualsActive_003Eb__0()
		{
		}
	}

	protected const float OPGEKIMTNET = 0.25f;

	[SerializeField]
	protected Vector2 specialInterval;

	[SerializeField]
	protected Vector2 distanceLimits;

	[SerializeField]
	protected float prepareDuration;

	[SerializeField]
	protected float duration;

	[SerializeField]
	protected float recoveryDuration;

	[SerializeField]
	protected List<ReadyVisualEntry> readyVisuals;

	[SerializeField]
	protected SoundEffect activateSfx;

	[SerializeField]
	protected bool lookAtTarget;

	[SerializeField]
	private AnimationController.LEMLOFGTTPG animationSet;

	public SoundEffect prepareSpecialSfx;

	protected SNPSPNGMQJO MJPJLPIKQFE;

	protected float HREPMHQLTOL;

	protected float EKFSSTEMLFQ;

	protected Soldier FIRQTKNHJLL;

	protected Animator HMRISTHTFOE;

	protected int TTHFJIGGGIL => 0;

	protected int TJGLGPELQGP => 0;

	protected virtual void MLHRFERJRGK()
	{
	}

	protected virtual void ITNGQTQIRME()
	{
	}

	protected virtual void OLTJKKIHGLK()
	{
	}

	protected virtual void Awake()
	{
	}

	private void EROPPSHMOSP()
	{
	}

	private void MHFNOHPTKKI(Modifications.ModificationData KPERIOFQLEM, bool PEJJOSEKFPK)
	{
	}

	public virtual void SpecialUpdate()
	{
	}

	protected virtual void EKJMGEMHTME(bool SMJFTKGRFLJ)
	{
	}

	protected float JRHNKSPSTGS()
	{
		return 0f;
	}

	public virtual void Process()
	{
	}

	protected void NKNSQHHMEGM(Vector3 PQNITOOPPOG)
	{
	}

	protected void NKNSQHHMEGM(Vector3 PQNITOOPPOG, float PMKRGJSFFES)
	{
	}

	protected virtual void FIQTSIGPJTE()
	{
	}

	public virtual bool ShouldActivate()
	{
		return false;
	}

	protected virtual bool OFJHEIHEGIN()
	{
		return false;
	}
}
