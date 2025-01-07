using System;
using UnityEngine;

public class GamestotyServerManager : MonoBehaviour
{
	[Serializable]
	public class GamestotyServerTime
	{
		public int ts_int;
	}

	public static int GetServerTime()
	{
		return 0;
	}
}
