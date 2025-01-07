using System.Collections.Generic;
using UnityEngine;

namespace Gear
{
	[CreateAssetMenu]
	public class GearResourceReference : ScriptableObject
	{
		public List<JJHFPNTSRLT.GearCategorySprite> gearCategoryIcons;

		public List<JJHFPNTSRLT.GearBonusSprite> gearBonusIcons;

		public Sprite defaultBonusIcon;
	}
}
