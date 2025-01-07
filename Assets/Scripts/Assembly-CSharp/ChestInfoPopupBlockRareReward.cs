using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChestInfoPopupBlockRareReward : MonoBehaviour
{
	[Serializable]
	protected struct WeaponBlock
	{
		public Image background;

		public WeaponRarityStars stars;

		public Text chance;

		public GameObject block;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct IQEGJHMOJTJ
	{
		public ChestInfoPopupBlockRareReward _003C_003E4__this;

		public Sequence seq;
	}

	[CompilerGenerated]
	private sealed class QPJNIJJHHLR
	{
		public JJHFPNTSRLT.PQRIQGIOGQT r;

		internal bool _003CSetupWeaponBlock_003Eb__0(JJHFPNTSRLT.RaritySprite x)
		{
			return false;
		}
	}

	[SerializeField]
	private WeaponBlock[] weaponBlocks;

	[SerializeField]
	private RectTransform blockParent;

	private int KSJFGIKEEEI;

	private List<float> TTQQRNSRPFP;

	private Sequence GJTGRKJEOJT;

	public void Setup(bool MSQSLHMQJTM, ChestController.ChestData IEHEOOQKSKK)
	{
	}

	private void OnDisable()
	{
	}

	private void RRKMHRJLOPL(float LGHKISKQTON, JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL, WeaponBlock QIMGEOQLLHO)
	{
	}

	private WeaponBlock LONJSPNMTPO()
	{
		return default(WeaponBlock);
	}

	private void SPFJHGMKIIF()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	[CompilerGenerated]
	private void JTJFEPQPILK(float SKOJGTGOPIF, bool LEMPSIFLGIE, ref IQEGJHMOJTJ P_2)
	{
	}
}
