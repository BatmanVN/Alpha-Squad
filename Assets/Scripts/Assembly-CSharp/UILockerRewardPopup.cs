using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UILockerRewardPopup : UIPopup
{
	[CompilerGenerated]
	private sealed class NIMJLPHOIIG
	{
		public Transform previousReward;

		internal void _003CRemovePreviousReward_003Eb__0()
		{
		}
	}

	public static Action OnLockerOpened;

	[SerializeField]
	private float timeAnim;

	[SerializeField]
	private float timeExtraMultiplier;

	[SerializeField]
	private int blinks;

	[SerializeField]
	private float revealScale;

	[SerializeField]
	[Space]
	private Animator lockerAnim;

	[SerializeField]
	private GameObject[] drawers;

	[SerializeField]
	private Transform[] rewardSpots;

	[SerializeField]
	private MeshRenderer[] drawerRenders;

	[SerializeField]
	private UILockerReward rewardPrefab;

	[SerializeField]
	private MenuChestCardBasicCurrency hammersPrefab;

	[SerializeField]
	private Transform rewardFinalParent;

	[SerializeField]
	private CanvasGroup backgroundGroup;

	[SerializeField]
	private UILockerRewardSummary summary;

	[SerializeField]
	private GameObject revealEffect;

	[SerializeField]
	private GameObject skipButton;

	[SerializeField]
	private Transform glowSpot;

	[SerializeField]
	private Sprite locker;

	[SerializeField]
	private Image[] lockerRarityClosed;

	[SerializeField]
	private Image[] lockerRarityOpen;

	private float TGGHJQTLEQI;

	private int[] QPMEQSRIHEN;

	private GameObject EPQQFHMOJSR;

	private List<UILockerRewardSummary.GEJJFHKESOQ> OPHQESJTOLF;

	private int OLIKOEMTQNT;

	private List<int> IHNOKFEELMH;

	private Vector2 HPISLNRIGNE;

	private bool EMQHTQGSITL;

	private bool RNPHJORMFQF;

	private bool GONRJRSJMQH;

	private Transform GNROELHPFRN;

	private static readonly int NFOKOMLKTEN;

	private static readonly int HMFOTOPGJPH;

	private static readonly int PKIOPKKEQEM;

	private static readonly int QEKNTQFHTSG;

	private static readonly int RFOFTFLFGKK;

	private static readonly int NGIPPSPKSNG;

	public static void Append(int SGNNHEROROI, bool MRLLOQSQLRT)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	public void CalculateChances()
	{
	}

	public void Skip()
	{
	}

	private void RSHFMJFHEST()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	public override void OnShowFinished()
	{
	}

	public void SetupRewards(int SGNNHEROROI, bool MRLLOQSQLRT)
	{
	}

	private void LPHMPHSPTTL()
	{
	}

	public int RandomExcept(int PRRKFGTQTJK, int NHJLNIHMJRG, int HQMFNLFKSJE)
	{
		return 0;
	}

	public void Hurry()
	{
	}

	public void ResetLocker()
	{
	}

	public void ResetFromEvent()
	{
	}

	private IEnumerator ENTNPHIHSTG()
	{
		return null;
	}

	private MeshRenderer KJFOMNGMEEL(int KQQINSRPRNP)
	{
		return null;
	}

	private void ESSGKLLETMP(float PRRKGRQILFR = 0f)
	{
	}

	private IEnumerator QFROPEPSQLK()
	{
		return null;
	}

	private void EQESGHJLFGH(bool TMLGLFQPHJN)
	{
	}

	private void JNEPESRSGRL()
	{
	}

	private IEnumerator SPSQLFTSTPO()
	{
		return null;
	}

	public void BeforeHide()
	{
	}

	private int OSKTRSJMPTT(UILockerRewardSummary.GEJJFHKESOQ SNESJTIRFSO)
	{
		return 0;
	}

	private int MLJHLEIEMTN(UILockerRewardSummary.GEJJFHKESOQ SNESJTIRFSO)
	{
		return 0;
	}

	private int TKLTMNQKOGG(UILockerRewardSummary.GEJJFHKESOQ SNESJTIRFSO)
	{
		return 0;
	}

	private float TKORHEERSGR(float JPKGQSMKSTF)
	{
		return 0f;
	}

	private float TQIJIQFFEOS(int KQQINSRPRNP, int NHJLNIHMJRG)
	{
		return 0f;
	}

	public void DebugReward(int SGNNHEROROI)
	{
	}

	private void HHJESSOTSPT(int SGNNHEROROI, bool MRLLOQSQLRT = true)
	{
	}

	private void IHOMRNEJKIF(bool MRLLOQSQLRT)
	{
	}

	private void KRPGSHQEKNI(bool MRLLOQSQLRT)
	{
	}

	public Button GetOkButton()
	{
		return null;
	}

	[CompilerGenerated]
	private bool GTOPKPLJHHI()
	{
		return false;
	}

	[CompilerGenerated]
	private bool JTJMSEGOLKG()
	{
		return false;
	}
}
