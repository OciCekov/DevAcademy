namespace Task06_Excel
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Task06
    {
        static void Main()
        {
            OleDbConnection dbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=C:\Users\Kremena\Documents\Visual Studio 2013\Projects\_SQL\T7_ADO.NET\VS2013\T7_ADO.NET\Task06_Excel\table.xlsx;Extended Properties=""Excel 12.0 XML;HDR=Yes""");
            OleDbCommand myCommand = new OleDbCommand("select * from [Sheet1$]", dbConn);
            dbConn.Open();

            //First way

            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["Name"];
                double score = (double)reader["Score"];
                Console.WriteLine("{0} - score: {1}", name, score);
            }
            
            dbConn.Close();

            //Second way
            dbConn.Open();
            Console.WriteLine();
            Console.WriteLine("The other way");
            Console.WriteLine("----------");

            DataTable dataSet = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [Sheet1$]", dbConn);
            adapter.Fill(dataSet);
            foreach (DataRow item in dataSet.Rows)
            {
                Console.WriteLine("{0}|{1}", item.ItemArray[0], item.ItemArray[1]);
            }
            dbConn.Close();
        }
    }
}
