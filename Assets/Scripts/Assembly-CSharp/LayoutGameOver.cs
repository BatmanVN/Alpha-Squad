using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LayoutGameOver : MonoBehaviour
{
	public enum OQJQQTNPFPT
	{
		CURRENCY = 0,
		ITEMS = 1,
		ALL = 2
	}

	[CompilerGenerated]
	private sealed class ESSFPOQHMGL
	{
		public LayoutGameOver _003C_003E4__this;

		public Action<CellGameOver> OnItemEntered;

		public Action OnComplete;

		internal void _003CPlayClaimAnimation_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class QSLHILTMOJP
	{
		public Transform used;

		public CellGameOver obj;

		public ESSFPOQHMGL CS_0024_003C_003E8__locals1;

		internal void _003CPlayClaimAnimation_003Eb__3()
		{
		}

		internal void _003CPlayClaimAnimation_003Eb__4()
		{
		}
	}

	[SerializeField]
	private CellGameOver prefabCell;

	[Space]
	[SerializeField]
	private RectTransform cellParent;

	[SerializeField]
	private Text labelNothing;

	[SerializeField]
	private bool centerIfFew;

	[SerializeField]
	private HorizontalLayoutGroup layout;

	[SerializeField]
	private LayoutElement layoutElement;

	private List<CellGameOver> TRJFGRHMHOH;

	private const float SIGMRNLTSOL = 0.225f;

	private const float JENPMQNKQGE = 0.015f;

	private const float GFRIKQQMITJ = 0.1f;

	private const float RIOJGIMJENN = 0.265f;

	private const float PJEPLRGHJLG = 0.15f;

	private float GNJIRMJHNNO;

	public SoundEffect show;

	public SoundEffect hide;

	public void Setup(DropController.DropsCollection JONGJFLGQHH, OQJQQTNPFPT TISJRIHGFEI, float KPIEJKTQONN = 0f)
	{
	}

	public void Setup(LootList GRJRQRKLHIH, OQJQQTNPFPT TISJRIHGFEI, float KPIEJKTQONN = 0f)
	{
	}

	public void UpdateForCell(CellGameOver LTHFHEPRQNI)
	{
	}

	public void ClearCells()
	{
	}

	public void Hide()
	{
	}

	public void Show(float PRRKGRQILFR)
	{
	}

	public void PlayClaimAnimation(Transform RNMJIKMTLPF, Transform EEHPKGGSNSL, Action LFKQKPPHTGJ = null, Action<CellGameOver> NRHNGRPQPRM = null)
	{
	}

	private void GKJISJGRFNM(LootElement INNLJIGRFOG, float HQNTKRIKJGR, ref float PRRKGRQILFR)
	{
	}

	private bool GSMIRRLLLLI(LootElement INNLJIGRFOG, OQJQQTNPFPT TISJRIHGFEI)
	{
		return false;
	}

	public void ForceAddCell(LootElement INNLJIGRFOG, float PRRKGRQILFR)
	{
	}

	private CellGameOver LNKGLSGFNGT()
	{
		return null;
	}

	public float GetTotalDelay()
	{
		return 0f;
	}

	private void RTJJJNOKFKQ()
	{
	}

	private void QJNPNSELJKJ()
	{
	}

	[CompilerGenerated]
	private void QFLJLSTQKOK()
	{
	}
}
