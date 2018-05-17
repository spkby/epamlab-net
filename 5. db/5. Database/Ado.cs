using System.Data.OleDb;

namespace Collections2
{
    public class Ado
    {
        private const string connectionString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""D:\dev\projects\epamlab-net\5. db\5. Database\db1.mdb""";

        private const string insertFrequenciesCmd = "insert into Frequencies (number,line_id) values (?,?)";
        private const string updateFrequenciesCmd = "update Frequencies where line_id = ?";
        private const string clearFrequenciesCmd = "delete from Frequencies";

        private const string clearCoordinatesCmd = "delete from Coordinates";
        private const string insertCoordinatesCmd = "insert into Coordinates (x1,x2,y1,y2) values (?,?,?,?)";


        private const string selectCmd = "SELECT ... AS len, Count(*) AS num FROM Coordinates GROUP BY ... ORDER BY ... ";

        public void add(OleDbCommand cmd, OleDbConnection conn)
        {
            
        }
    }
}