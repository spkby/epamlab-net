using System;

namespace Database
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var path = System.Environment.CurrentDirectory + @"\..\..\";
            Console.WriteLine(path);

            var conn = Ado.GetConnection(path);

            var listLenNums = Ado.GetList(conn);

            Ado.Insert(listLenNums, conn);

            var listWhereLenMoreThanNum = Ado.GetWhereLenMoreThanNum(conn);

            foreach (var lenNum in listWhereLenMoreThanNum)
            {
                Console.WriteLine(lenNum);
            }
        }
    }
}