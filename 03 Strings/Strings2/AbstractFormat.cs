using System.Text;
using System.Text.RegularExpressions;

namespace Strings2
{
    abstract class AbstractFormat
    {
        private readonly Regex _regex;

        public AbstractFormat(string pattern)
        {
            _regex = new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public string Parse(string input)
        {
            StringBuilder line = new StringBuilder(input);
            MatchCollection matches = _regex.Matches(line.ToString());

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                line = line.Replace(groups[GetGroup()].Value, GetReplacement(groups));
            }

            return line.ToString();
        }

        protected abstract string GetReplacement(GroupCollection groups);

        protected abstract int GetGroup();
    }
}