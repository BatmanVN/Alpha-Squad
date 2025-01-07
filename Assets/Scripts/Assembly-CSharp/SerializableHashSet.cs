using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

[Serializable]
public abstract class SerializableHashSet<T> : SerializableHashSetBase, ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver, IDeserializationCallback, ISerializable
{
	private JPFQQNEOOGO<T> m_hashSet;

	[SerializeField]
	private T[] m_keys;

	public int Count => 0;

	public bool IsReadOnly => false;

	public SerializableHashSet()
	{
	}

	public SerializableHashSet(ISet<T> FJJOLOHOQTE)
	{
	}

	public void KLNHRFEOEGR(ISet<T> FJJOLOHOQTE)
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public bool Add(T HPJMQLRTORF)
	{
		return false;
	}

	public void ExceptWith(IEnumerable<T> FKQLEGQSLHF)
	{
	}

	public void IntersectWith(IEnumerable<T> FKQLEGQSLHF)
	{
	}

	public bool IsProperSubsetOf(IEnumerable<T> FKQLEGQSLHF)
	{
		return false;
	}

	public bool IsProperSupersetOf(IEnumerable<T> FKQLEGQSLHF)
	{
		return false;
	}

	public bool IsSubsetOf(IEnumerable<T> FKQLEGQSLHF)
	{
		return false;
	}

	public bool IsSupersetOf(IEnumerable<T> FKQLEGQSLHF)
	{
		return false;
	}

	public bool Overlaps(IEnumerable<T> FKQLEGQSLHF)
	{
		return false;
	}

	public bool SetEquals(IEnumerable<T> FKQLEGQSLHF)
	{
		return false;
	}

	public void SymmetricExceptWith(IEnumerable<T> FKQLEGQSLHF)
	{
	}

	public void UnionWith(IEnumerable<T> FKQLEGQSLHF)
	{
	}

	private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EAdd(T HPJMQLRTORF)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T HPJMQLRTORF)
	{
		return false;
	}

	public void CopyTo(T[] JGTIHIJPMRI, int IHRMILOGPQS)
	{
	}

	public bool Remove(T HPJMQLRTORF)
	{
		return false;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	public void OnDeserialization(object KMJOPIEMFRK)
	{
	}

	protected SerializableHashSet(SerializationInfo RQQHGKJRQNR, StreamingContext OREERJJJFSO)
	{
	}

	public void GetObjectData(SerializationInfo RQQHGKJRQNR, StreamingContext OREERJJJFSO)
	{
	}
}
