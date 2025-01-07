using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TripleOfferClaimPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class PTIHSKLSNNO
	{
		public SmallCellVisual cell;

		public TripleOfferClaimPopup _003C_003E4__this;

		internal void _003CInitCustom_003Eb__0()
		{
		}
	}

	[SerializeField]
	private GameObject prefabParticles;

	[SerializeField]
	private GameObject prefabGlitter;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private Text title;

	[SerializeField]
	private LootListLayoutRowsNewCells lootVisuals;

	[SerializeField]
	private float titleUpperPosition;

	[SerializeField]
	private float titleLowerPosition;

	[SerializeField]
	private RectTransform particlesParent;

	public static bool CanShow;

	private bool QFJRLNGEEEP;

	private bool QFGNQGLPOKN;

	public static void Open(LootList OPHQESJTOLF, string RKJTFRTJSIR)
	{
	}

	public static void OpenCustom(LootList OPHQESJTOLF, string OLPSGPIMEJE, bool TJFLNFQIRMJ = false, bool JEPRTELNILG = false)
	{
	}

	private void MLNESSGJRME(LootList OPHQESJTOLF, string RKJTFRTJSIR)
	{
	}

	private void FIKRFSFPOGK(LootList OPHQESJTOLF, string GTPEOKJIJFE, bool TJFLNFQIRMJ = false, bool JMILPTPIOKE = false)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void OnOkButton()
	{
	}
}
