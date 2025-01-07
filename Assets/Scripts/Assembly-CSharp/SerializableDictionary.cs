using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[Serializable]
public class SerializableDictionary<TKey, TValue> : SerializableDictionaryBase<TKey, TValue, TValue>
{
	public SerializableDictionary()
	{
	}

	public SerializableDictionary(IDictionary<TKey, TValue> PPQGHNLPIPM)
	{
	}

	protected SerializableDictionary(SerializationInfo RQQHGKJRQNR, StreamingContext OREERJJJFSO)
	{
	}

	protected override TValue RKQINGQKGLT(TValue[] NJKGLQPOPSL, int KQQINSRPRNP)
	{
		return default(TValue);
	}

	protected override void OOEEOGMFKNG(TValue[] NJKGLQPOPSL, int KQQINSRPRNP, TValue RRPSNPOTQNT)
	{
	}
}
[Serializable]
public class SerializableDictionary<TKey, TValue, TValueStorage> : SerializableDictionaryBase<TKey, TValue, TValueStorage> where TValueStorage : FIESFKOGOTT.JNJLNPJLNEP<TValue>, new()
{
	public SerializableDictionary()
	{
	}

	public SerializableDictionary(IDictionary<TKey, TValue> PPQGHNLPIPM)
	{
	}

	protected SerializableDictionary(SerializationInfo RQQHGKJRQNR, StreamingContext OREERJJJFSO)
	{
	}

	protected override TValue RKQINGQKGLT(TValueStorage[] NJKGLQPOPSL, int KQQINSRPRNP)
	{
		return default(TValue);
	}

	protected override void OOEEOGMFKNG(TValueStorage[] NJKGLQPOPSL, int KQQINSRPRNP, TValue RRPSNPOTQNT)
	{
	}
}
