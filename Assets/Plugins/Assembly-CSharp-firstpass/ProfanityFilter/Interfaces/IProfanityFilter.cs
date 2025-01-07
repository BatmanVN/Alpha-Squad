using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProfanityFilter.Interfaces
{
	public interface IProfanityFilter
	{
		IAllowList AllowList { get; }

		int Count { get; }

		bool IsProfanity(string word);

		ReadOnlyCollection<string> DetectAllProfanities(string sentence);

		ReadOnlyCollection<string> DetectAllProfanities(string sentence, bool removePartialMatches);

		bool ContainsProfanity(string term);

		string CensorString(string sentence);

		string CensorString(string sentence, char censorCharacter);

		string CensorString(string sentence, char censorCharacter, bool ignoreNumbers);

		(int, int, string)? GetCompleteWord(string toCheck, string profanity);

		void AddProfanity(string profanity);

		void AddProfanity(string[] profanityList);

		void AddProfanity(List<string> profanityList);

		bool RemoveProfanity(string profanity);

		bool RemoveProfanity(List<string> profanities);

		bool RemoveProfanity(string[] profanities);

		void Clear();
	}
}
