using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AgentListPage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KQPQTQFISSK
	{
		public Agent agent;

		internal bool _003CTryUpdateCell_003Eb__0(AgentListCell c)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class RGHSKJSEFPJ
	{
		public Agent clickedAgent;

		internal void _003CRefreshSelectedAndClicked_003Eb__0(AgentListCell cell)
		{
		}
	}

	[SerializeField]
	private AgentListCell prefabCell;

	[Space]
	[SerializeField]
	private RectTransform cellParent;

	[NonSerialized]
	public MenuAgentPanel owner;

	[NonSerialized]
	public List<Agent> data;

	private List<AgentListCell> PHTKEJTOQRG;

	public void Setup(List<Agent> TSRPFHOJKSG)
	{
	}

	public bool TryUpdateCell(Agent IFLMHEQTKLS)
	{
		return false;
	}

	public void RefreshSelectedAndClicked(Agent KEMTSHKRKMS)
	{
	}
}
