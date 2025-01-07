using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class UIEffect : UIEffectBase
	{
		public enum BlurEx
		{
			None = 0,
			Ex = 1
		}

		public const string shaderName = "UI/Hidden/UI-Effect";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		private float m_EffectFactor;

		[SerializeField]
		private float m_ColorFactor;

		[SerializeField]
		private float m_BlurFactor;

		[SerializeField]
		private EffectMode m_EffectMode;

		[SerializeField]
		private ColorMode m_ColorMode;

		[SerializeField]
		private BlurMode m_BlurMode;

		[SerializeField]
		private bool m_AdvancedBlur;

		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private float m_ShadowBlur;

		[Obsolete]
		[SerializeField]
		[HideInInspector]
		private ShadowStyle m_ShadowStyle;

		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private Color m_ShadowColor;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private Vector2 m_EffectDistance;

		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private bool m_UseGraphicAlpha;

		[Obsolete]
		[SerializeField]
		[HideInInspector]
		private Color m_EffectColor;

		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private List<UIShadow.AdditionalShadow> m_AdditionalShadows;

		public override AdditionalCanvasShaderChannels requiredChannels => default(AdditionalCanvasShaderChannels);

		[Obsolete]
		public float toneLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float effectFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float colorFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete]
		public float blur
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete]
		public float blurFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete]
		public EffectMode toneMode => default(EffectMode);

		public EffectMode effectMode => default(EffectMode);

		public ColorMode colorMode => default(ColorMode);

		public BlurMode blurMode => default(BlurMode);

		public Color effectColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public override ParameterTexture ptex => null;

		public bool advancedBlur => false;

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected override void SetDirty()
		{
		}

		private static void GetBounds(List<UIVertex> verts, int start, int count, ref Rect posBounds, ref Rect uvBounds, bool global)
		{
		}
	}
}
