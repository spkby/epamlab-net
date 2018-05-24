using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Database
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var path = Environment.CurrentDirectory + @"\..\..\";
            /* 
             * Environment.CurrentDirectory - need for ConnectionString.
             * If path without Environment.CurrentDirectory, ConnectionString is wrong.
            */

            OleDbConnection conn = Ado.GetConnection(path);

            try
            {
                conn.Open();

                List<LenNum> listLenNums = Ado.GetList(conn);

                Ado.Insert(listLenNums, conn);

                List<LenNum> listWhereLenMoreThanNum = Ado.GetWhereLenMoreThanNum(conn);

                Console.WriteLine("len > num");
                foreach (LenNum lenNum in listWhereLenMoreThanNum)
                {
                    Console.WriteLine(lenNum);
                }
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DbException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

                Console.Read();
            }
        }
    }
}