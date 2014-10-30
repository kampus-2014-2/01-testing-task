using System;
using System.Collections.Generic;

namespace HtmlAnalysis
{
	public abstract class AbstractWordsStatistics : WordsStatistics_Tests
	{
		public abstract void AddWord(string word);
		/**
		<summary>
		Частотный словарь добавленных слов. 
		Слова сравниваются без учета регистра символов. 
		Порядок — по убыванию частоты слова.
		При одинаковой частоте — в лексикографическом порядке.
		</summary>
		*/
		public abstract IEnumerable<Tuple<int, string>> GetStatistics();
	}
}
