using System;

namespace MersenneTwister
{
	internal class MTRandomLoadStateException : Exception
	{
		private string msg;

		private string stkTrace;

		public override string StackTrace => null;

		public override string Message => null;

		public MTRandomLoadStateException(string MyBaseMessage, string stackTrace)
		{
		}
	}
}
