using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public abstract class SerializableDictionaryBase
{
	public abstract class JRHSNOHOJGR
	{
	}

	protected class SIJFGFIMJRS<TKey, TValue> : Dictionary<TKey, TValue>
	{
		public SIJFGFIMJRS()
		{
		}

		public SIJFGFIMJRS(IDictionary<TKey, TValue> PPQGHNLPIPM)
		{
		}

		public SIJFGFIMJRS(SerializationInfo RQQHGKJRQNR, StreamingContext OREERJJJFSO)
		{
		}
	}
}
[Serializable]
public abstract class SerializableDictionaryBase<TKey, TValue, TValueStorage> : SerializableDictionaryBase, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, ISerializationCallbackReceiver, IDeserializationCallback, ISerializable
{
	private SIJFGFIMJRS<TKey, TValue> m_dict;

	[SerializeField]
	private TKey[] m_keys;

	[SerializeField]
	private TValueStorage[] m_values;

	public ICollection<TKey> Keys => null;

	public ICollection<TValue> Values => null;

	public int Count => 0;

	public bool IsReadOnly => false;

	public TValue Item
	{
		get
		{
			return default(TValue);
		}
		set
		{
		}
	}

	public bool IsFixedSize => false;

	private ICollection System_002ECollections_002EIDictionary_002EKeys => null;

	private ICollection System_002ECollections_002EIDictionary_002EValues => null;

	public bool IsSynchronized => false;

	public object SyncRoot => null;

	public object Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SerializableDictionaryBase()
	{
	}

	public SerializableDictionaryBase(IDictionary<TKey, TValue> PPQGHNLPIPM)
	{
	}

	protected abstract void OOEEOGMFKNG(TValueStorage[] NJKGLQPOPSL, int KQQINSRPRNP, TValue RRPSNPOTQNT);

	protected abstract TValue RKQINGQKGLT(TValueStorage[] NJKGLQPOPSL, int KQQINSRPRNP);

	public void KLNHRFEOEGR(IDictionary<TKey, TValue> PPQGHNLPIPM)
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void Add(TKey QKQMRGKQOMI, TValue RRPSNPOTQNT)
	{
	}

	public bool ContainsKey(TKey QKQMRGKQOMI)
	{
		return false;
	}

	public bool Remove(TKey QKQMRGKQOMI)
	{
		return false;
	}

	public bool TryGetValue(TKey QKQMRGKQOMI, out TValue RRPSNPOTQNT)
	{
		RRPSNPOTQNT = default(TValue);
		return false;
	}

	public void Add(KeyValuePair<TKey, TValue> HPJMQLRTORF)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(KeyValuePair<TKey, TValue> HPJMQLRTORF)
	{
		return false;
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] JGTIHIJPMRI, int IHRMILOGPQS)
	{
	}

	public bool Remove(KeyValuePair<TKey, TValue> HPJMQLRTORF)
	{
		return false;
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	public void Add(object QKQMRGKQOMI, object RRPSNPOTQNT)
	{
	}

	public bool Contains(object QKQMRGKQOMI)
	{
		return false;
	}

	private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
	{
		return null;
	}

	public void Remove(object QKQMRGKQOMI)
	{
	}

	public void CopyTo(Array JGTIHIJPMRI, int PSPJIJNTMOI)
	{
	}

	public void OnDeserialization(object KMJOPIEMFRK)
	{
	}

	protected SerializableDictionaryBase(SerializationInfo RQQHGKJRQNR, StreamingContext OREERJJJFSO)
	{
	}

	public void GetObjectData(SerializationInfo RQQHGKJRQNR, StreamingContext OREERJJJFSO)
	{
	}
}
