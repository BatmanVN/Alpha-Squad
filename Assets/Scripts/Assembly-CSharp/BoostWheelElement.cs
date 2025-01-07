using System;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using UnityEngine;
using UnityEngine.UI;

public class BoostWheelElement : CircleElement
{
	[Serializable]
	public struct RarityConfig
	{
		public int rarity;

		public Sprite spriteBG;
	}

	[CompilerGenerated]
	private sealed class ETHTGGMTRME
	{
		public int rarity;

		internal bool _003CSetup_003Eb__0(RarityConfig x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MRGKMIFNNTT
	{
		public UIEffect effect;

		internal void _003CAnimateFlashSection_003Eb__0(float f)
		{
		}
	}

	public CircleSpriteElement bg;

	public Image icon;

	public Image separator;

	public Image separatorGlow;

	public Transform separatorParent;

	public float iconDistance;

	public RarityConfig[] rarityConfig;

	public void Setup(int MOTTITEELQF, ITTKIKLHHEQ EOOEIROQJOE)
	{
	}

	public override void SetWidth(float PNFTNKPRRQO)
	{
	}

	public override void UpdateLayout()
	{
	}

	public void AnimateFlashSection()
	{
	}
}
