using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings1
{
	class Program
	{
		static void Main(string[] args)
		{
			string signPlus = " + ";
			string signMinus = " - ";
			char delimiter = ';';
			string resultHead = "result(";
			string resultTail = ") = ";
			string errorHead = "error-lines = ";
			string path = @"..\..\in2.csv";
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
							index = Int32.Parse(elements[0]);

							if (index < 0 || index >= elements.Length)
							{
								errorLines++;
								continue;
							}

							number = Double.Parse(elements[index]);
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
				Console.Read();
			}
			catch(FileNotFoundException)
			{
				Console.WriteLine("File not found");
				Console.Read();
			}

			}
	}
}
