using System.Collections;
using System.Collections.Generic;

namespace SayKitInternal
{
	public class SayKitAdsInfoBuffer<T> : IEnumerable<T>, IEnumerable
	{
		private readonly Queue<T> _queue;

		private readonly int _maxCount;

		public SayKitAdsInfoBuffer(int maxCount)
		{
		}

		public void Add(T item)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
