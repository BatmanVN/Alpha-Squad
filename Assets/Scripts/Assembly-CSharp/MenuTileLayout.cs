using System.Runtime.CompilerServices;
using UnityEngine;

public class MenuTileLayout : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class SNHTHLQOGHM
	{
		public MenuTile.ONITTJRRQRK tileType;

		internal bool _003CGetTile_003Eb__0(MenuTile x)
		{
			return false;
		}
	}

	[HideInInspector]
	public MenuViewer owner;

	[SerializeField]
	private MenuTile[] tiles;

	public void Setup()
	{
	}

	public void OnTileClick(MenuTile JOTSJKFPFFF)
	{
	}

	public void TryUpdateTiles()
	{
	}

	public void SetSelectedTile(MenuTile.ONITTJRRQRK PNPKPMISSMI, bool KQGHGPEKKTJ = true)
	{
	}

	public MenuTile GetTile(MenuTile.ONITTJRRQRK PNPKPMISSMI)
	{
		return null;
	}

	public void EnableAllTiles()
	{
	}

	public void EnableOnlySpecificTile(MenuTile.ONITTJRRQRK PNPKPMISSMI)
	{
	}
}
