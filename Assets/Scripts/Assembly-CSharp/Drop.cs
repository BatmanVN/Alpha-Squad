using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class Drop : MonoBehaviour
{
	public const float START_FLY_RANGE = 5f;

	public const float START_FLY_RANGE_LEVEL_FINISHED_MULTIPLIER = 1.75f;

	public const float PICKUP_RANGE = 0.5f;

	public const float ACCELERATION = 1f;

	public const float UNPICKABLE_TIME = 0.9f;

	public const float AUTOFLY_DELAY = 0.9f;

	protected bool GMKQGHKHMQH;

	protected float OHGGOMMGTIP;

	protected float GQERPTEJKRO;

	private float NSFNHJNKMJP;

	private bool HFIFPFELTHF;

	private bool NJLLEQENKON;

	protected bool HIHGQKHNPSO;

	[SerializeField]
	private bool hasCollisionSfx;

	public SoundEffect dropReach;

	public SoundEffect dropSpawn;

	public SoundEffect startFlying;

	public SoundEffect collisionSfx;

	public GameObject pickupVFX;

	protected float IQKHSMOLOFP => 0f;

	public static event Action<Drop> FHOPJOSENSF
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

	protected virtual void Update()
	{
	}

	private void SPLILPQQENS()
	{
	}

	protected virtual void NJESMSEREEK()
	{
	}

	protected virtual bool HPGJQJPTOLO()
	{
		return false;
	}

	protected void NRRLGQKOLIL()
	{
	}

	protected virtual void OnEnable()
	{
	}

	public void AddToPickupDelay(float OGFKHSKTHHR)
	{
	}

	protected virtual void ELTTJTKTTNH()
	{
	}

	public abstract void GiveReward(DropController.DropsCollection SMKIJLNPSMP);

	public abstract void SaveReward(DropController.DropsCollection SMKIJLNPSMP);

	public virtual bool CanSaveReward()
	{
		return false;
	}

	public virtual void SetCanSaveReward()
	{
	}

	public void SetGaveReward()
	{
	}

	protected virtual bool SETMEPFOHKK()
	{
		return false;
	}

	protected virtual bool TLGTRQERNTT()
	{
		return false;
	}

	private void IMISMKQKROM()
	{
	}
}
