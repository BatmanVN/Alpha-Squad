using System.Runtime.CompilerServices;
using UnityEngine;

public class BaseMenuTileLayout : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MKNJFPOKSSL
	{
		public BaseMenuTile.OFELPTRRILJ tileType;

		internal bool _003CGetTile_003Eb__0(BaseMenuTile x)
		{
			return false;
		}
	}

	[HideInInspector]
	public BuildMenuViewer owner;

	[SerializeField]
	private BaseMenuTile[] tiles;

	public void Setup()
	{
	}

	public void OnTileClick(BaseMenuTile JOTSJKFPFFF)
	{
	}

	public void SelectTile(BaseMenuTile.OFELPTRRILJ PNPKPMISSMI, bool JEPRTELNILG = true)
	{
	}

	public void SetSelectedTile(BaseMenuTile.OFELPTRRILJ PNPKPMISSMI, bool KQGHGPEKKTJ = true)
	{
	}

	public BaseMenuTile GetTile(BaseMenuTile.OFELPTRRILJ PNPKPMISSMI)
	{
		return null;
	}

	public void EnableAllTiles()
	{
	}

	public void DisableAllTiles()
	{
	}

	public void EnableOnlySpecificTile(BaseMenuTile.OFELPTRRILJ PNPKPMISSMI)
	{
	}
}
