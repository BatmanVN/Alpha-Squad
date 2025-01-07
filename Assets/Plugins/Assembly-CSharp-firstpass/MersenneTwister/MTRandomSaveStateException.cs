using System;

namespace MersenneTwister
{
	internal class MTRandomSaveStateException : Exception
	{
		private string msg;

		private string stkTrace;

		public override string StackTrace => null;

		public override string Message => null;

		public MTRandomSaveStateException(string MyBaseMessage, string stackTrace)
		{
		}
	}
}
