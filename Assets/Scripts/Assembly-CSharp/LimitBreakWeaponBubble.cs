using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LimitBreakWeaponBubble : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MJLRJMNGTNE
	{
		public JJHFPNTSRLT.WeaponPartIdentifier weaponPart;

		public CurrencyData.WeaponParts allWeaponParts;

		internal bool _003CGetWeaponWithLimitBreak_003Eb__1(LootElement x)
		{
			return false;
		}
	}

	[SerializeField]
	private GameObject lbWeaponBubbleParent;

	[SerializeField]
	private RectTransform lbWeaponBubble;

	[SerializeField]
	private Image lbWeaponIcon;

	public void Setup(JJHFPNTSRLT.WeaponPartIdentifier PLKFROSLRHP, bool EJTGQSOIOHP = false)
	{
	}

	private ItemWeapon RTMFRQHRTQI(JJHFPNTSRLT.WeaponPartIdentifier TPIFTOPNRHQ)
	{
		return null;
	}

	public void ShowLimitBreakWeapon(ItemWeapon MGRTOPLOHGM)
	{
	}

	public void HideLimitBreakWeapon()
	{
	}

	public bool IsVisible()
	{
		return false;
	}
}
