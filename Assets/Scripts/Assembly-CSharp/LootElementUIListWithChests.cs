using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LootElementUIListWithChests : MonoBehaviour
{
	[SerializeField]
	private LootElementUICell prefabCellLoot;

	[SerializeField]
	private ChestUICell prefabCellChest;

	[Space]
	[SerializeField]
	private RectTransform cellParent;

	[SerializeField]
	private Vector2 sizeChest;

	[SerializeField]
	private Vector2 sizeLootCell;

	private List<LootElementUICell> PHTKEJTOQRG;

	private List<ChestUICell> MEIFNGGQFLF;

	private bool JEGPTJNSGLJ;

	private bool LGJLOKEIOME;

	public event Action<LootElementUICell> RPJQQQQIHJG
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

	public event Action<ChestUICell> TIENENMMTNG
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

	public void Setup(List<LootElement> PETLTREEEHN, List<ChestController.MFRETPOLGOE> NIFGEISKGRR, bool PLOQEPJEQNE = true, bool EHRKEKHLIOL = true, bool ETLKQQTFTJR = true)
	{
	}

	private void EEEHIRIPSPR(List<LootElement> PETLTREEEHN, bool EHRKEKHLIOL)
	{
	}

	private void PTIQROIFHIL(List<ChestController.MFRETPOLGOE> NIFGEISKGRR)
	{
	}

	private LootElementUICell HHFSGQJFIMT(LootElement INNLJIGRFOG)
	{
		return null;
	}

	private ChestUICell HGRQKGNEMPT(ChestController.MFRETPOLGOE MROKKGHHGTN, int SGNNHEROROI = 1)
	{
		return null;
	}

	public List<LootElementUICell> GetCells()
	{
		return null;
	}

	public List<ChestUICell> GetChestCells()
	{
		return null;
	}

	private void QEQOOLNLGRM(LootElementUICell GGOKJRGSMRT)
	{
	}

	private void ROOETSMRGNP(ChestUICell GGOKJRGSMRT)
	{
	}

	public void AnimateIn(float JIGSOIPNHMN = 0f)
	{
	}
}
