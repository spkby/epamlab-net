using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings2
{
	class DateFormat : Format
	{
		public DateFormat() : base(patternDate)
		{
		}

		private string[] months = new string[]{
            null, "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
    };

		private char[] patternDelimiter = new char[] { '-', '/', '.' };
    private const string century = "20";

    private const string patternDatePoint = @"([0-3]?[0-9]\.[0-1]?[0-9]\.(?:[0-9]{2})?[0-9]{2})";
    private const string patternDateSlash = @"([0-3]?[0-9]\/[0-1]?[0-9]\/(?:[0-9]{2})?[0-9]{2})";
    private const string patternDateHyphen = @"([0-3]?[0-9]\-[0-1]?[0-9]\-(?:[0-9]{2})?[0-9]{2})";

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

			if((Int32.Parse(strings[1]) >12 || Int32.Parse(strings[1]) <= 0)
				&& (Int32.Parse(strings[0]) > 31 || Int32.Parse(strings[0]) >= 0))
			{
				return oldDate;
			}

			string month = months[Int32.Parse(strings[1])];

			string day = (Int32.Parse(strings[0])).ToString();

			string year = strings[2].Length > 2 ? strings[2] : century + strings[2];

			return (month + " " + day + ", " + year);
		}
	}
}
