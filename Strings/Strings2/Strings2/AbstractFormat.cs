﻿using System.Text;
using System.Text.RegularExpressions;

namespace Strings2
{
	abstract class AbstractFormat
	{
		private Regex regex;

		public AbstractFormat(string pattern)
		{
			regex = new Regex(pattern, RegexOptions.IgnoreCase);
		}

		public string Parse(string input)
		{
			StringBuilder line = new StringBuilder(input);
			MatchCollection matches = regex.Matches(line.ToString());

			foreach (Match match in matches)
			{
				GroupCollection groups = match.Groups;
				line = line.Replace(groups[GetGroup()].Value, GetReplacement(groups));
			}

			return line.ToString();
		}

		public static string ReplaceAll(string str, string regex, string dest)
		{
			return Regex.Replace(str, regex, dest);
		}

		protected abstract string GetReplacement(GroupCollection groups);

		protected abstract int GetGroup();
	}
}
