using System.Collections.Generic;

namespace ProfanityFilter
{
	public class ProfanityBase
	{
		protected List<string> _profanities;

		private readonly string[] _wordList;

		public int Count => 0;

		public ProfanityBase()
		{
		}

		protected ProfanityBase(string[] profanityList)
		{
		}

		protected ProfanityBase(List<string> profanityList)
		{
		}

		public void AddProfanity(string profanity)
		{
		}

		public void AddProfanity(string[] profanityList)
		{
		}

		public void AddProfanity(List<string> profanityList)
		{
		}

		public bool RemoveProfanity(string profanity)
		{
			return false;
		}

		public bool RemoveProfanity(List<string> profanities)
		{
			return false;
		}

		public bool RemoveProfanity(string[] profanities)
		{
			return false;
		}

		public void Clear()
		{
		}
	}
}
