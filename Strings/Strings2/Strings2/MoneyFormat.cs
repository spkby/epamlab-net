using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings2
{
	class MoneyFormat : AbstractFormat
	{
		public MoneyFormat() : base(patternMoney)
		{
		}

		private const string patternMoney = @"(^|\s+)(\d+(\s+\d{3})*\s+)(blr|belarusian)";
    private const string patternSpaces = @"\s+";
    private const string noSpace = "";
		private const string space = " ";
		private const int group = 2;

		protected override string GetReplacement(GroupCollection groups)
		{
			return (Regex.Replace(groups[group].Value, patternSpaces, noSpace) + space);
		}

		protected override int GetGroup()
		{
			return group;
		}
	}
}
