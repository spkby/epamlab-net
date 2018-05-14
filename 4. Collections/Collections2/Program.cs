using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Collections2
{
    internal class Program
    {
        private const string path = @"..\..\in.txt";
        private const string fileNotFound = "File not found";
        private const string pattern = @"[\s(;)]+";

        private const int positionX1 = 1; 
        private const int positionX2 = 2; 
        private const int positionY1 = 3; 
        private const int positionY2 = 4; 

        public static void Main(string[] args)
        {
            var lines = new LenNumCollections();
            try
            {
                using (var sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var strings = new Regex(pattern).Split(line);
                        var x1 = double.Parse(strings[positionX1]);
                        var x2 = double.Parse(strings[positionX2]);
                        var y1 = double.Parse(strings[positionY1]);
                        var y2 = double.Parse(strings[positionY2]);
                        lines.Add(Utils.CalcLen(x1,x2,y1,y2));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(fileNotFound);
            }
            Console.WriteLine(lines.Print());
        }
    }
}