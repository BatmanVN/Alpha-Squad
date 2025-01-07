using System;
using System.Threading;

namespace SayKitInternal
{
	public class SKThreadService
	{
		private static SKThreadService _instance;

		private readonly SynchronizationContext _synchronizationContext;

		private static bool IsMainThread => false;

		public static SKThreadService Instance { get; }

		private SKThreadService()
		{
		}

		public void RunOnMainThread(Action action)
		{
		}

		public T RunOnMainThreadWithResult<T>(Func<T> action)
		{
			return default(T);
		}
	}
}
