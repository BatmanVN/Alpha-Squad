using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ChestRewardCell : MonoBehaviour
{
	public enum OHRHGNTKRKP
	{
		EMPTY = 0,
		REGULAR = 1,
		UNLOCKING = 2,
		UNLOCKED = 3,
		CELL_LOCKED = 4
	}

	private bool IRRTNMSJSOQ;

	public ChestController.ChestData data;

	[NonSerialized]
	public OHRHGNTKRKP state;

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[SerializeField]
	private UITextTimer labelTimer;

	[SerializeField]
	private Image chestIcon;

	[SerializeField]
	private Button buttonMe;

	[SerializeField]
	private CanvasGroup stateRegular;

	[SerializeField]
	private CanvasGroup stateUnlocking;

	[SerializeField]
	private CanvasGroup stateUnlocked;

	[SerializeField]
	private CanvasGroup stateEmpty;

	[SerializeField]
	private CanvasGroup stateCellLocked;

	[SerializeField]
	private CircleClock circleClock;

	[SerializeField]
	private float chestYRegular;

	[SerializeField]
	private float chestYUnlocked;

	[SerializeField]
	private Text startLabel;

	[SerializeField]
	private Text levelLabel;

	[SerializeField]
	private Text cantOpenPrice;

	[SerializeField]
	private GameObject overlayCantOpen;

	[SerializeField]
	private GameObject overlayCanOpen;

	[NonSerialized]
	public MenuViewStartGame owner;

	private Transform JMTMLTLQOPG;

	private bool JFJEHSOGNPM;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(ChestController.ChestData TSRPFHOJKSG)
	{
	}

	public void SetupPreview(ChestController.ChestData TSRPFHOJKSG, bool NQIRHPFKMRL = false)
	{
	}

	public void Resetup(bool KQGHGPEKKTJ)
	{
	}

	private void OnApplicationFocus(bool KQOPJTEQMEF)
	{
	}

	public void OnClick()
	{
	}

	public void UnlockChest()
	{
	}

	public void OpenChest()
	{
	}

	private void JIQOQGNHLFO(bool KQGHGPEKKTJ = true)
	{
	}

	private void MHKGMRGGGLI()
	{
	}

	public void OnTimerDone()
	{
	}

	public void PushForward()
	{
	}

	public void ResetForward()
	{
	}

	private bool SMKLRKTQGKS()
	{
		return false;
	}

	private void FIOLGGPQKON(bool NSNERIQSMEL = false)
	{
	}

	private void HOMMIJRTPTK()
	{
	}

	private void JFLHJIGFRRQ(bool KQGHGPEKKTJ = true)
	{
	}

	private void JNQIOGNKKGE(bool KQGHGPEKKTJ = true)
	{
	}

	private void KFHQHIOTTKO(bool KQGHGPEKKTJ = true)
	{
	}

	private void SSMOROMIKGN(bool KQGHGPEKKTJ = false)
	{
	}

	private void RJJSEEHRNOF(bool KQGHGPEKKTJ = false)
	{
	}

	private void OTRTERLPINI()
	{
	}

	private FloatingErrorText KMQIMTNTOMN(string HETQTIKJGNI, Transform HSSNSPQEIGR = null, bool JIETLHRJEEJ = true)
	{
		return null;
	}

	[CompilerGenerated]
	private void TRLQGRTQIFQ()
	{
	}

	[CompilerGenerated]
	private void GFOEIHGKQKI()
	{
	}

	[CompilerGenerated]
	private void NKGFNHOIMFR()
	{
	}

	[CompilerGenerated]
	private void SLPEILITFLJ()
	{
	}
}
