using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChristmasGiftBox : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NJFKNQOLSTM
	{
		public ChristmasGiftBox _003C_003E4__this;

		public Vector3 scale;

		public JJHFPNTSRLT.PQRIQGIOGQT rarityNew;

		public int rmProgNew;

		public int nextStepNew;

		internal void _003CAnimateUpdate_003Eb__0()
		{
		}

		internal void _003CAnimateUpdate_003Eb__1()
		{
		}

		internal void _003CAnimateUpdate_003Eb__2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class OKPNHEROOPI
	{
		public JJHFPNTSRLT.PQRIQGIOGQT crarity;

		public int pnow;

		public int total;

		public int totalNow;

		public JJHFPNTSRLT.PQRIQGIOGQT particlesRarity;

		public NJFKNQOLSTM CS_0024_003C_003E8__locals1;

		internal void _003CAnimateUpdate_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class ISJJLTRMIFE
	{
		public ChristmasGiftBox _003C_003E4__this;

		public int total;

		public int from;

		public int to;

		public Transform lbt;

		internal void _003CAnimateProgress_003Eb__0(float x)
		{
		}
	}

	[NonSerialized]
	public ChristmasTree owner;

	[SerializeField]
	public List<Sprite> rarityStyles;

	[Space]
	[SerializeField]
	public Image icon;

	[SerializeField]
	public Image iconCompleted;

	[SerializeField]
	public Image iconBackground;

	[SerializeField]
	public Text labelProgress;

	[SerializeField]
	public SlicedFilledImage fillProgress;

	[SerializeField]
	public Button buttonMe;

	[Space]
	[SerializeField]
	public bool hideNotProgressedWhenCompleted;

	[SerializeField]
	public GameObject blockNotProgressed;

	[SerializeField]
	public GameObject blockProgressed;

	[SerializeField]
	public GameObject blockCompleted;

	[SerializeField]
	public GameObject blockProgressBar;

	[SerializeField]
	public GameObject buttonClaim;

	[SerializeField]
	public Transform particleParent;

	[SerializeField]
	public Animation blik;

	private int FQTFHFKTINO;

	private int KTSLJKHTQLE;

	private int SIKJQIGQNEE;

	private JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF;

	private OFQPGEJLJMO.GiftboxData TSRPFHOJKSG;

	private bool ORRSINPMFFO;

	private int OOHOPKRREJM;

	private bool SKPJGQJPHMQ;

	private Sequence JJGOHFGSSFS;

	private global::HIJIFHMGTTR<Vector3> MTOSOSLJNFG;

	private int PSPJIJNTMOI;

	public bool Setup(OFQPGEJLJMO.GiftboxData MTLGKNIHTMR, int NGLJJHHTQTH, int QFOPFRIRJGQ, bool OKHOPSIQOEQ = false, float PRRKGRQILFR = 0f)
	{
		return false;
	}

	public Transform GetParticleParent()
	{
		return null;
	}

	private void MLRHQOFSQNK(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL, int MEJNONOTLHH, int TTQJIMSGTGL, int MJPKLHHTJTJ)
	{
	}

	private void HEPONFGEFMO(Sequence IHQSPPEFGNK, float PRRKGRQILFR)
	{
	}

	private void IMMPGEILLLF(JJHFPNTSRLT.PQRIQGIOGQT MQNTRRISIKG, JJHFPNTSRLT.PQRIQGIOGQT QFGMTQNTHSG, int FQPHTJMILGO, int GNSPFILJHFT, int IJHKSRJOFNO, int JMQKLLQPTSF, float PRRKGRQILFR)
	{
	}

	private Sequence PSJLTKEHLMQ(int EESTGTGKLJG, int NJLTOMFTSHK, int MJPKLHHTJTJ, float OGFKHSKTHHR)
	{
		return null;
	}

	private Vector3 QNJFNMGIGGN()
	{
		return default(Vector3);
	}

	public bool IsGoingToAnimate(int OQSSISRTFKL)
	{
		return false;
	}

	public void OnClaimButton()
	{
	}

	public void OnBlikAnimationFinished()
	{
	}

	private void JJTRQNLMSNL()
	{
	}
}
