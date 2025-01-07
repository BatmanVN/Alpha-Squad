using System;
using Microsoft.SolverFoundation.Common;

namespace EarClipperLib
{
	public class Vector3m : ICloneable
	{
		internal DynamicProperties DynamicProperties;

		public Rational X { get; set; }

		public Rational Y { get; set; }

		public Rational Z { get; set; }

		public Vector3m(Rational x, Rational y, Rational z)
		{
		}

		public Vector3m(Vector3m v)
		{
		}

		public static Vector3m Zero()
		{
			return null;
		}

		public Vector3m Absolute()
		{
			return null;
		}

		public object Clone()
		{
			return null;
		}

		public void ImplizitNegated()
		{
		}

		public Vector3m Negated()
		{
			return null;
		}

		public Vector3m Plus(Vector3m a)
		{
			return null;
		}

		public Vector3m Minus(Vector3m a)
		{
			return null;
		}

		public Vector3m Times(Rational a)
		{
			return null;
		}

		public Vector3m DividedBy(Rational a)
		{
			return null;
		}

		public Rational Dot(Vector3m a)
		{
			return default(Rational);
		}

		public Vector3m Lerp(Vector3m a, Rational t)
		{
			return null;
		}

		public double Length()
		{
			return 0.0;
		}

		public Rational LengthSquared()
		{
			return default(Rational);
		}

		public Vector3m ShortenByLargestComponent()
		{
			return null;
		}

		public Vector3m Cross(Vector3m a)
		{
			return null;
		}

		internal bool IsZero()
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

		public static Vector3m operator +(Vector3m a, Vector3m b)
		{
			return null;
		}

		public static Vector3m operator -(Vector3m a, Vector3m b)
		{
			return null;
		}

		public static Vector3m operator *(Vector3m a, Rational d)
		{
			return null;
		}

		public static Vector3m operator /(Vector3m a, Rational d)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static Vector3m PlaneNormal(Vector3m v0, Vector3m v1, Vector3m v2)
		{
			return null;
		}

		public bool SameDirection(Vector3m he)
		{
			return false;
		}
	}
}
