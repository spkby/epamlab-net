using System;
using System.IO;
using System.Text;

namespace Strings1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string signPlus = " + ";
            const string signMinus = " - ";
            const char delimiter = ';';
            const string resultHead = "result(";
            const string resultTail = ") = ";
            const string errorHead = "error-lines = ";
            const string path = @"..\..\in2.csv";
            int resultHeadLenght = resultHead.Length;

            StringBuilder resultLine = new StringBuilder(resultHead);

            double result = 0.0;
            int errorLines = 0;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] elements = line.Split(delimiter);

                        int index = 0;
                        double number = 0.0;

                        try
                        {
                            index = int.Parse(elements[0]);

                            if (index < 0 || index >= elements.Length)
                            {
                                errorLines++;
                                continue;
                            }

                            number = double.Parse(elements[index]);
                        }
                        catch (FormatException)
                        {
                            errorLines++;
                            continue;
                        }

                        result += number;

                        if (resultLine.Length > resultHeadLenght)
                        {
                            resultLine.Append(number < 0 ? signMinus : signPlus).Append(Math.Abs(number));
                        }
                        else
                        {
                            resultLine.Append(number);
                        }
                    }
                }

                resultLine.Append(resultTail + result);

                Console.WriteLine(resultLine);
                Console.WriteLine(errorHead + errorLines);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                Console.Read();
            }
        }
    }
}