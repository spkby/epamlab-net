using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Strings2
{
    class DateFormat : AbstractFormat
    {
        public DateFormat() : base(PatternDate)
        {
        }

        private readonly char[] _delimiters = {'-', '/', '.'};
        private const string Century = "20";

        private const string PatternDatePoint = @"([0-3]?[0-9]\.[0-1]?[0-9]\.(?:[0-9]{2})?[0-9]{2})\b";
        private const string PatternDateSlash = @"([0-3]?[0-9]\/[0-1]?[0-9]\/(?:[0-9]{2})?[0-9]{2})\b";
        private const string PatternDateHyphen = @"([0-3]?[0-9]\-[0-1]?[0-9]\-(?:[0-9]{2})?[0-9]{2})\b";

        private const string PatternDate = PatternDateHyphen + "|" + PatternDatePoint + "|" + PatternDateSlash;

        private const int Group = 0;

        protected override int GetGroup()
        {
            return Group;
        }

        protected override string GetReplacement(GroupCollection groups)
        {
            string oldDate = groups[GetGroup()].Value;
            string[] strings = oldDate.Split(_delimiters);

            int day = int.Parse(strings[0]);
            int month = int.Parse(strings[1]);
            int year = int.Parse((strings[2].Length == 2 ? Century : "") + strings[2]);

            if (!IsDate(day, month, year))
            {
                return oldDate;
            }

            DateTime dateTime = new DateTime(year, month, day);

            return (dateTime.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")));
        }

        private bool IsDate(int day, int month, int year)
        {
            bool isDate = !(month > 12 || month <= 0 || day > 31 || day <= 0);

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