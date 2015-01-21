namespace Task03_AgainAboutNorthwind
{
    using System;
    using System.Data.SqlClient;

    class Task03
    {
        //3.Write a program that retrieves from the Northwind database all product categories and the names of the products in each category. Can you do this with a single SQL query (with table join)?
        static void Main(string[] args)
        {
            SqlConnection databaseConnection = new SqlConnection("Server=.\\; " + "Database=Northwind; Integrated Security=true");
            databaseConnection.Open();

            using (databaseConnection)
            {
                SqlCommand queryAboutNorthwind = new SqlCommand("SELECT c.CategoryName, p.ProductName FROM Categories c inner join Products p on c.CategoryID = p.CategoryID;", databaseConnection);
                SqlDataReader reader = queryAboutNorthwind.ExecuteReader();

                using (reader)
                {
                    int rowCount = 1;
                    while (reader.Read())
                    {
                        string catName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];
                        Console.WriteLine("Row {0} : {1} - {2}", rowCount++, catName, productName);
                    }
                }
            }
        }
    }
}
