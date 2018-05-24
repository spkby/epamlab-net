using System.Text.RegularExpressions;

namespace Strings2
{
    class MoneyFormat : AbstractFormat
    {
        public MoneyFormat() : base(PatternMoney)
        {
        }

        private const string PatternMoney = @"(^|\s+)(\d{1,3}(\s+\d{3})*\s+)(blr|belarusian)";
        private const string PatternSpaces = @"\s+";
        private const string NoSpace = "";
        private const string Space = " ";
        private const int Group = 2;

        protected override string GetReplacement(GroupCollection groups)
        {
            return (Regex.Replace(groups[Group].Value, PatternSpaces, NoSpace) + Space);
        }

        protected override int GetGroup()
        {
            return Group;
        }
    }
}