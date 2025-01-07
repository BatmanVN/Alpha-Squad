using Microsoft.SolverFoundation.Common;

namespace EarClipperLib
{
	internal class Misc
	{
		public static int GetOrientation(Vector3m v0, Vector3m v1, Vector3m v2, Vector3m normal)
		{
			return 0;
		}

		public static int IsBetween(Vector3m Origin, Vector3m a, Vector3m b, Vector3m testPoint, Vector3m normal)
		{
			return 0;
		}

		public static bool PointInOrOnTriangle(Vector3m prevPoint, Vector3m curPoint, Vector3m nextPoint, Vector3m nonConvexPoint, Vector3m normal)
		{
			return false;
		}

		public static Rational PointLineDistance(Vector3m p1, Vector3m p2, Vector3m p3)
		{
			return default(Rational);
		}
	}
}
