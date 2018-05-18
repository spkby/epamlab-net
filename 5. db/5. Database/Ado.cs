using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Database
{
    public class Ado
    {
        private const string insert = "insert into Frequencies (len,num) values (@len,@num)";
        private const string clear = "delete from Frequencies";

        private const string selectLenNum =
            "SELECT ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)) AS len, Count(*) AS num FROM Coordinates" +
            " GROUP BY x1,x2,y1,y2 ORDER BY len";

        private const string selectWhereLenMoreThanNum =
            "SELECT len,num FROM Frequencies WHERE len > num";

        private const string errorDeleteFromFrequencies = "Error delete from Frequencies";

        private static OleDbCommand cmd;

        public static OleDbConnection GetConnection(string path)
        {
            var connectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "db1.mdb";
            return new OleDbConnection(connectionString);
        }

        public static IEnumerable<LenNum> GetList(OleDbConnection conn)
        {
            var list = new List<LenNum>();

            try
            {
                cmd = new OleDbCommand(selectLenNum, conn);
                conn.Open();
                
                // TODO: ! No value given for one or more required parameters.

                var dataReader = cmd.ExecuteReader();

                while (dataReader != null && dataReader.Read())
                {
                    var len = dataReader.GetInt32(0);
                    var num = dataReader.GetInt32(1);
                    list.Add(new LenNum(len, num));
                }
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return list;
        }

        private static void Clear(OleDbConnection conn)
        {
            try
            {
                cmd = new OleDbCommand(clear, conn);
                conn.Open();
                var res = cmd.ExecuteNonQuery();
                if (res == -1)
                {
                    
                    throw new Exception(errorDeleteFromFrequencies);
                }
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void Insert(IEnumerable<LenNum> list, OleDbConnection conn)
        {
            try
            {
                Clear(conn);

                conn.Open();

                foreach (var lenNum in list)
                {
                    cmd = new OleDbCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@len", lenNum.Len);
                    cmd.Parameters.AddWithValue("@num", lenNum.Num);
                    var res = cmd.ExecuteNonQuery();
                    if (res == -1)
                    {
                        Console.WriteLine("Error insert");
                    }
                }
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static IEnumerable<LenNum> GetWhereLenMoreThanNum(OleDbConnection conn)
        {
            var list = new List<LenNum>();

            try
            {
                cmd = new OleDbCommand(selectWhereLenMoreThanNum, conn);
                conn.Open();
                var dataReader = cmd.ExecuteReader();

                while (dataReader != null && dataReader.Read())
                {
                    var len = dataReader.GetInt32(0);
                    var num = dataReader.GetInt32(1);
                    list.Add(new LenNum(len, num));
                }
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return list;
        }
    }
}