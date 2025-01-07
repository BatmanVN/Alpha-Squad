using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ProfanityFilter.Interfaces;

namespace ProfanityFilter
{
	public class ProfanityFilter : ProfanityBase, IProfanityFilter
	{
		public IAllowList AllowList { get; }

		public ProfanityFilter()
		{
		}

		public ProfanityFilter(string[] profanityList)
		{
		}

		public ProfanityFilter(List<string> profanityList)
		{
		}

		public bool IsProfanity(string word)
		{
			return false;
		}

		public ReadOnlyCollection<string> DetectAllProfanities(string sentence)
		{
			return null;
		}

		public ReadOnlyCollection<string> DetectAllProfanities(string sentence, bool removePartialMatches)
		{
			return null;
		}

		public string CensorString(string sentence)
		{
			return null;
		}

		public string CensorString(string sentence, char censorCharacter)
		{
			return null;
		}

		public string CensorString(string sentence, char censorCharacter, bool ignoreNumbers)
		{
			return null;
		}

		public (int, int, string)? GetCompleteWord(string toCheck, string profanity)
		{
			return null;
		}

		public bool ContainsProfanity(string term)
		{
			return false;
		}

		private StringBuilder CensorStringByProfanityList(char censorCharacter, List<string> swearList, StringBuilder censored, StringBuilder tracker, bool ignoreNumeric)
		{
			return null;
		}

		private List<string> FilterSwearListForCompleteWordsOnly(string sentence, List<string> swearList)
		{
			return null;
		}

		private List<string> FilterWordListByAllowList(string[] words)
		{
			return null;
		}

		private static string ConvertWordListToSentence(List<string> postAllowList)
		{
			return null;
		}

		private void AddMultiWordProfanities(List<string> swearList, string postAllowListSentence)
		{
		}

		private static string CreateCensoredString(string word, char censorCharacter)
		{
			return null;
		}
	}
}
