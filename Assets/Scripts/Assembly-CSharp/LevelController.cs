using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
	[Serializable]
	public struct Data
	{
		public int stageIndex;

		public int currentStageId;

		public uint stageSeed;

		public bool analyticsSent;

		public TrackingData tracking;

		public int revivesUsed;
	}

	[Serializable]
	public struct Config
	{
		public int[] lootboxCooldown;
	}

	[Serializable]
	public struct RunData
	{
		public GameController.KFPHKOMNHSS playType;

		public int levelIndex;

		public int areaIndex;

		public int episodeIndex;

		public bool isEpisodes;

		public WorldData.JQNPLTQOFMJ worldType;

		public int currentStageIndex;

		public int totalStages;

		public bool win;

		public bool finished;

		public bool dropsEnabled;

		public bool tutorial;

		public int weaponsDropped;

		public bool firstTime;

		public bool bossStage;

		public int startTimestamp;

		public bool worldCompleted;

		public int numAreas;

		public bool firstStageLoad;

		public WeaponData.OHHQFFINRQH firstShotWeapon;

		public int globalLevelIndex;

		public EpisodeController.AreaConfig ETSJFLMKNJM()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public struct TrackingData
	{
		[Serializable]
		public class Loadout
		{
			public int weaponId;

			public int legendaryId;

			public int upgradeLevel;

			public int rarity;

			public int itemLevel;

			public int damageDone;

			public int enemiesKilled;

			public int elitesKilled;

			public int[] bonuses;

			public float[] bonusRolls;
		}

		[Serializable]
		public class GearSelection
		{
			[Serializable]
			public struct GearBonusMin
			{
				public int id;

				public int rarity;
			}

			public int id;

			public GearBonusMin[] gbonuses;

			public static GearSelection MOLHFNTIFQH(ItemGear IKONITGHGEQ)
			{
				return null;
			}
		}

		public int playType;

		public int agentId;

		public int completed;

		public int worldID;

		public int challengeID;

		public int levelIndex;

		public int stageID;

		public int totalDamageDone;

		public int enemiesSeen;

		public int elitesSeen;

		public int highestEnemyLevel;

		public int playerCP;

		public int recommendedCP;

		public int healthStart;

		public int healthFinish;

		public IRHNENTFPPM agentSkinId;

		public Loadout[] loadout;

		public GearSelection[] gear;
	}

	[Serializable]
	public class StageAddressableEntry
	{
		public GameController.KFPHKOMNHSS type;

		public AssetReferenceT<GameObject> start;

		public AssetReferenceT<GameObject> finish;
	}

	[Serializable]
	private struct AnalyticsContext
	{
		public int worldType;

		public int difficultyIndex;

		public int levelIndex;
	}

	[CompilerGenerated]
	private sealed class PPQROHINRTO
	{
		public EnemySpot.SMMGLQPTJET minibossToLoad;

		internal bool _003CGetMinibossConfig_003Eb__0(EnemyMap.EnemyAddressableEntry x)
		{
			return false;
		}
	}

	public const bool DEBUG = false;

	public List<Task> stageTasks;

	public Data data;

	public RunData runData;

	public EnemyMap enemyMap;

	public Image stageFade;

	public Stage currentStage;

	public Stage lastStage;

	public AsyncOperationHandle<GameObject> stageLoadingHandle;

	public bool stageLoaded;

	public List<StageAddressableEntry> stageParts;

	public Action OnFinishAllowed;

	public Action OnStageObjectivesCompleted;

	public Action<Enemy> OnEnemyAdded;

	public Action<Enemy, float, LQJTRNFQISM> OnEnemyTakenClampedDamage;

	public bool currentStageCompleted;

	public bool currentStageFailed;

	public EKFFMKLSSNN gameMode;

	[NonSerialized]
	public bool fastSwitching;

	private string GEJJESORNPJ;

	public Config config;

	[NonSerialized]
	public bool debuggingLevels;

	public static int[] allStages;

	private bool KSMLQSONMGF;

	private bool SNJHNOQSFGP;

	private float QEERPLHFPJF;

	private bool JEQEOEKLJTF;

	public static string DATA_KEY;

	public event Action GIRIEFKOMKI
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

	public event Action ITJFJIIKJRH
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

	public event Action TKSHHRHQIGT
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

	public event Action PHITQQNOKKH
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

	public event Action FIJILFNPJIP
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

	public event Action NOKHPQNIOIF
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

	public event Action IQQLOKGIMST
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

	public event Action RTQGSSISHJQ
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

	public event Action MIOTHPLQMQM
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

	public event Action<LQJTRNFQISM, Enemy> OHFSMFGFPHH
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

	private void OnDisable()
	{
	}

	private void FKTTQQHRMFO()
	{
	}

	private void IPKFIMOLIIG()
	{
	}

	private void ERTPSRRPQQK(AsyncOperationHandle<IList<IResourceLocation>> HNTPNTJRJMH)
	{
	}

	private void PMITOIOJNOT()
	{
	}

	private void KLJEPKORMLM()
	{
	}

	public static Data LoadDataCopy()
	{
		return default(Data);
	}

	public static void ClearData()
	{
	}

	public void AbandoningChallenge()
	{
	}

	public void ExitingScene()
	{
	}

	private void Start()
	{
	}

	private void OKPSTPLJSSN(string SLRMLOOSEGG)
	{
	}

	public void StartLevel()
	{
	}

	private void TKPPPJHNTTK()
	{
	}

	public void InstantiateStage(AsyncOperationHandle<GameObject> GHGHFHSPSHH)
	{
	}

	private void TSONMFQETII()
	{
	}

	private void Update()
	{
	}

	public void PrepareStage()
	{
	}

	public void DOFade(float LNSJINILNNO)
	{
	}

	public bool IsFadingIn()
	{
		return false;
	}

	private void FQGNFTMTNPT()
	{
	}

	private void HSNNOIRJMIG(float NSQGRQMGOJS, LQJTRNFQISM EMERMLLSHSL, Actor NIHPIGRSJMO)
	{
	}

	private void HKTIQINNEGS(LQJTRNFQISM EMERMLLSHSL, Actor NIHPIGRSJMO)
	{
	}

	public void StageCompleted()
	{
	}

	public static void StepLootbox(bool SISHFRTREPG)
	{
	}

	private bool OSPLNFSOJQO()
	{
		return false;
	}

	public bool IsMinibossStage()
	{
		return false;
	}

	public bool IsLastStage()
	{
		return false;
	}

	public MinibossConfig GetMinibossConfig()
	{
		return null;
	}

	public float GetNormalizedLevelProgress()
	{
		return 0f;
	}

	public void LevelCompleted(bool FQLPTFNNMKE = true)
	{
	}

	public void LevelFailed()
	{
	}

	public void LevelFailedFinal()
	{
	}

	private void GPTPJTMLMLL()
	{
	}

	public void OnRevive()
	{
	}

	private AsyncOperationHandle<GameObject> ILIHLTOEIOP()
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	private AsyncOperationHandle<GameObject> RRREGJPIIKF(int HSLQJLPMLMH)
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	public bool DoesStageExist(int HSLQJLPMLMH)
	{
		return false;
	}

	public bool IsEnemyTypeAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return false;
	}

	public bool IsEnemyEliteAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE)
	{
		return false;
	}

	public int GetEnemyLevelForCurrentStage()
	{
		return 0;
	}

	public float GetEliteChanceForCurrentStage()
	{
		return 0f;
	}

	public int GetEliteLevelAddForCurrentStage()
	{
		return 0;
	}

	public EnemyCount GetEnemyCountForCurrentStage()
	{
		return default(EnemyCount);
	}

	public static void CheckLootboxCooldown()
	{
	}

	public static void GenerateLootboxCooldown()
	{
	}

	private string RGKKFRJHEFK()
	{
		return null;
	}

	public void DebugStageLeftButton()
	{
	}

	public void DebugStageRightButton()
	{
	}

	public string GetCurrentAnalyticsContext()
	{
		return null;
	}

	public void PlayerShot(WeaponData QTRSFNTGTSR)
	{
	}

	[CompilerGenerated]
	private void IHRLGRRKHOG(Enemy PFIHOFSRMEH)
	{
	}
}
