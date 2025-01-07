using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SayKitInternal
{
	public class SayKitDoubleConverter : CustomCreationConverter<double>
	{
		public override double Create(Type objectType)
		{
			return 0.0;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
