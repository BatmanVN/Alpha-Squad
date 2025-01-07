using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EnhancementInfoBlock : MonoBehaviour
{
	public enum NPRLGKJKSKQ
	{
		LOCKED = 0,
		UNLOCKED = 1,
		SELECTED = 2,
		UNAVAILABLE = 3
	}

	[CompilerGenerated]
	private sealed class MOSQORHINET
	{
		public float vPrevious;

		public float vNew;

		public EnhancementInfoBlock _003C_003E4__this;

		public string valueFormat;

		public int sizeDefault;

		public int sizeMax;

		public Color colorDefault;

		public Color colorMax;

		internal void _003CAnimateValueUpgrade_003Eb__0(float x)
		{
		}
	}

	[SerializeField]
	private Text labelEnhancementTitle;

	[SerializeField]
	private GameObject blockGlobal;

	[SerializeField]
	private Text labelEnhancementInfo;

	[SerializeField]
	private Text labelEnhancementUpgradeValue;

	[SerializeField]
	private GameObject enhancementUpgradeBlock;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image selectedIcon;

	[SerializeField]
	private GameObject personalProgressBlock;

	[SerializeField]
	private Image personalProgressBlockFill;

	[SerializeField]
	private Image personalProgressBlockFillImage;

	[SerializeField]
	private Text personalProgressBlockLabel;

	[SerializeField]
	private Sprite spriteBarRegular;

	[SerializeField]
	private Sprite spriteBarMaxLvl;

	[SerializeField]
	private GameObject bottomBlock;

	[SerializeField]
	private GameObject buttonImprint;

	[SerializeField]
	private GameObject blockImprinted;

	[SerializeField]
	private GameObject blockUnavailable;

	[SerializeField]
	private GameObject blockLocked;

	public Action<EnhancementInfoBlock> OnSelected;

	private Agent IFLMHEQTKLS;

	private EnhancementData FPLLNERNQOM;

	private int FOQIJNNSRNI;

	private int PSPJIJNTMOI;

	private NPRLGKJKSKQ MJPJLPIKQFE;

	public void Setup(EnhancementData KRSKFMNSKII, int JFHKHTINNMG, int QFOPFRIRJGQ, Agent QPRRRRQOSNR, REJQJLNKIGF JQLGIINMGRI, bool NSNERIQSMEL)
	{
	}

	public void SetupPreview(Enhancement JPEEEILROQN, Agent QPRRRRQOSNR, int OHKSIPGFNKF, int KQOPRHOEOMT)
	{
	}

	public void AnimateValueUpgrade(float OGFKHSKTHHR = 0.5f)
	{
	}

	public void OnActivateButton()
	{
	}

	public Transform GetSelectParticlesLocation()
	{
		return null;
	}

	public bool IsSelected()
	{
		return false;
	}
}
