using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nakama;
using UnityEngine;

public class ClanBaseManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LNSMNORNPTP
	{
		public ClanBaseRoom room;
	}

	public static Action OnClanEmblemChanged;

	public static Action<int> OnActiveRoomChanged;

	public static ClanBaseManager Instance;

	[NonSerialized]
	public List<ClanBaseRoom> enteredRooms;

	[SerializeField]
	private SerializableDictionary<ClanBaseRoom.JFKMJEPEHOK, ClanBaseRoom> clanRooms;

	private int JIFGHLSQTOO;

	[SerializeField]
	private ClanBotManager botManager;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void IJFGLEPOKRT(IApiChannelMessage HNTPNTJRJMH)
	{
	}

	private void NIOIONHGIJH()
	{
	}

	private Task QKPTJEGLPIQ()
	{
		return null;
	}

	public void UpdateBots()
	{
	}

	private void Update()
	{
	}

	public void EnterRoom(ClanBaseRoom SLIEEELQMQS)
	{
	}

	public void ExitRoom(ClanBaseRoom SLIEEELQMQS)
	{
	}

	private void OLSNPOMKKSH()
	{
	}

	public void Exit()
	{
	}

	public void SetActiveRoom(int OJJLFPMNEHN)
	{
	}

	public void UpdateRoomVisual(int OJJLFPMNEHN, bool GRNTERLHTJO)
	{
	}

	private void PTHLTOOSQSR(ClanBaseRoom.JFKMJEPEHOK JGNPTHMJIEO)
	{
	}

	public void TryPlayUpgradeEffect(ClanBaseRoom SLIEEELQMQS)
	{
	}

	public int GetActiveRoomId()
	{
		return 0;
	}

	public ClanBaseRoom GetRoom(ClanBaseRoom.JFKMJEPEHOK EOOEIROQJOE)
	{
		return null;
	}

	public static void SetFakeShadows(int PSPJIJNTMOI)
	{
	}

	private void OnApplicationFocus(bool JQOIPNNJLHH)
	{
	}

	private Task RQJSQJHJLJS()
	{
		return null;
	}

	public void DebugSetRoomVisual(int OJJLFPMNEHN, int TOHTOFEHMHM)
	{
	}
}
