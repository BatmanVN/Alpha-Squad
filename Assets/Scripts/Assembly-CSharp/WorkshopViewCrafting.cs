using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopViewCrafting : MonoBehaviour
{
	private enum IFELIQHQKQN
	{
		CRAFT = 1,
		DISASSEMBLE = 2,
		FUSE = 3,
		TRANSFORM = 4
	}

	[CompilerGenerated]
	private sealed class TGGNNQPEORI
	{
		public WorkshopViewCrafting _003C_003E4__this;

		public LootElement le;

		internal void _003CAddLootElement_003Eb__1(int am)
		{
		}
	}

	[CompilerGenerated]
	private sealed class TGIIQSJPQRM
	{
		public ItemGear g;

		internal bool _003CTryAddGear_003Eb__0(LootElement x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class JQFMSFNPOET
	{
		public WorkshopViewCrafting _003C_003E4__this;

		public WorkshopRecipeReward weaponPartSelectReward;

		internal void _003COnCraftButton_003Eb__6(bool ok)
		{
		}

		internal void _003COnCraftButton_003Eb__7(List<JJHFPNTSRLT.WeaponPart> x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class TEMPPTQHTRE
	{
		public WorkshopRecipeReward gearSelectRecipeReward;

		public JQFMSFNPOET CS_0024_003C_003E8__locals1;

		internal void _003COnCraftButton_003Eb__9(ItemGear x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class MLEROFPQRHO
	{
		public JJHFPNTSRLT.PQRIQGIOGQT r;

		internal bool _003CUpdateExtraButtons_003Eb__2(LootElement x)
		{
			return false;
		}
	}

	[SerializeField]
	private FloatingErrorText prefabFloatingText;

	[Space]
	[SerializeField]
	private WorkshopFulfiller fulfiller;

	[SerializeField]
	private WorkshopOwnedCellList ownedLootElementsList;

	[SerializeField]
	private WorkshopAddedCellList usedLootElementsList;

	[SerializeField]
	private WorkshopRewardCell rewardCell;

	[SerializeField]
	private Text title;

	[SerializeField]
	private Text labelDescription;

	[SerializeField]
	private Text labelSelected;

	[SerializeField]
	private Text labelCraftingXp;

	[SerializeField]
	private Text labelCashPrice;

	[SerializeField]
	private Text labelCashPriceFuse;

	[SerializeField]
	private Text labelCrafting;

	[SerializeField]
	private Text labelTransformButton;

	[SerializeField]
	private GameObject blockNothingSelected;

	[SerializeField]
	private GameObject buttonCraft;

	[SerializeField]
	private GameObject buttonFuse;

	[SerializeField]
	private GameObject buttonTransform;

	[SerializeField]
	private GameObject buttonCraftDisabled;

	[SerializeField]
	private GameObject buttonDisassemble;

	[SerializeField]
	private GameObject blockToggleAutoMax;

	[SerializeField]
	private Button buttonInfo;

	[SerializeField]
	private GameObject labelNoItems;

	[SerializeField]
	private GameObject infoButtonGlow;

	[Space]
	[SerializeField]
	private GameObject blockCraft;

	[SerializeField]
	private GameObject blockCraftAnimation;

	[SerializeField]
	private Image arrow;

	[Space]
	[SerializeField]
	private GameObject craftButtonPrestigeIcon;

	[SerializeField]
	private GameObject fuseButtonPrestigeIcon;

	[SerializeField]
	private GameObject tutorialMultiCraft;

	[SerializeField]
	private GameObject tutorialResourcesReturned;

	[SerializeField]
	private GameObject tutorialResourcesReturnedBubble;

	[SerializeField]
	private Text tutorialResourcesReturnedLabel;

	[Space]
	[SerializeField]
	private RectTransform extraButtons;

	[SerializeField]
	private GameObject extraButtonGearCommon;

	[SerializeField]
	private GameObject extraButtonGearUncommon;

	[SerializeField]
	private GameObject extraButtonGearExceptional;

	[SerializeField]
	private GameObject extraButtonGearRare;

	[SerializeField]
	private GameObject extraButtonGearCommonCountBubble;

	[SerializeField]
	private GameObject extraButtonGearUncommonCountBubble;

	[SerializeField]
	private GameObject extraButtonGearExceptionalCountBubble;

	[SerializeField]
	private GameObject extraButtonGearRareCountBubble;

	[Space]
	[SerializeField]
	private GameObject toggleAutoMaxOn;

	[SerializeField]
	private GameObject toggleAutoMaxOff;

	private int HRFPQJEQIJS;

	[SerializeField]
	private Animator craftAnimation;

	[NonSerialized]
	public WorkshopPanel owner;

	private global::HIJIFHMGTTR<float> RRIJGRKSTTO;

	private bool PKHRPNJGFTF;

	private bool RETFIOSSTIK;

	private bool THEKTMJHOEP;

	private bool IKLGOLRNFNK;

	private bool RTLOGSNKEKO;

	private List<JJHFPNTSRLT.WeaponPart> MMTHMSINOGN;

	private WorkshopRecipe LQKPOLSLLJQ;

	private List<LootElement> LKFIQNGFJHM;

	public void InitialSetup()
	{
	}

	public void Setup(WorkshopRecipe LQKPOLSLLJQ)
	{
	}

	public void OnDisable()
	{
	}

	private void GTRFKTMGQOI()
	{
	}

	public void TryAddSingular()
	{
	}

	private void HMPEOKSLGHK()
	{
	}

	private void FERFFPTMNJL()
	{
	}

	private void OLMPOMHMPNE()
	{
	}

	private void JIQOQGNHLFO()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void GELFLOPHSMF()
	{
	}

	private void TIKEKFJHTGO(WorkshopOwnedCell GGOKJRGSMRT)
	{
	}

	private bool NQPGJLGSHFL(LootElement INNLJIGRFOG, bool FEIMSRQTLIJ = true)
	{
		return false;
	}

	private bool EIPTPOKPJHG(LootElement INNLJIGRFOG, int EHORJPHLGLL, ref int IKOFTMGIHSS)
	{
		return false;
	}

	private bool PFFEKNOTRPI(LootElement INNLJIGRFOG)
	{
		return false;
	}

	public void TryAddGear(ItemGear IKONITGHGEQ)
	{
	}

	private void EIKEEQERTJQ(WorkshopAddedCell GGOKJRGSMRT)
	{
	}

	public void OnCraftButton()
	{
	}

	public void OnCancelButton()
	{
	}

	public void OnToggleAutoMax()
	{
	}

	public void OnOpenTutorialResourcesReturned()
	{
	}

	public void OnCloseTutorialResourcesReturned()
	{
	}

	public WorkshopFulfiller GetFulfiller()
	{
		return null;
	}

	public WorkshopRecipe GetRecipe()
	{
		return null;
	}

	private FloatingErrorText KMQIMTNTOMN(string HETQTIKJGNI, Transform HSSNSPQEIGR = null)
	{
		return null;
	}

	private void MLMRKJLOSNQ()
	{
	}

	public void OnCraftAnimationFinished()
	{
	}

	public bool IsCraftAnimationPlaying()
	{
		return false;
	}

	private void LQKIIIOFOSK()
	{
	}

	private void LSROKEQETNG(bool FQLQJIMISGO = false)
	{
	}

	private void QSPGFQJIHGK()
	{
	}

	private void EGRRTIOSFNS()
	{
	}

	private void RKQOIKPRSQK()
	{
	}

	private void QHQJSEQQNLN()
	{
	}

	private void GJFQJOKOKSO(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL, bool IKOFTMGIHSS)
	{
	}

	public void OnExtraButtonCommon()
	{
	}

	public void OnExtraButtonUncommon()
	{
	}

	public void OnExtraButtonExceptional()
	{
	}

	public void OnExtraButtonRare()
	{
	}

	private bool EFRELGQHONI()
	{
		return false;
	}

	private IFELIQHQKQN QINOPPEJPRK()
	{
		return default(IFELIQHQKQN);
	}

	[CompilerGenerated]
	private int RSOKGLNGTQJ(JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
		return 0;
	}

	[CompilerGenerated]
	private void GISFEITROLH(GameObject OQORKHMOHSG, bool SMJFTKGRFLJ, JJHFPNTSRLT.PQRIQGIOGQT OEESQHTSGJL)
	{
	}
}
