using System;
using System.Collections.Generic;
using System.Linq;

namespace HtmlAnalysis.Implementations
{
	public class WordsStatistics : AbstractWordsStatistics
	{
		private IDictionary<string, int> stats = new Dictionary<string, int>();

		public override void AddWord(string word)
		{
			if (string.IsNullOrEmpty(word)) return;
			int count;
			stats[word.ToLower()] = stats.TryGetValue(word.ToLower(), out count) ? count + 1 : 1;
		}

		public override IEnumerable<Tuple<int, string>> GetStatistics()
		{
			return stats.OrderByDescending(kv => kv.Value).ThenBy(kv => kv.Key).Select(kv => Tuple.Create(kv.Value, kv.Key));
		}
	}
}