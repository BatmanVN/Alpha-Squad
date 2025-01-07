using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WorldUnlockElement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LPRGIESPOOS
	{
		public WorldUnlockElement _003C_003E4__this;

		public bool episodes;

		internal void _003CPlayUnlockAnimation_003Eb__0()
		{
		}
	}

	[SerializeField]
	private EpisodeCell prefabEpisodeCell;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image previousIcon;

	[SerializeField]
	private GameObject lockCover;

	[Space]
	[SerializeField]
	private Shader silluetteShader;

	[SerializeField]
	private Color colorUnavailable;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private RectTransform beams;

	[Space]
	[SerializeField]
	private GameObject worldBlockPrevious;

	[SerializeField]
	private GameObject episodeBlockPrevious;

	[SerializeField]
	private GameObject worldBlockCurrent;

	[SerializeField]
	private GameObject episodeBlockCurrent;

	[SerializeField]
	private RectTransform episodeLayoutPrevious;

	[SerializeField]
	private RectTransform episodeLayoutCurrent;

	private bool TEILKPETLEJ;

	private Action RRQGRENQSGR;

	public virtual void Setup()
	{
	}

	public virtual void SetupAnimation()
	{
	}

	protected void QQLTGMLQESL(bool GSJNPHNGPLM, WorldData NHQFORNOPMI)
	{
	}

	protected void RONOKGMFFJN(bool GSJNPHNGPLM, EpisodeController.EpisodeConfig KOSMGSTPRIQ)
	{
	}

	public void PlayUnlockAnimation(Action LFKQKPPHTGJ, bool ISSSHQNFGIS, float PRRKGRQILFR = 0f)
	{
	}

	public void OnUnlockComplete()
	{
	}

	public virtual void FadeIn()
	{
	}

	public void HideBeams()
	{
	}

	public void Show(float PRRKGRQILFR)
	{
	}

	[CompilerGenerated]
	private void KOQFGHPMERH()
	{
	}
}
