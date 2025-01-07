using System;
using System.Collections.Generic;
using UnityEngine;

namespace Coffee.UIExtensions
{
	public class MaterialCache
	{
		public static List<MaterialCache> materialCaches;

		public ulong hash { get; private set; }

		public int referenceCount { get; private set; }

		public Texture texture { get; private set; }

		public Material material { get; private set; }

		public static MaterialCache Register(ulong hash, Texture texture, Func<Material> onCreateMaterial)
		{
			return null;
		}

		public static MaterialCache Register(ulong hash, Func<Material> onCreateMaterial)
		{
			return null;
		}

		public static void Unregister(MaterialCache cache)
		{
		}
	}
}
