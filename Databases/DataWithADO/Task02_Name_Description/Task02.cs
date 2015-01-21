namespace Task02_Name_Description
{
    using System;
    using System.Data.SqlClient;

    class Task02
    {
        static void Main(string[] args)
        {
            //2.Write a program that retrieves the name and description of all categories in the Northwind DB.
            SqlConnection databaseConnection = new SqlConnection("Server=.\\; " + "Database=Northwind; Integrated Security=true");            
            databaseConnection.Open();

            using (databaseConnection)
            {
                SqlCommand categoryInfoCommand = new SqlCommand("SELECT CategoryName, Description FROM Categories;", databaseConnection);
                SqlDataReader reader = categoryInfoCommand.ExecuteReader();

                using (reader)
                {
                    int rowCount = 1;
                    while (reader.Read())
                    {
                        string Name = (string)reader["CategoryName"];
                        string Description = (string)reader["Description"];
                        Console.WriteLine("Row {0} : {1} - {2}", rowCount++, Name, Description);
                    }
                }               
            }
        }
    }
}
