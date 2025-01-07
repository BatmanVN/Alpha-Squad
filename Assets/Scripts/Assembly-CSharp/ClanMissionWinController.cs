using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Nakama;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class ClanMissionWinController : MonoBehaviour
{
	[Serializable]
	public struct AnimParams
	{
		public float scaleDuration;

		public float sizeDuration;

		public float moveDelay;

		public float a;

		public float b;

		public float c;

		public float scaleSize;

		public float glowAlpha;

		public float nonChangePosDuration;

		public float delayOffset;
	}

	public struct FILIROQFIHJ
	{
		public string HSLQJLPMLMH;

		public int PMNGMSRTHLP;
	}

	[CompilerGenerated]
	private sealed class OQGRLSQLRGF
	{
		public ClanMissionWinController _003C_003E4__this;

		public int newScoreInt;

		internal void _003CSetup_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class TNFHFGLRLPO
	{
		public IGroupUserListGroupUser user;

		internal bool _003CSetup_003Eb__2(FILIROQFIHJ u)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class ITKKQLGOEGP
	{
		public ClanMissionWinController _003C_003E4__this;

		public int newPos;

		public int oldScore;

		public int score;

		public Image bg;

		public Image glow;

		public TweenCallback<float> _003C_003E9__5;

		public TweenCallback _003C_003E9__6;

		internal void _003CSetNewScoreAndAnimate_003Eb__5(float v)
		{
		}

		internal void _003CSetNewScoreAndAnimate_003Eb__1(float v)
		{
		}

		internal void _003CSetNewScoreAndAnimate_003Eb__2()
		{
		}

		internal void _003CSetNewScoreAndAnimate_003Eb__6()
		{
		}
	}

	[CompilerGenerated]
	private sealed class NJPEQOLJQKO
	{
		public float intervalDuration;

		public ITKKQLGOEGP CS_0024_003C_003E8__locals1;

		internal void _003CSetNewScoreAndAnimate_003Eb__3()
		{
		}
	}

	private List<FILIROQFIHJ> QGPKEFFEGPL;

	public ClanLeagueWinPlayerElement prefab;

	public RectTransform listTransform;

	public int debugNewPos;

	public int debugOffset;

	public int scrollSizeExtra;

	public bool enableScroll;

	public bool enableShrinkScroll;

	public int minPxVisible;

	[SerializeField]
	private VerticalLayoutGroup layoutGroup;

	[SerializeField]
	private Sprite frameSprite;

	[SerializeField]
	private Sprite glowSprite;

	[SerializeField]
	private ScrollRectEx scroll;

	[SerializeField]
	private GameObject spinner;

	private readonly List<ClanLeagueWinPlayerElement> NNIQGGQJIHT;

	private ClanLeagueWinPlayerElement GNMOKSRKPMT;

	private ClanLeagueWinPlayerElement NELETHQMOQJ;

	[SerializeField]
	private AnimParams animParams;

	public static int lastPlayerScore;

	private bool PGTRJQTPLKM;

	private float PNPIFEEESJK;

	public void Setup()
	{
	}

	private void HGIGNTJMOPP()
	{
	}

	private float PQNMPFMRTFF()
	{
		return 0f;
	}

	private void MGRLTPGGSSI()
	{
	}

	private void EHEFKFGQTLF()
	{
	}

	private void Update()
	{
	}

	private void SGIRPKSRNMG()
	{
	}

	public void SetNewScoreAndAnimate(int PMNGMSRTHLP)
	{
	}

	private void JMEMMIPNJRR()
	{
	}

	private void PTPJEQPEFIN()
	{
	}

	private void RJNNKJKIKLO(float GHQMNEHPFIH)
	{
	}

	private void NHPFTPFKOKJ()
	{
	}

	private void TTJLJHQOJPF(int FOMFIIFEKTS)
	{
	}
}
