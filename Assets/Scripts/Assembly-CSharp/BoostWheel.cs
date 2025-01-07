using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class BoostWheel : UIPanel
{
	[Serializable]
	public struct WheelConfig
	{
		public int[] slotRarity;

		public int[] spinChanceWeight;
	}

	private enum HLSISRTHNOQ
	{
		None = 0,
		Idle = 1,
		Spinning = 2,
		FinishedSpinning = 3
	}

	[CompilerGenerated]
	private sealed class IMLGORNKGQE
	{
		public BoostReference.BoostSlot slot;

		public BoostWheel _003C_003E4__this;

		internal void _003COnSpinFinished_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class TSHRHLEGREH
	{
		public BoostWheelBonusItem item;

		public IMLGORNKGQE CS_0024_003C_003E8__locals1;

		internal void _003COnSpinFinished_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class HTGGKMFHIHI
	{
		public int rarity;

		internal bool _003CSetupWheel_003Eb__0(ITTKIKLHHEQ t)
		{
			return false;
		}
	}

	[SerializeField]
	private RectTransform title;

	[SerializeField]
	private RectTransform wheel;

	[SerializeField]
	private WheelSpinner wheelSpinner;

	[SerializeField]
	private CircularLayout circularLayout;

	[SerializeField]
	private RectTransform separatorParent;

	[SerializeField]
	private RectTransform statsContainer;

	[SerializeField]
	private RectTransform wheelCenter;

	[SerializeField]
	private GameObject buttonSpin;

	[SerializeField]
	private GameObject buttonSpinAgainGems;

	[SerializeField]
	private GameObject buttonSpinAgainVip;

	[SerializeField]
	private GameObject buttonSpinAgainAd;

	[SerializeField]
	private GameObject buttonPlay;

	[SerializeField]
	private GameObject buttonNoThanks;

	[SerializeField]
	private Text textSpinAgainGemsPrice;

	[SerializeField]
	private AdFetchSpinner spinAgainSpinner;

	[SerializeField]
	private Image statsContainerGlow;

	[SerializeField]
	private Image[] lights;

	[SerializeField]
	private Image pointer;

	[SerializeField]
	private Image pointerActive;

	public WheelConfig[] wheelConfigs;

	public BoostWheelBonusItem bonusItemPrefab;

	public Transform bonusItemParent;

	public Vector2 spinAccuracyRange;

	public bool randomizeStartRotation;

	private HLSISRTHNOQ MJPJLPIKQFE;

	private BoostReference.BoostSlot[] OEHQRRSGLKQ;

	private int IPOPJSKNTJK;

	private int JHGGOLMGLMM;

	private List<BoostWheelBonusItem> RQGRROKLHNT;

	private List<ITTKIKLHHEQ> IMJGEOGTINP;

	private bool OIJMMKQFNKK;

	protected override void MGKPMPHSLFR()
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	private Tween RLNQJLGIKOK(GameObject GKKFNISSPRI, bool KFMHTTRTIPE = true)
	{
		return null;
	}

	private void Update()
	{
	}

	private int GTRTKOOOOGL()
	{
		return 0;
	}

	public static float Clamp0360(float RJSEPEPHTRJ)
	{
		return 0f;
	}

	private void MHJFLERLFTL()
	{
	}

	public void OnSpinButton()
	{
	}

	public void OnSpeedupButton()
	{
	}

	public void OnButtonSpinGems()
	{
	}

	public void OnButtonSpinAd()
	{
	}

	public void OnButtonSpinAgainVip()
	{
	}

	private void REFQPIKGTSP()
	{
	}

	public void OnButtonNoThanks()
	{
	}

	private void FQINGQTPHLI()
	{
	}

	private void NTTOSEJIPTK()
	{
	}

	private void LILIQGHOJHM()
	{
	}

	private int NMPMTLGPFLM()
	{
		return 0;
	}

	public Tween ShowStatsContainer()
	{
		return null;
	}

	public void HideStatsContainer()
	{
	}

	private void LKEMGORIMKH()
	{
	}

	private static bool KQFSELTGHJG()
	{
		return false;
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public void Close()
	{
	}

	public static string GetBoostTitle(ITTKIKLHHEQ EOOEIROQJOE)
	{
		return null;
	}

	public static string GetBoostDescription(BoostReference.BoostSlot EHEHKSMHOIK)
	{
		return null;
	}

	[CompilerGenerated]
	private void PRGGNOQLHGH(bool SILMTFJJQIJ)
	{
	}
}
