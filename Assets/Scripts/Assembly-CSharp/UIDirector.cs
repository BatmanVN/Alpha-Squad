using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UIDirector : MonoBehaviour
{
	[Serializable]
	public struct PopupQueueElement
	{
		public UIPopup popup;

		public bool with_animation;

		public bool closeOtherPopups;

		public PopupQueueElement(UIPopup HLNKTFSRTNR, bool KQGHGPEKKTJ = true, bool PKRMRHJEGQJ = true)
		{
			popup = null;
			with_animation = false;
			closeOtherPopups = false;
		}
	}

	[CompilerGenerated]
	private sealed class LOKPOFMGSQI
	{
		public UIPopup p;

		internal bool _003COnPopupClose_003Eb__0(PopupQueueElement x)
		{
			return false;
		}
	}

	[SerializeField]
	private UIDirectorElements elements;

	[SerializeField]
	private List<UIPopup> popups;

	[SerializeField]
	private List<UIPanel> panels;

	[SerializeField]
	private List<UIHeader> headersLeft;

	[SerializeField]
	private List<UIHeader> headersCenter;

	[SerializeField]
	private List<UIHeader> headersRight;

	[SerializeField]
	private List<UIPopover> popovers;

	[SerializeField]
	private List<Transform> bringToFront;

	protected Dictionary<Type, UIPanel> SHPPNEHJLNK;

	protected Dictionary<Type, UIPopup> GIFERLFHIJK;

	protected Dictionary<Type, UIHeader> KJKLOHGQGLE;

	protected Dictionary<Type, UIPopover> LGNEKRFGRHS;

	private List<PopupQueueElement> NMTKGTIHFHP;

	private UIPanel QPPJMLHLFSE;

	private List<UIHeader> IRTSPLKRITT;

	private Transform NROTPOFIGGQ;

	[NonSerialized]
	public UnityEngine.Object previousScreen;

	private bool RLTLREMEQOR;

	private int QKJQLSEMEFL;

	private float IPFPSELQJLG;

	public event Action<int> GJLIOFJSGFI
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action IRNEFSGOITF
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action NITGNMPQMQG
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action GNFNLHEPFKQ
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public virtual void Start()
	{
	}

	public virtual void Awake()
	{
	}

	protected void PKRORKOEHLQ()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private float NJNQOQSIEOO()
	{
		return 0f;
	}

	private void KJFQSKPQSLE()
	{
	}

	private void KRFMISLTGEG()
	{
	}

	public T GetPanel<T>() where T : UIPanel
	{
		return null;
	}

	public T GetHeader<T>() where T : UIHeader
	{
		return null;
	}

	public T GetPopup<T>() where T : UIPopup
	{
		return null;
	}

	public T GetPopover<T>() where T : UIPopover
	{
		return null;
	}

	public T GetLivePopup<T>() where T : UIPopup
	{
		return null;
	}

	public Transform GetFrontElementTransform()
	{
		return null;
	}

	public void EnterPanel<T>(bool KQGHGPEKKTJ = true) where T : UIPanel
	{
	}

	public void EnterHeader<T>(bool KQGHGPEKKTJ = true) where T : UIHeader
	{
	}

	public void AppendPopup<T>(bool KQGHGPEKKTJ = true, bool PKRMRHJEGQJ = true) where T : UIPopup
	{
	}

	public void PrependPopup<T>(bool KQGHGPEKKTJ = true, bool PKRMRHJEGQJ = true) where T : UIPopup
	{
	}

	public void RemovePopupFromQueue<T>() where T : UIPopup
	{
	}

	public bool IsPopupInQueue<T>() where T : UIPopup
	{
		return false;
	}

	public bool IsPopupInQueue(UIPopup SKOJGTGOPIF)
	{
		return false;
	}

	public bool IsPopupFirst<T>() where T : UIPopup
	{
		return false;
	}

	public void CloseAllPopups(bool KQGHGPEKKTJ = true)
	{
	}

	public void ExitAllHeaders(bool KQGHGPEKKTJ = true)
	{
	}

	public int GetLastHeaderCallerSiblingIndex()
	{
		return 0;
	}

	protected void ETNNQLNTTJF()
	{
	}

	protected void PLJEITHQNHF()
	{
	}

	protected void SHEOFIMMKGT()
	{
	}

	public void OnPopupClose(UIPopup SKOJGTGOPIF)
	{
	}

	protected void PPFLQTNNPJO(bool SNNFPNNHTOQ = true)
	{
	}

	public int GetOpenPopupCount()
	{
		return 0;
	}

	private int GOSHFTMGPTP(UIPopup SKOJGTGOPIF)
	{
		return 0;
	}

	private GameObject FRSPMGLMJTF<T>(T GRMOIOOPGSL, Transform JKFPSLRREIJ) where T : UILayer
	{
		return null;
	}

	public UIPanel GetActivePanel()
	{
		return null;
	}
}
