using System;

namespace SayKitInternal
{
	[Serializable]
	public class ConversionResponseData
	{
		public ConversionConfig config;

		public ConversionSKADValues[] skadValues;

		public SKCommand[] commands;
	}
}
