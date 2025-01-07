namespace EarClipperLib
{
	internal class ConnectionEdge
	{
		internal ConnectionEdge Prev;

		internal ConnectionEdge Next;

		internal Vector3m Origin { get; private set; }

		internal Polygon Polygon { get; set; }

		protected bool Equals(ConnectionEdge other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public ConnectionEdge(Vector3m p0, Polygon parentPolygon)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal void AddIncidentEdge(ConnectionEdge next)
		{
		}
	}
}
