using System;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	public class UIShiny : UIEffectBase
	{
		public const string shaderName = "UI/Hidden/UI-Effect-Shiny";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		private float m_EffectFactor;

		[SerializeField]
		private float m_Width;

		[SerializeField]
		private float m_Rotation;

		[SerializeField]
		private float m_Softness;

		[SerializeField]
		private float m_Brightness;

		[SerializeField]
		private float m_Gloss;

		[SerializeField]
		protected EffectArea m_EffectArea;

		[SerializeField]
		private EffectPlayer m_Player;

		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private bool m_Play;

		[Obsolete]
		[SerializeField]
		[HideInInspector]
		private bool m_Loop;

		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private float m_Duration;

		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private float m_LoopDelay;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private AnimatorUpdateMode m_UpdateMode;

		private float _lastRotation;

		[Obsolete]
		public float location
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

		public float width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float softness
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
		public float alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float brightness
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
		public float highlight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float gloss
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public EffectArea effectArea
		{
			get
			{
				return default(EffectArea);
			}
			set
			{
			}
		}

		[Obsolete]
		public bool play
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete]
		public bool loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float duration
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
		public float loopDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimatorUpdateMode updateMode
		{
			get
			{
				return default(AnimatorUpdateMode);
			}
			set
			{
			}
		}

		public override ParameterTexture ptex => null;

		private EffectPlayer _player => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		public void Play(bool reset = true)
		{
		}

		public void Stop(bool reset = true)
		{
		}

		protected override void SetDirty()
		{
		}
	}
}
