using System.Collections.Generic;
using Microsoft.SolverFoundation.Common;

namespace EarClipperLib
{
	public class EarClipping
	{
		private Polygon _mainPointList;

		private List<Polygon> _holes;

		private Vector3m Normal;

		public List<Vector3m> Result { get; private set; }

		public void SetPoints(List<Vector3m> points, List<List<Vector3m>> holes = null, Vector3m normal = null)
		{
		}

		private void CalcNormal(List<Vector3m> points)
		{
		}

		private void LinkAndAddToList(Polygon polygon, List<Vector3m> points)
		{
		}

		public void Triangulate()
		{
		}

		private bool PointsOnLine(Polygon pointList)
		{
			return false;
		}

		private bool IsConvex(ConnectionEdge curPoint)
		{
			return false;
		}

		private void ProcessHoles()
		{
		}

		private void InsertNewEdges(ConnectionEdge insertionEdge, ConnectionEdge m)
		{
		}

		private void GetVisiblePoints(int holeIndex, List<Polygon> polygons, out ConnectionEdge M, out ConnectionEdge P)
		{
			M = null;
			P = null;
		}

		private ConnectionEdge FindVisiblePoint(Candidate I, List<Polygon> polygons, ConnectionEdge M, Vector3m direction)
		{
			return null;
		}

		private ConnectionEdge FindMinimumAngle(List<ConnectionEdge> candidates, Vector3m M, Vector3m direction)
		{
			return null;
		}

		private Candidate FindPointI(ConnectionEdge M, List<Polygon> polygons, int holeIndex, Vector3m direction)
		{
			return null;
		}

		private ConnectionEdge FindLargest(Polygon testHole)
		{
			return null;
		}

		private bool IsPointInTriangle(Vector3m prevPoint, Vector3m curPoint, Vector3m nextPoint, List<ConnectionEdge> nonConvexPoints)
		{
			return false;
		}

		private List<ConnectionEdge> FindNonConvexPoints(Polygon p)
		{
			return null;
		}

		public bool RaySegmentIntersection(out Vector3m intersection, out Rational distanceSquared, Vector3m linePoint1, Vector3m lineVec1, Vector3m linePoint3, Vector3m linePoint4, Vector3m direction)
		{
			intersection = null;
			distanceSquared = default(Rational);
			return false;
		}
	}
}
