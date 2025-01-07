using System.Collections.Generic;

namespace EarClipperLib
{
	internal class Polygon
	{
		internal ConnectionEdge Start;

		internal int PointCount;

		internal IEnumerable<ConnectionEdge> GetPolygonCirculator()
		{
			return null;
		}

		internal void Remove(ConnectionEdge cur)
		{
		}

		public bool Contains(Vector3m vector2M, out Vector3m res)
		{
			res = null;
			return false;
		}
	}
}
