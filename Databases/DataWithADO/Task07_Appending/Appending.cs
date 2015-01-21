namespace Task07_Appending
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Appending
    {
        //7.Implement appending new rows to the Excel file.
        static void Main()
        {
            OleDbConnection dbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=C:\Users\Kremena\Documents\Visual Studio 2013\Projects\_SQL\T7_ADO.NET\VS2013\T7_ADO.NET\Task07_Appending\table.xlsx; Extended Properties=""Excel 12.0 XML;HDR=Yes""");
            
            for (int i = 1; i < 10; i++)
            {
                InsertDataIntoEcxel("Nakov" + i, i, dbConn);
            }
        }

        static void InsertDataIntoEcxel(string name, double score, OleDbConnection connection)
        {
            OleDbCommand myCommand = new OleDbCommand("INSERT INTO [Sheet1$] (Name,Score) VALUES (@Name,@Score)", connection);
            connection.Open();

            myCommand.Parameters.AddWithValue("@Name", name);
            myCommand.Parameters.AddWithValue("@Score", score);
            myCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}
