using System;
using System.Numerics;

namespace MersenneTwister
{
	public class MTRandom
	{
		[Serializable]
		public class MTState
		{
			public int mti;

			public uint[] mt;
		}

		private BigInteger int128SignedIntMaxValue;

		private BigInteger twoToThe128power;

		public MTState state;

		private Random rng;

		private const int N = 624;

		private const int M = 397;

		private const uint MATRIX_A = 2567483615u;

		private const uint UPPER_MASK = 2147483648u;

		private const uint LOWER_MASK = 2147483647u;

		private const int kDiffMN = -227;

		private const int Nuplim = 623;

		private const int Muplim = 396;

		private const int Nplus1 = 625;

		private const int NuplimLess1 = 622;

		private const int NuplimLessM = 226;

		private uint[] mag01;

		private const int k2_8 = 256;

		private const int k2_16 = 65536;

		private const int k2_24 = 16777216;

		private const double k2_31 = 2147483648.0;

		private const double k2_32 = 4294967296.0;

		private const double k2_32b = 4294967295.0;

		private const uint kDefaultSeed = 5489u;

		private const double kMT_1 = 2.3283064370807974E-10;

		private const double kMT_2 = 2.3283064365386963E-10;

		private const double kMT_3 = 2.3283064365386963E-10;

		private const double kMT_res53 = 1.1102230246251565E-16;

		private const double kMT_Gap = 5E-13;

		private const double kMT_Gap2 = 1E-12;

		private const double kMT_GapInterval = 0.999999999999;

		private const double kMT_2b = 2.3283064370784694E-10;

		private const double kMT_2c = 2.3283064370784694E-10;

		private const double kMT_3b = 2.3283064370784694E-10;

		private const double kMT_4b = 4.656612874161595E-10;

		private const double kMT_5b = 4.656612874156939E-10;

		public MTRandom()
		{
		}

		public MTRandom(uint seed)
		{
		}

		public MTRandom(ref uint[] array)
		{
		}

		public MTRandom(bool dummy)
		{
		}

		public MTRandom(double dummy)
		{
		}

		public MTRandom(string fileName)
		{
		}

		public void init_random(bool reSeedFromClock)
		{
		}

		public void init_by_crypto(double dummy)
		{
		}

		public void saveState(string fileName)
		{
		}

		public void loadState(string fileName)
		{
		}

		private void init_int128SignedInt()
		{
		}

		public void init_genrand(uint seed)
		{
		}

		public void init_by_array(ref uint[] init_key)
		{
		}

		public int genrand_int32SignedInt()
		{
			return 0;
		}

		public uint genrand_int32()
		{
			return 0u;
		}

		public int genrand_int31()
		{
			return 0;
		}

		public double genrand_real1()
		{
			return 0.0;
		}

		public double genrand_real2()
		{
			return 0.0;
		}

		public double genrand_real3()
		{
			return 0.0;
		}

		public double genrand_res53()
		{
			return 0.0;
		}

		public double genrand_real2b()
		{
			return 0.0;
		}

		public double genrand_real2c()
		{
			return 0.0;
		}

		public double genrand_real3b()
		{
			return 0.0;
		}

		public double genrand_real4b()
		{
			return 0.0;
		}

		public double genrand_real5b()
		{
			return 0.0;
		}

		public uint genrand_intMax(uint N)
		{
			return 0u;
		}

		public uint genrand_intRange(uint lower, uint upper)
		{
			return 0u;
		}

		public ulong genrand_int64()
		{
			return 0uL;
		}

		public BigInteger genrand_int128SignedInt()
		{
			return default(BigInteger);
		}
	}
}
