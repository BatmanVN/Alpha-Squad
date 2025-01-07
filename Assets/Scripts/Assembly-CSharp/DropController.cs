using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class DropController : MonoBehaviour
{
	[Serializable]
	public class DropsCollection
	{
		public List<LootElement> loot;

		public void MFEFSLSRRFT(LootElement INNLJIGRFOG)
		{
		}

		public void TLLJMIFFIGO(List<LootElement> GSOLTKSNTML)
		{
		}

		public List<LootElement> LHFEEOHIKSO()
		{
			return null;
		}

		public bool MTHNKEPKFJI()
		{
			return false;
		}

		public bool JRSMGNEEHQQ(bool NGSLNTSRSTS)
		{
			return false;
		}

		public void THTHNSPOMOP(DropsCollection FKQLEGQSLHF)
		{
		}

		public void IPFMPHMLTEM()
		{
		}
	}

	[Serializable]
	public class Data
	{
		public DropsCollection picked;

		public DropsCollection unpicked;
	}

	[CompilerGenerated]
	private sealed class FLQPMRJSTQE
	{
		public List<LootElement> ll;

		internal void _003CUpdateData135_003Eb__1(ItemWeapon x)
		{
		}
	}

	[CompilerGenerated]
	private sealed class JPMOTRNSIQR
	{
		public int amountPerObject;

		public int rewardLeft;

		public int numObjects;

		public DropController _003C_003E4__this;

		public Vector3 position;

		public float addedPickupDelay;

		public int i;

		public TweenCallback _003C_003E9__0;

		internal void _003CDropCash_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class QTNNKRSGGTJ
	{
		public int amount;

		public DropController _003C_003E4__this;

		public Vector3 position;

		public float addedPickupDelay;

		public TweenCallback _003C_003E9__0;

		internal void _003CDropGem_003Eb__0()
		{
		}
	}

	private const float PENHSLKNTJJ = 0.03f;

	private const float JMGOQQFJNKO = 0.25f;

	[SerializeField]
	public GameObject[] lootVFXPrefabs;

	[SerializeField]
	public GameObject lootVFXPrefabLegendary;

	[SerializeField]
	public GameObject[] lootSpawnVFXPrefabs;

	[SerializeField]
	public GameObject lootSpawnVFXPrefabLegendary;

	[SerializeField]
	private Cash cashPrefab;

	[SerializeField]
	private Gem gemPrefab;

	[SerializeField]
	private Wrench wrenchPrefab;

	[SerializeField]
	private GearFragment gearFragmentPrefab;

	[SerializeField]
	private EventPumpkin eventPumpkinPrefab;

	[SerializeField]
	private EventPresent eventPresentPrefab;

	[SerializeField]
	private EventBitCard eventBitCardPrefab;

	[SerializeField]
	private AgentCard agentCardPrefab;

	[SerializeField]
	private WeaponScrap weaponScrapPrefab;

	[SerializeField]
	private WeaponChestToken weaponChestTokenPrefab;

	[SerializeField]
	private ArcadePassCoin arcadePassCoinPrefab;

	[SerializeField]
	private ResourceChestToken resourceChestTokenPrefab;

	[SerializeField]
	private Hammer hammerPrefab;

	[SerializeField]
	private HealPickup healPrefab;

	[SerializeField]
	private ItemDrop dropPrefab;

	[SerializeField]
	private GameObject cashSpawnEffect;

	[SerializeField]
	private GameObject gemSpawnEffect;

	[SerializeField]
	private GameObject healSpawnEffect;

	public Color[] rarityColors;

	public Color[] materialColors;

	public Sprite[] rarityStars;

	public Data data;

	private LootList GKSITNHMPRI;

	public static string KEY;

	public event Action<DropsCollection> LQPMKGISRNJ
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

	public event Action EOSFIPLERIG
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

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void KLJEPKORMLM()
	{
	}

	private void NSRGMEFPSPL()
	{
	}

	public void SaveData()
	{
	}

	public void ClearAllData()
	{
	}

	public static void ClearSavedDataOnly()
	{
	}

	private void HENELGRIJLH()
	{
	}

	private void ILKGHTKLRJN()
	{
	}

	private void QKNNTOTNRJF()
	{
	}

	public void SaveUnpickedLoot()
	{
	}

	private void ENRFJIJHPPI()
	{
	}

	public bool HasCollectedLoot()
	{
		return false;
	}

	public bool HasUncollectedLoot(bool NGSLNTSRSTS = false)
	{
		return false;
	}

	public static void AddDropCollectionToInventory(DropsCollection JONGJFLGQHH, string ENSHQFNLRJT = "")
	{
	}

	public void AddUnpickedLootToInventory()
	{
	}

	public void MoveUnpickedLootToPicked()
	{
	}

	public void ClearUnpickedLoot()
	{
	}

	public void ClearPickedLoot()
	{
	}

	private void REHNMIPHJJI()
	{
	}

	public void CreateEnemyDrop(Enemy EESTGTGKLJG)
	{
	}

	public void CreateLootboxDrop(Lootbox EESTGTGKLJG)
	{
	}

	public void CreateLootboxGemsDrop(LootboxGems EESTGTGKLJG)
	{
	}

	public void CreateLootboxOperationsDrop(LootboxOperations EESTGTGKLJG)
	{
	}

	public void CreateLootboxAgentCardsDrop(LootboxAgentCards EESTGTGKLJG)
	{
	}

	public void CreateLootboxWeaponScrapDrop(LootboxWeaponScrap EESTGTGKLJG)
	{
	}

	private float STGMSTHNFER(Vector3 JSMLIQPPPQS, LootElement QHSMPFPKNMM, float PPKNGMJMPRM = 0f)
	{
		return 0f;
	}

	private float HOITKKMRTRN(Vector3 JSMLIQPPPQS, int ISLTSKEPJPI, int FTKPLQNOEPM, int SHTKHSOJNTT = 0, float PPKNGMJMPRM = 0f)
	{
		return 0f;
	}

	private float NLNPFHEFQSP(Vector3 JSMLIQPPPQS, int ISLTSKEPJPI, float PPKNGMJMPRM = 0f)
	{
		return 0f;
	}

	private void JESFPGINTEK(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void EHQIPMIELHQ(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void GQTOIOTSQOJ(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void ILEGRHMTHHI(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void QKMOMJPMINL(Vector3 HSSNSPQEIGR, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int ISLTSKEPJPI = 1, bool NHJOHGHQNSS = false, float PPKNGMJMPRM = 0f)
	{
	}

	private void NSQTLSRLPJT(Vector3 HSSNSPQEIGR, WeaponData.OHHQFFINRQH EMKNPKTIJPF, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void RGTJQSESILN(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void LGMGSKHIEOG(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void JOSFQGSTSMQ(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void ROTLFEESKLE(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void HSPFPJFHRRR(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void TFLPKTKLNOO(Vector3 HSSNSPQEIGR, int ISLTSKEPJPI = 1, float PPKNGMJMPRM = 0f)
	{
	}

	private void KMGHFQSOLKM(Vector3 PQNITOOPPOG, int RRPSNPOTQNT, float PPKNGMJMPRM = 0f)
	{
	}

	private void GRNLQJNSHJK(Vector3 PQNITOOPPOG, int RRPSNPOTQNT, float PPKNGMJMPRM = 0f)
	{
	}

	private void HGSKJLOPNEJ(Vector3 PQNITOOPPOG, WeaponData.OHHQFFINRQH EMKNPKTIJPF, int RRPSNPOTQNT, float PPKNGMJMPRM = 0f)
	{
	}

	private void FQGTGNIQHTE(Vector3 PQNITOOPPOG, ItemWeapon HPJMQLRTORF, float PPKNGMJMPRM = 0f)
	{
	}

	private void TLILNQKNGOT(Vector3 PQNITOOPPOG, float PPKNGMJMPRM = 0f)
	{
	}

	private void JFSNGFIRQLO(Vector3 PQNITOOPPOG, float PPKNGMJMPRM = 0f)
	{
	}

	private void ELOKIQNLHFN(Vector3 PQNITOOPPOG, float PPKNGMJMPRM = 0f)
	{
	}

	private void NNQHJHLMLTG(Vector3 PQNITOOPPOG, int RRPSNPOTQNT, float PPKNGMJMPRM = 0f)
	{
	}

	private void JLPTTFFPLJO(Vector3 PQNITOOPPOG, int RRPSNPOTQNT, float ENMITMNQHJS = 0f)
	{
	}

	private void GGJHKJHFKHT(Vector3 PQNITOOPPOG, int RRPSNPOTQNT, float ENMITMNQHJS = 0f)
	{
	}

	private void QSHELKNGNRF(Vector3 PQNITOOPPOG, int RRPSNPOTQNT, float PPKNGMJMPRM = 0f)
	{
	}

	private void JKGGOMQHGPR(Vector3 PQNITOOPPOG, float PPKNGMJMPRM = 0f)
	{
	}

	private void QJERQHKQSHM(Vector3 PQNITOOPPOG, int ISLTSKEPJPI, float PPKNGMJMPRM = 0f)
	{
	}

	private void OMKJFRJOGSP(Vector3 PQNITOOPPOG, JJHFPNTSRLT.PQRIQGIOGQT MOTTITEELQF, int ISLTSKEPJPI, float PPKNGMJMPRM = 0f)
	{
	}

	private void FEFMITJJENI(Vector3 PQNITOOPPOG, int ISLTSKEPJPI, float PPKNGMJMPRM)
	{
	}

	private void MEOOLQFFEEF(Vector3 PQNITOOPPOG, int ISLTSKEPJPI, float PPKNGMJMPRM)
	{
	}

	private void PKEJPJIKERL(Vector3 PQNITOOPPOG, float PPKNGMJMPRM = 0f)
	{
	}

	private void RFQTOQMNOMT(Enemy PFIHOFSRMEH)
	{
	}

	public void Test(EnemySpot.SMMGLQPTJET EOOEIROQJOE, int IQLQQNIPTPQ, Enemy GRMOIOOPGSL)
	{
	}

	[CompilerGenerated]
	internal static void FGMLIHFHQOE(PJRPMRSRNJS.DropCollection FNHFHEJLEPS, ref DropsCollection NIMSTIFGKET)
	{
	}

	[CompilerGenerated]
	private void EEOPTJLNGLO(Enemy TMNEHEFJGHM, LootList EERHHOKKRIM)
	{
	}
}
