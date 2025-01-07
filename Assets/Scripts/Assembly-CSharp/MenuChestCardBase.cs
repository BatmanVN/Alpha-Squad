using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MenuChestCardBase : MonoBehaviour
{
	[Utils.ReadOnly]
	public LootElement chestReward;

	[SerializeField]
	private GameObject boostedParticles;

	[SerializeField]
	private GameObject explosionParticles;

	[SerializeField]
	private RectTransform visualBlock;

	[SerializeField]
	private Image glow;

	private Animator JFKTSHNOIKP;

	private LootElement HRMLMNNFKSF;

	private LootElement EGLSRLSPNSO;

	protected virtual void Awake()
	{
	}

	public virtual void Setup(LootElement FILOKRMHOJJ)
	{
	}

	public virtual void UpdateData(LootElement FILOKRMHOJJ)
	{
	}

	public virtual void AnimateUpdate(LootElement GSJNPHNGPLM)
	{
	}

	public void Highlight(bool QHSMPFPKNMM)
	{
	}

	public void Hide(bool KQGHGPEKKTJ = true, float PRRKGRQILFR = 0.1f)
	{
	}

	public void Show(bool KQGHGPEKKTJ = true, float PRRKGRQILFR = 0f)
	{
	}

	private void QMHFNEQOQTE()
	{
	}

	public bool TryUpdate(LootElement INNLJIGRFOG)
	{
		return false;
	}

	public void SetAnimatorSpeed(float OHGGOMMGTIP)
	{
	}

	public bool WillBeBoosted(LootElement INNLJIGRFOG)
	{
		return false;
	}

	public string GetCustomIdentifier()
	{
		return null;
	}

	public void OnBoostUpdateValues()
	{
	}

	public void OnBoostAnimCompleted()
	{
	}

	[CompilerGenerated]
	private void OJFPPHOJETT()
	{
	}
}
