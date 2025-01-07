using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ProfileIconSelectPopup : UIPopup
{
	[Serializable]
	public struct IconAvatar
	{
		public ProfileIcon.LOQMGTKOSMM icon;

		public Sprite sprite;

		[SerializeReference]
		public UnlockMode unlock;
	}

	[Serializable]
	public struct FrameAvatar
	{
		public ProfileIcon.PNQEKROLFPK frame;

		[SerializeField]
		private Sprite spriteBot;

		[SerializeField]
		private Sprite spriteTop;

		[SerializeField]
		private Sprite spriteMask;

		[SerializeReference]
		public UnlockMode unlock;

		public Sprite SpriteBot => null;

		public Sprite SpriteTop => null;

		public Sprite SpriteMask => null;
	}

	[Serializable]
	public abstract class UnlockMode
	{
		public abstract Dictionary<string, string> RGKKFRJHEFK();
	}

	public abstract class RequirementUnlock : UnlockMode
	{
		public abstract string REFJFLHIEGT();

		public abstract bool LEHEPNMNKGO();
	}

	[Serializable]
	public class CashUnlock : UnlockMode
	{
		public int amount;

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[Serializable]
	public class GemUnlock : UnlockMode
	{
		public int amount;

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[Serializable]
	public class EpisodeUnlock : RequirementUnlock
	{
		public int reachEpisode;

		public string locString;

		public bool dynamicLocalization;

		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[Serializable]
	public class WorldUnlock : RequirementUnlock
	{
		public WorldData.JQNPLTQOFMJ completeWorld;

		public string locString;

		public bool dynamicLocalization;

		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[Serializable]
	public class BaseLevelUnlock : RequirementUnlock
	{
		public int level;

		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[Serializable]
	public class BeatHuntUnlock : RequirementUnlock
	{
		public int index;

		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[Serializable]
	public class AcquireGearUnlock : RequirementUnlock
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}

		[CompilerGenerated]
		private bool RFEHFHJKSHS(ItemGear IKONITGHGEQ)
		{
			return false;
		}
	}

	[Serializable]
	public class AcquireWeaponUnlock : RequirementUnlock
	{
		public JJHFPNTSRLT.PQRIQGIOGQT rarity;

		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}

		[CompilerGenerated]
		private bool JOROLNLRRNJ(ItemWeapon IKONITGHGEQ)
		{
			return false;
		}
	}

	[Serializable]
	public class RiftsUnlock : RequirementUnlock
	{
		public int floor;

		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[Serializable]
	public class ElitePassUnlock : RequirementUnlock
	{
		public bool plus;

		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[Serializable]
	public class VipUnlock : RequirementUnlock
	{
		public override string REFJFLHIEGT()
		{
			return null;
		}

		public override bool LEHEPNMNKGO()
		{
			return false;
		}

		public override Dictionary<string, string> RGKKFRJHEFK()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class HTTRRJTGLMI
	{
		public ProfileIconPopupItem item;

		public ProfileIconSelectPopup _003C_003E4__this;

		internal void _003CSetupIconBlock_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class PTIGRJMRGSM
	{
		public ProfileFramePopupItem item;

		public ProfileIconSelectPopup _003C_003E4__this;

		internal void _003CSetupFrameBlock_003Eb__0()
		{
		}
	}

	public static Action OnPlayerProfileChanged;

	[SerializeField]
	private ProfileIconPopupItem iconPrefab;

	[SerializeField]
	private ProfileFramePopupItem framePrefab;

	[Space]
	[SerializeField]
	private RectTransform popup;

	[SerializeField]
	private PlayerAvatar previewAvatar;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private GridLayoutGroup gridIcons;

	[SerializeField]
	private GridLayoutGroup gridFrames;

	[SerializeField]
	private ScrollRect scrollIcons;

	[SerializeField]
	private ScrollRect scrollFrames;

	[SerializeField]
	private GameObject[] tabs;

	[SerializeField]
	private Text[] tabTexts;

	[SerializeField]
	private GameObject requirementBlock;

	[SerializeField]
	private GameObject requirementFade;

	[SerializeField]
	private Text requirementLabel;

	[SerializeField]
	private GameObject buttonSelect;

	[SerializeField]
	private GameObject buttonSelected;

	[SerializeField]
	private GameObject buttonDisabled;

	[SerializeField]
	private GameObject buttonCash;

	[SerializeField]
	private Text cashAmountLabel;

	[SerializeField]
	private GameObject buttonGems;

	[SerializeField]
	private Text gemsAmountLabel;

	private List<ProfileIconPopupItem> FQGNLGTEFNH;

	private List<ProfileFramePopupItem> PLKEKJFFJRJ;

	private bool LELGMFEFKPG;

	private bool TJTMSGIFJLN;

	private ProfileIcon.LOQMGTKOSMM KHEIOGMHEOS;

	private ProfileIcon.PNQEKROLFPK TFTTPNORPKJ;

	private bool QLKIJMSLKLH;

	private static bool QOOPLGKOOLG;

	public static void Open()
	{
	}

	public static void Init()
	{
	}

	private static void EMSMGMTNTJT()
	{
	}

	private static void HLRFIEKSHTP()
	{
	}

	private static void TOTLHKFPLGP(int HNTPNTJRJMH)
	{
	}

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	private static void EESIFFKIJOO<T>() where T : RequirementUnlock
	{
	}

	private void OLIEPMRNKLN(ProfileIconPopupItem HPJMQLRTORF)
	{
	}

	private void KNPRGRRTSSG(ProfileFramePopupItem HPJMQLRTORF)
	{
	}

	private void IHKOHSHSRIK()
	{
	}

	private void GKILSERQHMQ()
	{
	}

	private void LOHKPLRSPOH()
	{
	}

	private void JIQOQGNHLFO()
	{
	}

	private bool JTORRSFMQJH()
	{
		return false;
	}

	private bool KEHQNLNPFOJ()
	{
		return false;
	}

	public static bool IsIconUnlockedOrFree(IconAvatar ITRKNMFTGIG)
	{
		return false;
	}

	public static bool IsFrameUnlockedOrFree(FrameAvatar IOTMPGKLTMT)
	{
		return false;
	}

	public void OnSelectButton()
	{
	}

	private void RPLFFJEHRQQ()
	{
	}

	public void OnSelectedButton()
	{
	}

	public void OnDisabledSelectButton()
	{
	}

	public void OnCashButton()
	{
	}

	private void JJKRMMTFKJN()
	{
	}

	private void FSRORNIKRLN(ProfileIcon.LOQMGTKOSMM QFLNGSEEFRI)
	{
	}

	private void LFSQIHSTGPJ(ProfileIcon.PNQEKROLFPK TEQIFGTMGRN)
	{
	}

	public void OnGemsButton()
	{
	}

	private UnlockMode OEQOHGHNTQF()
	{
		return null;
	}

	private RequirementUnlock POMOLNSEKET()
	{
		return null;
	}

	private bool MHJJFHGTNRG()
	{
		return false;
	}

	private void GKTHGNLOSSO()
	{
	}

	private void QRNMIHJPKNH()
	{
	}

	private void GRLLSMQESPJ()
	{
	}

	private void OQITGMLNOPL()
	{
	}

	private void REIIMRSFIFM()
	{
	}

	private void LLPMKTPGQGN()
	{
	}

	public void OnTabIcon()
	{
	}

	public void OnTabFrame()
	{
	}

	private void PMPJKHQSIIS(int PSPJIJNTMOI)
	{
	}

	public void OnCloseButton()
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	private void MHJFLERLFTL()
	{
	}

	public override void SetupHeaders(bool KQGHGPEKKTJ = true)
	{
	}
}
