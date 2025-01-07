using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class SkinData : ScriptableObject
{
	public enum JLLOHGFJSQJ
	{
		DEFAULT = -1,
		UNSET = 0,
		GEMS = 1,
		REAL_MONEY = 2,
		CASH = 3,
		VIP = 4,
		HALLOWEEN = 5
	}

	[Flags]
	public enum QSMEJIQHPHN
	{
		None = 0,
		Gameplay = 2,
		UI = 4,
		Intro = 8
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct IPQIEKOMSIT
	{
		public Transform parent;
	}

	public IRHNENTFPPM id;

	public Sprite icon;

	public JJHFPNTSRLT.PQRIQGIOGQT rarity;

	public JLLOHGFJSQJ unlockType;

	public int unlockPrice;

	public int poseNumber;

	public bool showIfLocked;

	[Space]
	public AssetReferenceT<GameObject> prefab;

	public AssetReferenceT<Mesh> mesh;

	public AssetReferenceT<Material>[] materials;

	public bool customIntro;

	public RuntimeAnimatorController customIntroAnimation;

	public Color customIntroColor0;

	public Color customIntroColor1;

	public bool customIntroChangeWeapon;

	public WeaponData customIntroWeapon;

	public string purchaseId => null;

	public Task<GameObject> NJNRTTHSTQK(Transform JKFPSLRREIJ, QSMEJIQHPHN EMKNPKTIJPF = QSMEJIQHPHN.None)
	{
		return null;
	}

	public Task<Material[]> LTGELEPONHH()
	{
		return null;
	}

	public Task<Mesh> LNJGJIRPGHM()
	{
		return null;
	}

	private bool RMQIEGMMMPQ()
	{
		return false;
	}

	private bool FSPHPNETHON()
	{
		return false;
	}

	public void PEGMISNSPFF()
	{
	}

	[CompilerGenerated]
	internal static bool IFKFQSTFGJJ(ref IPQIEKOMSIT P_0)
	{
		return false;
	}
}
