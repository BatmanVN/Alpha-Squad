using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	public class Gradient2 : BaseMeshEffect
	{
		public enum HNQQQMJSQIL
		{
			Horizontal = 0,
			Vertical = 1,
			Radial = 2,
			Diamond = 3
		}

		public enum JGRHPNGHRGK
		{
			Override = 0,
			Add = 1,
			Multiply = 2
		}

		[SerializeField]
		private HNQQQMJSQIL _gradientType;

		[SerializeField]
		private JGRHPNGHRGK _blendMode;

		[SerializeField]
		private bool _modifyVertices;

		[SerializeField]
		private float _offset;

		[SerializeField]
		private float _zoom;

		[SerializeField]
		private Gradient _effectGradient;

		public JGRHPNGHRGK TRNLIHNNHMI
		{
			get
			{
				return default(JGRHPNGHRGK);
			}
			set
			{
			}
		}

		public Gradient FMHPFETPJSN
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HNQQQMJSQIL NOGJLHEETHK
		{
			get
			{
				return default(HNQQQMJSQIL);
			}
			set
			{
			}
		}

		public bool RJSHEFNPQGQ
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float OMETGMEPPIM
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float EOMKGIGMNPG
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper KLHQOPPLQLN)
		{
		}

		private Rect RJIKHIMNKGO(List<UIVertex> KORGKOPMGTI)
		{
			return default(Rect);
		}

		private void HRIRKIJTRPR(List<UIVertex> MNQQEQPPMPP, Rect ELMTSFKGFHS, float SRJEEHSFSRH, VertexHelper KLHQOPPLQLN)
		{
		}

		private float[] PIKSTQNKNFP(List<UIVertex> MNQQEQPPMPP, int PSPJIJNTMOI)
		{
			return null;
		}

		private List<float> RRISRTQHQER(float SRJEEHSFSRH, Rect ELMTSFKGFHS)
		{
			return null;
		}

		private UIVertex IOESGPTTMRK(UIVertex NSNQGMTMJNP, UIVertex FSKRJTNJOIF, float MKFJTQFIEHT)
		{
			return default(UIVertex);
		}

		private Color FHTEPQNNPJS(Color RTNSMOREKSS, Color KQQRRKRGIMN)
		{
			return default(Color);
		}
	}
}
