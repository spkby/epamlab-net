using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings2
{
	class DateFormat : AbstractFormat
	{
		public DateFormat() : base(patternDate)
		{
		}
		private char[] patternDelimiter = new char[] { '-', '/', '.' };
		private const string century = "20";

    private const string patternDatePoint = @"([0-3]?[0-9]\.[0-1]?[0-9]\.(?:[0-9]{2})?[0-9]{2})\b";
    private const string patternDateSlash = @"([0-3]?[0-9]\/[0-1]?[0-9]\/(?:[0-9]{2})?[0-9]{2})\b";
    private const string patternDateHyphen = @"([0-3]?[0-9]\-[0-1]?[0-9]\-(?:[0-9]{2})?[0-9]{2})\b";

    private const string patternDate = patternDateHyphen + "|" + patternDatePoint + "|" + patternDateSlash;

    private const int group = 0;

	protected override int GetGroup()
		{
			return group;
		}

		protected override string GetReplacement(GroupCollection groups)
		{
			string oldDate = groups[GetGroup()].Value;
			string[] strings = oldDate.Split(patternDelimiter);

			int day = Int32.Parse(strings[0]);
			int month = Int32.Parse(strings[1]);
			int year = Int32.Parse((strings[2].Length == 2 ? century : "") + strings[2]);

			if (!IsDate(day, month, year))
			{
				return oldDate;
			}

			DateTime dateTime = new DateTime(year, month, day);

			return (dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")));
		}

		private bool IsDate(int day, int month, int year)
		{
			bool isDate = true;

			if ((month > 12 || month <= 0) && (day > 31 || day >= 0))
			{
				isDate = false;
			}

			try
			{
				DateTime dateTime = new DateTime(year, month, day);
			}
			catch (ArgumentOutOfRangeException)
			{
				isDate = false;
			}

			return isDate;
		}
	}
}
