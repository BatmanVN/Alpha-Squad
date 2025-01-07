using System.Collections.Generic;
using System.Collections.ObjectModel;
using ProfanityFilter.Interfaces;

namespace ProfanityFilter
{
	public class AllowList : IAllowList
	{
		private List<string> _allowList;

		public ReadOnlyCollection<string> ToList => null;

		public int Count => 0;

		public void Add(string wordToAllowlist)
		{
		}

		public bool Contains(string wordToCheck)
		{
			return false;
		}

		public void Clear()
		{
		}

		public bool Remove(string wordToRemove)
		{
			return false;
		}
	}
}
