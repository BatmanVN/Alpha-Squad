#define SAFE

using System;
using System.Collections.Generic;
using UnityEngine;

public class GameLoopUpdater : MonoSingleton<GameLoopUpdater>
{
    private void Update()
    {
        // if (TimeSystem.IsPause)
        //     return;
        GameLoop.Update();
    }
}

public static class GameLoop
{
    private static readonly List<Action>[] Loops =
    {
        new List<Action>(), // 0
        new(), // 1
        new(), // 2
        new(), // 3
        new(), // 4
        new(), // 5
        new(), // 6
        new()  // 7
    };

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    private static void ManualReload()
    {
        for (var i = 0; i < Loops.Length; i++)
            Loops[i].Clear();
        actionRank.Clear();
    }

    public static readonly Dictionary<Action, int> actionRank = new();

    public static void Add(Action action, int rank = 0)
    {
        if (!actionRank.TryAdd(action, rank)) return;
        Loops[rank].Add(action);
    }
    
    public static void Remove(Action action)
    {
        if (actionRank.Remove(action, out var r))
        {
            Loops[r].Remove(action);
        }
    }
    
    public static void Update()
    {
        for (var i = 0; i < Loops.Length; i++)
        {
            for (var j = Loops[i].Count - 1; j >= 0; j--)
            {
                DoLoop(i, j);
            }
        }
    }

    private static void DoLoop(int i, int j)
    {
        try
        {
            Loops[i][j].Invoke();
        }
        catch (Exception e)
        {
#if UNITY_EDITOR
            Debug.LogError(e);
#endif
        }
    }
}