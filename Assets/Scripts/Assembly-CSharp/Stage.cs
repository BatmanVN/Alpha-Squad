using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MersenneTwister;
using UnityEngine;
using UnityEngine.AI;

public class Stage : MonoBehaviour
{
	public enum PQHGSRPEIGR
	{
		UNSET = 0,
		PREPARED = 1,
		STARTED = 2,
		FAILED = 3,
		COMPLETED = 4
	}

	[CompilerGenerated]
	private sealed class HFOGSNQKERH
	{
		public GameController.KFPHKOMNHSS playType;

		internal bool _003CSpawnStart_003Eb__0(LevelController.StageAddressableEntry s)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class TOHPRRJGTJO
	{
		public GameController.KFPHKOMNHSS playType;

		internal bool _003CSpawnFinish_003Eb__0(LevelController.StageAddressableEntry s)
		{
			return false;
		}
	}

	[TextArea]
	public string comments;

	public PQHGSRPEIGR state;

	public static List<object> startHolders;

	[SerializeField]
	private Rect cameraFollowBounds;

	[SerializeField]
	private Bounds navMeshbounds;

	[SerializeField]
	private StageObjSpawner startSpawner;

	[SerializeField]
	private StageObjSpawner finishSpawner;

	private StageFinish NMTOJPIJLKJ;

	private StageStart KQSFOENOONK;

	private HEPTMPFPKPP GJTHIPHQFKK;

	private List<Enemy> JKQFRNGOOJS;

	private List<Lootbox> GRSLQLHQIIQ;

	[SerializeField]
	private EnemySpot[] enemySpots;

	private Miniboss IJRMNKPIOPF;

	[SerializeField]
	private NavMeshData navigation;

	private NavMeshDataInstance MFJKMSGRHMS;

	private MTRandom MQORMJQMJRH;

	private bool RIMSIPGNTNM;

	private bool EQHMEFFKHSK;

	private bool QHPQKRQIJKR;

	private EnemySpot NHFLPEQFPLR;

	public Task Setup()
	{
		return null;
	}

	private Task OLJGNQMNNKS(GameController.KFPHKOMNHSS NSQRHJPNSGL)
	{
		return null;
	}

	private Task FREHRPNSKEP(GameController.KFPHKOMNHSS NSQRHJPNSGL)
	{
		return null;
	}

	private void PMHRSPJOJTF()
	{
	}

	public HEPTMPFPKPP GetGameplayMode()
	{
		return null;
	}

	public MTRandom GetStageRandom()
	{
		return null;
	}

	public int GetMaxNonSkulledKilledEnemyLevel()
	{
		return 0;
	}

	public Task SpawnMiniboss(EnemySpot ESKFGMNRFQK = null)
	{
		return null;
	}

	public EnemySpot GetMinibossSpawnSpot()
	{
		return null;
	}

	public Task SpawnEnemies()
	{
		return null;
	}

	public void SpawnLootboxes()
	{
	}

	public void StaticBatch()
	{
	}

	private void TFLPFKSFTST(GameObject HIFFPIRQPSN, List<GameObject> OEIITHTPMTT)
	{
	}

	public void AddEnemy(Enemy PFIHOFSRMEH)
	{
	}

	public uint GetStageSeed()
	{
		return 0u;
	}

	private void TQMOSIIOOIH()
	{
	}

	public void TeleportPlayerToSpawnPoint()
	{
	}

	private Transform RTMJGMKJKJM()
	{
		return null;
	}

	private void Update()
	{
	}

	private bool QJKQRNJFMRM()
	{
		return false;
	}

	private bool HSGMFMGENTH()
	{
		return false;
	}

	public bool AreObjectivesCompleted()
	{
		return false;
	}

	public bool AreAllLootboxesOpened()
	{
		return false;
	}

	public List<Enemy> GetAllEnemies()
	{
		return null;
	}

	public Miniboss GetMiniboss()
	{
		return null;
	}

	public List<Lootbox> GetLootboxes()
	{
		return null;
	}

	public EnemySpot[] GetEnemySpots()
	{
		return null;
	}

	public CameraController.ENLHOSOLLEN GetCameraData()
	{
		return default(CameraController.ENLHOSOLLEN);
	}

	public void FinishStage()
	{
	}

	public void FailStage(LQJTRNFQISM EMERMLLSHSL, Actor NIHPIGRSJMO)
	{
	}

	public void OnRevive()
	{
	}

	public StageFinish GetFinish()
	{
		return null;
	}

	public StageStart GetStart()
	{
		return null;
	}

	private void RTMQFPTPNMH()
	{
	}

	public void DisallowFinish()
	{
	}

	private bool MKRHQTRPQFI()
	{
		return false;
	}

	public bool IsFinishOpen()
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}

	public void KillAllEnemies()
	{
	}

	public void KillAllAliveEnemies()
	{
	}

	public bool AreAllEnemiesDead()
	{
		return false;
	}

	public bool IsSomeEnemyTargetingPlayer()
	{
		return false;
	}

	public int GetAliveEnemyCount()
	{
		return 0;
	}

	public int GetID()
	{
		return 0;
	}

	public void PrintLevelInfo()
	{
	}

	public string GetStageInfo()
	{
		return null;
	}

	public bool IsValid()
	{
		return false;
	}

	public bool IsChallenge()
	{
		return false;
	}

	public void UpdateCameraBounds()
	{
	}

	public NavMeshData GetNavMeshData()
	{
		return null;
	}

	public void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void ApplyNavMesh()
	{
	}

	public void RemoveNavMesh()
	{
	}

	public void GatherEnemySpots()
	{
	}

	public void GatherStartAndFinishSpawners()
	{
	}

	[CompilerGenerated]
	internal static string HNTJIQINKOL(EnemySpot.OOSTRKKLKGI EMKNPKTIJPF)
	{
		return null;
	}
}
