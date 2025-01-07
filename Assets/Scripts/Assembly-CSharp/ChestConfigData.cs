using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class ChestConfigData : LootConfigData
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct NENKRLKOTMN
	{
		public ChestConfigData _003C_003E4__this;

		public int level;
	}

	public Sprite icon;

	public string title_key;

	[SerializeField]
	protected bool boostable;

	public bool selectChest;

	public SoundEffect openSound;

	public GameObject[] prefabs;

	public GameObject sparksParticles;

	public ChestController.MFRETPOLGOE chestQuality;

	public bool seeded;

	public string title => null;

	public bool Boostable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GameObject JENQSRIELIK(int PNIQKIGEHLF = 0)
	{
		return null;
	}

	public string KKMPQSLHNNG()
	{
		return null;
	}

	public void EGPPRLIETSS()
	{
	}

	public void JHGMPLTRJNH()
	{
	}

	public void PQQQJOLHTKI(int KRNIIJJIJNF, int IQLQQNIPTPQ)
	{
	}

	[CompilerGenerated]
	private LootList TNLPORLKILQ(ref NENKRLKOTMN P_0)
	{
		return null;
	}
}
