using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class UIClanListPanel : UIPanel, DynamicVerticalLayout.SNFEJIONTHF
{
	[CompilerGenerated]
	private sealed class SKOMQOPQLMR
	{
		public int minActivity;

		internal bool _003CSearchForRandomClans_003Eb__0(IApiGroup g)
		{
			return false;
		}
	}

	private const int RFIRKPESKRP = 100;

	private const int EGOHJPPKRTO = 10;

	private const int TQORTSEOKET = 2;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private UIClanSmallInfo itemPrefab;

	[SerializeField]
	private InputField searchInput;

	[SerializeField]
	private DynamicVerticalLayout layout;

	private IEnumerable<IApiGroup> ENNFOIJKKIO;

	private bool KIMINTQESLS;

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public void SetupItem(MonoBehaviour LMSPIEGSMRF, int TFPLTLFLKPI)
	{
	}

	public MonoBehaviour GetItemPrefab()
	{
		return null;
	}

	public void OnSearch()
	{
	}

	public void OnFilterButton()
	{
	}

	public void OnFindAClanDiscordButton()
	{
	}

	private Task HFLHPQIHTQO(string HETQTIKJGNI)
	{
		return null;
	}

	private Task NNRSERQSNRM(string NEHGFQTHRKP = "")
	{
		return null;
	}

	private void FMTGPJQSGKE()
	{
	}

	private void GQSPFGPLSOM()
	{
	}

	private void OLLTRKFOKMG()
	{
	}

	public void OnBackButton()
	{
	}
}
