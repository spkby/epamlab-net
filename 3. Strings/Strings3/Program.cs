using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Strings3
{
    internal static class Program
    {
        public static void Main()
        {
            // match quotation
            const string quotation = "('.*')|(\".*\")";
            // match miltilines comment
            const string multiLinesCommnent = @"(\/\*([\s\S]*?)\*\/)";
            // match line comments
            const string lineComment = @"(\/\/.*\n)";

            const string pattern = quotation + "|" + multiLinesCommnent + "|" + lineComment;

            const int groupMultiLinesCommnent = 3;
            const int groupLineComment = 5;

            var newLine = Environment.NewLine;
            const string emptyStr = "";

            const string pathIn = @"..\..\input.txt";
            const string pathOut = @"..\..\output.txt";

            try
            {
                using (var reader = new StreamReader(pathIn))
                using (var writer = new StreamWriter(pathOut))
                {
                    var lines = new StringBuilder(reader.ReadToEnd());
                    var regex = new Regex(pattern);
                    var matches = regex.Matches(lines.ToString());

                    foreach (Match match in matches)
                    {
                        var groups = match.Groups;
                        if (groups[groupMultiLinesCommnent].Value.Length > 0)
                        {
                            lines.Replace(groups[groupMultiLinesCommnent].Value, emptyStr);
                        }

                        if (groups[groupLineComment].Value.Length > 0)
                        {
                            lines.Replace(groups[groupLineComment].Value, newLine);
                        }
                    }

                    writer.Write(lines);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
