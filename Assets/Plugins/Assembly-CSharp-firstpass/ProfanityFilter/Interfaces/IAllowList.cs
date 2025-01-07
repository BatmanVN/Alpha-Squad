using System.Collections.ObjectModel;

namespace ProfanityFilter.Interfaces
{
	public interface IAllowList
	{
		int Count { get; }

		ReadOnlyCollection<string> ToList { get; }

		void Add(string wordToAllowlist);

		bool Contains(string wordToCheck);

		bool Remove(string wordToRemove);

		void Clear();
	}
}
