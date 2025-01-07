using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIEventGameGiftboxesElement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PFPJPEJLHHH
	{
		public UIEventGameGiftboxesElement _003C_003E4__this;

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
	private sealed class RGRNSKGKLJP
	{
		public JJHFPNTSRLT.PQRIQGIOGQT crarity;

		public int pnow;

		public int total;

		public int totalNow;

		public JJHFPNTSRLT.PQRIQGIOGQT particlesRarity;

		public PFPJPEJLHHH CS_0024_003C_003E8__locals1;

		internal void _003CAnimateUpdate_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class EMJIMMGGLPM
	{
		public UIEventGameGiftboxesElement _003C_003E4__this;

		public int total;

		public int from;

		public int to;

		public Transform lbt;

		internal void _003CAnimateProgress_003Eb__0(float x)
		{
		}

		internal void _003CAnimateProgress_003Eb__1()
		{
		}
	}

	[NonSerialized]
	public UIEventGameGiftboxes owner;

	[SerializeField]
	private List<Sprite> rarityStyles;

	[Space]
	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image iconCompleted;

	[SerializeField]
	private Image iconBackground;

	[SerializeField]
	private Text labelProgress;

	[SerializeField]
	private SlicedFilledImage fillProgress;

	[SerializeField]
	private Button buttonMe;

	[Space]
	[SerializeField]
	private GameObject blockNotProgressed;

	[SerializeField]
	private GameObject blockProgressed;

	[SerializeField]
	private GameObject blockCompleted;

	[SerializeField]
	private GameObject blockProgressBar;

	[SerializeField]
	private GameObject buttonClaim;

	[SerializeField]
	private CanvasGroup upgradeBlock;

	[SerializeField]
	private Transform particleParent;

	[SerializeField]
	private Animation blik;

	private int FQTFHFKTINO;

	private int KTSLJKHTQLE;

	private int SIKJQIGQNEE;

	private JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF;

	private OFQPGEJLJMO.GiftboxData TSRPFHOJKSG;

	private bool ORRSINPMFFO;

	private int OOHOPKRREJM;

	private bool SKPJGQJPHMQ;

	public Action<UIEventGameGiftboxesElement> OnClaim;

	private Sequence JJGOHFGSSFS;

	private Tween MKKIGIMMQEG;

	private global::HIJIFHMGTTR<Vector3> MTOSOSLJNFG;

	private int PSPJIJNTMOI;

	private Func<int, bool> TPHQOESRQSL;

	private Func<int, bool> HLSLKFQEHEE;

	private Func<int, bool> HKKORTFIEIP;

	public bool Setup(OFQPGEJLJMO.GiftboxData MTLGKNIHTMR, int NGLJJHHTQTH, int QFOPFRIRJGQ, Func<int, bool> PFGGJISLTRM, Func<int, bool> KIJGRGIMNPN, Func<int, bool> RORGGJFQOJL, bool OKHOPSIQOEQ = false, float PRRKGRQILFR = 0f)
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

	private void MOFGHHEHMSJ()
	{
	}

	public bool DidProgress(int NGLJJHHTQTH)
	{
		return false;
	}

	public int GetIndex()
	{
		return 0;
	}

	public void ResetState()
	{
	}
}
