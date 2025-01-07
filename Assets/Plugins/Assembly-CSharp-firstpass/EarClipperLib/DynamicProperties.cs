using System.Collections.Generic;

namespace EarClipperLib
{
	internal class DynamicProperties
	{
		private Dictionary<PropertyConstants, object> _properties;

		public int Count => 0;

		internal void AddProperty(PropertyConstants key, object value)
		{
		}

		internal bool ExistsKey(PropertyConstants key)
		{
			return false;
		}

		internal object GetValue(PropertyConstants key)
		{
			return null;
		}

		internal void ChangeValue(PropertyConstants key, object value)
		{
		}

		internal void Clear()
		{
		}

		internal void RemoveKey(PropertyConstants key)
		{
		}
	}
}
