using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class RiftsPanelLeaderboards : RiftsPanelView, DynamicVerticalLayout.SNFEJIONTHF
{
	[Serializable]
	public enum Tab
	{
		Top = 0,
		Me = 1,
		Watched = 2,
		Clan = 3
	}

	[Serializable]
	public class WatchListEntry
	{
		public string id;

		public string name;
	}

	[CompilerGenerated]
	private sealed class IHEEEKNJQFT
	{
		public string ownerId;

		internal bool _003COnItemRemoveClicked_003Eb__0(WatchListEntry r)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class OLOSNSQHPFF
	{
		public IApiUser user;

		internal bool _003CCheckRequestWatchlistUserData_003Eb__0(WatchListEntry e)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TFGGMMQTIMF
	{
		public List<string> ownerRecords;

		internal bool _003CGetClanWithoutRecordData_003Eb__0(IGroupUserListGroupUser m)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class PQEGSKKELJE
	{
		public IGroupUserListGroupUser m;

		internal bool _003CGetClanWithoutRecordData_003Eb__1(string r)
		{
			return false;
		}
	}

	private const int RFIRKPESKRP = 100;

	private const int OGEMITQHSQM = 2;

	private const int ILNLISSOPJO = 100;

	public RiftsPanelLeaderboardItem itemPrefab;

	public DynamicVerticalLayout layout;

	public GameObject failedToRetrieveLeaderboards;

	public GameObject spinner;

	public CanvasGroup addWatchButton;

	public Transform tabFloatingTextParent;

	[SerializeField]
	private Image[] tabs;

	[SerializeField]
	private Text[] tabLabels;

	[SerializeField]
	private Sprite spriteTabActive;

	[SerializeField]
	private Sprite spriteTabInactive;

	[SerializeField]
	private Sprite spriteTabDisabled;

	private bool KIMINTQESLS;

	private Tab NQTPJLQQLRE;

	private Dictionary<Tab, QHOERPGGPPJ> JNEHMQNHNLL;

	private Dictionary<Tab, float> ORPEIRNFQEL;

	private int QSRMRPIQSMF;

	private int RONKKSLRPNJ;

	private RiftsPanelLeaderboardItem REHPNQLQFRM;

	private int JORQIFOMQHO;

	private bool JKPIREKMFNS;

	private List<WatchListEntry> MGPILIQJFGM;

	private List<IGroupUserListGroupUser> JPJSOIFMINQ;

	private bool OLTSEPFQFRK;

	private static bool IITJSPOSQEQ;

	public event Action<int> IGJPMJJJSKH
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

	public override void SetupView(RiftsPanel TNKMMOJJPPI)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetupTab(Tab OIGIHGHENJK)
	{
	}

	public override void OnScrollChanged(Vector2 RRPSNPOTQNT)
	{
	}

	private void RMPLTJLLPOH()
	{
	}

	private void HHRJOTMRHMH()
	{
	}

	private void JITNJSQRJSO()
	{
	}

	public void OnTabButton(int QOSKLRJOTKH)
	{
	}

	private bool KREJTGNMMKI(Tab OIGIHGHENJK)
	{
		return false;
	}

	private void FLFKLTLPFGO()
	{
	}

	private void KHFKNLMSRPK()
	{
	}

	private QHOERPGGPPJ GILGPJFFKHJ()
	{
		return null;
	}

	public QHOERPGGPPJ GetLeaderboardForTab(Tab OIGIHGHENJK)
	{
		return null;
	}

	private void RRMRJGJNGFG()
	{
	}

	public QHOERPGGPPJ InitializeTopLeaderboard()
	{
		return null;
	}

	public void OnRetryButton()
	{
	}

	private void HLNNEEJOHON(QHOERPGGPPJ QEFHSEEFROM, int FIPHTRRRPET)
	{
	}

	private void GQSPFGPLSOM()
	{
	}

	private void QJHRQFSPMJM()
	{
	}

	private void TNOMHOFJSSE()
	{
	}

	private void PRHTJQOOEQI()
	{
	}

	public void SetupItem(MonoBehaviour LMSPIEGSMRF, int TFPLTLFLKPI)
	{
	}

	public void ClearLeaderboardsAndRefresh(bool OJQIFLPSRFE = true)
	{
	}

	public void ClearWatchedLeaderboardsAndRefresh()
	{
	}

	public void ClearClanLeaderboardsAndRefresh()
	{
	}

	public void SetWatchTabDirty()
	{
	}

	public static void SetClanTabDirty()
	{
	}

	public void OnItemClicked(RiftsPanelLeaderboardItem HPJMQLRTORF, int PSPJIJNTMOI)
	{
	}

	public void OnItemRemoveClicked(RiftsPanelLeaderboardItem HPJMQLRTORF, string IPEOLHNKPHM)
	{
	}

	private void QITORENJGHH(int TFPLTLFLKPI)
	{
	}

	public IApiLeaderboardRecord GetRecord(int PSPJIJNTMOI)
	{
		return null;
	}

	public IApiLeaderboardRecord GetOwnerRecord(int PSPJIJNTMOI)
	{
		return null;
	}

	public WatchListEntry GetWatchlistWithoutRecordData(int PSPJIJNTMOI)
	{
		return null;
	}

	private void LQHQKTSFGIT()
	{
	}

	private void PLHOGJTJRFS()
	{
	}

	public MonoBehaviour GetItemPrefab()
	{
		return null;
	}

	private void GMOHOEFKMTI(QHOERPGGPPJ QEFHSEEFROM, int FIPHTRRRPET)
	{
	}

	private void EKRTFOMNPKJ(QHOERPGGPPJ QEFHSEEFROM, int FIPHTRRRPET)
	{
	}

	private void LILPNOOSMOT(QHOERPGGPPJ QEFHSEEFROM, int FIPHTRRRPET)
	{
	}

	private void EHEFKFGQTLF()
	{
	}

	private int IJQSKSSPGTN(Tab OIGIHGHENJK)
	{
		return 0;
	}

	public void ViewportHeightChanged()
	{
	}

	private void JNGJKSEFFSK(int PSPJIJNTMOI)
	{
	}

	private void FSHKHJMENGP()
	{
	}
}
