using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPathRewardRow : MonoBehaviour, OEIIQMSMROS
{
	[SerializeField]
	private PlayerPathRewardCell cellPremium;

	[SerializeField]
	private PlayerPathRewardCell cellPaid;

	[SerializeField]
	private PlayerPathRewardCell cellFree;

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private RectTransform transformLevel;

	[SerializeField]
	private GameObject lineAvailable;

	[SerializeField]
	private GameObject levelVisualAvailable;

	[SerializeField]
	private GameObject levelVisualUnavailable;

	[SerializeField]
	private GameObject separator;

	private bool TFRPFFEHQPR;

	private int KFQJTSHPRGJ;

	private int PSPJIJNTMOI;

	public event Action<TMRSFTIETMS.EEPIMQTNTOF> LROMHSPRTNF
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

	public void UpdateToClaimable()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public void Deactivate()
	{
	}

	public void Activate()
	{
	}

	public void Setup(int QFOPFRIRJGQ, bool OHKSJJPQSOR, bool JEPRTELNILG = false)
	{
	}

	public void Resetup(bool OHKSJJPQSOR, bool JEPRTELNILG = false)
	{
	}

	private void PTJGNNQKTTQ(bool JEPRTELNILG, bool MPIHKMGOKPF)
	{
	}

	public void OnRewardFreeClick()
	{
	}

	public void OnRewardPaidClick()
	{
	}

	public void OnRewardPremiumClick()
	{
	}

	private void GMPSRGRRPSH(TMRSFTIETMS.EEPIMQTNTOF OSOHKTSGQFR)
	{
	}

	private void RHHLPMJSRLQ(LootIdentifier KNPQOIKEPKI)
	{
	}

	public RectTransform GetLevelTransform()
	{
		return null;
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	public int GetLevel()
	{
		return 0;
	}

	public void PlayAvailableAnimation()
	{
	}

	public void SetSeparatorVisible(bool QPNIRNRNJON)
	{
	}
}
