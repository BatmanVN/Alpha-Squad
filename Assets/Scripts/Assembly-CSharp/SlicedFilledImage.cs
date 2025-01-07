using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SlicedFilledImage : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
{
	private static class OGFPJLMGIGP
	{
		public static bool MIRHOKTNFKE<T>(ref T JJSIMGHPPOF, T ENGRQPPTRMQ) where T : struct
		{
			return false;
		}

		public static bool LFJHOPEQQIR<T>(ref T JJSIMGHPPOF, T ENGRQPPTRMQ) where T : class
		{
			return false;
		}
	}

	public enum JHHFEOEJRTF
	{
		Right = 0,
		Left = 1,
		Up = 2,
		Down = 3
	}

	private static readonly Vector3[] QPIOMJPNJJQ;

	private static readonly Vector2[] SOSKKIFIPKR;

	private static readonly Vector2[] PFJSKTJERIQ;

	private static readonly Vector2[] PEFLTPFNKQK;

	[SerializeField]
	private Sprite m_Sprite;

	[SerializeField]
	private JHHFEOEJRTF m_FillDirection;

	[SerializeField]
	private float m_FillAmount;

	[SerializeField]
	private bool m_FillCenter;

	[SerializeField]
	private float m_PixelsPerUnitMultiplier;

	[NonSerialized]
	private Sprite QOHFPRPJJRF;

	private bool FQIEJPFQLSQ;

	private static List<SlicedFilledImage> SSHKTFPGOSK;

	private static bool FSGNNPLFOFG;

	public Sprite JSIJMHEGPEG
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JHHFEOEJRTF NPNMEMOPSLE
	{
		get
		{
			return default(JHHFEOEJRTF);
		}
		set
		{
		}
	}

	public float GLMFLGERPHN
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool TMQETFMNMKK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float SJOFLLSJGGF
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float OIFLRLLPORP => 0f;

	public Sprite OJKJSERPNQP
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private Sprite SOTJQNSRQSI => null;

	public override Texture JQOLNFNEKRT => null;

	public bool TQMPQKMHSTI => false;

	public override Material PPGGTFESMHN
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float FTLRRISGOOM
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private int LSJEGIEHISG => 0;

	private float MSLMSKERSIK => 0f;

	private float QIJFKGGLIML => 0f;

	private float IGRKIOLIJLO => 0f;

	private float PIEIMNSRRJQ => 0f;

	private float LTSRLNKNIEE => 0f;

	private float TPFPPSKREJJ => 0f;

	protected SlicedFilledImage()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnPopulateMesh(VertexHelper NNHFJETMONE)
	{
	}

	protected override void UpdateMaterial()
	{
	}

	private void ILMJNSLQLOI(VertexHelper NNHFJETMONE)
	{
	}

	private Vector4 HJRPOGIHILQ(Vector4 SKPENOLSQRQ, Rect TTGTTNJOLJT)
	{
		return default(Vector4);
	}

	private void HIJLQIFQROL(VertexHelper NNHFJETMONE, Vector4 KORGKOPMGTI, Vector4 JMIFSNRTHOG, float GLMFLGERPHN)
	{
	}

	private void UnityEngine_002EUI_002EILayoutElement_002ECalculateLayoutInputHorizontal()
	{
	}

	private void UnityEngine_002EUI_002EILayoutElement_002ECalculateLayoutInputVertical()
	{
	}

	private bool UnityEngine_002EICanvasRaycastFilter_002EIsRaycastLocationValid(Vector2 QEQJIIKSKTQ, Camera HJFEHJFPIPT)
	{
		return false;
	}

	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	private void SHPGFTJFONL()
	{
	}

	private void TTIJQGPRRKO()
	{
	}

	private static void KRRPSRITSJQ(SpriteAtlas KNOOTOSENFF)
	{
	}
}
