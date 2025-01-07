using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BuildMenuStorageTab : BuildMenuTab, DynamicVerticalLayout.SNFEJIONTHF
{
	public enum TOGJEQLJHOJ
	{
		Interior = 0,
		Styles = 1
	}

	[CompilerGenerated]
	private sealed class KJLFTQLQHHT
	{
		public BuildMenuStorageTab _003C_003E4__this;

		public UIBaseStyleElement styleElement;

		public int visualId;

		internal void _003COnStyleSelected_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class FFJOINTSHEO
	{
		public BaseItemSave item;

		internal bool _003CGetOtherItem_003Eb__0(BaseItemSave x)
		{
			return false;
		}
	}

	[SerializeField]
	protected Transform interiorGrid;

	[SerializeField]
	protected GameObject interiorExplainer;

	[SerializeField]
	private ScrollRectStepped stylesScroll;

	[SerializeField]
	private BuildMenuSubtabs storageSubtabs;

	[SerializeField]
	private DynamicVerticalLayoutEx layout;

	[SerializeField]
	private UIBlueprintListElement elementPrefab;

	[SerializeField]
	private UIBaseStyleElement styleElement;

	[SerializeField]
	private GameObject stylePagePrefab;

	[SerializeField]
	private GameObject storageInfo;

	[SerializeField]
	private GameObject leftButton;

	[SerializeField]
	private GameObject rightButton;

	[SerializeField]
	private GameObject dotPrefab;

	[SerializeField]
	private UIStyleSelection buySelection;

	[SerializeField]
	private Transform dotsParent;

	[SerializeField]
	private Text storageCountText;

	private List<UIBaseStyleElement> NKRPNGMORHQ;

	private List<BaseItemSave> PSTJOHSNQMM;

	private List<RectTransform> LOGTNKITFPM;

	private List<int> IIOTRILONHL;

	private Vector3 KSOFKHGNTQJ;

	[HideInInspector]
	public TOGJEQLJHOJ storageView;

	private int EGHJJLFQLSR;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void Setup()
	{
	}

	public override void Refresh()
	{
	}

	public void OnInteriorView()
	{
	}

	public void TutorialTryToForceStylesView()
	{
	}

	public void ForceStylesView()
	{
	}

	public void ForceStorageView()
	{
	}

	public void OnStylesView()
	{
	}

	public void OnSalvage()
	{
	}

	private void NIRKGPRNTGH(int SLIEEELQMQS)
	{
	}

	public bool CanHaveStyles()
	{
		return false;
	}

	private bool EOGHEQGFSSS(int SLIEEELQMQS)
	{
		return false;
	}

	protected virtual void TMKISOJJFMN()
	{
	}

	private void GJNSIJRJEEL()
	{
	}

	private int PPTMPQOQRJE()
	{
		return 0;
	}

	private void HPKHMTJHENT()
	{
	}

	private void KNROGLQOLHQ()
	{
	}

	private bool KTLNFTLFQNM(int FIPHTRRRPET)
	{
		return false;
	}

	private bool QSOKNFGFNPT(int FIPHTRRRPET)
	{
		return false;
	}

	private void NPEKFKLKNJK()
	{
	}

	private void FKESLEPROQM(int RNQJMTJNOTN)
	{
	}

	private void GOMKSSOHGGI(RectTransform FIPHTRRRPET, int[] NNIQGGQJIHT, bool RMRTLJSNHMJ = false)
	{
	}

	public void OnScrollValueChanged(Vector2 IJFKSETNIHI)
	{
	}

	private int[] NKLKHMJOOPS(int[] QLOMLOJKOLO)
	{
		return null;
	}

	public void HideSelection()
	{
	}

	public void OnStyleSelected(UIBaseStyleElement LKNQFIIKGNT, int OKKIQNGEFPQ)
	{
	}

	private void NRRSOKEPJKT(UIBaseStyleElement LKNQFIIKGNT, int OKKIQNGEFPQ, int QIROGTNPJFG = 0)
	{
	}

	public override void RefreshNotification()
	{
	}

	public MonoBehaviour GetItemPrefab()
	{
		return null;
	}

	public void SetupItem(MonoBehaviour HPJMQLRTORF, int TFPLTLFLKPI)
	{
	}

	public override BaseItemSave GetOtherItem(BaseItemSave HPJMQLRTORF, bool PITFEETNKEK)
	{
		return null;
	}

	public override bool CanSwapItem()
	{
		return false;
	}

	public void CheckStylePage(int FIPHTRRRPET)
	{
	}

	public void OnNextPage()
	{
	}

	public void OnPrevPage()
	{
	}

	public void GoToStylePurchases()
	{
	}

	private void OFQJTKTGMPE(int FIPHTRRRPET)
	{
	}

	private void Update()
	{
	}

	[CompilerGenerated]
	private JJHFPNTSRLT.PQRIQGIOGQT SMRTRKREKRO(BaseItemSave KQQINSRPRNP)
	{
		return default(JJHFPNTSRLT.PQRIQGIOGQT);
	}
}
