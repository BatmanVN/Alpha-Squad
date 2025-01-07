using System;
using UnityEngine;

[CreateAssetMenu]
public class AnimationTypeMap : ScriptableObject
{
	[Serializable]
	public class TypeMap
	{
		public WeaponData.NPFHJORTJIG weaponType;

		public MeleeMap melee;

		public RangedMap ranged;
	}

	[Serializable]
	public class MeleeMap : SerializableDictionary<WeaponData.EROOPMNJEIR, AnimatorOverrideController>
	{
	}

	[Serializable]
	public class RangedMap : SerializableDictionary<WeaponData.FOTPMHNRNFK, AnimatorOverrideController>
	{
	}

	public TypeMap[] map;
}
