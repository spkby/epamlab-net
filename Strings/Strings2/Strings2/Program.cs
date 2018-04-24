using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings2
{
	class Program
	{
		static void Main(string[] args)
		{
			string pathIn = @"..\..\in.txt";
			string pathOut = @"..\..\out.txt";

			try
			{
				using (StreamReader reader = new StreamReader(pathIn))
				using (StreamWriter writer = new StreamWriter(pathOut))
				{
					AbstractFormat money = new MoneyFormat();
					AbstractFormat date = new DateFormat();
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						writer.WriteLine(date.Parse(money.Parse(line)));
					}
				}
			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("File not found");
				Console.Read();
			}

		}
	}
}