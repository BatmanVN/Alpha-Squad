using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Server;
using UnityEngine;
using UnityEngine.UI;

public class DataView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NFOEFKPKTQL
	{
		public Loadout loadout;

		internal bool _003CSetup_003Eb__3(Agent x)
		{
			return false;
		}

		internal bool _003CSetup_003Eb__4(ItemWeapon x)
		{
			return false;
		}
	}

	[SerializeField]
	private Text xpText;

	[SerializeField]
	private Text levelText;

	[SerializeField]
	private Image levelProgressFill;

	[SerializeField]
	private Text combatPowerText;

	[SerializeField]
	private UIPlayerPreview agentPreview;

	public void Setup(List<CloudController.FKJTHFJMIEF> TSRPFHOJKSG)
	{
	}
}
