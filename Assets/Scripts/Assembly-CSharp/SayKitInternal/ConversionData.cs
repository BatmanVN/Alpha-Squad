using System;
using System.Collections.Generic;

namespace SayKitInternal
{
	[Serializable]
	public class ConversionData
	{
		public ConversionConfig config;

		public List<ConversionSKADValues> skadValues;

		public List<string> commandHashes;
	}
}
