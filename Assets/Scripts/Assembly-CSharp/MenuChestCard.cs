using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MenuChestCard : MonoBehaviour
{
	[SerializeField]
	private CardCellVisual visual;

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

	public virtual void Setup(LootElement FILOKRMHOJJ, bool JEPRTELNILG = false)
	{
	}

	public virtual void UpdateData(LootElement FILOKRMHOJJ)
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

	public bool DoesCardMatchReward(LootElement INNLJIGRFOG)
	{
		return false;
	}

	public bool TryUpdate(LootElement INNLJIGRFOG, bool SGLHNMMIOMT = true)
	{
		return false;
	}

	public void SetAnimatorSpeed(float OHGGOMMGTIP)
	{
	}

	public void ResetAnimator()
	{
	}

	public bool WillBeBoosted(LootElement INNLJIGRFOG, bool SGLHNMMIOMT = true)
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
	private void FEHPMMPLHRO()
	{
	}
}
