using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Database
{
    public class Ado
    {
        private const string insert = "insert into Frequencies (len,num) values (@len,@num)";
        private const string clear = "delete from Frequencies";
        private const string calcLen = "Int(ABS(x1 - x2) + 0.5)";

        private const string selectLenNum = "SELECT " + calcLen + " AS len, Count(*) AS num"
                                            + " FROM Coordinates GROUP BY " + calcLen + " ORDER BY 1";

        private const string selectWhereLenMoreThanNum =
            "SELECT len,num FROM Frequencies WHERE len > num";

        private const string errorDeleteFromFrequencies = "Error delete from Frequencies";
        private const string errorInsertIntoFrequencies = "Error insert into Frequencies";

        private static OleDbCommand cmd;

        public static OleDbConnection GetConnection(string path)
        {
            var connectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "db1.mdb";
            return new OleDbConnection(connectionString);
        }

        public static List<LenNum> GetList(OleDbConnection conn)
        {
            List<LenNum> list = new List<LenNum>();

            try
            {
                cmd = new OleDbCommand(selectLenNum, conn);

                OleDbDataReader dataReader = cmd.ExecuteReader();

                while (dataReader != null && dataReader.Read())
                {
                    int len = (int) dataReader.GetDouble(0);
                    int num = dataReader.GetInt32(1);
                    list.Add(new LenNum(len, num));
                }
            }
            catch (OleDbException e)
            {
                throw new DbException(e.Message);
            }

            return list;
        }

        private static void Clear(OleDbConnection conn)
        {
            try
            {
                cmd = new OleDbCommand(clear, conn);

                int res = cmd.ExecuteNonQuery();
                if (res == -1)
                {
                    throw new DbException(errorDeleteFromFrequencies);
                }
            }
            catch (OleDbException e)
            {
                throw new DbException(e.Message);
            }
        }

        public static void Insert(List<LenNum> list, OleDbConnection conn)
        {
            try
            {
                Clear(conn);
                cmd = new OleDbCommand(insert, conn);

                OleDbParameter len = new OleDbParameter();
                OleDbParameter num = new OleDbParameter();

                len.ParameterName = "@len";
                num.ParameterName = "@num";

                cmd.Parameters.Add(len);
                cmd.Parameters.Add(num);

                foreach (LenNum lenNum in list)
                {
                    len.Value = lenNum.Len;
                    num.Value = lenNum.Num;

                    int res = cmd.ExecuteNonQuery();
                    if (res == -1)
                    {
                        throw new DbException(errorInsertIntoFrequencies);
                    }
                }
            }
            catch (OleDbException e)
            {
                throw new DbException(e.Message);
            }
        }

        public static List<LenNum> GetWhereLenMoreThanNum(OleDbConnection conn)
        {
            List<LenNum> list = new List<LenNum>();

            try
            {
                cmd = new OleDbCommand(selectWhereLenMoreThanNum, conn);

                OleDbDataReader dataReader = cmd.ExecuteReader();

                while (dataReader != null && dataReader.Read())
                {
                    int len = dataReader.GetInt32(0);
                    int num = dataReader.GetInt32(1);
                    list.Add(new LenNum(len, num));
                }
            }
            catch (OleDbException e)
            {
                throw new DbException(e.Message);
            }

            return list;
        }
    }
}